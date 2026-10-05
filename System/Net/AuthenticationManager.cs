using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	public class AuthenticationManager
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x5068130", Offset = "0x5066D30", VA = "0x185068130")]
		private static void EnsureModules()
		{
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x5067BD0", Offset = "0x50667D0", VA = "0x185067BD0")]
		public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001522")]
		[Address(RVA = "0x5067D50", Offset = "0x5066950", VA = "0x185067D50")]
		private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x5068430", Offset = "0x5067030", VA = "0x185068430")]
		public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x0")]
		private static ArrayList modules;

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x8")]
		private static object locker;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x10")]
		private static ICredentialPolicy credential_policy;
	}
}
