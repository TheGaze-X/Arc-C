using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CA0 RID: 23712
	[Token(Token = "0x2005CA0")]
	public class ClimbTowerLevelPreviewView : DataBinder<ClimbTowerLevelPreviewProperty>
	{
		// Token: 0x1700509A RID: 20634
		// (set) Token: 0x06022531 RID: 140593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700509A")]
		public Action<List<EnemyHandBookEverViewModel>, int> enemyHandbookBtnCallback
		{
			[Token(Token = "0x6022531")]
			[Address(RVA = "0x1CBE570", Offset = "0x1CBD170", VA = "0x181CBE570")]
			set
			{
			}
		}

		// Token: 0x1700509B RID: 20635
		// (set) Token: 0x06022532 RID: 140594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700509B")]
		public Action rewardDetailBtnCallback
		{
			[Token(Token = "0x6022532")]
			[Address(RVA = "0x1CBE5F0", Offset = "0x1CBD1F0", VA = "0x181CBE5F0")]
			set
			{
			}
		}

		// Token: 0x06022533 RID: 140595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022533")]
		[Address(RVA = "0x1CBE1A0", Offset = "0x1CBCDA0", VA = "0x181CBE1A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022534 RID: 140596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022534")]
		[Address(RVA = "0x1CBDEF0", Offset = "0x1CBCAF0", VA = "0x181CBDEF0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerLevelPreviewProperty property)
		{
		}

		// Token: 0x06022535 RID: 140597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022535")]
		[Address(RVA = "0x1CBE500", Offset = "0x1CBD100", VA = "0x181CBE500")]
		public ClimbTowerLevelPreviewView()
		{
		}

		// Token: 0x0402F224 RID: 193060
		[Token(Token = "0x402F224")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _transLayerHolder;

		// Token: 0x0402F225 RID: 193061
		[Token(Token = "0x402F225")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClimbTowerTowerLayerStack _towerLayerPrefab;

		// Token: 0x0402F226 RID: 193062
		[Token(Token = "0x402F226")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClimbTowerPanelPreviewLevel _panelLevelPrefab;

		// Token: 0x0402F227 RID: 193063
		[Token(Token = "0x402F227")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ClimbTowerPanelPreviewBoss _panelBossPrefab;

		// Token: 0x0402F228 RID: 193064
		[Token(Token = "0x402F228")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBtnUp;

		// Token: 0x0402F229 RID: 193065
		[Token(Token = "0x402F229")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBtnDown;

		// Token: 0x0402F22A RID: 193066
		[Token(Token = "0x402F22A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasBossInfoSelected;

		// Token: 0x0402F22B RID: 193067
		[Token(Token = "0x402F22B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgBoss;

		// Token: 0x0402F22C RID: 193068
		[Token(Token = "0x402F22C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _panelHolder;

		// Token: 0x0402F22D RID: 193069
		[Token(Token = "0x402F22D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ClimbTowerTowerLayerSelectArrowSimple _selectArrowPrefab;

		// Token: 0x0402F22E RID: 193070
		[Token(Token = "0x402F22E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerTowerLayerGodCardTipsSimple _godCardTipsPrefab;

		// Token: 0x0402F22F RID: 193071
		[Token(Token = "0x402F22F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0402F230 RID: 193072
		[Token(Token = "0x402F230")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedTowerId;

		// Token: 0x0402F231 RID: 193073
		[Token(Token = "0x402F231")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerLevelPreviewView.Adapter m_adapter;

		// Token: 0x0402F232 RID: 193074
		[Token(Token = "0x402F232")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerLevelPreviewViewModel m_cachedModel;

		// Token: 0x0402F233 RID: 193075
		[Token(Token = "0x402F233")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_bossInfoBtnSelectedSwitchTween;

		// Token: 0x0402F234 RID: 193076
		[Token(Token = "0x402F234")]
		[FieldOffset(Offset = "0xA0")]
		private ClimbTowerPanelPreviewLevel m_panelPreviewLevel;

		// Token: 0x0402F235 RID: 193077
		[Token(Token = "0x402F235")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerPanelPreviewBoss m_panelPreviewBoss;

		// Token: 0x0402F236 RID: 193078
		[Token(Token = "0x402F236")]
		[FieldOffset(Offset = "0xB0")]
		private ClimbTowerTowerLayerStack m_towerLayerView;

		// Token: 0x0402F237 RID: 193079
		[Token(Token = "0x402F237")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cachedIsHardMode;

		// Token: 0x0402F238 RID: 193080
		[Token(Token = "0x402F238")]
		[FieldOffset(Offset = "0xC0")]
		private Action<List<EnemyHandBookEverViewModel>, int> m_enemyHandbookBtnCallback;

		// Token: 0x0402F239 RID: 193081
		[Token(Token = "0x402F239")]
		[FieldOffset(Offset = "0xC8")]
		private Action m_rewardDetailBtnCallback;

		// Token: 0x0402F23A RID: 193082
		[Token(Token = "0x402F23A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_enemyHandbookBtnCallback;

		// Token: 0x0402F23B RID: 193083
		[Token(Token = "0x402F23B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rewardDetailBtnCallback;

		// Token: 0x0402F23C RID: 193084
		[Token(Token = "0x402F23C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F23D RID: 193085
		[Token(Token = "0x402F23D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F23E RID: 193086
		[Token(Token = "0x402F23E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CA1 RID: 23713
		[Token(Token = "0x2005CA1")]
		private class Adapter : ClimbTowerTowerLayerStackAdapter
		{
			// Token: 0x06022536 RID: 140598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022536")]
			[Address(RVA = "0x1CB83C0", Offset = "0x1CB6FC0", VA = "0x181CB83C0")]
			public Adapter(ClimbTowerLevelPreviewView closure)
			{
			}

			// Token: 0x1700509C RID: 20636
			// (get) Token: 0x06022537 RID: 140599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700509C")]
			public override List<ClimbTowerLevelModel> data
			{
				[Token(Token = "0x6022537")]
				[Address(RVA = "0x1CB8770", Offset = "0x1CB7370", VA = "0x181CB8770", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700509D RID: 20637
			// (get) Token: 0x06022538 RID: 140600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700509D")]
			public override string selectedItem
			{
				[Token(Token = "0x6022538")]
				[Address(RVA = "0x1CB8B20", Offset = "0x1CB7720", VA = "0x181CB8B20", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700509E RID: 20638
			// (get) Token: 0x06022539 RID: 140601 RVA: 0x000BD048 File Offset: 0x000BB248
			[Token(Token = "0x1700509E")]
			public override int arrowIndex
			{
				[Token(Token = "0x6022539")]
				[Address(RVA = "0x1CB84E0", Offset = "0x1CB70E0", VA = "0x181CB84E0", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602253A RID: 140602 RVA: 0x000BD060 File Offset: 0x000BB260
			[Token(Token = "0x602253A")]
			[Address(RVA = "0x1CB73E0", Offset = "0x1CB5FE0", VA = "0x181CB73E0", Slot = "7")]
			public override bool IsLevelPassed(ClimbTowerLevelModel levelModel)
			{
				return default(bool);
			}

			// Token: 0x0602253B RID: 140603 RVA: 0x000BD078 File Offset: 0x000BB278
			[Token(Token = "0x602253B")]
			[Address(RVA = "0x1CB72C0", Offset = "0x1CB5EC0", VA = "0x181CB72C0", Slot = "8")]
			public override bool IsHardMode()
			{
				return default(bool);
			}

			// Token: 0x1700509F RID: 20639
			// (get) Token: 0x0602253C RID: 140604 RVA: 0x000BD090 File Offset: 0x000BB290
			[Token(Token = "0x1700509F")]
			public override int subCardStageSortBefore
			{
				[Token(Token = "0x602253C")]
				[Address(RVA = "0x1CB8D30", Offset = "0x1CB7930", VA = "0x181CB8D30", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170050A0 RID: 20640
			// (get) Token: 0x0602253D RID: 140605 RVA: 0x000BD0A8 File Offset: 0x000BB2A8
			[Token(Token = "0x170050A0")]
			public override bool hasSelectedSubCard
			{
				[Token(Token = "0x602253D")]
				[Address(RVA = "0x1CB89E0", Offset = "0x1CB75E0", VA = "0x181CB89E0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170050A1 RID: 20641
			// (get) Token: 0x0602253E RID: 140606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050A1")]
			public override ClimbTowerTowerLayerBaseSelectArrow selectArrowPrefab
			{
				[Token(Token = "0x602253E")]
				[Address(RVA = "0x1CB8AB0", Offset = "0x1CB76B0", VA = "0x181CB8AB0", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x170050A2 RID: 20642
			// (get) Token: 0x0602253F RID: 140607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050A2")]
			public override ClimbTowerTowerLayerBaseGodCardTips godCardTipsPrefab
			{
				[Token(Token = "0x602253F")]
				[Address(RVA = "0x1CB88F0", Offset = "0x1CB74F0", VA = "0x181CB88F0", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x0402F23F RID: 193087
			[Token(Token = "0x402F23F")]
			[FieldOffset(Offset = "0x28")]
			private ClimbTowerLevelPreviewView m_closure;

			// Token: 0x0402F240 RID: 193088
			[Token(Token = "0x402F240")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F241 RID: 193089
			[Token(Token = "0x402F241")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x0402F242 RID: 193090
			[Token(Token = "0x402F242")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_selectedItem;

			// Token: 0x0402F243 RID: 193091
			[Token(Token = "0x402F243")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_arrowIndex;

			// Token: 0x0402F244 RID: 193092
			[Token(Token = "0x402F244")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsLevelPassed;

			// Token: 0x0402F245 RID: 193093
			[Token(Token = "0x402F245")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_IsHardMode;

			// Token: 0x0402F246 RID: 193094
			[Token(Token = "0x402F246")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_subCardStageSortBefore;

			// Token: 0x0402F247 RID: 193095
			[Token(Token = "0x402F247")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_hasSelectedSubCard;

			// Token: 0x0402F248 RID: 193096
			[Token(Token = "0x402F248")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_selectArrowPrefab;

			// Token: 0x0402F249 RID: 193097
			[Token(Token = "0x402F249")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_godCardTipsPrefab;
		}
	}
}
