using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private float _walkSpeed = 10f;

    private CharacterController _characterController;

	private void Awake()
	{
		_characterController = GetComponent<CharacterController>();
	}

	private void Update()
	{


		Vector3 inputVector = new Vector3
		{
			x = Input.GetAxisRaw("Horizontal"),
			y = 0,
			z = Input.GetAxisRaw("Vertical")
		};

		Vector3 moveVector = inputVector.normalized * _walkSpeed;
		_characterController.SimpleMove(moveVector);
	}
}
