//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.UnityInterfaces
{
    [Serializable]
    public class RosUnityTopicListResponse : Message
    {
        public const string k_RosMessageName = "unity_interfaces/RosUnityTopicList";


        public string[] topics;

        public RosUnityTopicListResponse()
        {
            this.topics = new string[0];
        }

        public RosUnityTopicListResponse(string[] topics)
        {
            this.topics = topics;
        }

        public RosUnityTopicListResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.topics, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.topics);
            serializer.Write(this.topics);
        }

        public override string ToString()
        {
            return "RosUnityTopicListResponse: " +
            "\ntopics: " + System.String.Join(", ", topics.ToList());
        }

        public static RosUnityTopicListResponse Deserialize(MessageDeserializer deserializer)
        {
            return new RosUnityTopicListResponse(deserializer);
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
