using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020021EE RID: 8686
	[Token(Token = "0x20021EE")]
	[Serializable]
	public struct EffectReplacePair
	{
		// Token: 0x0600D954 RID: 55636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D954")]
		[Address(RVA = "0x35E1010", Offset = "0x35DFC10", VA = "0x1835E1010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400EA5A RID: 59994
		[Token(Token = "0x400EA5A")]
		[FieldOffset(Offset = "0x0")]
		public string fromEffect;

		// Token: 0x0400EA5B RID: 59995
		[Token(Token = "0x400EA5B")]
		[FieldOffset(Offset = "0x8")]
		public string toEffect;
	}
}
