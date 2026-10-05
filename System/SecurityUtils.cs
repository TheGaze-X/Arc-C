using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	internal static class SecurityUtils
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void DemandReflectionAccess(Type type)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void DemandGrantSet(Assembly assembly)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x50DE6C0", Offset = "0x50DD2C0", VA = "0x1850DE6C0")]
		private static bool HasReflectionPermission(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x50DEB50", Offset = "0x50DD750", VA = "0x1850DEB50")]
		internal static object SecureCreateInstance(Type type)
		{
			return null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x50DEB60", Offset = "0x50DD760", VA = "0x1850DEB60")]
		internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic)
		{
			return null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x50DEC80", Offset = "0x50DD880", VA = "0x1850DEC80")]
		internal static object SecureCreateInstance(Type type, object[] args)
		{
			return null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x50DE850", Offset = "0x50DD450", VA = "0x1850DE850")]
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic)
		{
			return null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x50DE9D0", Offset = "0x50DD5D0", VA = "0x1850DE9D0")]
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags)
		{
			return null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x50DE5F0", Offset = "0x50DD1F0", VA = "0x1850DE5F0")]
		private static bool GenericArgumentsAreVisible(MethodInfo method)
		{
			return default(bool);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x50DE6E0", Offset = "0x50DD2E0", VA = "0x1850DE6E0")]
		internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args)
		{
			return null;
		}
	}
}
