using System;

namespace ChatServer
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Server.ChatServer();
			Console.ReadLine();
		}
	}
}
