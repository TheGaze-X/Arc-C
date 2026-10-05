using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E18 RID: 28184
	[Token(Token = "0x2006E18")]
	public class ActVecBreakV2DefenseStageOverviewItem : ActVecBreakV2DefenseStageBaseItem
	{
		// Token: 0x060281F3 RID: 164339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F3")]
		[Address(RVA = "0x23680C0", Offset = "0x2366CC0", VA = "0x1823680C0", Slot = "4")]
		public override void Render(ActVecBreakV2DefenseStageBaseItem.InputParam inputParam)
		{
		}

		// Token: 0x060281F4 RID: 164340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F4")]
		[Address(RVA = "0x23688D0", Offset = "0x23674D0", VA = "0x1823688D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060281F5 RID: 164341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F5")]
		[Address(RVA = "0x2368A30", Offset = "0x2367630", VA = "0x182368A30")]
		private static void _RenderBGPanel(ActVecBreakV2DefenseStageBaseItem.InputParam input, ActVecBreakV2DefenseBuffBackgroundPanel panel, ActVecBreakV2DefenseStageBaseItem.BackgroundType bgType)
		{
		}

		// Token: 0x060281F6 RID: 164342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F6")]
		[Address(RVA = "0x23687E0", Offset = "0x23673E0", VA = "0x1823687E0")]
		private void _EventRemoveSquadClick(string stageId)
		{
		}

		// Token: 0x060281F7 RID: 164343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F7")]
		[Address(RVA = "0x2367FB0", Offset = "0x2366BB0", VA = "0x182367FB0")]
		public void EventFocusStage()
		{
		}

		// Token: 0x060281F8 RID: 164344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F8")]
		[Address(RVA = "0x2368B50", Offset = "0x2367750", VA = "0x182368B50")]
		public ActVecBreakV2DefenseStageOverviewItem()
		{
		}

		// Token: 0x04038F42 RID: 233282
		[Token(Token = "0x4038F42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Lock")]
		private GameObject _panelLock;

		// Token: 0x04038F43 RID: 233283
		[Token(Token = "0x4038F43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lock")]
		private Text _unlockTimeText;

		// Token: 0x04038F44 RID: 233284
		[Token(Token = "0x4038F44")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Not Complete")]
		private GameObject _panelNotComplete;

		// Token: 0x04038F45 RID: 233285
		[Token(Token = "0x4038F45")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Not Complete")]
		private Image _buffIconNotComplete;

		// Token: 0x04038F46 RID: 233286
		[Token(Token = "0x4038F46")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Not Complete")]
		private Text _buffNameNotComplete;

		// Token: 0x04038F47 RID: 233287
		[Token(Token = "0x4038F47")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Not Complete")]
		private Text _buffDescNotComplete;

		// Token: 0x04038F48 RID: 233288
		[Token(Token = "0x4038F48")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Not Complete")]
		private Text _unlockCondition;

		// Token: 0x04038F49 RID: 233289
		[Token(Token = "0x4038F49")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Not Complete")]
		private TwoStateToggle _stageLockToggle;

		// Token: 0x04038F4A RID: 233290
		[Token(Token = "0x4038F4A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Not Complete")]
		private GameObject[] _lockPeopleIcon;

		// Token: 0x04038F4B RID: 233291
		[Token(Token = "0x4038F4B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Not Complete")]
		private GameObject[] _startBattlePeopleIcon;

		// Token: 0x04038F4C RID: 233292
		[Token(Token = "0x4038F4C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Not Select")]
		private GameObject _panelNotSelect;

		// Token: 0x04038F4D RID: 233293
		[Token(Token = "0x4038F4D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Not Select")]
		private Image _buffIconNotSelect;

		// Token: 0x04038F4E RID: 233294
		[Token(Token = "0x4038F4E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Not Select")]
		private Text _buffNameNotSelect;

		// Token: 0x04038F4F RID: 233295
		[Token(Token = "0x4038F4F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Not Select")]
		private Text _buffDescNotSelect;

		// Token: 0x04038F50 RID: 233296
		[Token(Token = "0x4038F50")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Selected")]
		private GameObject _panelSelected;

		// Token: 0x04038F51 RID: 233297
		[Token(Token = "0x4038F51")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Selected")]
		private Image _buffIconSelected;

		// Token: 0x04038F52 RID: 233298
		[Token(Token = "0x4038F52")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Selected")]
		private Text _buffNameSelected;

		// Token: 0x04038F53 RID: 233299
		[Token(Token = "0x4038F53")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Selected")]
		private Text _buffDescSelected;

		// Token: 0x04038F54 RID: 233300
		[Token(Token = "0x4038F54")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _singlePanel;

		// Token: 0x04038F55 RID: 233301
		[Token(Token = "0x4038F55")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _groupLeftPanel;

		// Token: 0x04038F56 RID: 233302
		[Token(Token = "0x4038F56")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _groupMiddlePanel;

		// Token: 0x04038F57 RID: 233303
		[Token(Token = "0x4038F57")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _groupRightPanel;

		// Token: 0x04038F58 RID: 233304
		[Token(Token = "0x4038F58")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _charSlotListContainer;

		// Token: 0x04038F59 RID: 233305
		[Token(Token = "0x4038F59")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ActVecBreakV2DefenseCharListView _charSlotListPrefab;

		// Token: 0x04038F5A RID: 233306
		[Token(Token = "0x4038F5A")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_hasInited;

		// Token: 0x04038F5B RID: 233307
		[Token(Token = "0x4038F5B")]
		[FieldOffset(Offset = "0xE8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038F5C RID: 233308
		[Token(Token = "0x4038F5C")]
		[FieldOffset(Offset = "0xF8")]
		private ActVecBreakV2DefenseCharListView m_defenseCharView;

		// Token: 0x04038F5D RID: 233309
		[Token(Token = "0x4038F5D")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04038F5E RID: 233310
		[Token(Token = "0x4038F5E")]
		[FieldOffset(Offset = "0x110")]
		private string m_stageId;

		// Token: 0x04038F5F RID: 233311
		[Token(Token = "0x4038F5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038F60 RID: 233312
		[Token(Token = "0x4038F60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038F61 RID: 233313
		[Token(Token = "0x4038F61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBGPanel;

		// Token: 0x04038F62 RID: 233314
		[Token(Token = "0x4038F62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventRemoveSquadClick;

		// Token: 0x04038F63 RID: 233315
		[Token(Token = "0x4038F63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventFocusStage;

		// Token: 0x04038F64 RID: 233316
		[Token(Token = "0x4038F64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
