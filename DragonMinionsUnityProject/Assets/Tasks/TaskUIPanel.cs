using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskUIPanel : MonoBehaviour
{
	[SerializeField] private TaskUIPrompt promptPrefab;
	[SerializeField] private LayoutGroup layoutGroup;

	[SerializeField] private TaskSpawner spawner;

	private void Awake()
	{
		spawner.OnSpawnEvent.AddListener(HandleOnTaskSpawn);
	}

	public void HandleOnTaskSpawn(TaskEventArgs args)
	{
		TaskUIPrompt prompt = Instantiate(promptPrefab);
		prompt.transform.parent = layoutGroup.transform;
		prompt.DisplayTask(args.task);
	}

	private void OnDestroy()
	{
		spawner.OnSpawnEvent.RemoveListener(HandleOnTaskSpawn);
	}
}