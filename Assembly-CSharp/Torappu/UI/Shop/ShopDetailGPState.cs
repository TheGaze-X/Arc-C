using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.VoucherSkin;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AA9 RID: 23209
	[Token(Token = "0x2005AA9")]
	public class ShopDetailGPState : ShopDetailCommonState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06021C0B RID: 138251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C0B")]
		[Address(RVA = "0x1C39410", Offset = "0x1C38010", VA = "0x181C39410", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06021C0C RID: 138252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C0C")]
		[Address(RVA = "0x1C39A60", Offset = "0x1C38660", VA = "0x181C39A60")]
		private void _OnGpTicketUse()
		{
		}

		// Token: 0x06021C0D RID: 138253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C0D")]
		[Address(RVA = "0x1C39380", Offset = "0x1C37F80", VA = "0x181C39380", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06021C0E RID: 138254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021C0E")]
		[Address(RVA = "0x1C39080", Offset = "0x1C37C80", VA = "0x181C39080", Slot = "34")]
		public CustomYieldInstruction HandleCallBackAsync(int instId, ValueBundle output)
		{
			return null;
		}

		// Token: 0x06021C0F RID: 138255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021C0F")]
		[Address(RVA = "0x1C394B0", Offset = "0x1C380B0", VA = "0x181C394B0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06021C10 RID: 138256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C10")]
		[Address(RVA = "0x1C39F50", Offset = "0x1C38B50", VA = "0x181C39F50")]
		private void _ToChoosePreviewState(IStateBean stateBean)
		{
		}

		// Token: 0x06021C11 RID: 138257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C11")]
		[Address(RVA = "0x1C3A0F0", Offset = "0x1C38CF0", VA = "0x181C3A0F0")]
		private void _ToEvolvePreviewState(IStateBean stateBean)
		{
		}

		// Token: 0x06021C12 RID: 138258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C12")]
		[Address(RVA = "0x1C3A290", Offset = "0x1C38E90", VA = "0x181C3A290")]
		private void _ToPlayerAvatarDisplayState(IStateBean stateBean)
		{
		}

		// Token: 0x06021C13 RID: 138259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C13")]
		[Address(RVA = "0x1C38E90", Offset = "0x1C37A90", VA = "0x181C38E90")]
		public void EventOnPreviewBtnClick(string itemId)
		{
		}

		// Token: 0x06021C14 RID: 138260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C14")]
		[Address(RVA = "0x1C3A360", Offset = "0x1C38F60", VA = "0x181C3A360")]
		private void _TryOpenPreviewState(UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06021C15 RID: 138261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C15")]
		[Address(RVA = "0x1C39940", Offset = "0x1C38540", VA = "0x181C39940")]
		private void _HandleBuyGoodWithTicketResponse(BuyGpGoodWithTicketResponse response)
		{
		}

		// Token: 0x06021C16 RID: 138262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C16")]
		[Address(RVA = "0x1C396F0", Offset = "0x1C382F0", VA = "0x181C396F0")]
		private void _FetchVoucherSkinGoodList(UIItemViewModel itemViewModel, Action<UIItemViewModel, List<VoucherSkinItemViewModel>, string> onFinish)
		{
		}

		// Token: 0x06021C17 RID: 138263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C17")]
		[Address(RVA = "0x1C39E00", Offset = "0x1C38A00", VA = "0x181C39E00")]
		private void _OpenVoucherSkinPage(UIItemViewModel itemViewModel, List<VoucherSkinItemViewModel> skinItems, string ruleDesc)
		{
		}

		// Token: 0x06021C18 RID: 138264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C18")]
		[Address(RVA = "0x1C3A8E0", Offset = "0x1C394E0", VA = "0x181C3A8E0")]
		public ShopDetailGPState()
		{
		}

		// Token: 0x06021C19 RID: 138265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021C19")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402E2D8 RID: 189144
		[Token(Token = "0x402E2D8")]
		[NonSerialized]
		public const int ON_GP_TICKET_USE = 0;

		// Token: 0x0402E2D9 RID: 189145
		[Token(Token = "0x402E2D9")]
		[FieldOffset(Offset = "0x78")]
		private UIItemViewModel m_cachedItemViewModel;

		// Token: 0x0402E2DA RID: 189146
		[Token(Token = "0x402E2DA")]
		[FieldOffset(Offset = "0x80")]
		private int m_instId;

		// Token: 0x0402E2DB RID: 189147
		[Token(Token = "0x402E2DB")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E2DC RID: 189148
		[Token(Token = "0x402E2DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402E2DD RID: 189149
		[Token(Token = "0x402E2DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnGpTicketUse;

		// Token: 0x0402E2DE RID: 189150
		[Token(Token = "0x402E2DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402E2DF RID: 189151
		[Token(Token = "0x402E2DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleCallBackAsync;

		// Token: 0x0402E2E0 RID: 189152
		[Token(Token = "0x402E2E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402E2E1 RID: 189153
		[Token(Token = "0x402E2E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ToChoosePreviewState;

		// Token: 0x0402E2E2 RID: 189154
		[Token(Token = "0x402E2E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ToEvolvePreviewState;

		// Token: 0x0402E2E3 RID: 189155
		[Token(Token = "0x402E2E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ToPlayerAvatarDisplayState;

		// Token: 0x0402E2E4 RID: 189156
		[Token(Token = "0x402E2E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnPreviewBtnClick;

		// Token: 0x0402E2E5 RID: 189157
		[Token(Token = "0x402E2E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryOpenPreviewState;

		// Token: 0x0402E2E6 RID: 189158
		[Token(Token = "0x402E2E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandleBuyGoodWithTicketResponse;

		// Token: 0x0402E2E7 RID: 189159
		[Token(Token = "0x402E2E7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FetchVoucherSkinGoodList;

		// Token: 0x0402E2E8 RID: 189160
		[Token(Token = "0x402E2E8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OpenVoucherSkinPage;

		// Token: 0x0402E2E9 RID: 189161
		[Token(Token = "0x402E2E9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
