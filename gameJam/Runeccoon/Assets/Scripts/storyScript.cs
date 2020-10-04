using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyScript : MonoBehaviour
{
    public dialogueTrigger dia;

    private GameObject player;

    private void Start()
    {
        StartCoroutine(ExecuteDialogue(2));
        
        player = GameObject.Find("Player");
        player.gameObject.SetActive(false);
        
        StartCoroutine(ExecuteWakeUp(3));

       // FunctionTimer.Create(dia.TriggerDialogue(), 2f, "Timer");
    }

     IEnumerator ExecuteDialogue(float time)
     {
        yield return new WaitForSeconds(time);
        // Code to execute after the delay
        dia.TriggerDialogue();
     }
     IEnumerator ExecuteWakeUp(float time)
     {
        yield return new WaitForSeconds(time);

        player.gameObject.SetActive(true);
     }

     void Update(){
    
     }
     
}
