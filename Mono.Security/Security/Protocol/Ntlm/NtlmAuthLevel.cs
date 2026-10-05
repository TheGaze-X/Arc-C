using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public enum NtlmAuthLevel
	{
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		LM_and_NTLM,
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		LM_and_NTLM_and_try_NTLMv2_Session,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		NTLM_only,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		NTLMv2_only
	}
}
