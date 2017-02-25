using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1;

	private Rigidbody rb;

	//chamado no primeiro frame quando o script é ativado
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	//chamado antes de cada frame ser renderizado
	void Update()
	{

	}

	//chamado antes de fazer um cálculo de physics
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}
