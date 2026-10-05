using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005307 RID: 21255
	[Token(Token = "0x2005307")]
	public class RoguelikeMenuRelicObject : RoguelikeMenuObject<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x0601F5A4 RID: 128420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5A4")]
		[Address(RVA = "0x1913670", Offset = "0x1912270", VA = "0x181913670", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x0601F5A5 RID: 128421 RVA: 0x000B19C0 File Offset: 0x000AFBC0
		[Token(Token = "0x17004989")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F5A5")]
			[Address(RVA = "0x1914470", Offset = "0x1913070", VA = "0x181914470", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F5A6 RID: 128422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5A6")]
		[Address(RVA = "0x1914190", Offset = "0x1912D90", VA = "0x181914190")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x0601F5A7 RID: 128423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5A7")]
		[Address(RVA = "0x1913A20", Offset = "0x1912620", VA = "0x181913A20", Slot = "7")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F5A8 RID: 128424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5A8")]
		[Address(RVA = "0x1913890", Offset = "0x1912490", VA = "0x181913890", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F5A9 RID: 128425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5A9")]
		[Address(RVA = "0x1913B10", Offset = "0x1912710", VA = "0x181913B10", Slot = "16")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F5AA RID: 128426 RVA: 0x000B19D8 File Offset: 0x000AFBD8
		[Token(Token = "0x601F5AA")]
		[Address(RVA = "0x1913F50", Offset = "0x1912B50", VA = "0x181913F50")]
		private int _GetRelicCount(RoguelikeMenuRelicViewModel viewModel)
		{
			return 0;
		}

		// Token: 0x0601F5AB RID: 128427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5AB")]
		[Address(RVA = "0x1914000", Offset = "0x1912C00", VA = "0x181914000")]
		private void _RenderNewRelic()
		{
		}

		// Token: 0x0601F5AC RID: 128428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5AC")]
		[Address(RVA = "0x19143E0", Offset = "0x1912FE0", VA = "0x1819143E0")]
		public RoguelikeMenuRelicObject()
		{
		}

		// Token: 0x0601F5AF RID: 128431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5AF")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0601F5B0 RID: 128432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B0")]
		[Address(RVA = "0x190F360", Offset = "0x190DF60", VA = "0x18190F360")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0601F5B1 RID: 128433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5B1")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0402A215 RID: 172565
		[Token(Token = "0x402A215")]
		private const float ANIM_NEW_RELIC_DURATION = 0.5f;

		// Token: 0x0402A216 RID: 172566
		[Token(Token = "0x402A216")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402A217 RID: 172567
		[Token(Token = "0x402A217")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402A218 RID: 172568
		[Token(Token = "0x402A218")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlBack;

		// Token: 0x0402A219 RID: 172569
		[Token(Token = "0x402A219")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textNum;

		// Token: 0x0402A21A RID: 172570
		[Token(Token = "0x402A21A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animNewRelic;

		// Token: 0x0402A21B RID: 172571
		[Token(Token = "0x402A21B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0402A21C RID: 172572
		[Token(Token = "0x402A21C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _showTrap;

		// Token: 0x0402A21D RID: 172573
		[Token(Token = "0x402A21D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _invalidRaycastBlocker;

		// Token: 0x0402A21E RID: 172574
		[Token(Token = "0x402A21E")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_showSwitchTween;

		// Token: 0x0402A21F RID: 172575
		[Token(Token = "0x402A21F")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_newRelicTween;

		// Token: 0x0402A220 RID: 172576
		[Token(Token = "0x402A220")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402A221 RID: 172577
		[Token(Token = "0x402A221")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeMenuRelicViewModel m_cachedModel;

		// Token: 0x0402A222 RID: 172578
		[Token(Token = "0x402A222")]
		[FieldOffset(Offset = "0x90")]
		private bool m_cachedStateShow;

		// Token: 0x0402A223 RID: 172579
		[Token(Token = "0x402A223")]
		[FieldOffset(Offset = "0x94")]
		private int m_cachedRelicCount;

		// Token: 0x0402A224 RID: 172580
		[Token(Token = "0x402A224")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A225 RID: 172581
		[Token(Token = "0x402A225")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A226 RID: 172582
		[Token(Token = "0x402A226")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402A227 RID: 172583
		[Token(Token = "0x402A227")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A228 RID: 172584
		[Token(Token = "0x402A228")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A229 RID: 172585
		[Token(Token = "0x402A229")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A22A RID: 172586
		[Token(Token = "0x402A22A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetRelicCount;

		// Token: 0x0402A22B RID: 172587
		[Token(Token = "0x402A22B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderNewRelic;

		// Token: 0x0402A22C RID: 172588
		[Token(Token = "0x402A22C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
