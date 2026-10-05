using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	internal class AndroidReflection
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x344E770", Offset = "0x344D370", VA = "0x18344E770")]
		public static bool IsPrimitive(Type t)
		{
			return default(bool);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x590B480", Offset = "0x590A080", VA = "0x18590B480")]
		public static bool IsAssignableFrom(Type t, Type from)
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x590B3F0", Offset = "0x5909FF0", VA = "0x18590B3F0")]
		private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
		{
			return 0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x590B100", Offset = "0x5909D00", VA = "0x18590B100")]
		private static IntPtr GetMethodID(string clazz, string methodName, string signature)
		{
			return 0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x590ABF0", Offset = "0x59097F0", VA = "0x18590ABF0")]
		public static IntPtr GetConstructorMember(IntPtr jclass, string signature)
		{
			return 0;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x590B190", Offset = "0x5909D90", VA = "0x18590B190")]
		public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			return 0;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x590ADF0", Offset = "0x59099F0", VA = "0x18590ADF0")]
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			return 0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x590AD80", Offset = "0x5909980", VA = "0x18590AD80")]
		public static IntPtr GetFieldClass(IntPtr field)
		{
			return 0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x590B050", Offset = "0x5909C50", VA = "0x18590B050")]
		public static string GetFieldSignature(IntPtr field)
		{
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x590B4D0", Offset = "0x590A0D0", VA = "0x18590B4D0")]
		public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze)
		{
			return 0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x590B5C0", Offset = "0x590A1C0", VA = "0x18590B5C0")]
		public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound)
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GlobalJavaObjectRef s_ReflectionHelperClass;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IntPtr s_ReflectionHelperGetConstructorID;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IntPtr s_ReflectionHelperGetMethodID;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly IntPtr s_ReflectionHelperGetFieldID;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x20")]
		private static readonly IntPtr s_ReflectionHelperGetFieldSignature;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		private static readonly IntPtr s_ReflectionHelperNewProxyInstance;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x30")]
		private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x38")]
		private static readonly IntPtr s_FieldGetDeclaringClass;
	}
}
