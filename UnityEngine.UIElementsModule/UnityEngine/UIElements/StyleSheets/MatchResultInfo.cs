using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002EF RID: 751
	[Token(Token = "0x20002EF")]
	internal struct MatchResultInfo
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x5A7BAC0", Offset = "0x5A7A6C0", VA = "0x185A7BAC0")]
		public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask)
		{
		}

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x0")]
		public readonly bool success;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x4")]
		public readonly PseudoStates triggerPseudoMask;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x8")]
		public readonly PseudoStates dependencyPseudoMask;
	}
}
