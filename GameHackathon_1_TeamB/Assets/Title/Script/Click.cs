using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
        
    }
    void Update()
    {
        //クリックしたら
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SugaharaPairScene");
            Debug.Log("ki");
        }
        //スペース押したら
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("SugaharaPairScene");
            Debug.Log("ki");
        }

    }

}
