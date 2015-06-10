using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Epam_Intro_0._2._1_TextEditor.Classes;
using Epam_Intro_0._2._1_TextEditor.Extensions;
using Epam_Intro_0._2._1_TextEditor.Factories;

//Задача 1. Создать программу обработки текста учебника по программированию с использованием классов:
//Символ, Слово, Предложение, Знак препинания и др. (состав и иерархию классов продумать самостоятельно).
//Во всех задачах с формированием текста заменять табуляции и последовательности пробелов одним пробелом.

//1. Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них.
//2. Во всех вопросительных предложениях текста найти и напеча¬тать без повторений слова заданной длины.
//3. Из текста удалить все слова заданной длины, начинающиеся на согласную букву.
//4. В некотором предложении текста слова заданной длины заменить указанной подстрокой, длина которой может не совпадать с длиной слова.

namespace Epam_Intro_0._2._1_TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var parsedText = "Parsed text should be pasted here. Or read from file! One? One Two? One Tow Three Four five six seven Eight? Awesome manouver by Senna helps him to protect his position here at Adelaida, but his teammate and main competitor won't give up such early in the beggining of the race, so Prost will fight till the last turn and increase the pressure on Ayrton. How could you solve this riddle having no any hints and assumptions? Could you try to recall all the circumstances of what was happened last morning in the details? Take it easy, my fellow... Don't regret you fail, regret you fail so quick. Think twice before you kick him off! Congrats, see ya! His elevator doesn't go full way up. He is definately not the sharpest tool in the shed.";
            var sentencefactory = ParserFactory.CreateParser<Sentence>();
            var sentenceList = sentencefactory.Parse(parsedText);
            //Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них.
            foreach (var sentence in sentenceList.SortSentencesByWordQuantity())
            {
                Console.WriteLine(sentence.Value);
            }

            //Во всех вопросительных предложениях текста найти и напеча¬тать без повторений слова заданной длины.
            var wordfactory = ParserFactory.CreateParser<Word>();
            foreach (var sentence in sentenceList.FindInterrogativeSentences())
            {
                var wordList = wordfactory.Parse(sentence.Value);
                foreach (var word in wordList.SelectByLenght(5))
                {
                    Console.WriteLine(word.Value);
                }

            }

            //Из текста удалить все слова заданной длины, начинающиеся на согласную букву.

            //MatchCollection matches = Regex.Matches(parsedText, @"\s+[BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz]\S+\b");
            //for (int i = matches.Count - 1, j = 1; i >= 0; i--, j++)
            //{
            //    Console.WriteLine("{0}. {1}", j, matches[i].ToString());
            //}


            //В некотором предложении текста слова заданной длины заменить указанной подстрокой, длина которой может не совпадать с длиной слова.


            var symbolfactory = ParserFactory.CreateParser<Symbol>();
            var symbolList = symbolfactory.Parse(parsedText);

            Console.ReadKey();
        }
    }
}
