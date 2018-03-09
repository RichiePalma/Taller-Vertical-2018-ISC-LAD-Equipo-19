using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionNube : MonoBehaviour {

    public GameObject[] nubesitas = new GameObject[4];

    void Start(){
        StartCoroutine(AprareceNube());
    }

    private Vector3 Posicion(){
        Vector3 xyz = new Vector3(-10,Random.Range(13, 31), Random.Range(-20,15));
        return xyz;
    }

    private int RandomAparecer(){
        int tiempoNube = Random.Range(1, 2);
        return tiempoNube;
    }

    private int NumArrayNubesitas(){
        int x = Random.Range(0, 4);
        return x;
    }

    IEnumerator AprareceNube(){
        while (true){
            yield return new WaitForSeconds(RandomAparecer());
            // GameObject nube = Instantiate(cloud, Posicion(), transform.rotation);
            int numNube = NumArrayNubesitas();
            GameObject nube = Instantiate(nubesitas[numNube], Posicion(), nubesitas[numNube].transform.rotation);
            //float x = Random.Range(1, 3);
            //nube.transform.localScale = new Vector3(x, x, x);
        }
    }
}
