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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switchPibot.transform.Rotate(new Vector3(0, 0, -400) * Time.deltaTime);

        if(Input.GetMouseButtonDown(0))
        {   
            ChangeFoot();
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


}
