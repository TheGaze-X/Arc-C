using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002FA RID: 762
	[Token(Token = "0x20002FA")]
	internal struct MatchResult
	{
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x1700051D")]
		public bool success
		{
			[Token(Token = "0x60014C6")]
			[Address(RVA = "0x5A7BAD0", Offset = "0x5A7A6D0", VA = "0x185A7BAD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0x0")]
		public MatchResultErrorCode errorCode;

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		[FieldOffset(Offset = "0x8")]
		public string errorValue;
	}
}
