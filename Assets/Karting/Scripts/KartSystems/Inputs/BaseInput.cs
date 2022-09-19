using UnityEngine;

namespace KartGame.KartSystems
{
    public struct InputData
    {
        /// </summary>
        public bool Accelerate;
        //public bool BoostAccelerate;
        public bool Brake;
        public float TurnInput;
    }

    public interface IInput
    {
        InputData GenerateInput();
    }

    public abstract class BaseInput : MonoBehaviour, IInput
    {
        /// <summary>
        /// Override this function to generate an XY input that can be used to steer and control the car.
        /// </summary>
        public abstract InputData GenerateInput();
    }
}
