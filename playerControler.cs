using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D playerRigidbody;
    private Vector3 change;

    bool tractorState = false;

    private Animator anim;

    public GameObject beam; 

    // Start is called before the first frame update
    void Start()
    {
        beam.SetActive(false);
        playerRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        MoveCharacter();

        tractorBeamOn();
        tractorBeamOff();
        lazerOn();
        lazerOff();
        
        
    }


        
          
     

    void MoveCharacter() {
        playerRigidbody.MovePosition(transform.position + change.normalized * playerSpeed * Time.deltaTime); 
    }

    void tractorBeamOn() {
        if (Input.GetKeyDown("q")) {
            anim.SetBool("tractorBeam", true);
            bool tractorState = true;
            
            anim.SetBool("activateTractorBeam", true);
            beam.SetActive(true);

        }
    }

    void tractorBeamOff()
    {
        if (Input.GetKeyDown("e"))
        {
            anim.SetBool("tractorBeam", false);
            Debug.Log("Tractor beam off");
            anim.SetBool("activateTractorBeam", false);
            beam.SetActive(false);
        }
    }


    void lazerOn()
    {
        if (Input.GetKeyDown("o"))
        {
            anim.SetBool("readyLazer", true);
            


        }
    }

    void lazerOff()
    {
        if (Input.GetKeyDown("p"))
        {
            anim.SetBool("readyLazer", false);
           
        }
    }




    
}
