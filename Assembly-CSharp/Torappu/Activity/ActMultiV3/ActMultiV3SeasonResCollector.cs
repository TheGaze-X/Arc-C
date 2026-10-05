using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EB6 RID: 28342
	[Token(Token = "0x2006EB6")]
	public class ActMultiV3SeasonResCollector : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x0602851F RID: 165151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F34")]
		public Sprite entryAnimLogo
		{
			[Token(Token = "0x602851F")]
			[Address(RVA = "0x238D1B0", Offset = "0x238BDB0", VA = "0x18238D1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x06028520 RID: 165152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F35")]
		public Sprite entryManualLogo
		{
			[Token(Token = "0x6028520")]
			[Address(RVA = "0x238D210", Offset = "0x238BE10", VA = "0x18238D210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x06028521 RID: 165153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F36")]
		public Sprite entrySeasonLogo
		{
			[Token(Token = "0x6028521")]
			[Address(RVA = "0x238D270", Offset = "0x238BE70", VA = "0x18238D270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x06028522 RID: 165154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F37")]
		public Sprite manualLogo
		{
			[Token(Token = "0x6028522")]
			[Address(RVA = "0x238D2D0", Offset = "0x238BED0", VA = "0x18238D2D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x06028523 RID: 165155 RVA: 0x000D1718 File Offset: 0x000CF918
		[Token(Token = "0x17005F38")]
		public Color seasonThemeColor
		{
			[Token(Token = "0x6028523")]
			[Address(RVA = "0x238D590", Offset = "0x238C190", VA = "0x18238D590")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x06028524 RID: 165156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F39")]
		public Sprite seasonTokenSmallIcon
		{
			[Token(Token = "0x6028524")]
			[Address(RVA = "0x238D610", Offset = "0x238C210", VA = "0x18238D610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x06028525 RID: 165157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F3A")]
		public Sprite seasonBottomBarIcon
		{
			[Token(Token = "0x6028525")]
			[Address(RVA = "0x238D530", Offset = "0x238C130", VA = "0x18238D530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x06028526 RID: 165158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F3B")]
		public GameObject prepareLoopAnimObj
		{
			[Token(Token = "0x6028526")]
			[Address(RVA = "0x238D4D0", Offset = "0x238C0D0", VA = "0x18238D4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x06028527 RID: 165159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F3C")]
		public GameObject matchLoopAnimObj
		{
			[Token(Token = "0x6028527")]
			[Address(RVA = "0x238D330", Offset = "0x238BF30", VA = "0x18238D330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x06028528 RID: 165160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F3D")]
		public Sprite stageDetailSeasonIcon
		{
			[Token(Token = "0x6028528")]
			[Address(RVA = "0x238D670", Offset = "0x238C270", VA = "0x18238D670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x06028529 RID: 165161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F3E")]
		public Sprite entranceShowSeasonIcon
		{
			[Token(Token = "0x6028529")]
			[Address(RVA = "0x238D150", Offset = "0x238BD50", VA = "0x18238D150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x0602852A RID: 165162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F3F")]
		public ActMultiV3MilestoneMainRewardView milestoneMainRewardView
		{
			[Token(Token = "0x602852A")]
			[Address(RVA = "0x238D470", Offset = "0x238C070", VA = "0x18238D470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x0602852B RID: 165163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F40")]
		public Sprite milestoneBg
		{
			[Token(Token = "0x602852B")]
			[Address(RVA = "0x238D390", Offset = "0x238BF90", VA = "0x18238D390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x0602852C RID: 165164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F41")]
		public ActMultiV3SeasonResCollector.BillboardModeLoopAnimConfig[] billboardModeLoopAnims
		{
			[Token(Token = "0x602852C")]
			[Address(RVA = "0x238D0F0", Offset = "0x238BCF0", VA = "0x18238D0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x0602852D RID: 165165 RVA: 0x000D1730 File Offset: 0x000CF930
		[Token(Token = "0x17005F42")]
		public Color milestoneColor
		{
			[Token(Token = "0x602852D")]
			[Address(RVA = "0x238D3F0", Offset = "0x238BFF0", VA = "0x18238D3F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0602852E RID: 165166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602852E")]
		[Address(RVA = "0x238D090", Offset = "0x238BC90", VA = "0x18238D090")]
		public ActMultiV3SeasonResCollector()
		{
		}

		// Token: 0x040394CD RID: 234701
		[Token(Token = "0x40394CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _entryAnimLogo;

		// Token: 0x040394CE RID: 234702
		[Token(Token = "0x40394CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _entryManualLogo;

		// Token: 0x040394CF RID: 234703
		[Token(Token = "0x40394CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Entry")]
		private Sprite _entrySeasonLogo;

		// Token: 0x040394D0 RID: 234704
		[Token(Token = "0x40394D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _seasonThemeColor;

		// Token: 0x040394D1 RID: 234705
		[Token(Token = "0x40394D1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _seasonTokenSmallIcon;

		// Token: 0x040394D2 RID: 234706
		[Token(Token = "0x40394D2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _seasonBottomBarIcon;

		// Token: 0x040394D3 RID: 234707
		[Token(Token = "0x40394D3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Manual")]
		private Sprite _manualLogo;

		// Token: 0x040394D4 RID: 234708
		[Token(Token = "0x40394D4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Prepare")]
		private GameObject _prepareLoopAnimObj;

		// Token: 0x040394D5 RID: 234709
		[Token(Token = "0x40394D5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Prepare")]
		private Sprite _stageDetailSeasonIcon;

		// Token: 0x040394D6 RID: 234710
		[Token(Token = "0x40394D6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Prepare")]
		private Sprite _entranceShowSeasonIcon;

		// Token: 0x040394D7 RID: 234711
		[Token(Token = "0x40394D7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Match")]
		private GameObject _matchLoopAnimObj;

		// Token: 0x040394D8 RID: 234712
		[Token(Token = "0x40394D8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Training")]
		private ActMultiV3SeasonResCollector.BillboardModeLoopAnimConfig[] _billboardModeLoopAnims;

		// Token: 0x040394D9 RID: 234713
		[Token(Token = "0x40394D9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Milestone")]
		private ActMultiV3MilestoneMainRewardView _mainRewardView;

		// Token: 0x040394DA RID: 234714
		[Token(Token = "0x40394DA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Milestone")]
		private Sprite _milestoneBg;

		// Token: 0x040394DB RID: 234715
		[Token(Token = "0x40394DB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Milestone")]
		private Color _milestoneColor;

		// Token: 0x040394DC RID: 234716
		[Token(Token = "0x40394DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_entryAnimLogo;

		// Token: 0x040394DD RID: 234717
		[Token(Token = "0x40394DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_entryManualLogo;

		// Token: 0x040394DE RID: 234718
		[Token(Token = "0x40394DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_entrySeasonLogo;

		// Token: 0x040394DF RID: 234719
		[Token(Token = "0x40394DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_manualLogo;

		// Token: 0x040394E0 RID: 234720
		[Token(Token = "0x40394E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_seasonThemeColor;

		// Token: 0x040394E1 RID: 234721
		[Token(Token = "0x40394E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_seasonTokenSmallIcon;

		// Token: 0x040394E2 RID: 234722
		[Token(Token = "0x40394E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_seasonBottomBarIcon;

		// Token: 0x040394E3 RID: 234723
		[Token(Token = "0x40394E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_prepareLoopAnimObj;

		// Token: 0x040394E4 RID: 234724
		[Token(Token = "0x40394E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_matchLoopAnimObj;

		// Token: 0x040394E5 RID: 234725
		[Token(Token = "0x40394E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_stageDetailSeasonIcon;

		// Token: 0x040394E6 RID: 234726
		[Token(Token = "0x40394E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_entranceShowSeasonIcon;

		// Token: 0x040394E7 RID: 234727
		[Token(Token = "0x40394E7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_milestoneMainRewardView;

		// Token: 0x040394E8 RID: 234728
		[Token(Token = "0x40394E8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_milestoneBg;

		// Token: 0x040394E9 RID: 234729
		[Token(Token = "0x40394E9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_billboardModeLoopAnims;

		// Token: 0x040394EA RID: 234730
		[Token(Token = "0x40394EA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_milestoneColor;

		// Token: 0x040394EB RID: 234731
		[Token(Token = "0x40394EB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006EB7 RID: 28343
		[Token(Token = "0x2006EB7")]
		[Serializable]
		public class BillboardModeLoopAnimConfig
		{
			// Token: 0x17005F43 RID: 24387
			// (get) Token: 0x0602852F RID: 165167 RVA: 0x000D1748 File Offset: 0x000CF948
			[Token(Token = "0x17005F43")]
			public ActMultiV3MapModeType modeType
			{
				[Token(Token = "0x602852F")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return ActMultiV3MapModeType.NONE;
				}
			}

			// Token: 0x17005F44 RID: 24388
			// (get) Token: 0x06028530 RID: 165168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005F44")]
			public ActMultiV3TrainingRoomBillboardView modeBillboardView
			{
				[Token(Token = "0x6028530")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x06028531 RID: 165169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028531")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BillboardModeLoopAnimConfig()
			{
			}

			// Token: 0x040394EC RID: 234732
			[Token(Token = "0x40394EC")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private ActMultiV3MapModeType _modeType;

			// Token: 0x040394ED RID: 234733
			[Token(Token = "0x40394ED")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private ActMultiV3TrainingRoomBillboardView _modeBillboardView;
		}
	}
}
