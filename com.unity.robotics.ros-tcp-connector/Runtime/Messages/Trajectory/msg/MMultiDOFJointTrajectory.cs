//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Trajectory
{
    public class MMultiDOFJointTrajectory : Message
    {
        public const string RosMessageName = "trajectory_msgs/MultiDOFJointTrajectory";

        //  The header is used to specify the coordinate frame and the reference time for the trajectory durations
        public MHeader header;
        //  A representation of a multi-dof joint trajectory (each point is a transformation)
        //  Each point along the trajectory will include an array of positions/velocities/accelerations
        //  that has the same length as the array of joint names, and has the same order of joints as 
        //  the joint names array.
        public string[] joint_names;
        public MMultiDOFJointTrajectoryPoint[] points;

        public MMultiDOFJointTrajectory()
        {
            this.header = new MHeader();
            this.joint_names = new string[0];
            this.points = new MMultiDOFJointTrajectoryPoint[0];
        }

        public MMultiDOFJointTrajectory(MHeader header, string[] joint_names, MMultiDOFJointTrajectoryPoint[] points)
        {
            this.header = header;
            this.joint_names = joint_names;
            this.points = points;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());

            listOfSerializations.Add(BitConverter.GetBytes(joint_names.Length));
            foreach (var entry in joint_names)
                listOfSerializations.Add(SerializeString(entry));

            listOfSerializations.Add(BitConverter.GetBytes(points.Length));
            foreach (var entry in points)
                listOfSerializations.Add(entry.Serialize());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);

            var joint_namesArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.joint_names = new string[joint_namesArrayLength];
            for (var i = 0; i < joint_namesArrayLength; i++)
            {
                var joint_namesStringBytesLength = DeserializeLength(data, offset);
                offset += 4;
                this.joint_names[i] = DeserializeString(data, offset, joint_namesStringBytesLength);
                offset += joint_namesStringBytesLength;
            }

            var pointsArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.points = new MMultiDOFJointTrajectoryPoint[pointsArrayLength];
            for (var i = 0; i < pointsArrayLength; i++)
            {
                this.points[i] = new MMultiDOFJointTrajectoryPoint();
                offset = this.points[i].Deserialize(data, offset);
            }

            return offset;
        }

        public override string ToString()
        {
            return "MMultiDOFJointTrajectory: " +
            "\nheader: " + header.ToString() +
            "\njoint_names: " + System.String.Join(", ", joint_names.ToList()) +
            "\npoints: " + System.String.Join(", ", points.ToList());
        }
    }
}