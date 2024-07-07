﻿using System.Threading.Channels;
using OnlineStoreManagementSystem;
using OnlineStoreManagementSystem.Person;
using ToolBox;
using static ToolBox.Delegates;

#region test

//#region Products

//#region Clothes

//// Create instances with constructors
//Product p1 = new Clothes("Skirt", 39.99, EnumClothes.Skirt, EnumColor.Pink);
//p1.ShowContents();

//#endregion

//Tool.AddLine();

//#region Food

//// Create instances with constructors
//Product p2 = new Food("Hamburger", 2.99, EnumAllergy.Pork, EnumAllergy.Beef, EnumAllergy.Sesame, EnumAllergy.Wheat, EnumAllergy.Milk);
//p2.ShowContents();

//#endregion

//Tool.AddLine();

//#region Personal care

//// Create instances with constructors (no color, 1 color, 2 colors, 3 colors)
//Product p3 = new PersonalCare("Body cream", 5.99, EnumPersonalCare.Body_care, EnumAllergy.Avocado, EnumAllergy.Milk);
//Product p4 = new PersonalCare("Mascara", 12.99, EnumPersonalCare.Make_up, EnumColor.Black, EnumAllergy.None);
//Product p5 = new PersonalCare("Nail polish", 3.99, EnumPersonalCare.Nail_care, EnumColor.Purple, EnumColor.Black, EnumAllergy.None);
//Product p6 = new PersonalCare("Eyeshadow", 12.99, EnumPersonalCare.Make_up, EnumColor.Pink, EnumColor.Brown, EnumColor.Red, EnumAllergy.None);

//p3.ShowContents();
//Tool.AddLine();

//p4.ShowContents();
//Tool.AddLine();

//p5.ShowContents();
//Tool.AddLine(); 

//p6.ShowContents();
//Tool.AddLine();

//#endregion

//Tool.AddLine();

//#endregion

//Tool.AddLine();

//#region Customer

//// Create instances with constructors
//Customer c1 = new Customer("Mickey", "Mouse", "123 Disney Lane", "mickey.mouse@disney.com");
//Customer c2 = new Customer("Donald", "Duck", "456 Quack Street", "donald.duck@disney.com");
//Customer c3 = new Customer("Goofy", "Goof", "789 Silly Circle", "goofy.goof@disney.com");

//c1.ShowContents();
//c2.ShowContents();
//c3.ShowContents();

//#endregion

//Tool.AddLine();

//#region Shopping cart

//ShoppingCart cart = new ShoppingCart();

//Console.WriteLine($"Count in cart {cart.Count()}");
//cart.Add(p1);
//cart.Add(p2);
//cart.Add(p3);
//cart.Add(p4);
//cart.Add(p5);
//cart.Add(p6);
//Console.WriteLine($"Count in cart {cart.Count()}");

//cart.Add(p1);

//Console.WriteLine($"There are {cart.ProductsInCart[p1]} {p1.Name} in the cart");

//cart.Remove(p3);
//Console.WriteLine($"Count in cart {cart.Count()}");

////cart.ChangeQuantity(p1);
////Console.WriteLine($"There are {cart.ProductsInCart[p1]} {p1.Name} in the cart");

////// 0 Test OK
////cart.ChangeQuantity(p1);

//#endregion

//#region Managers

//Tool.AddLine();

//#region Product manager

//// Create instances to stock the products
//ProductManager productManager = new ProductManager();

//// Add products
//productManager.Add(p1);
//productManager.Add(p2);
//productManager.Add(p3);
//productManager.Add(p4);
//productManager.Add(p5);
//productManager.Add(p6);

//// Error test OK
////productManager.Add(p6);

//// Count the number of registered products
//Console.WriteLine($"There are {productManager.Count()} elements in the list");

//// Remove products
//productManager.Remove(p5.ProductId);
//productManager.Remove(p6);
//Console.WriteLine($"There are {productManager.Count()} elements in the list");

//// Error test OK
////productManager.Remove(p6.ProductId);
////productManager.Remove(p6);

//// Indexer
//Console.WriteLine($"P1's name : {productManager[p1.ProductId].Name}");

//// Error test OK
////Console.WriteLine($"P1's name : {productManager[p6.ProductId].Name}");

//// Product factory
////productManager.AddProductStep1();

//#endregion

//Tool.AddLine();

//#region Customer manager

//// Create instances to stock the customers
//CustomerManager customerManager = new CustomerManager();

//// Add products
//customerManager.Add(c1);
//customerManager.Add(c2);
//customerManager.Add(c3);

////Error test OK
////customerManager.Add(c3);

//// Count the number of registered customers
//Console.WriteLine($"There are {customerManager.Count()} elements in the list");

//// Remove products
//customerManager.Remove(c2.CustomerId);
//customerManager.Remove(c3);
//Console.WriteLine($"There are {customerManager.Count()} elements in the list");

//// Error test OK
////customerManager.Remove(c2.CustomerId);
////customerManager.Remove(c3);

//// Indexer
//Console.WriteLine($"P1's name : {customerManager[c1.CustomerId].FirstName}");

//// Error test OK
////Console.WriteLine($"P1's name : {customerManager[c2.CustomerId].FirstName}");

//// Product factory
////customerManager.AddProductStep1();

//#endregion

//#region Order Manager

//OrderManager orderManager = new OrderManager();
//Order o1 = new Order(cart.ProductsInCart, c1);
//Order o2 = new Order(cart.ProductsInCart, c2, EnumPayment.CreditCard);
//Order o3 = new Order(cart.ProductsInCart, c3, EnumPayment.Paypal);

//orderManager.Add(o1);
//orderManager.Add(o2);
//orderManager.Add(o3);

//// Error test OK
////orderManager.Add(o3);

//orderManager.Count();

//orderManager.Remove(o2);
//orderManager.Remove(o3.OrderId);

//// Error test OK
////orderManager.Remove(o3);
////orderManager.Remove(o3.OrderId);

//orderManager.Count();

//orderManager.PaymentProceeded += (order) =>
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"The payment n° {order.OrderId} was successfully proceeded");
//    Console.ResetColor();
//};

//orderManager.ChoosePayment(o1.OrderId);
//await orderManager.Pay(o1.OrderId);
//o1.ShowContents();

//#endregion

//#endregion

#endregion

#region Managers and shopping cart

ProductManager productManager = new ProductManager();
AccountManager accountManager = new AccountManager();
AdminManager adminManager = new AdminManager();
OrderManager orderManager = new OrderManager();
ShoppingCart cart = new ShoppingCart();

#endregion

#region Products

Product c1 = new Clothes("Summer Dress", 29.99, EnumClothes.Dress, EnumColor.Red, EnumColor.White);
Product c2 = new Clothes("Casual T-Shirt", 19.99, EnumClothes.T_shirt, EnumColor.Blue, EnumColor.Gray);
Product c3 = new Clothes("Formal Blouse", 39.99, EnumClothes.Blouse, EnumColor.Beige, EnumColor.Black);
Product c4 = new Clothes("Denim Pants", 49.99, EnumClothes.Pants, EnumColor.Blue);
Product c5 = new Clothes("Winter Sweater", 59.99, EnumClothes.Sweater, EnumColor.Gray, EnumColor.White, EnumColor.Purple);

Product f1 = new Food("Almond Milk", 3.99, EnumAllergy.Nuts);
Product f2 = new Food("Whole Wheat Bread", 2.49, EnumAllergy.Wheat);
Product f3 = new Food("Peanut Butter", 3.49, EnumAllergy.Nuts);
Product f4 = new Food("Cheese Pizza", 8.99, EnumAllergy.Milk, EnumAllergy.Wheat);
Product f5 = new Food("Shrimp Salad", 10.99, EnumAllergy.Shellfish);

Product p1 = new PersonalCare("Face Cream", 25.99, EnumPersonalCare.Skin_care, EnumColor.White, EnumAllergy.Milk, EnumAllergy.Nuts);
Product p2 = new PersonalCare("Shampoo", 8.99, EnumPersonalCare.Hair_care, EnumColor.Blue, EnumAllergy.None);
Product p3 = new PersonalCare("Body Lotion", 12.99, EnumPersonalCare.Body_care, EnumColor.Pink, EnumColor.White, EnumAllergy.Soy, EnumAllergy.Celery);
Product p4 = new PersonalCare("Nail Polish", 7.99, EnumPersonalCare.Nail_care, EnumColor.Red, EnumAllergy.None);
Product p5 = new PersonalCare("Toothpaste", 4.99, EnumPersonalCare.Oral_care, EnumColor.White, EnumColor.Blue, EnumAllergy.None);

#endregion

#region Add all products to the list

productManager.Add(c1);
productManager.Add(c2);
productManager.Add(c3);
productManager.Add(c4);
productManager.Add(c5);

productManager.Add(f1);
productManager.Add(f2);
productManager.Add(f3);
productManager.Add(f4);
productManager.Add(f5);

productManager.Add(p1);
productManager.Add(p2);
productManager.Add(p3);
productManager.Add(p4);
productManager.Add(p5);

#endregion

#region Home

bool isLoggedIn = false;
bool wantStay = true;
bool wantSeeCart = false;
bool wantPay = false;
Account currentAccount = null;
Admin currentAdmin = null;
Order currentOrder = null;

while (wantStay)
{
    // The user choose the action
    MessageDelegate message = () =>
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1 : Look at our products");
        Console.WriteLine("2 : Check your order and delivery");
        Console.WriteLine("3 : Control products as admin");
    };

    Tool.TryGetIntLimitedRange(message, 1, 3, out int result);

    // Depending on the answer, the appropriate action will be executed
    switch (result)
    {
        case 1:
            // Show all the products
            productManager.ShowAllProducts();

            // Verify if the user is already logged in
            // If logged in, the user adds a product to cart or go see the cart
            if(isLoggedIn) wantSeeCart = cart.AddOrToCart(isLoggedIn);

            // If NOT logged in, ask the user to log in or create an account
            else
            {
                Console.WriteLine("Please log in to add a product in the cart");
                isLoggedIn = accountManager.LoginOrCreate(ref currentAccount);
            }

            // If the user wants to see the cart, the user can either manage the products in the cart or proceed a payment
            if (wantSeeCart) 
            {
                wantPay = cart.ManageCartOrPay();

                if (wantPay)
                {
                    currentOrder = orderManager.AddOrder(currentAccount);
                    orderManager.ChoosePayment(currentOrder.OrderId);

                    orderManager.PaymentProceeded += (order) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"The payment n° {order.OrderId} was successfully proceeded");
                        Console.ResetColor();
                    };

                    await orderManager.Pay(currentOrder.OrderId);
                }
                wantSeeCart = false;
            }

            Tool.ReturnToMenu();
            break;

        case 2:
            if (isLoggedIn)
            {
                message = () =>
                {
                    Console.WriteLine("Which order would you like to manage? Choose by number");
                    orderManager.ShowAllOrders();
                };
                Tool.TryGetIntLimitedRange(message, 1, orderManager.Count(), out result);

                orderManager.Orders[result].ShowContents();
            }
            else
            {
                Console.WriteLine("Please log in to check your order or delivery");
                isLoggedIn = accountManager.LoginOrCreate(ref currentAccount);
            }

            Tool.ReturnToMenu();
            break;
        case 3:
            if (isLoggedIn)
            {
                message = () =>
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1 : Add a product");
                    Console.WriteLine("2 : Remove a product");
                };
                Tool.TryGetIntLimitedRange(message, 1, 2, out result);

                switch(result)
                {
                    case 1: 
                        productManager.AddProductStep1();
                        break;
                    case 2:
                        message = () =>
                        {
                            Console.WriteLine("Which product would you like to delete? Choose by number");
                            productManager.ShowAllProducts();
                        };

                        Tool.TryGetIntLimitedRange(message, 1, productManager.Count(), out result);

                        productManager.Remove(productManager.Products[result - 1]);
                        break;
                }
            }
            else
            {
                currentAdmin = currentAdmin.Login(adminManager.Admins);
                isLoggedIn = true;
            }

            break;
    }
}

#endregion