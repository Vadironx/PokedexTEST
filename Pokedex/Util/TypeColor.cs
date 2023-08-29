namespace Pokedex.Util
{
    public class TypeColor
    {
        public static string GetTypeColor(string type)
        {
            string color = type switch
            {
                "bug" => "#26de81",
                "dragon" => "#ffeaa7",
                "electric" => "#fed330",
                "fairy" => "#FF0069",
                "fighting" => "#f00",
                "fire" => "#f0932b",
                "flying" => "#81ecec",
                "grass" => "#00b894",
                "ground" => "#EFB549",
                "ghost" => "#a55eea",
                "ice" => "#74b9ff",
                "normal" => "#95afc0",
                "poison" => "#6c5ce7",
                "psychic" => "#ce5a9c",
                "rock" => "#414040",
                "water" => "#0190FF",
                _ => "#808080"
            };

            return color;
        }
    }
}
