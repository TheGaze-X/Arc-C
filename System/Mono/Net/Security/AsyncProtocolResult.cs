using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	internal class AsyncProtocolResult
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x1700001A")]
		public int UserResult
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public ExceptionDispatchInfo Error
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		public AsyncProtocolResult(int result)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		public AsyncProtocolResult(ExceptionDispatchInfo error)
		{
		}
	}
}
