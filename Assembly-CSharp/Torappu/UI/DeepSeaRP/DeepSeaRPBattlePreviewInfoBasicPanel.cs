using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005110 RID: 20752
	[Token(Token = "0x2005110")]
	public abstract class DeepSeaRPBattlePreviewInfoBasicPanel : DataBinder<DeepSeaRPBattleNodeDetailProperty>, IHotfixable
	{
		// Token: 0x17004771 RID: 18289
		// (get) Token: 0x0601EA4C RID: 125516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004771")]
		public DeepSeaRPBattlePreviewConfigController configController
		{
			[Token(Token = "0x601EA4C")]
			[Address(RVA = "0x1850E30", Offset = "0x184FA30", VA = "0x181850E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EA4D RID: 125517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA4D")]
		[Address(RVA = "0x1850590", Offset = "0x184F190", VA = "0x181850590", Slot = "7")]
		public override void OnValueChanged(DeepSeaRPBattleNodeDetailProperty property)
		{
		}

		// Token: 0x0601EA4E RID: 125518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA4E")]
		[Address(RVA = "0x1850510", Offset = "0x184F110", VA = "0x181850510")]
		public void OnEnter()
		{
		}

		// Token: 0x0601EA4F RID: 125519 RVA: 0x000AF260 File Offset: 0x000AD460
		[Token(Token = "0x601EA4F")]
		[Address(RVA = "0x1850450", Offset = "0x184F050", VA = "0x181850450", Slot = "8")]
		protected virtual bool OnBattleNodeChanged(DeepSeaRPBattleNodeDetailViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601EA50 RID: 125520
		[Token(Token = "0x601EA50")]
		protected abstract void UpdateSwitchTween(DeepSeaRPBattleNodeDetailViewModel viewModel);

		// Token: 0x0601EA51 RID: 125521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA51")]
		[Address(RVA = "0x1850640", Offset = "0x184F240", VA = "0x181850640", Slot = "10")]
		protected virtual void RefreshView(DeepSeaRPBattleNodeDetailViewModel viewModel)
		{
		}

		// Token: 0x0601EA52 RID: 125522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA52")]
		[Address(RVA = "0x18509F0", Offset = "0x184F5F0", VA = "0x1818509F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EA53 RID: 125523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EA53")]
		[Address(RVA = "0x18508E0", Offset = "0x184F4E0", VA = "0x1818508E0")]
		private string _DisplayCostValueFormat(int value)
		{
			return null;
		}

		// Token: 0x0601EA54 RID: 125524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA54")]
		[Address(RVA = "0x1850BB0", Offset = "0x184F7B0", VA = "0x181850BB0")]
		private void _UpdateRewardList(StageViewModel selectedStageModel)
		{
		}

		// Token: 0x0601EA55 RID: 125525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA55")]
		[Address(RVA = "0x1850DC0", Offset = "0x184F9C0", VA = "0x181850DC0")]
		protected DeepSeaRPBattlePreviewInfoBasicPanel()
		{
		}

		// Token: 0x0402917B RID: 168315
		[Token(Token = "0x402917B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _selfAlpha;

		// Token: 0x0402917C RID: 168316
		[Token(Token = "0x402917C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StagePreviewRankView _rankView;

		// Token: 0x0402917D RID: 168317
		[Token(Token = "0x402917D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x0402917E RID: 168318
		[Token(Token = "0x402917E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402917F RID: 168319
		[Token(Token = "0x402917F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDifficulty;

		// Token: 0x04029180 RID: 168320
		[Token(Token = "0x4029180")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x04029181 RID: 168321
		[Token(Token = "0x4029181")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textApCost;

		// Token: 0x04029182 RID: 168322
		[Token(Token = "0x4029182")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _detailBtn;

		// Token: 0x04029183 RID: 168323
		[Token(Token = "0x4029183")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private DeepSeaRPBattlePreviewConfigController _configController;

		// Token: 0x04029184 RID: 168324
		[Token(Token = "0x4029184")]
		[FieldOffset(Offset = "0x68")]
		protected DeepSeaRPBattlePreviewInfoBasicPanel.InfoSwitchTween switchTween;

		// Token: 0x04029185 RID: 168325
		[Token(Token = "0x4029185")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04029186 RID: 168326
		[Token(Token = "0x4029186")]
		[FieldOffset(Offset = "0x78")]
		private DeepSeaRPBattlePreviewInfoBasicPanel.RewardPreviewAdapter m_rewardAdapter;

		// Token: 0x04029187 RID: 168327
		[Token(Token = "0x4029187")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_configController;

		// Token: 0x04029188 RID: 168328
		[Token(Token = "0x4029188")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029189 RID: 168329
		[Token(Token = "0x4029189")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402918A RID: 168330
		[Token(Token = "0x402918A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBattleNodeChanged;

		// Token: 0x0402918B RID: 168331
		[Token(Token = "0x402918B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x0402918C RID: 168332
		[Token(Token = "0x402918C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402918D RID: 168333
		[Token(Token = "0x402918D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DisplayCostValueFormat;

		// Token: 0x0402918E RID: 168334
		[Token(Token = "0x402918E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateRewardList;

		// Token: 0x0402918F RID: 168335
		[Token(Token = "0x402918F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005111 RID: 20753
		[Token(Token = "0x2005111")]
		protected class InfoSwitchTween : UISwitchTween
		{
			// Token: 0x0601EA56 RID: 125526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA56")]
			[Address(RVA = "0x1862B00", Offset = "0x1861700", VA = "0x181862B00")]
			public InfoSwitchTween(DeepSeaRPBattlePreviewInfoBasicPanel closure)
			{
			}

			// Token: 0x0601EA57 RID: 125527 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EA57")]
			[Address(RVA = "0x1862720", Offset = "0x1861320", VA = "0x181862720", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601EA58 RID: 125528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EA58")]
			[Address(RVA = "0x18627E0", Offset = "0x18613E0", VA = "0x1818627E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601EA59 RID: 125529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA59")]
			[Address(RVA = "0x1862640", Offset = "0x1861240", VA = "0x181862640", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601EA5A RID: 125530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA5A")]
			[Address(RVA = "0x18629A0", Offset = "0x18615A0", VA = "0x1818629A0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601EA5B RID: 125531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA5B")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601EA5C RID: 125532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA5C")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04029190 RID: 168336
			[Token(Token = "0x4029190")]
			[FieldOffset(Offset = "0x48")]
			private DeepSeaRPBattlePreviewInfoBasicPanel m_closure;

			// Token: 0x04029191 RID: 168337
			[Token(Token = "0x4029191")]
			private const float HIDE_POSITION_Y = 400f;

			// Token: 0x04029192 RID: 168338
			[Token(Token = "0x4029192")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029193 RID: 168339
			[Token(Token = "0x4029193")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04029194 RID: 168340
			[Token(Token = "0x4029194")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04029195 RID: 168341
			[Token(Token = "0x4029195")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04029196 RID: 168342
			[Token(Token = "0x4029196")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02005112 RID: 20754
		[Token(Token = "0x2005112")]
		private class RewardPreviewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004772 RID: 18290
			// (get) Token: 0x0601EA5D RID: 125533 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601EA5E RID: 125534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004772")]
			public List<StageRewardViewModel> cardModels
			{
				[Token(Token = "0x601EA5D")]
				[Address(RVA = "0x1863270", Offset = "0x1861E70", VA = "0x181863270")]
				get
				{
					return null;
				}
				[Token(Token = "0x601EA5E")]
				[Address(RVA = "0x18633E0", Offset = "0x1861FE0", VA = "0x1818633E0")]
				set
				{
				}
			}

			// Token: 0x17004773 RID: 18291
			// (get) Token: 0x0601EA5F RID: 125535 RVA: 0x000AF278 File Offset: 0x000AD478
			[Token(Token = "0x17004773")]
			public override int count
			{
				[Token(Token = "0x601EA5F")]
				[Address(RVA = "0x18632D0", Offset = "0x1861ED0", VA = "0x1818632D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601EA60 RID: 125536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EA60")]
			[Address(RVA = "0x1863050", Offset = "0x1861C50", VA = "0x181863050", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601EA61 RID: 125537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA61")]
			[Address(RVA = "0x1863210", Offset = "0x1861E10", VA = "0x181863210")]
			public RewardPreviewAdapter()
			{
			}

			// Token: 0x04029197 RID: 168343
			[Token(Token = "0x4029197")]
			private const int MAX_ITEM_COUNT = 3;

			// Token: 0x04029198 RID: 168344
			[Token(Token = "0x4029198")]
			[FieldOffset(Offset = "0x20")]
			private List<StageRewardViewModel> m_cardModels;

			// Token: 0x04029199 RID: 168345
			[Token(Token = "0x4029199")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_cardModels;

			// Token: 0x0402919A RID: 168346
			[Token(Token = "0x402919A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_cardModels;

			// Token: 0x0402919B RID: 168347
			[Token(Token = "0x402919B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402919C RID: 168348
			[Token(Token = "0x402919C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402919D RID: 168349
			[Token(Token = "0x402919D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
