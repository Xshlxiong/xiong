//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Geometry
{
    [Serializable]
    public class PointMsg : Message
    {
        public const string k_RosMessageName = "geometry_msgs/Point";

        //  This contains the position of a point in free space
        public double x;
        public double y;
        public double z;

        public PointMsg()
        {
            this.x = 0.0;
            this.y = 0.0;
            this.z = 0.0;
        }

        public PointMsg(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static PointMsg Deserialize(MessageDeserializer deserializer) => new PointMsg(deserializer);

        private PointMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.x);
            deserializer.Read(out this.y);
            deserializer.Read(out this.z);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.x);
            serializer.Write(this.y);
            serializer.Write(this.z);
        }

        public override string ToString()
        {
            return "PointMsg: " +
            "\nx: " + x.ToString() +
            "\ny: " + y.ToString() +
            "\nz: " + z.ToString();
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