using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	public class BuildingChangeShopRequest : BuildingRequest
	{
		// Token: 0x06006270 RID: 25200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006270")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingChangeShopRequest()
		{
		}

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DF8 RID: 11768
		[Token(Token = "0x4002DF8")]
		[FieldOffset(Offset = "0x18")]
		public int stockIndex;

		// Token: 0x04002DF9 RID: 11769
		[Token(Token = "0x4002DF9")]
		[FieldOffset(Offset = "0x20")]
		public string targetFormulaId;

		// Token: 0x04002DFA RID: 11770
		[Token(Token = "0x4002DFA")]
		[FieldOffset(Offset = "0x28")]
		public int solutionCount;
	}
}
