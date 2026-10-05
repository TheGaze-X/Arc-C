using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003801 RID: 14337
	[Token(Token = "0x2003801")]
	public class UIGlobalRaycastBlocker : SingletonMonoBehaviour<UIGlobalRaycastBlocker>, ISingletonNotAutoCreate
	{
		// Token: 0x06016B61 RID: 93025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B61")]
		[Address(RVA = "0xF15CF0", Offset = "0xF148F0", VA = "0x180F15CF0")]
		public static void Show()
		{
		}

		// Token: 0x06016B62 RID: 93026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B62")]
		[Address(RVA = "0xF15C20", Offset = "0xF14820", VA = "0x180F15C20")]
		public static void Hide()
		{
		}

		// Token: 0x06016B63 RID: 93027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B63")]
		[Address(RVA = "0xF15DC0", Offset = "0xF149C0", VA = "0x180F15DC0")]
		public UIGlobalRaycastBlocker()
		{
		}

		// Token: 0x0401B5E2 RID: 112098
		[Token(Token = "0x401B5E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401B5E3 RID: 112099
		[Token(Token = "0x401B5E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401B5E4 RID: 112100
		[Token(Token = "0x401B5E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
