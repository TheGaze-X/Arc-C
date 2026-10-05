using System;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E56 RID: 20054
	[Token(Token = "0x2004E56")]
	public class FireworkUseHintResponse : PlayerDeltaResponse
	{
		// Token: 0x0601DED5 RID: 122581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DED5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public FireworkUseHintResponse()
		{
		}

		// Token: 0x04027B9C RID: 162716
		[Token(Token = "0x4027B9C")]
		[FieldOffset(Offset = "0x28")]
		public FireworkData.PlateSlotData solution;
	}
}
