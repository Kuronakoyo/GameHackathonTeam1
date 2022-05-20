using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float playerSpeed;

    [SerializeField]
    private float playermovePosMax_x;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.position.x <= playermovePosMax_x)
        {
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += new Vector3(playerSpeed, 0, 0);
            }
        }
         if  ( gameObject.transform.position.x >= -playermovePosMax_x)
        {
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.position -= new Vector3(playerSpeed, 0, 0);
            }

        }
    }
}
