using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FFE RID: 4094
	[Token(Token = "0x2000FFE")]
	public class NameCardV2RemovableModuleData : NameCardV2ModuleData
	{
		// Token: 0x06006D57 RID: 27991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D57")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NameCardV2RemovableModuleData()
		{
		}

		// Token: 0x040056D5 RID: 22229
		[Token(Token = "0x40056D5")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x040056D6 RID: 22230
		[Token(Token = "0x40056D6")]
		[FieldOffset(Offset = "0x24")]
		public NameCardV2ModuleSubType subType;

		// Token: 0x040056D7 RID: 22231
		[Token(Token = "0x40056D7")]
		[FieldOffset(Offset = "0x28")]
		public string name;
	}
}
