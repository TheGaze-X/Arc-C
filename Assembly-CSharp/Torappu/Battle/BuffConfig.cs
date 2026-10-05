using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200263E RID: 9790
	[Token(Token = "0x200263E")]
	public struct BuffConfig
	{
		// Token: 0x06010032 RID: 65586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010032")]
		[Address(RVA = "0x778B00", Offset = "0x777700", VA = "0x180778B00")]
		public string GetEffectKey()
		{
			return null;
		}

		// Token: 0x06010033 RID: 65587 RVA: 0x000616C8 File Offset: 0x0005F8C8
		[Token(Token = "0x6010033")]
		[Address(RVA = "0x778B50", Offset = "0x777750", VA = "0x180778B50")]
		public BuffData.OnEventPriority GetOnEventPriority()
		{
			return BuffData.OnEventPriority.DEFAULT;
		}

		// Token: 0x04011CB6 RID: 72886
		[Token(Token = "0x4011CB6")]
		[FieldOffset(Offset = "0x0")]
		public BuffTemplate template;

		// Token: 0x04011CB7 RID: 72887
		[Token(Token = "0x4011CB7")]
		[FieldOffset(Offset = "0x8")]
		public BuffData data;
	}
}
