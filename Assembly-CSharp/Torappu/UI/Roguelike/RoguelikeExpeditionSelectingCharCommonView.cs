using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052DA RID: 21210
	[Token(Token = "0x20052DA")]
	public class RoguelikeExpeditionSelectingCharCommonView : RoguelikeExpeditionSelectingCharView, IHotfixable
	{
		// Token: 0x0601F489 RID: 128137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F489")]
		[Address(RVA = "0x18FDF50", Offset = "0x18FCB50", VA = "0x1818FDF50", Slot = "4")]
		protected override void RenderChar(RoguelikeExpeditionModel expeditionModel, bool isAfter)
		{
		}

		// Token: 0x0601F48A RID: 128138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F48A")]
		[Address(RVA = "0x18FE080", Offset = "0x18FCC80", VA = "0x1818FE080")]
		public RoguelikeExpeditionSelectingCharCommonView()
		{
		}

		// Token: 0x0402A03F RID: 172095
		[Token(Token = "0x402A03F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _upgradeObj;

		// Token: 0x0402A040 RID: 172096
		[Token(Token = "0x402A040")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _portraitGrayMask;

		// Token: 0x0402A041 RID: 172097
		[Token(Token = "0x402A041")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402A042 RID: 172098
		[Token(Token = "0x402A042")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
