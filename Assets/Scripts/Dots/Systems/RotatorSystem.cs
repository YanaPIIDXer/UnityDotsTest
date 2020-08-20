using System;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace Dots.Systems
{
    /// <summary>
    /// Dotsでの回転処理
    /// </summary>
    public class RotatorSystem : SystemBase
    {
        /// <summary>
        /// 更新
        /// </summary>
        protected override void OnUpdate()
        {
            float DeltaTime = UnityEngine.Time.deltaTime;
            Entities.ForEach((ref Rotation Target, in Dots.Entities.Rotator InRot) =>
            {
                Target.Value = math.mul(math.normalize(Target.Value), quaternion.Euler(0.0f, InRot.Speed * DeltaTime, 0.0f));
            })
            .ScheduleParallel();
        }
    }
}
