using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055CD RID: 21965
	[Token(Token = "0x20055CD")]
	public class RL05ExpeditionSelectingCharView : RoguelikeExpeditionSelectingCharView
	{
		// Token: 0x060203FA RID: 132090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203FA")]
		[Address(RVA = "0x1A5F3C0", Offset = "0x1A5DFC0", VA = "0x181A5F3C0", Slot = "4")]
		protected override void RenderChar(RoguelikeExpeditionModel expeditionModel, bool isAfter)
		{
		}

		// Token: 0x060203FB RID: 132091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203FB")]
		[Address(RVA = "0x1A5F5D0", Offset = "0x1A5E1D0", VA = "0x181A5F5D0")]
		public RL05ExpeditionSelectingCharView()
		{
		}

		// Token: 0x0402B9D6 RID: 178646
		[Token(Token = "0x402B9D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _upgradeObj;

		// Token: 0x0402B9D7 RID: 178647
		[Token(Token = "0x402B9D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _specialStatusPanel;

		// Token: 0x0402B9D8 RID: 178648
		[Token(Token = "0x402B9D8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0402B9D9 RID: 178649
		[Token(Token = "0x402B9D9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _candledPanel;

		// Token: 0x0402B9DA RID: 178650
		[Token(Token = "0x402B9DA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _isAfterPanel;

		// Token: 0x0402B9DB RID: 178651
		[Token(Token = "0x402B9DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402B9DC RID: 178652
		[Token(Token = "0x402B9DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
