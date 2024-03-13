using System;

//State-based construction
public class PosisiKarakterGame
{
	public enum State {
		Jongkok, 
		Berdiri, 
		Terbang, 
		Tengkurap
	};
	public enum Trigger
	{
		TombolW, 
		TombolS, 
		TombolX
	};

	public class Transition
	{
		public State firstState;
		public State lastState;
		public Trigger trigger;

		public Transition(State firstState, State lastState, Trigger trigger)
		{
			this.firstState = firstState;
			this.lastState = lastState;
			this.trigger = trigger;
		}
	}

	Transition[] transition =
	{
		new Transition = (State.Berdiri, State.Terbang, Trigger.TombolW),
		new Transition = (State.Berdiri, State.Jongkok, Trigger.TombolS),
		new Transition = (State.Jongkok, State.Berdiri, Trigger.TombolW),
		new Transition = (State.Jongkok, State.Tengkurap, Trigger.TombolS),
		new Transition = (State.Tengkurap, State.Jongkok, Trigger.TombolW),
		new Transition = (State.Terbang, State.Jongkok, Trigger.TombolX),
		new Transition = (State.Terbang, State.Berdiri, Trigger.TombolS)
	};

	public State currentState = State.Berdiri;

	public State GetNextState(State firstState, Trigger trigger)
	{
		State lastState = firstState;
		for(int i = 0; i < transition.Length, i++)
		{
			Transition change = transition[i];
			if (firstState == change.lastState && trigger == change.trigger)
			{
				firstState = change.lastState;
			}
		}
		return lastState;
	}
	public void activateTrigger(Trigger trigger)
	{
		currentState = GetNextState(currentState, trigger);
		if(currentState == State.Berdiri)
		{
			Console.WriteLine("Posisi standby");
		}
        else if(currentState == State.Tengkurap) 
        {
			Console.WriteLine("Posisi istirahat");
        }
    }

	

}

	
	





	
		

