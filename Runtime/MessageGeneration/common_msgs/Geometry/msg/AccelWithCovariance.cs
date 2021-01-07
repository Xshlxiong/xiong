//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;

namespace RosMessageTypes.Geometry
{
    public class AccelWithCovariance : Message
    {
        public const string RosMessageName = "geometry_msgs/AccelWithCovariance";

        //  This expresses acceleration in free space with uncertainty.
        public Accel accel;
        //  Row-major representation of the 6x6 covariance matrix
        //  The orientation parameters use a fixed-axis representation.
        //  In order, the parameters are:
        //  (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)
        public double[] covariance;

        public AccelWithCovariance()
        {
            this.accel = new Accel();
            this.covariance = new double[36];
        }

        public AccelWithCovariance(Accel accel, double[] covariance)
        {
            this.accel = accel;
            this.covariance = covariance;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(accel.SerializationStatements());
            
            Array.Resize(ref covariance, 36);
            foreach(var entry in covariance)
                listOfSerializations.Add(BitConverter.GetBytes(entry));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.accel.Deserialize(data, offset);
            
            this.covariance= new double[36];
            for(var i = 0; i < 36; i++)
            {
                this.covariance[i] = BitConverter.ToDouble(data, offset);
                offset += 8;
            }

            return offset;
        }

        public override string ToString()
        {
            return "AccelWithCovariance: " +
            "\naccel: " + accel.ToString() +
            "\ncovariance: " + covariance.ToString();
        }
    }
}
