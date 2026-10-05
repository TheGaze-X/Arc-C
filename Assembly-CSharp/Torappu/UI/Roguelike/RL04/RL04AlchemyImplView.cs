using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005679 RID: 22137
	[Token(Token = "0x2005679")]
	public class RL04AlchemyImplView : DataBinder<RoguelikeAlchemyImplViewModelProperty>
	{
		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x060207A9 RID: 133033 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060207AA RID: 133034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C1E")]
		public RoguelikeRewardStyle rewardUiStyle
		{
			[Token(Token = "0x60207A9")]
			[Address(RVA = "0x1A9C400", Offset = "0x1A9B000", VA = "0x181A9C400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60207AA")]
			[Address(RVA = "0x1A9C460", Offset = "0x1A9B060", VA = "0x181A9C460")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060207AB RID: 133035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207AB")]
		[Address(RVA = "0x1A9B8B0", Offset = "0x1A9A4B0", VA = "0x181A9B8B0", Slot = "7")]
		public override void OnValueChanged(RoguelikeAlchemyImplViewModelProperty property)
		{
		}

		// Token: 0x060207AC RID: 133036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207AC")]
		[Address(RVA = "0x1A9BF20", Offset = "0x1A9AB20", VA = "0x181A9BF20")]
		public void ResetViewSeqCache()
		{
		}

		// Token: 0x060207AD RID: 133037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207AD")]
		[Address(RVA = "0x1A9BFC0", Offset = "0x1A9ABC0", VA = "0x181A9BFC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207AE RID: 133038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207AE")]
		[Address(RVA = "0x1A9B6A0", Offset = "0x1A9A2A0", VA = "0x181A9B6A0")]
		public void EventOnLeaveBtnClick()
		{
		}

		// Token: 0x060207AF RID: 133039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207AF")]
		[Address(RVA = "0x1A9B610", Offset = "0x1A9A210", VA = "0x181A9B610")]
		public void EventOnCancelLeaveClick()
		{
		}

		// Token: 0x060207B0 RID: 133040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207B0")]
		[Address(RVA = "0x1A9B730", Offset = "0x1A9A330", VA = "0x181A9B730")]
		public void EventOnStartAlchemyBtnClick()
		{
		}

		// Token: 0x060207B1 RID: 133041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207B1")]
		[Address(RVA = "0x1A9C360", Offset = "0x1A9AF60", VA = "0x181A9C360")]
		public RL04AlchemyImplView()
		{
		}

		// Token: 0x0402BFFB RID: 180219
		[Token(Token = "0x402BFFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL04AlchemyForecastView _forecastView;

		// Token: 0x0402BFFC RID: 180220
		[Token(Token = "0x402BFFC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL04AlchemySlotListView _slotListView;

		// Token: 0x0402BFFD RID: 180221
		[Token(Token = "0x402BFFD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL04AlchemyFragmentStorageView _fragmentStorageView;

		// Token: 0x0402BFFE RID: 180222
		[Token(Token = "0x402BFFE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("AlchemyBtn Part")]
		private CanvasGroup _canvasAlchemyBtnNotReady;

		// Token: 0x0402BFFF RID: 180223
		[Token(Token = "0x402BFFF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("AlchemyBtn Part")]
		private CanvasGroup _canvasAlchemyBtnReady;

		// Token: 0x0402C000 RID: 180224
		[Token(Token = "0x402C000")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("AlchemyBtn Part")]
		private CanvasGroup _canvasAlchemyBtnCant;

		// Token: 0x0402C001 RID: 180225
		[Token(Token = "0x402C001")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("LeaveBtn Part")]
		private GameObject _objLeaveBtnOpeningBlock;

		// Token: 0x0402C002 RID: 180226
		[Token(Token = "0x402C002")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("LeaveBtn Part")]
		private UIAnimationLocation _leaveBtnAnim;

		// Token: 0x0402C003 RID: 180227
		[Token(Token = "0x402C003")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tips Part")]
		private CanvasGroup _canvasAlchemyTips;

		// Token: 0x0402C004 RID: 180228
		[Token(Token = "0x402C004")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Tips Part")]
		private Text _txtTipsAlchemy;

		// Token: 0x0402C005 RID: 180229
		[Token(Token = "0x402C005")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tips Part")]
		private Text _txtTipsAlchemy1;

		// Token: 0x0402C006 RID: 180230
		[Token(Token = "0x402C006")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Result Part")]
		private RL04AlchemyResultView _resultView;

		// Token: 0x0402C008 RID: 180232
		[Token(Token = "0x402C008")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0402C009 RID: 180233
		[Token(Token = "0x402C009")]
		[FieldOffset(Offset = "0x98")]
		private string m_topicId;

		// Token: 0x0402C00A RID: 180234
		[Token(Token = "0x402C00A")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_tweenAlchemyTips;

		// Token: 0x0402C00B RID: 180235
		[Token(Token = "0x402C00B")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_tweenAlchemyBtnNotReady;

		// Token: 0x0402C00C RID: 180236
		[Token(Token = "0x402C00C")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_tweenAlchemyBtnReady;

		// Token: 0x0402C00D RID: 180237
		[Token(Token = "0x402C00D")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_tweenAlchemyBtnCant;

		// Token: 0x0402C00E RID: 180238
		[Token(Token = "0x402C00E")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_leaveBtnAnimTween;

		// Token: 0x0402C00F RID: 180239
		[Token(Token = "0x402C00F")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_cachedIsInDisaster;

		// Token: 0x0402C010 RID: 180240
		[Token(Token = "0x402C010")]
		[FieldOffset(Offset = "0xCC")]
		private RL04AlchemyForecastViewModel.ForecastStatus m_cachedForecastStatus;

		// Token: 0x0402C011 RID: 180241
		[Token(Token = "0x402C011")]
		[FieldOffset(Offset = "0xD0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402C012 RID: 180242
		[Token(Token = "0x402C012")]
		[FieldOffset(Offset = "0xE0")]
		private string m_tipsStartAlchemyBtnNotReady;

		// Token: 0x0402C013 RID: 180243
		[Token(Token = "0x402C013")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rewardUiStyle;

		// Token: 0x0402C014 RID: 180244
		[Token(Token = "0x402C014")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rewardUiStyle;

		// Token: 0x0402C015 RID: 180245
		[Token(Token = "0x402C015")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402C016 RID: 180246
		[Token(Token = "0x402C016")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetViewSeqCache;

		// Token: 0x0402C017 RID: 180247
		[Token(Token = "0x402C017")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C018 RID: 180248
		[Token(Token = "0x402C018")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnLeaveBtnClick;

		// Token: 0x0402C019 RID: 180249
		[Token(Token = "0x402C019")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCancelLeaveClick;

		// Token: 0x0402C01A RID: 180250
		[Token(Token = "0x402C01A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnStartAlchemyBtnClick;

		// Token: 0x0402C01B RID: 180251
		[Token(Token = "0x402C01B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
