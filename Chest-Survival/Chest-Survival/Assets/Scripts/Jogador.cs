using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // referência ao componente 'Rigidbody 2D' do jogador
    public Rigidbody2D oRigidbody2D;

    // controle da velocidade do jogador
    public float velocidadeDoJogador;

    // controla se o jogador possui ou não a chave
    public bool temChave;

    // Start is called before the first frame update
    void Start()
    {
        // diz que o jogador não possui a chave
        temChave = false;
    }

    // Update is called once per frame
    void Update()
    {
        // roda o método 'MovimentarJogador'
        MovimentarJogador();
    }

    private void MovimentarJogador()
    {
        // movimenta o jogador no eixo horizontal, se baseando na sua velocidade
        oRigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidadeDoJogador, oRigidbody2D.velocity.y);

        // verifica se o jogador está indo para a esquerda
        if(Input.GetAxis("Horizontal") < 0)
        {
            // ativa o espelhamento do sprite do jogador
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else    // verifica se o jogador está indo para a direita
        {
            // desativa o espelhamento do sprite do jogador
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
