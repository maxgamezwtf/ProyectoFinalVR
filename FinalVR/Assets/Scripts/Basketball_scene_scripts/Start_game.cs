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
    public GameObject UI_interfaceStart;
    private bool is_game_running; 
    public General_Script general_script_script;
    public MoveHoodBasket primaryHoodBasketScript;

    void Start()
    {
        is_game_running = false;
        Hide_targets();
        //Go_game();
    }

    void Update()
    {
        //cuando de click a start en el menu mandar a llamar la funcion Go_game();
        primaryHoodBasketScript.getGameConfiguration(is_game_running);
    }

    public void Go_game()
    {
        if(is_game_running == false)
        {
            primaryHoodBasketScript.resetPositionsHood();
            general_script_script.restartScore();
            audio_boton_inicio.Play();
            UI_interfaceStart.SetActive(false);
            Invoke("DelayTime",3);
        }
    }

    public void DelayTime(){
        timer_script.SetRunning();
        elements.SetActive(true);
        is_game_running = true;
    }

    public void Hide_targets()
    {
        elements.SetActive(false);
    }

    public void SetGameNotRunnig()
    {
        is_game_running = false;
        primaryHoodBasketScript.resetPositionsHood();
    }
}
