using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200132B RID: 4907
	[Token(Token = "0x200132B")]
	[Serializable]
	public class CharSkinBrandInfo
	{
		// Token: 0x060072EB RID: 29419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharSkinBrandInfo()
		{
		}

		// Token: 0x04006CE6 RID: 27878
		[Token(Token = "0x4006CE6")]
		[FieldOffset(Offset = "0x10")]
		public string brandId;

		// Token: 0x04006CE7 RID: 27879
		[Token(Token = "0x4006CE7")]
		[FieldOffset(Offset = "0x18")]
		public List<CharSkinGroupInfo> groupList;

		// Token: 0x04006CE8 RID: 27880
		[Token(Token = "0x4006CE8")]
		[FieldOffset(Offset = "0x20")]
		public List<CharSkinKvImgInfo> kvImgIdList;

		// Token: 0x04006CE9 RID: 27881
		[Token(Token = "0x4006CE9")]
		[FieldOffset(Offset = "0x28")]
		public string brandName;

		// Token: 0x04006CEA RID: 27882
		[Token(Token = "0x4006CEA")]
		[FieldOffset(Offset = "0x30")]
		public string brandCapitalName;

		// Token: 0x04006CEB RID: 27883
		[Token(Token = "0x4006CEB")]
		[FieldOffset(Offset = "0x38")]
		public string description;

		// Token: 0x04006CEC RID: 27884
		[Token(Token = "0x4006CEC")]
		[FieldOffset(Offset = "0x40")]
		public long publishTime;

		// Token: 0x04006CED RID: 27885
		[Token(Token = "0x4006CED")]
		[FieldOffset(Offset = "0x48")]
		public int sortId;
	}
}
