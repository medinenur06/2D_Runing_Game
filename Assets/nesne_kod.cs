using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesne_kod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            transform.position =new Vector2(Random.Range(-7f, 7f),Random.Range(6f, 9f));
        }
    }
}
