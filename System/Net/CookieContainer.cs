using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	[Serializable]
	public class CookieContainer
	{
		// Token: 0x060014A5 RID: 5285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x504EC90", Offset = "0x504D890", VA = "0x18504EC90")]
		public CookieContainer()
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x504B690", Offset = "0x504A290", VA = "0x18504B690")]
		private void AddRemoveDomain(string key, PathList value)
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x504B800", Offset = "0x504A400", VA = "0x18504B800")]
		internal void Add(Cookie cookie, bool throwOnError)
		{
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x504C0B0", Offset = "0x504ACB0", VA = "0x18504C0B0")]
		private bool AgeCookies(string domain)
		{
			return default(bool);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x504DDB0", Offset = "0x504C9B0", VA = "0x18504DDB0")]
		private int ExpireCollection(CookieCollection cc)
		{
			return 0;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x504E700", Offset = "0x504D300", VA = "0x18504E700")]
		internal bool IsLocalDomain(string host)
		{
			return default(bool);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x504D650", Offset = "0x504C250", VA = "0x18504D650")]
		internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			return null;
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x504E350", Offset = "0x504CF50", VA = "0x18504E350")]
		internal CookieCollection InternalGetCookies(Uri uri)
		{
			return null;
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x504CF10", Offset = "0x504BB10", VA = "0x18504CF10")]
		private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x504E9A0", Offset = "0x504D5A0", VA = "0x18504E9A0")]
		private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x504DF30", Offset = "0x504CB30", VA = "0x18504DF30")]
		public string GetCookieHeader(Uri uri)
		{
			return null;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x504E000", Offset = "0x504CC00", VA = "0x18504E000")]
		internal string GetCookieHeader(Uri uri, out string optCookie2)
		{
			return null;
		}

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HeaderVariantInfo[] HeaderInfo;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x10")]
		private Hashtable m_domainTable;

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x18")]
		private int m_maxCookieSize;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x1C")]
		private int m_maxCookies;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x20")]
		private int m_maxCookiesPerDomain;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x24")]
		private int m_count;

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x28")]
		private string m_fqdnMyDomain;
	}
}
