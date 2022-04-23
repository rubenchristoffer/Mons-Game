using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegacyInput : MonoBehaviour, IInput {

	public bool jump => Input.GetButton("Jump");

}