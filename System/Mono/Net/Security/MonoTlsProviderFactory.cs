using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	internal static class MonoTlsProviderFactory
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x4F5C660", Offset = "0x4F5B260", VA = "0x184F5C660")]
		internal static MobileTlsProvider GetProviderInternal()
		{
			return null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x4F5C7A0", Offset = "0x4F5B3A0", VA = "0x184F5C7A0")]
		internal static void InitializeInternal()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x4F5CF30", Offset = "0x4F5BB30", VA = "0x184F5CF30")]
		private static MobileTlsProvider LookupProvider(string name, bool throwOnError)
		{
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x4F5CB70", Offset = "0x4F5B770", VA = "0x184F5CB70")]
		private static void InitializeProviderRegistration()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4F5D6F0", Offset = "0x4F5C2F0", VA = "0x184F5D6F0")]
		private static void PopulateUnityProviders()
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x4F5D4C0", Offset = "0x4F5C0C0", VA = "0x184F5D4C0")]
		private static void PopulateProviders()
		{
		}

		// Token: 0x06000173 RID: 371
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal static extern bool IsBtlsSupported();

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4F5C3E0", Offset = "0x4F5AFE0", VA = "0x184F5C3E0")]
		private static MobileTlsProvider CreateDefaultProviderImpl()
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x4F5C760", Offset = "0x4F5B360", VA = "0x184F5C760")]
		internal static MobileTlsProvider GetProvider()
		{
			return null;
		}

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x0")]
		private static object locker;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x8")]
		private static bool initialized;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x10")]
		private static MobileTlsProvider defaultProvider;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Tuple<Guid, string>> providerRegistration;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<Guid, MobileTlsProvider> providerCache;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly Guid UnityTlsId;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly Guid AppleTlsId;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x48")]
		internal static readonly Guid BtlsId;
	}
}
