using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    public int scoreIncrement;

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(IncrementScore);
    }

    private void IncrementScore()
    {
        GameManager.Instance.IncreaseScore(scoreIncrement);
    }
}
