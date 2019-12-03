using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TaskSpawner", fileName = "TaskSpawner")]
public class TaskSpawner : ScriptableObject
{
	[SerializeField] private TaskEvent onSpawnEvent;
	public TaskEvent OnSpawnEvent => onSpawnEvent;

	[SerializeField] private TaskObject taskPrefab;

	[ContextMenu("SpawnTask")]
	public void SpawnTask()
	{
		TaskObject task = Instantiate(taskPrefab);
		TaskEventArgs args = new TaskEventArgs(task);
		onSpawnEvent.Invoke(args);
	}
}
