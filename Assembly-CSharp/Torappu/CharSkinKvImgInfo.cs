using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200132D RID: 4909
	[Token(Token = "0x200132D")]
	[Serializable]
	public class CharSkinKvImgInfo
	{
		// Token: 0x060072ED RID: 29421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072ED")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharSkinKvImgInfo()
		{
		}

		// Token: 0x04006CF0 RID: 27888
		[Token(Token = "0x4006CF0")]
		[FieldOffset(Offset = "0x10")]
		public string kvImgId;

		// Token: 0x04006CF1 RID: 27889
		[Token(Token = "0x4006CF1")]
		[FieldOffset(Offset = "0x18")]
		public string linkedSkinGroupId;
	}
}
