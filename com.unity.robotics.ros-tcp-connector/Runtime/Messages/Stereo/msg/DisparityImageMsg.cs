//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Stereo
{
    [Serializable]
    public class DisparityImageMsg : Message
    {
        public const string k_RosMessageName = "stereo_msgs/DisparityImage";

        //  Separate header for compatibility with current TimeSynchronizer.
        //  Likely to be removed in a later release, use image.header instead.
        public Std.HeaderMsg header;
        //  Floating point disparity image. The disparities are pre-adjusted for any
        //  x-offset between the principal points of the two cameras (in the case
        //  that they are verged). That is: d = x_l - x_r - (cx_l - cx_r)
        public Sensor.ImageMsg image;
        //  Stereo geometry. For disparity d, the depth from the camera is Z = fT/d.
        public float f;
        //  Focal length, pixels
        public float t;
        //  Baseline, world units
        //  Subwindow of (potentially) valid disparity values.
        public Sensor.RegionOfInterestMsg valid_window;
        //  The range of disparities searched.
        //  In the disparity image, any disparity less than min_disparity is invalid.
        //  The disparity search range defines the horopter, or 3D volume that the
        //  stereo algorithm can "see". Points with Z outside of:
        //      Z_min = fT / max_disparity
        //      Z_max = fT / min_disparity
        //  could not be found.
        public float min_disparity;
        public float max_disparity;
        //  Smallest allowed disparity increment. The smallest achievable depth range
        //  resolution is delta_Z = (Z^2/fT)*delta_d.
        public float delta_d;

        public DisparityImageMsg()
        {
            this.header = new Std.HeaderMsg();
            this.image = new Sensor.ImageMsg();
            this.f = 0.0f;
            this.t = 0.0f;
            this.valid_window = new Sensor.RegionOfInterestMsg();
            this.min_disparity = 0.0f;
            this.max_disparity = 0.0f;
            this.delta_d = 0.0f;
        }

        public DisparityImageMsg(Std.HeaderMsg header, Sensor.ImageMsg image, float f, float t, Sensor.RegionOfInterestMsg valid_window, float min_disparity, float max_disparity, float delta_d)
        {
            this.header = header;
            this.image = image;
            this.f = f;
            this.t = t;
            this.valid_window = valid_window;
            this.min_disparity = min_disparity;
            this.max_disparity = max_disparity;
            this.delta_d = delta_d;
        }

        public static DisparityImageMsg Deserialize(MessageDeserializer deserializer) => new DisparityImageMsg(deserializer);

        private DisparityImageMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            this.image = Sensor.ImageMsg.Deserialize(deserializer);
            deserializer.Read(out this.f);
            deserializer.Read(out this.t);
            this.valid_window = Sensor.RegionOfInterestMsg.Deserialize(deserializer);
            deserializer.Read(out this.min_disparity);
            deserializer.Read(out this.max_disparity);
            deserializer.Read(out this.delta_d);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.image);
            serializer.Write(this.f);
            serializer.Write(this.t);
            serializer.Write(this.valid_window);
            serializer.Write(this.min_disparity);
            serializer.Write(this.max_disparity);
            serializer.Write(this.delta_d);
        }

        public override string ToString()
        {
            return "DisparityImageMsg: " +
            "\nheader: " + header.ToString() +
            "\nimage: " + image.ToString() +
            "\nf: " + f.ToString() +
            "\nt: " + t.ToString() +
            "\nvalid_window: " + valid_window.ToString() +
            "\nmin_disparity: " + min_disparity.ToString() +
            "\nmax_disparity: " + max_disparity.ToString() +
            "\ndelta_d: " + delta_d.ToString();
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
