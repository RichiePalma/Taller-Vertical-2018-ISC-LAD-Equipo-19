using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pregunta : MonoBehaviour {
	
	
	public Text pregunta { get; set; }
	public Button respuesta1 { get; set; }
	public Button respuesta2 { get; set; }

	public Pregunta(){
	}

	public Pregunta(Text question, Button answerL, Button answerR, string questionText, string answerLText, string answerRText){
		pregunta = question;
		pregunta.text = questionText;

		respuesta1 = answerL;
		respuesta1.GetComponentInChildren<Text> ().text = answerLText;

		respuesta2 = answerR;
		respuesta2.GetComponentInChildren<Text> ().text = answerRText;
	
	}

}
