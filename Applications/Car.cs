namespace Applications
{
    public class Car : ICar
	{
        private readonly IEngine _engine;
        private readonly IWheel _wheel;

		public Car(IEngine engine, IWheel wheel)
		{
            _engine = engine;
            _wheel = wheel;
		}

        public void MoveBackward()
        {
            SpinWheels(1);
        }

        public void MoveForward()
        {
            SpinWheels(2);
        }

        public void Start()
        {
            _engine.Start();
        }

        public void Stop()
        {
            _engine.Stop();
        }

        private void SpinWheels(int dirction)
        {
            _wheel.Spin();
        }
    }
}

