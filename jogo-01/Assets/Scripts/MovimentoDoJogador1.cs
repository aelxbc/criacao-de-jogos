using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador1 : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float velocidadeDoJogador;

    void Awake() 
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador();
    }

    private void MovimentarJogador()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float eixoX = movimentoHorizontal * velocidadeDoJogador;
        
        float eixoY =  rigidbody2D.velocity.y;

        rigidbody2D.velocity = new Vector2(eixoX, eixoY);

        if(movimentoHorizontal > 0) {
            // jogador para a direita
            transform.localScale = new Vector3(1f, 1f, 1f);
        } else if (movimentoHorizontal < 0) {
            // jogador para asquerda 
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

    }
}
