using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	internal class GradientRemap : LinkedPoolItem<GradientRemap>
	{
		// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x5A58BE0", Offset = "0x5A577E0", VA = "0x185A58BE0")]
		public void Reset()
		{
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x5A58C50", Offset = "0x5A57850", VA = "0x185A58C50")]
		public GradientRemap()
		{
		}

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x18")]
		public int origIndex;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[FieldOffset(Offset = "0x1C")]
		public int destIndex;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[FieldOffset(Offset = "0x20")]
		public RectInt location;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x30")]
		public GradientRemap next;

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x38")]
		public TextureId atlas;
	}
}
