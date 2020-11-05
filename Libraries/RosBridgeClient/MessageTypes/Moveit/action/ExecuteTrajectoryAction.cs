/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class ExecuteTrajectoryAction : Action<ExecuteTrajectoryActionGoal, ExecuteTrajectoryActionResult, ExecuteTrajectoryActionFeedback, ExecuteTrajectoryGoal, ExecuteTrajectoryResult, ExecuteTrajectoryFeedback>
    {
        public const string RosMessageName = "moveit_msgs/ExecuteTrajectoryAction";

        public ExecuteTrajectoryAction() : base()
        {
            this.action_goal = new ExecuteTrajectoryActionGoal();
            this.action_result = new ExecuteTrajectoryActionResult();
            this.action_feedback = new ExecuteTrajectoryActionFeedback();
        }

    }
}