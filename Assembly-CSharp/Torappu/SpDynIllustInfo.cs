using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200132F RID: 4911
	[Token(Token = "0x200132F")]
	[Serializable]
	public class SpDynIllustInfo
	{
		// Token: 0x060072EF RID: 29423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpDynIllustInfo()
		{
		}

		// Token: 0x04006CF5 RID: 27893
		[Token(Token = "0x4006CF5")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x04006CF6 RID: 27894
		[Token(Token = "0x4006CF6")]
		[FieldOffset(Offset = "0x18")]
		public string spDynIllustId;

		// Token: 0x04006CF7 RID: 27895
		[Token(Token = "0x4006CF7")]
		[FieldOffset(Offset = "0x20")]
		public string spDynIllustSkinTag;

		// Token: 0x04006CF8 RID: 27896
		[Token(Token = "0x4006CF8")]
		[FieldOffset(Offset = "0x28")]
		public string spIllustId;

		// Token: 0x04006CF9 RID: 27897
		[Token(Token = "0x4006CF9")]
		[FieldOffset(Offset = "0x30")]
		public string spPortraitId;

		// Token: 0x04006CFA RID: 27898
		[Token(Token = "0x4006CFA")]
		[FieldOffset(Offset = "0x38")]
		public string spAvatarId;
	}
}
