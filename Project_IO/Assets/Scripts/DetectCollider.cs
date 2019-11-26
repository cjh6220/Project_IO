using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(GameObject parent)
    {
        player = parent;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.transform.tag == "Head" && collision.transform.tag == "Foot")
        {
            Debug.Log(player.name + "가" + collision.transform.name + "에 닿음");

            if (player.name == "me")
            {
                IOGameManager.Instance.GameOver();
                IOGameManager.Instance.DeletePlayerList(player);
                Destroy(player);
            }
            else
            {
                IOGameManager.Instance.DeletePlayerList(player);
                Destroy(player);
            }

            if (IOGameManager.Instance.GetPlayerListNum() == 1)
            {
                IOGameManager.Instance.WinGame();
            }
        }
    }
}
