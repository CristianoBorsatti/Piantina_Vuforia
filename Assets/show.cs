using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show : MonoBehaviour
{
    Text percentageText;
    public int id;
    GameObject piano;
    GameObject piano1;
    GameObject piano2;
    private Piantina percentaceText;
    public Text mytext;
    // Use this for initialization
    void Start()
    {
        percentageText = GetComponent<Text>();

        mytext = GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>();
        piano = GameObject.Find("piano");
        Debug.Log("trova piano: " + piano);

        piano1 = GameObject.Find("piano1");
        Debug.Log("trova piano1: " + piano1);

        piano2 = GameObject.Find("piano2");
        Debug.Log("trova piano2: " + piano2);

    }

    // Update is called once per frame
    void Update(){

        Debug.Log("valore" + mytext.text);

            int.TryParse(mytext.text, out id);
        
        switch (id) {

                case 0:
                    Debug.Log("caso 1");
                    piano.SetActive(true);
                    piano1.SetActive(true);
                    piano2.SetActive(true);
                    break;

                case 25:
                    Debug.Log("caso 2");
                //piano.SetActive(false);
                    piano.SetActive(true);
                    piano1.SetActive(false);
                    piano2.SetActive(false);
                    break;

                case 50:
                    Debug.Log("caso 3");
                //piano.SetActive(false);
                piano.SetActive(false);
                piano1.SetActive(true);
                piano2.SetActive(false);
                break;

                case 75:
                    Debug.Log("caso 4");
                //piano.SetActive(false);
                piano.SetActive(false);
                piano1.SetActive(false);
                piano2.SetActive(true);
                break;
            }

        }
    }




