double billAmount=Convert.ToDouble(Console.ReadLine());
double finalPrice;


if (billAmount >= 500)
{
    finalPrice = billAmount * 0.8;
}
else if (billAmount >= 300 && billAmount<=499)
{
    finalPrice = billAmount * 0.9;
}
else
{
    finalPrice = billAmount;
}

Console.Write($"Final Price: ={finalPrice}");
