namespace PhysicValuesLib.Values;

internal class Weight : AnyValue
{
    public Weight()
    {
        ValueName = "Вес";

        CoefficientsAndMeasuresList = new Dictionary<string, double>()
        {
           { "Грамм",      0.001},
            { "Килограммы", 1},
            { "Центнеры",   100},
            { "Тонны",      1*1000},
        };
    }
}