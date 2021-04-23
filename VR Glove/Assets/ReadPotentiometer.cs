using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Uduino;

public class ReadPotentiometer : MonoBehaviour
{

    public Slider slider;
    UduinoManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = UduinoManager.Instance;

        manager.pinMode(AnalogPin.A0, PinMode.Input);

    }

    // Update is called once per frame
    void Update()
    {
        int analogValue = manager.analogRead(AnalogPin.A0);
        // 0  - 1024
        slider.value = (float)analogValue / 1000.0f;
    }
}
