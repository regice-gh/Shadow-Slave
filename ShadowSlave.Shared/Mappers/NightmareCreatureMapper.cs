using ShadowSlave.Shared.Models;
using ShadowSlave.Shared.ViewModels;

namespace ShadowSlave.Shared.Mappers
{
    public static class NightmareCreatureMapper
    {
        public static NightmareCreatureViewModel ToViewModel(this NightmareCreature creature)
        {
            if (creature == null) return null;

            return new NightmareCreatureViewModel
            {
                Id = creature.Id,
                Name = creature.Name,
                Description = creature.Description,
                Core = creature.Core,
                Rank = creature.Rank,
                SoulEssense = creature.SoulEssense
            };
        }
    }
}
