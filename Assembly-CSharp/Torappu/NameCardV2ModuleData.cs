using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FFC RID: 4092
	[Token(Token = "0x2000FFC")]
	public class NameCardV2ModuleData
	{
		// Token: 0x06006D56 RID: 27990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D56")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NameCardV2ModuleData()
		{
		}

		// Token: 0x040056CC RID: 22220
		[Token(Token = "0x40056CC")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040056CD RID: 22221
		[Token(Token = "0x40056CD")]
		[FieldOffset(Offset = "0x18")]
		public NameCardV2ModuleType type;
	}
}
