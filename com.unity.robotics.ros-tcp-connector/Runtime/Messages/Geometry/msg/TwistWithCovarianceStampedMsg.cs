//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Geometry
{
    [Serializable]
    public class TwistWithCovarianceStampedMsg : Message
    {
        public const string k_RosMessageName = "geometry_msgs/TwistWithCovarianceStamped";

        //  This represents an estimated twist with reference coordinate frame and timestamp.
        public HeaderMsg header;
        public TwistWithCovarianceMsg twist;

        public TwistWithCovarianceStampedMsg()
        {
            this.header = new HeaderMsg();
            this.twist = new TwistWithCovarianceMsg();
        }

        public TwistWithCovarianceStampedMsg(HeaderMsg header, TwistWithCovarianceMsg twist)
        {
            this.header = header;
            this.twist = twist;
        }

        public static TwistWithCovarianceStampedMsg Deserialize(MessageDeserializer deserializer) => new TwistWithCovarianceStampedMsg(deserializer);

        private TwistWithCovarianceStampedMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            this.twist = TwistWithCovarianceMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.twist);
        }

        public override string ToString()
        {
            return "TwistWithCovarianceStampedMsg: " +
            "\nheader: " + header.ToString() +
            "\ntwist: " + twist.ToString();
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
