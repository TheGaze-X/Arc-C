using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055F1 RID: 22001
	[Token(Token = "0x20055F1")]
	public class RL05MenuSpZoneStepObject : RoguelikeMenuObject<RL05MenuSpZoneStepViewModel>, IHotfixable
	{
		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x060204B6 RID: 132278 RVA: 0x000B53C8 File Offset: 0x000B35C8
		[Token(Token = "0x17004BA7")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x60204B6")]
			[Address(RVA = "0x1A65C80", Offset = "0x1A64880", VA = "0x181A65C80", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x060204B7 RID: 132279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B7")]
		[Address(RVA = "0x1A64880", Offset = "0x1A63480", VA = "0x181A64880", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x060204B8 RID: 132280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B8")]
		[Address(RVA = "0x1A64E40", Offset = "0x1A63A40", VA = "0x181A64E40", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x060204B9 RID: 132281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B9")]
		[Address(RVA = "0x1A64F00", Offset = "0x1A63B00", VA = "0x181A64F00", Slot = "7")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x060204BA RID: 132282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204BA")]
		[Address(RVA = "0x1A64FE0", Offset = "0x1A63BE0", VA = "0x181A64FE0", Slot = "16")]
		public override void Render(RL05MenuSpZoneStepViewModel viewModel)
		{
		}

		// Token: 0x060204BB RID: 132283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204BB")]
		[Address(RVA = "0x1A659F0", Offset = "0x1A645F0", VA = "0x181A659F0")]
		private void _Render(bool fastMode, bool isFromAdapterChange)
		{
		}

		// Token: 0x060204BC RID: 132284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204BC")]
		[Address(RVA = "0x1A65B10", Offset = "0x1A64710", VA = "0x181A65B10")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x060204BD RID: 132285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204BD")]
		[Address(RVA = "0x1A65730", Offset = "0x1A64330", VA = "0x181A65730")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x060204BE RID: 132286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204BE")]
		[Address(RVA = "0x1A657D0", Offset = "0x1A643D0", VA = "0x181A657D0")]
		private void _RenderView(RL05MenuSpZoneStepObject.StepParam stepParam, bool fastMode)
		{
		}

		// Token: 0x060204BF RID: 132287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204BF")]
		[Address(RVA = "0x1A65430", Offset = "0x1A64030", VA = "0x181A65430")]
		private void _PlayStepChangeAnim(bool fastMode, int preStep)
		{
		}

		// Token: 0x060204C0 RID: 132288 RVA: 0x000B53E0 File Offset: 0x000B35E0
		[Token(Token = "0x60204C0")]
		[Address(RVA = "0x1A652B0", Offset = "0x1A63EB0", VA = "0x181A652B0")]
		private UIAnimationLocation _GetCandleAnimLocation(int step)
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x060204C1 RID: 132289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204C1")]
		[Address(RVA = "0x1A65120", Offset = "0x1A63D20", VA = "0x181A65120")]
		private void _EventOnDungeonShowAnim(object arg)
		{
		}

		// Token: 0x060204C2 RID: 132290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204C2")]
		[Address(RVA = "0x1A64CE0", Offset = "0x1A638E0", VA = "0x181A64CE0")]
		public void OnBackToNormZoneClick()
		{
		}

		// Token: 0x060204C3 RID: 132291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204C3")]
		[Address(RVA = "0x1A65BB0", Offset = "0x1A647B0", VA = "0x181A65BB0")]
		public RL05MenuSpZoneStepObject()
		{
		}

		// Token: 0x060204C7 RID: 132295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204C7")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x060204C8 RID: 132296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204C8")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x060204C9 RID: 132297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204C9")]
		[Address(RVA = "0x190F360", Offset = "0x190DF60", VA = "0x18190F360")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0402BB4F RID: 179023
		[Token(Token = "0x402BB4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0402BB50 RID: 179024
		[Token(Token = "0x402BB50")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroupWindow;

		// Token: 0x0402BB51 RID: 179025
		[Token(Token = "0x402BB51")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x0402BB52 RID: 179026
		[Token(Token = "0x402BB52")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtStep;

		// Token: 0x0402BB53 RID: 179027
		[Token(Token = "0x402BB53")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtStepAnim;

		// Token: 0x0402BB54 RID: 179028
		[Token(Token = "0x402BB54")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animationLocationStepChange;

		// Token: 0x0402BB55 RID: 179029
		[Token(Token = "0x402BB55")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animationLocationStepZoneIn;

		// Token: 0x0402BB56 RID: 179030
		[Token(Token = "0x402BB56")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<RL05MenuSpZoneStepObject.CandleAnim> _candleAnims;

		// Token: 0x0402BB57 RID: 179031
		[Token(Token = "0x402BB57")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_windowFadeSwitchTween;

		// Token: 0x0402BB58 RID: 179032
		[Token(Token = "0x402BB58")]
		[FieldOffset(Offset = "0x80")]
		private int m_currentStep;

		// Token: 0x0402BB59 RID: 179033
		[Token(Token = "0x402BB59")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_stepChangeTween;

		// Token: 0x0402BB5A RID: 179034
		[Token(Token = "0x402BB5A")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402BB5B RID: 179035
		[Token(Token = "0x402BB5B")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeMenuViewRenderer<RL05MenuSpZoneStepObject.StepParam> m_stepRenderer;

		// Token: 0x0402BB5C RID: 179036
		[Token(Token = "0x402BB5C")]
		[FieldOffset(Offset = "0xA0")]
		private RL05MenuSpZoneStepViewModel m_cachedModel;

		// Token: 0x0402BB5D RID: 179037
		[Token(Token = "0x402BB5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402BB5E RID: 179038
		[Token(Token = "0x402BB5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402BB5F RID: 179039
		[Token(Token = "0x402BB5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402BB60 RID: 179040
		[Token(Token = "0x402BB60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402BB61 RID: 179041
		[Token(Token = "0x402BB61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BB62 RID: 179042
		[Token(Token = "0x402BB62")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402BB63 RID: 179043
		[Token(Token = "0x402BB63")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402BB64 RID: 179044
		[Token(Token = "0x402BB64")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402BB65 RID: 179045
		[Token(Token = "0x402BB65")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0402BB66 RID: 179046
		[Token(Token = "0x402BB66")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayStepChangeAnim;

		// Token: 0x0402BB67 RID: 179047
		[Token(Token = "0x402BB67")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetCandleAnimLocation;

		// Token: 0x0402BB68 RID: 179048
		[Token(Token = "0x402BB68")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnDungeonShowAnim;

		// Token: 0x0402BB69 RID: 179049
		[Token(Token = "0x402BB69")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBackToNormZoneClick;

		// Token: 0x0402BB6A RID: 179050
		[Token(Token = "0x402BB6A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055F2 RID: 22002
		[Token(Token = "0x20055F2")]
		[Serializable]
		private struct CandleAnim
		{
			// Token: 0x0402BB6B RID: 179051
			[Token(Token = "0x402BB6B")]
			[FieldOffset(Offset = "0x0")]
			public int stepCount;

			// Token: 0x0402BB6C RID: 179052
			[Token(Token = "0x402BB6C")]
			[FieldOffset(Offset = "0x8")]
			public UIAnimationLocation animationLocation;
		}

		// Token: 0x020055F3 RID: 22003
		[Token(Token = "0x20055F3")]
		private struct StepParam
		{
			// Token: 0x0402BB6D RID: 179053
			[Token(Token = "0x402BB6D")]
			[FieldOffset(Offset = "0x0")]
			public int stepCount;

			// Token: 0x0402BB6E RID: 179054
			[Token(Token = "0x402BB6E")]
			[FieldOffset(Offset = "0x8")]
			public string desc;
		}
	}
}
