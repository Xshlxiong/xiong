//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Nav
{
    [Serializable]
    public class GetPlanRequest : Message
    {
        public const string k_RosMessageName = "nav_msgs/GetPlan";

        //  Get a plan from the current position to the goal Pose 
        //  The start pose for the plan
        public Geometry.PoseStampedMsg start;
        //  The final pose of the goal position
        public Geometry.PoseStampedMsg goal;
        //  If the goal is obstructed, how many meters the planner can 
        //  relax the constraint in x and y before failing. 
        public float tolerance;

        public GetPlanRequest()
        {
            this.start = new Geometry.PoseStampedMsg();
            this.goal = new Geometry.PoseStampedMsg();
            this.tolerance = 0.0f;
        }

        public GetPlanRequest(Geometry.PoseStampedMsg start, Geometry.PoseStampedMsg goal, float tolerance)
        {
            this.start = start;
            this.goal = goal;
            this.tolerance = tolerance;
        }

        public static GetPlanRequest Deserialize(MessageDeserializer deserializer) => new GetPlanRequest(deserializer);

        private GetPlanRequest(MessageDeserializer deserializer)
        {
            this.start = Geometry.PoseStampedMsg.Deserialize(deserializer);
            this.goal = Geometry.PoseStampedMsg.Deserialize(deserializer);
            deserializer.Read(out this.tolerance);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.start);
            serializer.Write(this.goal);
            serializer.Write(this.tolerance);
        }

        public override string ToString()
        {
            return "GetPlanRequest: " +
            "\nstart: " + start.ToString() +
            "\ngoal: " + goal.ToString() +
            "\ntolerance: " + tolerance.ToString();
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
