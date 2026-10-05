using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035CF RID: 13775
	[Token(Token = "0x20035CF")]
	public class DefaultCommonSquadLayoutView : CommonSquadLayoutViewBase
	{
		// Token: 0x06015E9F RID: 89759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E9F")]
		[Address(RVA = "0xE67E60", Offset = "0xE66A60", VA = "0x180E67E60")]
		private void _RefreshStartBtnBg(CommonSquadGroupViewModel commonSquadGroupViewModel)
		{
		}

		// Token: 0x06015EA0 RID: 89760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA0")]
		[Address(RVA = "0xE67CA0", Offset = "0xE668A0", VA = "0x180E67CA0", Slot = "10")]
		protected override void OnStateValueChanged(CommonSquadGroupViewModel commonSquadGroupViewModel)
		{
		}

		// Token: 0x06015EA1 RID: 89761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA1")]
		[Address(RVA = "0xE67BF0", Offset = "0xE667F0", VA = "0x180E67BF0")]
		public void EventOnStartBtnClick()
		{
		}

		// Token: 0x06015EA2 RID: 89762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA2")]
		[Address(RVA = "0xE67930", Offset = "0xE66530", VA = "0x180E67930")]
		public void EventOnAssistBtnClick()
		{
		}

		// Token: 0x06015EA3 RID: 89763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA3")]
		[Address(RVA = "0xE679E0", Offset = "0xE665E0", VA = "0x180E679E0")]
		public void EventOnAssistClearBtnClick()
		{
		}

		// Token: 0x06015EA4 RID: 89764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA4")]
		[Address(RVA = "0xE67A90", Offset = "0xE66690", VA = "0x180E67A90")]
		public void EventOnMultiFormationClicked()
		{
		}

		// Token: 0x06015EA5 RID: 89765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA5")]
		[Address(RVA = "0xE67FA0", Offset = "0xE66BA0", VA = "0x180E67FA0")]
		public DefaultCommonSquadLayoutView()
		{
		}

		// Token: 0x06015EA6 RID: 89766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA6")]
		[Address(RVA = "0xE67E50", Offset = "0xE66A50", VA = "0x180E67E50")]
		private void <>xLuaBaseProxy_OnStateValueChanged(CommonSquadGroupViewModel P0)
		{
		}

		// Token: 0x0401A5A1 RID: 107937
		[Token(Token = "0x401A5A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _startBattleImg;

		// Token: 0x0401A5A2 RID: 107938
		[Token(Token = "0x401A5A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CommonSquadAssistView _assistView;

		// Token: 0x0401A5A3 RID: 107939
		[Token(Token = "0x401A5A3")]
		[FieldOffset(Offset = "0x60")]
		private SquadStartButtonTypeEnum m_startBtnType;

		// Token: 0x0401A5A4 RID: 107940
		[Token(Token = "0x401A5A4")]
		[FieldOffset(Offset = "0x64")]
		private bool m_isStartBtnRefreshed;

		// Token: 0x0401A5A5 RID: 107941
		[Token(Token = "0x401A5A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RefreshStartBtnBg;

		// Token: 0x0401A5A6 RID: 107942
		[Token(Token = "0x401A5A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateValueChanged;

		// Token: 0x0401A5A7 RID: 107943
		[Token(Token = "0x401A5A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnStartBtnClick;

		// Token: 0x0401A5A8 RID: 107944
		[Token(Token = "0x401A5A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnAssistBtnClick;

		// Token: 0x0401A5A9 RID: 107945
		[Token(Token = "0x401A5A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnAssistClearBtnClick;

		// Token: 0x0401A5AA RID: 107946
		[Token(Token = "0x401A5AA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormationClicked;

		// Token: 0x0401A5AB RID: 107947
		[Token(Token = "0x401A5AB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
