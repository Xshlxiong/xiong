//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;

namespace RosMessageTypes.Geometry
{
    public class Polygon : Message
    {
        public const string RosMessageName = "geometry_msgs/Polygon";

        // A specification of a polygon where the first and last points are assumed to be connected
        public Point32[] points;

        public Polygon()
        {
            this.points = new Point32[0];
        }

        public Polygon(Point32[] points)
        {
            this.points = points;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            
            listOfSerializations.Add(BitConverter.GetBytes(points.Length));
            foreach(var entry in points)
                listOfSerializations.Add(entry.Serialize());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            
            var pointsArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.points= new Point32[pointsArrayLength];
            for(var i = 0; i < pointsArrayLength; i++)
            {
                this.points[i] = new Point32();
                offset = this.points[i].Deserialize(data, offset);
            }

            return offset;
        }

        public override string ToString()
        {
            return "Polygon: " +
            "\npoints: " + points.ToString();
        }
    }
}
