using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IOGameManager.Instance.InitGame();

        //SetGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGame()
    {
        IOGameManager.Instance.gameover = GameObject.Find("GameOver").gameObject;
        IOGameManager.Instance.wingame = GameObject.Find("Victory").gameObject;

        IOGameManager.Instance.gameover.SetActive(false);
        IOGameManager.Instance.wingame.SetActive(false);
    }
}
