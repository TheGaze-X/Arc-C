using System;
using System.Diagnostics.CodeAnalysis;
using Il2CppDummyDll;

namespace System.Dynamic.Utils
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	internal static class ContractUtils
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		[ExcludeFromCodeCoverage]
		public static Exception Unreachable
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x4F3DDC0", Offset = "0x4F3C9C0", VA = "0x184F3DDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4F3DD60", Offset = "0x4F3C960", VA = "0x184F3DD60")]
		public static void RequiresNotNull(object value, string paramName)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4F3DCE0", Offset = "0x4F3C8E0", VA = "0x184F3DCE0")]
		public static void RequiresNotNull(object value, string paramName, int index)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x4F3DC60", Offset = "0x4F3C860", VA = "0x184F3DC60")]
		private static string GetParamName(string paramName, int index)
		{
			return null;
		}
	}
}
