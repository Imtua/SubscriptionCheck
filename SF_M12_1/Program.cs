using SF_M12_1;

SubscriptionCheck(new User("TestLogin", "Дмитрий", true));
SubscriptionCheck(new User("Test11", "Владимир", false));

static void SubscriptionCheck(User? user)
{
    Console.WriteLine("Добрый день, {0}!!", user.Name);
    if (!user.IsPremium)
	{
		User.ShowAds();
	}
    Console.WriteLine("До свидания, {0}. Удачи!!", user.Name);
}