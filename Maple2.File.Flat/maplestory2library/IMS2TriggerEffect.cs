using Maple2.File.Flat.standardmodellibrary;

namespace Maple2.File.Flat.maplestory2library {
    public interface IMS2TriggerEffect : IMS2TriggerObject, I3DProxy {
        string XmlFilePath => "";
        uint EffectOID => 0;
    }
}
