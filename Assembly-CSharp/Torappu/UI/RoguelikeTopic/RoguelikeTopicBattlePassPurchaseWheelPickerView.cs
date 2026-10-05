using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004499 RID: 17561
	[Token(Token = "0x2004499")]
	public class RoguelikeTopicBattlePassPurchaseWheelPickerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AD2B RID: 109867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD2B")]
		[Address(RVA = "0x13F96B0", Offset = "0x13F82B0", VA = "0x1813F96B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AD2C RID: 109868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD2C")]
		[Address(RVA = "0x13F95F0", Offset = "0x13F81F0", VA = "0x1813F95F0")]
		private void Update()
		{
		}

		// Token: 0x0601AD2D RID: 109869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD2D")]
		[Address(RVA = "0x13F9570", Offset = "0x13F8170", VA = "0x1813F9570")]
		public void SetActionDelegate(RoguelikeTopicBattlePassPurchaseWheelPickerView.ActionDelegate actionDelegate)
		{
		}

		// Token: 0x0601AD2E RID: 109870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD2E")]
		[Address(RVA = "0x13F93B0", Offset = "0x13F7FB0", VA = "0x1813F93B0")]
		public void Render(RoguelikeTopicBattlePassPurchaseViewModel viewModel)
		{
		}

		// Token: 0x0601AD2F RID: 109871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD2F")]
		[Address(RVA = "0x13F99E0", Offset = "0x13F85E0", VA = "0x1813F99E0")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x0601AD30 RID: 109872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD30")]
		[Address(RVA = "0x13F9960", Offset = "0x13F8560", VA = "0x1813F9960")]
		private void _OnPageChangeStart()
		{
		}

		// Token: 0x0601AD31 RID: 109873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD31")]
		[Address(RVA = "0x13F98C0", Offset = "0x13F84C0", VA = "0x1813F98C0")]
		private void _OnPageChangeEnd(int itemIndex)
		{
		}

		// Token: 0x0601AD32 RID: 109874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD32")]
		[Address(RVA = "0x13F9B80", Offset = "0x13F8780", VA = "0x1813F9B80")]
		public RoguelikeTopicBattlePassPurchaseWheelPickerView()
		{
		}

		// Token: 0x0402255E RID: 140638
		[Token(Token = "0x402255E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InertiaScrollViewPager _wheelPager;

		// Token: 0x0402255F RID: 140639
		[Token(Token = "0x402255F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04022560 RID: 140640
		[Token(Token = "0x4022560")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeTopicBattlePassObjView _itemPrefab;

		// Token: 0x04022561 RID: 140641
		[Token(Token = "0x4022561")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemWidth;

		// Token: 0x04022562 RID: 140642
		[Token(Token = "0x4022562")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isInited;

		// Token: 0x04022563 RID: 140643
		[Token(Token = "0x4022563")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeTopicBattlePassPurchaseWheelPickerView.ActionDelegate m_actionDelegate;

		// Token: 0x04022564 RID: 140644
		[Token(Token = "0x4022564")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeTopicBattlePassPurchaseWheelPickerView.PagerAdapter m_adapter;

		// Token: 0x04022565 RID: 140645
		[Token(Token = "0x4022565")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeTopicBattlePassPurchaseViewModel m_cachedModel;

		// Token: 0x04022566 RID: 140646
		[Token(Token = "0x4022566")]
		[FieldOffset(Offset = "0x50")]
		private long m_cachedWidgetId;

		// Token: 0x04022567 RID: 140647
		[Token(Token = "0x4022567")]
		[FieldOffset(Offset = "0x58")]
		private long m_cachedDragId;

		// Token: 0x04022568 RID: 140648
		[Token(Token = "0x4022568")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022569 RID: 140649
		[Token(Token = "0x4022569")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402256A RID: 140650
		[Token(Token = "0x402256A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetActionDelegate;

		// Token: 0x0402256B RID: 140651
		[Token(Token = "0x402256B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402256C RID: 140652
		[Token(Token = "0x402256C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x0402256D RID: 140653
		[Token(Token = "0x402256D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPageChangeStart;

		// Token: 0x0402256E RID: 140654
		[Token(Token = "0x402256E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPageChangeEnd;

		// Token: 0x0402256F RID: 140655
		[Token(Token = "0x402256F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200449A RID: 17562
		[Token(Token = "0x200449A")]
		public class Param
		{
			// Token: 0x0601AD33 RID: 109875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD33")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04022570 RID: 140656
			[Token(Token = "0x4022570")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicBattlePassObjView prefab;

			// Token: 0x04022571 RID: 140657
			[Token(Token = "0x4022571")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeTopicBPObjViewModel viewModel;

			// Token: 0x04022572 RID: 140658
			[Token(Token = "0x4022572")]
			[FieldOffset(Offset = "0x20")]
			public bool isFirstItem;

			// Token: 0x04022573 RID: 140659
			[Token(Token = "0x4022573")]
			[FieldOffset(Offset = "0x21")]
			public bool isLastItem;

			// Token: 0x04022574 RID: 140660
			[Token(Token = "0x4022574")]
			[FieldOffset(Offset = "0x24")]
			public float preferredSize;
		}

		// Token: 0x0200449B RID: 17563
		[Token(Token = "0x200449B")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RoguelikeTopicBattlePassObjView>
		{
			// Token: 0x0601AD34 RID: 109876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD34")]
			[Address(RVA = "0x1400C30", Offset = "0x13FF830", VA = "0x181400C30")]
			public VirtualView(RoguelikeTopicBattlePassPurchaseWheelPickerView.Param param)
			{
			}

			// Token: 0x0601AD35 RID: 109877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD35")]
			[Address(RVA = "0x1400A10", Offset = "0x13FF610", VA = "0x181400A10", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601AD36 RID: 109878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD36")]
			[Address(RVA = "0x1400AB0", Offset = "0x13FF6B0", VA = "0x181400AB0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601AD37 RID: 109879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AD37")]
			[Address(RVA = "0x14007B0", Offset = "0x13FF3B0", VA = "0x1814007B0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601AD38 RID: 109880 RVA: 0x000A36F8 File Offset: 0x000A18F8
			[Token(Token = "0x601AD38")]
			[Address(RVA = "0x14008F0", Offset = "0x13FF4F0", VA = "0x1814008F0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x04022575 RID: 140661
			[Token(Token = "0x4022575")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicBattlePassPurchaseWheelPickerView.Param m_param;

			// Token: 0x04022576 RID: 140662
			[Token(Token = "0x4022576")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022577 RID: 140663
			[Token(Token = "0x4022577")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04022578 RID: 140664
			[Token(Token = "0x4022578")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04022579 RID: 140665
			[Token(Token = "0x4022579")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402257A RID: 140666
			[Token(Token = "0x402257A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x0200449C RID: 17564
		[Token(Token = "0x200449C")]
		public class ActionDelegate
		{
			// Token: 0x0601AD39 RID: 109881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD39")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActionDelegate()
			{
			}

			// Token: 0x0402257B RID: 140667
			[Token(Token = "0x402257B")]
			[FieldOffset(Offset = "0x10")]
			public Action onScrollBegin;

			// Token: 0x0402257C RID: 140668
			[Token(Token = "0x402257C")]
			[FieldOffset(Offset = "0x18")]
			public Action onBeginDrag;

			// Token: 0x0402257D RID: 140669
			[Token(Token = "0x402257D")]
			[FieldOffset(Offset = "0x20")]
			public Action<int> onUpdateIndex;

			// Token: 0x0402257E RID: 140670
			[Token(Token = "0x402257E")]
			[FieldOffset(Offset = "0x28")]
			public Action<int> onScrollEnd;
		}

		// Token: 0x0200449D RID: 17565
		[Token(Token = "0x200449D")]
		private class PagerAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601AD3A RID: 109882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD3A")]
			[Address(RVA = "0x13ED8D0", Offset = "0x13EC4D0", VA = "0x1813ED8D0")]
			public PagerAdapter(RoguelikeTopicBattlePassPurchaseWheelPickerView closure)
			{
			}

			// Token: 0x0601AD3B RID: 109883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD3B")]
			[Address(RVA = "0x13ED840", Offset = "0x13EC440", VA = "0x1813ED840")]
			public void RebuildList()
			{
			}

			// Token: 0x0601AD3C RID: 109884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AD3C")]
			[Address(RVA = "0x13ED5A0", Offset = "0x13EC1A0", VA = "0x1813ED5A0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0402257F RID: 140671
			[Token(Token = "0x402257F")]
			[FieldOffset(Offset = "0x18")]
			private RoguelikeTopicBattlePassPurchaseWheelPickerView m_closure;

			// Token: 0x04022580 RID: 140672
			[Token(Token = "0x4022580")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022581 RID: 140673
			[Token(Token = "0x4022581")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x04022582 RID: 140674
			[Token(Token = "0x4022582")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
		}
	}
}
