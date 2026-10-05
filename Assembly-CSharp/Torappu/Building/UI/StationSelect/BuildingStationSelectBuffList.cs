using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C79 RID: 7289
	[Token(Token = "0x2001C79")]
	public class BuildingStationSelectBuffList : DataBinder<StationCharGroupProperty>
	{
		// Token: 0x0600B51B RID: 46363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51B")]
		[Address(RVA = "0x32ED410", Offset = "0x32EC010", VA = "0x1832ED410")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51C")]
		[Address(RVA = "0x32ED510", Offset = "0x32EC110", VA = "0x1832ED510", Slot = "7")]
		public override void OnValueChanged(StationCharGroupProperty property)
		{
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51D")]
		[Address(RVA = "0x32ED820", Offset = "0x32EC420", VA = "0x1832ED820")]
		private void _Init()
		{
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B51E")]
		[Address(RVA = "0x32EDAB0", Offset = "0x32EC6B0", VA = "0x1832EDAB0")]
		private IEnumerator _UpdateBuffLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B51F")]
		[Address(RVA = "0x32EDB60", Offset = "0x32EC760", VA = "0x1832EDB60")]
		private IEnumerator _UpdateEmptyPaddingCoroutine()
		{
			return null;
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B520")]
		[Address(RVA = "0x32ED940", Offset = "0x32EC540", VA = "0x1832ED940")]
		private void _OnBuffNextLevelButtonClicked(BuildingBuffDescView buffView)
		{
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B521")]
		[Address(RVA = "0x32EDC10", Offset = "0x32EC810", VA = "0x1832EDC10")]
		public BuildingStationSelectBuffList()
		{
		}

		// Token: 0x0400B125 RID: 45349
		[Token(Token = "0x400B125")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _buffLayout;

		// Token: 0x0400B126 RID: 45350
		[Token(Token = "0x400B126")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelPadding;

		// Token: 0x0400B127 RID: 45351
		[Token(Token = "0x400B127")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelBound;

		// Token: 0x0400B128 RID: 45352
		[Token(Token = "0x400B128")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0400B129 RID: 45353
		[Token(Token = "0x400B129")]
		[FieldOffset(Offset = "0x40")]
		private BuildingStationSelectBuffList.BuffAdapter m_buffAdapter;

		// Token: 0x0400B12A RID: 45354
		[Token(Token = "0x400B12A")]
		[FieldOffset(Offset = "0x48")]
		private List<BuildingBuffDescStruct> m_buffList;

		// Token: 0x0400B12B RID: 45355
		[Token(Token = "0x400B12B")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0400B12C RID: 45356
		[Token(Token = "0x400B12C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400B12D RID: 45357
		[Token(Token = "0x400B12D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B12E RID: 45358
		[Token(Token = "0x400B12E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400B12F RID: 45359
		[Token(Token = "0x400B12F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateBuffLayoutCoroutine;

		// Token: 0x0400B130 RID: 45360
		[Token(Token = "0x400B130")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateEmptyPaddingCoroutine;

		// Token: 0x0400B131 RID: 45361
		[Token(Token = "0x400B131")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBuffNextLevelButtonClicked;

		// Token: 0x0400B132 RID: 45362
		[Token(Token = "0x400B132")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C7A RID: 7290
		[Token(Token = "0x2001C7A")]
		private class BuffAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B522 RID: 46370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B522")]
			[Address(RVA = "0x32EBD90", Offset = "0x32EA990", VA = "0x1832EBD90")]
			public BuffAdapter(BuildingStationSelectBuffList closure)
			{
			}

			// Token: 0x170015C8 RID: 5576
			// (get) Token: 0x0600B523 RID: 46371 RVA: 0x00044BF8 File Offset: 0x00042DF8
			[Token(Token = "0x170015C8")]
			public override int count
			{
				[Token(Token = "0x600B523")]
				[Address(RVA = "0x32EBE10", Offset = "0x32EAA10", VA = "0x1832EBE10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B524 RID: 46372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B524")]
			[Address(RVA = "0x32EBA30", Offset = "0x32EA630", VA = "0x1832EBA30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B133 RID: 45363
			[Token(Token = "0x400B133")]
			[FieldOffset(Offset = "0x20")]
			private BuildingStationSelectBuffList m_closure;

			// Token: 0x0400B134 RID: 45364
			[Token(Token = "0x400B134")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B135 RID: 45365
			[Token(Token = "0x400B135")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B136 RID: 45366
			[Token(Token = "0x400B136")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
