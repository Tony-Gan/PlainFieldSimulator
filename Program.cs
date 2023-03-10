using PlainFieldSimulator.Units;
using PlainFieldSimulator.Missions;
using UnityEngine;

namespace PlainFieldSimulator
{
    class Program : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Unit unit = MainCharacterGroupGenerator.GenerateMainCharacter("Tony", 1);
            Debug.Log(unit);
        }
    }
}