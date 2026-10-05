using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001223 RID: 4643
	[Token(Token = "0x2001223")]
	public class RoguelikeGameSquadBuffData
	{
		// Token: 0x06007021 RID: 28705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007021")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameSquadBuffData()
		{
		}

		// Token: 0x04006443 RID: 25667
		[Token(Token = "0x4006443")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006444 RID: 25668
		[Token(Token = "0x4006444")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x04006445 RID: 25669
		[Token(Token = "0x4006445")]
		[FieldOffset(Offset = "0x20")]
		public string outerName;

		// Token: 0x04006446 RID: 25670
		[Token(Token = "0x4006446")]
		[FieldOffset(Offset = "0x28")]
		public string innerName;

		// Token: 0x04006447 RID: 25671
		[Token(Token = "0x4006447")]
		[FieldOffset(Offset = "0x30")]
		public string functionDesc;

		// Token: 0x04006448 RID: 25672
		[Token(Token = "0x4006448")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x04006449 RID: 25673
		[Token(Token = "0x4006449")]
		[FieldOffset(Offset = "0x40")]
		public List<RoguelikeBuff> buffs;
	}
}
