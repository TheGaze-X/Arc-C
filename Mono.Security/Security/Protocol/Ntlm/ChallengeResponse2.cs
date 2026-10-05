using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public static class ChallengeResponse2
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4A77980", Offset = "0x4A76580", VA = "0x184A77980")]
		private static byte[] Compute_LM(string password, byte[] challenge)
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4A77CC0", Offset = "0x4A768C0", VA = "0x184A77CC0")]
		private static byte[] Compute_NTLM_Password(string password)
		{
			return null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4A77DF0", Offset = "0x4A769F0", VA = "0x184A77DF0")]
		private static byte[] Compute_NTLM(string password, byte[] challenge)
		{
			return null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4A77E60", Offset = "0x4A76A60", VA = "0x184A77E60")]
		private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4A780B0", Offset = "0x4A76CB0", VA = "0x184A780B0")]
		private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain)
		{
			return null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4A78560", Offset = "0x4A77160", VA = "0x184A78560")]
		public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4A78780", Offset = "0x4A77380", VA = "0x184A78780")]
		private static byte[] GetResponse(byte[] challenge, byte[] pwd)
		{
			return null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4A78BE0", Offset = "0x4A777E0", VA = "0x184A78BE0")]
		private static byte[] PrepareDESKey(byte[] key56bits, int position)
		{
			return null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4A78A50", Offset = "0x4A77650", VA = "0x184A78A50")]
		private static byte[] PasswordToKey(string password, int position)
		{
			return null;
		}

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] magic;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] nullEncMagic;
	}
}
