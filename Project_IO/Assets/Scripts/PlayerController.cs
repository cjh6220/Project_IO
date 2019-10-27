using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject switchPibot;
    public GameObject circle1;
    public GameObject circle2;

    public bool change = false;
    public bool isTestObject = false;

    // Start is called before the first frame update
    void Start()
    {
        circle1.GetComponent<DetectCollider>().Init(this.gameObject);
        circle2.GetComponent<DetectCollider>().Init(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //switchPibot.transform.Rotate(new Vector3(0, 0, -400) * Time.deltaTime);
        if(change)
        {            
            circle2.transform.Rotate(new Vector3(0, 0, -400) * Time.deltaTime);
        }
        else
        {
            circle1.transform.Rotate(new Vector3(0, 0, -400) * Time.deltaTime);
        }

        if(Input.GetMouseButtonDown(0) && isTestObject == false)
        {   
            ChangeFoot2();
        }
    }

    private void ChangeFoot()
    {
        if(change)
        {
            circle1.transform.SetParent(switchPibot.transform);
            circle1.transform.localPosition = new Vector3(-2, 0, 0);
            circle1.GetComponent<SpriteRenderer>().color = Color.red;

            circle2.transform.SetParent(this.transform);
            circle2.transform.localPosition = Vector3.zero;
            circle2.GetComponent<SpriteRenderer>().color = Color.white;

            Vector3 worldPos = switchPibot.transform.GetChild(0).position;
            this.transform.position = worldPos;

            change = false;
        }
        else
        {
            circle2.transform.SetParent(switchPibot.transform);
            circle2.transform.localPosition = new Vector3(-2, 0, 0);
            circle2.GetComponent<SpriteRenderer>().color = Color.white;

            circle1.transform.SetParent(this.transform);
            circle1.transform.localPosition = Vector3.zero;
            circle1.GetComponent<SpriteRenderer>().color = Color.red;

            Vector3 worldPos = switchPibot.transform.GetChild(0).position;
            this.transform.position = worldPos;

            change = true;
        }
    }

    private void ChangeFoot2()
    {
        if(change)
        {
            circle1.transform.SetParent(switchPibot.transform);
            circle2.transform.SetParent(circle1.transform);
            circle1.transform.SetParent(this.transform);

            circle1.transform.tag = "Head";
            circle2.transform.tag = "Foot";            

            change = false;
        }
        else
        {
            circle2.transform.SetParent(switchPibot.transform);
            circle1.transform.SetParent(circle2.transform);
            circle2.transform.SetParent(this.transform);

            circle2.transform.tag = "Head";
            circle1.transform.tag = "Foot";

            change = true;
        }
    }

}
