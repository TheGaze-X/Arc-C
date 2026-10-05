using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200472C RID: 18220
	[Token(Token = "0x200472C")]
	public class RecruitGachaConfirmView : PageSingleComponent
	{
		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x0601B9D5 RID: 113109 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B9D6 RID: 113110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041AE")]
		public Action<string> action
		{
			[Token(Token = "0x601B9D5")]
			[Address(RVA = "0x14FFEC0", Offset = "0x14FEAC0", VA = "0x1814FFEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B9D6")]
			[Address(RVA = "0x14FFF80", Offset = "0x14FEB80", VA = "0x1814FFF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x0601B9D7 RID: 113111 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B9D8 RID: 113112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041AF")]
		public string inputPoolId
		{
			[Token(Token = "0x601B9D7")]
			[Address(RVA = "0x14FFF20", Offset = "0x14FEB20", VA = "0x1814FFF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B9D8")]
			[Address(RVA = "0x1500000", Offset = "0x14FEC00", VA = "0x181500000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B9D9 RID: 113113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9D9")]
		[Address(RVA = "0x14FF880", Offset = "0x14FE480", VA = "0x1814FF880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B9DA RID: 113114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9DA")]
		[Address(RVA = "0x14FF270", Offset = "0x14FDE70", VA = "0x1814FF270")]
		public static void SingleGacha(Action<string> gachaEvent, string poolId, RecruitDataConverter.SingleGachaPolicy policy)
		{
		}

		// Token: 0x0601B9DB RID: 113115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9DB")]
		[Address(RVA = "0x14FED70", Offset = "0x14FD970", VA = "0x1814FED70")]
		public static void BatchedGacha(Action<string> gachaEvent, string poolId, RecruitDataConverter.TenGachaPolicy policy)
		{
		}

		// Token: 0x0601B9DC RID: 113116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9DC")]
		[Address(RVA = "0x14FEEF0", Offset = "0x14FDAF0", VA = "0x1814FEEF0")]
		public static void BuyUnlockSlot(Action<string> unlockEvent, string index, int price)
		{
		}

		// Token: 0x0601B9DD RID: 113117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9DD")]
		[Address(RVA = "0x14FF050", Offset = "0x14FDC50", VA = "0x1814FF050")]
		public void Dismiss()
		{
		}

		// Token: 0x0601B9DE RID: 113118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9DE")]
		[Address(RVA = "0x14FFAC0", Offset = "0x14FE6C0", VA = "0x1814FFAC0")]
		private void _SetStatusByDisplayConfig(RecruitGachaConfirmView.DisplayConfig config)
		{
		}

		// Token: 0x0601B9DF RID: 113119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B9DF")]
		[Address(RVA = "0x14FF5A0", Offset = "0x14FE1A0", VA = "0x1814FF5A0")]
		private List<UIItemViewModel> _GenerateItemFromDisplayConfig(RecruitGachaConfirmView.DisplayConfig config, bool isTargetItem)
		{
			return null;
		}

		// Token: 0x0601B9E0 RID: 113120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9E0")]
		[Address(RVA = "0x14FF0C0", Offset = "0x14FDCC0", VA = "0x1814FF0C0")]
		public void OnClick()
		{
		}

		// Token: 0x0601B9E1 RID: 113121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9E1")]
		[Address(RVA = "0x14FFDD0", Offset = "0x14FE9D0", VA = "0x1814FFDD0")]
		public RecruitGachaConfirmView()
		{
		}

		// Token: 0x04023CC6 RID: 146630
		[Token(Token = "0x4023CC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _soldText;

		// Token: 0x04023CC7 RID: 146631
		[Token(Token = "0x4023CC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x04023CC8 RID: 146632
		[Token(Token = "0x4023CC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04023CC9 RID: 146633
		[Token(Token = "0x4023CC9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _stateIcon;

		// Token: 0x04023CCA RID: 146634
		[Token(Token = "0x4023CCA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _costContent;

		// Token: 0x04023CCB RID: 146635
		[Token(Token = "0x4023CCB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _targetContent;

		// Token: 0x04023CCC RID: 146636
		[Token(Token = "0x4023CCC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _needDSTip;

		// Token: 0x04023CCD RID: 146637
		[Token(Token = "0x4023CCD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _needDSNum;

		// Token: 0x04023CCE RID: 146638
		[Token(Token = "0x4023CCE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _usedOutItemColor;

		// Token: 0x04023CCF RID: 146639
		[Token(Token = "0x4023CCF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _bugDiamondShardIcon;

		// Token: 0x04023CD2 RID: 146642
		[Token(Token = "0x4023CD2")]
		[FieldOffset(Offset = "0x88")]
		private int m_cacheDiamond;

		// Token: 0x04023CD3 RID: 146643
		[Token(Token = "0x4023CD3")]
		[FieldOffset(Offset = "0x90")]
		private RecruitGachaConfirmView.CostItemAdapter m_costAdapter;

		// Token: 0x04023CD4 RID: 146644
		[Token(Token = "0x4023CD4")]
		[FieldOffset(Offset = "0x98")]
		private RecruitGachaConfirmView.CostItemAdapter m_targetAdapter;

		// Token: 0x04023CD5 RID: 146645
		[Token(Token = "0x4023CD5")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIItemViewModel> m_costItemModelList;

		// Token: 0x04023CD6 RID: 146646
		[Token(Token = "0x4023CD6")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIItemViewModel> m_targetItemModelList;

		// Token: 0x04023CD7 RID: 146647
		[Token(Token = "0x4023CD7")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_initFlag;

		// Token: 0x04023CD8 RID: 146648
		[Token(Token = "0x4023CD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_action;

		// Token: 0x04023CD9 RID: 146649
		[Token(Token = "0x4023CD9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_action;

		// Token: 0x04023CDA RID: 146650
		[Token(Token = "0x4023CDA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_inputPoolId;

		// Token: 0x04023CDB RID: 146651
		[Token(Token = "0x4023CDB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_inputPoolId;

		// Token: 0x04023CDC RID: 146652
		[Token(Token = "0x4023CDC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023CDD RID: 146653
		[Token(Token = "0x4023CDD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SingleGacha;

		// Token: 0x04023CDE RID: 146654
		[Token(Token = "0x4023CDE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BatchedGacha;

		// Token: 0x04023CDF RID: 146655
		[Token(Token = "0x4023CDF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BuyUnlockSlot;

		// Token: 0x04023CE0 RID: 146656
		[Token(Token = "0x4023CE0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x04023CE1 RID: 146657
		[Token(Token = "0x4023CE1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetStatusByDisplayConfig;

		// Token: 0x04023CE2 RID: 146658
		[Token(Token = "0x4023CE2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenerateItemFromDisplayConfig;

		// Token: 0x04023CE3 RID: 146659
		[Token(Token = "0x4023CE3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04023CE4 RID: 146660
		[Token(Token = "0x4023CE4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200472D RID: 18221
		[Token(Token = "0x200472D")]
		private struct DisplayConfig : IHotfixable
		{
			// Token: 0x170041B0 RID: 16816
			// (get) Token: 0x0601B9E2 RID: 113122 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B9E3 RID: 113123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170041B0")]
			public List<RecruitGachaConfirmView.CostItemModel> costItemList
			{
				[Token(Token = "0x601B9E2")]
				[Address(RVA = "0x14F2820", Offset = "0x14F1420", VA = "0x1814F2820")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x601B9E3")]
				[Address(RVA = "0x14F2BE0", Offset = "0x14F17E0", VA = "0x1814F2BE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170041B1 RID: 16817
			// (get) Token: 0x0601B9E4 RID: 113124 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B9E5 RID: 113125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170041B1")]
			public string costText
			{
				[Token(Token = "0x601B9E4")]
				[Address(RVA = "0x14F28E0", Offset = "0x14F14E0", VA = "0x1814F28E0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x601B9E5")]
				[Address(RVA = "0x14F2CD0", Offset = "0x14F18D0", VA = "0x1814F2CD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170041B2 RID: 16818
			// (get) Token: 0x0601B9E6 RID: 113126 RVA: 0x000A5A98 File Offset: 0x000A3C98
			// (set) Token: 0x0601B9E7 RID: 113127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170041B2")]
			public bool showStateIcon
			{
				[Token(Token = "0x601B9E6")]
				[Address(RVA = "0x14F2B20", Offset = "0x14F1720", VA = "0x1814F2B20")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x601B9E7")]
				[Address(RVA = "0x14F2F80", Offset = "0x14F1B80", VA = "0x1814F2F80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170041B3 RID: 16819
			// (get) Token: 0x0601B9E8 RID: 113128 RVA: 0x000A5AB0 File Offset: 0x000A3CB0
			// (set) Token: 0x0601B9E9 RID: 113129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170041B3")]
			public bool showNeedDSTip
			{
				[Token(Token = "0x601B9E8")]
				[Address(RVA = "0x14F2A60", Offset = "0x14F1660", VA = "0x1814F2A60")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x601B9E9")]
				[Address(RVA = "0x14F2EA0", Offset = "0x14F1AA0", VA = "0x1814F2EA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170041B4 RID: 16820
			// (get) Token: 0x0601B9EA RID: 113130 RVA: 0x000A5AC8 File Offset: 0x000A3CC8
			// (set) Token: 0x0601B9EB RID: 113131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170041B4")]
			public int needDSNum
			{
				[Token(Token = "0x601B9EA")]
				[Address(RVA = "0x14F29A0", Offset = "0x14F15A0", VA = "0x1814F29A0")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x601B9EB")]
				[Address(RVA = "0x14F2DC0", Offset = "0x14F19C0", VA = "0x1814F2DC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601B9EC RID: 113132 RVA: 0x000A5AE0 File Offset: 0x000A3CE0
			[Token(Token = "0x601B9EC")]
			[Address(RVA = "0x14F12A0", Offset = "0x14EFEA0", VA = "0x1814F12A0")]
			public static RecruitGachaConfirmView.DisplayConfig CreateSingle(string poolId, RecruitDataConverter.SingleGachaPolicy policy)
			{
				return default(RecruitGachaConfirmView.DisplayConfig);
			}

			// Token: 0x0601B9ED RID: 113133 RVA: 0x000A5AF8 File Offset: 0x000A3CF8
			[Token(Token = "0x601B9ED")]
			[Address(RVA = "0x14F0ED0", Offset = "0x14EFAD0", VA = "0x1814F0ED0")]
			public static RecruitGachaConfirmView.DisplayConfig CreateBatched(string poolId, RecruitDataConverter.TenGachaPolicy policy)
			{
				return default(RecruitGachaConfirmView.DisplayConfig);
			}

			// Token: 0x0601B9EE RID: 113134 RVA: 0x000A5B10 File Offset: 0x000A3D10
			[Token(Token = "0x601B9EE")]
			[Address(RVA = "0x14F14B0", Offset = "0x14F00B0", VA = "0x1814F14B0")]
			public static RecruitGachaConfirmView.DisplayConfig CreateUnlockSlot(string index, int diamondCost)
			{
				return default(RecruitGachaConfirmView.DisplayConfig);
			}

			// Token: 0x0601B9EF RID: 113135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9EF")]
			[Address(RVA = "0x14F20F0", Offset = "0x14F0CF0", VA = "0x1814F20F0")]
			private void _LoadDataForDiamondGacha(string poolId, int rate)
			{
			}

			// Token: 0x0601B9F0 RID: 113136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9F0")]
			[Address(RVA = "0x14F25C0", Offset = "0x14F11C0", VA = "0x1814F25C0")]
			private void _LoadDataForSingleGachaTkt(string poolId, int count)
			{
			}

			// Token: 0x0601B9F1 RID: 113137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9F1")]
			[Address(RVA = "0x14F1E90", Offset = "0x14F0A90", VA = "0x1814F1E90")]
			private void _LoadDataForClassicSingleGachaTkt(string poolId, int count)
			{
			}

			// Token: 0x0601B9F2 RID: 113138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9F2")]
			[Address(RVA = "0x14F2370", Offset = "0x14F0F70", VA = "0x1814F2370")]
			private void _LoadDataForNormalSingleGachaTkt(string poolId, string itemId, ItemType itemType, int itemCurCount)
			{
			}

			// Token: 0x0601B9F3 RID: 113139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B9F3")]
			[Address(RVA = "0x14F1CB0", Offset = "0x14F08B0", VA = "0x1814F1CB0")]
			private static List<RecruitGachaConfirmView.CostItemModel> _LoadCostItemFromCombineGacha(List<RecruitDataConverter.CombineGachaItemWithType> combineItemList)
			{
				return null;
			}

			// Token: 0x0601B9F4 RID: 113140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B9F4")]
			[Address(RVA = "0x14F17E0", Offset = "0x14F03E0", VA = "0x1814F17E0")]
			private static RecruitGachaConfirmView.CostItemModel _GenerateCostItemModel(RecruitDataConverter.CombineGachaItemWithType combineGachaItem, int currentCount)
			{
				return null;
			}

			// Token: 0x0601B9F5 RID: 113141 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B9F5")]
			[Address(RVA = "0x14F19D0", Offset = "0x14F05D0", VA = "0x1814F19D0")]
			private static string _GenerateCostTextFromItemList(List<RecruitGachaConfirmView.CostItemModel> itemList)
			{
				return null;
			}

			// Token: 0x04023CEA RID: 146666
			[Token(Token = "0x4023CEA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_costItemList;

			// Token: 0x04023CEB RID: 146667
			[Token(Token = "0x4023CEB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_costItemList;

			// Token: 0x04023CEC RID: 146668
			[Token(Token = "0x4023CEC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_costText;

			// Token: 0x04023CED RID: 146669
			[Token(Token = "0x4023CED")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_costText;

			// Token: 0x04023CEE RID: 146670
			[Token(Token = "0x4023CEE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_showStateIcon;

			// Token: 0x04023CEF RID: 146671
			[Token(Token = "0x4023CEF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_showStateIcon;

			// Token: 0x04023CF0 RID: 146672
			[Token(Token = "0x4023CF0")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_showNeedDSTip;

			// Token: 0x04023CF1 RID: 146673
			[Token(Token = "0x4023CF1")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_showNeedDSTip;

			// Token: 0x04023CF2 RID: 146674
			[Token(Token = "0x4023CF2")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_needDSNum;

			// Token: 0x04023CF3 RID: 146675
			[Token(Token = "0x4023CF3")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_needDSNum;

			// Token: 0x04023CF4 RID: 146676
			[Token(Token = "0x4023CF4")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_CreateSingle;

			// Token: 0x04023CF5 RID: 146677
			[Token(Token = "0x4023CF5")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_CreateBatched;

			// Token: 0x04023CF6 RID: 146678
			[Token(Token = "0x4023CF6")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_CreateUnlockSlot;

			// Token: 0x04023CF7 RID: 146679
			[Token(Token = "0x4023CF7")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__LoadDataForDiamondGacha;

			// Token: 0x04023CF8 RID: 146680
			[Token(Token = "0x4023CF8")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0__LoadDataForSingleGachaTkt;

			// Token: 0x04023CF9 RID: 146681
			[Token(Token = "0x4023CF9")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0__LoadDataForClassicSingleGachaTkt;

			// Token: 0x04023CFA RID: 146682
			[Token(Token = "0x4023CFA")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__LoadDataForNormalSingleGachaTkt;

			// Token: 0x04023CFB RID: 146683
			[Token(Token = "0x4023CFB")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0__LoadCostItemFromCombineGacha;

			// Token: 0x04023CFC RID: 146684
			[Token(Token = "0x4023CFC")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0__GenerateCostItemModel;

			// Token: 0x04023CFD RID: 146685
			[Token(Token = "0x4023CFD")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0__GenerateCostTextFromItemList;
		}

		// Token: 0x0200472E RID: 18222
		[Token(Token = "0x200472E")]
		private class CostItemModel : IHotfixable
		{
			// Token: 0x0601B9F6 RID: 113142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9F6")]
			[Address(RVA = "0x14F0E70", Offset = "0x14EFA70", VA = "0x1814F0E70")]
			public CostItemModel()
			{
			}

			// Token: 0x04023CFE RID: 146686
			[Token(Token = "0x4023CFE")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04023CFF RID: 146687
			[Token(Token = "0x4023CFF")]
			[FieldOffset(Offset = "0x18")]
			public ItemType itemType;

			// Token: 0x04023D00 RID: 146688
			[Token(Token = "0x4023D00")]
			[FieldOffset(Offset = "0x1C")]
			public int countFrom;

			// Token: 0x04023D01 RID: 146689
			[Token(Token = "0x4023D01")]
			[FieldOffset(Offset = "0x20")]
			public int countTo;

			// Token: 0x04023D02 RID: 146690
			[Token(Token = "0x4023D02")]
			[FieldOffset(Offset = "0x24")]
			public int costCount;

			// Token: 0x04023D03 RID: 146691
			[Token(Token = "0x4023D03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200472F RID: 18223
		[Token(Token = "0x200472F")]
		private class CostItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B9F7 RID: 113143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9F7")]
			[Address(RVA = "0x14F0C90", Offset = "0x14EF890", VA = "0x1814F0C90")]
			public CostItemAdapter(RecruitGachaConfirmView closure)
			{
			}

			// Token: 0x170041B5 RID: 16821
			// (set) Token: 0x0601B9F8 RID: 113144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170041B5")]
			public List<UIItemViewModel> itemList
			{
				[Token(Token = "0x601B9F8")]
				[Address(RVA = "0x14F0DF0", Offset = "0x14EF9F0", VA = "0x1814F0DF0")]
				set
				{
				}
			}

			// Token: 0x170041B6 RID: 16822
			// (get) Token: 0x0601B9F9 RID: 113145 RVA: 0x000A5B28 File Offset: 0x000A3D28
			[Token(Token = "0x170041B6")]
			public override int count
			{
				[Token(Token = "0x601B9F9")]
				[Address(RVA = "0x14F0D10", Offset = "0x14EF910", VA = "0x1814F0D10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170041B7 RID: 16823
			// (set) Token: 0x0601B9FA RID: 113146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170041B7")]
			public bool ignoreUsedOutStyle
			{
				[Token(Token = "0x601B9FA")]
				[Address(RVA = "0x14F0D80", Offset = "0x14EF980", VA = "0x1814F0D80")]
				set
				{
				}
			}

			// Token: 0x0601B9FB RID: 113147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B9FB")]
			[Address(RVA = "0x14F0840", Offset = "0x14EF440", VA = "0x1814F0840", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B9FC RID: 113148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B9FC")]
			[Address(RVA = "0x14F0B80", Offset = "0x14EF780", VA = "0x1814F0B80")]
			private void _OnItemCardClicked(int position)
			{
			}

			// Token: 0x04023D04 RID: 146692
			[Token(Token = "0x4023D04")]
			[FieldOffset(Offset = "0x20")]
			private RecruitGachaConfirmView m_closure;

			// Token: 0x04023D05 RID: 146693
			[Token(Token = "0x4023D05")]
			[FieldOffset(Offset = "0x28")]
			private List<UIItemViewModel> m_itemList;

			// Token: 0x04023D06 RID: 146694
			[Token(Token = "0x4023D06")]
			[FieldOffset(Offset = "0x30")]
			private bool m_ignoreUsedOutStyle;

			// Token: 0x04023D07 RID: 146695
			[Token(Token = "0x4023D07")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023D08 RID: 146696
			[Token(Token = "0x4023D08")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_itemList;

			// Token: 0x04023D09 RID: 146697
			[Token(Token = "0x4023D09")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023D0A RID: 146698
			[Token(Token = "0x4023D0A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_ignoreUsedOutStyle;

			// Token: 0x04023D0B RID: 146699
			[Token(Token = "0x4023D0B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04023D0C RID: 146700
			[Token(Token = "0x4023D0C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__OnItemCardClicked;
		}
	}
}
