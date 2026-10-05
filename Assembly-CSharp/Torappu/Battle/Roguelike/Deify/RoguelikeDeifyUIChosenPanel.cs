using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Roguelike.Deify
{
	// Token: 0x02002936 RID: 10550
	[Token(Token = "0x2002936")]
	public class RoguelikeDeifyUIChosenPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011817 RID: 71703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011817")]
		[Address(RVA = "0x95F510", Offset = "0x95E110", VA = "0x18095F510")]
		public void InitData(RoguelikeDeifyUIPlugin plugin)
		{
		}

		// Token: 0x06011818 RID: 71704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011818")]
		[Address(RVA = "0x95FB80", Offset = "0x95E780", VA = "0x18095FB80")]
		public void UpdateData()
		{
		}

		// Token: 0x06011819 RID: 71705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011819")]
		[Address(RVA = "0x95FE00", Offset = "0x95EA00", VA = "0x18095FE00")]
		private void _UpdateBattleInfoText()
		{
		}

		// Token: 0x0601181A RID: 71706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601181A")]
		[Address(RVA = "0x95F780", Offset = "0x95E380", VA = "0x18095F780")]
		public void OnStartBtnClick()
		{
		}

		// Token: 0x0601181B RID: 71707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601181B")]
		[Address(RVA = "0x95FC90", Offset = "0x95E890", VA = "0x18095FC90")]
		private void _OnConfirmPanelTrueClick()
		{
		}

		// Token: 0x0601181C RID: 71708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601181C")]
		[Address(RVA = "0x95FBE0", Offset = "0x95E7E0", VA = "0x18095FBE0")]
		private void _OnConfirmPanelFalseClick()
		{
		}

		// Token: 0x0601181D RID: 71709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601181D")]
		[Address(RVA = "0x95FF20", Offset = "0x95EB20", VA = "0x18095FF20")]
		public RoguelikeDeifyUIChosenPanel()
		{
		}

		// Token: 0x04013936 RID: 80182
		[Token(Token = "0x4013936")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("BattleInfo")]
		private GameObject _battleInfoComponent;

		// Token: 0x04013937 RID: 80183
		[Token(Token = "0x4013937")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("BattleInfo")]
		private Text _deployInfoComponent;

		// Token: 0x04013938 RID: 80184
		[Token(Token = "0x4013938")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("StartBattle")]
		private GameObject _startBattleComponent;

		// Token: 0x04013939 RID: 80185
		[Token(Token = "0x4013939")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_battleInfo;

		// Token: 0x0401393A RID: 80186
		[Token(Token = "0x401393A")]
		[FieldOffset(Offset = "0x38")]
		private Text m_deployInfo;

		// Token: 0x0401393B RID: 80187
		[Token(Token = "0x401393B")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_startBattle;

		// Token: 0x0401393C RID: 80188
		[Token(Token = "0x401393C")]
		[FieldOffset(Offset = "0x48")]
		private GameModeFactory.RoguelikeDeifyGameMode m_gameMode;

		// Token: 0x0401393D RID: 80189
		[Token(Token = "0x401393D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401393E RID: 80190
		[Token(Token = "0x401393E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401393F RID: 80191
		[Token(Token = "0x401393F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateBattleInfoText;

		// Token: 0x04013940 RID: 80192
		[Token(Token = "0x4013940")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStartBtnClick;

		// Token: 0x04013941 RID: 80193
		[Token(Token = "0x4013941")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnConfirmPanelTrueClick;

		// Token: 0x04013942 RID: 80194
		[Token(Token = "0x4013942")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnConfirmPanelFalseClick;

		// Token: 0x04013943 RID: 80195
		[Token(Token = "0x4013943")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
