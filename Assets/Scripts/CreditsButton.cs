using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CeditsButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        if (button != null && gameManager != null)
        {
            button.onClick.AddListener(gameManager.CreditsStart);
        }
        else
        {
            Debug.LogWarning("Button or GameManager is null");
        }
    }
}