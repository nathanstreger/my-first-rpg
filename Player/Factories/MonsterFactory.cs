﻿using System;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Snake", "Snake.png", 4, 4,
                        10, 10, 10, 10, 10, 10,
                        50, 1)
                        {
                            CurrentWeapon = ItemFactory.CreateGameItem(1501)
                        };

                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 60);
                    AddLootItem(snake, 3001, 5);
                    AddLootItem(snake, 3002, 5);
                    AddLootItem(snake, 3003, 5);

                    return snake;

                case 2:
                    Monster rat =
                        new Monster("Rat", "Rat.png", 5, 5,
                        10, 10, 10, 10, 10, 10,
                        5, 1)
                        {
                            CurrentWeapon = ItemFactory.CreateGameItem(1502)
                        };

                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 60);
                    AddLootItem(rat, 3001, 5);
                    AddLootItem(rat, 3002, 5);
                    AddLootItem(rat, 3003, 5);

                    return rat;

                case 3:
                    Monster giantSpider =
                        new Monster("Giant Spider", "GiantSpider.png", 10, 10,
                        10, 10, 10, 10, 10, 10,
                        10, 3)
                        {
                            CurrentWeapon = ItemFactory.CreateGameItem(1503)
                        };

                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 60);
                    AddLootItem(giantSpider, 3001, 5);
                    AddLootItem(giantSpider, 3002, 5);
                    AddLootItem(giantSpider, 3003, 5);

                    return giantSpider;

                case 4:
                    Monster giantSnake =
                        new Monster("Giant Snake", "Snake.png", 20, 20,
                        10, 10, 10, 10, 10, 10,
                        30, 10)
                        {
                            CurrentWeapon = ItemFactory.CreateGameItem(1601)
                        };

                    AddLootItem(giantSnake, 9001, 25);
                    AddLootItem(giantSnake, 9002, 60);
                    AddLootItem(giantSnake, 3001, 5);
                    AddLootItem(giantSnake, 3002, 5);
                    AddLootItem(giantSnake, 3003, 5);

                    return giantSnake;

                case 5:
                    Monster giantRat =
                        new Monster("Giant Rat", "Rat.png", 15, 15,
                        10, 10, 10, 10, 10, 10,
                        25, 5)
                        {
                            CurrentWeapon = ItemFactory.CreateGameItem(1602)
                        };

                    AddLootItem(giantRat, 9003, 25);
                    AddLootItem(giantRat, 9004, 60);
                    AddLootItem(giantRat, 3001, 5);
                    AddLootItem(giantRat, 3002, 5);
                    AddLootItem(giantRat, 3003, 5);

                    return giantRat;

                case 6:
                    Monster queenSpider =
                        new Monster("Queen Spider", "GiantSpider.png", 50, 50,
                        10, 10, 10, 10, 10, 10,
                        75, 25)
                        {
                            CurrentWeapon = ItemFactory.CreateGameItem(1603)
                        };

                    AddLootItem(queenSpider, 9005, 25);
                    AddLootItem(queenSpider, 9006, 60);
                    AddLootItem(queenSpider, 3001, 5);
                    AddLootItem(queenSpider, 3002, 5);
                    AddLootItem(queenSpider, 3003, 5);

                    return queenSpider;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}