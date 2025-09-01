using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistic : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float minT = 0.25f, maxT = 0.9f;
    [SerializeField] private float arcHeight = 1.5f;
    void ShootBallistic(Transform tgt)
    {
        Vector2 origin = firePoint.position;
        Vector2 dest = tgt.position;

        //var bullet = ObjectPoolManager.Instance.Get(PoolKey.PlayerBullet);

        //var rbS = bullet.GetComponent<Rigidbody2D>();

        //float g = Physics2D.gravity.y * (rbS ? rbS.gravityScale : 1f);
        //float gAbs = Mathf.Abs(g);

        //bullet.SetActive(false);

        //Vector2 dp2 = dest - origin;
        //float yApex = Mathf.Max(origin.y, dest.y) + Mathf.Max(0.01f, arcHeight);

        //float hUp = Mathf.Max(0.001f, yApex - origin.y);
        //float v0y = Mathf.Sqrt(2f * gAbs * hUp);
        //float tUp = v0y / gAbs;

        //float hDown = Mathf.Max(0f, yApex - dest.y);
        //float tDown = Mathf.Sqrt(2f * hDown / gAbs);

        //float T = Mathf.Clamp(tUp + tDown, minT, maxT);
        //float v0x = dp2.x / Mathf.Max(0.001f, T);

        //Vector2 v0 = new Vector2(v0x, v0y);
        //FireVelocity(v0, orient: true);
    }
}
