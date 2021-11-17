using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{

    [SerializeField] private Transform levelPart_1;


    private void Awake() {
        Instantiate(levelPart_1, new Vector3(26, 21), Quaternion.identity);
    }
}
