using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		//pega a diferença da posição xyz da câmera com o player
		offset = transform.position - player.transform.position;
	}
	
	//chamado quando todos os itens foram processados pelos seus respectivos updates
	//garante com que todos os itens tenham se movimentado antes da câmera ser posicionada
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
