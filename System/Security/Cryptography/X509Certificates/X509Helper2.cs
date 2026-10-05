using System;
using Il2CppDummyDll;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	internal static class X509Helper2
	{
		// Token: 0x06000868 RID: 2152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x5136A80", Offset = "0x5135680", VA = "0x185136A80")]
		[MonoTODO("Investigate replacement; see comments in source.")]
		internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate)
		{
			return null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x51369A0", Offset = "0x51355A0", VA = "0x1851369A0")]
		internal static X509ChainImpl CreateChainImpl(bool useMachineContext)
		{
			return null;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x4B6CCA0", Offset = "0x4B6B8A0", VA = "0x184B6CCA0")]
		public static bool IsValid(X509ChainImpl impl)
		{
			return default(bool);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x5136C00", Offset = "0x5135800", VA = "0x185136C00")]
		internal static void ThrowIfContextInvalid(X509ChainImpl impl)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x5136A00", Offset = "0x5135600", VA = "0x185136A00")]
		internal static Exception GetInvalidChainContextException()
		{
			return null;
		}
	}
}
