// See https://aka.ms/new-console-template for more information
using OOP;

WaterBottle bottle1 = new WaterBottle();
WaterBottle bottle2 = new WaterBottle("red", 2000, 55.5);


Console.WriteLine(bottle2.Color);

EightSidedDice eightSidedDice = new EightSidedDice();
eightSidedDice.Roll();