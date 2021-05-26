//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.BuiltinInterfaces;

namespace RosMessageTypes.Trajectory
{
    [Serializable]
    public class MultiDOFJointTrajectoryPointMsg : Message
    {
        public const string k_RosMessageName = "trajectory_msgs/MultiDOFJointTrajectoryPoint";

        //  Each multi-dof joint can specify a transform (up to 6 DOF)
        public Geometry.TransformMsg[] transforms;
        //  There can be a velocity specified for the origin of the joint 
        public Geometry.TwistMsg[] velocities;
        //  There can be an acceleration specified for the origin of the joint 
        public Geometry.TwistMsg[] accelerations;
        public DurationMsg time_from_start;

        public MultiDOFJointTrajectoryPointMsg()
        {
            this.transforms = new Geometry.TransformMsg[0];
            this.velocities = new Geometry.TwistMsg[0];
            this.accelerations = new Geometry.TwistMsg[0];
            this.time_from_start = new DurationMsg();
        }

        public MultiDOFJointTrajectoryPointMsg(Geometry.TransformMsg[] transforms, Geometry.TwistMsg[] velocities, Geometry.TwistMsg[] accelerations, DurationMsg time_from_start)
        {
            this.transforms = transforms;
            this.velocities = velocities;
            this.accelerations = accelerations;
            this.time_from_start = time_from_start;
        }

        public static MultiDOFJointTrajectoryPointMsg Deserialize(MessageDeserializer deserializer) => new MultiDOFJointTrajectoryPointMsg(deserializer);

        private MultiDOFJointTrajectoryPointMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.transforms, Geometry.TransformMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.velocities, Geometry.TwistMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.accelerations, Geometry.TwistMsg.Deserialize, deserializer.ReadLength());
            this.time_from_start = DurationMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.transforms);
            serializer.Write(this.transforms);
            serializer.WriteLength(this.velocities);
            serializer.Write(this.velocities);
            serializer.WriteLength(this.accelerations);
            serializer.Write(this.accelerations);
            serializer.Write(this.time_from_start);
        }

        public override string ToString()
        {
            return "MultiDOFJointTrajectoryPointMsg: " +
            "\ntransforms: " + System.String.Join(", ", transforms.ToList()) +
            "\nvelocities: " + System.String.Join(", ", velocities.ToList()) +
            "\naccelerations: " + System.String.Join(", ", accelerations.ToList()) +
            "\ntime_from_start: " + time_from_start.ToString();
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
