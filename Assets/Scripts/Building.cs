using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building
{
    private BuildingData _data;
    private Transform _transform;
    private int _currentHealth;

    public Building(BuildingData data)
    {
        _data = data;
        _currentHealth = data.HP;

        GameObject g = GameObject.Instantiate(
            Resources.Load($"Prefabs/Buildings/{_data.Code}")
            ) as GameObject;
        _transform = g.transform;
    }

    public void SetPosition(Vector3 position)
    {
        _transform.position = position;
    }

    public string Code { get => _data.Code; }
    public Transform Transform { get => _transform; }
    public int HP { get => _currentHealth; set => _currentHealth = value; }
    public int MaxHP { get => _data.HP; }
    public int DataIndex
    {
        get
        {
            for(int i = 0; i < Globals.BUILDING_DATA.Length; i++)
            {
                if(Globals.BUILDING_DATA[i].Code == _data.Code)
                {
                    return i; //result of match found
                }
            }
            return -1; //result of no match
        }
    }
}
