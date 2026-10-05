using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Dynamic.Utils
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	internal static class TypeUtils
	{
		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4F47760", Offset = "0x4F46360", VA = "0x184F47760")]
		public static Type GetNonNullableType(this Type type)
		{
			return null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x4F47860", Offset = "0x4F46460", VA = "0x184F47860")]
		public static Type GetNullableType(this Type type)
		{
			return null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4F4A190", Offset = "0x4F48D90", VA = "0x184F4A190")]
		public static bool IsNullableType(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x4F48D10", Offset = "0x4F47910", VA = "0x184F48D10")]
		public static bool IsBool(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x4F4A270", Offset = "0x4F48E70", VA = "0x184F4A270")]
		public static bool IsNumeric(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x4F49B30", Offset = "0x4F48730", VA = "0x184F49B30")]
		public static bool IsInteger(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x4F48B90", Offset = "0x4F47790", VA = "0x184F48B90")]
		public static bool IsArithmetic(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x4F4A500", Offset = "0x4F49100", VA = "0x184F4A500")]
		public static bool IsUnsignedInt(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x4F499B0", Offset = "0x4F485B0", VA = "0x184F499B0")]
		public static bool IsIntegerOrBool(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x4F4A690", Offset = "0x4F49290", VA = "0x184F4A690")]
		public static bool IsValidInstanceType(MemberInfo member, Type instanceType)
		{
			return default(bool);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x4F48350", Offset = "0x4F46F50", VA = "0x184F48350")]
		public static bool HasIdentityPrimitiveOrNullableConversionTo(this Type source, Type dest)
		{
			return default(bool);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x4F48870", Offset = "0x4F47470", VA = "0x184F48870")]
		public static bool HasReferenceConversionTo(this Type source, Type dest)
		{
			return default(bool);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x4F4AA40", Offset = "0x4F49640", VA = "0x184F4AA40")]
		private static bool StrictHasReferenceConversionTo(this Type source, Type dest, bool skipNonArray)
		{
			return default(bool);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x4F47D50", Offset = "0x4F46950", VA = "0x184F47D50")]
		private static bool HasArrayToInterfaceConversion(Type source, Type dest)
		{
			return default(bool);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x4F48610", Offset = "0x4F47210", VA = "0x184F48610")]
		private static bool HasInterfaceToArrayConversion(Type source, Type dest)
		{
			return default(bool);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x4F49000", Offset = "0x4F47C00", VA = "0x184F49000")]
		private static bool IsCovariant(Type t)
		{
			return default(bool);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x4F48E30", Offset = "0x4F47A30", VA = "0x184F48E30")]
		private static bool IsContravariant(Type t)
		{
			return default(bool);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x4F49CB0", Offset = "0x4F488B0", VA = "0x184F49CB0")]
		private static bool IsInvariant(Type t)
		{
			return default(bool);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x4F49050", Offset = "0x4F47C50", VA = "0x184F49050")]
		private static bool IsDelegate(Type t)
		{
			return default(bool);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4F49D00", Offset = "0x4F48900", VA = "0x184F49D00")]
		public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest)
		{
			return default(bool);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x4F48E80", Offset = "0x4F47A80", VA = "0x184F48E80")]
		public static bool IsConvertible(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x4F48AA0", Offset = "0x4F476A0", VA = "0x184F48AA0")]
		public static bool HasReferenceEquality(Type left, Type right)
		{
			return default(bool);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4F47FB0", Offset = "0x4F46BB0", VA = "0x184F47FB0")]
		public static bool HasBuiltInEqualityOperator(Type left, Type right)
		{
			return default(bool);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x4F494E0", Offset = "0x4F480E0", VA = "0x184F494E0")]
		public static bool IsImplicitlyConvertibleTo(this Type source, Type destination)
		{
			return default(bool);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x4F479D0", Offset = "0x4F465D0", VA = "0x184F479D0")]
		public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType)
		{
			return null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4F46F10", Offset = "0x4F45B10", VA = "0x184F46F10")]
		private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo)
		{
			return null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4F49310", Offset = "0x4F47F10", VA = "0x184F49310")]
		private static bool IsImplicitNumericConversion(Type source, Type destination)
		{
			return default(bool);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x4E32500", Offset = "0x4E31100", VA = "0x184E32500")]
		private static bool IsImplicitReferenceConversion(Type source, Type destination)
		{
			return default(bool);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x4F490F0", Offset = "0x4F47CF0", VA = "0x184F490F0")]
		private static bool IsImplicitBoxingConversion(Type source, Type destination)
		{
			return default(bool);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x4F49270", Offset = "0x4F47E70", VA = "0x184F49270")]
		private static bool IsImplicitNullableConversion(Type source, Type destination)
		{
			return default(bool);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x4F470E0", Offset = "0x4F45CE0", VA = "0x184F470E0")]
		public static Type FindGenericType(Type definition, Type type)
		{
			return null;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x4F473E0", Offset = "0x4F45FE0", VA = "0x184F473E0")]
		public static MethodInfo GetBooleanOperator(Type type, string name)
		{
			return null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x4F47800", Offset = "0x4F46400", VA = "0x184F47800")]
		public static Type GetNonRefType(this Type type)
		{
			return null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x4F46D50", Offset = "0x4F45950", VA = "0x184F46D50")]
		public static bool AreEquivalent(Type t1, Type t2)
		{
			return default(bool);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x4F46DF0", Offset = "0x4F459F0", VA = "0x184F46DF0")]
		public static bool AreReferenceAssignable(Type dest, Type src)
		{
			return default(bool);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x4F4A3F0", Offset = "0x4F48FF0", VA = "0x184F4A3F0")]
		public static bool IsSameOrSubclass(Type type, Type subType)
		{
			return default(bool);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x4F4AFF0", Offset = "0x4F49BF0", VA = "0x184F4AFF0")]
		public static void ValidateType(Type type, string paramName)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x4F4AE20", Offset = "0x4F49A20", VA = "0x184F4AE20")]
		public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x4F4B060", Offset = "0x4F49C60", VA = "0x184F4B060")]
		public static bool ValidateType(Type type, string paramName, int index)
		{
			return default(bool);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x4F47710", Offset = "0x4F46310", VA = "0x184F47710")]
		public static MethodInfo GetInvokeMethod(this Type delegateType)
		{
			return null;
		}

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] s_arrayAssignableInterfaces;
	}
}
