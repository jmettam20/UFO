using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Animator anim;

    public float speed;

    bool movingRight = true;

    public Transform groundDetection;

    public float groundDetectionLength = 2f;

    bool walking = true;

    public GameObject awareness;

    public BoxCollider2D beam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
         
                speed = 4f;
                Debug.Log("NPC RUN!");
          
        }
    }
}
