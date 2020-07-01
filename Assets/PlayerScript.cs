using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Vector2 direction;
    
    public float moveSpeed;
    public Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate(){
        playerRb.MovePosition(playerRb.position + (direction * moveSpeed * Time.fixedDeltaTime));
    }

}
