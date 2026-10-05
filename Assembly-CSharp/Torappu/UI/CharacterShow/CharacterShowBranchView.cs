using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DE9 RID: 24041
	[Token(Token = "0x2005DE9")]
	public class CharacterShowBranchView : CharacterShowRightInfoViewBase
	{
		// Token: 0x1700528A RID: 21130
		// (get) Token: 0x06022D79 RID: 142713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700528A")]
		public UIWrappedScrollRect equipScroll
		{
			[Token(Token = "0x6022D79")]
			[Address(RVA = "0x1D6C5A0", Offset = "0x1D6B1A0", VA = "0x181D6C5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022D7A RID: 142714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D7A")]
		[Address(RVA = "0x1D6B8D0", Offset = "0x1D6A4D0", VA = "0x181D6B8D0", Slot = "7")]
		public override void OnValueChanged(CharacterShowProp property)
		{
		}

		// Token: 0x06022D7B RID: 142715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D7B")]
		[Address(RVA = "0x1D6C0B0", Offset = "0x1D6ACB0", VA = "0x181D6C0B0")]
		private void _UpdateEquipView()
		{
		}

		// Token: 0x06022D7C RID: 142716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D7C")]
		[Address(RVA = "0x1D6BCC0", Offset = "0x1D6A8C0", VA = "0x181D6BCC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022D7D RID: 142717 RVA: 0x000BF3D0 File Offset: 0x000BD5D0
		[Token(Token = "0x6022D7D")]
		[Address(RVA = "0x1D6BB60", Offset = "0x1D6A760", VA = "0x181D6BB60")]
		private float _GetTraitMaxHeight()
		{
			return 0f;
		}

		// Token: 0x06022D7E RID: 142718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D7E")]
		[Address(RVA = "0x1D6C4F0", Offset = "0x1D6B0F0", VA = "0x181D6C4F0")]
		public CharacterShowBranchView()
		{
		}

		// Token: 0x0402FF53 RID: 196435
		[Token(Token = "0x402FF53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgSubProf;

		// Token: 0x0402FF54 RID: 196436
		[Token(Token = "0x402FF54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSubProf;

		// Token: 0x0402FF55 RID: 196437
		[Token(Token = "0x402FF55")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTraitDesc;

		// Token: 0x0402FF56 RID: 196438
		[Token(Token = "0x402FF56")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutTraitDesc;

		// Token: 0x0402FF57 RID: 196439
		[Token(Token = "0x402FF57")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _equipList;

		// Token: 0x0402FF58 RID: 196440
		[Token(Token = "0x402FF58")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _talentList;

		// Token: 0x0402FF59 RID: 196441
		[Token(Token = "0x402FF59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unlockHintGo;

		// Token: 0x0402FF5A RID: 196442
		[Token(Token = "0x402FF5A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textUnlockHint;

		// Token: 0x0402FF5B RID: 196443
		[Token(Token = "0x402FF5B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _equipListGo;

		// Token: 0x0402FF5C RID: 196444
		[Token(Token = "0x402FF5C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _emptyEquipGo;

		// Token: 0x0402FF5D RID: 196445
		[Token(Token = "0x402FF5D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _emptyTalentGo;

		// Token: 0x0402FF5E RID: 196446
		[Token(Token = "0x402FF5E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _selectEquipName;

		// Token: 0x0402FF5F RID: 196447
		[Token(Token = "0x402FF5F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _equipContentRectTransform;

		// Token: 0x0402FF60 RID: 196448
		[Token(Token = "0x402FF60")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIWrappedScrollRect _equipScroll;

		// Token: 0x0402FF61 RID: 196449
		[Token(Token = "0x402FF61")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _limitEquipCntScrollWidth;

		// Token: 0x0402FF62 RID: 196450
		[Token(Token = "0x402FF62")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _maxEquipCntScrollWidth;

		// Token: 0x0402FF63 RID: 196451
		[Token(Token = "0x402FF63")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _singleEquipGo;

		// Token: 0x0402FF64 RID: 196452
		[Token(Token = "0x402FF64")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CharacterShowEquipItem _singleEquipItem;

		// Token: 0x0402FF65 RID: 196453
		[Token(Token = "0x402FF65")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SimpleLayoutContent _masterList;

		// Token: 0x0402FF66 RID: 196454
		[Token(Token = "0x402FF66")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelMaster;

		// Token: 0x0402FF67 RID: 196455
		[Token(Token = "0x402FF67")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_hasInited;

		// Token: 0x0402FF68 RID: 196456
		[Token(Token = "0x402FF68")]
		[FieldOffset(Offset = "0xC0")]
		private CharacterShowV2Model m_charShowModel;

		// Token: 0x0402FF69 RID: 196457
		[Token(Token = "0x402FF69")]
		[FieldOffset(Offset = "0xC8")]
		private CharacterShowBranchView.EquipListAdapter m_equipListAdapter;

		// Token: 0x0402FF6A RID: 196458
		[Token(Token = "0x402FF6A")]
		[FieldOffset(Offset = "0xD0")]
		private CharacterShowBranchView.TalentListAdapter m_talentListAdapter;

		// Token: 0x0402FF6B RID: 196459
		[Token(Token = "0x402FF6B")]
		[FieldOffset(Offset = "0xD8")]
		private CharacterShowBranchView.MasterListAdapter m_masterListAdapter;

		// Token: 0x0402FF6C RID: 196460
		[Token(Token = "0x402FF6C")]
		[FieldOffset(Offset = "0xE0")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402FF6D RID: 196461
		[Token(Token = "0x402FF6D")]
		[FieldOffset(Offset = "0xE8")]
		private int m_refreshSeqNum;

		// Token: 0x0402FF6E RID: 196462
		[Token(Token = "0x402FF6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_equipScroll;

		// Token: 0x0402FF6F RID: 196463
		[Token(Token = "0x402FF6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FF70 RID: 196464
		[Token(Token = "0x402FF70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateEquipView;

		// Token: 0x0402FF71 RID: 196465
		[Token(Token = "0x402FF71")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FF72 RID: 196466
		[Token(Token = "0x402FF72")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTraitMaxHeight;

		// Token: 0x0402FF73 RID: 196467
		[Token(Token = "0x402FF73")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DEA RID: 24042
		[Token(Token = "0x2005DEA")]
		private class EquipListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022D7F RID: 142719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022D7F")]
			[Address(RVA = "0x1D71BD0", Offset = "0x1D707D0", VA = "0x181D71BD0")]
			public EquipListAdapter(CharacterShowBranchView closure)
			{
			}

			// Token: 0x1700528B RID: 21131
			// (get) Token: 0x06022D80 RID: 142720 RVA: 0x000BF3E8 File Offset: 0x000BD5E8
			[Token(Token = "0x1700528B")]
			public override int count
			{
				[Token(Token = "0x6022D80")]
				[Address(RVA = "0x1D71C50", Offset = "0x1D70850", VA = "0x181D71C50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022D81 RID: 142721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022D81")]
			[Address(RVA = "0x1D71990", Offset = "0x1D70590", VA = "0x181D71990", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FF74 RID: 196468
			[Token(Token = "0x402FF74")]
			[FieldOffset(Offset = "0x20")]
			private CharacterShowBranchView m_closure;

			// Token: 0x0402FF75 RID: 196469
			[Token(Token = "0x402FF75")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FF76 RID: 196470
			[Token(Token = "0x402FF76")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FF77 RID: 196471
			[Token(Token = "0x402FF77")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005DEB RID: 24043
		[Token(Token = "0x2005DEB")]
		private class TalentListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022D82 RID: 142722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022D82")]
			[Address(RVA = "0x1D73190", Offset = "0x1D71D90", VA = "0x181D73190")]
			public TalentListAdapter(CharacterShowBranchView closure)
			{
			}

			// Token: 0x1700528C RID: 21132
			// (get) Token: 0x06022D83 RID: 142723 RVA: 0x000BF400 File Offset: 0x000BD600
			[Token(Token = "0x1700528C")]
			public override int count
			{
				[Token(Token = "0x6022D83")]
				[Address(RVA = "0x1D73210", Offset = "0x1D71E10", VA = "0x181D73210", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022D84 RID: 142724 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022D84")]
			[Address(RVA = "0x1D72FA0", Offset = "0x1D71BA0", VA = "0x181D72FA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FF78 RID: 196472
			[Token(Token = "0x402FF78")]
			[FieldOffset(Offset = "0x20")]
			private CharacterShowBranchView m_closure;

			// Token: 0x0402FF79 RID: 196473
			[Token(Token = "0x402FF79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FF7A RID: 196474
			[Token(Token = "0x402FF7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FF7B RID: 196475
			[Token(Token = "0x402FF7B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005DEC RID: 24044
		[Token(Token = "0x2005DEC")]
		private class MasterListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022D85 RID: 142725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022D85")]
			[Address(RVA = "0x1D71EE0", Offset = "0x1D70AE0", VA = "0x181D71EE0")]
			public MasterListAdapter(CharacterShowBranchView closure)
			{
			}

			// Token: 0x1700528D RID: 21133
			// (get) Token: 0x06022D86 RID: 142726 RVA: 0x000BF418 File Offset: 0x000BD618
			[Token(Token = "0x1700528D")]
			public override int count
			{
				[Token(Token = "0x6022D86")]
				[Address(RVA = "0x1D71F60", Offset = "0x1D70B60", VA = "0x181D71F60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022D87 RID: 142727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022D87")]
			[Address(RVA = "0x1D71CF0", Offset = "0x1D708F0", VA = "0x181D71CF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FF7C RID: 196476
			[Token(Token = "0x402FF7C")]
			[FieldOffset(Offset = "0x20")]
			private CharacterShowBranchView m_closure;

			// Token: 0x0402FF7D RID: 196477
			[Token(Token = "0x402FF7D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FF7E RID: 196478
			[Token(Token = "0x402FF7E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FF7F RID: 196479
			[Token(Token = "0x402FF7F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
