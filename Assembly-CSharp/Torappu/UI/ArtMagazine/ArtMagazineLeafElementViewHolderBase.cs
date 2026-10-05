using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B9 RID: 26041
	[Token(Token = "0x20065B9")]
	public abstract class ArtMagazineLeafElementViewHolderBase : MonoBehaviour, IAsyncObjectListener, IHotfixable
	{
		// Token: 0x17005883 RID: 22659
		// (get) Token: 0x060256C8 RID: 153288 RVA: 0x000C7DD0 File Offset: 0x000C5FD0
		[Token(Token = "0x17005883")]
		protected UIPageFinder pageFinder
		{
			[Token(Token = "0x60256C8")]
			[Address(RVA = "0x20680D0", Offset = "0x2066CD0", VA = "0x1820680D0")]
			get
			{
				return default(UIPageFinder);
			}
		}

		// Token: 0x17005884 RID: 22660
		// (get) Token: 0x060256C9 RID: 153289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005884")]
		protected ArtMagazineLeafElementViewBase leafElementViewObj
		{
			[Token(Token = "0x60256C9")]
			[Address(RVA = "0x2068070", Offset = "0x2066C70", VA = "0x182068070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005885 RID: 22661
		// (get) Token: 0x060256CA RID: 153290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005885")]
		public string key
		{
			[Token(Token = "0x60256CA")]
			[Address(RVA = "0x2067F30", Offset = "0x2066B30", VA = "0x182067F30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060256CB RID: 153291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60256CB")]
		[Address(RVA = "0x2067C50", Offset = "0x2066850", VA = "0x182067C50")]
		private RectTransform _GetValidRectTransform()
		{
			return null;
		}

		// Token: 0x17005886 RID: 22662
		// (get) Token: 0x060256CC RID: 153292 RVA: 0x000C7DE8 File Offset: 0x000C5FE8
		// (set) Token: 0x060256CD RID: 153293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005886")]
		public Vector2 anchoredPosition
		{
			[Token(Token = "0x60256CC")]
			[Address(RVA = "0x2067DE0", Offset = "0x20669E0", VA = "0x182067DE0", Slot = "6")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60256CD")]
			[Address(RVA = "0x20682F0", Offset = "0x2066EF0", VA = "0x1820682F0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17005887 RID: 22663
		// (get) Token: 0x060256CE RID: 153294 RVA: 0x000C7E00 File Offset: 0x000C6000
		// (set) Token: 0x060256CF RID: 153295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005887")]
		public float scale
		{
			[Token(Token = "0x60256CE")]
			[Address(RVA = "0x2068150", Offset = "0x2066D50", VA = "0x182068150", Slot = "8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60256CF")]
			[Address(RVA = "0x20684E0", Offset = "0x20670E0", VA = "0x1820684E0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17005888 RID: 22664
		// (get) Token: 0x060256D0 RID: 153296 RVA: 0x000C7E18 File Offset: 0x000C6018
		[Token(Token = "0x17005888")]
		public Vector2 standardSizeDelta
		{
			[Token(Token = "0x60256D0")]
			[Address(RVA = "0x20681D0", Offset = "0x2066DD0", VA = "0x1820681D0", Slot = "10")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17005889 RID: 22665
		// (set) Token: 0x060256D1 RID: 153297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005889")]
		public float parentScale
		{
			[Token(Token = "0x60256D1")]
			[Address(RVA = "0x2068410", Offset = "0x2067010", VA = "0x182068410")]
			set
			{
			}
		}

		// Token: 0x1700588A RID: 22666
		// (get) Token: 0x060256D2 RID: 153298 RVA: 0x000C7E30 File Offset: 0x000C6030
		[Token(Token = "0x1700588A")]
		public bool isReadyForSaving
		{
			[Token(Token = "0x60256D2")]
			[Address(RVA = "0x2067E90", Offset = "0x2066A90", VA = "0x182067E90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060256D3 RID: 153299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256D3")]
		[Address(RVA = "0x2067460", Offset = "0x2066060", VA = "0x182067460")]
		public void InitElementViewHolder(int leafViewInstId, int index)
		{
		}

		// Token: 0x060256D4 RID: 153300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256D4")]
		[Address(RVA = "0x2067220", Offset = "0x2065E20", VA = "0x182067220")]
		public void DestroyElementViewHolder()
		{
		}

		// Token: 0x060256D5 RID: 153301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256D5")]
		[Address(RVA = "0x2067710", Offset = "0x2066310", VA = "0x182067710", Slot = "4")]
		public void OnGameObjectLoaded(GameObject gameObject)
		{
		}

		// Token: 0x060256D6 RID: 153302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256D6")]
		[Address(RVA = "0x2067290", Offset = "0x2065E90", VA = "0x182067290")]
		public void GenLeafTransformData(ref ArtMagazineLeafView.LeafTransformData leafTransformData)
		{
		}

		// Token: 0x060256D7 RID: 153303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256D7")]
		[Address(RVA = "0x20678D0", Offset = "0x20664D0", VA = "0x1820678D0", Slot = "11")]
		public virtual void Render(ArtMagazineLeafElementViewModel viewModel, ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060256D8 RID: 153304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256D8")]
		[Address(RVA = "0x2067820", Offset = "0x2066420", VA = "0x182067820", Slot = "12")]
		protected virtual void OnLeafElementViewLoaded(ArtMagazineLeafElementViewBase leafElementView)
		{
		}

		// Token: 0x060256D9 RID: 153305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256D9")]
		[Address(RVA = "0x2067D30", Offset = "0x2066930", VA = "0x182067D30")]
		protected ArtMagazineLeafElementViewHolderBase()
		{
		}

		// Token: 0x0403485D RID: 215133
		[Token(Token = "0x403485D")]
		private const uint PER_OBJ_COST = 1U;

		// Token: 0x0403485E RID: 215134
		[Token(Token = "0x403485E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtMagazineLeafElementViewBase _leafElementViewPrefab;

		// Token: 0x0403485F RID: 215135
		[Token(Token = "0x403485F")]
		[FieldOffset(Offset = "0x20")]
		private AsyncDataViewHandler<ArtMagazineLeafElementViewBase, ArtMagazineLeafElementViewHolderBase.Data> m_handler;

		// Token: 0x04034860 RID: 215136
		[Token(Token = "0x4034860")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034861 RID: 215137
		[Token(Token = "0x4034861")]
		[FieldOffset(Offset = "0x38")]
		private ArtMagazineLeafElementViewHolderBase.Data m_data;

		// Token: 0x04034862 RID: 215138
		[Token(Token = "0x4034862")]
		[FieldOffset(Offset = "0x40")]
		private ArtMagazineLeafElementViewBase m_leafElementViewObj;

		// Token: 0x04034863 RID: 215139
		[Token(Token = "0x4034863")]
		[FieldOffset(Offset = "0x48")]
		private float m_cachedParentScale;

		// Token: 0x04034864 RID: 215140
		[Token(Token = "0x4034864")]
		[FieldOffset(Offset = "0x4C")]
		private int m_cachedLoadDataSeqNum;

		// Token: 0x04034865 RID: 215141
		[Token(Token = "0x4034865")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageFinder;

		// Token: 0x04034866 RID: 215142
		[Token(Token = "0x4034866")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_leafElementViewObj;

		// Token: 0x04034867 RID: 215143
		[Token(Token = "0x4034867")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_key;

		// Token: 0x04034868 RID: 215144
		[Token(Token = "0x4034868")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetValidRectTransform;

		// Token: 0x04034869 RID: 215145
		[Token(Token = "0x4034869")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_anchoredPosition;

		// Token: 0x0403486A RID: 215146
		[Token(Token = "0x403486A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_anchoredPosition;

		// Token: 0x0403486B RID: 215147
		[Token(Token = "0x403486B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_scale;

		// Token: 0x0403486C RID: 215148
		[Token(Token = "0x403486C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_scale;

		// Token: 0x0403486D RID: 215149
		[Token(Token = "0x403486D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_standardSizeDelta;

		// Token: 0x0403486E RID: 215150
		[Token(Token = "0x403486E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_parentScale;

		// Token: 0x0403486F RID: 215151
		[Token(Token = "0x403486F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isReadyForSaving;

		// Token: 0x04034870 RID: 215152
		[Token(Token = "0x4034870")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_InitElementViewHolder;

		// Token: 0x04034871 RID: 215153
		[Token(Token = "0x4034871")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DestroyElementViewHolder;

		// Token: 0x04034872 RID: 215154
		[Token(Token = "0x4034872")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnGameObjectLoaded;

		// Token: 0x04034873 RID: 215155
		[Token(Token = "0x4034873")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GenLeafTransformData;

		// Token: 0x04034874 RID: 215156
		[Token(Token = "0x4034874")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034875 RID: 215157
		[Token(Token = "0x4034875")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnLeafElementViewLoaded;

		// Token: 0x04034876 RID: 215158
		[Token(Token = "0x4034876")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065BA RID: 26042
		[Token(Token = "0x20065BA")]
		public class Data
		{
			// Token: 0x060256DA RID: 153306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60256DA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Data()
			{
			}

			// Token: 0x04034877 RID: 215159
			[Token(Token = "0x4034877")]
			[FieldOffset(Offset = "0x10")]
			public ArtMagazineLeafViewModelBase leafData;

			// Token: 0x04034878 RID: 215160
			[Token(Token = "0x4034878")]
			[FieldOffset(Offset = "0x18")]
			public ArtMagazineLeafElementViewModel data;
		}
	}
}
