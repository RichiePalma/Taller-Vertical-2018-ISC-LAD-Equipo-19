using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject filler;
    public Transform spawn;
    public float maxContaminacion, minContaminacion;
    private Stack<GameObject> damage = new Stack<GameObject>();
    private float avgContaminacion;
    private Pregunta something;
    // Use this for initialization
    void Start()
    {
        //something = new panelScript();
        something = new Pregunta();
        StartCoroutine(setContamination());
        StartCoroutine(genContamination(5));
    }

    // Update is called once per frame

    //Reminder: Remove -1 from minContaminacion inside if's when setting a default starting score
    void Update()
    {

    }

    void starter(int a)
    {
        StartCoroutine(genContamination(a));
    }

    IEnumerator setContamination()
    {
        for (int i = 0; i < maxContaminacion / 2; i++)
        {
            yield return new WaitForSeconds(0.5f);
            GameObject clone = Instantiate(filler, spawn.position, transform.rotation);
            damage.Push(clone);
           // print("Pushed: " + filler.name + "Total Elements: " + damage.Count); //Push track
            avgContaminacion = damage.Count / maxContaminacion * 100;
            print("Contamination score: " + avgContaminacion + "%");
        }

    }

   public  IEnumerator genContamination(int score)
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            if (maxContaminacion > damage.Count && minContaminacion - 1 < damage.Count)
            { //In game
                if (Input.GetKey(KeyCode.Space)) //conditional taste    
                {
                    for (int i = 0; i < score; i++)
                    {
                        yield return new WaitForSeconds(0.2f);
                        GameObject clone = Instantiate(filler, spawn.position, transform.rotation);
                        damage.Push(clone);
                       // print("Pushed: " + filler.name + "Total Elements: " + damage.Count); //Push track
                        avgContaminacion = damage.Count / maxContaminacion * 100;
                        print("Contamination score: " + avgContaminacion + "%");
                        Debug.Log("Felicidad: " + something.felicidad + " Contaminacion: " + something.contaminacion + " Sustentabilidad: " + something.sustentabilidad + " Recursos: " + something.recursos);
                    }
                }
                if (Input.GetKey(KeyCode.A))
                {
                    if (damage.Count != 0)
                    {
                        GameObject toErrase = damage.Pop();
                        print("Popped: " + toErrase.name + "Total Elements" + damage.Count); //Pop track
                        avgContaminacion = damage.Count / maxContaminacion * 100;
                        print("Contamination score: " + avgContaminacion + "%");
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
