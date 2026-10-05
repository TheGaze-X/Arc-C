using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007088 RID: 28808
	[Token(Token = "0x2007088")]
	public class ActMultiV3BattleFinishDefenceModeView : ActMultiV3BattleFinishModeViewBase
	{
		// Token: 0x170060D7 RID: 24791
		// (get) Token: 0x06028ED4 RID: 167636 RVA: 0x000D39B0 File Offset: 0x000D1BB0
		[Token(Token = "0x170060D7")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028ED4")]
			[Address(RVA = "0x244BB50", Offset = "0x244A750", VA = "0x18244BB50", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028ED5 RID: 167637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028ED5")]
		[Address(RVA = "0x244A9E0", Offset = "0x24495E0", VA = "0x18244A9E0", Slot = "5")]
		public override Tween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06028ED6 RID: 167638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ED6")]
		[Address(RVA = "0x244B210", Offset = "0x2449E10", VA = "0x18244B210", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028ED7 RID: 167639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ED7")]
		[Address(RVA = "0x244B8B0", Offset = "0x244A4B0", VA = "0x18244B8B0")]
		private void _RenderProgress(Text textProgressVal, Text textProgressMax, int targetIdx)
		{
		}

		// Token: 0x06028ED8 RID: 167640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ED8")]
		[Address(RVA = "0x244B760", Offset = "0x244A360", VA = "0x18244B760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028ED9 RID: 167641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ED9")]
		[Address(RVA = "0x244BA90", Offset = "0x244A690", VA = "0x18244BA90")]
		public ActMultiV3BattleFinishDefenceModeView()
		{
		}

		// Token: 0x0403A643 RID: 239171
		[Token(Token = "0x403A643")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newStarGO;

		// Token: 0x0403A644 RID: 239172
		[Token(Token = "0x403A644")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _newDamageGO;

		// Token: 0x0403A645 RID: 239173
		[Token(Token = "0x403A645")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403A646 RID: 239174
		[Token(Token = "0x403A646")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgType;

		// Token: 0x0403A647 RID: 239175
		[Token(Token = "0x403A647")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCurrWave;

		// Token: 0x0403A648 RID: 239176
		[Token(Token = "0x403A648")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textMaxWave;

		// Token: 0x0403A649 RID: 239177
		[Token(Token = "0x403A649")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textBossDamage;

		// Token: 0x0403A64A RID: 239178
		[Token(Token = "0x403A64A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _sliderBossHealth;

		// Token: 0x0403A64B RID: 239179
		[Token(Token = "0x403A64B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textProgressVal1;

		// Token: 0x0403A64C RID: 239180
		[Token(Token = "0x403A64C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textProgressVal2;

		// Token: 0x0403A64D RID: 239181
		[Token(Token = "0x403A64D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textProgressVal3;

		// Token: 0x0403A64E RID: 239182
		[Token(Token = "0x403A64E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textProgressMax1;

		// Token: 0x0403A64F RID: 239183
		[Token(Token = "0x403A64F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textProgressMax2;

		// Token: 0x0403A650 RID: 239184
		[Token(Token = "0x403A650")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textProgressMax3;

		// Token: 0x0403A651 RID: 239185
		[Token(Token = "0x403A651")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0403A652 RID: 239186
		[Token(Token = "0x403A652")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _sliderTweenDuration;

		// Token: 0x0403A653 RID: 239187
		[Token(Token = "0x403A653")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _finalTweenDuration;

		// Token: 0x0403A654 RID: 239188
		[Token(Token = "0x403A654")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _finalTweenDelay;

		// Token: 0x0403A655 RID: 239189
		[Token(Token = "0x403A655")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation[] _animCompleteList;

		// Token: 0x0403A656 RID: 239190
		[Token(Token = "0x403A656")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0403A657 RID: 239191
		[Token(Token = "0x403A657")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _animFinalWaveEnter;

		// Token: 0x0403A658 RID: 239192
		[Token(Token = "0x403A658")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIAnimationLocation _animBossKill;

		// Token: 0x0403A659 RID: 239193
		[Token(Token = "0x403A659")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIAnimationLocation _animNewRecord;

		// Token: 0x0403A65A RID: 239194
		[Token(Token = "0x403A65A")]
		[FieldOffset(Offset = "0x100")]
		private bool m_hasInited;

		// Token: 0x0403A65B RID: 239195
		[Token(Token = "0x403A65B")]
		[FieldOffset(Offset = "0x108")]
		private BattleFinishDefenceMapModel m_defenceModel;

		// Token: 0x0403A65C RID: 239196
		[Token(Token = "0x403A65C")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_animTween;

		// Token: 0x0403A65D RID: 239197
		[Token(Token = "0x403A65D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A65E RID: 239198
		[Token(Token = "0x403A65E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0403A65F RID: 239199
		[Token(Token = "0x403A65F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A660 RID: 239200
		[Token(Token = "0x403A660")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderProgress;

		// Token: 0x0403A661 RID: 239201
		[Token(Token = "0x403A661")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A662 RID: 239202
		[Token(Token = "0x403A662")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
