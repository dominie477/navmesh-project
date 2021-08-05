
using UnityEngine;

public class Cameramovment : MonoBehaviour
{
    public float panSpeed = 20f;

    public float panBorder = 10f;

    public Vector2 panLimit;

    
    


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.mousePosition.y >= Screen.height - panBorder)
        {
            pos.z += panSpeed * Time.deltaTime;

            


        }


        if (Input.mousePosition.y <= panBorder)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }

        if (Input.mousePosition.x >= Screen.width - panBorder)
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        if (Input.mousePosition.x <= panBorder)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }




        if (Input.GetKey("q"))
        {

            transform.Rotate(Vector3.down * Time.deltaTime * -panSpeed, Space.World);

        }

        else if (Input.GetKey("e"))
        {

            transform.Rotate(Vector3.up * Time.deltaTime * -panSpeed, Space.World);

        }
       
        transform.position = pos;
        
        // pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        // pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);




    }


}
