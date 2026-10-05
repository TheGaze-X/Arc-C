using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.CETest
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	public class CETestDataType
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CETestDataType()
		{
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CETestDataLevel> levels;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CETestDataSquad> squads;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, List<string>> relations;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x28")]
		public List<string> squadsAlways;
	}
}
