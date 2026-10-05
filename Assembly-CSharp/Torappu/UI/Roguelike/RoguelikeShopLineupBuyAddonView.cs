using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005507 RID: 21767
	[Token(Token = "0x2005507")]
	public class RoguelikeShopLineupBuyAddonView : RoguelikeShopLineupAddonView
	{
		// Token: 0x0602003F RID: 131135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602003F")]
		[Address(RVA = "0x1A238A0", Offset = "0x1A224A0", VA = "0x181A238A0", Slot = "4")]
		protected override void OnDataChange(RoguelikeGameShopViewModel model)
		{
		}

		// Token: 0x06020040 RID: 131136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020040")]
		[Address(RVA = "0x1A23B10", Offset = "0x1A22710", VA = "0x181A23B10")]
		private void RenderNormalPanel(RoguelikeGameShopViewModel model)
		{
		}

		// Token: 0x06020041 RID: 131137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020041")]
		[Address(RVA = "0x1A23BB0", Offset = "0x1A227B0", VA = "0x181A23BB0")]
		private void _RenderCostInfoPanel(RoguelikeGameShopViewModel model)
		{
		}

		// Token: 0x06020042 RID: 131138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020042")]
		[Address(RVA = "0x1A239C0", Offset = "0x1A225C0", VA = "0x181A239C0")]
		public void OnRefreshClick()
		{
		}

		// Token: 0x06020043 RID: 131139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020043")]
		[Address(RVA = "0x1A23E80", Offset = "0x1A22A80", VA = "0x181A23E80")]
		public RoguelikeShopLineupBuyAddonView()
		{
		}

		// Token: 0x0402B384 RID: 177028
		[Token(Token = "0x402B384")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _rootPanel;

		// Token: 0x0402B385 RID: 177029
		[Token(Token = "0x402B385")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _refreshValidPanel;

		// Token: 0x0402B386 RID: 177030
		[Token(Token = "0x402B386")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _refreshInvalidPanel;

		// Token: 0x0402B387 RID: 177031
		[Token(Token = "0x402B387")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Cost")]
		private GameObject _costInfoPanel;

		// Token: 0x0402B388 RID: 177032
		[Token(Token = "0x402B388")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Cost")]
		private Image _costIconImage;

		// Token: 0x0402B389 RID: 177033
		[Token(Token = "0x402B389")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Cost")]
		private Color _invalidIconColor;

		// Token: 0x0402B38A RID: 177034
		[Token(Token = "0x402B38A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Cost")]
		private Text _costCountText;

		// Token: 0x0402B38B RID: 177035
		[Token(Token = "0x402B38B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Cost")]
		private GameObject _costValidPanel;

		// Token: 0x0402B38C RID: 177036
		[Token(Token = "0x402B38C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Cost")]
		private GameObject _costInvalidPanel;

		// Token: 0x0402B38D RID: 177037
		[Token(Token = "0x402B38D")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B38E RID: 177038
		[Token(Token = "0x402B38E")]
		[FieldOffset(Offset = "0xB0")]
		private string m_loadedCostId;

		// Token: 0x0402B38F RID: 177039
		[Token(Token = "0x402B38F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataChange;

		// Token: 0x0402B390 RID: 177040
		[Token(Token = "0x402B390")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderNormalPanel;

		// Token: 0x0402B391 RID: 177041
		[Token(Token = "0x402B391")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCostInfoPanel;

		// Token: 0x0402B392 RID: 177042
		[Token(Token = "0x402B392")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRefreshClick;

		// Token: 0x0402B393 RID: 177043
		[Token(Token = "0x402B393")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
