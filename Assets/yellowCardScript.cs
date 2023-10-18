using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class yellowCardScript : MonoBehaviour
{
    // this script will be called whenever yellow plays a lightning bolt card
    // script is attached to the yellow card
    // this deals 3 damage to the red user
    // Start is called before the first frame updatexs
    void Start()
    {
        int redHealth = int.Parse(GameObject.Find("Red Health Value").GetComponent<TMPro.TextMeshPro>().text);
        redHealth -= 3;
        GameObject.Find("Red Health Value").GetComponent<TMPro.TextMeshPro>().text = redHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
