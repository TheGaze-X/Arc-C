using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C44 RID: 23620
	[Token(Token = "0x2005C44")]
	public class ClimbTowerEntryFloatProgressItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060223BB RID: 140219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223BB")]
		[Address(RVA = "0x1CA4CB0", Offset = "0x1CA38B0", VA = "0x181CA4CB0")]
		public void Render(bool isComplete)
		{
		}

		// Token: 0x060223BC RID: 140220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223BC")]
		[Address(RVA = "0x1CA4D80", Offset = "0x1CA3980", VA = "0x181CA4D80")]
		public ClimbTowerEntryFloatProgressItemView()
		{
		}

		// Token: 0x0402EF8E RID: 192398
		[Token(Token = "0x402EF8E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MaskableGraphic _imgItem;

		// Token: 0x0402EF8F RID: 192399
		[Token(Token = "0x402EF8F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _uncompleteColor;

		// Token: 0x0402EF90 RID: 192400
		[Token(Token = "0x402EF90")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _completeColor;

		// Token: 0x0402EF91 RID: 192401
		[Token(Token = "0x402EF91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EF92 RID: 192402
		[Token(Token = "0x402EF92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
