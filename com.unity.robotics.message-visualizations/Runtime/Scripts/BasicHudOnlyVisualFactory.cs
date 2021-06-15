using System;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using UnityEngine;

namespace Unity.Robotics.MessageVisualizers
{
    public abstract class BasicHudOnlyVisualFactory<TargetMessageType> : MonoBehaviour, IVisualFactory, IPriority
        where TargetMessageType : Message
    {
        [SerializeField]
        string m_Topic;

        public virtual void Start()
        {
            if (m_Topic == "")
                VisualFactoryRegistry.RegisterTypeVisualizer<TargetMessageType>(this, Priority);
            else
                VisualFactoryRegistry.RegisterTopicVisualizer(m_Topic, this, Priority);
        }

        public int Priority { get; set; }

        public bool CanShowDrawing => false;

        public IVisual CreateVisual(Message message, MessageMetadata meta)
        {
            return new BasicHudOnlyVisualization<TargetMessageType>((TargetMessageType)message, meta, this);
        }

        public virtual Action CreateGUI(TargetMessageType message, MessageMetadata meta)
        {
            return MessageVisualizations.CreateDefaultGUI(message, meta);
        }
    }
}
