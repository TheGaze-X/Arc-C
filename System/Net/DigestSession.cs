using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	internal class DigestSession
	{
		// Token: 0x0600154A RID: 5450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x506CDD0", Offset = "0x506B9D0", VA = "0x18506CDD0")]
		public DigestSession()
		{
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047F")]
		public string Algorithm
		{
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x506CE30", Offset = "0x506BA30", VA = "0x18506CE30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000480")]
		public string Realm
		{
			[Token(Token = "0x600154C")]
			[Address(RVA = "0x506D050", Offset = "0x506BC50", VA = "0x18506D050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000481")]
		public string Nonce
		{
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x506CF90", Offset = "0x506BB90", VA = "0x18506CF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000482")]
		public string Opaque
		{
			[Token(Token = "0x600154E")]
			[Address(RVA = "0x506CFD0", Offset = "0x506BBD0", VA = "0x18506CFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000483")]
		public string QOP
		{
			[Token(Token = "0x600154F")]
			[Address(RVA = "0x506D010", Offset = "0x506BC10", VA = "0x18506D010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000484")]
		public string CNonce
		{
			[Token(Token = "0x6001550")]
			[Address(RVA = "0x506CE70", Offset = "0x506BA70", VA = "0x18506CE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00009EE8 File Offset: 0x000080E8
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x506C820", Offset = "0x506B420", VA = "0x18506C820")]
		public bool Parse(string challenge)
		{
			return default(bool);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x506C680", Offset = "0x506B280", VA = "0x18506C680")]
		private string HashToHexString(string toBeHashed)
		{
			return null;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x506C400", Offset = "0x506B000", VA = "0x18506C400")]
		private string HA1(string username, string password)
		{
			return null;
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x506C560", Offset = "0x506B160", VA = "0x18506C560")]
		private string HA2(HttpWebRequest webRequest)
		{
			return null;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x506C9E0", Offset = "0x506B5E0", VA = "0x18506C9E0")]
		private string Response(string username, string password, HttpWebRequest webRequest)
		{
			return null;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x506BE30", Offset = "0x506AA30", VA = "0x18506BE30")]
		public Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x17000485")]
		public DateTime LastUse
		{
			[Token(Token = "0x6001557")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x0")]
		private static RandomNumberGenerator rng;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x10")]
		private DateTime lastUse;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x18")]
		private int _nc;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0x20")]
		private HashAlgorithm hash;

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x28")]
		private DigestHeaderParser parser;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x30")]
		private string _cnonce;
	}
}
