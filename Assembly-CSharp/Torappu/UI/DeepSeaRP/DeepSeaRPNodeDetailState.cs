using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005166 RID: 20838
	[Token(Token = "0x2005166")]
	public class DeepSeaRPNodeDetailState : PopupFadeState
	{
		// Token: 0x0601ECA2 RID: 126114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECA2")]
		[Address(RVA = "0x186C080", Offset = "0x186AC80", VA = "0x18186C080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601ECA3 RID: 126115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA3")]
		[Address(RVA = "0x186D490", Offset = "0x186C090", VA = "0x18186D490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ECA4 RID: 126116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA4")]
		[Address(RVA = "0x186CB90", Offset = "0x186B790", VA = "0x18186CB90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601ECA5 RID: 126117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA5")]
		[Address(RVA = "0x186D340", Offset = "0x186BF40", VA = "0x18186D340", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601ECA6 RID: 126118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA6")]
		[Address(RVA = "0x186D3B0", Offset = "0x186BFB0", VA = "0x18186D3B0")]
		private void _ClearIntroCoroutine()
		{
		}

		// Token: 0x0601ECA7 RID: 126119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECA7")]
		[Address(RVA = "0x186D5A0", Offset = "0x186C1A0", VA = "0x18186D5A0")]
		private IEnumerator _IntroCoroutine(Act17sideData.EventData eventData, bool showAdditionView)
		{
			return null;
		}

		// Token: 0x0601ECA8 RID: 126120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA8")]
		[Address(RVA = "0x186D690", Offset = "0x186C290", VA = "0x18186D690")]
		private void _OnChoiceSelected(int choiceIdx, Act17sideData.EventData eventData)
		{
		}

		// Token: 0x0601ECA9 RID: 126121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECA9")]
		[Address(RVA = "0x186C240", Offset = "0x186AE40", VA = "0x18186C240")]
		public void OnBtnLeave()
		{
		}

		// Token: 0x0601ECAA RID: 126122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECAA")]
		[Address(RVA = "0x186C0E0", Offset = "0x186ACE0", VA = "0x18186C0E0")]
		public void OnBtnAction()
		{
		}

		// Token: 0x0601ECAB RID: 126123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECAB")]
		[Address(RVA = "0x186C7C0", Offset = "0x186B3C0", VA = "0x18186C7C0")]
		public void OnBtnReadStory()
		{
		}

		// Token: 0x0601ECAC RID: 126124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECAC")]
		[Address(RVA = "0x186C440", Offset = "0x186B040", VA = "0x18186C440")]
		public void OnBtnOpenChest()
		{
		}

		// Token: 0x0601ECAD RID: 126125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ECAD")]
		[Address(RVA = "0x186D9C0", Offset = "0x186C5C0", VA = "0x18186D9C0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0601ECAE RID: 126126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECAE")]
		[Address(RVA = "0x186DAA0", Offset = "0x186C6A0", VA = "0x18186DAA0")]
		public DeepSeaRPNodeDetailState()
		{
		}

		// Token: 0x0601ECB0 RID: 126128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECB0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601ECB1 RID: 126129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ECB1")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04029493 RID: 169107
		[Token(Token = "0x4029493")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DeepSeaRPNodeDetailView _view;

		// Token: 0x04029494 RID: 169108
		[Token(Token = "0x4029494")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x04029495 RID: 169109
		[Token(Token = "0x4029495")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine m_introCoroutine;

		// Token: 0x04029496 RID: 169110
		[Token(Token = "0x4029496")]
		[FieldOffset(Offset = "0x88")]
		private DeepSeaRPCommonNodeDetailStateBean m_stateBean;

		// Token: 0x04029497 RID: 169111
		[Token(Token = "0x4029497")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04029498 RID: 169112
		[Token(Token = "0x4029498")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029499 RID: 169113
		[Token(Token = "0x4029499")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402949A RID: 169114
		[Token(Token = "0x402949A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402949B RID: 169115
		[Token(Token = "0x402949B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402949C RID: 169116
		[Token(Token = "0x402949C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearIntroCoroutine;

		// Token: 0x0402949D RID: 169117
		[Token(Token = "0x402949D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IntroCoroutine;

		// Token: 0x0402949E RID: 169118
		[Token(Token = "0x402949E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnChoiceSelected;

		// Token: 0x0402949F RID: 169119
		[Token(Token = "0x402949F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnLeave;

		// Token: 0x040294A0 RID: 169120
		[Token(Token = "0x40294A0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnAction;

		// Token: 0x040294A1 RID: 169121
		[Token(Token = "0x40294A1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBtnReadStory;

		// Token: 0x040294A2 RID: 169122
		[Token(Token = "0x40294A2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnOpenChest;

		// Token: 0x040294A3 RID: 169123
		[Token(Token = "0x40294A3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x040294A4 RID: 169124
		[Token(Token = "0x40294A4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
