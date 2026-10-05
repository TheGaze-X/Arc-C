using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200132C RID: 4908
	[Token(Token = "0x200132C")]
	[Serializable]
	public class CharSkinGroupInfo
	{
		// Token: 0x060072EC RID: 29420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharSkinGroupInfo()
		{
		}

		// Token: 0x04006CEE RID: 27886
		[Token(Token = "0x4006CEE")]
		[FieldOffset(Offset = "0x10")]
		public string skinGroupId;

		// Token: 0x04006CEF RID: 27887
		[Token(Token = "0x4006CEF")]
		[FieldOffset(Offset = "0x18")]
		public long publishTime;
	}
}
