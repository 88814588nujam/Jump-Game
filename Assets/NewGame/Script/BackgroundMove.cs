using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMove : MonoBehaviour
{
    private GameObject BackCity1_0;
    private GameObject BackCity2_0;
    private GameObject BackCity3_0;
    private GameObject BackCity4_0;
    private GameObject BackCity1_1;
    private GameObject BackCity2_1;
    private GameObject BackCity3_1;
    private GameObject BackCity4_1;
    private GameObject BackCity1_2;
    private GameObject BackCity2_2;
    private GameObject BackCity3_2;
    private GameObject BackCity4_2;
    private GameObject BackCity1_3;
    private GameObject BackCity2_3;
    private GameObject BackCity3_3;
    private GameObject BackCity4_3;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.BackCity1_0 = GameObject.Find("BackCity1_0");
        this.BackCity2_0 = GameObject.Find("BackCity2_0");
        this.BackCity3_0 = GameObject.Find("BackCity3_0");
        this.BackCity4_0 = GameObject.Find("BackCity4_0");
        this.BackCity1_1 = GameObject.Find("BackCity1_1");
        this.BackCity2_1 = GameObject.Find("BackCity2_1");
        this.BackCity3_1 = GameObject.Find("BackCity3_1");
        this.BackCity4_1 = GameObject.Find("BackCity4_1");
        this.BackCity1_2 = GameObject.Find("BackCity1_2");
        this.BackCity2_2 = GameObject.Find("BackCity2_2");
        this.BackCity3_2 = GameObject.Find("BackCity3_2");
        this.BackCity4_2 = GameObject.Find("BackCity4_2");
        this.BackCity1_3 = GameObject.Find("BackCity1_3");
        this.BackCity2_3 = GameObject.Find("BackCity2_3");
        this.BackCity3_3 = GameObject.Find("BackCity3_3");
        this.BackCity4_3 = GameObject.Find("BackCity4_3");
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float playerPosX = this.player.transform.position.x;
        float playerPosY = this.player.transform.position.y;
        if (playerPosX > 0.0f && playerPosX < 83.2f && playerPosY > -6.18f)
        {
            if (this.BackCity1_0.transform.position.x > -3.25)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                     this.BackCity1_0.transform.Translate(-0.005f, 0, 0);
                    this.BackCity2_0.transform.Translate(-0.01f, 0, 0);
                    this.BackCity3_0.transform.Translate(-0.02f, 0, 0);
                    this.BackCity4_0.transform.Translate(-0.03f, 0, 0);
                    this.BackCity1_1.transform.Translate(-0.005f, 0, 0);
                    this.BackCity2_1.transform.Translate(-0.01f, 0, 0);
                    this.BackCity3_1.transform.Translate(-0.02f, 0, 0);
                    this.BackCity4_1.transform.Translate(-0.03f, 0, 0);
                    this.BackCity1_2.transform.Translate(-0.005f, 0, 0);
                    this.BackCity2_2.transform.Translate(-0.01f, 0, 0);
                    this.BackCity3_2.transform.Translate(-0.02f, 0, 0);
                    this.BackCity4_2.transform.Translate(-0.03f, 0, 0);
                    this.BackCity1_3.transform.Translate(-0.005f, 0, 0);
                    this.BackCity2_3.transform.Translate(-0.01f, 0, 0);
                    this.BackCity3_3.transform.Translate(-0.02f, 0, 0);
                    this.BackCity4_3.transform.Translate(-0.03f, 0, 0);
                }
            }
            if (this.BackCity1_0.transform.position.x < 4.8f)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    this.BackCity1_0.transform.Translate(0.005f, 0, 0);
                    this.BackCity2_0.transform.Translate(0.01f, 0, 0);
                    this.BackCity3_0.transform.Translate(0.02f, 0, 0);
                    this.BackCity4_0.transform.Translate(0.03f, 0, 0);
                    this.BackCity1_1.transform.Translate(0.005f, 0, 0);
                    this.BackCity2_1.transform.Translate(0.01f, 0, 0);
                    this.BackCity3_1.transform.Translate(0.02f, 0, 0);
                    this.BackCity4_1.transform.Translate(0.03f, 0, 0);
                    this.BackCity1_2.transform.Translate(0.005f, 0, 0);
                    this.BackCity2_2.transform.Translate(0.01f, 0, 0);
                    this.BackCity3_2.transform.Translate(0.02f, 0, 0);
                    this.BackCity4_2.transform.Translate(0.03f, 0, 0);
                    this.BackCity1_3.transform.Translate(0.005f, 0, 0);
                    this.BackCity2_3.transform.Translate(0.01f, 0, 0);
                    this.BackCity3_3.transform.Translate(0.02f, 0, 0);
                    this.BackCity4_3.transform.Translate(0.03f, 0, 0);
                }
            }
        }
    }
}
