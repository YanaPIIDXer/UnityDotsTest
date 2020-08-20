using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 物理エンジンで動作する玉生成
/// </summary>
public class PhysicsShapeSpawner : MonoBehaviour
{
    /// <summary>
    /// 玉のPrefab
    /// </summary>
    [SerializeField]
    private GameObject ShapePrefab = null;
    
    /// <summary>
    /// 玉リスト
    /// </summary>
    private List<GameObject> Shapes = new List<GameObject>();

    /// <summary>
    /// 生成された玉の数
    /// </summary>
    public int Count { get { return Shapes.Count; } }

    /// <summary>
    /// 生成される玉の最大数
    /// </summary>
    private static readonly int MaxShapeCount = 10000;

    /// <summary>
    /// １フレームあたりの生成数
    /// </summary>
    private static readonly int SpawnByFrame = 150;

    /// <summary>
    /// 範囲
    /// </summary>
    private static readonly float Range = 10.0f;

    protected void Awake()
    {
        StartCoroutine(SpawnShape());
    }

    /// <summary>
    /// 玉生成コルーチン
    /// </summary>
    private IEnumerator SpawnShape()
    {
        while(Count < MaxShapeCount)
        {
            for(int i = 0; i < SpawnByFrame; i++)
            {
                Spawn();
            }
            yield return null;
        }
    }

    /// <summary>
    /// 生成
    /// </summary>
    private void Spawn()
    {
        Vector3 Pos = transform.position;
        Pos.x += Random.Range(-Range, Range);
        Pos.z += Random.Range(-Range, Range);
        Pos.y += 3.0f;

        GameObject ShapeObj = GameObject.Instantiate(ShapePrefab, Pos, transform.rotation);
        Debug.Assert(ShapeObj != null);

        Shapes.Add(ShapeObj);
    }
}
