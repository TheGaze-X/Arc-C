using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class OAuthManager
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4E0A5A0", Offset = "0x4E091A0", VA = "0x184E0A5A0")]
		public OAuthManager()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4E0A880", Offset = "0x4E09480", VA = "0x184E0A880")]
		public OAuthManager(string consumerKey, string consumerSecret, string token, string tokenSecret)
		{
		}

		// Token: 0x17000006 RID: 6
		[Token(Token = "0x17000006")]
		public string this[string ix]
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x4E0CB90", Offset = "0x4E0B790", VA = "0x184E0CB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x4E0D060", Offset = "0x4E0BC60", VA = "0x184E0D060")]
			set
			{
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4E0BEB0", Offset = "0x4E0AAB0", VA = "0x184E0BEB0")]
		private string generateTimeStamp()
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4E0CFB0", Offset = "0x4E0BBB0", VA = "0x184E0CFB0")]
		private void prepareNewRequest()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4E0BD70", Offset = "0x4E0A970", VA = "0x184E0BD70")]
		private string generateNonce()
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4E0BA70", Offset = "0x4E0A670", VA = "0x184E0BA70")]
		private SortedDictionary<string, string> extractQueryParameters(string queryString)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4E0D250", Offset = "0x4E0BE50", VA = "0x184E0D250")]
		public static string urlEncode(string value)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4E0CC60", Offset = "0x4E0B860", VA = "0x184E0CC60")]
		private static SortedDictionary<string, string> mergePostParamsWithOauthParams(SortedDictionary<string, string> postParams, SortedDictionary<string, string> oAuthParams)
		{
			return null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4E0B780", Offset = "0x4E0A380", VA = "0x184E0B780")]
		private static string encodeRequestParameters(SortedDictionary<string, string> p)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4E0B480", Offset = "0x4E0A080", VA = "0x184E0B480")]
		public static byte[] encodePostParameters(SortedDictionary<string, string> p)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4E0AF00", Offset = "0x4E09B00", VA = "0x184E0AF00")]
		public OAuthResponse acquireRequestToken(string uri, string method)
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4E0A9A0", Offset = "0x4E095A0", VA = "0x184E0A9A0")]
		public OAuthResponse acquireAccessToken(string uri, string method, string verifier)
		{
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4E0BD10", Offset = "0x4E0A910", VA = "0x184E0BD10")]
		public string generateCredsHeader(string uri, string method, string realm)
		{
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4E0BCC0", Offset = "0x4E0A8C0", VA = "0x184E0BCC0")]
		public string generateAuthzHeader(string uri, string method)
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4E0C2A0", Offset = "0x4E0AEA0", VA = "0x184E0C2A0")]
		private string getAuthorizationHeader(string uri, string method)
		{
			return null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4E0BFC0", Offset = "0x4E0ABC0", VA = "0x184E0BFC0")]
		private string getAuthorizationHeader(string uri, string method, string realm)
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4E0D140", Offset = "0x4E0BD40", VA = "0x184E0D140")]
		private void sign(string uri, string method)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4E0C4C0", Offset = "0x4E0B0C0", VA = "0x184E0C4C0")]
		private string getSignatureBase(string url, string method)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4E0C2C0", Offset = "0x4E0AEC0", VA = "0x184E0C2C0")]
		private HashAlgorithm getHash()
		{
			return null;
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime _epoch;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		private SortedDictionary<string, string> _params;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private Random _random;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x8")]
		private static string unreservedChars;
	}
}
