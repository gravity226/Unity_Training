using UnityEngine;
using Assets.Code.States;
using Assets.Code.Interfaces;

public class StateManager : MonoBehaviour {

	private IStateBase activeState;

	private static StateManager instanceRef;

	void Awake()
	{
		if (instanceRef == null) {
			instanceRef = this;
			DontDestroyOnLoad (gameObject);
		} else {
			DestroyImmediate(gameObject);
		}
	}

	//
	// extra white space to line up book with code here.

	// Use this for initialization
	void Start () {
		activeState = new BeginState (this);
	}
	
	// Update is called once per frame
	void Update () {
		if (activeState != null) {
			activeState.StateUpdate();
		}
	}

	void OnGUI()
	{
		if (activeState != null) {
			activeState.ShowIt();
		}
	}

	public void SwitchState(IStateBase newState)
	{
		activeState = newState;
	}
}
