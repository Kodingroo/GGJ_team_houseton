using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    [SerializeField] public Vector2 lastCheckPointPos;
    private GameObject[] lap1;
    List<string> lap2 = new List<string>();
    List<string> lap3 = new List<string>();
    Player reference;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void gameOver(){

    }

    void wipeScore(){
        //when length of an array becomes greater than 0, delete scores. 
    }

    void displayScore(){
        //send scores to front end 
    }
    [SerializeField] public GameObject[] players;
    void Start()
    {
        players = FindGameObjectsWithTags(new string[] { "Player1", "Player2", "Player3", "Player4" });
        lap1 = players;
    }
    public int Position(Collider2D playerObject)
    {
        foreach (GameObject player in players)
        {
            reference = playerObject.GetComponent<Player>();
            if (lap2.Contains($"{playerObject.tag}"))
            {
                lap3.Add($"{playerObject.tag}");
                reference.rank++;
                Debug.Log("rank" + reference.rank);
                return lap3.IndexOf($"{playerObject.tag}");
            }
            else
            {   
                lap2.Add($"{playerObject.tag}");
                reference.rank++;
                Debug.Log("rank" + reference);                
                return lap2.IndexOf($"{playerObject.tag}");
            }
        }
        return 0;
    }
    GameObject[] FindGameObjectsWithTags(params string[] tags)
    {
        var all = new List<GameObject>();
        foreach (string tag in tags)
        {
            var temp = GameObject.FindGameObjectsWithTag(tag).ToList();
            all = all.Concat(temp).ToList();
        }
        return all.ToArray();
    }
}



