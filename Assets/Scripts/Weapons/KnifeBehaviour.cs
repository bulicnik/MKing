using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehaviour : ProjectileWeaponBehaviour
{
    // Start is called before the first frame update
    KnifeController kc;
    protected override void Start()
    {
        base.Start();
        kc = FindObjectOfType<KnifeController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * kc.speed * Time.deltaTime;
    }
}
