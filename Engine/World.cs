using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_BONE = 11;
        public const int ITEM_ID_SKULL_FRAGMENT = 12;
        public const int ITEM_ID_SHARP_BONE = 13;
        public const int ITEM_ID_ROTTEN_FLESH = 14;
        public const int ITEM_ID_FRIEND_OF_LOGNESS = 15;
        public const int ITEM_ID_SPECIAL_FLOWER = 16;
        public const int ITEM_ID_LOVE_POTION = 17;
        public const int ITEM_ID_TROLL_DAD = 18;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_SKELETON = 4;
        public const int MONSTER_ID_ZOMBIE = 5;
        public const int MONSTER_ID_EVIL_FAIRY = 6;
        public const int MONSTER_ID_MOTHER_SPIDER = 7;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_CLEAR_CEMETERY = 3;
        public const int QUEST_ID_FEED_FRIEND_OF_LOGNESS = 4;
        public const int QUEST_ID_COLLECT_FLOWERS = 5;
        public const int QUEST_ID_DELIVER_POTION = 6;
        public const int QUEST_ID_RESCUE_TROLL = 7;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_CHURCH = 10;
        public const int LOCATION_ID_CEMETERY = 11;
        public const int LOCATION_ID_WOODS = 12;
        public const int LOCATION_ID_FRIEND_ZONE = 13;
        public const int LOCATION_ID_CLIFF_BOTTOM = 14;
        public const int LOCATION_ID_SPIDER_LAIR = 15;
        public const int LOCATION_ID_TROLL_TOWN = 16;
        public const int LOCATION_ID_LABORATORY = 17;
        public const int LOCATION_ID_ILDAS_HOUSE = 18;
        public const int LOCATION_ID_TROLLS_HOUSE = 19;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
            Items.Add(new Item(ITEM_ID_BONE, "Bone", "Bones"));
            Items.Add(new Item(ITEM_ID_SKULL_FRAGMENT, "Skull fragment", "Skull fragments"));
            Items.Add(new Weapon(ITEM_ID_SHARP_BONE, "Sharp bone", "Sharp bones", 5, 15));
            Items.Add(new Item(ITEM_ID_ROTTEN_FLESH, "Zombie flesh", "Zombie flesh"));
            Items.Add(new Item(ITEM_ID_FRIEND_OF_LOGNESS, "Friend of Logness", "Friends of Logness"));
            Items.Add(new Item(ITEM_ID_SPECIAL_FLOWER, "Special flower", "Special flowers"));
            Items.Add(new Item(ITEM_ID_LOVE_POTION, "Love potion", "Love potions"));
            Items.Add(new Item(ITEM_ID_TROLL_DAD, "Troll dad", "Troll dads"));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 2, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 7, 7);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 15, 40, 20, 20);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster skeleton = new Monster(MONSTER_ID_SKELETON, "Skeleton", 3, 5, 10, 6, 6);
            skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BONE), 25, false));
            skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SKULL_FRAGMENT), 50, true));

            Monster zombie = new Monster(MONSTER_ID_ZOMBIE, "Zombie", 7, 5, 10, 11, 11);
            zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROTTEN_FLESH), 100, true));

            Monster evilFairy = new Monster(MONSTER_ID_EVIL_FAIRY, "Evil fairy", 11, 10, 25, 15, 15);
            evilFairy.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPECIAL_FLOWER), 100, true));

            Monster motherSpider = new Monster(MONSTER_ID_MOTHER_SPIDER, "Mother Spider", 25, 20, 45, 25, 25);
            motherSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TROLL_DAD), 100, true));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(skeleton);
            Monsters.Add(zombie);
            Monsters.Add(evilFairy);
            Monsters.Add(motherSpider);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a Healing Potion and 10 gold.", 20, 10);
            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_RAT_TAIL), 3));
            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField = new Quest(QUEST_ID_CLEAR_FARMERS_FIELD,
                "Clear the farmer's field",
                "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an Adventurer's Pass and 20 gold.", 20, 20);
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_SNAKE_FANG), 3));
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quest clearCemetery = new Quest(QUEST_ID_CLEAR_CEMETERY,
                "Clear the cemetery",
                "Kill skeletons in the cemetery and bring back 2 bones. You will receive a Sharp Bone and 15 gold.", 20, 15);
            clearCemetery.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_BONE), 2));
            clearCemetery.RewardItem = ItemByID(ITEM_ID_SHARP_BONE);

            Quest feedFriendOfLogness = new Quest(QUEST_ID_FEED_FRIEND_OF_LOGNESS,
                "Feed Friend of Logness",
                "Feed the Friend of Logness 6 pieces of Rotten flesh. He will give you a ride to the cliff bottom.", 20, 0);
            feedFriendOfLogness.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_ROTTEN_FLESH), 6));
            feedFriendOfLogness.RewardItem = ItemByID(ITEM_ID_FRIEND_OF_LOGNESS);

            Quest collectFlowers = new Quest(QUEST_ID_COLLECT_FLOWERS,
                "Collect special flowers",
                "Bring 5 special flowers to the scientist so he can make his love potion. You will receive the love potion and 30 gold.", 30, 30);
            collectFlowers.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_SPECIAL_FLOWER), 5));
            collectFlowers.RewardItem = ItemByID(ITEM_ID_LOVE_POTION);

            Quest deliverPotion = new Quest(QUEST_ID_DELIVER_POTION,
                "Deliver Love Potion",
                "The scientist is in love with Ilda. Pour his love potion into her drink. You will receive a Healing Potion and 50 gold.", 30, 50);
            deliverPotion.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_LOVE_POTION), 1));
            deliverPotion.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest rescueTroll = new Quest(QUEST_ID_RESCUE_TROLL,
                "Rescue the troll dad",
                "The troll dad was caught by giant spiders. Rescue him in the spider's lair and bring him back to his family. You will receive a club and 50 gold.", 30, 50);
            rescueTroll.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_TROLL_DAD), 1));
            rescueTroll.RewardItem = ItemByID(ITEM_ID_CLUB);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(clearCemetery);
            Quests.Add(feedFriendOfLogness);
            Quests.Add(collectFlowers);
            Quests.Add(deliverPotion);
            Quests.Add(rescueTroll);

        }

        private static void PopulateLocations()
        {
            //Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home",
                "Your house. Smells like new furniture.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE,
                "Town square", "You see a fountain.");

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT,
                "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN,
                "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE,
                "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD,
                "Farmer's field", "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST,
                "Guard post", "There is a large, tough-looking guard here.",
                ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE,
                "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD,
                "Forest", "You see spider webs covering covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location church = new Location(LOCATION_ID_CHURCH,
                "Church", "The priestess is lighting the candles.");
            church.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_CEMETERY);

            Location cemetery = new Location(LOCATION_ID_CEMETERY,
                "Cemetery", "There are no more graves.");
            cemetery.MonsterLivingHere = MonsterByID(MONSTER_ID_SKELETON);

            Location woods = new Location(LOCATION_ID_WOODS,
                "Woods", "You hear whispering.");
            woods.MonsterLivingHere = MonsterByID(MONSTER_ID_ZOMBIE);

            Location friendZone = new Location(LOCATION_ID_FRIEND_ZONE,
                "Friend Zone", "Here lives the Friend of the Logness monster.");
            friendZone.QuestAvailableHere = QuestByID(QUEST_ID_FEED_FRIEND_OF_LOGNESS);

            Location cliffBottom = new Location(LOCATION_ID_CLIFF_BOTTOM,
                "Cliff bottom", "The evil fairies are guarding the flowers.",
                ItemByID(ITEM_ID_FRIEND_OF_LOGNESS));
            cliffBottom.MonsterLivingHere = MonsterByID(MONSTER_ID_EVIL_FAIRY);

            Location spiderLair = new Location(LOCATION_ID_SPIDER_LAIR,
                "Spider's Lair", "Here live the mother spiders.",
                ItemByID(ITEM_ID_SPIDER_FANG));
            spiderLair.MonsterLivingHere = MonsterByID(MONSTER_ID_MOTHER_SPIDER);

            Location trollTown = new Location(LOCATION_ID_TROLL_TOWN,
                "Troll town", "This town is almost deserted.");

            Location laboratory = new Location(LOCATION_ID_LABORATORY,
                "Laboratory", "The scientist is busy with his research.");
            laboratory.QuestAvailableHere = QuestByID(QUEST_ID_COLLECT_FLOWERS);

            Location ildasHouse = new Location(LOCATION_ID_ILDAS_HOUSE,
                "Ilda's House", "Smells like old furniture.");
            ildasHouse.QuestAvailableHere = QuestByID(QUEST_ID_DELIVER_POTION);

            Location trollsHouse = new Location(LOCATION_ID_TROLLS_HOUSE,
                "The Troll's House", "There are many family photos on the walls.");
            trollsHouse.QuestAvailableHere = QuestByID(QUEST_ID_RESCUE_TROLL);

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;
            farmhouse.LocationToNorth = church;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;
            alchemistHut.LocationToWest = church;

            alchemistsGarden.LocationToSouth = alchemistHut;
            alchemistsGarden.LocationToWest = cemetery;
            alchemistsGarden.LocationToEast = woods;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;
            bridge.LocationToNorth = friendZone;

            spiderField.LocationToWest = bridge;
            spiderField.LocationToSouth = spiderLair;

            spiderLair.LocationToNorth = spiderField;

            church.LocationToEast = alchemistHut;
            church.LocationToNorth = cemetery;

            cemetery.LocationToSouth = church;
            cemetery.LocationToEast = alchemistsGarden;
            cemetery.LocationToNorth = trollTown;

            woods.LocationToWest = alchemistsGarden;

            friendZone.LocationToSouth = bridge;
            friendZone.LocationToNorth = cliffBottom;

            cliffBottom.LocationToSouth = friendZone;

            trollTown.LocationToSouth = cemetery;
            trollTown.LocationToWest = laboratory;
            trollTown.LocationToNorth = ildasHouse;
            trollTown.LocationToEast = trollsHouse;

            laboratory.LocationToEast = trollTown;

            ildasHouse.LocationToSouth = trollTown;

            trollsHouse.LocationToWest = trollTown;



            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
            Locations.Add(church);
            Locations.Add(cemetery);
            Locations.Add(woods);
            Locations.Add(friendZone);
            Locations.Add(cliffBottom);
            Locations.Add(spiderLair);
            Locations.Add(trollTown);
            Locations.Add(laboratory);
            Locations.Add(ildasHouse);
            Locations.Add(trollsHouse);

        }
        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
    
            return null;
        }
    
        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if(monster.ID == id)
                    {
                        return monster;
                    }
            }
    
            return null;
        }
    
        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            }

                return null;
        }
    
        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }
    
            return null;
        }
    }
}
