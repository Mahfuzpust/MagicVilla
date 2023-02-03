using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO{Id=1, Name="Dream Villa", Sqrt=5, Occupancy=9},
            new VillaDTO{Id=2, Name="Beach Villa", Sqrt=10, Occupancy=18}
        };
    }
}
