using Stride.Engine;
using VoxelWorldBuilding.Types;

namespace MyGame
{
    public class EnumExmaple : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
            foreach(MyEnum myEnum in MyEnumExtensions.GetValues())
            {
                Log.Verbose(myEnum.ToString());
            }
        }

        public override void Update()
        {
            // Do stuff every new frame
        }
    }
}
