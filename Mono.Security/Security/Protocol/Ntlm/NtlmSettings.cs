using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public static class NtlmSettings
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x17000055")]
		public static NtlmAuthLevel DefaultAuthLevel
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x4A9EF70", Offset = "0x4A9DB70", VA = "0x184A9EF70")]
			get
			{
				return NtlmAuthLevel.LM_and_NTLM;
			}
		}

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x0")]
		private static NtlmAuthLevel defaultAuthLevel;
	}
}
