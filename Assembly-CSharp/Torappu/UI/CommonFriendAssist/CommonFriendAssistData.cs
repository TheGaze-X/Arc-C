using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BC6 RID: 23494
	[Token(Token = "0x2005BC6")]
	public class CommonFriendAssistData
	{
		// Token: 0x0602211E RID: 139550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602211E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonFriendAssistData()
		{
		}

		// Token: 0x0402EBC8 RID: 191432
		[Token(Token = "0x402EBC8")]
		[FieldOffset(Offset = "0x10")]
		public List<SquadAssistData> assistList;

		// Token: 0x0402EBC9 RID: 191433
		[Token(Token = "0x402EBC9")]
		[FieldOffset(Offset = "0x18")]
		public List<SquadAssistData> starFriendAssistList;

		// Token: 0x0402EBCA RID: 191434
		[Token(Token = "0x402EBCA")]
		[FieldOffset(Offset = "0x20")]
		public ProfessionCategory prof;
	}
}
