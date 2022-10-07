using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int ForwardForce = 500;

    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.0f);
    }

    void Update()
    {
        if(IsGrounded()){
        if(Input.GetKey("space")){
            rb.AddForce(0, 130 * Time.deltaTime ,0, ForceMode.VelocityChange);
        }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, ForwardForce * Time.deltaTime);

        

        if(Input.GetKey("d")) 
        {
            rb.AddForce(70 * Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")) 
        {
            rb.AddForce(-70 * Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }
    }
}
