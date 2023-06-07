using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter_kod : MonoBehaviour
{
    float hiz = 10;
    float guc = 100;
    float can = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal") * Time.deltaTime * hiz;
        transform.Translate(yatay, 0f, 0f);
    }


    public GameObject can1;
    public GameObject can2;
    public GameObject can3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bicak")
        {
            collision.gameObject.transform.position = new Vector2(Random.Range(-7f, 7f), Random.Range(6f, 9f));
            guc -= 50;
        }

        if (collision.gameObject.tag == "sopa")
        {
            collision.gameObject.transform.position = new Vector2(Random.Range(-7f, 7f), Random.Range(6f, 9f));
            guc -= 25;
        }

        if (collision.gameObject.tag == "yem")
        {
            collision.gameObject.transform.position = new Vector2(Random.Range(-7f, 7f), Random.Range(6f, 9f));
            guc += 10;
            if (guc > 100) guc = 100;
        }

        if (guc <= 0)
        {
            can--;
            guc = 100;
        }



        Debug.Log("Kalan Can: " + can + "    Kalan Güç: " + guc);

        if (can == 3)
        {
            can1.SetActive(true);
            can2.SetActive(true);
            can3.SetActive(true);
        }

        if (can == 2)
        {
            can1.SetActive(true);
            can2.SetActive(true);
            can3.SetActive(false);
        }

        if (can == 1)
        {
            can1.SetActive(true);
            can2.SetActive(false);
            can3.SetActive(false);
        }
        if (can == 0)
        {
            can1.SetActive(false);
            can2.SetActive(false);
            can3.SetActive(false);
        }

        if (can <= 0)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}