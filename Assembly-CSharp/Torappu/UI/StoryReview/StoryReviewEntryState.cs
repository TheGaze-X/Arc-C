using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048E7 RID: 18663
	[Token(Token = "0x20048E7")]
	public class StoryReviewEntryState : PopupFloatState
	{
		// Token: 0x0601C281 RID: 115329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C281")]
		[Address(RVA = "0x15A34A0", Offset = "0x15A20A0", VA = "0x1815A34A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C282 RID: 115330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C282")]
		[Address(RVA = "0x15A3730", Offset = "0x15A2330", VA = "0x1815A3730", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C283 RID: 115331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C283")]
		[Address(RVA = "0x15A3890", Offset = "0x15A2490", VA = "0x1815A3890", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C284 RID: 115332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C284")]
		[Address(RVA = "0x15A3930", Offset = "0x15A2530", VA = "0x1815A3930", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C285 RID: 115333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C285")]
		[Address(RVA = "0x15A4670", Offset = "0x15A3270", VA = "0x1815A4670")]
		private void _InitNewTip()
		{
		}

		// Token: 0x0601C286 RID: 115334 RVA: 0x000A76B8 File Offset: 0x000A58B8
		[Token(Token = "0x601C286")]
		[Address(RVA = "0x15A4230", Offset = "0x15A2E30", VA = "0x1815A4230")]
		private bool _CheckRewardsAvailable(StoryReviewEntryType entryType)
		{
			return default(bool);
		}

		// Token: 0x0601C287 RID: 115335 RVA: 0x000A76D0 File Offset: 0x000A58D0
		[Token(Token = "0x601C287")]
		[Address(RVA = "0x15A4500", Offset = "0x15A3100", VA = "0x1815A4500")]
		private bool _CheckStoryAvailable(StoryReviewChapterViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601C288 RID: 115336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C288")]
		[Address(RVA = "0x15A4760", Offset = "0x15A3360", VA = "0x1815A4760")]
		private void _OnJumpToActivityStoryState(StoryReviewStateBean targetBean)
		{
		}

		// Token: 0x0601C289 RID: 115337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C289")]
		[Address(RVA = "0x15A4850", Offset = "0x15A3450", VA = "0x1815A4850")]
		private void _OnJumpToMiniStoryState(MiniActReviewStateBean targetBean)
		{
		}

		// Token: 0x0601C28A RID: 115338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C28A")]
		[Address(RVA = "0x15A3120", Offset = "0x15A1D20", VA = "0x1815A3120")]
		public void EventOnActivityReviewClicked()
		{
		}

		// Token: 0x0601C28B RID: 115339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C28B")]
		[Address(RVA = "0x15A32E0", Offset = "0x15A1EE0", VA = "0x1815A32E0")]
		public void EventOnMiniReviewClicked()
		{
		}

		// Token: 0x0601C28C RID: 115340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C28C")]
		[Address(RVA = "0x15A3B00", Offset = "0x15A2700", VA = "0x1815A3B00", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601C28D RID: 115341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C28D")]
		[Address(RVA = "0x15A3500", Offset = "0x15A2100", VA = "0x1815A3500", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601C28E RID: 115342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C28E")]
		[Address(RVA = "0x15A3C30", Offset = "0x15A2830", VA = "0x1815A3C30", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601C28F RID: 115343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C28F")]
		[Address(RVA = "0x15A3640", Offset = "0x15A2240", VA = "0x1815A3640", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601C290 RID: 115344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C290")]
		[Address(RVA = "0x15A49D0", Offset = "0x15A35D0", VA = "0x1815A49D0")]
		public StoryReviewEntryState()
		{
		}

		// Token: 0x0601C295 RID: 115349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C295")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C296 RID: 115350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C296")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601C297 RID: 115351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C297")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C298 RID: 115352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C298")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601C299 RID: 115353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C299")]
		[Address(RVA = "0x15A4170", Offset = "0x15A2D70", VA = "0x1815A4170")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601C29A RID: 115354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C29A")]
		[Address(RVA = "0x15A4200", Offset = "0x15A2E00", VA = "0x1815A4200")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0601C29B RID: 115355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C29B")]
		[Address(RVA = "0x15A41A0", Offset = "0x15A2DA0", VA = "0x1815A41A0")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x04024CEC RID: 150764
		[Token(Token = "0x4024CEC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topmenuHolder;

		// Token: 0x04024CED RID: 150765
		[Token(Token = "0x4024CED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StoryReviewEntryView _entryView;

		// Token: 0x04024CEE RID: 150766
		[Token(Token = "0x4024CEE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _avtivityNewTip;

		// Token: 0x04024CEF RID: 150767
		[Token(Token = "0x4024CEF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _miniNewTip;

		// Token: 0x04024CF0 RID: 150768
		[Token(Token = "0x4024CF0")]
		[FieldOffset(Offset = "0x90")]
		private StoryReviewStateBean m_stateBean;

		// Token: 0x04024CF1 RID: 150769
		[Token(Token = "0x4024CF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024CF2 RID: 150770
		[Token(Token = "0x4024CF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024CF3 RID: 150771
		[Token(Token = "0x4024CF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04024CF4 RID: 150772
		[Token(Token = "0x4024CF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04024CF5 RID: 150773
		[Token(Token = "0x4024CF5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitNewTip;

		// Token: 0x04024CF6 RID: 150774
		[Token(Token = "0x4024CF6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckRewardsAvailable;

		// Token: 0x04024CF7 RID: 150775
		[Token(Token = "0x4024CF7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckStoryAvailable;

		// Token: 0x04024CF8 RID: 150776
		[Token(Token = "0x4024CF8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToActivityStoryState;

		// Token: 0x04024CF9 RID: 150777
		[Token(Token = "0x4024CF9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToMiniStoryState;

		// Token: 0x04024CFA RID: 150778
		[Token(Token = "0x4024CFA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnActivityReviewClicked;

		// Token: 0x04024CFB RID: 150779
		[Token(Token = "0x4024CFB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnMiniReviewClicked;

		// Token: 0x04024CFC RID: 150780
		[Token(Token = "0x4024CFC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04024CFD RID: 150781
		[Token(Token = "0x4024CFD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04024CFE RID: 150782
		[Token(Token = "0x4024CFE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04024CFF RID: 150783
		[Token(Token = "0x4024CFF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04024D00 RID: 150784
		[Token(Token = "0x4024D00")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
