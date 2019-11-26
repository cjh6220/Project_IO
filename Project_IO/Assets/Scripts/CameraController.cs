using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public static CameraController instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            CameraController.instance = this;
        }
        if (player != null)
        {
            this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float playerXPos = player.transform.position.x;
        float playerYPos = player.transform.position.y;
        ths.transform.position = new Vector3(playerXPos, playerYPos, -10);
        */
        if(player ==null)
        {
            return;
        }
        
        Vector3 currentPos = new Vector3(transform.position.x, transform.position.y, -10f);
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, -10f);

        transform.position = Vector3.MoveTowards(currentPos, targetPos, 0.1f);
        
    }

    public GameObject SetPlayer{ set{ player = value; }}

    
    public void InitCamera()
    {
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }    
}
