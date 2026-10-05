using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200619D RID: 24989
	[Token(Token = "0x200619D")]
	public class BossRushSquadHomePluginView : SquadHomePluginView
	{
		// Token: 0x060240B5 RID: 147637 RVA: 0x000C2DC0 File Offset: 0x000C0FC0
		[Token(Token = "0x60240B5")]
		[Address(RVA = "0x1EB6CB0", Offset = "0x1EB58B0", VA = "0x181EB6CB0", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x060240B6 RID: 147638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240B6")]
		[Address(RVA = "0x1EB6D10", Offset = "0x1EB5910", VA = "0x181EB6D10", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x060240B7 RID: 147639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240B7")]
		[Address(RVA = "0x1EB71A0", Offset = "0x1EB5DA0", VA = "0x181EB71A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060240B8 RID: 147640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240B8")]
		[Address(RVA = "0x1EB75C0", Offset = "0x1EB61C0", VA = "0x181EB75C0")]
		private void _UpdateTeamBuffPart()
		{
		}

		// Token: 0x060240B9 RID: 147641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240B9")]
		[Address(RVA = "0x1EB7480", Offset = "0x1EB6080", VA = "0x181EB7480")]
		private void _TryCloseTeamBuffDes()
		{
		}

		// Token: 0x060240BA RID: 147642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240BA")]
		[Address(RVA = "0x1EB7360", Offset = "0x1EB5F60", VA = "0x181EB7360")]
		private void _ShowTeamBuffDetailTips(bool show)
		{
		}

		// Token: 0x060240BB RID: 147643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240BB")]
		[Address(RVA = "0x1EB72B0", Offset = "0x1EB5EB0", VA = "0x181EB72B0")]
		private void _SetTeamBuffTipsVisible(bool visible)
		{
		}

		// Token: 0x060240BC RID: 147644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240BC")]
		[Address(RVA = "0x1EB74F0", Offset = "0x1EB60F0", VA = "0x181EB74F0")]
		private void _TryTriggerAVG()
		{
		}

		// Token: 0x060240BD RID: 147645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240BD")]
		[Address(RVA = "0x1EB6980", Offset = "0x1EB5580", VA = "0x181EB6980")]
		public void EventOnRelicBtnClick()
		{
		}

		// Token: 0x060240BE RID: 147646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240BE")]
		[Address(RVA = "0x1EB6A90", Offset = "0x1EB5690", VA = "0x181EB6A90")]
		public void EventOnTeamBuffBtnClick()
		{
		}

		// Token: 0x060240BF RID: 147647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240BF")]
		[Address(RVA = "0x1EB6AF0", Offset = "0x1EB56F0", VA = "0x181EB6AF0")]
		public void EventOnTeamBuffDetailBlockClick()
		{
		}

		// Token: 0x060240C0 RID: 147648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240C0")]
		[Address(RVA = "0x1EB6B50", Offset = "0x1EB5750", VA = "0x181EB6B50", Slot = "9")]
		protected override void OnSquadGroupChanged(SquadGroupViewModel groupModel)
		{
		}

		// Token: 0x060240C1 RID: 147649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240C1")]
		[Address(RVA = "0x1EB77A0", Offset = "0x1EB63A0", VA = "0x181EB77A0")]
		public BossRushSquadHomePluginView()
		{
		}

		// Token: 0x060240C2 RID: 147650 RVA: 0x000C2DD8 File Offset: 0x000C0FD8
		[Token(Token = "0x60240C2")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x060240C3 RID: 147651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240C3")]
		[Address(RVA = "0x1EB7190", Offset = "0x1EB5D90", VA = "0x181EB7190")]
		private void <>xLuaBaseProxy_OnSquadGroupChanged(SquadGroupViewModel P0)
		{
		}

		// Token: 0x0403216F RID: 205167
		[Token(Token = "0x403216F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgRelicIcon;

		// Token: 0x04032170 RID: 205168
		[Token(Token = "0x4032170")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objRelicEmpty;

		// Token: 0x04032171 RID: 205169
		[Token(Token = "0x4032171")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objRelicHas;

		// Token: 0x04032172 RID: 205170
		[Token(Token = "0x4032172")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objTeamBuff;

		// Token: 0x04032173 RID: 205171
		[Token(Token = "0x4032173")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgTeamBuffIcon;

		// Token: 0x04032174 RID: 205172
		[Token(Token = "0x4032174")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIFadeFloatPanel _fadeTeamBuffDetailTipsPanel;

		// Token: 0x04032175 RID: 205173
		[Token(Token = "0x4032175")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtTeamBuffName;

		// Token: 0x04032176 RID: 205174
		[Token(Token = "0x4032176")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtTeamBuffDec;

		// Token: 0x04032177 RID: 205175
		[Token(Token = "0x4032177")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _transTeamBuffDetailBlock;

		// Token: 0x04032178 RID: 205176
		[Token(Token = "0x4032178")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objTeamBuffBan;

		// Token: 0x04032179 RID: 205177
		[Token(Token = "0x4032179")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403217A RID: 205178
		[Token(Token = "0x403217A")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isTipsBlockShowing;

		// Token: 0x0403217B RID: 205179
		[Token(Token = "0x403217B")]
		[FieldOffset(Offset = "0x88")]
		private string m_groupId;

		// Token: 0x0403217C RID: 205180
		[Token(Token = "0x403217C")]
		[FieldOffset(Offset = "0x90")]
		private string m_stageId;

		// Token: 0x0403217D RID: 205181
		[Token(Token = "0x403217D")]
		[FieldOffset(Offset = "0x98")]
		private ActivityBossRushData.BossRushStageType m_stageType;

		// Token: 0x0403217E RID: 205182
		[Token(Token = "0x403217E")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_curSquadHasTeamBuff;

		// Token: 0x0403217F RID: 205183
		[Token(Token = "0x403217F")]
		[FieldOffset(Offset = "0xA0")]
		private string m_teamId;

		// Token: 0x04032180 RID: 205184
		[Token(Token = "0x4032180")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<string, ActivityBossRushData.BossRushTeamData> m_cachedTeamDataMap;

		// Token: 0x04032181 RID: 205185
		[Token(Token = "0x4032181")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x04032182 RID: 205186
		[Token(Token = "0x4032182")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04032183 RID: 205187
		[Token(Token = "0x4032183")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032184 RID: 205188
		[Token(Token = "0x4032184")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTeamBuffPart;

		// Token: 0x04032185 RID: 205189
		[Token(Token = "0x4032185")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryCloseTeamBuffDes;

		// Token: 0x04032186 RID: 205190
		[Token(Token = "0x4032186")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowTeamBuffDetailTips;

		// Token: 0x04032187 RID: 205191
		[Token(Token = "0x4032187")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetTeamBuffTipsVisible;

		// Token: 0x04032188 RID: 205192
		[Token(Token = "0x4032188")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryTriggerAVG;

		// Token: 0x04032189 RID: 205193
		[Token(Token = "0x4032189")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRelicBtnClick;

		// Token: 0x0403218A RID: 205194
		[Token(Token = "0x403218A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnTeamBuffBtnClick;

		// Token: 0x0403218B RID: 205195
		[Token(Token = "0x403218B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnTeamBuffDetailBlockClick;

		// Token: 0x0403218C RID: 205196
		[Token(Token = "0x403218C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnSquadGroupChanged;

		// Token: 0x0403218D RID: 205197
		[Token(Token = "0x403218D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
