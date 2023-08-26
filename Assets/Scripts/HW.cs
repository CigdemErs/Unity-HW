using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int IntNum1, IntNum2;
    public float FloatNum1, FloatNum2;
    public string String1, String2;

    // Start is called before the first frame update
    void Start() {
        // vars are automatically initialized if the user wont
        IfElseInt(IntNum1, IntNum2);
        SwitchFloat();
        WhileStr(String1, String2);
    }

    // parameter
    void IfElseInt(int num1, int num2) {
        if (num1 > num2)
            Debug.Log(num1 + " is bigger than " + num2);
        else if (num2 > num1)
            Debug.Log(num2 + " is bigger than " + num1);
        else
            Debug.Log(num1 + " = " + num2);
    }

    // without parameter
    void SwitchFloat() {
        switch (FloatNum1 / FloatNum2) {
            case 0f:
                Debug.Log("Num1 / Num2 = 0.0");
                break;
            case 1f:
                Debug.Log("Num1 / Num2 = 1.0");
                break;
            case 2f:
                Debug.Log("Num1 / Num2 = 2.0");
                break;
            default:
                Debug.Log("Oops...");
                break;
        }
    }

    void WhileStr(string String1, string String2) {

        string Combined = String1 + String2;

        while (!Combined.Equals(String2)) {
            Debug.Log("Combined: " + Combined);
            Debug.Log("String 2: " + String2);
            Debug.Log("Not equal...\n");
            Combined = Combined.Substring(1);
        }

        Debug.Log("Equal: " + Combined);
    }
}
