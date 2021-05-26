//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Std
{
    [Serializable]
    public class Int64MultiArrayMsg : Message
    {
        public const string k_RosMessageName = "std_msgs/Int64MultiArray";


        //  This was originally provided as an example message.
        //  It is deprecated as of Foxy
        //  It is recommended to create your own semantically meaningful message.
        //  However if you would like to continue using this please use the equivalent in example_msgs.
        //  Please look at the MultiArrayLayout message definition for
        //  documentation on all multiarrays.
        public MultiArrayLayoutMsg layout;
        //  specification of data layout
        public long[] data;
        //  array of data

        public Int64MultiArrayMsg()
        {
            this.layout = new MultiArrayLayoutMsg();
            this.data = new long[0];
        }

        public Int64MultiArrayMsg(MultiArrayLayoutMsg layout, long[] data)
        {
            this.layout = layout;
            this.data = data;
        }

        public Int64MultiArrayMsg(MessageDeserializer deserializer)
        {
            this.layout = new MultiArrayLayoutMsg(deserializer);
            deserializer.Read(out this.data, sizeof(long), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.layout);
            serializer.WriteLength(this.data);
            serializer.Write(this.data);
        }

        public override string ToString()
        {
            return "Int64MultiArrayMsg: " +
            "\nlayout: " + layout.ToString() +
            "\ndata: " + System.String.Join(", ", data.ToList());
        }

        public static Int64MultiArrayMsg Deserialize(MessageDeserializer deserializer)
        {
            return new Int64MultiArrayMsg(deserializer);
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
