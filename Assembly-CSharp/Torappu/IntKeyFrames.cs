using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FA3 RID: 4003
	[Token(Token = "0x2000FA3")]
	[Serializable]
	public class IntKeyFrames : KeyFrames<int>
	{
		// Token: 0x06006CE9 RID: 27881 RVA: 0x00031AE8 File Offset: 0x0002FCE8
		[Token(Token = "0x6006CE9")]
		[Address(RVA = "0x2105E30", Offset = "0x2104A30", VA = "0x182105E30", Slot = "35")]
		protected override int LerpData(KeyFrames<int, int>.KeyFrame from, KeyFrames<int, int>.KeyFrame to, int level)
		{
			return 0;
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEA")]
		[Address(RVA = "0x2105E70", Offset = "0x2104A70", VA = "0x182105E70")]
		public IntKeyFrames()
		{
		}
	}
}
