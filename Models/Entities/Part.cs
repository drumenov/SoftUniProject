using Models.Enums;

namespace Models.Entities
{
    public class Part
    {
        public int Id { get; set; }

        public PartType Type { get; set; }

        public int Quantity { get; set; }
    }
}
