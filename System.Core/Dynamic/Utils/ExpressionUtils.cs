using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Dynamic.Utils
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	internal static class ExpressionUtils
	{
		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection)
		{
			return null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		public static T ReturnObject<T>(object collectionOrT) where T : class
		{
			return null;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4F40230", Offset = "0x4F3EE30", VA = "0x184F40230")]
		public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x4F40310", Offset = "0x4F3EF10", VA = "0x184F40310")]
		public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1)
		{
			return null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x4F3FCD0", Offset = "0x4F3E8D0", VA = "0x184F3FCD0")]
		public static void RequiresCanRead(Expression expression, string paramName)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4F3FCE0", Offset = "0x4F3E8E0", VA = "0x184F3FCE0")]
		public static void RequiresCanRead(Expression expression, string paramName, int idx)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x4F40020", Offset = "0x4F3EC20", VA = "0x184F40020")]
		public static bool TryQuote(Type parameterType, ref Expression argument)
		{
			return default(bool);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x4F3FC50", Offset = "0x4F3E850", VA = "0x184F3FC50")]
		internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			return null;
		}
	}
}
