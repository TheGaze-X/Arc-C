using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x020059F7 RID: 23031
	[Token(Token = "0x20059F7")]
	public class CrisisShopState : PopupFadeState
	{
		// Token: 0x17004ED8 RID: 20184
		// (get) Token: 0x06021908 RID: 137480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004ED8")]
		public CrisisShopViewHolder viewHolder
		{
			[Token(Token = "0x6021908")]
			[Address(RVA = "0x1C0BAD0", Offset = "0x1C0A6D0", VA = "0x181C0BAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021909 RID: 137481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021909")]
		[Address(RVA = "0x1C0A670", Offset = "0x1C09270", VA = "0x181C0A670")]
		public void OnEnterDetail(CrisisShopWrapped shopWrapped)
		{
		}

		// Token: 0x0602190A RID: 137482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602190A")]
		[Address(RVA = "0x1C0AC30", Offset = "0x1C09830", VA = "0x181C0AC30", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602190B RID: 137483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602190B")]
		[Address(RVA = "0x1C0AD90", Offset = "0x1C09990", VA = "0x181C0AD90", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602190C RID: 137484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602190C")]
		[Address(RVA = "0x1C0AF90", Offset = "0x1C09B90", VA = "0x181C0AF90", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602190D RID: 137485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602190D")]
		[Address(RVA = "0x1C0A610", Offset = "0x1C09210", VA = "0x181C0A610", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602190E RID: 137486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602190E")]
		[Address(RVA = "0x1C0A7D0", Offset = "0x1C093D0", VA = "0x181C0A7D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602190F RID: 137487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602190F")]
		[Address(RVA = "0x1C0AB20", Offset = "0x1C09720", VA = "0x181C0AB20", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06021910 RID: 137488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021910")]
		[Address(RVA = "0x1C0B850", Offset = "0x1C0A450", VA = "0x181C0B850")]
		private void _SendGetInfo()
		{
		}

		// Token: 0x06021911 RID: 137489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021911")]
		[Address(RVA = "0x1C0AEE0", Offset = "0x1C09AE0", VA = "0x181C0AEE0")]
		private IEnumerator ShowDetailCoroutine()
		{
			return null;
		}

		// Token: 0x06021912 RID: 137490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021912")]
		[Address(RVA = "0x1C0BA70", Offset = "0x1C0A670", VA = "0x181C0BA70")]
		public CrisisShopState()
		{
		}

		// Token: 0x06021916 RID: 137494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021916")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06021917 RID: 137495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021917")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06021918 RID: 137496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021918")]
		[Address(RVA = "0x12B83C0", Offset = "0x12B6FC0", VA = "0x1812B83C0")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x06021919 RID: 137497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021919")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602191A RID: 137498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602191A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402DDE5 RID: 187877
		[Token(Token = "0x402DDE5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CrisisShopStateBean _stateBean;

		// Token: 0x0402DDE6 RID: 187878
		[Token(Token = "0x402DDE6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CrisisShopViewHolder _viewHolder;

		// Token: 0x0402DDE7 RID: 187879
		[Token(Token = "0x402DDE7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _viewHolderContainer;

		// Token: 0x0402DDE8 RID: 187880
		[Token(Token = "0x402DDE8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _alphaGroup;

		// Token: 0x0402DDE9 RID: 187881
		[Token(Token = "0x402DDE9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CrisisShopEvent _clickEvent;

		// Token: 0x0402DDEA RID: 187882
		[Token(Token = "0x402DDEA")]
		[FieldOffset(Offset = "0x98")]
		private CrisisShopViewHolder m_viewHolder;

		// Token: 0x0402DDEB RID: 187883
		[Token(Token = "0x402DDEB")]
		[FieldOffset(Offset = "0xA0")]
		private CrisisShopWrapped m_cacheData;

		// Token: 0x0402DDEC RID: 187884
		[Token(Token = "0x402DDEC")]
		private const float ITEM_FADE_DURATION = 0.23f;

		// Token: 0x0402DDED RID: 187885
		[Token(Token = "0x402DDED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewHolder;

		// Token: 0x0402DDEE RID: 187886
		[Token(Token = "0x402DDEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnterDetail;

		// Token: 0x0402DDEF RID: 187887
		[Token(Token = "0x402DDEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402DDF0 RID: 187888
		[Token(Token = "0x402DDF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402DDF1 RID: 187889
		[Token(Token = "0x402DDF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0402DDF2 RID: 187890
		[Token(Token = "0x402DDF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402DDF3 RID: 187891
		[Token(Token = "0x402DDF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402DDF4 RID: 187892
		[Token(Token = "0x402DDF4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402DDF5 RID: 187893
		[Token(Token = "0x402DDF5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SendGetInfo;

		// Token: 0x0402DDF6 RID: 187894
		[Token(Token = "0x402DDF6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowDetailCoroutine;

		// Token: 0x0402DDF7 RID: 187895
		[Token(Token = "0x402DDF7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
