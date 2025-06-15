using Rustic.Code.Block;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace Rustic
{
    public class RusticModSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            // Block classes
            api.RegisterBlockClass("Rustic.BlockLargeRusticGenericContainer", typeof(BlockLargeRusticGenericContainer));
            api.RegisterBlockClass("Rustic.BlockSmallRusticGenericContainer", typeof(BlockSmallRusticGenericContainer));
        }

    }
}
