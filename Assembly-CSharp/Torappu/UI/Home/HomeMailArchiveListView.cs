using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C3E RID: 19518
	[Token(Token = "0x2004C3E")]
	public class HomeMailArchiveListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D4D7 RID: 120023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D7")]
		[Address(RVA = "0x16D1320", Offset = "0x16CFF20", VA = "0x1816D1320")]
		public void Render(HomeMailArchiveViewModel model)
		{
		}

		// Token: 0x0601D4D8 RID: 120024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D8")]
		[Address(RVA = "0x16D12A0", Offset = "0x16CFEA0", VA = "0x1816D12A0")]
		public void FocusListToItem(int index)
		{
		}

		// Token: 0x0601D4D9 RID: 120025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D9")]
		[Address(RVA = "0x16D10A0", Offset = "0x16CFCA0", VA = "0x1816D10A0")]
		public void EventOnScrollValueChanged(Vector2 value)
		{
		}

		// Token: 0x0601D4DA RID: 120026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4DA")]
		[Address(RVA = "0x16D1590", Offset = "0x16D0190", VA = "0x1816D1590")]
		private void _ToBarPosWithReset(int index)
		{
		}

		// Token: 0x0601D4DB RID: 120027 RVA: 0x000AB1F8 File Offset: 0x000A93F8
		[Token(Token = "0x601D4DB")]
		[Address(RVA = "0x16D14F0", Offset = "0x16D00F0", VA = "0x1816D14F0")]
		private static int _CalcIndexFromScrollValue(float val, int totalCount, float countInOnePage)
		{
			return 0;
		}

		// Token: 0x0601D4DC RID: 120028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4DC")]
		[Address(RVA = "0x16D1890", Offset = "0x16D0490", VA = "0x1816D1890")]
		public HomeMailArchiveListView()
		{
		}

		// Token: 0x040268DC RID: 157916
		[Token(Token = "0x40268DC")]
		private const int LIST_NEAR_INDEX_DIST = 10;

		// Token: 0x040268DD RID: 157917
		[Token(Token = "0x40268DD")]
		private const float LIST_ITEM_HEIGHT = 140f;

		// Token: 0x040268DE RID: 157918
		[Token(Token = "0x40268DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x040268DF RID: 157919
		[Token(Token = "0x40268DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x040268E0 RID: 157920
		[Token(Token = "0x40268E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HomeMailArchiveListAdapter _listAdapter;

		// Token: 0x040268E1 RID: 157921
		[Token(Token = "0x40268E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LoopVerticalScrollRect _listScrollRect;

		// Token: 0x040268E2 RID: 157922
		[Token(Token = "0x40268E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HomeMailArchiveBarListAdapter _barAdapter;

		// Token: 0x040268E3 RID: 157923
		[Token(Token = "0x40268E3")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_cacheTween;

		// Token: 0x040268E4 RID: 157924
		[Token(Token = "0x40268E4")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040268E5 RID: 157925
		[Token(Token = "0x40268E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040268E6 RID: 157926
		[Token(Token = "0x40268E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FocusListToItem;

		// Token: 0x040268E7 RID: 157927
		[Token(Token = "0x40268E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnScrollValueChanged;

		// Token: 0x040268E8 RID: 157928
		[Token(Token = "0x40268E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ToBarPosWithReset;

		// Token: 0x040268E9 RID: 157929
		[Token(Token = "0x40268E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CalcIndexFromScrollValue;

		// Token: 0x040268EA RID: 157930
		[Token(Token = "0x40268EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
