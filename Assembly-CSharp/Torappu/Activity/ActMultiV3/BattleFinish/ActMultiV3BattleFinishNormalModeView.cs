using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200708E RID: 28814
	[Token(Token = "0x200708E")]
	public class ActMultiV3BattleFinishNormalModeView : ActMultiV3BattleFinishModeViewBase
	{
		// Token: 0x170060DC RID: 24796
		// (get) Token: 0x06028EEF RID: 167663 RVA: 0x000D3A10 File Offset: 0x000D1C10
		[Token(Token = "0x170060DC")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028EEF")]
			[Address(RVA = "0x244D680", Offset = "0x244C280", VA = "0x18244D680", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028EF0 RID: 167664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028EF0")]
		[Address(RVA = "0x244CA00", Offset = "0x244B600", VA = "0x18244CA00", Slot = "5")]
		public override Tween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06028EF1 RID: 167665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EF1")]
		[Address(RVA = "0x244CE70", Offset = "0x244BA70", VA = "0x18244CE70", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028EF2 RID: 167666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EF2")]
		[Address(RVA = "0x244D3F0", Offset = "0x244BFF0", VA = "0x18244D3F0")]
		private void _RenderProgress(Text textProgressVal, Text textProgressMax, int targetIdx)
		{
		}

		// Token: 0x06028EF3 RID: 167667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EF3")]
		[Address(RVA = "0x244D2B0", Offset = "0x244BEB0", VA = "0x18244D2B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028EF4 RID: 167668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EF4")]
		[Address(RVA = "0x244D5D0", Offset = "0x244C1D0", VA = "0x18244D5D0")]
		public ActMultiV3BattleFinishNormalModeView()
		{
		}

		// Token: 0x0403A681 RID: 239233
		[Token(Token = "0x403A681")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _penaltyHintGO;

		// Token: 0x0403A682 RID: 239234
		[Token(Token = "0x403A682")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0403A683 RID: 239235
		[Token(Token = "0x403A683")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403A684 RID: 239236
		[Token(Token = "0x403A684")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgType;

		// Token: 0x0403A685 RID: 239237
		[Token(Token = "0x403A685")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider _sliderStage1;

		// Token: 0x0403A686 RID: 239238
		[Token(Token = "0x403A686")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _sliderStage2;

		// Token: 0x0403A687 RID: 239239
		[Token(Token = "0x403A687")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textProgressVal1;

		// Token: 0x0403A688 RID: 239240
		[Token(Token = "0x403A688")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textProgressVal2;

		// Token: 0x0403A689 RID: 239241
		[Token(Token = "0x403A689")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textProgressVal3;

		// Token: 0x0403A68A RID: 239242
		[Token(Token = "0x403A68A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textProgressMax1;

		// Token: 0x0403A68B RID: 239243
		[Token(Token = "0x403A68B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textProgressMax2;

		// Token: 0x0403A68C RID: 239244
		[Token(Token = "0x403A68C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textProgressMax3;

		// Token: 0x0403A68D RID: 239245
		[Token(Token = "0x403A68D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _sliderTweenDuration;

		// Token: 0x0403A68E RID: 239246
		[Token(Token = "0x403A68E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _animComplete1;

		// Token: 0x0403A68F RID: 239247
		[Token(Token = "0x403A68F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _animComplete2;

		// Token: 0x0403A690 RID: 239248
		[Token(Token = "0x403A690")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _animComplete3;

		// Token: 0x0403A691 RID: 239249
		[Token(Token = "0x403A691")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0403A692 RID: 239250
		[Token(Token = "0x403A692")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _newStarGO;

		// Token: 0x0403A693 RID: 239251
		[Token(Token = "0x403A693")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_hasInited;

		// Token: 0x0403A694 RID: 239252
		[Token(Token = "0x403A694")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_animTween;

		// Token: 0x0403A695 RID: 239253
		[Token(Token = "0x403A695")]
		[FieldOffset(Offset = "0xF0")]
		private BattleFinishNormalMapModel m_normalModel;

		// Token: 0x0403A696 RID: 239254
		[Token(Token = "0x403A696")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A697 RID: 239255
		[Token(Token = "0x403A697")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0403A698 RID: 239256
		[Token(Token = "0x403A698")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A699 RID: 239257
		[Token(Token = "0x403A699")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderProgress;

		// Token: 0x0403A69A RID: 239258
		[Token(Token = "0x403A69A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A69B RID: 239259
		[Token(Token = "0x403A69B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
