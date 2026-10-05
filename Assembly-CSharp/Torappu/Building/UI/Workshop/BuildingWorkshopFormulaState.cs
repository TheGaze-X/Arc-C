using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BDA RID: 7130
	[Token(Token = "0x2001BDA")]
	public class BuildingWorkshopFormulaState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0600B1D2 RID: 45522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1D2")]
		[Address(RVA = "0x32BD1B0", Offset = "0x32BBDB0", VA = "0x1832BD1B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D3")]
		[Address(RVA = "0x32BDC50", Offset = "0x32BC850", VA = "0x1832BDC50")]
		private void Start()
		{
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D4")]
		[Address(RVA = "0x32BDDF0", Offset = "0x32BC9F0", VA = "0x1832BDDF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D5")]
		[Address(RVA = "0x32BD210", Offset = "0x32BBE10", VA = "0x1832BD210", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D6")]
		[Address(RVA = "0x32BD8C0", Offset = "0x32BC4C0", VA = "0x1832BD8C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B1D7 RID: 45527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D7")]
		[Address(RVA = "0x32BE010", Offset = "0x32BCC10", VA = "0x1832BE010")]
		private void _OnFormulaClicked(IWorkshopFormula formula)
		{
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D8")]
		[Address(RVA = "0x32BD3F0", Offset = "0x32BBFF0", VA = "0x1832BD3F0")]
		public void OnFilterBuildingButtonPressed()
		{
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D9")]
		[Address(RVA = "0x32BD4B0", Offset = "0x32BC0B0", VA = "0x1832BD4B0")]
		public void OnFilterEliteButtonPressed()
		{
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1DA")]
		[Address(RVA = "0x32BD630", Offset = "0x32BC230", VA = "0x1832BD630")]
		public void OnFilterSkillButtonPressed()
		{
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1DB")]
		[Address(RVA = "0x32BD330", Offset = "0x32BBF30", VA = "0x1832BD330")]
		public void OnFilterAscButtonPressed()
		{
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1DC")]
		[Address(RVA = "0x32BD570", Offset = "0x32BC170", VA = "0x1832BD570")]
		public void OnFilterFurnitureButtonPressed()
		{
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1DD")]
		[Address(RVA = "0x32BD810", Offset = "0x32BC410", VA = "0x1832BD810")]
		public void OnRarityFilterGroupBtnPressed()
		{
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1DE")]
		[Address(RVA = "0x32BDB90", Offset = "0x32BC790", VA = "0x1832BDB90")]
		public void OnSortRarityButtonPressed()
		{
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1DF")]
		[Address(RVA = "0x32BDAC0", Offset = "0x32BC6C0", VA = "0x1832BDAC0")]
		public void OnSortPriceButtonPressed()
		{
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1E0")]
		[Address(RVA = "0x32BD9F0", Offset = "0x32BC5F0", VA = "0x1832BD9F0")]
		public void OnSortIdButtonPressed()
		{
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1E1")]
		[Address(RVA = "0x32BD6F0", Offset = "0x32BC2F0", VA = "0x1832BD6F0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1E2")]
		[Address(RVA = "0x32BE1B0", Offset = "0x32BCDB0", VA = "0x1832BE1B0")]
		public BuildingWorkshopFormulaState()
		{
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1E4")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1E5")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400AC63 RID: 44131
		[Token(Token = "0x400AC63")]
		public const int MSG_FILTER_CLICK = 1;

		// Token: 0x0400AC64 RID: 44132
		[Token(Token = "0x400AC64")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400AC65 RID: 44133
		[Token(Token = "0x400AC65")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingWorkshopFormulaView _formulaView;

		// Token: 0x0400AC66 RID: 44134
		[Token(Token = "0x400AC66")]
		[FieldOffset(Offset = "0x80")]
		private BuildingWorkshopFormulaState.StateBean m_stateBean;

		// Token: 0x0400AC67 RID: 44135
		[Token(Token = "0x400AC67")]
		[FieldOffset(Offset = "0x88")]
		private BuildingWorkshopFormulaProperty m_viewProperty;

		// Token: 0x0400AC68 RID: 44136
		[Token(Token = "0x400AC68")]
		[FieldOffset(Offset = "0x90")]
		private BuildingWorkshopFormulaViewModel m_formularViewModel;

		// Token: 0x0400AC69 RID: 44137
		[Token(Token = "0x400AC69")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0400AC6A RID: 44138
		[Token(Token = "0x400AC6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AC6B RID: 44139
		[Token(Token = "0x400AC6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400AC6C RID: 44140
		[Token(Token = "0x400AC6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400AC6D RID: 44141
		[Token(Token = "0x400AC6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AC6E RID: 44142
		[Token(Token = "0x400AC6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400AC6F RID: 44143
		[Token(Token = "0x400AC6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFormulaClicked;

		// Token: 0x0400AC70 RID: 44144
		[Token(Token = "0x400AC70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnFilterBuildingButtonPressed;

		// Token: 0x0400AC71 RID: 44145
		[Token(Token = "0x400AC71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnFilterEliteButtonPressed;

		// Token: 0x0400AC72 RID: 44146
		[Token(Token = "0x400AC72")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFilterSkillButtonPressed;

		// Token: 0x0400AC73 RID: 44147
		[Token(Token = "0x400AC73")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFilterAscButtonPressed;

		// Token: 0x0400AC74 RID: 44148
		[Token(Token = "0x400AC74")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnFilterFurnitureButtonPressed;

		// Token: 0x0400AC75 RID: 44149
		[Token(Token = "0x400AC75")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnRarityFilterGroupBtnPressed;

		// Token: 0x0400AC76 RID: 44150
		[Token(Token = "0x400AC76")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnSortRarityButtonPressed;

		// Token: 0x0400AC77 RID: 44151
		[Token(Token = "0x400AC77")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSortPriceButtonPressed;

		// Token: 0x0400AC78 RID: 44152
		[Token(Token = "0x400AC78")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnSortIdButtonPressed;

		// Token: 0x0400AC79 RID: 44153
		[Token(Token = "0x400AC79")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0400AC7A RID: 44154
		[Token(Token = "0x400AC7A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BDB RID: 7131
		[Token(Token = "0x2001BDB")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x0600B1E6 RID: 45542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1E6")]
			[Address(RVA = "0x32CE1E0", Offset = "0x32CCDE0", VA = "0x1832CE1E0")]
			public StateBean()
			{
			}

			// Token: 0x0400AC7B RID: 44155
			[Token(Token = "0x400AC7B")]
			[FieldOffset(Offset = "0x10")]
			public IWorkshopSession currentSession;

			// Token: 0x0400AC7C RID: 44156
			[Token(Token = "0x400AC7C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
