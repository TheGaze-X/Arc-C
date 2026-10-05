using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[Preserve]
	public static class Extensions
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F5")]
		public static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F6")]
		public static IJEnumerable<JToken> AncestorsAndSelf<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F7")]
		public static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T : JContainer
		{
			return null;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F8")]
		public static IJEnumerable<JToken> DescendantsAndSelf<T>(this IEnumerable<T> source) where T : JContainer
		{
			return null;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x4DB7F50", Offset = "0x4DB6B50", VA = "0x184DB7F50")]
		public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			return null;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x4DB80B0", Offset = "0x4DB6CB0", VA = "0x184DB80B0")]
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, object key)
		{
			return null;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x4DB8130", Offset = "0x4DB6D30", VA = "0x184DB8130")]
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			return null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FC")]
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, object key)
		{
			return null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FD")]
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source)
		{
			return null;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FE")]
		public static U Value<U>(this IEnumerable<JToken> value)
		{
			return null;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FF")]
		public static U Value<T, U>(this IEnumerable<T> value) where T : JToken
		{
			return null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000700")]
		internal static IEnumerable<U> Values<T, U>(this IEnumerable<T> source, object key) where T : JToken
		{
			return null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000701")]
		public static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000702")]
		public static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000703")]
		internal static IEnumerable<U> Convert<T, U>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000704")]
		internal static U Convert<T, U>(this T token) where T : JToken
		{
			return null;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x4DB7F10", Offset = "0x4DB6B10", VA = "0x184DB7F10")]
		public static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
		{
			return null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000706")]
		public static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}
	}
}
