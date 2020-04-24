﻿namespace HQC_Exam___Computers.ComputerFactories
{
    using HQC_Exam___Computers.ComputerComponents;
    using HQC_Exam___Computers.Computers;
    public class DELLFactory : AbstractComputerFactory
    {
        public const string DELLFactoryName = "Dell";

        public override Laptop CreateLaptop()
        {
            var laptopRam = new Ram(8);
            var laptopVideoCard = new ColorfulVideoCard();
            var laptopHardDrive = new HardDriver(1000);
            var laptopCPU = new CPU32(4);

            return new Laptop(laptopCPU, laptopRam, laptopVideoCard, new[] { laptopHardDrive });
        }

        public override PC CreatePC()
        {
            var PCRam = new Ram(8);
            var PCVideoCard = new ColorfulVideoCard();
            var PCHardDrive = new HardDriver(1000);
            var PCCPU = new CPU64(4);

            return new PC(PCCPU, PCRam, PCVideoCard, new[] { PCHardDrive });
        }

        public override Server CreateServer()
        {
            var ServerRam = new Ram(64);
            var ServerHardDrives = new[] { new HardDriver(2000), new HardDriver(2000) };
            var ServerCPU = new CPU64(8);

            return new Server(ServerCPU, ServerRam, ServerHardDrives);
        }
    }
}
