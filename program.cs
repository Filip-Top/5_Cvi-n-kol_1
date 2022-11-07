int[] pole1 = new int[5];
            int[] pole2 = { 1, 2, 3, 4, 5};
            int[] pole3 = { 6, 7, 8, 9, 10 };

            for (int i = 0; i < pole1.Length; i++)
            {
                Console.Clear();
                Console.WriteLine(i + ". index pole1.");
                Console.Write("> ");
                int vyber = int.Parse(Console.ReadLine());
                pole1[i] = vyber;
            }
            Console.Clear();
            for (int i = 0; i < pole1.Length; i++)
            {
                Console.WriteLine("Hodnota X na indexu " + i + " v prvním poli je: " + pole1[i]);
            }
            Console.ReadLine();
            Console.Clear();
            int soucet = pole2[0] + pole2[1] + pole2[2] + pole2[3] + pole2[4];
            Console.WriteLine("Součet všech prvků pole2 je: " + soucet);
            Console.ReadLine();
            Console.Clear();

            int[] pole4 = new int[5];
            for (int i = 0; i < pole3.Length; i++)
            {
                pole4[i] = pole3[i];
            }

            pole3[0] = pole4[4];
            pole3[1] = pole4[0];
            pole3[2] = pole4[1];
            pole3[3] = pole4[2];
            pole3[4] = pole4[3];

            for (int i = 0; i < pole1.Length; i++)
            {
                Console.WriteLine("Hodnota X na indexu " + i + " v třetím poli je: " + pole3[i]);
            }
            Console.ReadLine();
