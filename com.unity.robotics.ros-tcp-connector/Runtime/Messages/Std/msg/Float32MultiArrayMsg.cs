//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Std
{
    [Serializable]
    public class Float32MultiArrayMsg : Message
    {
        public const string k_RosMessageName = "std_msgs/Float32MultiArray";


        //  This was originally provided as an example message.
        //  It is deprecated as of Foxy
        //  It is recommended to create your own semantically meaningful message.
        //  However if you would like to continue using this please use the equivalent in example_msgs.
        //  Please look at the MultiArrayLayout message definition for
        //  documentation on all multiarrays.
        public MultiArrayLayoutMsg layout;
        //  specification of data layout
        public float[] data;
        //  array of data

        public Float32MultiArrayMsg()
        {
            this.layout = new MultiArrayLayoutMsg();
            this.data = new float[0];
        }

        public Float32MultiArrayMsg(MultiArrayLayoutMsg layout, float[] data)
        {
            this.layout = layout;
            this.data = data;
        }

        public Float32MultiArrayMsg(MessageDeserializer deserializer)
        {
            this.layout = new MultiArrayLayoutMsg(deserializer);
            deserializer.Read(out this.data, sizeof(float), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.layout);
            serializer.WriteLength(this.data);
            serializer.Write(this.data);
        }

        public override string ToString()
        {
            return "Float32MultiArrayMsg: " +
            "\nlayout: " + layout.ToString() +
            "\ndata: " + System.String.Join(", ", data.ToList());
        }

        public static Float32MultiArrayMsg Deserialize(MessageDeserializer deserializer)
        {
            return new Float32MultiArrayMsg(deserializer);
        }

        #if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
        #else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
        #endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
