using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToSurvive : MonoBehaviour
{
    public float forceAmount = 5f;
    private Rigidbody2D rb;
    private int tapCount = 0;
    public Text tapCountText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tapCount++;
            tapCountText.text = "Taps: " + tapCount;
            rb.AddForce(Vector2.up * forceAmount, ForceMode2D.Impulse);
        }
    }
}