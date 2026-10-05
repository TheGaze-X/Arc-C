using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200531C RID: 21276
	[Token(Token = "0x200531C")]
	public class RoguelikeTopicInnerTaskObject : RoguelikeMenuObject<RoguelikeTopicInnerTaskViewModel>
	{
		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x0601F643 RID: 128579 RVA: 0x000B1C00 File Offset: 0x000AFE00
		[Token(Token = "0x17004997")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F643")]
			[Address(RVA = "0x191EDA0", Offset = "0x191D9A0", VA = "0x18191EDA0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F644 RID: 128580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F644")]
		[Address(RVA = "0x191E6F0", Offset = "0x191D2F0", VA = "0x18191E6F0", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x0601F645 RID: 128581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F645")]
		[Address(RVA = "0x191E910", Offset = "0x191D510", VA = "0x18191E910", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F646 RID: 128582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F646")]
		[Address(RVA = "0x191E9E0", Offset = "0x191D5E0", VA = "0x18191E9E0", Slot = "7")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F647 RID: 128583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F647")]
		[Address(RVA = "0x191EAC0", Offset = "0x191D6C0", VA = "0x18191EAC0", Slot = "16")]
		public override void Render(RoguelikeTopicInnerTaskViewModel viewModel)
		{
		}

		// Token: 0x0601F648 RID: 128584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F648")]
		[Address(RVA = "0x191ED30", Offset = "0x191D930", VA = "0x18191ED30")]
		public RoguelikeTopicInnerTaskObject()
		{
		}

		// Token: 0x0601F649 RID: 128585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F649")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0601F64A RID: 128586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F64A")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0601F64B RID: 128587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F64B")]
		[Address(RVA = "0x190F360", Offset = "0x190DF60", VA = "0x18190F360")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0402A327 RID: 172839
		[Token(Token = "0x402A327")]
		private const float EXPAND_ANIM_DURATION = 0.3f;

		// Token: 0x0402A328 RID: 172840
		[Token(Token = "0x402A328")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animExpand;

		// Token: 0x0402A329 RID: 172841
		[Token(Token = "0x402A329")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _taskContentBkg;

		// Token: 0x0402A32A RID: 172842
		[Token(Token = "0x402A32A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _buttonExpand;

		// Token: 0x0402A32B RID: 172843
		[Token(Token = "0x402A32B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _taskLayoutContent;

		// Token: 0x0402A32C RID: 172844
		[Token(Token = "0x402A32C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Graphic _graphicLight;

		// Token: 0x0402A32D RID: 172845
		[Token(Token = "0x402A32D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("List Deco")]
		private GameObject _panelListDeco;

		// Token: 0x0402A32E RID: 172846
		[Token(Token = "0x402A32E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("List Deco")]
		private GameObject _panelListDecoNormal;

		// Token: 0x0402A32F RID: 172847
		[Token(Token = "0x402A32F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("List Deco")]
		private GameObject _panelListDecoCompleted;

		// Token: 0x0402A330 RID: 172848
		[Token(Token = "0x402A330")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Month")]
		private Color _monthTaskThemeColor;

		// Token: 0x0402A331 RID: 172849
		[Token(Token = "0x402A331")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Month")]
		private Color _monthTaskCurColor;

		// Token: 0x0402A332 RID: 172850
		[Token(Token = "0x402A332")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Month")]
		private GameObject _pnlMonthCompleted;

		// Token: 0x0402A333 RID: 172851
		[Token(Token = "0x402A333")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Month")]
		private GameObject _pnlMonthNormal;

		// Token: 0x0402A334 RID: 172852
		[Token(Token = "0x402A334")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Challenge")]
		private Color _challengeTaskThemeColor;

		// Token: 0x0402A335 RID: 172853
		[Token(Token = "0x402A335")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Challenge")]
		private Color _challengeTaskCurColor;

		// Token: 0x0402A336 RID: 172854
		[Token(Token = "0x402A336")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Challenge")]
		private GameObject _pnlChallengeCompleted;

		// Token: 0x0402A337 RID: 172855
		[Token(Token = "0x402A337")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Challenge")]
		private GameObject _pnlChallengeNormal;

		// Token: 0x0402A338 RID: 172856
		[Token(Token = "0x402A338")]
		[FieldOffset(Offset = "0xD0")]
		private UISwitchTween m_expandSwitchTween;

		// Token: 0x0402A339 RID: 172857
		[Token(Token = "0x402A339")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeTopicInnerTaskObject.TaskAdapter m_taskAdapter;

		// Token: 0x0402A33A RID: 172858
		[Token(Token = "0x402A33A")]
		[FieldOffset(Offset = "0xE0")]
		private RoguelikeTopicInnerTaskViewModel m_viewModel;

		// Token: 0x0402A33B RID: 172859
		[Token(Token = "0x402A33B")]
		[FieldOffset(Offset = "0xE8")]
		private Color m_themeColor;

		// Token: 0x0402A33C RID: 172860
		[Token(Token = "0x402A33C")]
		[FieldOffset(Offset = "0xF8")]
		private Color m_curColor;

		// Token: 0x0402A33D RID: 172861
		[Token(Token = "0x402A33D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A33E RID: 172862
		[Token(Token = "0x402A33E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A33F RID: 172863
		[Token(Token = "0x402A33F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A340 RID: 172864
		[Token(Token = "0x402A340")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A341 RID: 172865
		[Token(Token = "0x402A341")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A342 RID: 172866
		[Token(Token = "0x402A342")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200531D RID: 21277
		[Token(Token = "0x200531D")]
		private class ExpandSwitchTween : UISwitchTween
		{
			// Token: 0x0601F64C RID: 128588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F64C")]
			[Address(RVA = "0x190BD70", Offset = "0x190A970", VA = "0x18190BD70")]
			public ExpandSwitchTween(RoguelikeTopicInnerTaskObject closure)
			{
			}

			// Token: 0x0601F64D RID: 128589 RVA: 0x000B1C18 File Offset: 0x000AFE18
			[Token(Token = "0x601F64D")]
			[Address(RVA = "0x190BC40", Offset = "0x190A840", VA = "0x18190BC40")]
			private float _GetValue()
			{
				return 0f;
			}

			// Token: 0x0601F64E RID: 128590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F64E")]
			[Address(RVA = "0x190BCA0", Offset = "0x190A8A0", VA = "0x18190BCA0")]
			private void _SetValue(float value)
			{
			}

			// Token: 0x0601F64F RID: 128591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F64F")]
			[Address(RVA = "0x190B790", Offset = "0x190A390", VA = "0x18190B790", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F650 RID: 128592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F650")]
			[Address(RVA = "0x190B920", Offset = "0x190A520", VA = "0x18190B920", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F651 RID: 128593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F651")]
			[Address(RVA = "0x190BAC0", Offset = "0x190A6C0", VA = "0x18190BAC0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F652 RID: 128594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F652")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A343 RID: 172867
			[Token(Token = "0x402A343")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeTopicInnerTaskObject m_closure;

			// Token: 0x0402A344 RID: 172868
			[Token(Token = "0x402A344")]
			[FieldOffset(Offset = "0x50")]
			private float m_tweenValue;

			// Token: 0x0402A345 RID: 172869
			[Token(Token = "0x402A345")]
			[FieldOffset(Offset = "0x58")]
			private AnimationWrapper.AnimationHandler m_animationHandler;

			// Token: 0x0402A346 RID: 172870
			[Token(Token = "0x402A346")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A347 RID: 172871
			[Token(Token = "0x402A347")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__GetValue;

			// Token: 0x0402A348 RID: 172872
			[Token(Token = "0x402A348")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__SetValue;

			// Token: 0x0402A349 RID: 172873
			[Token(Token = "0x402A349")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A34A RID: 172874
			[Token(Token = "0x402A34A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A34B RID: 172875
			[Token(Token = "0x402A34B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x0200531E RID: 21278
		[Token(Token = "0x200531E")]
		private class TaskAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601F653 RID: 128595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F653")]
			[Address(RVA = "0x1920140", Offset = "0x191ED40", VA = "0x181920140")]
			public TaskAdapter(RoguelikeTopicInnerTaskObject closure)
			{
			}

			// Token: 0x17004998 RID: 18840
			// (get) Token: 0x0601F654 RID: 128596 RVA: 0x000B1C30 File Offset: 0x000AFE30
			[Token(Token = "0x17004998")]
			public override int count
			{
				[Token(Token = "0x601F654")]
				[Address(RVA = "0x19201C0", Offset = "0x191EDC0", VA = "0x1819201C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F655 RID: 128597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F655")]
			[Address(RVA = "0x191FEF0", Offset = "0x191EAF0", VA = "0x18191FEF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402A34C RID: 172876
			[Token(Token = "0x402A34C")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicInnerTaskObject m_closure;

			// Token: 0x0402A34D RID: 172877
			[Token(Token = "0x402A34D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A34E RID: 172878
			[Token(Token = "0x402A34E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402A34F RID: 172879
			[Token(Token = "0x402A34F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
