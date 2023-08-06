using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Interger_to_Romain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine(IntToRomain(numero));
            Console.Read();
        }

        public static string IntToRomain(int numero)
        {
            string romano="";

            int um = 0, quatro = 0, cinco = 0, nove = 0, dez = 0, quarenta = 0, cinquenta = 0, noventa = 0, cem = 0, quatrocentos = 0, quinhentos = 0, novecentos = 0, mil = 0;
            char[] letras=new char[20];

            mil = numero / 1000;
            novecentos = (numero % 1000) / 900;
            quinhentos = ((numero % 1000)%900)/ 500;
            quatrocentos = (((numero % 1000) % 900) % 500) / 400;
            cem = ((((numero % 1000) % 900) % 500) % 400) / 100;
            noventa = (((((numero % 1000) % 900) % 500) % 400) % 100) / 90;
            cinquenta = ((((((numero % 1000) % 900) % 500) % 400) % 100) % 90) / 50;
            quarenta = (((((((numero % 1000) % 900) % 500) % 400) % 100) % 90) % 50) / 40;
            dez = ((((((((numero % 1000) % 900) % 500) % 400) % 100) % 90) % 50) % 40) / 10;
            nove = (((((((((numero % 1000) % 900) % 500) % 400) % 100) % 90) % 50) % 40) % 10) / 9;
            cinco = ((((((((((numero % 1000) % 900) % 500) % 400) % 100) % 90) % 50) % 40) % 10) % 9) / 5;
            quatro = (((((((((((numero % 1000) % 900) % 500) % 400) % 100) % 90) % 50) % 40) % 10) % 9) % 5) / 4;
            um = (((((((((((numero % 1000) % 900) % 500) % 400) % 100) % 90) % 50) % 40) % 10) % 9) % 5) % 4;

            for(int i = 0; i < mil; i++)
            {
                romano = romano + "M";
            }
            for (int i = 0; i < novecentos; i++)
            {
                romano = romano + "CM";
            }
            for (int i = 0; i < quinhentos; i++)
            {
                romano = romano + "D";
            }
            for (int i = 0; i < quatrocentos; i++)
            {
                romano = romano + "CD";
            }
            for (int i = 0; i < cem; i++)
            {
                romano = romano + "C";
            }
            for (int i = 0; i < noventa; i++)
            {
                romano = romano + "XC";
            }
            for (int i = 0; i < cinquenta; i++)
            {
                romano = romano + "L";
            }
            for(int i = 0; i < quarenta; i++)
            {
                romano = romano + "XL";
            }
            for (int i = 0; i < dez; i++)
            {
                romano = romano + "X";
            }
            for (int i = 0; i < nove; i++)
            {
                romano = romano + "IX";
            }
            for (int i = 0; i < cinco; i++)
            {
                romano = romano + "V";
            }
            for (int i = 0; i < quatro; i++)
            {
                romano = romano + "IV";
            }
            for (int i = 0; i < um; i++)
            {
                romano = romano + "I";
            }

            return romano;
        }
    }
}
