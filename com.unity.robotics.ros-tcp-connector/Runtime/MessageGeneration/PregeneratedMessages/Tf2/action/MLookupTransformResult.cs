//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Tf2
{
    public class MLookupTransformResult : Message
    {
        public const string RosMessageName = "tf2_msgs/LookupTransform";

        public Geometry.MTransformStamped transform;
        public MTF2Error error;

        public MLookupTransformResult()
        {
            this.transform = new Geometry.MTransformStamped();
            this.error = new MTF2Error();
        }

        public MLookupTransformResult(Geometry.MTransformStamped transform, MTF2Error error)
        {
            this.transform = transform;
            this.error = error;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(transform.SerializationStatements());
            listOfSerializations.AddRange(error.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.transform.Deserialize(data, offset);
            offset = this.error.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "MLookupTransformResult: " +
            "\ntransform: " + transform.ToString() +
            "\nerror: " + error.ToString();
        }
    }
}