using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007136 RID: 28982
	[Token(Token = "0x2007136")]
	public class ActAutoChessRewardInfoView : DataBinder<ActAutoChessRewardInfoProperty>, IHotfixable
	{
		// Token: 0x0602925C RID: 168540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602925C")]
		[Address(RVA = "0x248D6A0", Offset = "0x248C2A0", VA = "0x18248D6A0", Slot = "7")]
		public override void OnValueChanged(ActAutoChessRewardInfoProperty property)
		{
		}

		// Token: 0x0602925D RID: 168541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602925D")]
		[Address(RVA = "0x248D600", Offset = "0x248C200", VA = "0x18248D600")]
		public void EventOnSkipBtnClicked()
		{
		}

		// Token: 0x0602925E RID: 168542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602925E")]
		[Address(RVA = "0x248DDA0", Offset = "0x248C9A0", VA = "0x18248DDA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602925F RID: 168543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602925F")]
		[Address(RVA = "0x248D800", Offset = "0x248C400", VA = "0x18248D800")]
		private void _FocusToItem(int targetIndex)
		{
		}

		// Token: 0x06029260 RID: 168544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029260")]
		[Address(RVA = "0x248DF70", Offset = "0x248CB70", VA = "0x18248DF70")]
		public ActAutoChessRewardInfoView()
		{
		}

		// Token: 0x0403AC43 RID: 240707
		[Token(Token = "0x403AC43")]
		private const int SLIDE_MAX_LENGTH = 10;

		// Token: 0x0403AC44 RID: 240708
		[Token(Token = "0x403AC44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActAutoChessRewardInfoAdapter _adapter;

		// Token: 0x0403AC45 RID: 240709
		[Token(Token = "0x403AC45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopHorizontalScrollRect _scrollRect;

		// Token: 0x0403AC46 RID: 240710
		[Token(Token = "0x403AC46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x0403AC47 RID: 240711
		[Token(Token = "0x403AC47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _contentMode;

		// Token: 0x0403AC48 RID: 240712
		[Token(Token = "0x403AC48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _contentDifficulty;

		// Token: 0x0403AC49 RID: 240713
		[Token(Token = "0x403AC49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x0403AC4A RID: 240714
		[Token(Token = "0x403AC4A")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_hasInited;

		// Token: 0x0403AC4B RID: 240715
		[Token(Token = "0x403AC4B")]
		[FieldOffset(Offset = "0x50")]
		private List<ActAutoChessModeRewardModel> m_cachedModeList;

		// Token: 0x0403AC4C RID: 240716
		[Token(Token = "0x403AC4C")]
		[FieldOffset(Offset = "0x58")]
		private List<ActAutoChessDifficultyRewardModel> m_cachedDifficultyList;

		// Token: 0x0403AC4D RID: 240717
		[Token(Token = "0x403AC4D")]
		[FieldOffset(Offset = "0x60")]
		private ActAutoChessRewardInfoView.ModeAdapter m_modeAdapter;

		// Token: 0x0403AC4E RID: 240718
		[Token(Token = "0x403AC4E")]
		[FieldOffset(Offset = "0x68")]
		private ActAutoChessRewardInfoView.DifficultyAdapter m_difficultyAdapter;

		// Token: 0x0403AC4F RID: 240719
		[Token(Token = "0x403AC4F")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_cachedTween;

		// Token: 0x0403AC50 RID: 240720
		[Token(Token = "0x403AC50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403AC51 RID: 240721
		[Token(Token = "0x403AC51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnSkipBtnClicked;

		// Token: 0x0403AC52 RID: 240722
		[Token(Token = "0x403AC52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AC53 RID: 240723
		[Token(Token = "0x403AC53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FocusToItem;

		// Token: 0x0403AC54 RID: 240724
		[Token(Token = "0x403AC54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007137 RID: 28983
		[Token(Token = "0x2007137")]
		private class ModeAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06029263 RID: 168547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029263")]
			[Address(RVA = "0x24907E0", Offset = "0x248F3E0", VA = "0x1824907E0")]
			public ModeAdapter(ActAutoChessRewardInfoView closure)
			{
			}

			// Token: 0x1700616B RID: 24939
			// (get) Token: 0x06029264 RID: 168548 RVA: 0x000D49A0 File Offset: 0x000D2BA0
			[Token(Token = "0x1700616B")]
			public override int count
			{
				[Token(Token = "0x6029264")]
				[Address(RVA = "0x2490860", Offset = "0x248F460", VA = "0x182490860", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029265 RID: 168549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029265")]
			[Address(RVA = "0x2490500", Offset = "0x248F100", VA = "0x182490500", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403AC55 RID: 240725
			[Token(Token = "0x403AC55")]
			[FieldOffset(Offset = "0x20")]
			private ActAutoChessRewardInfoView m_closure;

			// Token: 0x0403AC56 RID: 240726
			[Token(Token = "0x403AC56")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403AC57 RID: 240727
			[Token(Token = "0x403AC57")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403AC58 RID: 240728
			[Token(Token = "0x403AC58")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02007138 RID: 28984
		[Token(Token = "0x2007138")]
		private class DifficultyAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06029266 RID: 168550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029266")]
			[Address(RVA = "0x248FD30", Offset = "0x248E930", VA = "0x18248FD30")]
			public DifficultyAdapter(ActAutoChessRewardInfoView closure)
			{
			}

			// Token: 0x1700616C RID: 24940
			// (get) Token: 0x06029267 RID: 168551 RVA: 0x000D49B8 File Offset: 0x000D2BB8
			[Token(Token = "0x1700616C")]
			public override int count
			{
				[Token(Token = "0x6029267")]
				[Address(RVA = "0x248FDB0", Offset = "0x248E9B0", VA = "0x18248FDB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029268 RID: 168552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029268")]
			[Address(RVA = "0x248FA50", Offset = "0x248E650", VA = "0x18248FA50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403AC59 RID: 240729
			[Token(Token = "0x403AC59")]
			[FieldOffset(Offset = "0x20")]
			private ActAutoChessRewardInfoView m_closure;

			// Token: 0x0403AC5A RID: 240730
			[Token(Token = "0x403AC5A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403AC5B RID: 240731
			[Token(Token = "0x403AC5B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403AC5C RID: 240732
			[Token(Token = "0x403AC5C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
