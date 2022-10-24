Menu();

static void Menu()
{
  Console.Clear();
  Console.WriteLine("S = Segundos => 10s = 10 segundos");
  Console.WriteLine("M = Minutos => 1m = 1 minuto");
  Console.WriteLine("0 = Sair");
  Console.WriteLine("Quanto tempo deseja contar?");

  string input = Console.ReadLine().ToLower();
  char type = char.Parse(input.Substring(input.Length - 1, 1));
  int tempo = int.Parse(input.Substring(0, input.Length - 1));

  int multiplicador = 1;

  if (type == 'm') multiplicador = 60;
  if (tempo == 0) System.Environment.Exit(0);

  Start(tempo * multiplicador);
}

static void Start(int time)
{
  int currentTime = 0;

  while (currentTime != time)
  {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }

  Console.Clear();
  Console.WriteLine("Cronômetro finalizado.");
  Thread.Sleep(2500);
  Menu();
}
