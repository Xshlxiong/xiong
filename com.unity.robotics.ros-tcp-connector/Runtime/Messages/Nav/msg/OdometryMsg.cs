//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Nav
{
    [Serializable]
    public class OdometryMsg : Message
    {
        public const string k_RosMessageName = "nav_msgs/Odometry";

        //  This represents an estimate of a position and velocity in free space.  
        //  The pose in this message should be specified in the coordinate frame given by header.frame_id.
        //  The twist in this message should be specified in the coordinate frame given by the child_frame_id
        public HeaderMsg header;
        public string child_frame_id;
        public Geometry.PoseWithCovarianceMsg pose;
        public Geometry.TwistWithCovarianceMsg twist;

        public OdometryMsg()
        {
            this.header = new HeaderMsg();
            this.child_frame_id = "";
            this.pose = new Geometry.PoseWithCovarianceMsg();
            this.twist = new Geometry.TwistWithCovarianceMsg();
        }

        public OdometryMsg(HeaderMsg header, string child_frame_id, Geometry.PoseWithCovarianceMsg pose, Geometry.TwistWithCovarianceMsg twist)
        {
            this.header = header;
            this.child_frame_id = child_frame_id;
            this.pose = pose;
            this.twist = twist;
        }

        public static OdometryMsg Deserialize(MessageDeserializer deserializer) => new OdometryMsg(deserializer);

        private OdometryMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.child_frame_id);
            this.pose = Geometry.PoseWithCovarianceMsg.Deserialize(deserializer);
            this.twist = Geometry.TwistWithCovarianceMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.child_frame_id);
            serializer.Write(this.pose);
            serializer.Write(this.twist);
        }

        public override string ToString()
        {
            return "OdometryMsg: " +
            "\nheader: " + header.ToString() +
            "\nchild_frame_id: " + child_frame_id.ToString() +
            "\npose: " + pose.ToString() +
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
