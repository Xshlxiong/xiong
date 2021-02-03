//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Collections.Generic;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Std
{
    public class Time : Message
    {
        public const string RosMessageName = "std_msgs/Time";
        public uint secs;
        public uint nsecs;

        public Time()
        {
            secs = 0;
            nsecs = 0;
        }

        public Time(uint secs, uint nsecs)
        {
            this.secs = secs;
            this.nsecs = nsecs;
        }

        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.secs));
            listOfSerializations.Add(BitConverter.GetBytes(this.nsecs));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.secs = BitConverter.ToUInt32(data, offset);
            offset += 4;
            this.nsecs = BitConverter.ToUInt32(data, offset);
            offset += 4;

            return offset;
        }
    }
}
