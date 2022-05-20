using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBlookScript : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed;

    [SerializeField]
    private float fallCoolTime;

    [SerializeField]
    private float destroyLine;

    GameObject playerUI;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Alienfall());

        playerUI = GameObject.Find("LifeUiPanel");
    }

    private void Update()
    {
        if (transform.position.y < destroyLine)
        {
            playerUI.GetComponent<LifeGauge>().SubHp();

            Destroy(gameObject);
        }
    }

 
    IEnumerator Alienfall()
    {
        while(true)
        {
            yield return new WaitForSeconds(fallCoolTime);

            transform.position -= new Vector3(0, fallSpeed, 0);
        }
    }
}
