while (true) {
Console.WriteLine("Hello, World!");
Console.WriteLine("This is a simple C# program.");


	Random rand = new Random();
	string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
	
	Console.Clear();
	for (int i = 0; i < 20; i++) {
		char randomChar = allowedChars[rand.Next(0, allowedChars.Length)];
		Console.Write(randomChar);
	}
}