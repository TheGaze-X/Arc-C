using System;
using Il2CppDummyDll;

namespace Torappu.Config
{
	// Token: 0x020016C7 RID: 5831
	[Token(Token = "0x20016C7")]
	public struct FortressConfig
	{
		// Token: 0x060093DC RID: 37852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093DC")]
		[Address(RVA = "0x2B398A0", Offset = "0x2B384A0", VA = "0x182B398A0")]
		public string GetDiffInfo(FortressConfig originConfig)
		{
			return null;
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x00039B28 File Offset: 0x00037D28
		[Token(Token = "0x60093DD")]
		[Address(RVA = "0x2B397C0", Offset = "0x2B383C0", VA = "0x182B397C0")]
		public static FortressConfig GenerateDefault()
		{
			return default(FortressConfig);
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x00039B40 File Offset: 0x00037D40
		[Token(Token = "0x60093DE")]
		[Address(RVA = "0x2B39980", Offset = "0x2B38580", VA = "0x182B39980")]
		public static FortressConfig LoadFromStorage()
		{
			return default(FortressConfig);
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093DF")]
		[Address(RVA = "0x2B39670", Offset = "0x2B38270", VA = "0x182B39670")]
		public static void ClearStorage()
		{
		}

		// Token: 0x040089AB RID: 35243
		[Token(Token = "0x40089AB")]
		private const string STORAGE_KEY = "torappu_fortress_config";

		// Token: 0x040089AC RID: 35244
		[Token(Token = "0x40089AC")]
		[FieldOffset(Offset = "0x0")]
		public string serverType;

		// Token: 0x040089AD RID: 35245
		[Token(Token = "0x40089AD")]
		[FieldOffset(Offset = "0x8")]
		public string gsUrl;
	}
}
