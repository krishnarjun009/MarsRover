using System.Collections.Generic;

namespace MarsRoverPuzzle
{
    public class RoversDeployer
    {
        private readonly Queue<IRover> rovers;

        public RoversDeployer()
        {
            rovers = new Queue<IRover>();
        }

        public RoversDeployer AddRover(IRover rover)
        {
            rovers.Enqueue(rover);
            return this;
        }

        public void Deploy()
        {
            var rover = GetRover();
            if (rover != null)
            {
                //rover.Run();
                Deploy();
            }
        }

        private IRover GetRover() => IsRoversAvaiable() ? rovers.Dequeue() : null;
        public bool IsRoversAvaiable() => rovers.Count > 0;
    }
}
