using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // verifica se o gameObject que colidiu com a chave foi o jogador
        if(other.gameObject.CompareTag("Player"))
        {
            // acessa o script do jogador e diz que ele possui a chave
            other.GetComponent<Jogador>().temChave = true;
            // destrói o gameObject da chave
            Destroy(this.gameObject);
        }
    }
}
