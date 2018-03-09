using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelScriptIngles : MonoBehaviour {

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


	string[] questions = {"The forest region has burned down...",
		"There isn't suficient energy for the city",
		"The general hospital does not have energy",
		"What do you want to invest in?",
		"The government has 10 extra acres of land...",
		"A financial crisis has stroke the city",
		"The population wants more sport events",
		"The main energy company doesn't fulfill the international standars",
		"An eolic park needs to be constructed in an indigenous community",
		"A hydraulic power dam plans to be built on a marine ecological reserve:",
		"Suddenly there is energy crisis...",
		"It is planned to invest towards renewable energies...",
		"You are looking to innovate sustainability in the agricultural sector...",
		"What do you prefer to encourage in your citizens?",
		"You decide to buy solar panels...",
		"Existing solar panels create short circuits and fires...",
		"You want to build a new power plant in the city...",
		"There is too much traffic in the city, you prefer to...",
		"They want to reward you as the cleanest city with a monetary fund",
		"Raised money can be invested in sustainable infrastructure",
		"You owe a lot of money to the World Bank",
		"It is planned to invest in a refinery to create more jobs:",
		"Making the city participate in a convention against climate change",
		"Conduct a campaign where the governor travel around the city reforesting",
		"Propose a nuclear plant construction initiative",
		"A world-renowned organization that regulates environmental standards invites your country to join the international agreement...",
		"Certain companies were affected in their finance by accepting international regulations to the ecology",
		"Include sustainability as part of elementary education",
		"A group of students asks you to finance your sustainable biomass energy project",
		"Geothermal energy is the least investigated sustainable energies",
		"The country you buy fossil fuel decides to increase the prices",
		"A big company offers you a contract for a new condo in the place where diferent species live",

		"Which of these new technologies would you like to invest?",
		"Would you invest in an expensive research of a new energy source? ",
		"Choose one of these technologies to invest in",
		"There's enough money for a renovation of the following infrastructures",
		"It is proposed the construction of a road that will pass through a protected reserve",
		"The near-by habitants of the nuclear plant complains about an accident may happen...",
		"An electric company proposes to produce electricity at a low cost by exploiting more natural resources..."};

	string[] answerL = {"You decide to reforest",
		"Use fossil fuels",
		"Use fossil fuels",
		"A petroleum refinery",
		"Build homes",
		"You decide to cut sustainable projects",
		"Help the city organize them",
		"You decide to close it",
		"You build it by evicting families",
		"Destroy ecosystems to make preys",
		"Buy foreign petroleum at high prices",
		"You decide to invest in the research of biomass as a source of sustainable energy",
		"You decide to invest in infrastructure for farmers",
		"The education of the people",
		"You get from middle-low range panel at an affordable price",
		"You decide to remove them all to not risk",
		"You decide to build it",
		"Start building a new long-term highway",
		"Take That Monetary Fund",
		"Make a nuclear plant",
		"Cut Sustainable energy research funds",
		"Invest in it",
		"Attend",
		"Do it",
		"Do the corresponding track",
		"Deciding to be part of the agreement, supporting the environment",
		"Stop being part of the treaty",
		"Include it within the educational program",
		"Support their project",
		"You would agree to open an investigation to learn more about it",
		"Stop buying",
		"Accept it",
		"Solar energy",
		"Implement it",
		"bimass energy",
		"Solar energy\n",
		"Approve project construction",
		"Shut down the plant",
		"Accept the offer"};

	string[] answersR = {"Build an orphanage in that place", 
		"Build solar panels in public places",
		"Stop supplying energy to the hospital",
		"In new sustainable energies",
		"Sell them to energy producing companies",
		"You decide to ask the bank for a loan with big interests",
		"Do not participate in them",
		"Falsify the documents necessary to save the company",
		"You increase the public prices of gasoline",
		"You dismantle to the area fishing and with it you remove work places",
		"You use that money to subsidize the price of public gasoline",
		"Equip buildings and public places with solar breads",
		"You decide to invest in studying the system to make it more sustainable",
		"The economy of the people",
		"High quality and durable at a high price",
		"You invest in the costly repair of each one",
		"Continuing with the same infrastructure",
		"Campaigning in favor of public transport",
		"Reject because being the cleanest city is not a prize, but a responsibility",
		"Make a plant tidal",
		"Cut infrastructure funds",
		"Invest in a wind plant despite the lack of jobs",
		"Reject the invitation",
		"Don't do it",
		"Do not do it despite of the energy necesity",
		"Do not participate in the Treaty",
		"Look for new investors that accept the regulations",
		"You decide not to include it",
		"Continuing with existing energies",
		"Allocate resources to the agricultural sector",
		"Invest in the technology sector for the obtaining of fossil fuels",
		"Reject it ",
		"wind power",
		"Spend that capital in another field",
		"Thermogenic Energy",
		"wind power",
		"Reject the offer",
		"Convince your citizens that the place is safe",
		"Reject it and look up for other alternatives"};

	//Pregunta[] arr;
	PreguntaIngles p;
	// Use this for initialization
	void Start () {
		fel = felicidad;
		con = contaminacion;
		sus = sustentabilidad;
		rec = recursos;
		boteCT.text = "Pollution: " + contaminacion;
		boteRT.text = "Resources: " + recursos;
		boteST.text = "Sustainability: " + sustentabilidad;
		boteFT.text = "Happiness: " + felicidad;
		p = new PreguntaIngles (pregunta, respuesta1, respuesta2, questions[i], answerL[i], answersR[i]);

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
		p = new PreguntaIngles (pregunta, respuesta1, respuesta2, questions[i], answerL[i], answersR[i]);
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
		p = new PreguntaIngles (pregunta, respuesta1, respuesta2, questions[i], answerL[i], answersR[i]);
		checarNeblina ();
		checarSustentabilidad ();
		checarRecursos ();
		checarFelicidad ();
		rotarPosicionNormal ();
	}

	void checarNeblina(){
		Spawn c = (Spawn)boteC.GetComponent (typeof(Spawn));
		c.Contaminacion (con, contaminacion);
		boteCT.text = "Pollution: " + contaminacion;
		RenderSettings.fogDensity = contaminacion/1000f;
	}

	void checarFelicidad(){
		Spawn f = (Spawn)boteF.GetComponent (typeof(Spawn));
		f.Felicidad (fel, felicidad);
		boteFT.text = "Happiness: " + felicidad;
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
		boteRT.text = "Resources: " + recursos;
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
		boteST.text = "Sustainability: " + sustentabilidad;
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

