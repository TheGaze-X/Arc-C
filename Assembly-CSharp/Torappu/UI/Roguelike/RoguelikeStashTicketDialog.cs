using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200554A RID: 21834
	[Token(Token = "0x200554A")]
	public class RoguelikeStashTicketDialog : UICompDialog<RoguelikeStashTicketDialog.Option>
	{
		// Token: 0x060201B4 RID: 131508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201B4")]
		[Address(RVA = "0x1A3DC00", Offset = "0x1A3C800", VA = "0x181A3DC00", Slot = "18")]
		protected override void OnRender(RoguelikeStashTicketDialog.Option input)
		{
		}

		// Token: 0x060201B5 RID: 131509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201B5")]
		[Address(RVA = "0x1A3DBA0", Offset = "0x1A3C7A0", VA = "0x181A3DBA0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060201B6 RID: 131510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201B6")]
		[Address(RVA = "0x1A3DAB0", Offset = "0x1A3C6B0", VA = "0x181A3DAB0", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x060201B7 RID: 131511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201B7")]
		[Address(RVA = "0x1A3D860", Offset = "0x1A3C460", VA = "0x181A3D860")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x060201B8 RID: 131512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201B8")]
		[Address(RVA = "0x1A3D920", Offset = "0x1A3C520", VA = "0x181A3D920")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x060201B9 RID: 131513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201B9")]
		[Address(RVA = "0x1A3E100", Offset = "0x1A3CD00", VA = "0x181A3E100")]
		public RoguelikeStashTicketDialog()
		{
		}

		// Token: 0x060201BA RID: 131514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201BA")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060201BB RID: 131515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201BB")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0402B5EA RID: 177642
		[Token(Token = "0x402B5EA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402B5EB RID: 177643
		[Token(Token = "0x402B5EB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402B5EC RID: 177644
		[Token(Token = "0x402B5EC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtStashTips;

		// Token: 0x0402B5ED RID: 177645
		[Token(Token = "0x402B5ED")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgStashTicketIcon;

		// Token: 0x0402B5EE RID: 177646
		[Token(Token = "0x402B5EE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _txtStashTicketTitle;

		// Token: 0x0402B5EF RID: 177647
		[Token(Token = "0x402B5EF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _txtStashTicketUsage;

		// Token: 0x0402B5F0 RID: 177648
		[Token(Token = "0x402B5F0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _txtCurStashedCount;

		// Token: 0x0402B5F1 RID: 177649
		[Token(Token = "0x402B5F1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _txtTotalCanStashCount;

		// Token: 0x0402B5F2 RID: 177650
		[Token(Token = "0x402B5F2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x0402B5F3 RID: 177651
		[Token(Token = "0x402B5F3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0402B5F4 RID: 177652
		[Token(Token = "0x402B5F4")]
		[FieldOffset(Offset = "0xC8")]
		private RoguelikeStashTicketDialog.ViewModel m_viewModel;

		// Token: 0x0402B5F5 RID: 177653
		[Token(Token = "0x402B5F5")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_cachedTween;

		// Token: 0x0402B5F6 RID: 177654
		[Token(Token = "0x402B5F6")]
		private const string STASHED_COUNT_LIMIT_FORMAT = "/{0}";

		// Token: 0x0402B5F7 RID: 177655
		[Token(Token = "0x402B5F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402B5F8 RID: 177656
		[Token(Token = "0x402B5F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402B5F9 RID: 177657
		[Token(Token = "0x402B5F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0402B5FA RID: 177658
		[Token(Token = "0x402B5FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0402B5FB RID: 177659
		[Token(Token = "0x402B5FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0402B5FC RID: 177660
		[Token(Token = "0x402B5FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200554B RID: 21835
		[Token(Token = "0x200554B")]
		public class Option
		{
			// Token: 0x060201BC RID: 131516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201BC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0402B5FD RID: 177661
			[Token(Token = "0x402B5FD")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402B5FE RID: 177662
			[Token(Token = "0x402B5FE")]
			[FieldOffset(Offset = "0x18")]
			public string ticketId;
		}

		// Token: 0x0200554C RID: 21836
		[Token(Token = "0x200554C")]
		private class DialogSwitchTween : UISwitchTween
		{
			// Token: 0x060201BD RID: 131517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201BD")]
			[Address(RVA = "0x1A30BC0", Offset = "0x1A2F7C0", VA = "0x181A30BC0")]
			public DialogSwitchTween(RoguelikeStashTicketDialog closure)
			{
			}

			// Token: 0x060201BE RID: 131518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60201BE")]
			[Address(RVA = "0x1A30820", Offset = "0x1A2F420", VA = "0x181A30820", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060201BF RID: 131519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60201BF")]
			[Address(RVA = "0x1A30920", Offset = "0x1A2F520", VA = "0x181A30920", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060201C0 RID: 131520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201C0")]
			[Address(RVA = "0x1A30AA0", Offset = "0x1A2F6A0", VA = "0x181A30AA0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060201C1 RID: 131521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201C1")]
			[Address(RVA = "0x1A30760", Offset = "0x1A2F360", VA = "0x181A30760", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060201C2 RID: 131522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201C2")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x060201C3 RID: 131523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201C3")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0402B5FF RID: 177663
			[Token(Token = "0x402B5FF")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeStashTicketDialog m_closure;

			// Token: 0x0402B600 RID: 177664
			[Token(Token = "0x402B600")]
			[FieldOffset(Offset = "0x50")]
			private float m_duration;

			// Token: 0x0402B601 RID: 177665
			[Token(Token = "0x402B601")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B602 RID: 177666
			[Token(Token = "0x402B602")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402B603 RID: 177667
			[Token(Token = "0x402B603")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402B604 RID: 177668
			[Token(Token = "0x402B604")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402B605 RID: 177669
			[Token(Token = "0x402B605")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;
		}

		// Token: 0x0200554D RID: 21837
		[Token(Token = "0x200554D")]
		private class ViewModel : IHotfixable
		{
			// Token: 0x17004B55 RID: 19285
			// (get) Token: 0x060201C4 RID: 131524 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060201C5 RID: 131525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B55")]
			public string stashTicketId
			{
				[Token(Token = "0x60201C4")]
				[Address(RVA = "0x1A46AD0", Offset = "0x1A456D0", VA = "0x181A46AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60201C5")]
				[Address(RVA = "0x1A46E30", Offset = "0x1A45A30", VA = "0x181A46E30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B56 RID: 19286
			// (get) Token: 0x060201C6 RID: 131526 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060201C7 RID: 131527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B56")]
			public string stashTicketName
			{
				[Token(Token = "0x60201C6")]
				[Address(RVA = "0x1A46B30", Offset = "0x1A45730", VA = "0x181A46B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60201C7")]
				[Address(RVA = "0x1A46EB0", Offset = "0x1A45AB0", VA = "0x181A46EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B57 RID: 19287
			// (get) Token: 0x060201C8 RID: 131528 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060201C9 RID: 131529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B57")]
			public string stashTicketUsage
			{
				[Token(Token = "0x60201C8")]
				[Address(RVA = "0x1A46B90", Offset = "0x1A45790", VA = "0x181A46B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60201C9")]
				[Address(RVA = "0x1A46F30", Offset = "0x1A45B30", VA = "0x181A46F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B58 RID: 19288
			// (get) Token: 0x060201CA RID: 131530 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060201CB RID: 131531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B58")]
			public string stashRecruitDesc
			{
				[Token(Token = "0x60201CA")]
				[Address(RVA = "0x1A46A10", Offset = "0x1A45610", VA = "0x181A46A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60201CB")]
				[Address(RVA = "0x1A46D30", Offset = "0x1A45930", VA = "0x181A46D30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B59 RID: 19289
			// (get) Token: 0x060201CC RID: 131532 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060201CD RID: 131533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B59")]
			public string stashSucToast
			{
				[Token(Token = "0x60201CC")]
				[Address(RVA = "0x1A46A70", Offset = "0x1A45670", VA = "0x181A46A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60201CD")]
				[Address(RVA = "0x1A46DB0", Offset = "0x1A459B0", VA = "0x181A46DB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B5A RID: 19290
			// (get) Token: 0x060201CE RID: 131534 RVA: 0x000B4A08 File Offset: 0x000B2C08
			// (set) Token: 0x060201CF RID: 131535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B5A")]
			public int stashedCount
			{
				[Token(Token = "0x60201CE")]
				[Address(RVA = "0x1A46BF0", Offset = "0x1A457F0", VA = "0x181A46BF0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60201CF")]
				[Address(RVA = "0x1A46FB0", Offset = "0x1A45BB0", VA = "0x181A46FB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B5B RID: 19291
			// (get) Token: 0x060201D0 RID: 131536 RVA: 0x000B4A20 File Offset: 0x000B2C20
			// (set) Token: 0x060201D1 RID: 131537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B5B")]
			public int maxStashCount
			{
				[Token(Token = "0x60201D0")]
				[Address(RVA = "0x1A469B0", Offset = "0x1A455B0", VA = "0x181A469B0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60201D1")]
				[Address(RVA = "0x1A46CC0", Offset = "0x1A458C0", VA = "0x181A46CC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004B5C RID: 19292
			// (get) Token: 0x060201D2 RID: 131538 RVA: 0x000B4A38 File Offset: 0x000B2C38
			// (set) Token: 0x060201D3 RID: 131539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B5C")]
			public bool initSuc
			{
				[Token(Token = "0x60201D2")]
				[Address(RVA = "0x1A46950", Offset = "0x1A45550", VA = "0x181A46950")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60201D3")]
				[Address(RVA = "0x1A46C50", Offset = "0x1A45850", VA = "0x181A46C50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060201D4 RID: 131540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201D4")]
			[Address(RVA = "0x1A46300", Offset = "0x1A44F00", VA = "0x181A46300")]
			public void LoadData(string topicId, string ticketId)
			{
			}

			// Token: 0x060201D5 RID: 131541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60201D5")]
			[Address(RVA = "0x1A468F0", Offset = "0x1A454F0", VA = "0x181A468F0")]
			public ViewModel()
			{
			}

			// Token: 0x0402B60E RID: 177678
			[Token(Token = "0x402B60E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_stashTicketId;

			// Token: 0x0402B60F RID: 177679
			[Token(Token = "0x402B60F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_stashTicketId;

			// Token: 0x0402B610 RID: 177680
			[Token(Token = "0x402B610")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_stashTicketName;

			// Token: 0x0402B611 RID: 177681
			[Token(Token = "0x402B611")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_stashTicketName;

			// Token: 0x0402B612 RID: 177682
			[Token(Token = "0x402B612")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_stashTicketUsage;

			// Token: 0x0402B613 RID: 177683
			[Token(Token = "0x402B613")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_stashTicketUsage;

			// Token: 0x0402B614 RID: 177684
			[Token(Token = "0x402B614")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_stashRecruitDesc;

			// Token: 0x0402B615 RID: 177685
			[Token(Token = "0x402B615")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_stashRecruitDesc;

			// Token: 0x0402B616 RID: 177686
			[Token(Token = "0x402B616")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_stashSucToast;

			// Token: 0x0402B617 RID: 177687
			[Token(Token = "0x402B617")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_stashSucToast;

			// Token: 0x0402B618 RID: 177688
			[Token(Token = "0x402B618")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_stashedCount;

			// Token: 0x0402B619 RID: 177689
			[Token(Token = "0x402B619")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_set_stashedCount;

			// Token: 0x0402B61A RID: 177690
			[Token(Token = "0x402B61A")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_maxStashCount;

			// Token: 0x0402B61B RID: 177691
			[Token(Token = "0x402B61B")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_set_maxStashCount;

			// Token: 0x0402B61C RID: 177692
			[Token(Token = "0x402B61C")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_initSuc;

			// Token: 0x0402B61D RID: 177693
			[Token(Token = "0x402B61D")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_set_initSuc;

			// Token: 0x0402B61E RID: 177694
			[Token(Token = "0x402B61E")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402B61F RID: 177695
			[Token(Token = "0x402B61F")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
