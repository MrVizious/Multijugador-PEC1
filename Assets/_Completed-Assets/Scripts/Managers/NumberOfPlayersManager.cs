using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    [RequireComponent(typeof(GameManager))]
    public class NumberOfPlayersManager : MonoBehaviour
    {
        public int maxNumberOfPlayers = 4;
        private bool[] playersAlreadyPlaying;

        private void Start() {

            playersAlreadyPlaying = new bool[maxNumberOfPlayers];

            for (int i = 0; i < maxNumberOfPlayers; i++)
            {
                if (i < 2) playersAlreadyPlaying[i] = true;
                else playersAlreadyPlaying[i] = false;
            }

        }

        private void Update() {
            for (int i = 1; i <= maxNumberOfPlayers; i++)
            {
                if (Input.GetButtonDown("Start" + i))
                {
                    if (!playersAlreadyPlaying[i - 1])
                    {
                        playersAlreadyPlaying[i - 1] = true;
                        GetComponent<GameManager>().AddPlayer();
                    }
                }
            }
        }

    }
}