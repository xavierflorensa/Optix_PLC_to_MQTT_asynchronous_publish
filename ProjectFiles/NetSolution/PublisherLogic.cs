#region StandardUsing
using System;
using FTOptix.CoreBase;
using FTOptix.HMIProject;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.OPCUAServer;
#endregion
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;

public class PublisherLogic : BaseNetLogic
{
    private IUAVariable variable1;
    public override void Start()
    {
        var brokerIpAddressVariable = Project.Current.GetVariable("Model/BrokerIpAddress");

        // Create a client connecting to the broker (default port is 1883)
        publishClient = new MqttClient(brokerIpAddressVariable.Value);
        // Connect to the broker
        publishClient.Connect("FTOptixPublishClient");
        // Assign a callback to be executed when a message is published to the broker
        publishClient.MqttMsgPublished += PublishClientMqttMsgPublished;
         variable1 = Project.Current.GetVariable("Model/Variable1");
        //assing a callback function to be executed when the variable changes
        variable1.VariableChange += variable1_VariableChange;
    }

    public override void Stop()
    {
        publishClient.Disconnect();
        publishClient.MqttMsgPublished -= PublishClientMqttMsgPublished;
        variable1.VariableChange -= variable1_VariableChange;
    }

    private void PublishClientMqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
    {
        Log.Info("Message " + e.MessageId + " - published = " + e.IsPublished);
    }

     private void variable1_VariableChange(object sender, VariableChangeEventArgs e)
    {
        Log.Info("Variable has changed");
        var variable1 = Project.Current.GetVariable("Model/Variable1");
        //variable1.Value = new Random().Next(0, 101);

        // Publish a message
        ushort msgId = publishClient.Publish("/my_new_topic", // topic
            System.Text.Encoding.UTF8.GetBytes(((int)variable1.Value).ToString()), // message body
            MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
            false); // retained
    }
    
    private MqttClient publishClient;
}
