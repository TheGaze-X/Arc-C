using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004456 RID: 17494
	[Token(Token = "0x2004456")]
	public class ZoneHomeSandboxV2TodoPluginViewModel : ZoneHomeSandboxPermToDoPluginBaseModel, IHotfixable
	{
		// Token: 0x0601ABB9 RID: 109497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ABB9")]
		[Address(RVA = "0x13EBCE0", Offset = "0x13EA8E0", VA = "0x1813EBCE0")]
		public static ZoneHomeSandboxV2TodoPluginViewModel CreateModel(SandboxPermBasicData basicData)
		{
			return null;
		}

		// Token: 0x0601ABBA RID: 109498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABBA")]
		[Address(RVA = "0x13EBEB0", Offset = "0x13EAAB0", VA = "0x1813EBEB0")]
		public ZoneHomeSandboxV2TodoPluginViewModel()
		{
		}

		// Token: 0x0402225C RID: 139868
		[Token(Token = "0x402225C")]
		[FieldOffset(Offset = "0x38")]
		public bool isChallenge;

		// Token: 0x0402225D RID: 139869
		[Token(Token = "0x402225D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateModel;

		// Token: 0x0402225E RID: 139870
		[Token(Token = "0x402225E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
