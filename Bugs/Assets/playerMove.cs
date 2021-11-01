
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public GameObject player;
    private moveSpeed = 1;


    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() 
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            (player.x * moveSpeed * time.DeltaTime);
        }
    }

   

    

}
