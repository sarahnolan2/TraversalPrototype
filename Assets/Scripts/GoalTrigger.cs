using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalTrigger : MonoBehaviour
{
    public AudioSource GamplayAudioSource;
    public AudioClip GoalAudioClip;
    [Range(0, 1)] public float GameplayAudioVolume = 0.8f;
    
    List<GameObject> PowerupsList;

    public GameObject RestartTextObj;

    // Start is called before the first frame update
    void Start()
    {
        PowerupsList = GetAllChildren(GameObject.Find("BoostDashParent"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //launch the goal fanfare            
            GamplayAudioSource.clip = GoalAudioClip;
            GamplayAudioSource.Play();

            //text message on screen that they made it and that they can continue if they wish
            RestartTextObj.SetActive(true);

            //instantiate all boosts and dashes again
            foreach(GameObject powerup in PowerupsList)
            {
                powerup.SetActive(true);
            }

        }
    }

    //To get our powerups as a list on Awake
    private List<GameObject> GetAllChildren(GameObject parent)
    {
        List<GameObject> powerupsList = new List<GameObject>();

        foreach (Transform trnsfrm in parent.GetComponentInChildren<Transform>())
        {
            powerupsList.Add(trnsfrm.gameObject);
        }
        return powerupsList;
    }
}
