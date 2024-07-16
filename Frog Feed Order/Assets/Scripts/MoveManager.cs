using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveManager : MonoBehaviour
{
    public static int Moves;
    public GameObject losePanel;
    public bool isGameContinue=true;
    public int move;
    public TextMeshProUGUI moveTxt;

    private void Start()
    {
        Moves = move;
    }
    void Update()
    {
        ////sað clicki frog koduna ekle
        //if (Input.GetMouseButtonDown(1) && isGameContinue)
        //{
        //    Moves--;
        //    moveTxt.text = Moves.ToString() + " moves";
        //}

        if (Moves<=0)
        {
            moveTxt.text = Moves.ToString() + " moves";
            isGameContinue = false;
            losePanel.SetActive(true);
        }
        else
        {
            isGameContinue = true;
            losePanel.SetActive(false);
            moveTxt.text = Moves.ToString() + " moves";
        }
    }
}
