using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDecrement : MonoBehaviour
{
    public TMP_Text healthText;
    public TMP_Text youLose;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure healthText is assigned before accessing its properties
        if (healthText == null)
        {
            healthText = GetComponent<TMP_Text>();
        }
        if (youLose == null)
        {
            youLose = GetComponent<TMP_Text>();
        }
    }

    // Update is called once per frame
    public void onButtonClick()
    {
        // Check if healthText is still null before accessing its properties
        if (healthText != null)
        {
            int health = int.Parse(healthText.text);
            if (health > 0){
                health--;
                healthText.text = health.ToString();
            }
            else
            {
                youLose.gameObject.SetActive(true);
            }
        }
        else
        {
            Debug.LogError("healthText is null!");
        }
    }
}
