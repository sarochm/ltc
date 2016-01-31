namespace LtcService
{
    public interface IEvaluator
    {
        bool Tick();
        void ResetCountdown();
        void Initialize();
    }
}