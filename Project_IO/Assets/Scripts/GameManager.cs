using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static GameManager instance = null;
    [SerializeField] private GameObject gameover;
    [SerializeField] private GameObject wingame;
    [SerializeField] public List<GameObject> playerList = new List<GameObject>();


    public static GameManager Instance
    {
        get 
        {
            if (instance ==null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {        
        //InitGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(testbtn)
        {
            wingame.SetActive(true);
        }
    }

    public void LoadGameManager()
    {        
        
    }

    public void InitGame()
    {
        gameover = GameObject.Find("GameOver");
        wingame = GameObject.Find("Victory");

        //gameover.SetActive(false);
        //wingame.SetActive(false);
                
        InitPlayer();
    }

    public void WinGame()
    {
        wingame.SetActive(true);
    }

    public void GameOver()
    {
        gameover.SetActive(true);
    }

    public void InitPlayer()
    {
        playerList.Clear();        

        GameObject playerPrefab = Resources.Load<GameObject>("Player");
        GameObject me = Instantiate(playerPrefab);//, new Vector3(5.64f, 0f, 0f), Quaternion.identity);
        me.transform.position = new Vector3(5.64f, 0f, -0.1f);
        me.name = "me";
        //me.GetComponent<PlayerController>().SetCamera();
        playerList.Add(me);

        //CameraController.instance.InitCamera();

        GameObject otherPlayer1 = Instantiate(playerPrefab);
        otherPlayer1.transform.position = new Vector3(-2.53f, 0f, -0.1f);
        otherPlayer1.name = "otherPlayer1";
        otherPlayer1.GetComponent<PlayerController>().isTestObject = true;
        playerList.Add(otherPlayer1);

        GameObject otherPlayer2 = Instantiate(playerPrefab);
        otherPlayer2.transform.position = new Vector3(2.74f, 6.64f, -0.1f);
        otherPlayer2.name = "otherPlayer2";
        otherPlayer2.GetComponent<PlayerController>().isTestObject = true;
        playerList.Add(otherPlayer2);
    }

    public void DeletePlayerList(GameObject obj)
    {
        playerList.Remove(obj);
    }

    public int GetPlayerListNum()
    {
        return playerList.Count;
    }

    public void ResetGame()
    {
        for(int i = 0; i < playerList.Count; i++)
        {
            Destroy(playerList[i]);
            //player.Remove(player[0]);
        }

        gameover.SetActive(false);
        wingame.SetActive(false);

        InitPlayer();
    }

    [SerializeField] public bool testbtn;
}
