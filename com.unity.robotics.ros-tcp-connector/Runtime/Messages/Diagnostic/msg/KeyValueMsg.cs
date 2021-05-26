//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Diagnostic
{
    [Serializable]
    public class KeyValueMsg : Message
    {
        public const string k_RosMessageName = "diagnostic_msgs/KeyValue";

        //  What to label this value when viewing.
        public string key;
        //  A value to track over time.
        public string value;

        public KeyValueMsg()
        {
            this.key = "";
            this.value = "";
        }

        public KeyValueMsg(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public static KeyValueMsg Deserialize(MessageDeserializer deserializer) => new KeyValueMsg(deserializer);

        private KeyValueMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.key);
            deserializer.Read(out this.value);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.key);
            serializer.Write(this.value);
        }

        public override string ToString()
        {
            return "KeyValueMsg: " +
            "\nkey: " + key.ToString() +
            "\nvalue: " + value.ToString();
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
