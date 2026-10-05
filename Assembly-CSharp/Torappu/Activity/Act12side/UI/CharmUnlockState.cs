using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A8F RID: 31375
	[Token(Token = "0x2007A8F")]
	public class CharmUnlockState : PopupFloatState
	{
		// Token: 0x0602BF28 RID: 180008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF28")]
		[Address(RVA = "0x27EAA00", Offset = "0x27E9600", VA = "0x1827EAA00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF29 RID: 180009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF29")]
		[Address(RVA = "0x27EAAA0", Offset = "0x27E96A0", VA = "0x1827EAAA0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0602BF2A RID: 180010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF2A")]
		[Address(RVA = "0x27EAB20", Offset = "0x27E9720", VA = "0x1827EAB20", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BF2B RID: 180011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF2B")]
		[Address(RVA = "0x27EB150", Offset = "0x27E9D50", VA = "0x1827EB150")]
		private void _Refresh()
		{
		}

		// Token: 0x0602BF2C RID: 180012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF2C")]
		[Address(RVA = "0x27EAFE0", Offset = "0x27E9BE0", VA = "0x1827EAFE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BF2D RID: 180013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF2D")]
		[Address(RVA = "0x27EA9A0", Offset = "0x27E95A0", VA = "0x1827EA9A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF2E RID: 180014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF2E")]
		[Address(RVA = "0x27EA6F0", Offset = "0x27E92F0", VA = "0x1827EA6F0")]
		public void EventOnGet()
		{
		}

		// Token: 0x0602BF2F RID: 180015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF2F")]
		[Address(RVA = "0x27EB070", Offset = "0x27E9C70", VA = "0x1827EB070")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602BF30 RID: 180016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF30")]
		[Address(RVA = "0x27EAF10", Offset = "0x27E9B10", VA = "0x1827EAF10")]
		private string _GetTheActivityOpenedMe()
		{
			return null;
		}

		// Token: 0x0602BF31 RID: 180017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF31")]
		[Address(RVA = "0x27EADC0", Offset = "0x27E99C0", VA = "0x1827EADC0")]
		private Act12sideStageController _FindController()
		{
			return null;
		}

		// Token: 0x0602BF32 RID: 180018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF32")]
		[Address(RVA = "0x27EB5A0", Offset = "0x27EA1A0", VA = "0x1827EB5A0")]
		public CharmUnlockState()
		{
		}

		// Token: 0x0602BF35 RID: 180021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF35")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BF36 RID: 180022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF36")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0602BF37 RID: 180023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF37")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403FA8F RID: 260751
		[Token(Token = "0x403FA8F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CharmCard _cardPrefab;

		// Token: 0x0403FA90 RID: 260752
		[Token(Token = "0x403FA90")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0403FA91 RID: 260753
		[Token(Token = "0x403FA91")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x0403FA92 RID: 260754
		[Token(Token = "0x403FA92")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _coin;

		// Token: 0x0403FA93 RID: 260755
		[Token(Token = "0x403FA93")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403FA94 RID: 260756
		[Token(Token = "0x403FA94")]
		private const string ANIM_ENTRY = "unlock_entry";

		// Token: 0x0403FA95 RID: 260757
		[Token(Token = "0x403FA95")]
		[FieldOffset(Offset = "0x98")]
		private string m_activityId;

		// Token: 0x0403FA96 RID: 260758
		[Token(Token = "0x403FA96")]
		[FieldOffset(Offset = "0xA0")]
		private List<CharmCard> m_cards;

		// Token: 0x0403FA97 RID: 260759
		[Token(Token = "0x403FA97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FA98 RID: 260760
		[Token(Token = "0x403FA98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0403FA99 RID: 260761
		[Token(Token = "0x403FA99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FA9A RID: 260762
		[Token(Token = "0x403FA9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0403FA9B RID: 260763
		[Token(Token = "0x403FA9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FA9C RID: 260764
		[Token(Token = "0x403FA9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FA9D RID: 260765
		[Token(Token = "0x403FA9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnGet;

		// Token: 0x0403FA9E RID: 260766
		[Token(Token = "0x403FA9E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403FA9F RID: 260767
		[Token(Token = "0x403FA9F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetTheActivityOpenedMe;

		// Token: 0x0403FAA0 RID: 260768
		[Token(Token = "0x403FAA0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FindController;

		// Token: 0x0403FAA1 RID: 260769
		[Token(Token = "0x403FAA1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
