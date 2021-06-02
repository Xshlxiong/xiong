//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.ObjectRecognition
{
    public class MObjectType : Message
    {
        public const string k_RosMessageName = "object_recognition_msgs/ObjectType";
        public override string RosMessageName => k_RosMessageName;

        // ################################################# OBJECT ID #########################################################
        //  Contains information about the type of a found object. Those two sets of parameters together uniquely define an
        //  object
        //  The key of the found object: the unique identifier in the given db
        public string key;
        //  The db parameters stored as a JSON/compressed YAML string. An object id does not make sense without the corresponding
        //  database. E.g., in object_recognition, it can look like: "{'type':'CouchDB', 'root':'http://localhost'}"
        //  There is no conventional format for those parameters and it's nice to keep that flexibility.
        //  The object_recognition_core as a generic DB type that can read those fields
        //  Current examples:
        //  For CouchDB:
        //    type: 'CouchDB'
        //    root: 'http://localhost:5984'
        //    collection: 'object_recognition'
        //  For SQL household database:
        //    type: 'SqlHousehold'
        //    host: 'wgs36'
        //    port: 5432
        //    user: 'willow'
        //    password: 'willow'
        //    name: 'household_objects'
        //    module: 'tabletop'
        public string db;

        public MObjectType()
        {
            this.key = "";
            this.db = "";
        }

        public MObjectType(string key, string db)
        {
            this.key = key;
            this.db = db;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.key));
            listOfSerializations.Add(SerializeString(this.db));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var keyStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.key = DeserializeString(data, offset, keyStringBytesLength);
            offset += keyStringBytesLength;
            var dbStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.db = DeserializeString(data, offset, dbStringBytesLength);
            offset += dbStringBytesLength;

            return offset;
        }

        public override string ToString()
        {
            return "MObjectType: " +
            "\nkey: " + key.ToString() +
            "\ndb: " + db.ToString();
        }

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        static void OnLoad()
        {
            MessageRegistry.Register<MObjectType>(k_RosMessageName);
        }
    }
}