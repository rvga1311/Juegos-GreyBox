using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMov : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 screenBounds;
    public GameObject player;
    public Camera cam;

    private float prevY;
    
    void Start()
    {
        cam = Camera.main;
        screenBounds = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));
        prevY = player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float playerX = player.transform.position.x;
        float playerY = player.transform.position.y;
        float playerHeight = player.GetComponent<SpriteRenderer>().bounds.size.y;
        float screenHeight = screenBounds.y;

        

        float yOffset = 0f;

        float XPOS = playerX + 5f;
        float YPOS;

        float top = screenHeight*0.05f;
        float bot = -screenHeight*0.5f;
        

        if(playerY != prevY){
            yOffset = playerY - prevY;
            prevY = playerY;
        }

        
        
        if(bot < playerY  && playerY < top ){
            YPOS = playerY + 1f;
        }else{
            YPOS = transform.position.y;
        }
            
        transform.position = new Vector3(XPOS, YPOS, transform.position.z);


        

        if (playerY <= -(screenBounds.y + playerHeight/2))
        {
            print("Out of bounds, bottom");
            print("Lost");
            player.GetComponent<Player>().resetPosition();
        }
        
    }
}

/*

*/