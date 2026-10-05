using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200216C RID: 8556
	[Token(Token = "0x200216C")]
	[Serializable]
	public class BakedEventTimeline
	{
		// Token: 0x0600D2CF RID: 53967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BakedEventTimeline()
		{
		}

		// Token: 0x0400E1CF RID: 57807
		[Token(Token = "0x400E1CF")]
		[FieldOffset(Offset = "0x10")]
		public float[] eventTime;

		// Token: 0x0400E1D0 RID: 57808
		[Token(Token = "0x400E1D0")]
		[FieldOffset(Offset = "0x18")]
		public string[] events;
	}
}
