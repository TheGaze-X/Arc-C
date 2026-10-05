using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FA4 RID: 4004
	[Token(Token = "0x2000FA4")]
	[Serializable]
	public class FloatKeyFrames : KeyFrames<float>
	{
		// Token: 0x06006CEB RID: 27883 RVA: 0x00031B00 File Offset: 0x0002FD00
		[Token(Token = "0x6006CEB")]
		[Address(RVA = "0x2104A30", Offset = "0x2103630", VA = "0x182104A30", Slot = "35")]
		protected override float LerpData(KeyFrames<float, float>.KeyFrame from, KeyFrames<float, float>.KeyFrame to, int level)
		{
			return 0f;
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEC")]
		[Address(RVA = "0x2104A80", Offset = "0x2103680", VA = "0x182104A80")]
		public FloatKeyFrames()
		{
		}
	}
}
