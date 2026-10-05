using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CA3 RID: 23715
	[Token(Token = "0x2005CA3")]
	public class ClimbTowerPanelPreviewLevel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170050A3 RID: 20643
		// (set) Token: 0x06022542 RID: 140610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050A3")]
		public Action<List<EnemyHandBookEverViewModel>, int> enemyHandbookBtnCallback
		{
			[Token(Token = "0x6022542")]
			[Address(RVA = "0x1CC1060", Offset = "0x1CBFC60", VA = "0x181CC1060")]
			set
			{
			}
		}

		// Token: 0x170050A4 RID: 20644
		// (set) Token: 0x06022543 RID: 140611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050A4")]
		public Action rewardDetailBtnCallback
		{
			[Token(Token = "0x6022543")]
			[Address(RVA = "0x1CC10E0", Offset = "0x1CBFCE0", VA = "0x181CC10E0")]
			set
			{
			}
		}

		// Token: 0x06022544 RID: 140612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022544")]
		[Address(RVA = "0x1CC0BA0", Offset = "0x1CBF7A0", VA = "0x181CC0BA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022545 RID: 140613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022545")]
		[Address(RVA = "0x1CC0D80", Offset = "0x1CBF980", VA = "0x181CC0D80")]
		private void _LoadPreviewMap(string mapPreviewId)
		{
		}

		// Token: 0x06022546 RID: 140614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022546")]
		[Address(RVA = "0x1CC0F50", Offset = "0x1CBFB50", VA = "0x181CC0F50")]
		private void _UnloadPreviewMap()
		{
		}

		// Token: 0x06022547 RID: 140615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022547")]
		[Address(RVA = "0x1CC0890", Offset = "0x1CBF490", VA = "0x181CC0890")]
		public void Render(ClimbTowerLevelModel levelModel, int maxLayer)
		{
		}

		// Token: 0x06022548 RID: 140616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022548")]
		[Address(RVA = "0x1CC0740", Offset = "0x1CBF340", VA = "0x181CC0740")]
		public void OnJumpToEnemyHandbook(int enemyListIdx)
		{
		}

		// Token: 0x06022549 RID: 140617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022549")]
		[Address(RVA = "0x1CC0800", Offset = "0x1CBF400", VA = "0x181CC0800")]
		public void OnJumpToRewardDetailView()
		{
		}

		// Token: 0x0602254A RID: 140618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602254A")]
		[Address(RVA = "0x1CC0FF0", Offset = "0x1CBFBF0", VA = "0x181CC0FF0")]
		public ClimbTowerPanelPreviewLevel()
		{
		}

		// Token: 0x0402F253 RID: 193107
		[Token(Token = "0x402F253")]
		private const string MAX_LAYER_FORMAT = "/{0}";

		// Token: 0x0402F254 RID: 193108
		[Token(Token = "0x402F254")]
		private const int REWARD_PREVIEW_COUNT = 3;

		// Token: 0x0402F255 RID: 193109
		[Token(Token = "0x402F255")]
		private const int ENEMY_HANDBOOK_COUNT = 6;

		// Token: 0x0402F256 RID: 193110
		[Token(Token = "0x402F256")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textLevelNum;

		// Token: 0x0402F257 RID: 193111
		[Token(Token = "0x402F257")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLevelTotalNum;

		// Token: 0x0402F258 RID: 193112
		[Token(Token = "0x402F258")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLevelDesc;

		// Token: 0x0402F259 RID: 193113
		[Token(Token = "0x402F259")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgLevelPreview;

		// Token: 0x0402F25A RID: 193114
		[Token(Token = "0x402F25A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x0402F25B RID: 193115
		[Token(Token = "0x402F25B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _enemyInfoList;

		// Token: 0x0402F25C RID: 193116
		[Token(Token = "0x402F25C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _cardScaleFactor;

		// Token: 0x0402F25D RID: 193117
		[Token(Token = "0x402F25D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelList;

		// Token: 0x0402F25E RID: 193118
		[Token(Token = "0x402F25E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402F25F RID: 193119
		[Token(Token = "0x402F25F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelMore;

		// Token: 0x0402F260 RID: 193120
		[Token(Token = "0x402F260")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedLevelId;

		// Token: 0x0402F261 RID: 193121
		[Token(Token = "0x402F261")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0402F262 RID: 193122
		[Token(Token = "0x402F262")]
		[FieldOffset(Offset = "0x78")]
		private List<StageRewardViewModel> m_cachedReward;

		// Token: 0x0402F263 RID: 193123
		[Token(Token = "0x402F263")]
		[FieldOffset(Offset = "0x80")]
		private List<EnemyHandBookEverViewModel> m_cachedEnemyList;

		// Token: 0x0402F264 RID: 193124
		[Token(Token = "0x402F264")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerPanelPreviewLevel.RewardAdapter m_rewardAdapter;

		// Token: 0x0402F265 RID: 193125
		[Token(Token = "0x402F265")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerPanelPreviewLevel.EnemyInfoAdapter m_enemyInfoAdapter;

		// Token: 0x0402F266 RID: 193126
		[Token(Token = "0x402F266")]
		[FieldOffset(Offset = "0x98")]
		private Action<List<EnemyHandBookEverViewModel>, int> m_enemyHandbookBtnCallback;

		// Token: 0x0402F267 RID: 193127
		[Token(Token = "0x402F267")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_rewardDetailBtnCallback;

		// Token: 0x0402F268 RID: 193128
		[Token(Token = "0x402F268")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_enemyHandbookBtnCallback;

		// Token: 0x0402F269 RID: 193129
		[Token(Token = "0x402F269")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rewardDetailBtnCallback;

		// Token: 0x0402F26A RID: 193130
		[Token(Token = "0x402F26A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F26B RID: 193131
		[Token(Token = "0x402F26B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadPreviewMap;

		// Token: 0x0402F26C RID: 193132
		[Token(Token = "0x402F26C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UnloadPreviewMap;

		// Token: 0x0402F26D RID: 193133
		[Token(Token = "0x402F26D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F26E RID: 193134
		[Token(Token = "0x402F26E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnJumpToEnemyHandbook;

		// Token: 0x0402F26F RID: 193135
		[Token(Token = "0x402F26F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnJumpToRewardDetailView;

		// Token: 0x0402F270 RID: 193136
		[Token(Token = "0x402F270")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CA4 RID: 23716
		[Token(Token = "0x2005CA4")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602254B RID: 140619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602254B")]
			[Address(RVA = "0x1CC8040", Offset = "0x1CC6C40", VA = "0x181CC8040")]
			public RewardAdapter(ClimbTowerPanelPreviewLevel closure)
			{
			}

			// Token: 0x170050A5 RID: 20645
			// (get) Token: 0x0602254C RID: 140620 RVA: 0x000BD0C0 File Offset: 0x000BB2C0
			[Token(Token = "0x170050A5")]
			public override int count
			{
				[Token(Token = "0x602254C")]
				[Address(RVA = "0x1CC80C0", Offset = "0x1CC6CC0", VA = "0x181CC80C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602254D RID: 140621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602254D")]
			[Address(RVA = "0x1CC7DA0", Offset = "0x1CC69A0", VA = "0x181CC7DA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F271 RID: 193137
			[Token(Token = "0x402F271")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerPanelPreviewLevel m_closure;

			// Token: 0x0402F272 RID: 193138
			[Token(Token = "0x402F272")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F273 RID: 193139
			[Token(Token = "0x402F273")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F274 RID: 193140
			[Token(Token = "0x402F274")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005CA5 RID: 23717
		[Token(Token = "0x2005CA5")]
		private class EnemyInfoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602254E RID: 140622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602254E")]
			[Address(RVA = "0x1CC7CC0", Offset = "0x1CC68C0", VA = "0x181CC7CC0")]
			public EnemyInfoAdapter(ClimbTowerPanelPreviewLevel closure)
			{
			}

			// Token: 0x170050A6 RID: 20646
			// (get) Token: 0x0602254F RID: 140623 RVA: 0x000BD0D8 File Offset: 0x000BB2D8
			[Token(Token = "0x170050A6")]
			public override int count
			{
				[Token(Token = "0x602254F")]
				[Address(RVA = "0x1CC7D40", Offset = "0x1CC6940", VA = "0x181CC7D40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022550 RID: 140624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022550")]
			[Address(RVA = "0x1CC7970", Offset = "0x1CC6570", VA = "0x181CC7970", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F275 RID: 193141
			[Token(Token = "0x402F275")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerPanelPreviewLevel m_closure;

			// Token: 0x0402F276 RID: 193142
			[Token(Token = "0x402F276")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F277 RID: 193143
			[Token(Token = "0x402F277")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F278 RID: 193144
			[Token(Token = "0x402F278")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
