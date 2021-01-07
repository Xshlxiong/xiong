//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Visualization
{
    public class ImageMarker : Message
    {
        public const string RosMessageName = "visualization_msgs/ImageMarker";

        public const byte CIRCLE = 0;
        public const byte LINE_STRIP = 1;
        public const byte LINE_LIST = 2;
        public const byte POLYGON = 3;
        public const byte POINTS = 4;
        public const byte ADD = 0;
        public const byte REMOVE = 1;
        public Header header;
        public string ns;
        //  namespace, used with id to form a unique id
        public int id;
        //  unique id within the namespace
        public int type;
        //  CIRCLE/LINE_STRIP/etc.
        public int action;
        //  ADD/REMOVE
        public Geometry.Point position;
        //  2D, in pixel-coords
        public float scale;
        //  the diameter for a circle, etc.
        public Std.ColorRGBA outline_color;
        public byte filled;
        //  whether to fill in the shape with color
        public Std.ColorRGBA fill_color;
        //  color [0.0-1.0]
        public Duration lifetime;
        //  How long the object should last before being automatically deleted.  0 means forever
        public Geometry.Point[] points;
        //  used for LINE_STRIP/LINE_LIST/POINTS/etc., 2D in pixel coords
        public Std.ColorRGBA[] outline_colors;
        //  a color for each line, point, etc.

        public ImageMarker()
        {
            this.header = new Header();
            this.ns = "";
            this.id = 0;
            this.type = 0;
            this.action = 0;
            this.position = new Geometry.Point();
            this.scale = 0.0f;
            this.outline_color = new Std.ColorRGBA();
            this.filled = 0;
            this.fill_color = new Std.ColorRGBA();
            this.lifetime = new Duration();
            this.points = new Geometry.Point[0];
            this.outline_colors = new Std.ColorRGBA[0];
        }

        public ImageMarker(Header header, string ns, int id, int type, int action, Geometry.Point position, float scale, Std.ColorRGBA outline_color, byte filled, Std.ColorRGBA fill_color, Duration lifetime, Geometry.Point[] points, Std.ColorRGBA[] outline_colors)
        {
            this.header = header;
            this.ns = ns;
            this.id = id;
            this.type = type;
            this.action = action;
            this.position = position;
            this.scale = scale;
            this.outline_color = outline_color;
            this.filled = filled;
            this.fill_color = fill_color;
            this.lifetime = lifetime;
            this.points = points;
            this.outline_colors = outline_colors;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(SerializeString(this.ns));
            listOfSerializations.Add(BitConverter.GetBytes(this.id));
            listOfSerializations.Add(BitConverter.GetBytes(this.type));
            listOfSerializations.Add(BitConverter.GetBytes(this.action));
            listOfSerializations.AddRange(position.SerializationStatements());
            listOfSerializations.Add(BitConverter.GetBytes(this.scale));
            listOfSerializations.AddRange(outline_color.SerializationStatements());
            listOfSerializations.Add(new[]{this.filled});
            listOfSerializations.AddRange(fill_color.SerializationStatements());
            listOfSerializations.AddRange(lifetime.SerializationStatements());
            
            listOfSerializations.Add(BitConverter.GetBytes(points.Length));
            foreach(var entry in points)
                listOfSerializations.Add(entry.Serialize());
            
            listOfSerializations.Add(BitConverter.GetBytes(outline_colors.Length));
            foreach(var entry in outline_colors)
                listOfSerializations.Add(entry.Serialize());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            var nsStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.ns = DeserializeString(data, offset, nsStringBytesLength);
            offset += nsStringBytesLength;
            this.id = BitConverter.ToInt32(data, offset);
            offset += 4;
            this.type = BitConverter.ToInt32(data, offset);
            offset += 4;
            this.action = BitConverter.ToInt32(data, offset);
            offset += 4;
            offset = this.position.Deserialize(data, offset);
            this.scale = BitConverter.ToSingle(data, offset);
            offset += 4;
            offset = this.outline_color.Deserialize(data, offset);
            this.filled = data[offset];;
            offset += 1;
            offset = this.fill_color.Deserialize(data, offset);
            offset = this.lifetime.Deserialize(data, offset);
            
            var pointsArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.points= new Geometry.Point[pointsArrayLength];
            for(var i = 0; i < pointsArrayLength; i++)
            {
                this.points[i] = new Geometry.Point();
                offset = this.points[i].Deserialize(data, offset);
            }
            
            var outline_colorsArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.outline_colors= new Std.ColorRGBA[outline_colorsArrayLength];
            for(var i = 0; i < outline_colorsArrayLength; i++)
            {
                this.outline_colors[i] = new Std.ColorRGBA();
                offset = this.outline_colors[i].Deserialize(data, offset);
            }

            return offset;
        }

        public override string ToString()
        {
            return "ImageMarker: " +
            "\nheader: " + header.ToString() +
            "\nns: " + ns.ToString() +
            "\nid: " + id.ToString() +
            "\ntype: " + type.ToString() +
            "\naction: " + action.ToString() +
            "\nposition: " + position.ToString() +
            "\nscale: " + scale.ToString() +
            "\noutline_color: " + outline_color.ToString() +
            "\nfilled: " + filled.ToString() +
            "\nfill_color: " + fill_color.ToString() +
            "\nlifetime: " + lifetime.ToString() +
            "\npoints: " + points.ToString() +
            "\noutline_colors: " + outline_colors.ToString();
        }
    }
}
