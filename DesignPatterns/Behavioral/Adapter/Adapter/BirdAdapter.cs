namespace Adapter
{
    public class BirdAdapter : IToyDuck
    {
        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }

        private readonly IBird _bird;
        public void Squeak()
        {
            _bird.MakeSound();
        }
    }
}
