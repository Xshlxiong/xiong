//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.BuiltinInterfaces;

namespace RosMessageTypes.Nav
{
    [Serializable]
    public class MapMetaDataMsg : Message
    {
        public const string k_RosMessageName = "nav_msgs/MapMetaData";

        //  This hold basic information about the characterists of the OccupancyGrid
        //  The time at which the map was loaded
        public TimeMsg map_load_time;
        //  The map resolution [m/cell]
        public float resolution;
        //  Map width [cells]
        public uint width;
        //  Map height [cells]
        public uint height;
        //  The origin of the map [m, m, rad].  This is the real-world pose of the
        //  cell (0,0) in the map.
        public Geometry.PoseMsg origin;

        public MapMetaDataMsg()
        {
            this.map_load_time = new TimeMsg();
            this.resolution = 0.0f;
            this.width = 0;
            this.height = 0;
            this.origin = new Geometry.PoseMsg();
        }

        public MapMetaDataMsg(TimeMsg map_load_time, float resolution, uint width, uint height, Geometry.PoseMsg origin)
        {
            this.map_load_time = map_load_time;
            this.resolution = resolution;
            this.width = width;
            this.height = height;
            this.origin = origin;
        }

        public static MapMetaDataMsg Deserialize(MessageDeserializer deserializer) => new MapMetaDataMsg(deserializer);

        private MapMetaDataMsg(MessageDeserializer deserializer)
        {
            this.map_load_time = TimeMsg.Deserialize(deserializer);
            deserializer.Read(out this.resolution);
            deserializer.Read(out this.width);
            deserializer.Read(out this.height);
            this.origin = Geometry.PoseMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.map_load_time);
            serializer.Write(this.resolution);
            serializer.Write(this.width);
            serializer.Write(this.height);
            serializer.Write(this.origin);
        }

        public override string ToString()
        {
            return "MapMetaDataMsg: " +
            "\nmap_load_time: " + map_load_time.ToString() +
            "\nresolution: " + resolution.ToString() +
            "\nwidth: " + width.ToString() +
            "\nheight: " + height.ToString() +
            "\norigin: " + origin.ToString();
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
