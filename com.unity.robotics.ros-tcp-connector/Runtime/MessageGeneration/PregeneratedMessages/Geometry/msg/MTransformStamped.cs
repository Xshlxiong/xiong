//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Geometry
{
    public class MTransformStamped : Message
    {
        public const string k_RosMessageName = "geometry_msgs/TransformStamped";
        public override string RosMessageName => k_RosMessageName;

        //  This expresses a transform from coordinate frame header.frame_id
        //  to the coordinate frame child_frame_id
        // 
        //  This message is mostly used by the 
        //  <a href="http://wiki.ros.org/tf">tf</a> package. 
        //  See its documentation for more information.
        public MHeader header;
        public string child_frame_id;
        //  the frame id of the child frame
        public MTransform transform;

        public MTransformStamped()
        {
            this.header = new MHeader();
            this.child_frame_id = "";
            this.transform = new MTransform();
        }

        public MTransformStamped(MHeader header, string child_frame_id, MTransform transform)
        {
            this.header = header;
            this.child_frame_id = child_frame_id;
            this.transform = transform;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(SerializeString(this.child_frame_id));
            listOfSerializations.AddRange(transform.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            var child_frame_idStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.child_frame_id = DeserializeString(data, offset, child_frame_idStringBytesLength);
            offset += child_frame_idStringBytesLength;
            offset = this.transform.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "MTransformStamped: " +
            "\nheader: " + header.ToString() +
            "\nchild_frame_id: " + child_frame_id.ToString() +
            "\ntransform: " + transform.ToString();
        }

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        static void OnLoad()
        {
            MessageRegistry.Register<MTransformStamped>(k_RosMessageName);
        }
    }
}