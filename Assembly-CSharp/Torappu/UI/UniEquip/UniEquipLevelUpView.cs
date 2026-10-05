using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C2C RID: 15404
	[Token(Token = "0x2003C2C")]
	public class UniEquipLevelUpView : DataBinder<LevelUpViewProperty>
	{
		// Token: 0x06018176 RID: 98678 RVA: 0x000994F8 File Offset: 0x000976F8
		[Token(Token = "0x6018176")]
		[Address(RVA = "0x1098560", Offset = "0x1097160", VA = "0x181098560")]
		public bool isAnimPlaying()
		{
			return default(bool);
		}

		// Token: 0x06018177 RID: 98679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018177")]
		[Address(RVA = "0x1097820", Offset = "0x1096420", VA = "0x181097820", Slot = "7")]
		public override void OnValueChanged(LevelUpViewProperty property)
		{
		}

		// Token: 0x06018178 RID: 98680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018178")]
		[Address(RVA = "0x1098100", Offset = "0x1096D00", VA = "0x181098100")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018179 RID: 98681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018179")]
		[Address(RVA = "0x1098240", Offset = "0x1096E40", VA = "0x181098240")]
		private void _PlaySelectLevelItemFadeTween()
		{
		}

		// Token: 0x0601817A RID: 98682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601817A")]
		[Address(RVA = "0x1097D80", Offset = "0x1096980", VA = "0x181097D80")]
		public void PlayLevelUpAnim(Action reloadFunc)
		{
		}

		// Token: 0x0601817B RID: 98683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601817B")]
		[Address(RVA = "0x10983F0", Offset = "0x1096FF0", VA = "0x1810983F0")]
		public UniEquipLevelUpView()
		{
		}

		// Token: 0x0401D3C1 RID: 119745
		[Token(Token = "0x401D3C1")]
		private const string ANIM_ITEM_OUT = "levelup_item_out";

		// Token: 0x0401D3C2 RID: 119746
		[Token(Token = "0x401D3C2")]
		private const string ANIM_ITEM_IN = "levelup_item_in";

		// Token: 0x0401D3C3 RID: 119747
		[Token(Token = "0x401D3C3")]
		private const int AVG_FOCUS_ITEM_INDEX = 1;

		// Token: 0x0401D3C4 RID: 119748
		[Token(Token = "0x401D3C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgEquip;

		// Token: 0x0401D3C5 RID: 119749
		[Token(Token = "0x401D3C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UniEquipLevelUpSwitchBoardView _switchBoardView;

		// Token: 0x0401D3C6 RID: 119750
		[Token(Token = "0x401D3C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _switchBoardViewContainer;

		// Token: 0x0401D3C7 RID: 119751
		[Token(Token = "0x401D3C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _itemLayoutContent;

		// Token: 0x0401D3C8 RID: 119752
		[Token(Token = "0x401D3C8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _pointLayoutContent;

		// Token: 0x0401D3C9 RID: 119753
		[Token(Token = "0x401D3C9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _confirmInfoText;

		// Token: 0x0401D3CA RID: 119754
		[Token(Token = "0x401D3CA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401D3CB RID: 119755
		[Token(Token = "0x401D3CB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _itemCanvasGroup;

		// Token: 0x0401D3CC RID: 119756
		[Token(Token = "0x401D3CC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _itemFadeDuration;

		// Token: 0x0401D3CD RID: 119757
		[Token(Token = "0x401D3CD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CharacterInfoSpOpView _spOpView;

		// Token: 0x0401D3CE RID: 119758
		[Token(Token = "0x401D3CE")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0401D3CF RID: 119759
		[Token(Token = "0x401D3CF")]
		[FieldOffset(Offset = "0x78")]
		private UniEquipLevelUpView.ItemAdapter m_itemAdapter;

		// Token: 0x0401D3D0 RID: 119760
		[Token(Token = "0x401D3D0")]
		[FieldOffset(Offset = "0x80")]
		private UniEquipLevelUpView.PointAdapter m_pointAdapter;

		// Token: 0x0401D3D1 RID: 119761
		[Token(Token = "0x401D3D1")]
		[FieldOffset(Offset = "0x88")]
		private UniEquipLevelUpSwitchBoardView m_switchBoardView;

		// Token: 0x0401D3D2 RID: 119762
		[Token(Token = "0x401D3D2")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isAnimPlaying;

		// Token: 0x0401D3D3 RID: 119763
		[Token(Token = "0x401D3D3")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_itemFadeDotween;

		// Token: 0x0401D3D4 RID: 119764
		[Token(Token = "0x401D3D4")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D3D5 RID: 119765
		[Token(Token = "0x401D3D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_isAnimPlaying;

		// Token: 0x0401D3D6 RID: 119766
		[Token(Token = "0x401D3D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D3D7 RID: 119767
		[Token(Token = "0x401D3D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D3D8 RID: 119768
		[Token(Token = "0x401D3D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlaySelectLevelItemFadeTween;

		// Token: 0x0401D3D9 RID: 119769
		[Token(Token = "0x401D3D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayLevelUpAnim;

		// Token: 0x0401D3DA RID: 119770
		[Token(Token = "0x401D3DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C2D RID: 15405
		[Token(Token = "0x2003C2D")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700398C RID: 14732
			// (get) Token: 0x0601817E RID: 98686 RVA: 0x00099528 File Offset: 0x00097728
			[Token(Token = "0x1700398C")]
			public override int count
			{
				[Token(Token = "0x601817E")]
				[Address(RVA = "0x108EC40", Offset = "0x108D840", VA = "0x18108EC40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601817F RID: 98687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601817F")]
			[Address(RVA = "0x108E640", Offset = "0x108D240", VA = "0x18108E640", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018180 RID: 98688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018180")]
			[Address(RVA = "0x108EAA0", Offset = "0x108D6A0", VA = "0x18108EAA0")]
			public ItemAdapter()
			{
			}

			// Token: 0x0401D3DB RID: 119771
			[Token(Token = "0x401D3DB")]
			[FieldOffset(Offset = "0x20")]
			public UniEquipLevelUpViewModel viewModel;

			// Token: 0x0401D3DC RID: 119772
			[Token(Token = "0x401D3DC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D3DD RID: 119773
			[Token(Token = "0x401D3DD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D3DE RID: 119774
			[Token(Token = "0x401D3DE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003C2E RID: 15406
		[Token(Token = "0x2003C2E")]
		private class PointAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700398D RID: 14733
			// (get) Token: 0x06018181 RID: 98689 RVA: 0x00099540 File Offset: 0x00097740
			[Token(Token = "0x1700398D")]
			public override int count
			{
				[Token(Token = "0x6018181")]
				[Address(RVA = "0x108F250", Offset = "0x108DE50", VA = "0x18108F250", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018182 RID: 98690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018182")]
			[Address(RVA = "0x108F040", Offset = "0x108DC40", VA = "0x18108F040", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018183 RID: 98691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018183")]
			[Address(RVA = "0x108F1F0", Offset = "0x108DDF0", VA = "0x18108F1F0")]
			public PointAdapter()
			{
			}

			// Token: 0x0401D3DF RID: 119775
			[Token(Token = "0x401D3DF")]
			[FieldOffset(Offset = "0x20")]
			public UniEquipLevelUpSwitchBoardViewModel viewModel;

			// Token: 0x0401D3E0 RID: 119776
			[Token(Token = "0x401D3E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D3E1 RID: 119777
			[Token(Token = "0x401D3E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D3E2 RID: 119778
			[Token(Token = "0x401D3E2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
