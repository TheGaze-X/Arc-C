using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034E4 RID: 13540
	[Token(Token = "0x20034E4")]
	public class UICharacterSortFilterState : PopupFloatState
	{
		// Token: 0x0601593D RID: 88381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601593D")]
		[Address(RVA = "0xE0F210", Offset = "0xE0DE10", VA = "0x180E0F210", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601593E RID: 88382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601593E")]
		[Address(RVA = "0xE0F4F0", Offset = "0xE0E0F0", VA = "0x180E0F4F0")]
		private void Start()
		{
		}

		// Token: 0x0601593F RID: 88383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601593F")]
		[Address(RVA = "0xE0F450", Offset = "0xE0E050", VA = "0x180E0F450", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06015940 RID: 88384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015940")]
		[Address(RVA = "0xE0F270", Offset = "0xE0DE70", VA = "0x180E0F270")]
		public void OnBackgroundClicked()
		{
		}

		// Token: 0x06015941 RID: 88385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015941")]
		[Address(RVA = "0xE0F370", Offset = "0xE0DF70", VA = "0x180E0F370")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x06015942 RID: 88386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015942")]
		[Address(RVA = "0xE0F2F0", Offset = "0xE0DEF0", VA = "0x180E0F2F0")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x06015943 RID: 88387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015943")]
		[Address(RVA = "0xE0F600", Offset = "0xE0E200", VA = "0x180E0F600")]
		public UICharacterSortFilterState()
		{
		}

		// Token: 0x06015944 RID: 88388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015944")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04019DF6 RID: 105974
		[Token(Token = "0x4019DF6")]
		private const float ANIMATION_DURATION = 0.3f;

		// Token: 0x04019DF7 RID: 105975
		[Token(Token = "0x4019DF7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICharacterSortFilterStateBean _stateBean;

		// Token: 0x04019DF8 RID: 105976
		[Token(Token = "0x4019DF8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("the sort panel")]
		private UICharacterSortGroupOnFloat _sortGroup;

		// Token: 0x04019DF9 RID: 105977
		[Token(Token = "0x4019DF9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("the filter panel")]
		private UICharacterFilterGroupOnFloat _filterGroup;

		// Token: 0x04019DFA RID: 105978
		[Token(Token = "0x4019DFA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _btnFilterCancelTrans;

		// Token: 0x04019DFB RID: 105979
		[Token(Token = "0x4019DFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04019DFC RID: 105980
		[Token(Token = "0x4019DFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04019DFD RID: 105981
		[Token(Token = "0x4019DFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04019DFE RID: 105982
		[Token(Token = "0x4019DFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackgroundClicked;

		// Token: 0x04019DFF RID: 105983
		[Token(Token = "0x4019DFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x04019E00 RID: 105984
		[Token(Token = "0x4019E00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x04019E01 RID: 105985
		[Token(Token = "0x4019E01")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
