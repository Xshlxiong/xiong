//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Sensor
{
    [Serializable]
    public class PointCloudMsg : Message
    {
        public const string k_RosMessageName = "sensor_msgs/PointCloud";

        //  This message holds a collection of 3d points, plus optional additional
        //  information about each point.
        //  Time of sensor data acquisition, coordinate frame ID.
        public HeaderMsg header;
        //  Array of 3d points. Each Point32 should be interpreted as a 3d point
        //  in the frame given in the header.
        public Geometry.Point32Msg[] points;
        //  Each channel should have the same number of elements as points array,
        //  and the data in each channel should correspond 1:1 with each point.
        //  Channel names in common practice are listed in ChannelFloat32.msg.
        public ChannelFloat32Msg[] channels;

        public PointCloudMsg()
        {
            this.header = new HeaderMsg();
            this.points = new Geometry.Point32Msg[0];
            this.channels = new ChannelFloat32Msg[0];
        }

        public PointCloudMsg(HeaderMsg header, Geometry.Point32Msg[] points, ChannelFloat32Msg[] channels)
        {
            this.header = header;
            this.points = points;
            this.channels = channels;
        }

        public static PointCloudMsg Deserialize(MessageDeserializer deserializer) => new PointCloudMsg(deserializer);

        private PointCloudMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.points, Geometry.Point32Msg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.channels, ChannelFloat32Msg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.WriteLength(this.points);
            serializer.Write(this.points);
            serializer.WriteLength(this.channels);
            serializer.Write(this.channels);
        }

        public override string ToString()
        {
            return "PointCloudMsg: " +
            "\nheader: " + header.ToString() +
            "\npoints: " + System.String.Join(", ", points.ToList()) +
            "\nchannels: " + System.String.Join(", ", channels.ToList());
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
