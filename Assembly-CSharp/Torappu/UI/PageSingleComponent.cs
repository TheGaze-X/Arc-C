using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003607 RID: 13831
	[Token(Token = "0x2003607")]
	public abstract class PageSingleComponent : PageComponent
	{
		// Token: 0x06016080 RID: 90240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016080")]
		public static string GenerateKey<T>()
		{
			return null;
		}

		// Token: 0x06016081 RID: 90241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016081")]
		[Address(RVA = "0xE7CCF0", Offset = "0xE7B8F0", VA = "0x180E7CCF0")]
		public static string GenerateKey(Type type)
		{
			return null;
		}

		// Token: 0x06016082 RID: 90242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016082")]
		[Address(RVA = "0xE7CDB0", Offset = "0xE7B9B0", VA = "0x180E7CDB0")]
		public string GenerateKey()
		{
			return null;
		}

		// Token: 0x06016083 RID: 90243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016083")]
		[Address(RVA = "0xE7CEC0", Offset = "0xE7BAC0", VA = "0x180E7CEC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06016084 RID: 90244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016084")]
		[Address(RVA = "0xE7D0D0", Offset = "0xE7BCD0", VA = "0x180E7D0D0")]
		protected PageSingleComponent()
		{
		}

		// Token: 0x06016085 RID: 90245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016085")]
		[Address(RVA = "0xE7C660", Offset = "0xE7B260", VA = "0x180E7C660")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0401A787 RID: 108423
		[Token(Token = "0x401A787")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateKey;

		// Token: 0x0401A788 RID: 108424
		[Token(Token = "0x401A788")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_GenerateKey;

		// Token: 0x0401A789 RID: 108425
		[Token(Token = "0x401A789")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix2_GenerateKey;

		// Token: 0x0401A78A RID: 108426
		[Token(Token = "0x401A78A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401A78B RID: 108427
		[Token(Token = "0x401A78B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
