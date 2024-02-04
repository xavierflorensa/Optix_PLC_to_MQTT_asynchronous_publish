<a name="_toc157191124"></a>Optix PLC to MQTT
### Contents
[1.	Configuring an application as an MQTT client](#_toc157245591)

[2.	PLC data and MQTT](#_toc157245592)


# <a name="_toc157245591"></a>1. Configuring an application as an MQTT client

This example is using a cloud public broker like test.mosquitto.org

The Optix application is both subscribed and publishing to the same topic

Go to help

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 001](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/4645020b-9549-417e-b3df-0302cf6d33a3)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 002](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/94f0f968-aeb9-4fa6-a2ce-6c3a26f3e0ed)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 003](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/8002c684-71e5-4082-a316-86de4042145a)

<https://www.rockwellautomation.com/docs/en/factorytalk-optix/1-00/contents-ditamap/developing-solutions/customizing-projects-with-csharp/csharp-application-examples/configure-an-application-as-an-mqtt-client.html>

**Tip:** You can download a sample project from here: <https://www.rockwellautomation.com/docs/en/factorytalk-optix/1-00/contents-ditamap/developing-solutions/_resources/ExampleApplication-MQTTClient.zip>

Let’s try opening the example

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 004](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/6593daec-e23c-4ef1-ad71-056b580608a2)

Click on “Publish”

It works

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 005](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/9fb6a237-4870-4d0d-860b-f6da3e3bcef4)

But let’s look at the details

Like PublisherLogic

Double click on PublisherLogic

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 006](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/44c16096-710f-4dcc-91b8-c5ed9f33477b)

Visual Studio code opens

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 007](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/9ff2685b-8c09-4257-8c6d-28c607732022)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 008](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/13443d1f-2eba-4dcb-87e9-7640f31c1451)

Look at BrokerIpAddress under UI

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 009](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/e83f82c0-f437-44d0-866e-38b1e4ca3dd6)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 010](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/66424b25-ca03-4f39-a583-5efb84f79312)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 011](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/fd069dff-a887-4441-ac54-2fe9f11dccc6)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 012](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/1d2b924f-7e2c-412c-b8e0-781530a4ea6b)

So we are publishing a random value to mosquito on the cloud

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 013](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/300e0e5c-e3df-4ac4-8529-57b1688442b5)

We are publishing to Topic /my\_topic

Let’s check it with Node-RED. Yes, if we click on “Publish” the we receive the data

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 014](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/3b8d128d-23fb-44f9-a935-627cba54e5aa)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 015](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/18fa9281-b93b-4793-8580-d1c3af5d0e6b)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 016](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/f6571139-8d50-4c4f-bb8d-27b6bdbf3b3a)

Let’s test the subscription from Optix application

Yes, if we inject on Node-RED, the Optix Application gets the value

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 017](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/e1b0ea1c-dff7-4cdc-b8b4-58f4a13b2533)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 018](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/0a610a8d-cfc0-4fe3-9537-3ae73f04c661)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 019](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/88737abb-695f-4647-908f-574d572c2164)

Next step is to use PLC data
# <a name="_toc157191125"></a><a name="_toc157245592"></a>2. PLC data and MQTT

This is what we will do on this example

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 020](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/0873666b-b248-4dd3-9af3-029a079beb6c)

You an find the code here

<https://github.com/xavierflorensa/PLC2MQTTClient_HiveMQ_v1_Git>

We will create an EtherNet/IP driver on same MQTT sample project

Let’s take a look on how to work in our project with the variables provided by MQTT

Reading the subscribed variable

Create a new Texbox

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 021](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/e27ef561-2e3d-4589-b983-6bdeea8db422)
On properties point to Model.variable1

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 022](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/36e214a2-58f5-4b49-a376-dbc6f45d3cea)

Like this

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 023](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/7e5bdfb6-c7c3-4d56-871d-6c83853972c9)


And on the other hand let’s try to write to MQTT from PLC data

First let’s get PLC data

<https://www.rockwellautomation.com/docs/en/factorytalk-optix/1-00/contents-ditamap/getting-started/quick-start/configure-variables/import-tag-variables.html>

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 024](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/77064d20-d034-4c88-82a6-5955fffe7b2e)

First of all create a communications driver

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 025](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/1e412caf-1cf8-4752-bc23-71f9b0791e0f)

Add a new station

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 026](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/0ade5d47-1a1e-44a3-9322-63f7d7ae3e81)

Go to configure connected device

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 027](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/3f4ef696-6c1d-47f1-a610-78581131b55f)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 028](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/3261b443-538b-4f5a-8abf-30d91542cdfe)

Continue as we did on previous sections 2 until you reach this point

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 029](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/ed1db1fc-d2d4-449c-a378-3c95925945e5)
Verify that the Tag is there

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 030](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/c497498b-cb5b-41c8-88a9-57c7221b5611)

Now let’s display the PLC data on a new text label

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 031](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/efbf4e04-413c-4ea6-ab81-2e48bcbba712)
Now let’s try to publish the data from PLC variable

We did a try that is publishing PLC data to Mosquitto, without writing any script, just with dynamic links:

Modify the value on the PLC

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 032](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/5922a917-c95f-44f8-9b3a-34ebd174f72d)

Then look at the Optix application

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 033](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/51f22616-17d5-4827-88dc-919e5062aa5b)

We wanted just to write on the PLC, but on the other hand if we click the button publish, then we are writing a random value on the PLC!!!

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 034](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/597736a6-be26-438a-a9a2-87d1ac843762)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 035](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/b17b2629-ee1a-4163-bcfa-c25086fef787)

This is how to make this link

Just go to the Variable1 properties under model

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 036](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/cd7058cf-dea6-492c-9af3-5ed18d2cb210)

Then edit the link

Like this

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 037](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/8542bad4-6092-498d-b0da-fe1c852c8fdf)

You will get this

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 038](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/5b917097-4ffa-4d15-ad86-44f1b0a2bd1c)

And that’s all, you have the variables linked in both directions

But the problem when writing to the PLC is that the variable is random. Let’s try to be our desired value entered by the operator on Optix.

Now we are able to write the desired value on the PLC as soon as we hit enter

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 039](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/457b9b2a-0d99-4929-b2e5-8011e1992e91)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 040](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/78fb2088-296f-4373-8afb-4d4730154ec0)
Let’s see how to do it

Let’s create an editable Label

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 041](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/e758b88b-1014-4bf8-9e79-26e624643e11)
Like this

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 042](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/3220d529-65db-4b59-9b8f-ca91e01e7363)
And on the text property, link to the variable 

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 043](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/1ea1bc06-6b6f-4202-9598-071a12956139)

We are still writing a random variable with the publish button.

In order to cancel this we can try to comment this line on the code

Click on the code icon

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 044](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/51b51430-9859-4deb-8861-9a7dc2fdcb90)

And comment this line

Then save on Visual Studio Code

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 045](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/01825444-5bb0-46d6-aa2e-cbe2fcbd5dff)

Now click on play and try

No more random publishing.

But you do not need to click the publish button to write on the PLC.

But you have to click on publish in order to send per MQTT

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 046](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/0943e424-7e91-4e04-b99f-429944d85908)

But we are not yet able to write on the PLC from an MQTT client like a mobile phone.

We have to do two steps

First of all, modify on the subscriber code  this line

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 047](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/feade160-5a2e-4099-88a1-73dc78194807)
And leaving like this

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 048](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/c0435249-fb1f-4843-8a02-c73f68f78aba)

Then save on Visual Studio Code

Now we do not have the string like before

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 049](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/bebfcaf4-a8ad-49c0-aec8-b1cc79487cdb)

On the other hand, we have to link the variable Message to the PLC Tag like this

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 050](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/dda91072-f722-49c8-8db8-49c2aaf5f870)

Now we are writing on the PLC from a MQTT client like a Mobile Phone

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 051](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/32543bac-cf40-429e-b2ee-cb79ad6cfeb6)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 052](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/cbfc4045-ffc8-4229-96bd-ff9a635568e0)

![Aspose Words faea257d-ffd2-4c25-b4b1-a8553f3d92b0 053](https://github.com/xavierflorensa/Optix_PLC_to_MQTT/assets/55208134/bb8e93bf-067b-46e8-8f30-59d72f43dee5)

As you can see on this video

<https://youtu.be/u6EEDMmJJBU>

You can find the code here

<https://github.com/xavierflorensa/PLC2MQTTClient_HiveMQ_v1_Git>

# Asyncrhonous Publish

You may want to publish to MQTT broker each time you modify the PLC variable

You can do it with a callback function that executes a publish when Variable1 is modified.

This way

On same project delete the publish button 

Copy the publish method code and insert it on a publish function

Also change the topic name from /my\_topic to /my\_new\_topic

So use this code on the publisher side

```C#
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

```


Test the application

Changing the value from PLC or from Optix

![A screenshot of a computer

Description automatically generated](Aspose.Words.a01b5d69-7112-47d4-9db7-d09b87ae33cf.054.png)

But what happens when you change the PLC value from your MQTT client as a mobile phone,

The value is published twice, first time from mobile phone and second time from Optix, since Optix subscribe script will publish everything that is received thru MQTT

This way, change the value from mobile phone MQTT client app

![A screenshot of a computer

Description automatically generated](Aspose.Words.a01b5d69-7112-47d4-9db7-d09b87ae33cf.055.png)

This may be corrected from C#, but this will be done some other day…

You can find the code here

<https://github.com/xavierflorensa/Optix_PLC_to_MQTT_asynchronous_publish>


