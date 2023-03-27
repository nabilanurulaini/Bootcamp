//kalau class static, methodnya juga harus static. Tapi kalau methodnya static, classnya boleh static atau tidak
delegate T1 DelegateOnlineShop<T1, T2>(T1 name, T2 quantity);
delegate void DelegateDictionary(Dictionary<string, string> ProductValue, string ProductKey);
static class MethodsOnlineShop<T1, T2>
{
    public static T1 GetProduct(T1 name, T2 price)
    {
        if(name is int keyName && price is int keyPrice)
        {
            return (T1)(object)(keyName + " " + keyPrice);
        }
        else if(name is string keyName2 && price is string keyPrice2 )
        {
            return (T1)(object)(keyName2 + " " + keyPrice2);
        }
        else
        {
            throw new Exception("Invalid data type");
        }
        //code
    }
    // public T Dictionary<string, string> ConvertDictionary = new()
    // {
    //     {"Food", "Meatballs, Pizza, Burger, Pasta, Noodles, Salad, Fried Rice"},
    //     {"Drink", "Coffee, Tea, Juice, Soda, Water, Milk, Beer"},
    //     {"Clothes", "Shirt, Pants, Jacket, Sweater, Coat, Dress, Skirt"},
    //     {"Shoes", "Sneakers, Boots, Sandals, Slippers, Heels, Flats, Loafers"},
    //     {"Accessories", "Glasses, Watch, Necklace, Earrings, Bracelet, Ring, Hair Clip"},
    //     {"Electronics", "Phone, Laptop, Tablet, Camera, Headphone, Speaker, Charger"},
    //     {"Furniture", "Chair, Table, Sofa, Bed, Wardrobe, Desk, Bookshelf"},
    //     {"Toys", "Car, Doll, Action Figure, Puzzle, Board Game, Toy Gun, Toy Train"},
    //     {"Stationery", "Pen, Pencil, Eraser, Ruler, Stapler, Paper, Notebook"},
    //     {"Sports", "Basketball, Football, Baseball, Tennis, Badminton, Volleyball, Golf"},
    //     {"Books", "Novel, Biography, History, Science, Math, Art, Religion"},
    //     {"Others", "Others"}
    // };
}

// class DictionaryProduct{
    // public Dictionary<string, string> ConvertDictionary = new()
    // {
    //     {"Food", "Meatballs, Pizza, Burger, Pasta, Noodles, Salad, Fried Rice"},
    //     {"Drink", "Coffee, Tea, Juice, Soda, Water, Milk, Beer"},
    //     {"Clothes", "Shirt, Pants, Jacket, Sweater, Coat, Dress, Skirt"},
    //     {"Shoes", "Sneakers, Boots, Sandals, Slippers, Heels, Flats, Loafers"},
    //     {"Accessories", "Glasses, Watch, Necklace, Earrings, Bracelet, Ring, Hair Clip"},
    //     {"Electronics", "Phone, Laptop, Tablet, Camera, Headphone, Speaker, Charger"},
    //     {"Furniture", "Chair, Table, Sofa, Bed, Wardrobe, Desk, Bookshelf"},
    //     {"Toys", "Car, Doll, Action Figure, Puzzle, Board Game, Toy Gun, Toy Train"},
    //     {"Stationery", "Pen, Pencil, Eraser, Ruler, Stapler, Paper, Notebook"},
    //     {"Sports", "Basketball, Football, Baseball, Tennis, Badminton, Volleyball, Golf"},
    //     {"Books", "Novel, Biography, History, Science, Math, Art, Religion"},
    //     {"Others", "Other"}
    // };
    // public void ActionDictionary(DelegateDictionary delDict, string ProductKey)

    // {
    //     delDict(ConvertDictionary, ProductKey);

    // }
// }