//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.UnityInterfaces
{
    [Serializable]
    public class RosUnityErrorMsg : Message
    {
        public const string k_RosMessageName = "unity_interfaces/RosUnityError";


        public string message;

        public RosUnityErrorMsg()
        {
            this.message = "";
        }

        public RosUnityErrorMsg(string message)
        {
            this.message = message;
        }

        public RosUnityErrorMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.message);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.message);
        }

        public override string ToString()
        {
            return "RosUnityErrorMsg: " +
            "\nmessage: " + message.ToString();
        }

        public static RosUnityErrorMsg Deserialize(MessageDeserializer deserializer)
        {
            return new RosUnityErrorMsg(deserializer);
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