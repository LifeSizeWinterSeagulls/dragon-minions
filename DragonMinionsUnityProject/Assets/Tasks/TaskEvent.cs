using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class TaskEvent : UnityEvent<TaskEventArgs> { }

public class TaskEventArgs
{
	public readonly TaskObject task;

	public TaskEventArgs(TaskObject task)
	{
		this.task = task;
	}
}
