using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Animator animator;

   public bool firstTime;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        firstTime = true;
        //Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        firstTime = false;
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence =  sentences.Dequeue();
        
        //Debug.Log(sentence);
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation.");
        animator.SetBool("IsOpen", false);
    }

}
