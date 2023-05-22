using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
	[SerializeField] private Transform _followTarget;

	private void Update()
	{
		transform.position = _followTarget.position;
	}
}
