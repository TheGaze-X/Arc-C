using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Roguelike.Duel
{
	// Token: 0x02002930 RID: 10544
	[Token(Token = "0x2002930")]
	public class RoguelikeDuelUIChosenPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060117BB RID: 71611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117BB")]
		[Address(RVA = "0x963910", Offset = "0x962510", VA = "0x180963910")]
		public void InitData(RoguelikeDuelUIPlugin plugin)
		{
		}

		// Token: 0x060117BC RID: 71612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117BC")]
		[Address(RVA = "0x9640E0", Offset = "0x962CE0", VA = "0x1809640E0")]
		public void UpdateData()
		{
		}

		// Token: 0x060117BD RID: 71613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117BD")]
		[Address(RVA = "0x964570", Offset = "0x963170", VA = "0x180964570")]
		private void _UpdateRefreshState()
		{
		}

		// Token: 0x060117BE RID: 71614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117BE")]
		[Address(RVA = "0x964450", Offset = "0x963050", VA = "0x180964450")]
		private void _UpdateBattleInfoText()
		{
		}

		// Token: 0x060117BF RID: 71615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117BF")]
		[Address(RVA = "0x963C10", Offset = "0x962810", VA = "0x180963C10")]
		public void OnRefreshBtnClick()
		{
		}

		// Token: 0x060117C0 RID: 71616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C0")]
		[Address(RVA = "0x963D50", Offset = "0x962950", VA = "0x180963D50")]
		public void OnStartBtnClick()
		{
		}

		// Token: 0x060117C1 RID: 71617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C1")]
		[Address(RVA = "0x964280", Offset = "0x962E80", VA = "0x180964280")]
		private void _OnConfirmPanelTrueClick()
		{
		}

		// Token: 0x060117C2 RID: 71618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C2")]
		[Address(RVA = "0x9641D0", Offset = "0x962DD0", VA = "0x1809641D0")]
		private void _OnConfirmPanelFalseClick()
		{
		}

		// Token: 0x060117C3 RID: 71619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C3")]
		[Address(RVA = "0x964360", Offset = "0x962F60", VA = "0x180964360")]
		private void _SetRefreshBtnReady()
		{
		}

		// Token: 0x060117C4 RID: 71620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C4")]
		[Address(RVA = "0x9643C0", Offset = "0x962FC0", VA = "0x1809643C0")]
		private void _SetRefreshBtnState(bool flag)
		{
		}

		// Token: 0x060117C5 RID: 71621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117C5")]
		[Address(RVA = "0x964610", Offset = "0x963210", VA = "0x180964610")]
		public RoguelikeDuelUIChosenPanel()
		{
		}

		// Token: 0x040138CE RID: 80078
		[Token(Token = "0x40138CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Refresh")]
		private GameObject _refreshEnabledComponent;

		// Token: 0x040138CF RID: 80079
		[Token(Token = "0x40138CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Refresh")]
		private GameObject _refreshDisabledComponent;

		// Token: 0x040138D0 RID: 80080
		[Token(Token = "0x40138D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("BattleInfo")]
		private GameObject _battleInfoComponent;

		// Token: 0x040138D1 RID: 80081
		[Token(Token = "0x40138D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("BattleInfo")]
		private Text _deployInfoComponent;

		// Token: 0x040138D2 RID: 80082
		[Token(Token = "0x40138D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("StartBattle")]
		private GameObject _startBattleComponent;

		// Token: 0x040138D3 RID: 80083
		[Token(Token = "0x40138D3")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_refreshEnabled;

		// Token: 0x040138D4 RID: 80084
		[Token(Token = "0x40138D4")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_refreshDisabled;

		// Token: 0x040138D5 RID: 80085
		[Token(Token = "0x40138D5")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_battleInfo;

		// Token: 0x040138D6 RID: 80086
		[Token(Token = "0x40138D6")]
		[FieldOffset(Offset = "0x58")]
		private Text m_deployInfo;

		// Token: 0x040138D7 RID: 80087
		[Token(Token = "0x40138D7")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_startBattle;

		// Token: 0x040138D8 RID: 80088
		[Token(Token = "0x40138D8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_refreshFlag;

		// Token: 0x040138D9 RID: 80089
		[Token(Token = "0x40138D9")]
		private const float m_refreshCoolDownTime = 1f;

		// Token: 0x040138DA RID: 80090
		[Token(Token = "0x40138DA")]
		[FieldOffset(Offset = "0x6C")]
		private float m_refreshTimer;

		// Token: 0x040138DB RID: 80091
		[Token(Token = "0x40138DB")]
		[FieldOffset(Offset = "0x70")]
		private GameModeFactory.RoguelikeDuelGameMode m_gameMode;

		// Token: 0x040138DC RID: 80092
		[Token(Token = "0x40138DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040138DD RID: 80093
		[Token(Token = "0x40138DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040138DE RID: 80094
		[Token(Token = "0x40138DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateRefreshState;

		// Token: 0x040138DF RID: 80095
		[Token(Token = "0x40138DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateBattleInfoText;

		// Token: 0x040138E0 RID: 80096
		[Token(Token = "0x40138E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRefreshBtnClick;

		// Token: 0x040138E1 RID: 80097
		[Token(Token = "0x40138E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStartBtnClick;

		// Token: 0x040138E2 RID: 80098
		[Token(Token = "0x40138E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnConfirmPanelTrueClick;

		// Token: 0x040138E3 RID: 80099
		[Token(Token = "0x40138E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnConfirmPanelFalseClick;

		// Token: 0x040138E4 RID: 80100
		[Token(Token = "0x40138E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetRefreshBtnReady;

		// Token: 0x040138E5 RID: 80101
		[Token(Token = "0x40138E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetRefreshBtnState;

		// Token: 0x040138E6 RID: 80102
		[Token(Token = "0x40138E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
