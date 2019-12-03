using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskObject : MonoBehaviour
{
	[SerializeField] private string description;
	public string Description => description;
}
