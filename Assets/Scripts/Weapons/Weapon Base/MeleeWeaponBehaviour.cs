using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponBehaviour : MonoBehaviour
{
    // Base script of melee weapons
    public float destroyAfterSeconds;
    

    // Update is called once per frame
    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }
}
