using Work13.Task1;
using Work13.Task2;
using Work13.Task3;

namespace Work13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            Book book = new Book("Война и мир");
            DoPrint(book);
            DoRead(book);

            // Task 2

            RepairStations rs = new RepairStations();
            IRepairable[] obj =
            {
                new Transport(),
                new ElectricObject(),
                new Robot()
            };

            rs.Repair(obj[0]);
            rs.Repair(obj[1]);
            rs.Repair(obj[2]);

            // Task 3

            Car car = new Car("Logan");
            Plane plane = new Plane("Su-57");
            Boat boat = new Boat("Yamato");
            AmphibiousVehicle AV = new AmphibiousVehicle("Сверх-тс");
            Car car1 = new Car("Challenger");
            Plane plane1 = new Plane("F-16");
            Boat boat1 = new Boat("Bismark");
            AmphibiousVehicle AV1 = new AmphibiousVehicle("Сверх-тс");
            object[] veh = {car, plane, boat, AV, car1, plane1, boat1, AV1 };
            IFlyable[] vehout = FilterByInterface<IFlyable>(veh);
            foreach (IFlyable v in vehout)
                v.Move();
        }

        public static T[] FilterByInterface<T>(object[] veh)
        {
            T[] vehout = new T[0];
            for (int i = 0; i < veh.Length; i++)
            {
                if (veh[i] is T)
                {
                    T[] tempveh = new T[vehout.Length + 1];
                    for (int j = 0; j < vehout.Length; j++)
                    {
                        tempveh[j] = vehout[j];
                    }
                    tempveh[^1] = (T)veh[i];
                    vehout = tempveh;
                }
            }
            return vehout;
        }

        public static void DoRead(IReadable printable)
        {
            printable.Read();
        }
        public static void DoPrint(IPrintable printable)
        {
            printable.Print();
        }
    }
}