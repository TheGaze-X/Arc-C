using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074F5 RID: 29941
	[Token(Token = "0x20074F5")]
	public class Act25sideDailyHarvestState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0602A315 RID: 172821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A315")]
		[Address(RVA = "0x25C6D70", Offset = "0x25C5970", VA = "0x1825C6D70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A316 RID: 172822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A316")]
		[Address(RVA = "0x25C6F50", Offset = "0x25C5B50", VA = "0x1825C6F50", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602A317 RID: 172823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A317")]
		[Address(RVA = "0x25C70C0", Offset = "0x25C5CC0", VA = "0x1825C70C0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602A318 RID: 172824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A318")]
		[Address(RVA = "0x25C79D0", Offset = "0x25C65D0", VA = "0x1825C79D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A319 RID: 172825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A319")]
		[Address(RVA = "0x25C7C60", Offset = "0x25C6860", VA = "0x1825C7C60")]
		private void _Refresh()
		{
		}

		// Token: 0x0602A31A RID: 172826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A31A")]
		[Address(RVA = "0x25C6D10", Offset = "0x25C5910", VA = "0x1825C6D10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A31B RID: 172827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A31B")]
		[Address(RVA = "0x25C7290", Offset = "0x25C5E90", VA = "0x1825C7290", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602A31C RID: 172828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A31C")]
		[Address(RVA = "0x25C73E0", Offset = "0x25C5FE0", VA = "0x1825C73E0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602A31D RID: 172829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A31D")]
		[Address(RVA = "0x25C6C90", Offset = "0x25C5890", VA = "0x1825C6C90")]
		public void EventClose()
		{
		}

		// Token: 0x0602A31E RID: 172830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A31E")]
		[Address(RVA = "0x25C6FD0", Offset = "0x25C5BD0", VA = "0x1825C6FD0")]
		public void OnRewardClick()
		{
		}

		// Token: 0x0602A31F RID: 172831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A31F")]
		[Address(RVA = "0x25C7050", Offset = "0x25C5C50", VA = "0x1825C7050")]
		public void OnRuleClick()
		{
		}

		// Token: 0x0602A320 RID: 172832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A320")]
		private void _AddTopState<PopState>() where PopState : State
		{
		}

		// Token: 0x0602A321 RID: 172833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A321")]
		[Address(RVA = "0x25C7D40", Offset = "0x25C6940", VA = "0x1825C7D40")]
		private void _SendGetItem()
		{
		}

		// Token: 0x0602A322 RID: 172834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A322")]
		[Address(RVA = "0x25C7500", Offset = "0x25C6100", VA = "0x1825C7500")]
		private void _ProcessGetItemResp(VoucherItemDetailResponse resp)
		{
		}

		// Token: 0x0602A323 RID: 172835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A323")]
		[Address(RVA = "0x25C75B0", Offset = "0x25C61B0", VA = "0x1825C75B0")]
		private void _DataToHarvestRule(IStateBean stateBean)
		{
		}

		// Token: 0x0602A324 RID: 172836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A324")]
		[Address(RVA = "0x25C76B0", Offset = "0x25C62B0", VA = "0x1825C76B0")]
		private void _DataToRewardState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A325 RID: 172837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A325")]
		[Address(RVA = "0x25C78A0", Offset = "0x25C64A0", VA = "0x1825C78A0")]
		private void _EventOnHarvest()
		{
		}

		// Token: 0x0602A326 RID: 172838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A326")]
		[Address(RVA = "0x25C7790", Offset = "0x25C6390", VA = "0x1825C7790")]
		private AnimationSwitchTween _EnsureAnim()
		{
			return null;
		}

		// Token: 0x0602A327 RID: 172839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A327")]
		[Address(RVA = "0x25C6EA0", Offset = "0x25C5AA0", VA = "0x1825C6EA0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A328 RID: 172840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A328")]
		[Address(RVA = "0x25C7F80", Offset = "0x25C6B80", VA = "0x1825C7F80")]
		public Act25sideDailyHarvestState()
		{
		}

		// Token: 0x0602A32B RID: 172843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A32B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A32C RID: 172844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A32C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602A32D RID: 172845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A32D")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602A32E RID: 172846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A32E")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0602A32F RID: 172847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A32F")]
		[Address(RVA = "0x15A4200", Offset = "0x15A2E00", VA = "0x1815A4200")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0403CA20 RID: 248352
		[Token(Token = "0x403CA20")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act25sideDailyHarvestView _view;

		// Token: 0x0403CA21 RID: 248353
		[Token(Token = "0x403CA21")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403CA22 RID: 248354
		[Token(Token = "0x403CA22")]
		[NonSerialized]
		public const int ON_PROGRESS_TIMEOUT = 0;

		// Token: 0x0403CA23 RID: 248355
		[Token(Token = "0x403CA23")]
		[FieldOffset(Offset = "0x88")]
		private Act25sideDailyHarvestStateBean m_cachedBean;

		// Token: 0x0403CA24 RID: 248356
		[Token(Token = "0x403CA24")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0403CA25 RID: 248357
		[Token(Token = "0x403CA25")]
		[FieldOffset(Offset = "0x98")]
		private Act25SideData m_cachedData;

		// Token: 0x0403CA26 RID: 248358
		[Token(Token = "0x403CA26")]
		[FieldOffset(Offset = "0xA0")]
		private ItemVoucherData m_cachedItemData;

		// Token: 0x0403CA27 RID: 248359
		[Token(Token = "0x403CA27")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_enterAnim;

		// Token: 0x0403CA28 RID: 248360
		[Token(Token = "0x403CA28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CA29 RID: 248361
		[Token(Token = "0x403CA29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403CA2A RID: 248362
		[Token(Token = "0x403CA2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403CA2B RID: 248363
		[Token(Token = "0x403CA2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CA2C RID: 248364
		[Token(Token = "0x403CA2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0403CA2D RID: 248365
		[Token(Token = "0x403CA2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CA2E RID: 248366
		[Token(Token = "0x403CA2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403CA2F RID: 248367
		[Token(Token = "0x403CA2F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403CA30 RID: 248368
		[Token(Token = "0x403CA30")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventClose;

		// Token: 0x0403CA31 RID: 248369
		[Token(Token = "0x403CA31")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRewardClick;

		// Token: 0x0403CA32 RID: 248370
		[Token(Token = "0x403CA32")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRuleClick;

		// Token: 0x0403CA33 RID: 248371
		[Token(Token = "0x403CA33")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AddTopState;

		// Token: 0x0403CA34 RID: 248372
		[Token(Token = "0x403CA34")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SendGetItem;

		// Token: 0x0403CA35 RID: 248373
		[Token(Token = "0x403CA35")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ProcessGetItemResp;

		// Token: 0x0403CA36 RID: 248374
		[Token(Token = "0x403CA36")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DataToHarvestRule;

		// Token: 0x0403CA37 RID: 248375
		[Token(Token = "0x403CA37")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DataToRewardState;

		// Token: 0x0403CA38 RID: 248376
		[Token(Token = "0x403CA38")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnHarvest;

		// Token: 0x0403CA39 RID: 248377
		[Token(Token = "0x403CA39")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EnsureAnim;

		// Token: 0x0403CA3A RID: 248378
		[Token(Token = "0x403CA3A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403CA3B RID: 248379
		[Token(Token = "0x403CA3B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
