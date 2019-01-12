﻿using DesignPattern.BuilderPattern.Meal;
using DesignPattern.FactoryPattern.Color;
using DesignPattern.FactoryPattern.Factory;
using DesignPattern.FactoryPattern.Shape;
using DesignPattern.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactory shapeFactory = FactoryProducer.GetFactory(FactoryType.Shape);
            //IShape shape1 = shapeFactory.GetShape(ShapeType.Circle);
            //shape1.Draw();
            //IShape shape2 = shapeFactory.GetShape(ShapeType.Rectangle);
            //shape2.Draw();
            //IShape shape3 = shapeFactory.GetShape(ShapeType.Square);
            //shape3.Draw();
            //AbstractFactory colorFactory = FactoryProducer.GetFactory(FactoryType.Color);
            //IColor color1 = colorFactory.GetColor(ColorType.Red);
            //color1.Fill();
            //IColor color2 = colorFactory.GetColor(ColorType.Green);
            //color2.Fill();
            //IColor color3 = colorFactory.GetColor(ColorType.Blue);
            //color3.Fill();
            //===========================================================
            //Singleton singleton = new Singleton();因建構子為private,所以無法直接new
            //Singleton singleton = Singleton.GetSingleton();
            //singleton.SingletonTest();
            //Singleton2 singleton2 = Singleton2.GetSingleton();
            //singleton2.SingletonTest();
            //===========================================================
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine($"Total Cost:{vegMeal.GetCost()}");
            Console.WriteLine("");
            Console.WriteLine("");
            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("Non-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine($"Total Cost:{nonVegMeal.GetCost()}");
            Console.Read();
        }
    }
}