using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using BNG; 

public class Start_game : MonoBehaviour
{
    public Timer timer_script;
    public AudioSource audio_boton_inicio;
    public GameObject elements;
    private bool is_game_running;

    void Start()
    {
        is_game_running = false;
        Hide_targets();
        Go_game();
    }

    void Update()
    {
        //cuando de click a start en el menu mandar a llamar la funcion Go_game();
    }

    public void Go_game()
    {
        if(is_game_running == false)
        {
            timer_script.SetRunning();
            audio_boton_inicio.Play();
            elements.SetActive(true);
            is_game_running = true;
        }
    }

    public void Hide_targets()
    {
        elements.SetActive(false);
    }
}
