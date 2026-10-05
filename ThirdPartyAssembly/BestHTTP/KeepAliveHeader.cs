using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x2000496")]
	internal sealed class KeepAliveHeader
	{
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x00010848 File Offset: 0x0000EA48
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053C")]
		public TimeSpan TimeOut
		{
			[Token(Token = "0x6002632")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002633")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x00010860 File Offset: 0x0000EA60
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053D")]
		public int MaxRequests
		{
			[Token(Token = "0x6002634")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002635")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x539AB90", Offset = "0x5399790", VA = "0x18539AB90")]
		public void Parse(List<string> headerValues)
		{
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeepAliveHeader()
		{
		}
	}
}
