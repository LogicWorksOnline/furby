using UnityEngine;
using System.Collections;

public class TriggerDetection : MonoBehaviour {

    public bool isQuest = false;

    GameObject questImage;
    GameObject questText;

    public string customText;    

    // Use this for initialization
    void Start () {
        questImage = GameObject.Find("QuestImage");
        questText = GameObject.Find("QuestText");

        //questImage.SetActive(false);
       // questText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.tag == "Tutorial")
        {

            Destroy(other.gameObject);
            
        }

        if (gameObject.tag == "LevelComplete" && other.gameObject.tag == "Player")
        {

            Application.LoadLevel(1);

        }

        if (gameObject.tag == "Death" && other.gameObject.tag == "Player")
        {

            Application.LoadLevel(Application.loadedLevel);

        }

        if (gameObject.tag == "GoalD" && other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }



        //QUEST
        if (other.gameObject.tag == "Player" && isQuest)
        {
            //questImage.SetActive(true);
           // questText.active = true;

            
        }

    }
}
