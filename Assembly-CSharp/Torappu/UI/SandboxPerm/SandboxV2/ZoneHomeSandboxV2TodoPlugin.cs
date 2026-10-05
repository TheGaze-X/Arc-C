using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004455 RID: 17493
	[Token(Token = "0x2004455")]
	public class ZoneHomeSandboxV2TodoPlugin : ZoneHomeSandboxPermTodoPluginBase, IHotfixable
	{
		// Token: 0x0601ABB7 RID: 109495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABB7")]
		[Address(RVA = "0x13EBF10", Offset = "0x13EAB10", VA = "0x1813EBF10", Slot = "4")]
		public override void Render(ZoneHomeSandboxPermToDoPluginBaseModel baseModel)
		{
		}

		// Token: 0x0601ABB8 RID: 109496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABB8")]
		[Address(RVA = "0x13EC050", Offset = "0x13EAC50", VA = "0x1813EC050")]
		public ZoneHomeSandboxV2TodoPlugin()
		{
		}

		// Token: 0x04022258 RID: 139864
		[Token(Token = "0x4022258")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04022259 RID: 139865
		[Token(Token = "0x4022259")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelChallenge;

		// Token: 0x0402225A RID: 139866
		[Token(Token = "0x402225A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402225B RID: 139867
		[Token(Token = "0x402225B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
