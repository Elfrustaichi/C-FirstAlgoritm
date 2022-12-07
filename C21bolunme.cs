

int i = 0;

Console.WriteLine("Eded daxil edin;");
i = Convert.ToInt32 (Console.ReadLine ());
if (i>0)
{
	if (i%21==0)
	{
		Console.WriteLine("Bu eded 21-e bolunur.");
	}
	else
	{
		Console.WriteLine("Bu eded 21-e tam bolunmur.");
	}


}
else
{
	Console.WriteLine("Duzgun eded daxil edin.");
}
