//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Std
{
    public class MColorRGBA : Message
    {
        public const string k_RosMessageName = "std_msgs/ColorRGBA";
        public override string RosMessageName => k_RosMessageName;

        public float r;
        public float g;
        public float b;
        public float a;

        public MColorRGBA()
        {
            this.r = 0.0f;
            this.g = 0.0f;
            this.b = 0.0f;
            this.a = 0.0f;
        }

        public MColorRGBA(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.r));
            listOfSerializations.Add(BitConverter.GetBytes(this.g));
            listOfSerializations.Add(BitConverter.GetBytes(this.b));
            listOfSerializations.Add(BitConverter.GetBytes(this.a));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.r = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.g = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.b = BitConverter.ToSingle(data, offset);
            offset += 4;
            this.a = BitConverter.ToSingle(data, offset);
            offset += 4;

            return offset;
        }

        public override string ToString()
        {
            return "MColorRGBA: " +
            "\nr: " + r.ToString() +
            "\ng: " + g.ToString() +
            "\nb: " + b.ToString() +
            "\na: " + a.ToString();
        }

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        static void OnLoad()
        {
            MessageRegistry.Register<MColorRGBA>(k_RosMessageName);
        }
    }
}