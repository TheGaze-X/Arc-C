using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004959 RID: 18777
	[Token(Token = "0x2004959")]
	public class MedalBarListState : PopupFadeState, IMedalListFilterHandler
	{
		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x0601C4CC RID: 115916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004318")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x601C4CC")]
			[Address(RVA = "0x15C6F60", Offset = "0x15C5B60", VA = "0x1815C6F60", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C4CD RID: 115917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C4CD")]
		[Address(RVA = "0x15C5FC0", Offset = "0x15C4BC0", VA = "0x1815C5FC0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C4CE RID: 115918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4CE")]
		[Address(RVA = "0x15C6260", Offset = "0x15C4E60", VA = "0x1815C6260", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601C4CF RID: 115919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4CF")]
		[Address(RVA = "0x15C60A0", Offset = "0x15C4CA0", VA = "0x1815C60A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C4D0 RID: 115920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D0")]
		[Address(RVA = "0x15C6A10", Offset = "0x15C5610", VA = "0x1815C6A10", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C4D1 RID: 115921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D1")]
		[Address(RVA = "0x15C6470", Offset = "0x15C5070", VA = "0x1815C6470")]
		public void OnGetMedalReward(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C4D2 RID: 115922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D2")]
		[Address(RVA = "0x15C6D80", Offset = "0x15C5980", VA = "0x1815C6D80")]
		private void _OnReceiveItemSucceed(GetRewardMedalResponse response)
		{
		}

		// Token: 0x0601C4D3 RID: 115923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C4D3")]
		[Address(RVA = "0x15C6AC0", Offset = "0x15C56C0", VA = "0x1815C6AC0")]
		public IEnumerator ReceiveItemsCoroutine(List<ItemGet> items)
		{
			return null;
		}

		// Token: 0x0601C4D4 RID: 115924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D4")]
		[Address(RVA = "0x15C6020", Offset = "0x15C4C20", VA = "0x1815C6020")]
		public void OnClickMedalEvent(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C4D5 RID: 115925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D5")]
		[Address(RVA = "0x15C66F0", Offset = "0x15C52F0", VA = "0x1815C66F0")]
		public void OnJumpToGroupList(string groupId)
		{
		}

		// Token: 0x0601C4D6 RID: 115926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D6")]
		[Address(RVA = "0x15C6840", Offset = "0x15C5440", VA = "0x1815C6840")]
		public void OnJumpToMedal(string medalId)
		{
		}

		// Token: 0x0601C4D7 RID: 115927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D7")]
		[Address(RVA = "0x15C6990", Offset = "0x15C5590", VA = "0x1815C6990", Slot = "32")]
		public virtual void OnMedalFilterChanged()
		{
		}

		// Token: 0x0601C4D8 RID: 115928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4D8")]
		[Address(RVA = "0x15C6F00", Offset = "0x15C5B00", VA = "0x1815C6F00")]
		public MedalBarListState()
		{
		}

		// Token: 0x0601C4DB RID: 115931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C4DB")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0601C4DC RID: 115932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4DC")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601C4DD RID: 115933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4DD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C4DE RID: 115934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C4DE")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402504F RID: 151631
		[Token(Token = "0x402504F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MedalShowBarListView _barListView;

		// Token: 0x04025050 RID: 151632
		[Token(Token = "0x4025050")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MedalListStateBean _stateBean;

		// Token: 0x04025051 RID: 151633
		[Token(Token = "0x4025051")]
		[FieldOffset(Offset = "0x80")]
		private StateCacheHandler<MedalBarListState.StateRuntime> m_cacheHandler;

		// Token: 0x04025052 RID: 151634
		[Token(Token = "0x4025052")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04025053 RID: 151635
		[Token(Token = "0x4025053")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025054 RID: 151636
		[Token(Token = "0x4025054")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025055 RID: 151637
		[Token(Token = "0x4025055")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025056 RID: 151638
		[Token(Token = "0x4025056")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025057 RID: 151639
		[Token(Token = "0x4025057")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGetMedalReward;

		// Token: 0x04025058 RID: 151640
		[Token(Token = "0x4025058")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnReceiveItemSucceed;

		// Token: 0x04025059 RID: 151641
		[Token(Token = "0x4025059")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x0402505A RID: 151642
		[Token(Token = "0x402505A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickMedalEvent;

		// Token: 0x0402505B RID: 151643
		[Token(Token = "0x402505B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnJumpToGroupList;

		// Token: 0x0402505C RID: 151644
		[Token(Token = "0x402505C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnJumpToMedal;

		// Token: 0x0402505D RID: 151645
		[Token(Token = "0x402505D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnMedalFilterChanged;

		// Token: 0x0402505E RID: 151646
		[Token(Token = "0x402505E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200495A RID: 18778
		[Token(Token = "0x200495A")]
		public struct StateRuntime
		{
			// Token: 0x0402505F RID: 151647
			[Token(Token = "0x402505F")]
			[FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x04025060 RID: 151648
			[Token(Token = "0x4025060")]
			[FieldOffset(Offset = "0x8")]
			public string medalId;
		}
	}
}
