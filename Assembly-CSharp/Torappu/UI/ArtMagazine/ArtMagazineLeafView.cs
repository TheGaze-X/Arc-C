using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065BE RID: 26046
	[Token(Token = "0x20065BE")]
	[ExecuteInEditMode]
	public class ArtMagazineLeafView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700588B RID: 22667
		// (set) Token: 0x060256E5 RID: 153317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700588B")]
		public ArtMagazineLeafElementViewHolderBase leafElementViewHolderPrefab
		{
			[Token(Token = "0x60256E5")]
			[Address(RVA = "0x206B960", Offset = "0x206A560", VA = "0x18206B960")]
			set
			{
			}
		}

		// Token: 0x1700588C RID: 22668
		// (set) Token: 0x060256E6 RID: 153318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700588C")]
		public ArtMagazineLeafDecoBkgViewBase leafDecoBkgViewPrefab
		{
			[Token(Token = "0x60256E6")]
			[Address(RVA = "0x206B8E0", Offset = "0x206A4E0", VA = "0x18206B8E0")]
			set
			{
			}
		}

		// Token: 0x1700588D RID: 22669
		// (set) Token: 0x060256E7 RID: 153319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700588D")]
		public ArtMagazineLeafCharIllustBkgView charIllustBkgViewPrefab
		{
			[Token(Token = "0x60256E7")]
			[Address(RVA = "0x206B860", Offset = "0x206A460", VA = "0x18206B860")]
			set
			{
			}
		}

		// Token: 0x1700588E RID: 22670
		// (get) Token: 0x060256E8 RID: 153320 RVA: 0x000C7E48 File Offset: 0x000C6048
		[Token(Token = "0x1700588E")]
		public bool isReadyForSaving
		{
			[Token(Token = "0x60256E8")]
			[Address(RVA = "0x206B620", Offset = "0x206A220", VA = "0x18206B620")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060256E9 RID: 153321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256E9")]
		[Address(RVA = "0x206B2B0", Offset = "0x2069EB0", VA = "0x18206B2B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060256EA RID: 153322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256EA")]
		[Address(RVA = "0x206A950", Offset = "0x2069550", VA = "0x18206A950")]
		public void GenLeafTransformData(ref ArtMagazineLeafView.LeafTransformData leafTransformData)
		{
		}

		// Token: 0x060256EB RID: 153323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256EB")]
		[Address(RVA = "0x206AD80", Offset = "0x2069980", VA = "0x18206AD80")]
		public void OnScaleChanged(float scale)
		{
		}

		// Token: 0x060256EC RID: 153324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256EC")]
		[Address(RVA = "0x206AFC0", Offset = "0x2069BC0", VA = "0x18206AFC0")]
		public void Render(ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060256ED RID: 153325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256ED")]
		[Address(RVA = "0x206B5C0", Offset = "0x206A1C0", VA = "0x18206B5C0")]
		public ArtMagazineLeafView()
		{
		}

		// Token: 0x04034882 RID: 215170
		[Token(Token = "0x4034882")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bkg;

		// Token: 0x04034883 RID: 215171
		[Token(Token = "0x4034883")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _charIllustBkgContainer;

		// Token: 0x04034884 RID: 215172
		[Token(Token = "0x4034884")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _decoBkgContainer;

		// Token: 0x04034885 RID: 215173
		[Token(Token = "0x4034885")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _decoContainer;

		// Token: 0x04034886 RID: 215174
		[Token(Token = "0x4034886")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _bottomBarContainer;

		// Token: 0x04034887 RID: 215175
		[Token(Token = "0x4034887")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x04034888 RID: 215176
		[Token(Token = "0x4034888")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034889 RID: 215177
		[Token(Token = "0x4034889")]
		[FieldOffset(Offset = "0x58")]
		private ArtMagazineLeafBottomBar m_bottomBar;

		// Token: 0x0403488A RID: 215178
		[Token(Token = "0x403488A")]
		[FieldOffset(Offset = "0x60")]
		private ArtMagazineLeafViewModelBase m_cachedViewModel;

		// Token: 0x0403488B RID: 215179
		[Token(Token = "0x403488B")]
		[FieldOffset(Offset = "0x68")]
		private ArtMagazineLeafView.LeafElementGroup m_leafElementGroup;

		// Token: 0x0403488C RID: 215180
		[Token(Token = "0x403488C")]
		[FieldOffset(Offset = "0x70")]
		private ArtMagazineLeafElementViewHolderBase m_leafElementViewHolderPrefab;

		// Token: 0x0403488D RID: 215181
		[Token(Token = "0x403488D")]
		[FieldOffset(Offset = "0x78")]
		private ArtMagazineLeafDecoBkgViewBase m_leafDecoBkgViewPrefab;

		// Token: 0x0403488E RID: 215182
		[Token(Token = "0x403488E")]
		[FieldOffset(Offset = "0x80")]
		private ArtMagazineLeafDecoBkgViewBase m_decoBkgView;

		// Token: 0x0403488F RID: 215183
		[Token(Token = "0x403488F")]
		[FieldOffset(Offset = "0x88")]
		private ArtMagazineLeafCharIllustBkgView m_charIllustBkgViewPrefab;

		// Token: 0x04034890 RID: 215184
		[Token(Token = "0x4034890")]
		[FieldOffset(Offset = "0x90")]
		private ArtMagazineLeafCharIllustBkgView m_charIllustBkgView;

		// Token: 0x04034891 RID: 215185
		[Token(Token = "0x4034891")]
		[FieldOffset(Offset = "0x98")]
		private float m_cachedScale;

		// Token: 0x04034892 RID: 215186
		[Token(Token = "0x4034892")]
		[FieldOffset(Offset = "0x9C")]
		private int m_cachedLoadDataSeqNum;

		// Token: 0x04034893 RID: 215187
		[Token(Token = "0x4034893")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_leafElementViewHolderPrefab;

		// Token: 0x04034894 RID: 215188
		[Token(Token = "0x4034894")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_leafDecoBkgViewPrefab;

		// Token: 0x04034895 RID: 215189
		[Token(Token = "0x4034895")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_charIllustBkgViewPrefab;

		// Token: 0x04034896 RID: 215190
		[Token(Token = "0x4034896")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isReadyForSaving;

		// Token: 0x04034897 RID: 215191
		[Token(Token = "0x4034897")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034898 RID: 215192
		[Token(Token = "0x4034898")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenLeafTransformData;

		// Token: 0x04034899 RID: 215193
		[Token(Token = "0x4034899")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnScaleChanged;

		// Token: 0x0403489A RID: 215194
		[Token(Token = "0x403489A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403489B RID: 215195
		[Token(Token = "0x403489B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065BF RID: 26047
		[Token(Token = "0x20065BF")]
		public struct LeafItemTransformData
		{
			// Token: 0x0403489C RID: 215196
			[Token(Token = "0x403489C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ArtMagazineLeafView.LeafItemTransformData EMPTY;

			// Token: 0x0403489D RID: 215197
			[Token(Token = "0x403489D")]
			[FieldOffset(Offset = "0x0")]
			public string itemId;

			// Token: 0x0403489E RID: 215198
			[Token(Token = "0x403489E")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 anchoredPosition;

			// Token: 0x0403489F RID: 215199
			[Token(Token = "0x403489F")]
			[FieldOffset(Offset = "0x10")]
			public float scale;
		}

		// Token: 0x020065C0 RID: 26048
		[Token(Token = "0x20065C0")]
		public struct LeafTransformData
		{
			// Token: 0x060256EF RID: 153327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60256EF")]
			[Address(RVA = "0x206CCC0", Offset = "0x206B8C0", VA = "0x18206CCC0")]
			public void Clear()
			{
			}

			// Token: 0x040348A0 RID: 215200
			[Token(Token = "0x40348A0")]
			[FieldOffset(Offset = "0x0")]
			public string leafId;

			// Token: 0x040348A1 RID: 215201
			[Token(Token = "0x40348A1")]
			[FieldOffset(Offset = "0x8")]
			public ArtMagazineLeafView.LeafItemTransformData charSkinTransformData;

			// Token: 0x040348A2 RID: 215202
			[Token(Token = "0x40348A2")]
			[FieldOffset(Offset = "0x20")]
			public ValueTypeList<ArtMagazineLeafView.LeafItemTransformData> leafElementTransformData;
		}

		// Token: 0x020065C1 RID: 26049
		[Token(Token = "0x20065C1")]
		private class LeafElementGroup : IHotfixable
		{
			// Token: 0x060256F0 RID: 153328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60256F0")]
			[Address(RVA = "0x206CBF0", Offset = "0x206B7F0", VA = "0x18206CBF0")]
			public LeafElementGroup(ArtMagazineLeafView closure)
			{
			}

			// Token: 0x060256F1 RID: 153329 RVA: 0x000C7E60 File Offset: 0x000C6060
			[Token(Token = "0x60256F1")]
			[Address(RVA = "0x206C7B0", Offset = "0x206B3B0", VA = "0x18206C7B0")]
			private bool _ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x060256F2 RID: 153330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60256F2")]
			[Address(RVA = "0x206CA50", Offset = "0x206B650", VA = "0x18206CA50")]
			private IEnumerable<string> _IterKeys()
			{
				return null;
			}

			// Token: 0x060256F3 RID: 153331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60256F3")]
			[Address(RVA = "0x206C8A0", Offset = "0x206B4A0", VA = "0x18206C8A0")]
			private void _Instantiate(string key, ArtMagazineLeafElementViewModel leafElementViewModel)
			{
			}

			// Token: 0x060256F4 RID: 153332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60256F4")]
			[Address(RVA = "0x206CB00", Offset = "0x206B700", VA = "0x18206CB00")]
			private void _Render(string key, ArtMagazineLeafElementViewHolderBase leafElement)
			{
			}

			// Token: 0x060256F5 RID: 153333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60256F5")]
			[Address(RVA = "0x206BC40", Offset = "0x206A840", VA = "0x18206BC40")]
			public void OnDataChanged(bool isInit)
			{
			}

			// Token: 0x060256F6 RID: 153334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60256F6")]
			[Address(RVA = "0x206BB90", Offset = "0x206A790", VA = "0x18206BB90")]
			public IEnumerable<ArtMagazineLeafElementViewHolderBase> IterAllLeafElements()
			{
				return null;
			}

			// Token: 0x040348A3 RID: 215203
			[Token(Token = "0x40348A3")]
			[FieldOffset(Offset = "0x10")]
			private ArtMagazineLeafView m_closure;

			// Token: 0x040348A4 RID: 215204
			[Token(Token = "0x40348A4")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, ArtMagazineLeafElementViewHolderBase> m_leafElements;

			// Token: 0x040348A5 RID: 215205
			[Token(Token = "0x40348A5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040348A6 RID: 215206
			[Token(Token = "0x40348A6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__ContainsKey;

			// Token: 0x040348A7 RID: 215207
			[Token(Token = "0x40348A7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__IterKeys;

			// Token: 0x040348A8 RID: 215208
			[Token(Token = "0x40348A8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__Instantiate;

			// Token: 0x040348A9 RID: 215209
			[Token(Token = "0x40348A9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__Render;

			// Token: 0x040348AA RID: 215210
			[Token(Token = "0x40348AA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnDataChanged;

			// Token: 0x040348AB RID: 215211
			[Token(Token = "0x40348AB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_IterAllLeafElements;
		}
	}
}
