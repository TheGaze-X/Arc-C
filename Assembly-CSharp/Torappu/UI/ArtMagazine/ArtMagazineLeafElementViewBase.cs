using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B7 RID: 26039
	[Token(Token = "0x20065B7")]
	public abstract class ArtMagazineLeafElementViewBase : MonoBehaviour, IAsyncDataView<ArtMagazineLeafElementViewHolderBase.Data>, IAsyncShowEffect, IHotfixable
	{
		// Token: 0x1700587E RID: 22654
		// (get) Token: 0x060256BA RID: 153274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700587E")]
		protected string itemId
		{
			[Token(Token = "0x60256BA")]
			[Address(RVA = "0x2066ED0", Offset = "0x2065AD0", VA = "0x182066ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700587F RID: 22655
		// (get) Token: 0x060256BB RID: 153275 RVA: 0x000C7D70 File Offset: 0x000C5F70
		[Token(Token = "0x1700587F")]
		public Vector2 standardSizeDelta
		{
			[Token(Token = "0x60256BB")]
			[Address(RVA = "0x2066FF0", Offset = "0x2065BF0", VA = "0x182066FF0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17005880 RID: 22656
		// (get) Token: 0x060256BC RID: 153276 RVA: 0x000C7D88 File Offset: 0x000C5F88
		[Token(Token = "0x17005880")]
		public bool isReadyForSaving
		{
			[Token(Token = "0x60256BC")]
			[Address(RVA = "0x2066E70", Offset = "0x2065A70", VA = "0x182066E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005881 RID: 22657
		// (get) Token: 0x060256BD RID: 153277 RVA: 0x000C7DA0 File Offset: 0x000C5FA0
		// (set) Token: 0x060256BE RID: 153278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005881")]
		public float parentScale
		{
			[Token(Token = "0x60256BD")]
			[Address(RVA = "0x2066F90", Offset = "0x2065B90", VA = "0x182066F90")]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x60256BE")]
			[Address(RVA = "0x2067140", Offset = "0x2065D40", VA = "0x182067140")]
			set
			{
			}
		}

		// Token: 0x17005882 RID: 22658
		// (get) Token: 0x060256BF RID: 153279 RVA: 0x000C7DB8 File Offset: 0x000C5FB8
		// (set) Token: 0x060256C0 RID: 153280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005882")]
		public float localScale
		{
			[Token(Token = "0x60256BF")]
			[Address(RVA = "0x2066F30", Offset = "0x2065B30", VA = "0x182066F30")]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x60256C0")]
			[Address(RVA = "0x2067060", Offset = "0x2065C60", VA = "0x182067060")]
			set
			{
			}
		}

		// Token: 0x060256C1 RID: 153281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256C1")]
		[Address(RVA = "0x2066BB0", Offset = "0x20657B0", VA = "0x182066BB0", Slot = "6")]
		protected virtual void OnScaleChanged()
		{
		}

		// Token: 0x060256C2 RID: 153282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256C2")]
		[Address(RVA = "0x2066C10", Offset = "0x2065810", VA = "0x182066C10", Slot = "7")]
		protected virtual void Render(ArtMagazineLeafElementViewModel elementViewModel, ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060256C3 RID: 153283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256C3")]
		[Address(RVA = "0x20669C0", Offset = "0x20655C0", VA = "0x1820669C0", Slot = "4")]
		public void AsyncSetData(ArtMagazineLeafElementViewHolderBase.Data data)
		{
		}

		// Token: 0x060256C4 RID: 153284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256C4")]
		[Address(RVA = "0x2066A70", Offset = "0x2065670", VA = "0x182066A70", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x060256C5 RID: 153285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256C5")]
		[Address(RVA = "0x2066E00", Offset = "0x2065A00", VA = "0x182066E00")]
		protected ArtMagazineLeafElementViewBase()
		{
		}

		// Token: 0x04034846 RID: 215110
		[Token(Token = "0x4034846")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgElement;

		// Token: 0x04034847 RID: 215111
		[Token(Token = "0x4034847")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04034848 RID: 215112
		[Token(Token = "0x4034848")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedItemId;

		// Token: 0x04034849 RID: 215113
		[Token(Token = "0x4034849")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedTemplateId;

		// Token: 0x0403484A RID: 215114
		[Token(Token = "0x403484A")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403484B RID: 215115
		[Token(Token = "0x403484B")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_showTween;

		// Token: 0x0403484C RID: 215116
		[Token(Token = "0x403484C")]
		[FieldOffset(Offset = "0x50")]
		private float m_parentScale;

		// Token: 0x0403484D RID: 215117
		[Token(Token = "0x403484D")]
		[FieldOffset(Offset = "0x54")]
		private float m_localScale;

		// Token: 0x0403484E RID: 215118
		[Token(Token = "0x403484E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isShown;

		// Token: 0x0403484F RID: 215119
		[Token(Token = "0x403484F")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 m_standardSizeDelta;

		// Token: 0x04034850 RID: 215120
		[Token(Token = "0x4034850")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04034851 RID: 215121
		[Token(Token = "0x4034851")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_standardSizeDelta;

		// Token: 0x04034852 RID: 215122
		[Token(Token = "0x4034852")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReadyForSaving;

		// Token: 0x04034853 RID: 215123
		[Token(Token = "0x4034853")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_parentScale;

		// Token: 0x04034854 RID: 215124
		[Token(Token = "0x4034854")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_parentScale;

		// Token: 0x04034855 RID: 215125
		[Token(Token = "0x4034855")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_localScale;

		// Token: 0x04034856 RID: 215126
		[Token(Token = "0x4034856")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_localScale;

		// Token: 0x04034857 RID: 215127
		[Token(Token = "0x4034857")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnScaleChanged;

		// Token: 0x04034858 RID: 215128
		[Token(Token = "0x4034858")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034859 RID: 215129
		[Token(Token = "0x4034859")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0403485A RID: 215130
		[Token(Token = "0x403485A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x0403485B RID: 215131
		[Token(Token = "0x403485B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
