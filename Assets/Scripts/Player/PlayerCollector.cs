using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.TryGetComponent(out iCollectable collectable))
        {
            collectable.Collect();
        }
    }
}
