using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class FleeAT : ActionTask {

        public Transform targetTransform;
        public BBParameter<Vector3> targetPosition;
        public float fleeDistance; 

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

            //What is the direction thaat we flee from?
            Vector3 directionToTarget =  agent.transform.position - targetTransform.position;

			//How far along that direction do we want to move?
			if (directionToTarget.magnitude <= fleeDistance)
			{
				Vector3 target = fleeDistance * directionToTarget.normalized;
				targetPosition.value = target;
			}

        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}