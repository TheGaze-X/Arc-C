using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Internal.Cryptography
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	internal static class OidLookup
	{
		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x50DC240", Offset = "0x50DAE40", VA = "0x1850DC240")]
		public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			return null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x50DC4B0", Offset = "0x50DB0B0", VA = "0x1850DC4B0")]
		public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private static bool ShouldUseCache(OidGroup oidGroup)
		{
			return default(bool);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x50DBEF0", Offset = "0x50DAAF0", VA = "0x1850DBEF0")]
		private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			return null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x50DBBA0", Offset = "0x50DA7A0", VA = "0x1850DBBA0")]
		private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			return null;
		}

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, string> s_friendlyNameToOid;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<string, string> s_oidToFriendlyName;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<string, string> s_compatOids;
	}
}
