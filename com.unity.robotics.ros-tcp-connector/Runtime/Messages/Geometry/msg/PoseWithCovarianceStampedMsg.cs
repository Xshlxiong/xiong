//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Geometry
{
    [Serializable]
    public class PoseWithCovarianceStampedMsg : Message
    {
        public const string k_RosMessageName = "geometry_msgs/PoseWithCovarianceStamped";

        //  This expresses an estimated pose with a reference coordinate frame and timestamp
        public Std.HeaderMsg header;
        public PoseWithCovarianceMsg pose;

        public PoseWithCovarianceStampedMsg()
        {
            this.header = new Std.HeaderMsg();
            this.pose = new PoseWithCovarianceMsg();
        }

        public PoseWithCovarianceStampedMsg(Std.HeaderMsg header, PoseWithCovarianceMsg pose)
        {
            this.header = header;
            this.pose = pose;
        }

        public static PoseWithCovarianceStampedMsg Deserialize(MessageDeserializer deserializer) => new PoseWithCovarianceStampedMsg(deserializer);

        private PoseWithCovarianceStampedMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            this.pose = PoseWithCovarianceMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.pose);
        }

        public override string ToString()
        {
            return "PoseWithCovarianceStampedMsg: " +
            "\nheader: " + header.ToString() +
            "\npose: " + pose.ToString();
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
