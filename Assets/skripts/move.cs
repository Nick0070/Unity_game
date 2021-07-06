using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;

    public float runSpeed = 500f;
    public float strafeSpeed = 500f;
    public float jumpForce = 15f;


    protected bool strafeLeft = false;
    protected bool up = false;
    protected bool strafeRight = false;
    protected bool doJump = false;
    protected bool back = false;











    void Update()
    {



        // Left 
        if (Input.GetKey("a"))
        {

            strafeLeft = true;

        }
        else
        { strafeLeft = false; }




        // Right
        if (Input.GetKey("d"))
        {

            strafeRight = true;

        }
        else
        { strafeRight = false; }



        //up
        if (Input.GetKey("w"))
        {

            up = true;

        }
        else
        { up = false; }


        // back 
        if (Input.GetKey("s"))
        {

            back = true;

        }
        else
        { back = false; }






    }



    void FixedUpdate()
    {



        if (strafeRight)
        {
            rb.AddForce(runSpeed * Time.deltaTime, 0, 0);

        }

        if (strafeLeft)
        {
            rb.AddForce(-runSpeed * Time.deltaTime, 0, 0);

        }

        if (up)
        {
            rb.AddForce(0, 0, runSpeed * Time.deltaTime);

        }

        if (back)
        {
            rb.AddForce(0, 0, -runSpeed * Time.deltaTime);

        }



    }







}
