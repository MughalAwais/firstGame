using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text score;
    
    public Vector3 scoreDistanceFromThePlayer;
    void Update()
    {
 //      transform.position = player.position + scoreDistanceFromThePlayer;

        if (player.position.z > 0)
        {
            score.text = player.position.z.ToString("00");
        }



    }
}
