// using UnityEngine;
// using TMPro;
// using System.Collections;
// using System.Collections.Generic;

// public class Chat : MonoBehaviour
// {
//     public TextMeshProUGUI textComponent;
//     public string[] lines;
//     public float textSpeed;
//     private int index;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         textComponent.text = string.Empty;
//         startDialogue();
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
    
//     void startDialogue()
//     {
//         index = 0;
//         StartCoroutine(TypeLine());
//     }

//     IEnumerator TypeLine()
//     {
//         foreach (char c in lines[index].ToCharArray());
//         {
//             textComponent.text += c;
//             yield return new WaitForSeconds(textSpeed);
//         }
//     }
// }
