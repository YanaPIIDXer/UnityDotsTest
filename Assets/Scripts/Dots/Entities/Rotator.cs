using Unity.Entities;

namespace Dots.Entities
{
    /// <summary>
    /// 回転Entity
    /// </summary>
    [GenerateAuthoringComponent]
    public struct Rotator : IComponentData
    {
        public float Speed;
    }
}
