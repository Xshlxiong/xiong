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
    public class PoseArrayMsg : Message
    {
        public const string k_RosMessageName = "geometry_msgs/PoseArray";

        //  An array of poses with a header for global reference.
        public HeaderMsg header;
        public PoseMsg[] poses;

        public PoseArrayMsg()
        {
            this.header = new HeaderMsg();
            this.poses = new PoseMsg[0];
        }

        public PoseArrayMsg(HeaderMsg header, PoseMsg[] poses)
        {
            this.header = header;
            this.poses = poses;
        }

        public static PoseArrayMsg Deserialize(MessageDeserializer deserializer) => new PoseArrayMsg(deserializer);

        private PoseArrayMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.poses, PoseMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.WriteLength(this.poses);
            serializer.Write(this.poses);
        }

        public override string ToString()
        {
            return "PoseArrayMsg: " +
            "\nheader: " + header.ToString() +
            "\nposes: " + System.String.Join(", ", poses.ToList());
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
