using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingData
{
    private string _code; //building no.
    private int _healthpoints; //building healthpoints

    public BuildingData(string code, int healthpoints) //implement values when call this method
    {
        _code = code;
        _healthpoints = healthpoints;
    }

    public string Code { get => _code; } //get No.
    public int HP { get => _healthpoints; } //get HP
}
