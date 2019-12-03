using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUIPrompt : MonoBehaviour
{
	[SerializeField] private Text text;
	[SerializeField] private float lifeTime = 10F;
	private float time = 0F;

	public void DisplayTask(TaskObject task)
	{
		text.text = task.Description;
	}

	private void Update()
	{
		time += Time.deltaTime;
		if (time > lifeTime)
		{
			Destroy(gameObject);
		}
	}
}