using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bau : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // verifica se o gameObject que colidiu com o Baú foi o jogador
        if(other.gameObject.CompareTag("Player"))
        {
            // verifica se o jogador possui uma chave
            if(other.gameObject.GetComponent<Jogador>().temChave == true)
            {
                Debug.Log("Abriu Baú");
            }
            else    // verifica se o jogador não possui uma chave
            {
                Debug.Log("Você precisa coletar a chave");
            }
        }
    }
}
