using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A2F RID: 27183
	[Token(Token = "0x2006A2F")]
	public class Main11RecordNoteView : DataBinder<Main11ZoneRecordViewProperty>
	{
		// Token: 0x17005BAB RID: 23467
		// (get) Token: 0x06026DA5 RID: 159141 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026DA6 RID: 159142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BAB")]
		public Action onPrevBtnClick
		{
			[Token(Token = "0x6026DA5")]
			[Address(RVA = "0x21F4F30", Offset = "0x21F3B30", VA = "0x1821F4F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026DA6")]
			[Address(RVA = "0x21F5110", Offset = "0x21F3D10", VA = "0x1821F5110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BAC RID: 23468
		// (get) Token: 0x06026DA7 RID: 159143 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026DA8 RID: 159144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BAC")]
		public Action onNextBtnClick
		{
			[Token(Token = "0x6026DA7")]
			[Address(RVA = "0x21F4ED0", Offset = "0x21F3AD0", VA = "0x1821F4ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026DA8")]
			[Address(RVA = "0x21F5090", Offset = "0x21F3C90", VA = "0x1821F5090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BAD RID: 23469
		// (get) Token: 0x06026DA9 RID: 159145 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026DAA RID: 159146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BAD")]
		public Action onClaimAllRewardClick
		{
			[Token(Token = "0x6026DA9")]
			[Address(RVA = "0x21F4E70", Offset = "0x21F3A70", VA = "0x1821F4E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026DAA")]
			[Address(RVA = "0x21F5010", Offset = "0x21F3C10", VA = "0x1821F5010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BAE RID: 23470
		// (get) Token: 0x06026DAB RID: 159147 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026DAC RID: 159148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BAE")]
		public Main11ZoneRecordController controller
		{
			[Token(Token = "0x6026DAB")]
			[Address(RVA = "0x21F4E10", Offset = "0x21F3A10", VA = "0x1821F4E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026DAC")]
			[Address(RVA = "0x21F4F90", Offset = "0x21F3B90", VA = "0x1821F4F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026DAD RID: 159149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DAD")]
		[Address(RVA = "0x21F4200", Offset = "0x21F2E00", VA = "0x1821F4200")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026DAE RID: 159150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DAE")]
		[Address(RVA = "0x21F47E0", Offset = "0x21F33E0", VA = "0x1821F47E0")]
		private void _Render()
		{
		}

		// Token: 0x06026DAF RID: 159151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DAF")]
		[Address(RVA = "0x21F45E0", Offset = "0x21F31E0", VA = "0x1821F45E0")]
		private void _RenderPreNextBtnPart()
		{
		}

		// Token: 0x06026DB0 RID: 159152 RVA: 0x000CC858 File Offset: 0x000CAA58
		[Token(Token = "0x6026DB0")]
		[Address(RVA = "0x21F4BE0", Offset = "0x21F37E0", VA = "0x1821F4BE0")]
		private float _UpdatePageBtnAlpha(ZoneRecordViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x06026DB1 RID: 159153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DB1")]
		[Address(RVA = "0x21F4C80", Offset = "0x21F3880", VA = "0x1821F4C80")]
		private void _UpdatePageBtnGlow(Main11RecordNoteView.Main11RecordNotePageBtnGlowTweenWrapper tween, ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026DB2 RID: 159154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DB2")]
		[Address(RVA = "0x21F4A00", Offset = "0x21F3600", VA = "0x1821F4A00")]
		private void _ResetBeforeCloseNote()
		{
		}

		// Token: 0x06026DB3 RID: 159155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DB3")]
		[Address(RVA = "0x21F4010", Offset = "0x21F2C10", VA = "0x1821F4010", Slot = "7")]
		public override void OnValueChanged(Main11ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026DB4 RID: 159156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DB4")]
		[Address(RVA = "0x21F3F00", Offset = "0x21F2B00", VA = "0x1821F3F00")]
		public void EventOnPrevBtnClick()
		{
		}

		// Token: 0x06026DB5 RID: 159157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DB5")]
		[Address(RVA = "0x21F3DF0", Offset = "0x21F29F0", VA = "0x1821F3DF0")]
		public void EventOnNextBtnClick()
		{
		}

		// Token: 0x06026DB6 RID: 159158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DB6")]
		[Address(RVA = "0x21F4DA0", Offset = "0x21F39A0", VA = "0x1821F4DA0")]
		public Main11RecordNoteView()
		{
		}

		// Token: 0x04036EE9 RID: 225001
		[Token(Token = "0x4036EE9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main11RecordNoteContentView _contentView;

		// Token: 0x04036EEA RID: 225002
		[Token(Token = "0x4036EEA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasContent;

		// Token: 0x04036EEB RID: 225003
		[Token(Token = "0x4036EEB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _dotsLayout;

		// Token: 0x04036EEC RID: 225004
		[Token(Token = "0x4036EEC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objPrevBtn;

		// Token: 0x04036EED RID: 225005
		[Token(Token = "0x4036EED")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objNextBtn;

		// Token: 0x04036EEE RID: 225006
		[Token(Token = "0x4036EEE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasPrevBtn;

		// Token: 0x04036EEF RID: 225007
		[Token(Token = "0x4036EEF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasNextBtn;

		// Token: 0x04036EF0 RID: 225008
		[Token(Token = "0x4036EF0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasBtnPrevGlow;

		// Token: 0x04036EF1 RID: 225009
		[Token(Token = "0x4036EF1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasBtnNextGlow;

		// Token: 0x04036EF2 RID: 225010
		[Token(Token = "0x4036EF2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _rectRewardPartParent;

		// Token: 0x04036EF3 RID: 225011
		[Token(Token = "0x4036EF3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ZoneRecordRewardContentView _rewardContentPrefab;

		// Token: 0x04036EF4 RID: 225012
		[Token(Token = "0x4036EF4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasContentFade1;

		// Token: 0x04036EF5 RID: 225013
		[Token(Token = "0x4036EF5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasContentFade2;

		// Token: 0x04036EF6 RID: 225014
		[Token(Token = "0x4036EF6")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04036EF7 RID: 225015
		[Token(Token = "0x4036EF7")]
		[FieldOffset(Offset = "0x90")]
		private Main11RecordNoteView.Main11RecordNoteDotListAdapter m_dotListAdapter;

		// Token: 0x04036EF8 RID: 225016
		[Token(Token = "0x4036EF8")]
		[FieldOffset(Offset = "0x98")]
		private string m_selectingRecordId;

		// Token: 0x04036EF9 RID: 225017
		[Token(Token = "0x4036EF9")]
		[FieldOffset(Offset = "0xA0")]
		private ZoneRecordGroupViewModel m_cachedViewModel;

		// Token: 0x04036EFA RID: 225018
		[Token(Token = "0x4036EFA")]
		[FieldOffset(Offset = "0xA8")]
		private Main11RecordNoteView.Main11RecordNotePageBtnGlowTweenWrapper m_pagePrevBtnGlowTween;

		// Token: 0x04036EFB RID: 225019
		[Token(Token = "0x4036EFB")]
		[FieldOffset(Offset = "0xB0")]
		private Main11RecordNoteView.Main11RecordNotePageBtnGlowTweenWrapper m_pageNextBtnGlowTween;

		// Token: 0x04036EFC RID: 225020
		[Token(Token = "0x4036EFC")]
		[FieldOffset(Offset = "0xB8")]
		private ZoneRecordRewardContentView m_rewardContentView;

		// Token: 0x04036EFD RID: 225021
		[Token(Token = "0x4036EFD")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_noteContentFadeTween;

		// Token: 0x04036EFE RID: 225022
		[Token(Token = "0x4036EFE")]
		[FieldOffset(Offset = "0xC8")]
		private FadeSwitchTween m_noteContentArrowFadeTween;

		// Token: 0x04036EFF RID: 225023
		[Token(Token = "0x4036EFF")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedIndex;

		// Token: 0x04036F00 RID: 225024
		[Token(Token = "0x4036F00")]
		private const float PAGE_BTN_CANT_CLICK_ALPHA = 0.5f;

		// Token: 0x04036F01 RID: 225025
		[Token(Token = "0x4036F01")]
		private const float PAGE_BTN_CAN_CLICK_ALPHA = 1f;

		// Token: 0x04036F02 RID: 225026
		[Token(Token = "0x4036F02")]
		private const float CONTENT_FADE_DUR = 0.3f;

		// Token: 0x04036F07 RID: 225031
		[Token(Token = "0x4036F07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onPrevBtnClick;

		// Token: 0x04036F08 RID: 225032
		[Token(Token = "0x4036F08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onPrevBtnClick;

		// Token: 0x04036F09 RID: 225033
		[Token(Token = "0x4036F09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onNextBtnClick;

		// Token: 0x04036F0A RID: 225034
		[Token(Token = "0x4036F0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onNextBtnClick;

		// Token: 0x04036F0B RID: 225035
		[Token(Token = "0x4036F0B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onClaimAllRewardClick;

		// Token: 0x04036F0C RID: 225036
		[Token(Token = "0x4036F0C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onClaimAllRewardClick;

		// Token: 0x04036F0D RID: 225037
		[Token(Token = "0x4036F0D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04036F0E RID: 225038
		[Token(Token = "0x4036F0E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04036F0F RID: 225039
		[Token(Token = "0x4036F0F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036F10 RID: 225040
		[Token(Token = "0x4036F10")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04036F11 RID: 225041
		[Token(Token = "0x4036F11")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderPreNextBtnPart;

		// Token: 0x04036F12 RID: 225042
		[Token(Token = "0x4036F12")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdatePageBtnAlpha;

		// Token: 0x04036F13 RID: 225043
		[Token(Token = "0x4036F13")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdatePageBtnGlow;

		// Token: 0x04036F14 RID: 225044
		[Token(Token = "0x4036F14")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetBeforeCloseNote;

		// Token: 0x04036F15 RID: 225045
		[Token(Token = "0x4036F15")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036F16 RID: 225046
		[Token(Token = "0x4036F16")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnPrevBtnClick;

		// Token: 0x04036F17 RID: 225047
		[Token(Token = "0x4036F17")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClick;

		// Token: 0x04036F18 RID: 225048
		[Token(Token = "0x4036F18")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A30 RID: 27184
		[Token(Token = "0x2006A30")]
		private class Main11RecordNoteDotListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06026DB7 RID: 159159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026DB7")]
			[Address(RVA = "0x21F31E0", Offset = "0x21F1DE0", VA = "0x1821F31E0")]
			public Main11RecordNoteDotListAdapter(Main11RecordNoteView closure)
			{
			}

			// Token: 0x17005BAF RID: 23471
			// (get) Token: 0x06026DB8 RID: 159160 RVA: 0x000CC870 File Offset: 0x000CAA70
			[Token(Token = "0x17005BAF")]
			public override int count
			{
				[Token(Token = "0x6026DB8")]
				[Address(RVA = "0x21F3260", Offset = "0x21F1E60", VA = "0x1821F3260", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026DB9 RID: 159161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026DB9")]
			[Address(RVA = "0x21F2FF0", Offset = "0x21F1BF0", VA = "0x1821F2FF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04036F19 RID: 225049
			[Token(Token = "0x4036F19")]
			[FieldOffset(Offset = "0x20")]
			private Main11RecordNoteView m_closure;

			// Token: 0x04036F1A RID: 225050
			[Token(Token = "0x4036F1A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04036F1B RID: 225051
			[Token(Token = "0x4036F1B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036F1C RID: 225052
			[Token(Token = "0x4036F1C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006A31 RID: 27185
		[Token(Token = "0x2006A31")]
		private class Main11RecordNotePageBtnGlowTweenWrapper : IHotfixable
		{
			// Token: 0x06026DBA RID: 159162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026DBA")]
			[Address(RVA = "0x21F3380", Offset = "0x21F1F80", VA = "0x1821F3380")]
			public void SetCanvasGroup(CanvasGroup canvas)
			{
			}

			// Token: 0x06026DBB RID: 159163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026DBB")]
			[Address(RVA = "0x21F3400", Offset = "0x21F2000", VA = "0x1821F3400")]
			public void SetTween()
			{
			}

			// Token: 0x06026DBC RID: 159164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026DBC")]
			[Address(RVA = "0x21F3300", Offset = "0x21F1F00", VA = "0x1821F3300")]
			public void KillTween()
			{
			}

			// Token: 0x06026DBD RID: 159165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026DBD")]
			[Address(RVA = "0x21F36A0", Offset = "0x21F22A0", VA = "0x1821F36A0")]
			public Main11RecordNotePageBtnGlowTweenWrapper()
			{
			}

			// Token: 0x04036F1D RID: 225053
			[Token(Token = "0x4036F1D")]
			[FieldOffset(Offset = "0x10")]
			private CanvasGroup m_glowCanvasGroup;

			// Token: 0x04036F1E RID: 225054
			[Token(Token = "0x4036F1E")]
			[FieldOffset(Offset = "0x18")]
			private Sequence m_tween;

			// Token: 0x04036F1F RID: 225055
			[Token(Token = "0x4036F1F")]
			private const float SELECT_GLOW_TWEEN_DUR = 1f;

			// Token: 0x04036F20 RID: 225056
			[Token(Token = "0x4036F20")]
			private const float SELECT_GLOW_END_ALPHA = 0.6f;

			// Token: 0x04036F21 RID: 225057
			[Token(Token = "0x4036F21")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetCanvasGroup;

			// Token: 0x04036F22 RID: 225058
			[Token(Token = "0x4036F22")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetTween;

			// Token: 0x04036F23 RID: 225059
			[Token(Token = "0x4036F23")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillTween;

			// Token: 0x04036F24 RID: 225060
			[Token(Token = "0x4036F24")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
