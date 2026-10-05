using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.DB.Test
{
	// Token: 0x020016B7 RID: 5815
	[Token(Token = "0x20016B7")]
	public class SettingsDef
	{
		// Token: 0x0600932F RID: 37679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600932F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SettingsDef()
		{
		}

		// Token: 0x040088D3 RID: 35027
		[Token(Token = "0x40088D3")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040088D4 RID: 35028
		[Token(Token = "0x40088D4")]
		[FieldOffset(Offset = "0x18")]
		public List<int> list;

		// Token: 0x040088D5 RID: 35029
		[Token(Token = "0x40088D5")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> args;

		// Token: 0x040088D6 RID: 35030
		[Token(Token = "0x40088D6")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, object> args2;
	}
}
