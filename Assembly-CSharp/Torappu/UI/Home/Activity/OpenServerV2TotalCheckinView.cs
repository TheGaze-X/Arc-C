using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C8F RID: 19599
	[Token(Token = "0x2004C8F")]
	public class OpenServerV2TotalCheckinView : OpenServerV2FuncAbstractView
	{
		// Token: 0x0601D60B RID: 120331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D60B")]
		[Address(RVA = "0x16F21D0", Offset = "0x16F0DD0", VA = "0x1816F21D0", Slot = "4")]
		public override void Render(OpenServerV2MainViewModel viewModel, bool isInit)
		{
		}

		// Token: 0x0601D60C RID: 120332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D60C")]
		[Address(RVA = "0x16F28F0", Offset = "0x16F14F0", VA = "0x1816F28F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D60D RID: 120333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D60D")]
		[Address(RVA = "0x16F2C30", Offset = "0x16F1830", VA = "0x1816F2C30")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x0601D60E RID: 120334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D60E")]
		[Address(RVA = "0x16F2AC0", Offset = "0x16F16C0", VA = "0x1816F2AC0")]
		private void _OnCharClick(int index)
		{
		}

		// Token: 0x0601D60F RID: 120335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D60F")]
		[Address(RVA = "0x16F2510", Offset = "0x16F1110", VA = "0x1816F2510")]
		private void _FocusToItem(int targetIndex, int totalCount)
		{
		}

		// Token: 0x0601D610 RID: 120336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D610")]
		[Address(RVA = "0x16F2D30", Offset = "0x16F1930", VA = "0x1816F2D30")]
		public OpenServerV2TotalCheckinView()
		{
		}

		// Token: 0x04026AC8 RID: 158408
		[Token(Token = "0x4026AC8")]
		private const float FOCUS_DURATION = 0.5f;

		// Token: 0x04026AC9 RID: 158409
		[Token(Token = "0x4026AC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x04026ACA RID: 158410
		[Token(Token = "0x4026ACA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemLayoutContent;

		// Token: 0x04026ACB RID: 158411
		[Token(Token = "0x4026ACB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charLayoutContent;

		// Token: 0x04026ACC RID: 158412
		[Token(Token = "0x4026ACC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04026ACD RID: 158413
		[Token(Token = "0x4026ACD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x04026ACE RID: 158414
		[Token(Token = "0x4026ACE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x04026ACF RID: 158415
		[Token(Token = "0x4026ACF")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026AD0 RID: 158416
		[Token(Token = "0x4026AD0")]
		[FieldOffset(Offset = "0x58")]
		private OpenServerV2TotalCheckinViewModel m_viewModel;

		// Token: 0x04026AD1 RID: 158417
		[Token(Token = "0x4026AD1")]
		[FieldOffset(Offset = "0x60")]
		private OpenServerV2TotalCheckinView.CharBlockAdapter m_adapter;

		// Token: 0x04026AD2 RID: 158418
		[Token(Token = "0x4026AD2")]
		[FieldOffset(Offset = "0x68")]
		private OpenServerV2TotalCheckinView.TotalLoginAdapter m_itemAdapter;

		// Token: 0x04026AD3 RID: 158419
		[Token(Token = "0x4026AD3")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04026AD4 RID: 158420
		[Token(Token = "0x4026AD4")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_cachedTween;

		// Token: 0x04026AD5 RID: 158421
		[Token(Token = "0x4026AD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026AD6 RID: 158422
		[Token(Token = "0x4026AD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026AD7 RID: 158423
		[Token(Token = "0x4026AD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04026AD8 RID: 158424
		[Token(Token = "0x4026AD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCharClick;

		// Token: 0x04026AD9 RID: 158425
		[Token(Token = "0x4026AD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FocusToItem;

		// Token: 0x04026ADA RID: 158426
		[Token(Token = "0x4026ADA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C90 RID: 19600
		[Token(Token = "0x2004C90")]
		private class TotalLoginAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D613 RID: 120339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D613")]
			[Address(RVA = "0x16F3DA0", Offset = "0x16F29A0", VA = "0x1816F3DA0")]
			public TotalLoginAdapter(OpenServerV2TotalCheckinView closure)
			{
			}

			// Token: 0x170044ED RID: 17645
			// (get) Token: 0x0601D614 RID: 120340 RVA: 0x000AB4C8 File Offset: 0x000A96C8
			[Token(Token = "0x170044ED")]
			public override int count
			{
				[Token(Token = "0x601D614")]
				[Address(RVA = "0x16F3E20", Offset = "0x16F2A20", VA = "0x1816F3E20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D615 RID: 120341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D615")]
			[Address(RVA = "0x16F3B40", Offset = "0x16F2740", VA = "0x1816F3B40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026ADB RID: 158427
			[Token(Token = "0x4026ADB")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerV2TotalCheckinView m_closure;

			// Token: 0x04026ADC RID: 158428
			[Token(Token = "0x4026ADC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026ADD RID: 158429
			[Token(Token = "0x4026ADD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026ADE RID: 158430
			[Token(Token = "0x4026ADE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004C91 RID: 19601
		[Token(Token = "0x2004C91")]
		private class CharBlockAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D616 RID: 120342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D616")]
			[Address(RVA = "0x16DE280", Offset = "0x16DCE80", VA = "0x1816DE280")]
			public CharBlockAdapter(OpenServerV2TotalCheckinView closure)
			{
			}

			// Token: 0x170044EE RID: 17646
			// (get) Token: 0x0601D617 RID: 120343 RVA: 0x000AB4E0 File Offset: 0x000A96E0
			[Token(Token = "0x170044EE")]
			public override int count
			{
				[Token(Token = "0x601D617")]
				[Address(RVA = "0x16DE380", Offset = "0x16DCF80", VA = "0x1816DE380", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D618 RID: 120344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D618")]
			[Address(RVA = "0x16DE0C0", Offset = "0x16DCCC0", VA = "0x1816DE0C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026ADF RID: 158431
			[Token(Token = "0x4026ADF")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerV2TotalCheckinView m_closure;

			// Token: 0x04026AE0 RID: 158432
			[Token(Token = "0x4026AE0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026AE1 RID: 158433
			[Token(Token = "0x4026AE1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026AE2 RID: 158434
			[Token(Token = "0x4026AE2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004C92 RID: 19602
		[Token(Token = "0x2004C92")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0601D619 RID: 120345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D619")]
			[Address(RVA = "0x16EA240", Offset = "0x16E8E40", VA = "0x1816EA240")]
			public OnPostLayoutAction(OpenServerV2TotalCheckinView closure, int focusIndex, int totalCount)
			{
			}

			// Token: 0x0601D61A RID: 120346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D61A")]
			[Address(RVA = "0x16EA1C0", Offset = "0x16E8DC0", VA = "0x1816EA1C0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04026AE3 RID: 158435
			[Token(Token = "0x4026AE3")]
			[FieldOffset(Offset = "0x10")]
			private OpenServerV2TotalCheckinView m_closure;

			// Token: 0x04026AE4 RID: 158436
			[Token(Token = "0x4026AE4")]
			[FieldOffset(Offset = "0x18")]
			private int m_focusIndex;

			// Token: 0x04026AE5 RID: 158437
			[Token(Token = "0x4026AE5")]
			[FieldOffset(Offset = "0x1C")]
			private int m_totalCount;
		}
	}
}
