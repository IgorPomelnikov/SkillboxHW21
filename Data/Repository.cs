using LoremNET;
using SkillboxHW21.Models;
using System;
using System.Collections.Generic;

namespace SkillboxHW21.Data
{
    public static class Repository
    {

        /// <summary>
        /// Возвращает контакт с сгенерированными данными
        /// </summary>
        /// <returns>Заполненный экземпляр класса Contact</returns>
        public static Contact GetContact()
        {
            Random random = new Random();
            return new Contact()
            {
                FirstName = GetRandomFirstName(random),
                LastName = GetRandomLastName(random),
                FatherName = GetRandomFatherName(random),
                Telephone = $"+79{random.Next(900000000, 999999999)}",
                Adress = $"{random.Next(100000, 999999)}, с.Случайное, ул.Тестовая, д.{random.Next(100)}, кв.{random.Next(100)}.",
                Mail = Lorem.Email(),
                Description = Lorem.Sentence(5, 25)
            };
        }
        public static IEnumerable<Contact> GetContacts()
        {
            Random random = new();
            List<Contact> contacts = new();
            for (int i = 0; i < random.Next(3, 11); i++)
            {
                contacts.Add(GetContact());
            }
            return contacts;
        }
        private static string GetRandomLastName(Random random)
        {
            switch (random.Next(1, 5))
            {
                case 1: return "Кузнецов";
                case 2: return "Исакидис";
                case 3: return "Бабаян";
                case 4: return "Пучковский";
                default: return "Хренова";
            }
        }
        private static string GetRandomFatherName(Random random)
        {
            switch (random.Next(1, 5))
            {
                case 1: return "Васильевич";
                case 2: return "Романович";
                case 3: return "Григорьевич";
                case 4: return "Тигранович";
                default: return "Петрович";
            }
        }
        private static string GetRandomFirstName(Random random)
        {
            switch (random.Next(1, 5))
            {
                case 1: return "Антон";
                case 2: return "Глеб";
                case 3: return "Игорь";
                case 4: return "Виктор";
                default: return "Гадя";
            }
        }
    }
}
