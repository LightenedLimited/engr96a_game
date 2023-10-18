using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI CountText;
    public GameObject winTextObject;

    void SetCountText()
    {
        CountText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winTextObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            count += 1; 
            other.gameObject.SetActive(false);
            SetCountText(); 
        }
    }
}
