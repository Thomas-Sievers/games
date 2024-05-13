using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float velocidade = 3;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
    }

    void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * this.velocidade, ForceMode2D.Impulse);
    }
}
