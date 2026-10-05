using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	internal struct StyleVariable
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110F")]
		[Address(RVA = "0x17F8010", Offset = "0x17F6C10", VA = "0x1817F8010")]
		public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles)
		{
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x6001110")]
		[Address(RVA = "0x5B265C0", Offset = "0x5B251C0", VA = "0x185B265C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0x0")]
		public readonly string name;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[FieldOffset(Offset = "0x8")]
		public readonly StyleSheet sheet;

		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		[FieldOffset(Offset = "0x10")]
		public readonly StyleValueHandle[] handles;
	}
}
