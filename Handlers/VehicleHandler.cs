using MonoBrick.EV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EV3_WPF
{
    public class VehicleHandler
    {
        Brick<Sensor, Sensor, Sensor, Sensor> brick;
        sbyte straightSpeed = 30;
        sbyte curveSpeed = 10;
        int turningDeg = 86;

        public VehicleHandler(Brick<Sensor, Sensor, Sensor, Sensor> brick)
        {
            this.brick = brick;
            this.brick.Vehicle.LeftPort = MotorPort.OutA;
            this.brick.Vehicle.RightPort = MotorPort.OutD;
            this.brick.Sensor4 = new GyroSensor(GyroMode.Angle);
        }

        private int DegParser(string str)
        {
            string[] defString = str.Split(' ');
            int convDeg = int.Parse(defString[0]);

            return convDeg;
        }

        public void GoStraight()
        {
            brick.Vehicle.Forward(straightSpeed);
            Thread.Sleep(4000);
            brick.Vehicle.Off();
        }

        public void TurnLeft()
        {
            brick.Vehicle.SpinLeft(curveSpeed, false);
            int currentDegL = DegParser(brick.Sensor4.ReadAsString());

            while (true)
            {
                int deg = DegParser(brick.Sensor4.ReadAsString());
                int diff = currentDegL - deg;
                Console.WriteLine(currentDegL.ToString() + " | " + deg.ToString() + " | " + diff.ToString());

                if (diff >= turningDeg)
                {
                    brick.Vehicle.Off(false);
                    Console.WriteLine("STOP STOP STOP -------------------------------------");
                    break;
                }
            }
        }

        public void TurnRight()
        {
            brick.Vehicle.SpinRight(curveSpeed, false);
            int currentDegR = DegParser(brick.Sensor4.ReadAsString());

            while (true)
            {
                int deg = DegParser(brick.Sensor4.ReadAsString());
                int diff = deg - currentDegR;
                Console.WriteLine(currentDegR.ToString() + " | " + deg.ToString() + " | " + diff.ToString());

                if (diff >= turningDeg)
                {
                    Console.WriteLine("STOP STOP STOP -------------------------------------");
                    brick.Vehicle.Off(false);
                    break;
                }

            }
        }

        public void TurnAround()
        {
            brick.Vehicle.SpinRight(curveSpeed, false);
            int currentDegR = DegParser(brick.Sensor4.ReadAsString());

            while (true)
            {
                int deg = DegParser(brick.Sensor4.ReadAsString());
                int diff = deg - currentDegR;
                Console.WriteLine(currentDegR.ToString() + " | " + deg.ToString() + " | " + diff.ToString());

                if (diff >= (180-(90-turningDeg)))
                {
                    Console.WriteLine("STOP STOP STOP -------------------------------------");
                    brick.Vehicle.Off(false);
                    break;
                }

            }
        }
    }
}
