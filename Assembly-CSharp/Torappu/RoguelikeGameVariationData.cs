using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200121F RID: 4639
	[Token(Token = "0x200121F")]
	public class RoguelikeGameVariationData
	{
		// Token: 0x0600701E RID: 28702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600701E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameVariationData()
		{
		}

		// Token: 0x0400642A RID: 25642
		[Token(Token = "0x400642A")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400642B RID: 25643
		[Token(Token = "0x400642B")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeGameVariationType type;

		// Token: 0x0400642C RID: 25644
		[Token(Token = "0x400642C")]
		[FieldOffset(Offset = "0x20")]
		public string outerName;

		// Token: 0x0400642D RID: 25645
		[Token(Token = "0x400642D")]
		[FieldOffset(Offset = "0x28")]
		public string innerName;

		// Token: 0x0400642E RID: 25646
		[Token(Token = "0x400642E")]
		[FieldOffset(Offset = "0x30")]
		public string functionDesc;

		// Token: 0x0400642F RID: 25647
		[Token(Token = "0x400642F")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x04006430 RID: 25648
		[Token(Token = "0x4006430")]
		[FieldOffset(Offset = "0x40")]
		public string iconId;

		// Token: 0x04006431 RID: 25649
		[Token(Token = "0x4006431")]
		[FieldOffset(Offset = "0x48")]
		public string sound;
	}
}
