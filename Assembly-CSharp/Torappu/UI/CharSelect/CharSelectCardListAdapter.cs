using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E1B RID: 24091
	[Token(Token = "0x2005E1B")]
	public class CharSelectCardListAdapter : UICharacterCardScrollAdapter<CharSelectCardListAdapter.ViewHolder>
	{
		// Token: 0x06022E96 RID: 142998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E96")]
		[Address(RVA = "0x1D65910", Offset = "0x1D64510", VA = "0x181D65910")]
		public void SetParams(CharSelectCardListAdapter.CharSelectParam param, [Optional] UICharacterSelectState.IPlugin plugin)
		{
		}

		// Token: 0x06022E97 RID: 142999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E97")]
		[Address(RVA = "0x1D65A30", Offset = "0x1D64630", VA = "0x181D65A30", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CharSelectCardListAdapter.ViewHolder holder, CharacterCardViewModel data)
		{
		}

		// Token: 0x06022E98 RID: 143000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E98")]
		[Address(RVA = "0x1D65890", Offset = "0x1D64490", VA = "0x181D65890", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x06022E99 RID: 143001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E99")]
		[Address(RVA = "0x1D65730", Offset = "0x1D64330", VA = "0x181D65730")]
		public void NotifyCharChanged(int chrInstId)
		{
		}

		// Token: 0x06022E9A RID: 143002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E9A")]
		[Address(RVA = "0x1D65680", Offset = "0x1D64280", VA = "0x181D65680", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06022E9B RID: 143003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E9B")]
		[Address(RVA = "0x1D66110", Offset = "0x1D64D10", VA = "0x181D66110")]
		private void _TryRegisterAVGFirstItem(CharSelectCardView cardView)
		{
		}

		// Token: 0x06022E9C RID: 143004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E9C")]
		[Address(RVA = "0x1D66240", Offset = "0x1D64E40", VA = "0x181D66240")]
		public CharSelectCardListAdapter()
		{
		}

		// Token: 0x0403015B RID: 196955
		[Token(Token = "0x403015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _cardPrefab;

		// Token: 0x0403015C RID: 196956
		[Token(Token = "0x403015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> m_selectedChrInstIds;

		// Token: 0x0403015D RID: 196957
		[Token(Token = "0x403015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_showSelectOrder;

		// Token: 0x0403015E RID: 196958
		[Token(Token = "0x403015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UICharacterSelectState.IPlugin m_statePlugin;

		// Token: 0x0403015F RID: 196959
		[Token(Token = "0x403015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CharacterSortType m_currentSortType;

		// Token: 0x04030160 RID: 196960
		[Token(Token = "0x4030160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string m_pageName;

		// Token: 0x04030161 RID: 196961
		[Token(Token = "0x4030161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_AVGIsFirstItemRegistered;

		// Token: 0x04030162 RID: 196962
		[Token(Token = "0x4030162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetParams;

		// Token: 0x04030163 RID: 196963
		[Token(Token = "0x4030163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04030164 RID: 196964
		[Token(Token = "0x4030164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x04030165 RID: 196965
		[Token(Token = "0x4030165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyCharChanged;

		// Token: 0x04030166 RID: 196966
		[Token(Token = "0x4030166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04030167 RID: 196967
		[Token(Token = "0x4030167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryRegisterAVGFirstItem;

		// Token: 0x04030168 RID: 196968
		[Token(Token = "0x4030168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E1C RID: 24092
		[Token(Token = "0x2005E1C")]
		public class ViewHolder
		{
			// Token: 0x06022E9D RID: 143005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022E9D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04030169 RID: 196969
			[Token(Token = "0x4030169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CharSelectCardView cardView;
		}

		// Token: 0x02005E1D RID: 24093
		[Token(Token = "0x2005E1D")]
		public struct CharSelectParam
		{
			// Token: 0x0403016A RID: 196970
			[Token(Token = "0x403016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<int> selectedChrInstIds;

			// Token: 0x0403016B RID: 196971
			[Token(Token = "0x403016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool showSelectOrder;

			// Token: 0x0403016C RID: 196972
			[Token(Token = "0x403016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CharacterSortType sortType;

			// Token: 0x0403016D RID: 196973
			[Token(Token = "0x403016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string pageName;
		}
	}
}
