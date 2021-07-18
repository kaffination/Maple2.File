using System.Numerics;

namespace Maple2.File.Flat.maplestory2library {
    public interface IMS2RegionBoxSpawn : IMS2RegionSpawnBase {
        Vector3 RegionDimension => new Vector3(450, 450, 450);
        Vector3 DummyForVisualizer => default;
    }
}
