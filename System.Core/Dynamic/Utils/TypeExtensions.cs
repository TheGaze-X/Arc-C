using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Dynamic.Utils
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	internal static class TypeExtensions
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4F467D0", Offset = "0x4F453D0", VA = "0x184F467D0")]
		public static MethodInfo GetAnyStaticMethodValidated(this Type type, string name, Type[] types)
		{
			return null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4F46B50", Offset = "0x4F45750", VA = "0x184F46B50")]
		private static bool MatchesArgumentTypes(this MethodInfo mi, Type[] argTypes)
		{
			return default(bool);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4F46B00", Offset = "0x4F45700", VA = "0x184F46B00")]
		public static TypeCode GetTypeCode(this Type type)
		{
			return TypeCode.Empty;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4F46990", Offset = "0x4F45590", VA = "0x184F46990")]
		internal static ParameterInfo[] GetParametersCached(this MethodBase method)
		{
			return null;
		}

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache;
	}
}
