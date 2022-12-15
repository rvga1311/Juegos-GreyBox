using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 screenBounds;
    public GameObject player;
    public Camera cam;
    
    void Start()
    {
        cam = Camera.main;
        screenBounds = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        float playerX = player.transform.position.x;
        float playerY = player.transform.position.y;
        float playerHeight = player.GetComponent<SpriteRenderer>().bounds.size.y;

        
        

        if (playerY <= -(screenBounds.y + playerHeight/2))
        {
            print("Out of bounds, bottom");
            print("Lost");
        }else{
            transform.position = new Vector3(playerX + 5f, playerY + 2f, transform.position.z);
            print("Player Y: " + playerY);
            print("Screen Bounds Y: " + screenBounds.y);
            print("Player Height: " + playerHeight);
        }
        
    }
}

/*

*/