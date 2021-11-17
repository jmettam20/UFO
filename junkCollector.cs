using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class junkCollector : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider col)
        {
            Destroy(col.gameObject);
        }
    }
}
