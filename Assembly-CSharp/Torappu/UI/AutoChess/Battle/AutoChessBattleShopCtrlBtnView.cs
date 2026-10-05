using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064FF RID: 25855
	[Token(Token = "0x20064FF")]
	public class AutoChessBattleShopCtrlBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602527F RID: 152191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602527F")]
		[Address(RVA = "0x201A330", Offset = "0x2018F30", VA = "0x18201A330")]
		public void RenderView(AutoChessBattleShopViewModel model)
		{
		}

		// Token: 0x06025280 RID: 152192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025280")]
		[Address(RVA = "0x201A710", Offset = "0x2019310", VA = "0x18201A710")]
		public AutoChessBattleShopCtrlBtnView()
		{
		}

		// Token: 0x0403419D RID: 213405
		[Token(Token = "0x403419D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Refresh")]
		private TwoStateToggle _enableToggle;

		// Token: 0x0403419E RID: 213406
		[Token(Token = "0x403419E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Refresh")]
		private TwoStateToggle _freeToggle;

		// Token: 0x0403419F RID: 213407
		[Token(Token = "0x403419F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Refresh")]
		private PrefabWidget _refreshCost;

		// Token: 0x040341A0 RID: 213408
		[Token(Token = "0x40341A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Refresh")]
		private Text _freeCnt;

		// Token: 0x040341A1 RID: 213409
		[Token(Token = "0x40341A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Refresh")]
		private GameObject _specRefreshFx;

		// Token: 0x040341A2 RID: 213410
		[Token(Token = "0x40341A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Freeze")]
		private ThreeStateToggle _freezeToggle;

		// Token: 0x040341A3 RID: 213411
		[Token(Token = "0x40341A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040341A4 RID: 213412
		[Token(Token = "0x40341A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
