Console.WriteLine("Podaj kwotę w PLN do przeliczenia: ");
double pln = double.Parse(Console.ReadLine());
waluty w = new waluty(pln);
Console.WriteLine(w.ToString());
class waluty {
    public double PLN { get; set; }
    public double USD { get; set; }
    public double EUR { get; set; }
    public double GBP { get; set; }
    public double CHF { get; set; }

    public override string ToString()
    {
        return $"Przeliczone wartości: \n" +
               $"{PLN} PLN = {USD:F2} USD \n" +
               $"{PLN} PLN = {EUR:F2} EUR \n" +
               $"{PLN} PLN = {GBP:F2} GBP \n" +
               $"{PLN} PLN = {CHF:F2} CHF \n";
    }
    public waluty(double pln) {
        PLN = pln;
        USD = pln / 4.28;
        EUR = pln / 3.17;
        GBP = pln / 4.95;
        CHF = pln / 4.67;
        
    } 
}
