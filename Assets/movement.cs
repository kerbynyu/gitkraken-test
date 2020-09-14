using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class movement : MonoBehaviour {
    // Start is called before the first frame update
    float speed = 5; 

        void Start() {
        ControllPlayer();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();



    }

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite newSprite2;

    void Update() {
        if(Time.time > 5 && Time.time<30) {
            spriteRenderer.sprite = newSprite;
        }

        if (Time.time > 15)
        {
            spriteRenderer.sprite = newSprite2;
        }

        //WASD INPUT 
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0, speed * Time.deltaTime, 0);

        }

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0, -speed * Time.deltaTime, 0);

        }
        
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-speed * Time.deltaTime, 0, 0);

        }

        if(Input.GetKey(KeyCode.D)){
            transform.Translate(speed * Time.deltaTime, 0, 0);

        }
    }

    void ControllPlayer()
    {
       

    }
}
