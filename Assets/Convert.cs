using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convert : MonoBehaviour {
	public UnityEngine.UI.Text Output_Text;

	public void Conversion (UnityEngine.UI.Text Input_Text) {
		string Input = Input_Text.text;
		string Output = "";
		for (int i = 0; i < Input.Length; i++) {
			if (i % 2 == 0) {
				Output += Input[i].ToString().ToUpper(); //TODO?: Optimize
			}else {
				Output += Input[i].ToString().ToLower(); //TODO?: Optimize
			}
		}
		Output_Text.text = Output;
	}

	public void Conversion_Random (UnityEngine.UI.Text Input_Text) {
		string Input = Input_Text.text;
		string Output = "";
		foreach (char x in Input) {
			if (Random.Range(0, 2) == 0) {
				Output += x.ToString().ToUpper();
			}else {
				Output += x.ToString().ToLower();
			}
		}
		Output_Text.text = Output;
	}
}
