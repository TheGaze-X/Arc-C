using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200548B RID: 21643
	[Token(Token = "0x200548B")]
	public class RoguelikeCharSelectState : PopupFadeState, ICompDialogCallBack, IValueMsgReceiver
	{
		// Token: 0x0601FD7F RID: 130431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD7F")]
		[Address(RVA = "0x19F3930", Offset = "0x19F2530", VA = "0x1819F3930", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601FD80 RID: 130432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD80")]
		[Address(RVA = "0x19F6210", Offset = "0x19F4E10", VA = "0x1819F6210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FD81 RID: 130433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD81")]
		[Address(RVA = "0x19F6810", Offset = "0x19F5410", VA = "0x1819F6810")]
		private void _ResetGuideBook()
		{
		}

		// Token: 0x0601FD82 RID: 130434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD82")]
		[Address(RVA = "0x19F5F00", Offset = "0x19F4B00", VA = "0x1819F5F00")]
		private UIGuidebookTrigger _GetAvailGuidebookAsset()
		{
			return null;
		}

		// Token: 0x0601FD83 RID: 130435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD83")]
		[Address(RVA = "0x19F60C0", Offset = "0x19F4CC0", VA = "0x1819F60C0")]
		private string _GetAvailGuidebookSubsignal()
		{
			return null;
		}

		// Token: 0x0601FD84 RID: 130436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD84")]
		[Address(RVA = "0x19F3F70", Offset = "0x19F2B70", VA = "0x1819F3F70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601FD85 RID: 130437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD85")]
		[Address(RVA = "0x19F4690", Offset = "0x19F3290", VA = "0x1819F4690", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601FD86 RID: 130438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD86")]
		[Address(RVA = "0x19F45D0", Offset = "0x19F31D0", VA = "0x1819F45D0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601FD87 RID: 130439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD87")]
		[Address(RVA = "0x19F4B90", Offset = "0x19F3790", VA = "0x1819F4B90")]
		private void _ApplyFilter(ValueBundle msg)
		{
		}

		// Token: 0x0601FD88 RID: 130440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD88")]
		[Address(RVA = "0x19F5380", Offset = "0x19F3F80", VA = "0x1819F5380")]
		private void _DealWithInput()
		{
		}

		// Token: 0x0601FD89 RID: 130441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD89")]
		[Address(RVA = "0x19F7130", Offset = "0x19F5D30", VA = "0x1819F7130")]
		private void _TryLoadStashTicketButton()
		{
		}

		// Token: 0x0601FD8A RID: 130442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD8A")]
		[Address(RVA = "0x19F6680", Offset = "0x19F5280", VA = "0x1819F6680")]
		private RoguelikeSelectCharMenuButtonResHolderBase _LoadMenuButtonHolder()
		{
			return null;
		}

		// Token: 0x0601FD8B RID: 130443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD8B")]
		[Address(RVA = "0x19F7880", Offset = "0x19F6480", VA = "0x1819F7880")]
		private void _UpdateRecruitData()
		{
		}

		// Token: 0x0601FD8C RID: 130444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD8C")]
		[Address(RVA = "0x19F3480", Offset = "0x19F2080", VA = "0x1819F3480")]
		public void DealWithCharClick(int instId)
		{
		}

		// Token: 0x0601FD8D RID: 130445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD8D")]
		[Address(RVA = "0x19F5E00", Offset = "0x19F4A00", VA = "0x1819F5E00")]
		private void _EmitSelectCharChange()
		{
		}

		// Token: 0x0601FD8E RID: 130446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD8E")]
		[Address(RVA = "0x19F5BF0", Offset = "0x19F47F0", VA = "0x1819F5BF0")]
		private void _DealWithSingleSelect(RoguelikeSelectCharViewModel value, int instId)
		{
		}

		// Token: 0x0601FD8F RID: 130447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD8F")]
		[Address(RVA = "0x19F59A0", Offset = "0x19F45A0", VA = "0x1819F59A0")]
		private void _DealWithMultiSelect(RoguelikeSelectCharViewModel value, int instId)
		{
		}

		// Token: 0x0601FD90 RID: 130448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD90")]
		[Address(RVA = "0x19F6F50", Offset = "0x19F5B50", VA = "0x1819F6F50")]
		private void _TryInsertSelectInst(RoguelikeSelectCharViewModel value, RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0601FD91 RID: 130449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD91")]
		[Address(RVA = "0x19F36C0", Offset = "0x19F22C0", VA = "0x1819F36C0")]
		public void DealWithSkillClick(string skillId)
		{
		}

		// Token: 0x0601FD92 RID: 130450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD92")]
		[Address(RVA = "0x19F3360", Offset = "0x19F1F60", VA = "0x1819F3360")]
		public void DeadWithBranchClick(string equipId)
		{
		}

		// Token: 0x0601FD93 RID: 130451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD93")]
		[Address(RVA = "0x19F3640", Offset = "0x19F2240", VA = "0x1819F3640")]
		public void DealWithSkillClickWithCharId(int instId, string skillId)
		{
		}

		// Token: 0x0601FD94 RID: 130452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD94")]
		[Address(RVA = "0x19F3850", Offset = "0x19F2450", VA = "0x1819F3850")]
		public void EventOnAttrTabClick(CharAttrTabType tabType)
		{
		}

		// Token: 0x0601FD95 RID: 130453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD95")]
		[Address(RVA = "0x19F4A20", Offset = "0x19F3620", VA = "0x1819F4A20")]
		public void WrapperDismiss()
		{
		}

		// Token: 0x0601FD96 RID: 130454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD96")]
		[Address(RVA = "0x19F4AD0", Offset = "0x19F36D0", VA = "0x1819F4AD0")]
		public void WrapperShowInfo()
		{
		}

		// Token: 0x0601FD97 RID: 130455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD97")]
		[Address(RVA = "0x19F31C0", Offset = "0x19F1DC0", VA = "0x1819F31C0")]
		public void CleanAllSelect()
		{
		}

		// Token: 0x0601FD98 RID: 130456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD98")]
		[Address(RVA = "0x19F4D60", Offset = "0x19F3960", VA = "0x1819F4D60")]
		private void _CancelPage()
		{
		}

		// Token: 0x0601FD99 RID: 130457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD99")]
		[Address(RVA = "0x19F4EA0", Offset = "0x19F3AA0", VA = "0x1819F4EA0")]
		private void _CheckPage()
		{
		}

		// Token: 0x0601FD9A RID: 130458 RVA: 0x000B3850 File Offset: 0x000B1A50
		[Token(Token = "0x601FD9A")]
		[Address(RVA = "0x19F6EE0", Offset = "0x19F5AE0", VA = "0x1819F6EE0")]
		private bool _StateClosing()
		{
			return default(bool);
		}

		// Token: 0x0601FD9B RID: 130459 RVA: 0x000B3868 File Offset: 0x000B1A68
		[Token(Token = "0x601FD9B")]
		[Address(RVA = "0x19F50B0", Offset = "0x19F3CB0", VA = "0x1819F50B0")]
		private bool _CheckPendingRecruitAndDo()
		{
			return default(bool);
		}

		// Token: 0x0601FD9C RID: 130460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD9C")]
		[Address(RVA = "0x19F3DB0", Offset = "0x19F29B0", VA = "0x1819F3DB0")]
		public void OnCancelSelect()
		{
		}

		// Token: 0x0601FD9D RID: 130461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD9D")]
		[Address(RVA = "0x19F4340", Offset = "0x19F2F40", VA = "0x1819F4340")]
		public void OnFinishSelect()
		{
		}

		// Token: 0x0601FD9E RID: 130462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD9E")]
		[Address(RVA = "0x19F6540", Offset = "0x19F5140", VA = "0x1819F6540")]
		private void _JumpToFriendAssistState()
		{
		}

		// Token: 0x0601FD9F RID: 130463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD9F")]
		[Address(RVA = "0x19F6930", Offset = "0x19F5530", VA = "0x1819F6930")]
		private void _SendGetAssistListRequest(string index, ProfessionCategory profession, Action onComplete)
		{
		}

		// Token: 0x0601FDA0 RID: 130464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA0")]
		[Address(RVA = "0x19F42C0", Offset = "0x19F2EC0", VA = "0x1819F42C0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601FDA1 RID: 130465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA1")]
		[Address(RVA = "0x19F7600", Offset = "0x19F6200", VA = "0x1819F7600")]
		private void _TryOpenStashTicketDialog()
		{
		}

		// Token: 0x0601FDA2 RID: 130466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA2")]
		[Address(RVA = "0x19F3990", Offset = "0x19F2590", VA = "0x1819F3990", Slot = "31")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601FDA3 RID: 130467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA3")]
		[Address(RVA = "0x19F6C20", Offset = "0x19F5820", VA = "0x1819F6C20")]
		private void _StashTicketConfirm(string sucToast)
		{
		}

		// Token: 0x0601FDA4 RID: 130468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA4")]
		[Address(RVA = "0x19F49C0", Offset = "0x19F35C0", VA = "0x1819F49C0")]
		public void OnStashTicketClick()
		{
		}

		// Token: 0x0601FDA5 RID: 130469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA5")]
		[Address(RVA = "0x19F3AC0", Offset = "0x19F26C0", VA = "0x1819F3AC0")]
		public void OnBtnFriendAssist()
		{
		}

		// Token: 0x0601FDA6 RID: 130470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA6")]
		[Address(RVA = "0x19F7940", Offset = "0x19F6540", VA = "0x1819F7940")]
		public RoguelikeCharSelectState()
		{
		}

		// Token: 0x0601FDA7 RID: 130471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601FDA8 RID: 130472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA8")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601FDA9 RID: 130473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDA9")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0402AE62 RID: 175714
		[Token(Token = "0x402AE62")]
		private const string DEFAULT_GUIDEBOOK_SUBSIGNAL = "select";

		// Token: 0x0402AE63 RID: 175715
		[Token(Token = "0x402AE63")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeCharSelectStateBean _stateBean;

		// Token: 0x0402AE64 RID: 175716
		[Token(Token = "0x402AE64")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402AE65 RID: 175717
		[Token(Token = "0x402AE65")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _guideBtn;

		// Token: 0x0402AE66 RID: 175718
		[Token(Token = "0x402AE66")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _btnAssistGo;

		// Token: 0x0402AE67 RID: 175719
		[Token(Token = "0x402AE67")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _guideBookTriggerRoot;

		// Token: 0x0402AE68 RID: 175720
		[Token(Token = "0x402AE68")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RoguelikeCharSelectView _view;

		// Token: 0x0402AE69 RID: 175721
		[Token(Token = "0x402AE69")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Stash Ticket")]
		private RectTransform _stashButtonRoot;

		// Token: 0x0402AE6A RID: 175722
		[Token(Token = "0x402AE6A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _pluginContainer;

		// Token: 0x0402AE6B RID: 175723
		[Token(Token = "0x402AE6B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private LoopScrollRect _loopScrollRect;

		// Token: 0x0402AE6C RID: 175724
		[Token(Token = "0x402AE6C")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeCharSelectState.MenuAdapter m_menuAdapter;

		// Token: 0x0402AE6D RID: 175725
		[Token(Token = "0x402AE6D")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeMenuButtonPluginBase m_menuPlugin;

		// Token: 0x0402AE6E RID: 175726
		[Token(Token = "0x402AE6E")]
		[FieldOffset(Offset = "0xC8")]
		private RoguelikeMenuButtonPluginBase.Input m_menuPluginInput;

		// Token: 0x0402AE6F RID: 175727
		[Token(Token = "0x402AE6F")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hideCharMenuObject;

		// Token: 0x0402AE70 RID: 175728
		[Token(Token = "0x402AE70")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402AE71 RID: 175729
		[Token(Token = "0x402AE71")]
		[FieldOffset(Offset = "0xE0")]
		private List<IRoguelikeCharCardViewPluginContext> m_pluginContexts;

		// Token: 0x0402AE72 RID: 175730
		[Token(Token = "0x402AE72")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_inited;

		// Token: 0x0402AE73 RID: 175731
		[Token(Token = "0x402AE73")]
		[FieldOffset(Offset = "0xEC")]
		private int m_stashTicketDialog;

		// Token: 0x0402AE74 RID: 175732
		[Token(Token = "0x402AE74")]
		[FieldOffset(Offset = "0xF0")]
		private string m_topicId;

		// Token: 0x0402AE75 RID: 175733
		[Token(Token = "0x402AE75")]
		[FieldOffset(Offset = "0xF8")]
		private PlayerRoguelikeV2.CurrentData.Recruit m_recruitData;

		// Token: 0x0402AE76 RID: 175734
		[Token(Token = "0x402AE76")]
		[FieldOffset(Offset = "0x100")]
		private UIGuidebookTrigger m_guidebookTrigger;

		// Token: 0x0402AE77 RID: 175735
		[Token(Token = "0x402AE77")]
		[NonSerialized]
		public const int ON_APPLY_FILTER = 0;

		// Token: 0x0402AE78 RID: 175736
		[Token(Token = "0x402AE78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402AE79 RID: 175737
		[Token(Token = "0x402AE79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AE7A RID: 175738
		[Token(Token = "0x402AE7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetGuideBook;

		// Token: 0x0402AE7B RID: 175739
		[Token(Token = "0x402AE7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetAvailGuidebookAsset;

		// Token: 0x0402AE7C RID: 175740
		[Token(Token = "0x402AE7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetAvailGuidebookSubsignal;

		// Token: 0x0402AE7D RID: 175741
		[Token(Token = "0x402AE7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402AE7E RID: 175742
		[Token(Token = "0x402AE7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402AE7F RID: 175743
		[Token(Token = "0x402AE7F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402AE80 RID: 175744
		[Token(Token = "0x402AE80")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ApplyFilter;

		// Token: 0x0402AE81 RID: 175745
		[Token(Token = "0x402AE81")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DealWithInput;

		// Token: 0x0402AE82 RID: 175746
		[Token(Token = "0x402AE82")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryLoadStashTicketButton;

		// Token: 0x0402AE83 RID: 175747
		[Token(Token = "0x402AE83")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadMenuButtonHolder;

		// Token: 0x0402AE84 RID: 175748
		[Token(Token = "0x402AE84")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateRecruitData;

		// Token: 0x0402AE85 RID: 175749
		[Token(Token = "0x402AE85")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DealWithCharClick;

		// Token: 0x0402AE86 RID: 175750
		[Token(Token = "0x402AE86")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EmitSelectCharChange;

		// Token: 0x0402AE87 RID: 175751
		[Token(Token = "0x402AE87")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DealWithSingleSelect;

		// Token: 0x0402AE88 RID: 175752
		[Token(Token = "0x402AE88")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DealWithMultiSelect;

		// Token: 0x0402AE89 RID: 175753
		[Token(Token = "0x402AE89")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryInsertSelectInst;

		// Token: 0x0402AE8A RID: 175754
		[Token(Token = "0x402AE8A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_DealWithSkillClick;

		// Token: 0x0402AE8B RID: 175755
		[Token(Token = "0x402AE8B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_DeadWithBranchClick;

		// Token: 0x0402AE8C RID: 175756
		[Token(Token = "0x402AE8C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DealWithSkillClickWithCharId;

		// Token: 0x0402AE8D RID: 175757
		[Token(Token = "0x402AE8D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnAttrTabClick;

		// Token: 0x0402AE8E RID: 175758
		[Token(Token = "0x402AE8E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_WrapperDismiss;

		// Token: 0x0402AE8F RID: 175759
		[Token(Token = "0x402AE8F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_WrapperShowInfo;

		// Token: 0x0402AE90 RID: 175760
		[Token(Token = "0x402AE90")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CleanAllSelect;

		// Token: 0x0402AE91 RID: 175761
		[Token(Token = "0x402AE91")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CancelPage;

		// Token: 0x0402AE92 RID: 175762
		[Token(Token = "0x402AE92")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckPage;

		// Token: 0x0402AE93 RID: 175763
		[Token(Token = "0x402AE93")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__StateClosing;

		// Token: 0x0402AE94 RID: 175764
		[Token(Token = "0x402AE94")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckPendingRecruitAndDo;

		// Token: 0x0402AE95 RID: 175765
		[Token(Token = "0x402AE95")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnCancelSelect;

		// Token: 0x0402AE96 RID: 175766
		[Token(Token = "0x402AE96")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnFinishSelect;

		// Token: 0x0402AE97 RID: 175767
		[Token(Token = "0x402AE97")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__JumpToFriendAssistState;

		// Token: 0x0402AE98 RID: 175768
		[Token(Token = "0x402AE98")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__SendGetAssistListRequest;

		// Token: 0x0402AE99 RID: 175769
		[Token(Token = "0x402AE99")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402AE9A RID: 175770
		[Token(Token = "0x402AE9A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__TryOpenStashTicketDialog;

		// Token: 0x0402AE9B RID: 175771
		[Token(Token = "0x402AE9B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402AE9C RID: 175772
		[Token(Token = "0x402AE9C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__StashTicketConfirm;

		// Token: 0x0402AE9D RID: 175773
		[Token(Token = "0x402AE9D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnStashTicketClick;

		// Token: 0x0402AE9E RID: 175774
		[Token(Token = "0x402AE9E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnBtnFriendAssist;

		// Token: 0x0402AE9F RID: 175775
		[Token(Token = "0x402AE9F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200548C RID: 21644
		[Token(Token = "0x200548C")]
		[Serializable]
		public class RoguelikeCharAttrTabTypeMessage : UnityEvent<CharAttrTabType>
		{
			// Token: 0x0601FDAA RID: 130474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FDAA")]
			[Address(RVA = "0x19E7450", Offset = "0x19E6050", VA = "0x1819E7450")]
			public RoguelikeCharAttrTabTypeMessage()
			{
			}
		}

		// Token: 0x0200548D RID: 21645
		[Token(Token = "0x200548D")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x0601FDAB RID: 130475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FDAB")]
			[Address(RVA = "0x19E6F80", Offset = "0x19E5B80", VA = "0x1819E6F80")]
			public MenuAdapter(RoguelikeCharSelectState closure)
			{
			}

			// Token: 0x17004AB0 RID: 19120
			// (get) Token: 0x0601FDAC RID: 130476 RVA: 0x000B3880 File Offset: 0x000B1A80
			[Token(Token = "0x17004AB0")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601FDAC")]
				[Address(RVA = "0x19E7330", Offset = "0x19E5F30", VA = "0x1819E7330", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004AB1 RID: 19121
			// (get) Token: 0x0601FDAD RID: 130477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004AB1")]
			public override RoguelikeMenuButtonPluginBase buttonPrefab
			{
				[Token(Token = "0x601FDAD")]
				[Address(RVA = "0x19E7130", Offset = "0x19E5D30", VA = "0x1819E7130", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004AB2 RID: 19122
			// (get) Token: 0x0601FDAE RID: 130478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004AB2")]
			public override RoguelikeMenuButtonPluginBase.Input buttonInput
			{
				[Token(Token = "0x601FDAE")]
				[Address(RVA = "0x19E70C0", Offset = "0x19E5CC0", VA = "0x1819E70C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004AB3 RID: 19123
			// (get) Token: 0x0601FDAF RID: 130479 RVA: 0x000B3898 File Offset: 0x000B1A98
			[Token(Token = "0x17004AB3")]
			public override RoguelikeMenuCharObjectStatus charMenuObjectStatus
			{
				[Token(Token = "0x601FDAF")]
				[Address(RVA = "0x19E7200", Offset = "0x19E5E00", VA = "0x1819E7200", Slot = "8")]
				get
				{
					return RoguelikeMenuCharObjectStatus.HIDE;
				}
			}

			// Token: 0x0601FDB0 RID: 130480 RVA: 0x000B38B0 File Offset: 0x000B1AB0
			[Token(Token = "0x601FDB0")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0601FDB1 RID: 130481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FDB1")]
			[Address(RVA = "0x18AED60", Offset = "0x18AD960", VA = "0x1818AED60")]
			private RoguelikeMenuButtonPluginBase <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x0601FDB2 RID: 130482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FDB2")]
			[Address(RVA = "0x18AED50", Offset = "0x18AD950", VA = "0x1818AED50")]
			private RoguelikeMenuButtonPluginBase.Input <>xLuaBaseProxy_get_buttonInput()
			{
				return null;
			}

			// Token: 0x0601FDB3 RID: 130483 RVA: 0x000B38C8 File Offset: 0x000B1AC8
			[Token(Token = "0x601FDB3")]
			[Address(RVA = "0x19E6F70", Offset = "0x19E5B70", VA = "0x1819E6F70")]
			private RoguelikeMenuCharObjectStatus <>xLuaBaseProxy_get_charMenuObjectStatus()
			{
				return RoguelikeMenuCharObjectStatus.HIDE;
			}

			// Token: 0x0402AEA0 RID: 175776
			[Token(Token = "0x402AEA0")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeCharSelectState m_closure;

			// Token: 0x0402AEA1 RID: 175777
			[Token(Token = "0x402AEA1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402AEA2 RID: 175778
			[Token(Token = "0x402AEA2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402AEA3 RID: 175779
			[Token(Token = "0x402AEA3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402AEA4 RID: 175780
			[Token(Token = "0x402AEA4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_buttonInput;

			// Token: 0x0402AEA5 RID: 175781
			[Token(Token = "0x402AEA5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_charMenuObjectStatus;
		}
	}
}
