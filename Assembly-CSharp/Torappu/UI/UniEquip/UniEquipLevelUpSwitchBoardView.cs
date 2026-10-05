using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C29 RID: 15401
	[Token(Token = "0x2003C29")]
	public class UniEquipLevelUpSwitchBoardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018165 RID: 98661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018165")]
		[Address(RVA = "0x1095DB0", Offset = "0x10949B0", VA = "0x181095DB0")]
		public void Render(UniEquipLevelUpSwitchBoardViewModel viewModel)
		{
		}

		// Token: 0x06018166 RID: 98662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018166")]
		[Address(RVA = "0x1095BF0", Offset = "0x10947F0", VA = "0x181095BF0")]
		public void PlaySwitchAnim(Action reloadFunc)
		{
		}

		// Token: 0x06018167 RID: 98663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018167")]
		[Address(RVA = "0x1096400", Offset = "0x1095000", VA = "0x181096400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018168 RID: 98664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018168")]
		[Address(RVA = "0x1096A10", Offset = "0x1095610", VA = "0x181096A10")]
		private void _ShowSelectTween()
		{
		}

		// Token: 0x06018169 RID: 98665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018169")]
		[Address(RVA = "0x1096900", Offset = "0x1095500", VA = "0x181096900")]
		private void _SetBoardPos()
		{
		}

		// Token: 0x0601816A RID: 98666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601816A")]
		[Address(RVA = "0x10966C0", Offset = "0x10952C0", VA = "0x1810966C0")]
		private void _RenderLevelUpContent(UniEquipLevelUpSwitchBoardViewModel viewModel)
		{
		}

		// Token: 0x0601816B RID: 98667 RVA: 0x000994B0 File Offset: 0x000976B0
		[Token(Token = "0x601816B")]
		[Address(RVA = "0x10960F0", Offset = "0x1094CF0", VA = "0x1810960F0")]
		private float _CalcPreferredHeightInText(Text text, string content)
		{
			return 0f;
		}

		// Token: 0x0601816C RID: 98668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601816C")]
		[Address(RVA = "0x10965F0", Offset = "0x10951F0", VA = "0x1810965F0")]
		private void _PlayOutAnim(TweenCallback onComplete)
		{
		}

		// Token: 0x0601816D RID: 98669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601816D")]
		[Address(RVA = "0x1096540", Offset = "0x1095140", VA = "0x181096540")]
		private void _PlayInAnim()
		{
		}

		// Token: 0x0601816E RID: 98670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601816E")]
		[Address(RVA = "0x1096C80", Offset = "0x1095880", VA = "0x181096C80")]
		public UniEquipLevelUpSwitchBoardView()
		{
		}

		// Token: 0x0401D3A2 RID: 119714
		[Token(Token = "0x401D3A2")]
		private const string ANIM_BOARD_OUT = "levelup_board_out";

		// Token: 0x0401D3A3 RID: 119715
		[Token(Token = "0x401D3A3")]
		private const string ANIM_BOARD_IN = "levelup_board_in";

		// Token: 0x0401D3A4 RID: 119716
		[Token(Token = "0x401D3A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _simpleText;

		// Token: 0x0401D3A5 RID: 119717
		[Token(Token = "0x401D3A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401D3A6 RID: 119718
		[Token(Token = "0x401D3A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _boardContent;

		// Token: 0x0401D3A7 RID: 119719
		[Token(Token = "0x401D3A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _boardContentTransform;

		// Token: 0x0401D3A8 RID: 119720
		[Token(Token = "0x401D3A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HorizontalLayoutGroup _layoutGroup;

		// Token: 0x0401D3A9 RID: 119721
		[Token(Token = "0x401D3A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _boardObjTransform;

		// Token: 0x0401D3AA RID: 119722
		[Token(Token = "0x401D3AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _selectTweenDuration;

		// Token: 0x0401D3AB RID: 119723
		[Token(Token = "0x401D3AB")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _boardInitPosX;

		// Token: 0x0401D3AC RID: 119724
		[Token(Token = "0x401D3AC")]
		[FieldOffset(Offset = "0x50")]
		private UniEquipLevelUpSwitchBoardView.BoardAdapter m_boardAdapter;

		// Token: 0x0401D3AD RID: 119725
		[Token(Token = "0x401D3AD")]
		[FieldOffset(Offset = "0x58")]
		private UniEquipLevelUpSwitchBoardViewModel m_cachedModel;

		// Token: 0x0401D3AE RID: 119726
		[Token(Token = "0x401D3AE")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401D3AF RID: 119727
		[Token(Token = "0x401D3AF")]
		[FieldOffset(Offset = "0x64")]
		private int m_cachedTargetLevel;

		// Token: 0x0401D3B0 RID: 119728
		[Token(Token = "0x401D3B0")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_selectTween;

		// Token: 0x0401D3B1 RID: 119729
		[Token(Token = "0x401D3B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D3B2 RID: 119730
		[Token(Token = "0x401D3B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlaySwitchAnim;

		// Token: 0x0401D3B3 RID: 119731
		[Token(Token = "0x401D3B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D3B4 RID: 119732
		[Token(Token = "0x401D3B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowSelectTween;

		// Token: 0x0401D3B5 RID: 119733
		[Token(Token = "0x401D3B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetBoardPos;

		// Token: 0x0401D3B6 RID: 119734
		[Token(Token = "0x401D3B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderLevelUpContent;

		// Token: 0x0401D3B7 RID: 119735
		[Token(Token = "0x401D3B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalcPreferredHeightInText;

		// Token: 0x0401D3B8 RID: 119736
		[Token(Token = "0x401D3B8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayOutAnim;

		// Token: 0x0401D3B9 RID: 119737
		[Token(Token = "0x401D3B9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayInAnim;

		// Token: 0x0401D3BA RID: 119738
		[Token(Token = "0x401D3BA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C2A RID: 15402
		[Token(Token = "0x2003C2A")]
		private class BoardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700398B RID: 14731
			// (get) Token: 0x06018171 RID: 98673 RVA: 0x000994E0 File Offset: 0x000976E0
			[Token(Token = "0x1700398B")]
			public override int count
			{
				[Token(Token = "0x6018171")]
				[Address(RVA = "0x108DFE0", Offset = "0x108CBE0", VA = "0x18108DFE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018172 RID: 98674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018172")]
			[Address(RVA = "0x108DD80", Offset = "0x108C980", VA = "0x18108DD80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018173 RID: 98675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018173")]
			[Address(RVA = "0x108DF60", Offset = "0x108CB60", VA = "0x18108DF60")]
			public BoardAdapter(UniEquipLevelUpSwitchBoardView closure)
			{
			}

			// Token: 0x0401D3BB RID: 119739
			[Token(Token = "0x401D3BB")]
			[FieldOffset(Offset = "0x20")]
			private UniEquipLevelUpSwitchBoardView m_closure;

			// Token: 0x0401D3BC RID: 119740
			[Token(Token = "0x401D3BC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D3BD RID: 119741
			[Token(Token = "0x401D3BD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D3BE RID: 119742
			[Token(Token = "0x401D3BE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
