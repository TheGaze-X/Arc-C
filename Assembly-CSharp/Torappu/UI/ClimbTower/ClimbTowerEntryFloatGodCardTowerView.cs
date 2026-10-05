using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C3E RID: 23614
	[Token(Token = "0x2005C3E")]
	public class ClimbTowerEntryFloatGodCardTowerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602239C RID: 140188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602239C")]
		[Address(RVA = "0x1CA3DE0", Offset = "0x1CA29E0", VA = "0x181CA3DE0")]
		public void Render(ClimbTowerEntryGodCardModel.GodCardBindTowerStatus towerStatus, UIPage page)
		{
		}

		// Token: 0x0602239D RID: 140189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602239D")]
		[Address(RVA = "0x1CA3F50", Offset = "0x1CA2B50", VA = "0x181CA3F50")]
		public ClimbTowerEntryFloatGodCardTowerView()
		{
		}

		// Token: 0x0402EF54 RID: 192340
		[Token(Token = "0x402EF54")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgTowerIcon;

		// Token: 0x0402EF55 RID: 192341
		[Token(Token = "0x402EF55")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgTowerIconBg;

		// Token: 0x0402EF56 RID: 192342
		[Token(Token = "0x402EF56")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _unCompleteIconColor;

		// Token: 0x0402EF57 RID: 192343
		[Token(Token = "0x402EF57")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _completeIconColor;

		// Token: 0x0402EF58 RID: 192344
		[Token(Token = "0x402EF58")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _unCompleteBgColor;

		// Token: 0x0402EF59 RID: 192345
		[Token(Token = "0x402EF59")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _completeBgColor;

		// Token: 0x0402EF5A RID: 192346
		[Token(Token = "0x402EF5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EF5B RID: 192347
		[Token(Token = "0x402EF5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
