//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Visualization
{
    [Serializable]
    public class GetInteractiveMarkersRequest : Message
    {
        public const string k_RosMessageName = "visualization_msgs/GetInteractiveMarkers";



        public GetInteractiveMarkersRequest()
        {
        }
        public GetInteractiveMarkersRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "GetInteractiveMarkersRequest: ";
        }

        public static GetInteractiveMarkersRequest Deserialize(MessageDeserializer deserializer)
        {
            return new GetInteractiveMarkersRequest(deserializer);
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
