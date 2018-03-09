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
	public GameObject boteC;
	public GameObject boteF;
	public GameObject boteR;
	public GameObject boteS;
	int fel, sus, rec, con;

	public Text boteCT;
	public Text boteFT;
	public Text boteRT;
	public Text boteST;

	public int felicidad, sustentabilidad , recursos , contaminacion;

	string[] preguntas = { "El bosque de la región se ha quemado...", 
		"La ciudad se ha quedado sin energía suficiente...", 
		"El hospital general se ha quedado sin energía",
		"¿En qué deseas invertir?", 
		"La ciudad se encuentra en crisis financiera...", 
		"La principal productora de energía no cumple con los estándares internacionales...",
		"Un parque eólico planea ser construido en una zona de viviendas indígenas", 
		"Una presa de energia hidraulica planea ser construida en una reserva ecológica marina:",
		"De repente hay crisis energética...",
		"Se planea invertir hacia energías renovables...", 
		"Se busca innovar la sustentabildad en el sector agricola...",
		"¿Qué prefieres fomentar en tus ciudadanos?",
		"Decides comprar paneles solares...", 
		"Los paneles solares ya existentes crean cortos circuitos...",
		"Se quiere construir una nueva central eléctrica en la ciudad...",
		"Existe demasiado tráfico en la ciudad, prefieres:", 
		"Te quieren premiar como la ciudad más limpia con un fondo monetario", 
		"El dinero recudado puede ser invertido en infraestructura sostenible",
		"Debes mucho dinero al banco mundial", 
		"Se planea invertir en una refineria para crear mas empleos:",
		"Ser partícipe a la ciudad dentro de una convención contra el cambio climático",
		"Realizar una campaña donde el gobernador viaje por la ciudad reforestando",
		"Proponen una iniciativa de construcción de una planta nuclear", 
		"Una organización mundialmente conocida que regula normas del medio ambiente invito a tu país a formar parte del acuerdo internacional",
		"Ciertas compañías se vieron afectadas en sus finazas por aceptar regulaciones internacionales a la ecología", 
		"Incluir sustentabilidad como parte de la educación elemental",
		"Un grupo de estudiantes te pide financiar su proyecto de energía de Biomasa sustentable", 
		"La energía geotérmica es de las energías sustentables menos investigadas",
		"De invertir en alguna de estas nuevas tecnologías, ¿por cuál te inclinarías?",
		"El gobierno no sabe que hacer con 10 hectareas de terreno...",
		"¿Implementarías un proyecto sustentable aunque tuvieras que invertir una gran cantidad de dinero?",
		"¿A cuál de estos tipos de enrgía invertirias capital?",
		"Hay dinero para renovar la infraestructura de las plantas suministradoras de energía, ¿Cuál mejorarías?",
		"La ciudad es comienza hacer eventos deportivos",
		"Se propone la construcción de una carretera que pasará por una reserva protegida",
		"Los habitantes que residen cerca de la planta nuclear se quejan por los posibles peligros que hubiera en caso de un accidente",
		"Una compañia eléctrica te propone producir electricidad a un bajo costo explotando más los recursos naturales",
		"El país al cual le compras recursos fósiles para la producción de energía, decide aumentar sus precios en cuanto al producto",
		"Una empresa te ofrece un contrato de construcción de un nuevo fraccionamiento en una zona donde habitan diferentes especies de seres vivos"
		};

	string[] respuestas1 = { " Reforestarlo ", 
		" Usar combustibles fósiles ", 
		" Usar combustibles fósiles ",
		" En una refinería de petróleo ", 
		" Decides recortar proyectos sustentables ", 
		" Decides clausurarla ",
		" La construyes desalojando a las familias ", 
		" Destruyes ecosistemas para hacer las presas ",
		" Compras petróleo extranjero a precios elevados ",
		" Decides invertir en la investigación de biomasa como fuente de energía sustentable ",
		" Decides invertir en infraestructura para los agricultores ",
		" La educación del pueblo ",
		" Consigues de gama media-baja a precio económico ", 
		" Decides removerlos todos para no arriesgarte ",
		" Decides construirla ",
		" Comenzar la construcción de una nueva carretera a largo plazo ", 
		" Tomar ese fondo monetario ", 
		" Hacer una planta nuclear ",
		" Recortar fondos de investigacion de energías sustentables ",
		" Invertir ella ",
		" Asistir ", 
		" Aceptar ",
		" Realizar el seguimiento correspondiente ", 
		" Formar parte del acuerdo, teniendo mano dura para el medio ambiente ", 
		" Dejar de formar parte en la siguiente cumbre ",
		" Incluirlo dentro del programa educativo ", 
		" Apoyarlos ", 
		" Aceptarías abrir una investigación para saber más al respecto ",
		" Energía solar ",
		" Construir viviendas ",
		" Implementar ",
		" Energía a partir de biomasa " ,
		" Solar ",
		" Ayudar a la población a organizarlos ",
		" Aprovar la construcción del proyecto ",
		" Clausurar la planta ",
		" Aceptar la oferta ",
		" Dejar de comprar ",
		" Aceptar la petición "};

	string[] respuestas2 = { " Construir un orfanato en su lugar ", 
		" Construir paneles solares en lugares públicos ", 
		" Dejar de abastecer de energia el hospital ",
		" En nuevas energías sustentables ", 
		" Decides pedir al banco un préstamo con grandes intereses ", 
		" Falsificas los documentos necesarios para salvar la compañía ",
		" Aumentas los precios publicos de la gasolina ", 
		" Desmantelas a la zona pesqueras y con ello quitas empleos ",
		" Usas ese dinero para subsidiar el precio de la gasolina pública ",
		" Equipas edificios y lugares públicos con páneles solares ",
		" Decides invertir en estudiar al sistema para hacerlo más sustentable ",
		" La economía del pueblo ",
		" De calidad alta y duradera a un precio alto ", 
		" Inviertes en la costosa reparación de cada uno ",
		" Continúas con la misma infraestructura ",
		" Hacer campañas a favor del transporte público ", 
		" Rechazar porque ser la ciudad más limpia no es un premio, sino una responsabilidad ", 
		" Hacer una planta maremotriz ",
		" Recortar fondos de infraestructura ",
		" Invertir en una planta eólica pese a la falta de empleos ",
		" Rechazar invitación ", 
		" Negarse ",
		" No hacerlo pese a que los problemas energéticos puedan aumentar ", 
		" No participar en el tratado ", 
		" Buscar nuevos inversores que  cumplan con las normas ",
		" Decides no incluirlo ", 
		" Continuas con las energias existentes ", 
		" Destinar los recursos al sector agrícola ",
		" Energía eólica", 
		" Venderlas a empresas productoras de energía",
		" Gastar ese capital en otro campo ",
		" Energía termogénica ", 
		" Eólica ",
		" No participar ",
		" Rechazar ",
		" Hacerle ver a tus habitantes que es seguro el lugar ",
		" Rachazarla y buscar otras alternativas ",
		" Invertir en el sector tecnológico para la obtención de combustibles fósiles ",
		" Rechazar la petición "
		};
		

	//Pregunta[] arr;
	Pregunta p;
	// Use this for initialization
	void Start () {
		fel = felicidad;
		con = contaminacion;
		sus = sustentabilidad;
		rec = recursos;
		boteCT.text = "Contaminacion: " + contaminacion;
		boteRT.text = "Recursos: " + recursos;
		boteST.text = "Sustentabilidad: " + sustentabilidad;
		boteFT.text = "Felicidad: " + felicidad;
		p = new Pregunta (pregunta, respuesta1, respuesta2, preguntas[i], respuestas1[i], respuestas2[i]);

		RenderSettings.fogDensity = contaminacion/1000f;
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
		checarNeblina ();
		checarSustentabilidad ();
		checarRecursos ();
		checarFelicidad ();
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
		checarNeblina ();
		checarSustentabilidad ();
		checarRecursos ();
		checarFelicidad ();
		rotarPosicionNormal ();
	}

	void checarNeblina(){
		Spawn c = (Spawn)boteC.GetComponent (typeof(Spawn));
		c.Contaminacion (con, contaminacion);
		boteCT.text = "Contaminacion: " + contaminacion;
		RenderSettings.fogDensity = contaminacion/1000f;
	}

	void checarFelicidad(){
		Spawn f = (Spawn)boteF.GetComponent (typeof(Spawn));
		f.Felicidad (fel, felicidad);
		boteFT.text = "Felicidad: " + felicidad;
		if (felicidad < 50) {
			GameObject[] monos = GameObject.FindGameObjectsWithTag("Felicidad");
			foreach (GameObject mono in monos)
			{
				mono.GetComponent<Animator>().SetBool("HappyB", false);
			}
		} else {
			GameObject[] monos = GameObject.FindGameObjectsWithTag("Felicidad");
			foreach (GameObject mono in monos)
			{
				mono.GetComponent<Animator>().SetBool("HappyB", true);
			}
		}
	}

	void checarRecursos(){
		Spawn r = (Spawn)boteR.GetComponent (typeof(Spawn));
		r.Recursos (rec, recursos);
		boteRT.text = "Recursos: " + recursos;
		if (recursos < 50 && recursos >= 30) {
			GameObject[] objetosTagRecursos = GameObject.FindGameObjectsWithTag ("Recursos");
			for (int i = 0; i < objetosTagRecursos.Length / 2; i++) {
				GameObject obj = objetosTagRecursos [i];
				obj.SetActive(false);
			}
			GameObject[] objetosTagRecursosM = GameObject.FindGameObjectsWithTag ("RecursosM");
			for (int i = 0; i < objetosTagRecursosM.Length / 2; i++) {
				GameObject obj = objetosTagRecursosM [i];
				obj.GetComponent<Animator> ().enabled = false;
			}
		} else if (recursos < 30) {
			GameObject[] objetosTagRecursos = GameObject.FindGameObjectsWithTag ("Recursos");
			for (int i = 0; i < objetosTagRecursos.Length; i++) {
				GameObject obj = objetosTagRecursos [i];
				obj.SetActive(false);
			}
			GameObject[] objetosTagRecursosM = GameObject.FindGameObjectsWithTag ("RecursosM");
			for (int i = 0; i < objetosTagRecursosM.Length; i++) {
				GameObject obj = objetosTagRecursosM [i];
				obj.GetComponent<Animator> ().enabled = false;
			}
		} else {
			GameObject[] objetosTagRecursos = GameObject.FindGameObjectsWithTag ("Recursos");
			for (int i = 0; i < objetosTagRecursos.Length; i++) {
				GameObject obj = objetosTagRecursos [i];
				obj.SetActive(true);
			}
			GameObject[] objetosTagRecursosM = GameObject.FindGameObjectsWithTag ("RecursosM");
			for (int i = 0; i < objetosTagRecursosM.Length; i++) {
				GameObject obj = objetosTagRecursosM [i];
				obj.GetComponent<Animator> ().enabled = true;
			}
		}
	}

	void checarSustentabilidad(){
		Spawn s = (Spawn)boteS.GetComponent (typeof(Spawn));
		s.Sustentabilidad (sus, sustentabilidad);
		boteST.text = "Sustentabilidad: " + sustentabilidad;
		if (sustentabilidad < 50 && sustentabilidad >= 30) {
			GameObject[] objetosTagSustentabilidad = GameObject.FindGameObjectsWithTag ("Sustentabilidad");
			for (int i = 0; i < objetosTagSustentabilidad.Length / 2; i++) {
				GameObject obj = objetosTagSustentabilidad [i];
				obj.GetComponent<MeshRenderer> ().enabled = false;
			}
		} else if (sustentabilidad < 30) {
			GameObject[] objetosTagSustentabilidad = GameObject.FindGameObjectsWithTag ("Sustentabilidad");
			for (int i = 0; i < objetosTagSustentabilidad.Length; i++) {
				GameObject obj = objetosTagSustentabilidad [i];
				obj.GetComponent<MeshRenderer> ().enabled = false;
			}
		} else {
			GameObject[] objetosTagSustentabilidad = GameObject.FindGameObjectsWithTag ("Sustentabilidad");
			for (int i = 0; i < objetosTagSustentabilidad.Length; i++) {
				GameObject obj = objetosTagSustentabilidad [i];
				obj.GetComponent<MeshRenderer> ().enabled = true;
			}
		}
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
