using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    // Start is called before the first frame update
    void Start(){}
    // Update is called once per frame
    void Update(){}
		//////////////////////////
	public void ButtonStart(){
		SceneManager.LoadScene ("2_introducao");
	}
	public void ButtonLoad(){
			EditorUtility.DisplayDialog("tela de resposta", "ok ?","ok", "Not ok");
	}
	public void ButtonInstrucao(){
			EditorUtility.DisplayDialog("tela de resposta", "ok ?","ok", "Not ok");
	}
	public void ButtonOptions(){
			EditorUtility.DisplayDialog("tela de resposta", "ok ?","ok", "Not ok");
	}
}
