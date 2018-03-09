using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


	public GameObject menu;
	public GameObject idiomas;
	public GameObject instruccion;
	private int idioma = 0;

	public Button btnIdioma;
	public Button btnInicio;
	public Button btnInstrucciones;
	public Button btnEspañol;
	public Button btnIngles;
	public Button btnRegresar;
	public Button btnRegresar2;
	public RawImage español;
	public RawImage ingles;

	string[] menuIngles = { "BEGIN", "LANGUAGE", "INSTRUCTIONS" };
	string[] idiomasIngles = {"SPANISH","ENGLISH","BACK"};
	string[] instruccionIngles = { "BACK" };

	string[] menuEspañol = { "INICIO", "IDIOMA", "INSTRUCCIONES" };
	string[] idiomasEspañol = {"ESPAÑOL","INGLES","REGRESAR"};
	string[] instruccionEspañol = { "REGRESAR" };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void empezarJuego(){
		if (idioma == 0) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		} else {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
		}
	}

	public void mostrarIdiomas(){
		menu.SetActive (false);
		idiomas.SetActive (true);
		instruccion.SetActive (false);
	}

	public void regresarMenu(){
		menu.SetActive (true);
		idiomas.SetActive (false);
		instruccion.SetActive (false);
	}

	public void mostrarInstrucciones(){
		menu.SetActive (false);
		idiomas.SetActive (false);
		instruccion.SetActive (true);
		if (idioma == 0) {
			español.enabled = true;
			ingles.enabled = false;
		} else {
			español.enabled = false;
			ingles.enabled = true;
		}
	}

	public void cambiarEsp(){
		this.idioma = 0;
		btnInicio.GetComponentInChildren<Text> ().text = menuEspañol[0];
		btnIdioma.GetComponentInChildren<Text> ().text = menuEspañol[1];
		btnInstrucciones.GetComponentInChildren<Text> ().text = menuEspañol[2];
		btnEspañol.GetComponentInChildren<Text> ().text = idiomasEspañol[0];
		btnIngles.GetComponentInChildren<Text> ().text = idiomasEspañol[1];
		btnRegresar.GetComponentInChildren<Text> ().text = idiomasEspañol[2];
		btnRegresar2.GetComponentInChildren<Text> ().text = instruccionEspañol[0];


	}

	public void cambiarIng(){
		this.idioma = 1;
		btnInicio.GetComponentInChildren<Text> ().text = menuIngles[0];
		btnIdioma.GetComponentInChildren<Text> ().text = menuIngles[1];
		btnInstrucciones.GetComponentInChildren<Text> ().text = menuIngles[2];
		btnEspañol.GetComponentInChildren<Text> ().text = idiomasIngles[0];
		btnIngles.GetComponentInChildren<Text> ().text = idiomasIngles[1];
		btnRegresar.GetComponentInChildren<Text> ().text = idiomasIngles[2];
		btnRegresar2.GetComponentInChildren<Text> ().text = instruccionIngles[0];
		español.enabled = false;
		ingles.enabled = true;
	}
		
}
