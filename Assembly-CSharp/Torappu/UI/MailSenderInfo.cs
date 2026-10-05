using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003AC5 RID: 15045
	[Token(Token = "0x2003AC5")]
	public struct MailSenderInfo
	{
		// Token: 0x06017BC4 RID: 97220 RVA: 0x00097D40 File Offset: 0x00095F40
		[Token(Token = "0x6017BC4")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0401CA70 RID: 117360
		[Token(Token = "0x401CA70")]
		[FieldOffset(Offset = "0x0")]
		public string id;

		// Token: 0x0401CA71 RID: 117361
		[Token(Token = "0x401CA71")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x0401CA72 RID: 117362
		[Token(Token = "0x401CA72")]
		[FieldOffset(Offset = "0x10")]
		public Sprite avatar;
	}
}
