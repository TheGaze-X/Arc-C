using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004433 RID: 17459
	[Token(Token = "0x2004433")]
	public class SandboxV2SquadGroupPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AAAF RID: 109231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAAF")]
		[Address(RVA = "0x13C8840", Offset = "0x13C7440", VA = "0x1813C8840")]
		public void Init(string topicId, ISandboxV2SquadPanelContext actionInterface)
		{
		}

		// Token: 0x0601AAB0 RID: 109232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB0")]
		[Address(RVA = "0x13CA6D0", Offset = "0x13C92D0", VA = "0x1813CA6D0")]
		public void SaveSquadSelectIndex()
		{
		}

		// Token: 0x0601AAB1 RID: 109233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB1")]
		[Address(RVA = "0x13CA630", Offset = "0x13C9230", VA = "0x1813CA630")]
		public void SaveSquadIfNeeded(Action nextStep, bool mustGoNext = true)
		{
		}

		// Token: 0x0601AAB2 RID: 109234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB2")]
		[Address(RVA = "0x13CCDD0", Offset = "0x13CB9D0", VA = "0x1813CCDD0")]
		private void _SaveSquadSelectIndex()
		{
		}

		// Token: 0x0601AAB3 RID: 109235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB3")]
		[Address(RVA = "0x13CC810", Offset = "0x13CB410", VA = "0x1813CC810")]
		private void _SaveSquadIfNeeded(Action nextStep, bool mustGoNext = true)
		{
		}

		// Token: 0x0601AAB4 RID: 109236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB4")]
		[Address(RVA = "0x13CA800", Offset = "0x13C9400", VA = "0x1813CA800")]
		private void _EventOnSquadTabClick(int squadIdx)
		{
		}

		// Token: 0x0601AAB5 RID: 109237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB5")]
		[Address(RVA = "0x13CAEE0", Offset = "0x13C9AE0", VA = "0x1813CAEE0")]
		private void _OnCharSkillSelected(int instId, string skillId)
		{
		}

		// Token: 0x0601AAB6 RID: 109238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB6")]
		[Address(RVA = "0x13CADA0", Offset = "0x13C99A0", VA = "0x1813CADA0")]
		private void _OnCharDineClick(int charInstId)
		{
		}

		// Token: 0x0601AAB7 RID: 109239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB7")]
		[Address(RVA = "0x13CB390", Offset = "0x13C9F90", VA = "0x1813CB390")]
		private void _OnRepoSlotClick(int charInstId)
		{
		}

		// Token: 0x0601AAB8 RID: 109240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB8")]
		[Address(RVA = "0x13CC180", Offset = "0x13CAD80", VA = "0x1813CC180")]
		private void _OnToolBtnBuildClick(int toolIdx)
		{
		}

		// Token: 0x0601AAB9 RID: 109241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAB9")]
		[Address(RVA = "0x13CBEA0", Offset = "0x13CAAA0", VA = "0x1813CBEA0")]
		private void _OnSquadToolClick(int toolIdx)
		{
		}

		// Token: 0x0601AABA RID: 109242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AABA")]
		[Address(RVA = "0x13CB900", Offset = "0x13CA500", VA = "0x1813CB900")]
		private void _OnSquadSlotClick(int slotIdx)
		{
		}

		// Token: 0x0601AABB RID: 109243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AABB")]
		[Address(RVA = "0x13CC610", Offset = "0x13CB210", VA = "0x1813CC610")]
		private void _OpenToolSelectState(int squadIndex, SandboxV2ToolSelectStateBean.Input input)
		{
		}

		// Token: 0x0601AABC RID: 109244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AABC")]
		[Address(RVA = "0x13CC3B0", Offset = "0x13CAFB0", VA = "0x1813CC3B0")]
		private void _OpenCharSelectState(int squadIndex, SandboxV2AdminCharSelectStateBean.OpenOption openOption)
		{
		}

		// Token: 0x0601AABD RID: 109245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AABD")]
		[Address(RVA = "0x13CB790", Offset = "0x13CA390", VA = "0x1813CB790")]
		private void _OnRepoStatusFilterClick(SandboxV2CharFilter charFilter)
		{
		}

		// Token: 0x0601AABE RID: 109246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AABE")]
		[Address(RVA = "0x13CB290", Offset = "0x13C9E90", VA = "0x1813CB290")]
		private void _OnRepoProfessionFilterClick(ProfessionCategory profession)
		{
		}

		// Token: 0x0601AABF RID: 109247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AABF")]
		[Address(RVA = "0x13C80C0", Offset = "0x13C6CC0", VA = "0x1813C80C0")]
		public void EventOnClearProfessionFilter()
		{
		}

		// Token: 0x0601AAC0 RID: 109248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC0")]
		[Address(RVA = "0x13C8280", Offset = "0x13C6E80", VA = "0x1813C8280")]
		public void EventOnToggleProfessionFilter()
		{
		}

		// Token: 0x0601AAC1 RID: 109249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC1")]
		[Address(RVA = "0x13C83E0", Offset = "0x13C6FE0", VA = "0x1813C83E0")]
		public void EventOnToggleStatusFilter()
		{
		}

		// Token: 0x0601AAC2 RID: 109250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC2")]
		[Address(RVA = "0x13C8000", Offset = "0x13C6C00", VA = "0x1813C8000")]
		public void EventOnBtnRepoClick()
		{
		}

		// Token: 0x0601AAC3 RID: 109251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC3")]
		[Address(RVA = "0x13C7C00", Offset = "0x13C6800", VA = "0x1813C7C00")]
		public void EventOnBtnEditSquad()
		{
		}

		// Token: 0x0601AAC4 RID: 109252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC4")]
		[Address(RVA = "0x13C7E20", Offset = "0x13C6A20", VA = "0x1813C7E20")]
		public void EventOnBtnEditTool()
		{
		}

		// Token: 0x0601AAC5 RID: 109253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC5")]
		[Address(RVA = "0x13C81B0", Offset = "0x13C6DB0", VA = "0x1813C81B0")]
		public void EventOnNavToCharList()
		{
		}

		// Token: 0x0601AAC6 RID: 109254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC6")]
		[Address(RVA = "0x13C8210", Offset = "0x13C6E10", VA = "0x1813C8210")]
		public void EventOnNavToToolList()
		{
		}

		// Token: 0x0601AAC7 RID: 109255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC7")]
		[Address(RVA = "0x13CCF60", Offset = "0x13CBB60", VA = "0x1813CCF60")]
		private void _ScrollToPos(float scrollPos)
		{
		}

		// Token: 0x0601AAC8 RID: 109256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC8")]
		[Address(RVA = "0x13C84E0", Offset = "0x13C70E0", VA = "0x1813C84E0")]
		public void EventonClearSquad()
		{
		}

		// Token: 0x0601AAC9 RID: 109257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAC9")]
		[Address(RVA = "0x13CA5D0", Offset = "0x13C91D0", VA = "0x1813CA5D0")]
		public void NotifyUpdateDine()
		{
		}

		// Token: 0x0601AACA RID: 109258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AACA")]
		[Address(RVA = "0x13C91F0", Offset = "0x13C7DF0", VA = "0x1813C91F0")]
		public void NotifyCharSelect(SandboxV2AdminCharSelectStateBean.OpenOption openOption, SandboxV2AdminCharSelectStateBean.OutPut outputParam)
		{
		}

		// Token: 0x0601AACB RID: 109259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AACB")]
		[Address(RVA = "0x13C9630", Offset = "0x13C8230", VA = "0x1813C9630")]
		public void NotifyPanelResume(bool isForceUpdate)
		{
		}

		// Token: 0x0601AACC RID: 109260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AACC")]
		[Address(RVA = "0x13CA250", Offset = "0x13C8E50", VA = "0x1813CA250")]
		public void NotifyToolSelect(SandboxV2ToolSelectStateBean.Input toolSelectInput, SandboxV2ToolSelectStateBean.Output toolSelectOutput)
		{
		}

		// Token: 0x0601AACD RID: 109261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AACD")]
		[Address(RVA = "0x13C98A0", Offset = "0x13C84A0", VA = "0x1813C98A0")]
		public void NotifyStartBattle(SandboxV2BattleStartNodeInfo nodeInfo)
		{
		}

		// Token: 0x0601AACE RID: 109262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AACE")]
		[Address(RVA = "0x13C95D0", Offset = "0x13C81D0", VA = "0x1813C95D0")]
		public void NotifyMakeDrink()
		{
		}

		// Token: 0x0601AACF RID: 109263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AACF")]
		[Address(RVA = "0x13CAB30", Offset = "0x13C9730", VA = "0x1813CAB30")]
		private void _NavToMakeDrink()
		{
		}

		// Token: 0x0601AAD0 RID: 109264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAD0")]
		[Address(RVA = "0x13CD8F0", Offset = "0x13CC4F0", VA = "0x1813CD8F0")]
		private void _TryStartBattle()
		{
		}

		// Token: 0x0601AAD1 RID: 109265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAD1")]
		[Address(RVA = "0x13CD230", Offset = "0x13CBE30", VA = "0x1813CD230")]
		private void _StartBattleImpl()
		{
		}

		// Token: 0x0601AAD2 RID: 109266 RVA: 0x000A2D08 File Offset: 0x000A0F08
		[Token(Token = "0x601AAD2")]
		[Address(RVA = "0x13CA910", Offset = "0x13C9510", VA = "0x1813CA910")]
		private SandboxV2ConfirmDialog.Options _GeneCommonStartBattleConfirmDialogOptions(string topicId)
		{
			return default(SandboxV2ConfirmDialog.Options);
		}

		// Token: 0x0601AAD3 RID: 109267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAD3")]
		[Address(RVA = "0x13CD0A0", Offset = "0x13CBCA0", VA = "0x1813CD0A0")]
		private void _ShowJudgeDialog(SandboxV2ConfirmDialog.Options options)
		{
		}

		// Token: 0x0601AAD4 RID: 109268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AAD4")]
		[Address(RVA = "0x13CD9B0", Offset = "0x13CC5B0", VA = "0x1813CD9B0")]
		public SandboxV2SquadGroupPanel()
		{
		}

		// Token: 0x040220AF RID: 139439
		[Token(Token = "0x40220AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2SquadButtonView _buttonView;

		// Token: 0x040220B0 RID: 139440
		[Token(Token = "0x40220B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2SquadView _squadView;

		// Token: 0x040220B1 RID: 139441
		[Token(Token = "0x40220B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2CharRepoView _repoView;

		// Token: 0x040220B2 RID: 139442
		[Token(Token = "0x40220B2")]
		private const float CHAR_LIST_SCROLL_POS = 0f;

		// Token: 0x040220B3 RID: 139443
		[Token(Token = "0x40220B3")]
		private const float TOOL_LIST_SCROLL_POS = 1f;

		// Token: 0x040220B4 RID: 139444
		[Token(Token = "0x40220B4")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2SquadGroupProp m_prop;

		// Token: 0x040220B5 RID: 139445
		[Token(Token = "0x40220B5")]
		[FieldOffset(Offset = "0x38")]
		private ISandboxV2SquadPanelContext m_actionInterface;

		// Token: 0x040220B6 RID: 139446
		[Token(Token = "0x40220B6")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedSquadIdx;

		// Token: 0x040220B7 RID: 139447
		[Token(Token = "0x40220B7")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2BattleStartNodeInfo m_nodeInfo;

		// Token: 0x040220B8 RID: 139448
		[Token(Token = "0x40220B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040220B9 RID: 139449
		[Token(Token = "0x40220B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SaveSquadSelectIndex;

		// Token: 0x040220BA RID: 139450
		[Token(Token = "0x40220BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SaveSquadIfNeeded;

		// Token: 0x040220BB RID: 139451
		[Token(Token = "0x40220BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SaveSquadSelectIndex;

		// Token: 0x040220BC RID: 139452
		[Token(Token = "0x40220BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveSquadIfNeeded;

		// Token: 0x040220BD RID: 139453
		[Token(Token = "0x40220BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnSquadTabClick;

		// Token: 0x040220BE RID: 139454
		[Token(Token = "0x40220BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCharSkillSelected;

		// Token: 0x040220BF RID: 139455
		[Token(Token = "0x40220BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCharDineClick;

		// Token: 0x040220C0 RID: 139456
		[Token(Token = "0x40220C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnRepoSlotClick;

		// Token: 0x040220C1 RID: 139457
		[Token(Token = "0x40220C1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnToolBtnBuildClick;

		// Token: 0x040220C2 RID: 139458
		[Token(Token = "0x40220C2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSquadToolClick;

		// Token: 0x040220C3 RID: 139459
		[Token(Token = "0x40220C3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSquadSlotClick;

		// Token: 0x040220C4 RID: 139460
		[Token(Token = "0x40220C4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OpenToolSelectState;

		// Token: 0x040220C5 RID: 139461
		[Token(Token = "0x40220C5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OpenCharSelectState;

		// Token: 0x040220C6 RID: 139462
		[Token(Token = "0x40220C6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRepoStatusFilterClick;

		// Token: 0x040220C7 RID: 139463
		[Token(Token = "0x40220C7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRepoProfessionFilterClick;

		// Token: 0x040220C8 RID: 139464
		[Token(Token = "0x40220C8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnClearProfessionFilter;

		// Token: 0x040220C9 RID: 139465
		[Token(Token = "0x40220C9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnToggleProfessionFilter;

		// Token: 0x040220CA RID: 139466
		[Token(Token = "0x40220CA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnToggleStatusFilter;

		// Token: 0x040220CB RID: 139467
		[Token(Token = "0x40220CB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnBtnRepoClick;

		// Token: 0x040220CC RID: 139468
		[Token(Token = "0x40220CC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnBtnEditSquad;

		// Token: 0x040220CD RID: 139469
		[Token(Token = "0x40220CD")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnBtnEditTool;

		// Token: 0x040220CE RID: 139470
		[Token(Token = "0x40220CE")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnNavToCharList;

		// Token: 0x040220CF RID: 139471
		[Token(Token = "0x40220CF")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnNavToToolList;

		// Token: 0x040220D0 RID: 139472
		[Token(Token = "0x40220D0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ScrollToPos;

		// Token: 0x040220D1 RID: 139473
		[Token(Token = "0x40220D1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventonClearSquad;

		// Token: 0x040220D2 RID: 139474
		[Token(Token = "0x40220D2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_NotifyUpdateDine;

		// Token: 0x040220D3 RID: 139475
		[Token(Token = "0x40220D3")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_NotifyCharSelect;

		// Token: 0x040220D4 RID: 139476
		[Token(Token = "0x40220D4")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_NotifyPanelResume;

		// Token: 0x040220D5 RID: 139477
		[Token(Token = "0x40220D5")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_NotifyToolSelect;

		// Token: 0x040220D6 RID: 139478
		[Token(Token = "0x40220D6")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_NotifyStartBattle;

		// Token: 0x040220D7 RID: 139479
		[Token(Token = "0x40220D7")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_NotifyMakeDrink;

		// Token: 0x040220D8 RID: 139480
		[Token(Token = "0x40220D8")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__NavToMakeDrink;

		// Token: 0x040220D9 RID: 139481
		[Token(Token = "0x40220D9")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__TryStartBattle;

		// Token: 0x040220DA RID: 139482
		[Token(Token = "0x40220DA")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__StartBattleImpl;

		// Token: 0x040220DB RID: 139483
		[Token(Token = "0x40220DB")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GeneCommonStartBattleConfirmDialogOptions;

		// Token: 0x040220DC RID: 139484
		[Token(Token = "0x40220DC")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ShowJudgeDialog;

		// Token: 0x040220DD RID: 139485
		[Token(Token = "0x40220DD")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
