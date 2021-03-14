using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData", order = 1)]
public class LevelData : ScriptableObject
{
    public int numberOfPlayers;

    public void SetNumberOfPlayers(int newNumber) {
        if (newNumber >= 2 && newNumber <= 4)
        {
            numberOfPlayers = newNumber;
        }
    }
}
