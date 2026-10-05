using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D21 RID: 23841
	[Token(Token = "0x2005D21")]
	public class ClimbTowerEndingTopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005130 RID: 20784
		// (get) Token: 0x0602284C RID: 141388 RVA: 0x000BDB70 File Offset: 0x000BBD70
		[Token(Token = "0x17005130")]
		public bool canClick
		{
			[Token(Token = "0x602284C")]
			[Address(RVA = "0x1D00F50", Offset = "0x1CFFB50", VA = "0x181D00F50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005131 RID: 20785
		// (get) Token: 0x0602284D RID: 141389 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602284E RID: 141390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005131")]
		public ClimbTowerEndingTopState state
		{
			[Token(Token = "0x602284D")]
			[Address(RVA = "0x1D01010", Offset = "0x1CFFC10", VA = "0x181D01010")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602284E")]
			[Address(RVA = "0x1D010F0", Offset = "0x1CFFCF0", VA = "0x181D010F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005132 RID: 20786
		// (get) Token: 0x0602284F RID: 141391 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022850 RID: 141392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005132")]
		public UIPage page
		{
			[Token(Token = "0x602284F")]
			[Address(RVA = "0x1D00FB0", Offset = "0x1CFFBB0", VA = "0x181D00FB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022850")]
			[Address(RVA = "0x1D01070", Offset = "0x1CFFC70", VA = "0x181D01070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022851 RID: 141393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022851")]
		[Address(RVA = "0x1D00CB0", Offset = "0x1CFF8B0", VA = "0x181D00CB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022852 RID: 141394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022852")]
		[Address(RVA = "0x1D00600", Offset = "0x1CFF200", VA = "0x181D00600")]
		public void Render(ClimbTowerEndingTopViewModel viewModel)
		{
		}

		// Token: 0x06022853 RID: 141395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022853")]
		[Address(RVA = "0x1D00B50", Offset = "0x1CFF750", VA = "0x181D00B50")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06022854 RID: 141396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022854")]
		[Address(RVA = "0x1D00E60", Offset = "0x1CFFA60", VA = "0x181D00E60")]
		private IEnumerator _PlayFlashSoundFx()
		{
			return null;
		}

		// Token: 0x06022855 RID: 141397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022855")]
		[Address(RVA = "0x1D00C00", Offset = "0x1CFF800", VA = "0x181D00C00")]
		private IEnumerator _FloorTextAnimCoroutine()
		{
			return null;
		}

		// Token: 0x06022856 RID: 141398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022856")]
		[Address(RVA = "0x1D00EF0", Offset = "0x1CFFAF0", VA = "0x181D00EF0")]
		public ClimbTowerEndingTopView()
		{
		}

		// Token: 0x0402F720 RID: 194336
		[Token(Token = "0x402F720")]
		private const string FLOOR_TARGET_FORMAT = "/{0}";

		// Token: 0x0402F721 RID: 194337
		[Token(Token = "0x402F721")]
		private const string ANIM_SHOW_NAME = "ending_top_state_show";

		// Token: 0x0402F722 RID: 194338
		[Token(Token = "0x402F722")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgTowerIcon;

		// Token: 0x0402F723 RID: 194339
		[Token(Token = "0x402F723")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _imgBkgNormal;

		// Token: 0x0402F724 RID: 194340
		[Token(Token = "0x402F724")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imgBkgHard;

		// Token: 0x0402F725 RID: 194341
		[Token(Token = "0x402F725")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _finishToggle;

		// Token: 0x0402F726 RID: 194342
		[Token(Token = "0x402F726")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textFloorCurr;

		// Token: 0x0402F727 RID: 194343
		[Token(Token = "0x402F727")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textFloorTarget;

		// Token: 0x0402F728 RID: 194344
		[Token(Token = "0x402F728")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgBkgLight;

		// Token: 0x0402F729 RID: 194345
		[Token(Token = "0x402F729")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClimbTowerTowerLayerStack _layerStackPrefab;

		// Token: 0x0402F72A RID: 194346
		[Token(Token = "0x402F72A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _layerStackViewHolder;

		// Token: 0x0402F72B RID: 194347
		[Token(Token = "0x402F72B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _animShow;

		// Token: 0x0402F72C RID: 194348
		[Token(Token = "0x402F72C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ClimbTowerTowerLayerSelectArrowSimple _selectArrowPrefab;

		// Token: 0x0402F72D RID: 194349
		[Token(Token = "0x402F72D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerTowerLayerGodCardTipsWithAttach _godCardTipsPrefab;

		// Token: 0x0402F72E RID: 194350
		[Token(Token = "0x402F72E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorHard;

		// Token: 0x0402F72F RID: 194351
		[Token(Token = "0x402F72F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0402F730 RID: 194352
		[Token(Token = "0x402F730")]
		[FieldOffset(Offset = "0x98")]
		private int m_currFloor;

		// Token: 0x0402F731 RID: 194353
		[Token(Token = "0x402F731")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_inited;

		// Token: 0x0402F732 RID: 194354
		[Token(Token = "0x402F732")]
		[FieldOffset(Offset = "0xA0")]
		private ClimbTowerEndingTopView.Adapter m_adapter;

		// Token: 0x0402F733 RID: 194355
		[Token(Token = "0x402F733")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerEndingTopViewModel m_cachedModel;

		// Token: 0x0402F734 RID: 194356
		[Token(Token = "0x402F734")]
		[FieldOffset(Offset = "0xB0")]
		private ClimbTowerTowerLayerStack m_TowerlayerStack;

		// Token: 0x0402F735 RID: 194357
		[Token(Token = "0x402F735")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedTowerId;

		// Token: 0x0402F736 RID: 194358
		[Token(Token = "0x402F736")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_canClick;

		// Token: 0x0402F737 RID: 194359
		[Token(Token = "0x402F737")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_cachedIsHardMode;

		// Token: 0x0402F73A RID: 194362
		[Token(Token = "0x402F73A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canClick;

		// Token: 0x0402F73B RID: 194363
		[Token(Token = "0x402F73B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0402F73C RID: 194364
		[Token(Token = "0x402F73C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0402F73D RID: 194365
		[Token(Token = "0x402F73D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F73E RID: 194366
		[Token(Token = "0x402F73E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F73F RID: 194367
		[Token(Token = "0x402F73F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F740 RID: 194368
		[Token(Token = "0x402F740")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F741 RID: 194369
		[Token(Token = "0x402F741")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402F742 RID: 194370
		[Token(Token = "0x402F742")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayFlashSoundFx;

		// Token: 0x0402F743 RID: 194371
		[Token(Token = "0x402F743")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FloorTextAnimCoroutine;

		// Token: 0x0402F744 RID: 194372
		[Token(Token = "0x402F744")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D22 RID: 23842
		[Token(Token = "0x2005D22")]
		private class Adapter : ClimbTowerTowerLayerStackAdapter
		{
			// Token: 0x06022857 RID: 141399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022857")]
			[Address(RVA = "0x1CFD880", Offset = "0x1CFC480", VA = "0x181CFD880")]
			public Adapter(ClimbTowerEndingTopView closure)
			{
			}

			// Token: 0x17005133 RID: 20787
			// (get) Token: 0x06022858 RID: 141400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005133")]
			public override List<ClimbTowerLevelModel> data
			{
				[Token(Token = "0x6022858")]
				[Address(RVA = "0x1CFDB00", Offset = "0x1CFC700", VA = "0x181CFDB00", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005134 RID: 20788
			// (get) Token: 0x06022859 RID: 141401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005134")]
			public override string selectedItem
			{
				[Token(Token = "0x6022859")]
				[Address(RVA = "0x1CFDCF0", Offset = "0x1CFC8F0", VA = "0x181CFDCF0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005135 RID: 20789
			// (get) Token: 0x0602285A RID: 141402 RVA: 0x000BDB88 File Offset: 0x000BBD88
			[Token(Token = "0x17005135")]
			public override int arrowIndex
			{
				[Token(Token = "0x602285A")]
				[Address(RVA = "0x1CFD980", Offset = "0x1CFC580", VA = "0x181CFD980", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602285B RID: 141403 RVA: 0x000BDBA0 File Offset: 0x000BBDA0
			[Token(Token = "0x602285B")]
			[Address(RVA = "0x1CFD550", Offset = "0x1CFC150", VA = "0x181CFD550", Slot = "7")]
			public override bool IsLevelPassed(ClimbTowerLevelModel levelModel)
			{
				return default(bool);
			}

			// Token: 0x0602285C RID: 141404 RVA: 0x000BDBB8 File Offset: 0x000BBDB8
			[Token(Token = "0x602285C")]
			[Address(RVA = "0x1CFD4C0", Offset = "0x1CFC0C0", VA = "0x181CFD4C0", Slot = "8")]
			public override bool IsHardMode()
			{
				return default(bool);
			}

			// Token: 0x17005136 RID: 20790
			// (get) Token: 0x0602285D RID: 141405 RVA: 0x000BDBD0 File Offset: 0x000BBDD0
			[Token(Token = "0x17005136")]
			public override int subCardStageSortBefore
			{
				[Token(Token = "0x602285D")]
				[Address(RVA = "0x1CFDD50", Offset = "0x1CFC950", VA = "0x181CFDD50", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17005137 RID: 20791
			// (get) Token: 0x0602285E RID: 141406 RVA: 0x000BDBE8 File Offset: 0x000BBDE8
			[Token(Token = "0x17005137")]
			public override bool hasSelectedSubCard
			{
				[Token(Token = "0x602285E")]
				[Address(RVA = "0x1CFDC00", Offset = "0x1CFC800", VA = "0x181CFDC00", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005138 RID: 20792
			// (get) Token: 0x0602285F RID: 141407 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005138")]
			public override ClimbTowerTowerLayerBaseSelectArrow selectArrowPrefab
			{
				[Token(Token = "0x602285F")]
				[Address(RVA = "0x1CFDC80", Offset = "0x1CFC880", VA = "0x181CFDC80", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005139 RID: 20793
			// (get) Token: 0x06022860 RID: 141408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005139")]
			public override ClimbTowerTowerLayerBaseGodCardTips godCardTipsPrefab
			{
				[Token(Token = "0x6022860")]
				[Address(RVA = "0x1CFDB90", Offset = "0x1CFC790", VA = "0x181CFDB90", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x0402F745 RID: 194373
			[Token(Token = "0x402F745")]
			[FieldOffset(Offset = "0x28")]
			private ClimbTowerEndingTopView m_closure;

			// Token: 0x0402F746 RID: 194374
			[Token(Token = "0x402F746")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F747 RID: 194375
			[Token(Token = "0x402F747")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x0402F748 RID: 194376
			[Token(Token = "0x402F748")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_selectedItem;

			// Token: 0x0402F749 RID: 194377
			[Token(Token = "0x402F749")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_arrowIndex;

			// Token: 0x0402F74A RID: 194378
			[Token(Token = "0x402F74A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsLevelPassed;

			// Token: 0x0402F74B RID: 194379
			[Token(Token = "0x402F74B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_IsHardMode;

			// Token: 0x0402F74C RID: 194380
			[Token(Token = "0x402F74C")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_subCardStageSortBefore;

			// Token: 0x0402F74D RID: 194381
			[Token(Token = "0x402F74D")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_hasSelectedSubCard;

			// Token: 0x0402F74E RID: 194382
			[Token(Token = "0x402F74E")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_selectArrowPrefab;

			// Token: 0x0402F74F RID: 194383
			[Token(Token = "0x402F74F")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_godCardTipsPrefab;
		}
	}
}
