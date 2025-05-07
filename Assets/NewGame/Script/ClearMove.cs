using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearMove : MonoBehaviour
{
    private GameObject BackCity1_0;
    private GameObject BackCity2_0;
    private GameObject BackCity3_0;
    private GameObject BackCity4_0;
    private GameObject BackCity1_1;
    private GameObject BackCity2_1;
    private GameObject BackCity3_1;
    private GameObject BackCity4_1;

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
    }

    // Update is called once per frame
    void Update()
    {
        float city1X = this.BackCity1_0.transform.position.x;
        this.BackCity1_0.transform.Translate(-0.005f, 0, 0);
        this.BackCity1_1.transform.Translate(-0.005f, 0, 0);
        if (city1X <= -19.2f)
        {
            this.BackCity1_0.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            this.BackCity1_1.transform.position = new Vector3(19.2f, 0.0f, 0.0f);
        }

        float city2X = this.BackCity2_0.transform.position.x;
        this.BackCity2_0.transform.Translate(-0.01f, 0, 0);
        this.BackCity2_1.transform.Translate(-0.01f, 0, 0);
        if (city2X <= -19.2f)
        {
            this.BackCity2_0.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            this.BackCity2_1.transform.position = new Vector3(19.2f, 0.0f, 0.0f);
        }

        float city3X = this.BackCity3_0.transform.position.x;
        this.BackCity3_0.transform.Translate(-0.02f, 0, 0);
        this.BackCity3_1.transform.Translate(-0.02f, 0, 0);
        if (city3X <= -19.2f)
        {
            this.BackCity3_0.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            this.BackCity3_1.transform.position = new Vector3(19.2f, 0.0f, 0.0f);
        }


        float city4X = this.BackCity4_0.transform.position.x;
        this.BackCity4_0.transform.Translate(-0.03f, 0, 0);
        this.BackCity4_1.transform.Translate(-0.03f, 0, 0);
        if (city4X <= -19.2f)
        {
            this.BackCity4_0.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            this.BackCity4_1.transform.position = new Vector3(19.2f, 0.0f, 0.0f);
        }

    }
}