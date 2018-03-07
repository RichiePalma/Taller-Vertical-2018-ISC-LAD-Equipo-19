using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelScript : MonoBehaviour {
	public GameObject panelRespuestas;
	int i = 0;
	public Text pregunta;
	public Button respuesta1;
	public Button respuesta2;

	public int felicidad = 50, sustentabilidad =50 , recursos = 50, contaminacion = 50;

	string[] preguntas = { "Se quemo el bosque", "No hay energia suficiente", "Se fue la luz en un hospital",
		"invertir en:", "Hay crisis financiera", "La principal productora de energia no cumple con los estandares internacionales: ",
		"Un parque eolico planea ser construido en una zona de viviendas indigenas", "Una presa de energia hidraulica planea ser construida en una reserva ecologica marina:",
		"De repente hay crisis energética:","Se planea hacer una inversion hacia energias renovables", "Se busca innovar la sustentabildad en el sector agricola:",
		"Fomentar: ","Comprar dos tipos de paneles solares", "Se ponen paneles solares y causan cortos e incencios",
		"Se quiere construir una nueva central electrica en la ciudad","Existe demasiado tráfico en la ciudad, prefieres:", 
		"Te quieren premiar como la ciudad más limpia con un fondo monetario", "El dinero recudado puede ser invertido en infraestructura sostenible",
		"Debes mucho dinero al banco mundial", "Se planea invertir en una refineria para crear mas empleos:",
		"Asistir a una convención contra el cambio climatico","Realizar una campaña donde el gobernador viaje por la ciudad reforestando",
		"Proponen una iniciativa de construcción de una planta nuclear", "Una organización mundialmente conocida que regula normas del medio ambiente invito a tu país a formar parte del acuerdo internacional",
		"Ciertas compañías se vieron afectadas en sus finazas por aceptar el tratado", 
		"Incluir sustentabilidad como parte de la educación elemental","Un grupo de estudiantes te pide financiar su proyecto de Biomasa sustentable", 
		"La energía geotérmica es de las energías sustentables menos investigadas"};

	string[] respuestas1 = { "Reforestar", "Usar combustible fosil", "Darle abasto de fosiles",
		"Refineria de petroleo.", "Recortar proyectos sutentables", "Clausurarla",
		"Construirla desalojando a las familias", "Destruir el ecosistema para hacer la presa",
		"Compras petroleo extranjero a precios elevados","Se invierte en la investigacion de biomasa como fuente de energia sustentable ",
		"Se invierte en infraestructura",
		"La educación de las energías","De calidad media-baja a un precio economico", "Remover lo paneles solares",
		"Construir la nueva infraestructura","Comenzar la construcción de una nueva carretera a largo plazo", 
		"Tomar ese fondo monetario", "Hacer una planta nuclear",
		"Recortar fondos de investigacion de energias sustentables",
		"Invertir ella",
		"Aceptar", "Aceptar",
		"Realizar el seguimiento correspondiente", "Firmas el acuerdo, teniando mano dura para el medio ambiente", 
		"Dejar de formar parte en la siguiente cumbre","Hacer el cambio", 
		"Inviertes en ellos", "Aceptarias abrir una investigación para saber más al respecto"};

	string[] respuestas2 = { "Orfanato", "Contruir páneles solares", "No darle abasto",
		"Nuevas energias", "Pedir un prestamo al banco con grandes intereses", "Falsificar los resultados necesasrios para salvar la compañia",
		"Subir los precios de la energia fosil", "Desmantelar las zonas pesqueras para construir la presa, quitando empleos",
		"Usas ese dinero para subsifdiar los combustibles publicos","Equipar a edificios publicos con paneles solares",
		"Se invierte en el estudio de la materia",
		"La economía","De calida alta a un precio muy alto", "Invertir en una costosa reparación",
		"Seguir con la misma infraestructura","Hacer campañas a favor del transporte público", 
		"Rechazar porque ser la ciudad más limpia no es un premio, sino una responsabilidad", "Hacer una planta maremotriz",
		"Recortar fondos de infraestructura",
		"Invertir en una planta eolica pese a la falta de empleos",
		"Negarse", "Negarse",
		"No hacerlo pese a que los problemas energeticos puedan aumentar", "No lo firmas", 
		"Buscar nuevos inversores que  cumplan con las normas","No hacerlo", 
		"Sigues con las energias existentes", "Destinar los recursos al sector agricola"};

	//Pregunta[] arr;
	Pregunta p;
	// Use this for initialization
	void Start () {
		//arr = new Pregunta[preguntas.Length];
		//for(int i=0;i<preguntas.Length-1;i++)
		//{
			p = new Pregunta (pregunta, respuesta1, respuesta2, preguntas[i], respuestas1[i], respuestas2[i]);
			//arr [i] = p;
		//}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clickPreguntaIzquierda(){
//		pregunta.text = preguntas[i];
//		respuesta1.GetComponentInChildren<Text> ().text = respuestas1[i];
//		respuesta2.GetComponentInChildren<Text> ().text = respuestas2[i];
//		Pregunta pregunta = arr[i];
//		pregunta.puntuacionIzquierda(i)
		p.puntuacionIzquierda(i, this);
		i++;
		p = new Pregunta (pregunta, respuesta1, respuesta2, preguntas[i], respuestas1[i], respuestas2[i]);
		rotarPosicionNormal ();
	}

	public void clickPreguntaDerecha(){
		//		pregunta.text = preguntas[i];
		//		respuesta1.GetComponentInChildren<Text> ().text = respuestas1[i];
		//		respuesta2.GetComponentInChildren<Text> ().text = respuestas2[i];
		//Pregunta pregunta = arr[i];
		p.puntuacionDerecha(i, this);
		i++;
		p = new Pregunta (pregunta, respuesta1, respuesta2, preguntas[i], respuestas1[i], respuestas2[i]);
		rotarPosicionNormal ();
	}

	public void rotarIzquierda(){
		//Debug.Log ("Rota para mostrar el lado izquierdo");
		iTween.MoveTo(panelRespuestas, iTween.Hash("x", -0.5));
		iTween.RotateTo(panelRespuestas, iTween.Hash("z", 25));


	}

	public void rotarDerecha(){
		//Debug.Log ("Rota para mostrar el lado derecho");
		iTween.MoveTo(panelRespuestas, iTween.Hash("x", 0.5));
		iTween.RotateTo(panelRespuestas, iTween.Hash("z", -25));

	}

	public void rotarPosicionNormal(){
		//Debug.Log ("Rota para mostrar original");
		iTween.MoveTo(panelRespuestas, iTween.Hash("x", 0));
		iTween.RotateTo(panelRespuestas, iTween.Hash("z", 0));
	}
}
