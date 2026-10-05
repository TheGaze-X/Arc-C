using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001222 RID: 4642
	[Token(Token = "0x2001222")]
	public class RoguelikeGameCharBuffData
	{
		// Token: 0x06007020 RID: 28704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007020")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameCharBuffData()
		{
		}

		// Token: 0x0400643B RID: 25659
		[Token(Token = "0x400643B")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400643C RID: 25660
		[Token(Token = "0x400643C")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeGameCharBuffType buffType;

		// Token: 0x0400643D RID: 25661
		[Token(Token = "0x400643D")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x0400643E RID: 25662
		[Token(Token = "0x400643E")]
		[FieldOffset(Offset = "0x28")]
		public string outerName;

		// Token: 0x0400643F RID: 25663
		[Token(Token = "0x400643F")]
		[FieldOffset(Offset = "0x30")]
		public string innerName;

		// Token: 0x04006440 RID: 25664
		[Token(Token = "0x4006440")]
		[FieldOffset(Offset = "0x38")]
		public string functionDesc;

		// Token: 0x04006441 RID: 25665
		[Token(Token = "0x4006441")]
		[FieldOffset(Offset = "0x40")]
		public string desc;

		// Token: 0x04006442 RID: 25666
		[Token(Token = "0x4006442")]
		[FieldOffset(Offset = "0x48")]
		public List<RoguelikeBuff> buffs;
	}
}
