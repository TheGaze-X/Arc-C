using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062CB RID: 25291
	[Token(Token = "0x20062CB")]
	public class AutoChessModeChoiceState : AutoChessPrepareModeChooseBaseState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0602470E RID: 149262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602470E")]
		[Address(RVA = "0x1F43470", Offset = "0x1F42070", VA = "0x181F43470", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602470F RID: 149263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602470F")]
		[Address(RVA = "0x1F43DE0", Offset = "0x1F429E0", VA = "0x181F43DE0", Slot = "31")]
		protected override void OnStateEnter()
		{
		}

		// Token: 0x06024710 RID: 149264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024710")]
		[Address(RVA = "0x1F43910", Offset = "0x1F42510", VA = "0x181F43910", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06024711 RID: 149265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024711")]
		[Address(RVA = "0x1F43B90", Offset = "0x1F42790", VA = "0x181F43B90", Slot = "33")]
		protected override void OnStateCustomMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024712 RID: 149266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024712")]
		[Address(RVA = "0x1F434D0", Offset = "0x1F420D0", VA = "0x181F434D0", Slot = "34")]
		protected override AutoChessModeChoiceViewModel GetViewModel()
		{
			return null;
		}

		// Token: 0x06024713 RID: 149267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024713")]
		[Address(RVA = "0x1F44020", Offset = "0x1F42C20", VA = "0x181F44020", Slot = "35")]
		protected override void RefreshView()
		{
		}

		// Token: 0x06024714 RID: 149268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024714")]
		[Address(RVA = "0x1F43560", Offset = "0x1F42160", VA = "0x181F43560", Slot = "36")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06024715 RID: 149269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024715")]
		[Address(RVA = "0x1F44570", Offset = "0x1F43170", VA = "0x181F44570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024716 RID: 149270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024716")]
		[Address(RVA = "0x1F44510", Offset = "0x1F43110", VA = "0x181F44510")]
		private ILoadAsset _GetAssetLoader()
		{
			return null;
		}

		// Token: 0x06024717 RID: 149271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024717")]
		[Address(RVA = "0x1F44350", Offset = "0x1F42F50", VA = "0x181F44350")]
		private void _EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x06024718 RID: 149272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024718")]
		[Address(RVA = "0x1F44820", Offset = "0x1F43420", VA = "0x181F44820")]
		private void _OnConfirmLocalModeStartGame()
		{
		}

		// Token: 0x06024719 RID: 149273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024719")]
		[Address(RVA = "0x1F447B0", Offset = "0x1F433B0", VA = "0x181F447B0")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0602471A RID: 149274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602471A")]
		[Address(RVA = "0x1F448B0", Offset = "0x1F434B0", VA = "0x181F448B0")]
		private void _OnConfirmMultiSoloModeStartMatch()
		{
		}

		// Token: 0x0602471B RID: 149275 RVA: 0x000C4290 File Offset: 0x000C2490
		[Token(Token = "0x602471B")]
		[Address(RVA = "0x1F44E70", Offset = "0x1F43A70", VA = "0x181F44E70")]
		private bool _OnMultiSoloMatchStartMatchResponse(AutoChessStartMatchResponse response)
		{
			return default(bool);
		}

		// Token: 0x0602471C RID: 149276 RVA: 0x000C42A8 File Offset: 0x000C24A8
		[Token(Token = "0x602471C")]
		[Address(RVA = "0x1F44170", Offset = "0x1F42D70", VA = "0x181F44170")]
		private bool _CheckIfMultiSoloStartMatchSuccess(AutoChessStartMatchResponse response, AutoChessModeChoiceViewModel viewModel, out string toastStr)
		{
			return default(bool);
		}

		// Token: 0x0602471D RID: 149277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602471D")]
		[Address(RVA = "0x1F44C10", Offset = "0x1F43810", VA = "0x181F44C10")]
		private void _OnConfirmSingleModeStartGame()
		{
		}

		// Token: 0x0602471E RID: 149278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602471E")]
		[Address(RVA = "0x1F45040", Offset = "0x1F43C40", VA = "0x181F45040")]
		public AutoChessModeChoiceState()
		{
		}

		// Token: 0x06024720 RID: 149280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024720")]
		[Address(RVA = "0x1F25FB0", Offset = "0x1F24BB0", VA = "0x181F25FB0")]
		private void <>xLuaBaseProxy_OnStateEnter()
		{
		}

		// Token: 0x06024721 RID: 149281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024721")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04032BD9 RID: 207833
		[Token(Token = "0x4032BD9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AutoChessModeChoiceView _view;

		// Token: 0x04032BDA RID: 207834
		[Token(Token = "0x4032BDA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04032BDB RID: 207835
		[Token(Token = "0x4032BDB")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04032BDC RID: 207836
		[Token(Token = "0x4032BDC")]
		[FieldOffset(Offset = "0x94")]
		private int m_matchingDlgInst;

		// Token: 0x04032BDD RID: 207837
		[Token(Token = "0x4032BDD")]
		[FieldOffset(Offset = "0x98")]
		private AutoChessModeChoiceStateBean m_stateBean;

		// Token: 0x04032BDE RID: 207838
		[Token(Token = "0x4032BDE")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032BDF RID: 207839
		[Token(Token = "0x4032BDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04032BE0 RID: 207840
		[Token(Token = "0x4032BE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x04032BE1 RID: 207841
		[Token(Token = "0x4032BE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04032BE2 RID: 207842
		[Token(Token = "0x4032BE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateCustomMessage;

		// Token: 0x04032BE3 RID: 207843
		[Token(Token = "0x4032BE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x04032BE4 RID: 207844
		[Token(Token = "0x4032BE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04032BE5 RID: 207845
		[Token(Token = "0x4032BE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04032BE6 RID: 207846
		[Token(Token = "0x4032BE6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032BE7 RID: 207847
		[Token(Token = "0x4032BE7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetAssetLoader;

		// Token: 0x04032BE8 RID: 207848
		[Token(Token = "0x4032BE8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnConfirmBtnClicked;

		// Token: 0x04032BE9 RID: 207849
		[Token(Token = "0x4032BE9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnConfirmLocalModeStartGame;

		// Token: 0x04032BEA RID: 207850
		[Token(Token = "0x4032BEA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x04032BEB RID: 207851
		[Token(Token = "0x4032BEB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnConfirmMultiSoloModeStartMatch;

		// Token: 0x04032BEC RID: 207852
		[Token(Token = "0x4032BEC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnMultiSoloMatchStartMatchResponse;

		// Token: 0x04032BED RID: 207853
		[Token(Token = "0x4032BED")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIfMultiSoloStartMatchSuccess;

		// Token: 0x04032BEE RID: 207854
		[Token(Token = "0x4032BEE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnConfirmSingleModeStartGame;

		// Token: 0x04032BEF RID: 207855
		[Token(Token = "0x4032BEF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
