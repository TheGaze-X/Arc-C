using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public static class MethodInfoExtensions
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4E27B80", Offset = "0x4E26780", VA = "0x184E27B80")]
		public static string GetFullName(this MethodBase method, string extensionMethodPrefix)
		{
			return null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4E27E40", Offset = "0x4E26A40", VA = "0x184E27E40")]
		public static string GetParamsNames(this MethodBase method)
		{
			return null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4E27E00", Offset = "0x4E26A00", VA = "0x184E27E00")]
		public static string GetFullName(this MethodBase method)
		{
			return null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4E28100", Offset = "0x4E26D00", VA = "0x184E28100")]
		public static bool IsExtensionMethod(this MethodBase method)
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4E280B0", Offset = "0x4E26CB0", VA = "0x184E280B0")]
		public static bool IsAliasMethod(this MethodInfo methodInfo)
		{
			return default(bool);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4E27A50", Offset = "0x4E26650", VA = "0x184E27A50")]
		public static MethodInfo DeAliasMethod(this MethodInfo methodInfo, bool throwOnNotAliased = false)
		{
			return null;
		}
	}
}
