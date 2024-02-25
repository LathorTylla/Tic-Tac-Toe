using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
   [SerializeField] private TMP_Text txt_score;
   [SerializeField] private int addscore = 25;
    private int score;

    void start()
    {
        score = 0; 
    }

    public void puchame()
    {
        score += addscore;
        txt_score.text = score.ToString();
    }
}
