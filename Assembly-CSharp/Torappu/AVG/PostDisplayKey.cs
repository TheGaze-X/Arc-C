using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F02 RID: 7938
	[Token(Token = "0x2001F02")]
	public struct PostDisplayKey
	{
		// Token: 0x0600C51B RID: 50459 RVA: 0x000483D8 File Offset: 0x000465D8
		[Token(Token = "0x600C51B")]
		[Address(RVA = "0x3430CE0", Offset = "0x342F8E0", VA = "0x183430CE0")]
		public bool IsMatch(PostDisplayKey other)
		{
			return default(bool);
		}

		// Token: 0x0400C9A3 RID: 51619
		[Token(Token = "0x400C9A3")]
		[FieldOffset(Offset = "0x0")]
		public string id;

		// Token: 0x0400C9A4 RID: 51620
		[Token(Token = "0x400C9A4")]
		[FieldOffset(Offset = "0x8")]
		public PostDisplayType type;

		// Token: 0x0400C9A5 RID: 51621
		[Token(Token = "0x400C9A5")]
		[FieldOffset(Offset = "0x10")]
		public Component component;
	}
}
