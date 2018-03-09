using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PreguntaIngles : MonoBehaviour {

	public Text pregunta { get; set; }
	public Button respuesta1 { get; set; }
	public Button respuesta2 { get; set; }

	public PreguntaIngles(){
	}

	public PreguntaIngles(Text question, Button answerL, Button answerR, string questionText, string answerLText, string answerRText){
		pregunta = question;
		pregunta.text = questionText;

		respuesta1 = answerL;
		respuesta1.GetComponentInChildren<Text> ().text = answerLText;

		respuesta2 = answerR;
		respuesta2.GetComponentInChildren<Text> ().text = answerRText;

	}

	public void puntuacionIzquierda(int a, panelScriptIngles panel){
		Debug.Log ("Felicidad: " + panel.felicidad + " Contaminacion: "+ panel.contaminacion + " Sustentabilidad: " + panel.sustentabilidad + " Recursos: " + panel.recursos);
		switch(a)
		{
		case 0:
			Debug.Log ("Si entra");
			panel.contaminacion -= 8;
			panel.recursos -= 2;
			panel.felicidad += 5;
			break;
		case 1:
			panel.contaminacion += 12;
			panel.recursos -= 3;
			panel.felicidad += 2;
			panel.sustentabilidad -= 9;
			break;
		case 2:
			panel.contaminacion += 11;
			panel.recursos -= 4;
			panel.felicidad += 15;
			break;
		case 3:
			panel.contaminacion += 13;
			panel.recursos -= 6;
			panel.felicidad += 5;
			panel.sustentabilidad -= 7;
			break;
		case 4:
			panel.contaminacion += 7;
			panel.recursos += 1;
			panel.felicidad -= 6;
			panel.sustentabilidad -= 11;
			break;
		case 5:
			panel.felicidad -= 9;
			panel.sustentabilidad += 6;
			panel.contaminacion -= 7;
			panel.recursos -= 10;
			break;
		case 6:
			panel.felicidad -= 13;
			panel.sustentabilidad += 9;
			panel.contaminacion -= 3;
			panel.recursos -= 4;
			break;
		case 7:
			panel.sustentabilidad += 11;
			panel.felicidad -= 3;
			panel.contaminacion += 2;
			panel.recursos -= 5;
			break;
		case 8:
			panel.felicidad -= 6;
			panel.contaminacion += 4;
			panel.sustentabilidad -= 6;
			panel.recursos -= 15;
			break;
		case 9:
			panel.sustentabilidad += 9;
			panel.felicidad += 5;
			panel.recursos -= 2;
			panel.contaminacion -= 4;
			break;
		case 10:
			panel.sustentabilidad -= 10;
			panel.felicidad += 2;
			panel.recursos -= 7;
			panel.contaminacion += 5;
			break;
		case 11:
			panel.sustentabilidad += 15;
			panel.recursos -= 5;
			panel.contaminacion -= 15;
			break;
		case 12:
			panel.sustentabilidad += 5;
			panel.felicidad += 5;
			panel.recursos += 10;
			panel.contaminacion -= 5;
			break;
		case 13:
			panel.sustentabilidad -= 10;
			panel.felicidad -= 5;
			panel.recursos += 10;
			panel.contaminacion += 5;
			break;
		case 14:
			panel.sustentabilidad -= 4;
			panel.felicidad += 6;
			panel.recursos -= 8;
			panel.contaminacion += 6;
			break;
		case 15:
			panel.felicidad -= 5;
			panel.recursos -= 10;
			panel.sustentabilidad -= 1;
			panel.contaminacion += 3;
			break;
		case 16:
			panel.felicidad += 10;
			panel.recursos += 12;
			panel.sustentabilidad += 6;
			break;
		case 17:
			panel.sustentabilidad += 6;
			panel.felicidad -= 6;
			break;
		case 18:
			panel.contaminacion -= 5;
			panel.recursos += 5;
			panel.felicidad -= 5;
			panel.sustentabilidad -= 2;
			break;
		case 19:
			panel.felicidad += 6;
			panel.recursos -= 6;
			panel.contaminacion += 7;
			panel.sustentabilidad -= 3;
			break;
		case 20:
			panel.sustentabilidad += 5;
			panel.recursos -= 2;
			panel.contaminacion -= 3;
			break;
		case 21:
			panel.recursos -= 3;
			panel.felicidad += 4;
			panel.sustentabilidad += 4;
			break;
		case 22:
			panel.felicidad += 5;
			panel.sustentabilidad += 8;
			panel.contaminacion -= 2;
			panel.recursos -= 2;
			break;
		case 23:
			panel.felicidad += 6;
			panel.sustentabilidad += 5;
			panel.contaminacion -= 2;
			panel.recursos -= 8;
			break;
		case 24:
			panel.felicidad -= 3;
			panel.sustentabilidad -= 5;
			panel.contaminacion += 2;
			panel.recursos += 3;
			break;
		case 25:
			panel.felicidad += 2;
			panel.sustentabilidad += 5;
			panel.contaminacion -= 2;
			break;
		case 26:
			panel.felicidad += 3;
			panel.sustentabilidad += 5;
			panel.contaminacion -= 2;
			panel.recursos -= 3;
			break;
		case 27:
			panel.felicidad += 2;
			panel.sustentabilidad += 5;
			panel.contaminacion -= 2;
			panel.recursos -= 4;
			break;
		case 28:
			panel.contaminacion += 5;
			panel.recursos += 2;
			break;
		case 29:
			panel.contaminacion += 1;
			panel.recursos -= 5;
			panel.felicidad += 6;
			break;
		case 30:
			panel.felicidad -= 6;
			panel.sustentabilidad += 2;
			panel.recursos += 5;
			break;
		case 31:
			panel.felicidad += 11;
			panel.sustentabilidad -= 2;
			panel.contaminacion += 1;
			panel.recursos -= 3;
			break;
		case 32:
			panel.felicidad += 3;
			panel.sustentabilidad -= 4;
			panel.contaminacion -= 5;
			panel.recursos -= 7;
			break;
		case 33:
			panel.felicidad += 15;
			panel.sustentabilidad -= 9;
			panel.contaminacion += 8;
			panel.recursos -= 10;
			break;
		case 34:
			panel.felicidad += 10;
			panel.sustentabilidad -= 3;
			panel.contaminacion += 1;
			panel.recursos -= 5;
			break;
		case 35:
			panel.felicidad += 6;
			panel.sustentabilidad -= 5;
			panel.contaminacion -= 5;
			panel.recursos -= 2;
			break;
		case 36:
			panel.felicidad -= 6;
			panel.recursos -= 2;
			break;
		case 37:
			panel.felicidad += 6;
			panel.recursos -= 6;
			break;
		case 38:
			panel.felicidad += 5;
			panel.recursos -= 5;
			break;
		default:
			break;
		}
	}

	public void puntuacionDerecha(int a, panelScriptIngles panel){
		Debug.Log ("Felicidad: " + panel.felicidad + " Contaminacion: "+ panel.contaminacion + " Sustentabilidad: " + panel.sustentabilidad + " Recursos: " + panel.recursos);
		switch(a)
		{
		case 0:
			panel.contaminacion += 4;
			panel.recursos -= 5;
			panel.felicidad += 8;
			break;
		case 1:

			panel.recursos -= 6;
			panel.sustentabilidad += 8;
			break;
		case 2:

			panel.felicidad -= 15;
			break;
		case 3:
			panel.recursos -= 8;
			panel.sustentabilidad +=5;
			break;
		case 4:

			panel.recursos += 5;
			panel.felicidad +=3;

			break;
		case 5:
			panel.felicidad += 7;
			panel.sustentabilidad -= 8;
			panel.contaminacion += 7;
			panel.recursos += 5;
			break;
		case 6:
			panel.felicidad += 5;

			panel.contaminacion += 6;
			panel.recursos -= 6;
			break;
		case 7:
			panel.sustentabilidad += 11;
			panel.felicidad -= 8;

			panel.recursos -= 5;
			break;
		case 8:
			panel.felicidad += 6;
			panel.contaminacion += 2;
			panel.sustentabilidad -= 5;
			panel.recursos -= 15;
			break;
		case 9:
			panel.sustentabilidad += 15;
			panel.felicidad += 5;
			panel.recursos -= 6;
			panel.contaminacion -= 10;
			break;
		case 10:
			panel.sustentabilidad += 9;
			panel.felicidad += 6;
			panel.recursos -= 1;
			panel.contaminacion -= 2;
			break;
		case 11:
			panel.sustentabilidad += 6;
			panel.recursos += 5;
			panel.recursos -= 5;
			break;
		case 12:
			panel.sustentabilidad += 15;
			panel.felicidad += 10;
			panel.recursos -= 10;
			panel.contaminacion -= 15;
			break;
		case 13:
			panel.sustentabilidad += 10;
			panel.felicidad += 5;
			panel.recursos -= 10;
			panel.contaminacion -= 15;
			break;
		case 14:
			panel.sustentabilidad += 2;
			panel.felicidad -= 4;

			break;
		case 15:
			panel.felicidad += 1;
			panel.recursos -= 2;
			panel.sustentabilidad += 8;
			panel.contaminacion -= 5;
			break;
		case 16:
			panel.felicidad -= 5;
			panel.recursos -= 5;
			panel.sustentabilidad -= 5;
			break;
		case 17:
			panel.sustentabilidad += 3;
			panel.felicidad += 4;
			break;
		case 18:

			panel.recursos += 5;
			panel.felicidad -= 6;

			break;
		case 19:
			panel.felicidad -= 4;
			panel.recursos -= 5;
			panel.contaminacion -= 3;
			panel.sustentabilidad += 7;
			break;
		case 20:
			panel.felicidad -= 2;
			break;
		case 21:
			panel.contaminacion += 3;
			panel.felicidad -= 4;

			break;
		case 22:
			panel.felicidad += 5;
			break;
		case 23:
			panel.felicidad -= 3;
			panel.sustentabilidad -= 2;
			panel.contaminacion += 4;
			panel.recursos += 3;
			break;
		case 24:
			panel.felicidad += 3;
			panel.sustentabilidad += 5;
			panel.contaminacion -= 2;
			panel.recursos -= 2;
			break;
		case 25:
			panel.felicidad -= 1;
			panel.sustentabilidad -= 2;
			panel.contaminacion += 2;
			break;
		case 26:

			panel.sustentabilidad -= 5;
			panel.contaminacion += 2;

			break;
		case 27:
			panel.felicidad += 3;
			panel.sustentabilidad -= 1;
			panel.contaminacion += 2;
			panel.recursos -= 5;
			break;
		case 28:
			panel.felicidad += 3;
			panel.sustentabilidad += 5;
			panel.contaminacion -= 4;
			panel.recursos -= 4;
			break;
		case 29:
			panel.contaminacion += 3;
			panel.recursos += 4;
			panel.felicidad -= 4;
			break;
		case 30:
			panel.felicidad += 3;
			panel.recursos -= 6;
			break;
		case 31:
			panel.felicidad -= 9;

			break;
		case 32:

			panel.recursos -= 4;
			break;
		case 33:
			panel.felicidad -= 14;

			break;
		case 34:
			panel.felicidad += 15;
			panel.sustentabilidad -= 3;
			panel.contaminacion += 4;
			panel.recursos -= 8;
			break;
		case 35:
			panel.felicidad -= 4;
			break;
		case 36:
			panel.felicidad += 7;
			panel.recursos -= 8;
			break;
		case 37:
			panel.felicidad -= 8;
			break;
		case 38:
			panel.felicidad += 5;
			break;
		default:
			break;
		}
	}
}
