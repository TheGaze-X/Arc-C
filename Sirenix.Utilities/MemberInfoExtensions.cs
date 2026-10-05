using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public static class MemberInfoExtensions
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x600012D")]
		public static bool IsDefined<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			return default(bool);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600012E")]
		public static bool IsDefined<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600012F")]
		public static T GetAttribute<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000130")]
		public static T GetAttribute<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			return null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000131")]
		public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			return null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000132")]
		public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			return null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4E26B20", Offset = "0x4E25720", VA = "0x184E26B20")]
		public static Attribute[] GetAttributes(this ICustomAttributeProvider member)
		{
			return null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4E26AA0", Offset = "0x4E256A0", VA = "0x184E26AA0")]
		public static Attribute[] GetAttributes(this ICustomAttributeProvider member, bool inherit)
		{
			return null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4E26B90", Offset = "0x4E25790", VA = "0x184E26B90")]
		public static string GetNiceName(this MemberInfo member)
		{
			return null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4E27190", Offset = "0x4E25D90", VA = "0x184E27190")]
		public static bool IsStatic(this MemberInfo member)
		{
			return default(bool);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4E27100", Offset = "0x4E25D00", VA = "0x184E27100")]
		public static bool IsAlias(this MemberInfo memberInfo)
		{
			return default(bool);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4E26920", Offset = "0x4E25520", VA = "0x184E26920")]
		public static MemberInfo DeAlias(this MemberInfo memberInfo, bool throwOnNotAliased = false)
		{
			return null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4E27590", Offset = "0x4E26190", VA = "0x184E27590")]
		public static bool SignaturesAreEqual(this MemberInfo a, MemberInfo b)
		{
			return default(bool);
		}
	}
}
