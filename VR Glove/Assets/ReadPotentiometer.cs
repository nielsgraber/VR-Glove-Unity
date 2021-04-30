using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Uduino;

public class ReadPotentiometer : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;

    UduinoManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = UduinoManager.Instance;

        manager.pinMode(AnalogPin.A0, PinMode.Input);
        manager.pinMode(AnalogPin.A1, PinMode.Input);
        manager.pinMode(AnalogPin.A2, PinMode.Input);

    }

    // Update is called once per frame
    void Update()
    {
        int analogValue1 = manager.analogRead(AnalogPin.A0);
        int analogValue2 = manager.analogRead(AnalogPin.A1);
        int analogValue3 = manager.analogRead(AnalogPin.A2);

        // 0  - 1024
        slider1.value = (float)analogValue1 / 1000.0f;
        slider2.value = (float)analogValue2 / 1000.0f;
        slider3.value = (float)analogValue3 / 1000.0f;
    }
}
