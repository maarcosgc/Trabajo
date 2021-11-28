using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlMenu : MonoBehaviour
{
    public GameObject PantallaEspera;
    public GameObject PantallaInicial;
    public GameObject Opciones;
    public GameObject Juego;
    public GameObject Records;
    public Button JugarB;
    public Button OpcionesB;
    public Button RecordsB;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PantallaEspera.SetActive(false);
            PantallaInicial.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PantallaEspera.SetActive(false);
            Juego.SetActive(false);
            Opciones.SetActive(false);
            Records.SetActive(false);
            PantallaInicial.SetActive(true);
        }

       
    
    }
     public void ClickJugarB()
        {
            PantallaInicial.SetActive(false);
            Juego.SetActive(true);
        
        }

        public void ClickOpcionesB()
        {
            PantallaInicial.SetActive(false);
            Opciones.SetActive(true);
        }

        public void ClickRecordsB()
        {
            PantallaInicial.SetActive(false);
            Records.SetActive(true);
        }
}
