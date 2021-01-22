using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ROSGeometry
{
    public interface CoordinateSpace
    {
        Vector3 ConvertFromRUF(Vector3 v); // convert this vector from the Unity coordinate space into mine
        Vector3 ConvertToRUF(Vector3 v); // convert from my coordinate space into the Unity coordinate space

        Quaternion ConvertFromRUF(Quaternion q); // convert this quaternion from the Unity coordinate space into mine
        Quaternion ConvertToRUF(Quaternion q); // convert from my coordinate space into the Unity coordinate space
    }

    //RUF is the Unity coordinate space, so no conversion needed
    public class RUF : CoordinateSpace
    {
        public Vector3 ConvertFromRUF(Vector3 v) => v;
        public Vector3 ConvertToRUF(Vector3 v) => v;
        public Quaternion ConvertFromRUF(Quaternion q) => q;
        public Quaternion ConvertToRUF(Quaternion q) => q;
    }

    public class FLU : CoordinateSpace
    {
        public Vector3 ConvertFromRUF(Vector3 v) => new Vector3(v.z, -v.x, v.y);
        public Vector3 ConvertToRUF(Vector3 v) => new Vector3(-v.y, v.z, v.x);
        public Quaternion ConvertFromRUF(Quaternion q) => new Quaternion(q.z, -q.x, q.y, -q.w);
        public Quaternion ConvertToRUF(Quaternion q) => new Quaternion(-q.y, q.z, q.x, -q.w);
    }

    public class NED : CoordinateSpace
    {
        public Vector3 ConvertFromRUF(Vector3 v) => new Vector3(v.z, v.x, -v.y);
        public Vector3 ConvertToRUF(Vector3 v) => new Vector3(v.y, -v.z, v.x);
        public Quaternion ConvertFromRUF(Quaternion q) => new Quaternion(q.z, q.x, -q.y, -q.w);
        public Quaternion ConvertToRUF(Quaternion q) => new Quaternion(q.y, -q.z, q.x, -q.w);
    }

    public class ENU : CoordinateSpace
    {
        public Vector3 ConvertFromRUF(Vector3 v) => new Vector3(v.x, v.z, v.y);
        public Vector3 ConvertToRUF(Vector3 v) => new Vector3(v.x, v.z, v.y);
        public Quaternion ConvertFromRUF(Quaternion q) => new Quaternion(q.x, q.z, q.y, -q.w);
        public Quaternion ConvertToRUF(Quaternion q) => new Quaternion(q.x, q.z, q.y, -q.w);
    }

    public enum CoordinateSpaceSelection
    {
        RUF,
        FLU,
        NED,
        ENU
    }

    public static class CoordinateSpaceExtensions
    {
        public static Vector3<C> To<C>(this Vector3 self)
            where C : CoordinateSpace, new()
        {
            return new Vector3<C>(self);
        }

        public static Quaternion<C> To<C>(this Quaternion self)
            where C : CoordinateSpace, new()
        {
            return new Quaternion<C>(self);
        }

        public static Vector3<C> As<C>(this RosMessageTypes.Geometry.Point self) where C : CoordinateSpace, new()
        {
            return new Vector3<C>((float)self.x, (float)self.y, (float)self.z);
        }

        public static Vector3 From<C>(this RosMessageTypes.Geometry.Point self) where C : CoordinateSpace, new()
        {
            return new Vector3<C>((float)self.x, (float)self.y, (float)self.z).toUnity;
        }

        public static Vector3<C> As<C>(this RosMessageTypes.Geometry.Point32 self) where C : CoordinateSpace, new()
        {
            return new Vector3<C>(self.x, self.y, self.z);
        }

        public static Vector3 From<C>(this RosMessageTypes.Geometry.Point32 self) where C : CoordinateSpace, new()
        {
            return new Vector3<C>(self.x, self.y, self.z).toUnity;
        }

        public static Vector3<C> As<C>(this RosMessageTypes.Geometry.Vector3 self) where C : CoordinateSpace, new()
        {
            return new Vector3<C>((float)self.x, (float)self.y, (float)self.z);
        }

        public static Vector3 From<C>(this RosMessageTypes.Geometry.Vector3 self) where C : CoordinateSpace, new()
        {
            return new Vector3<C>((float)self.x, (float)self.y, (float)self.z).toUnity;
        }

        public static Quaternion<C> As<C>(this RosMessageTypes.Geometry.Quaternion self) where C : CoordinateSpace, new()
        {
            return new Quaternion<C>((float)self.x, (float)self.y, (float)self.z, (float)self.w);
        }

        public static Quaternion From<C>(this RosMessageTypes.Geometry.Quaternion self) where C : CoordinateSpace, new()
        {
            return new Quaternion<C>((float)self.x, (float)self.y, (float)self.z, (float)self.w).toUnity;
        }

        public static RosMessageTypes.Geometry.Transform To<C>(this Transform transform) where C : CoordinateSpace, new()
        {
            return new RosMessageTypes.Geometry.Transform(new Vector3<C>(transform.position), new Quaternion<C>(transform.rotation));
        }

        public static Vector3 From(this RosMessageTypes.Geometry.Point self, CoordinateSpaceSelection selection)
        {
            switch (selection)
            {
                case CoordinateSpaceSelection.RUF:
                    return self.From<RUF>();
                case CoordinateSpaceSelection.FLU:
                    return self.From<FLU>();
                case CoordinateSpaceSelection.ENU:
                    return self.From<ENU>();
                case CoordinateSpaceSelection.NED:
                    return self.From<NED>();
                default:
                    Debug.LogError("Invalid coordinate space " + selection);
                    return self.From<RUF>();
            }
        }

        public static Vector3 From(this RosMessageTypes.Geometry.Point32 self, CoordinateSpaceSelection selection)
        {
            switch (selection)
            {
                case CoordinateSpaceSelection.RUF:
                    return self.From<RUF>();
                case CoordinateSpaceSelection.FLU:
                    return self.From<FLU>();
                case CoordinateSpaceSelection.ENU:
                    return self.From<ENU>();
                case CoordinateSpaceSelection.NED:
                    return self.From<NED>();
                default:
                    Debug.LogError("Invalid coordinate space " + selection);
                    return self.From<RUF>();
            }
        }

        public static Vector3 From(this RosMessageTypes.Geometry.Vector3 self, CoordinateSpaceSelection selection)
        {
            switch (selection)
            {
                case CoordinateSpaceSelection.RUF:
                    return self.From<RUF>();
                case CoordinateSpaceSelection.FLU:
                    return self.From<FLU>();
                case CoordinateSpaceSelection.ENU:
                    return self.From<ENU>();
                case CoordinateSpaceSelection.NED:
                    return self.From<NED>();
                default:
                    Debug.LogError("Invalid coordinate space " + selection);
                    return self.From<RUF>();
            }
        }

        public static Quaternion From(this RosMessageTypes.Geometry.Quaternion self, CoordinateSpaceSelection selection)
        {
            switch (selection)
            {
                case CoordinateSpaceSelection.RUF:
                    return self.From<RUF>();
                case CoordinateSpaceSelection.FLU:
                    return self.From<FLU>();
                case CoordinateSpaceSelection.ENU:
                    return self.From<ENU>();
                case CoordinateSpaceSelection.NED:
                    return self.From<NED>();
                default:
                    Debug.LogError("Invalid coordinate space " + selection);
                    return self.From<RUF>();
            }
        }
    }
}