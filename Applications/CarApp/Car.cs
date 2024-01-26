namespace Applications
{
    public class Car : ICar
	{
        private readonly IEngine _engine;
        private readonly IWheel _frontPassangerWheel;
        private readonly IWheel _frontDriverWheel;
        private readonly IWheel _rearPassangerWheel;
        private readonly IWheel _rearDriverWheel;

        public Car(IEngine engine, IWheel frontPassangerWheel, IWheel frontDriverWheel, IWheel rearPassangerWheel, IWheel rearDriverWheel)
		{
            _engine = engine;
            _frontPassangerWheel = frontPassangerWheel;
            _frontDriverWheel = frontDriverWheel;
            _rearPassangerWheel = rearDriverWheel;
            _rearDriverWheel = rearDriverWheel;
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
            _frontPassangerWheel.Spin();
            _frontDriverWheel.Spin();
            _rearPassangerWheel.Spin();
            _rearDriverWheel.Spin();
        }
    }
}

