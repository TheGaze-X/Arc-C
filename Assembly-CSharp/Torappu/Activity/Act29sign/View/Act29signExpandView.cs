using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x02007498 RID: 29848
	[Token(Token = "0x2007498")]
	public class Act29signExpandView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700634E RID: 25422
		// (get) Token: 0x0602A1A4 RID: 172452 RVA: 0x000D76E8 File Offset: 0x000D58E8
		// (set) Token: 0x0602A1A5 RID: 172453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700634E")]
		protected float expansion
		{
			[Token(Token = "0x602A1A4")]
			[Address(RVA = "0x25BC210", Offset = "0x25BAE10", VA = "0x1825BC210")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x602A1A5")]
			[Address(RVA = "0x25BC270", Offset = "0x25BAE70", VA = "0x1825BC270")]
			set
			{
			}
		}

		// Token: 0x0602A1A6 RID: 172454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1A6")]
		[Address(RVA = "0x25BBB10", Offset = "0x25BA710", VA = "0x1825BBB10")]
		public void Render(Act29signExpandView.Model model)
		{
		}

		// Token: 0x0602A1A7 RID: 172455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1A7")]
		[Address(RVA = "0x25BBCC0", Offset = "0x25BA8C0", VA = "0x1825BBCC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A1A8 RID: 172456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1A8")]
		[Address(RVA = "0x25BC040", Offset = "0x25BAC40", VA = "0x1825BC040")]
		private void _SetItemVisible(bool visible)
		{
		}

		// Token: 0x0602A1A9 RID: 172457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1A9")]
		[Address(RVA = "0x25BBDC0", Offset = "0x25BA9C0", VA = "0x1825BBDC0")]
		private void _SetExpansionAndRender(float expansion)
		{
		}

		// Token: 0x0602A1AA RID: 172458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1AA")]
		[Address(RVA = "0x25BC0C0", Offset = "0x25BACC0", VA = "0x1825BC0C0")]
		private void _SetX(RectTransform rectTransform, float x)
		{
		}

		// Token: 0x0602A1AB RID: 172459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1AB")]
		[Address(RVA = "0x25BC1B0", Offset = "0x25BADB0", VA = "0x1825BC1B0")]
		public Act29signExpandView()
		{
		}

		// Token: 0x0403C71B RID: 247579
		[Token(Token = "0x403C71B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0403C71C RID: 247580
		[Token(Token = "0x403C71C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform[] _itemList;

		// Token: 0x0403C71D RID: 247581
		[Token(Token = "0x403C71D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _itemsContainer;

		// Token: 0x0403C71E RID: 247582
		[Token(Token = "0x403C71E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _containerMoveDistance;

		// Token: 0x0403C71F RID: 247583
		[Token(Token = "0x403C71F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _itemOccupyWidth;

		// Token: 0x0403C720 RID: 247584
		[Token(Token = "0x403C720")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemExpandWidth;

		// Token: 0x0403C721 RID: 247585
		[Token(Token = "0x403C721")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _duration;

		// Token: 0x0403C722 RID: 247586
		[Token(Token = "0x403C722")]
		[FieldOffset(Offset = "0x40")]
		private int m_expandItemIndex;

		// Token: 0x0403C723 RID: 247587
		[Token(Token = "0x403C723")]
		[FieldOffset(Offset = "0x48")]
		private Act29signExpandView.ExpandTween m_internalTween;

		// Token: 0x0403C724 RID: 247588
		[Token(Token = "0x403C724")]
		[FieldOffset(Offset = "0x50")]
		private bool m_controlItemsVisible;

		// Token: 0x0403C725 RID: 247589
		[Token(Token = "0x403C725")]
		[FieldOffset(Offset = "0x51")]
		private bool m_hasInited;

		// Token: 0x0403C726 RID: 247590
		[Token(Token = "0x403C726")]
		[FieldOffset(Offset = "0x54")]
		private Act29signExpandView.Model m_viewModel;

		// Token: 0x0403C727 RID: 247591
		[Token(Token = "0x403C727")]
		[FieldOffset(Offset = "0x64")]
		private float m_expansion;

		// Token: 0x0403C728 RID: 247592
		[Token(Token = "0x403C728")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_expansion;

		// Token: 0x0403C729 RID: 247593
		[Token(Token = "0x403C729")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_expansion;

		// Token: 0x0403C72A RID: 247594
		[Token(Token = "0x403C72A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C72B RID: 247595
		[Token(Token = "0x403C72B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C72C RID: 247596
		[Token(Token = "0x403C72C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetItemVisible;

		// Token: 0x0403C72D RID: 247597
		[Token(Token = "0x403C72D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetExpansionAndRender;

		// Token: 0x0403C72E RID: 247598
		[Token(Token = "0x403C72E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetX;

		// Token: 0x0403C72F RID: 247599
		[Token(Token = "0x403C72F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007499 RID: 29849
		[Token(Token = "0x2007499")]
		public struct Model : IHotfixable
		{
			// Token: 0x0403C730 RID: 247600
			[Token(Token = "0x403C730")]
			[FieldOffset(Offset = "0x0")]
			public bool isExpand;

			// Token: 0x0403C731 RID: 247601
			[Token(Token = "0x403C731")]
			[FieldOffset(Offset = "0x4")]
			public int expandIndex;

			// Token: 0x0403C732 RID: 247602
			[Token(Token = "0x403C732")]
			[FieldOffset(Offset = "0x8")]
			public float delay;

			// Token: 0x0403C733 RID: 247603
			[Token(Token = "0x403C733")]
			[FieldOffset(Offset = "0xC")]
			public bool controlItemsVisible;
		}

		// Token: 0x0200749A RID: 29850
		[Token(Token = "0x200749A")]
		private class ExpandTween : UISwitchTween
		{
			// Token: 0x0602A1AC RID: 172460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A1AC")]
			[Address(RVA = "0x25C2FB0", Offset = "0x25C1BB0", VA = "0x1825C2FB0")]
			public ExpandTween(Act29signExpandView expandView)
			{
			}

			// Token: 0x0602A1AD RID: 172461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A1AD")]
			[Address(RVA = "0x25C2A00", Offset = "0x25C1600", VA = "0x1825C2A00", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602A1AE RID: 172462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A1AE")]
			[Address(RVA = "0x25C2BB0", Offset = "0x25C17B0", VA = "0x1825C2BB0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602A1AF RID: 172463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A1AF")]
			[Address(RVA = "0x25C2E90", Offset = "0x25C1A90", VA = "0x1825C2E90", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602A1B4 RID: 172468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A1B4")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403C734 RID: 247604
			[Token(Token = "0x403C734")]
			private const float SHOW_TWEEN_AUDIO_POS = 0.5f;

			// Token: 0x0403C735 RID: 247605
			[Token(Token = "0x403C735")]
			[FieldOffset(Offset = "0x48")]
			private Act29signExpandView m_expandView;

			// Token: 0x0403C736 RID: 247606
			[Token(Token = "0x403C736")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403C737 RID: 247607
			[Token(Token = "0x403C737")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403C738 RID: 247608
			[Token(Token = "0x403C738")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403C739 RID: 247609
			[Token(Token = "0x403C739")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
