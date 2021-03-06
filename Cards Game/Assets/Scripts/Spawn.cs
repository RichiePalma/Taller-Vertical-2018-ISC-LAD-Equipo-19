﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawn : MonoBehaviour
{
    public GameObject pelotas;
    public Transform spawn;
    public float maxContaminacion;
    public Stack<GameObject> damage = new Stack<GameObject>();
    public float avgContaminacion  = 0;
    int rep = 0;
    public GameObject panelRespuestas;
    public Text pregunta;
    Pregunta p;
    // Use this for initialization

    void Start()
    {
        StartCoroutine(setContamination());
        StartCoroutine(genContamination());
        //p = new Pregunta(pregunta, "Contaminacion:");
    }

    //Reminder: Remove -1 from minContaminacion inside if's when setting a default starting score
    void Update()
    {
        //p = new Pregunta(pregunta, " " + avgContaminacion);
    }

    public void ActualizarPorcentaje(){
        avgContaminacion = damage.Count / maxContaminacion * 100;
    }

    /*public void MeterBolitas(string nombre, int cuantas){
        if (CompareTag("Contaminacion"){
            for (int i = 0; i<cuantas; i++){
                Instantiate(pelotas, )
            }
        }
    }*/

    IEnumerator setContamination()
    {
        while (rep < maxContaminacion/2)
        {
            yield return new WaitForSeconds(.1f);
            GameObject clone = Instantiate(pelotas, spawn.position + Random.insideUnitSphere * 0.1f, pelotas.transform.rotation);
            damage.Push(clone);
            IncreaseRep();
            ActualizarPorcentaje();
        }
    }

    public void IncreaseRep()
    {
        rep++;
    }

	public void Contaminacion(int pasado, int nuevo){
		if (gameObject.CompareTag("Contaminacion"))
		{
			if (pasado - nuevo > 0) {
				int num = pasado - nuevo;
				for (int i = 0; i < num; i++) {
					GameObject eliminar = damage.Pop();
					DestroyImmediate(eliminar, true);
					ActualizarPorcentaje();
				}
			}
			else if (pasado - nuevo < 0) {
				int num = nuevo - pasado;
				for (int i = 0; i < num; i++) {
					GameObject clone = Instantiate (pelotas, spawn.position, transform.rotation);
					damage.Push (clone);
					ActualizarPorcentaje ();
				}
			}
		}
	}

	public void Recursos(int pasado, int nuevo){
		if (gameObject.CompareTag("Rec"))
		{
			if (pasado - nuevo > 0) {
				int num = pasado - nuevo;
				for (int i = 0; i < num; i++) {
					GameObject eliminar = damage.Pop();
					DestroyImmediate(eliminar, true);
					ActualizarPorcentaje();
				}
			}
			else if (pasado - nuevo < 0) {
				int num = nuevo - pasado;
				for (int i = 0; i < num; i++) {
					GameObject clone = Instantiate (pelotas, spawn.position, transform.rotation);
					damage.Push (clone);
					ActualizarPorcentaje ();
				}
			}
		}
	}

	public void Felicidad(int pasado, int nuevo){
		if (gameObject.CompareTag("Fel"))
		{
			if (pasado - nuevo > 0) {
				int num = pasado - nuevo;
				for (int i = 0; i < num; i++) {
					GameObject eliminar = damage.Pop();
					DestroyImmediate(eliminar, true);
					ActualizarPorcentaje();
				}
			}
			else if (pasado - nuevo < 0) {
				int num = nuevo - pasado;
				for (int i = 0; i < num; i++) {
					GameObject clone = Instantiate (pelotas, spawn.position, transform.rotation);
					damage.Push (clone);
					ActualizarPorcentaje ();
				}
			}
		}
	}

	public void Sustentabilidad(int pasado, int nuevo){
		if (gameObject.CompareTag("Sus"))
		{
			if (pasado - nuevo > 0) {
				int num = pasado - nuevo;
				for (int i = 0; i < num; i++) {
					GameObject eliminar = damage.Pop();
					DestroyImmediate(eliminar, true);
					ActualizarPorcentaje();
				}
			}
			else if (pasado - nuevo < 0) {
				int num = nuevo - pasado;
				for (int i = 0; i < num; i++) {
					GameObject clone = Instantiate (pelotas, spawn.position, transform.rotation);
					damage.Push (clone);
					ActualizarPorcentaje ();
				}
			}
		}
	}

   

    IEnumerator genContamination()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            if (-1 < damage.Count)
            { //In game
                if (Input.GetKey(KeyCode.Space) && CompareTag("Sustentabilidad"))
                {
                    if (maxContaminacion > damage.Count)
                    {
                        GameObject clone = Instantiate(pelotas, spawn.position, transform.rotation);
                        damage.Push(clone);
                        print("Pushed: " + pelotas.name + "Total Elements: " + damage.Count); //Push track
                        avgContaminacion = damage.Count / maxContaminacion * 100;
                        print("Contamination score: " + avgContaminacion + "%");
                    }
                }
                if (Input.GetKey(KeyCode.A) && CompareTag("Felicidad"))
                {
                    if (damage.Count != 0)
                    {
                        GameObject toErrase = damage.Pop();
                        //print("Popped: " + toErrase.name + "Total Elements" + damage.Count); //Pop track
                        avgContaminacion = damage.Count / maxContaminacion * 100;
                        //print("Contamination score: " + avgContaminacion + "%");
                        //print("Errased: " + toErrase.name);

                        DestroyImmediate(toErrase, true);
                    }
                    /*else
                    {
                        print("You're loosing :(");
                    }*/

                }
            }
            else if (maxContaminacion <= damage.Count)
            {
                print("You won");
                break;
            }
            else
            {
                print("GG");
                break;
            }
        }

    }


}