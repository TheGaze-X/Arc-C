using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003398 RID: 13208
	[Token(Token = "0x2003398")]
	public class UIGiantEnemySpWarning : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x06015109 RID: 86281 RVA: 0x0008A3C0 File Offset: 0x000885C0
		[Token(Token = "0x17003208")]
		public bool isDefault
		{
			[Token(Token = "0x6015109")]
			[Address(RVA = "0xD73D30", Offset = "0xD72930", VA = "0x180D73D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0601510A RID: 86282 RVA: 0x0008A3D8 File Offset: 0x000885D8
		[Token(Token = "0x17003209")]
		public bool isVgctrl
		{
			[Token(Token = "0x601510A")]
			[Address(RVA = "0xD73DA0", Offset = "0xD729A0", VA = "0x180D73DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601510B RID: 86283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601510B")]
		[Address(RVA = "0xD721E0", Offset = "0xD70DE0", VA = "0x180D721E0")]
		public void SetSpSliderWarningTween(int stageIndex = 0, bool force = false)
		{
		}

		// Token: 0x0601510C RID: 86284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601510C")]
		[Address(RVA = "0xD720C0", Offset = "0xD70CC0", VA = "0x180D720C0")]
		public void SetSpSliderStageWarningTweenByProgress(float spProgress)
		{
		}

		// Token: 0x0601510D RID: 86285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601510D")]
		[Address(RVA = "0xD71E40", Offset = "0xD70A40", VA = "0x180D71E40")]
		private void Awake()
		{
		}

		// Token: 0x0601510E RID: 86286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601510E")]
		[Address(RVA = "0xD71F10", Offset = "0xD70B10", VA = "0x180D71F10")]
		public void DoAttach(UITextSlider slider)
		{
		}

		// Token: 0x0601510F RID: 86287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601510F")]
		[Address(RVA = "0xD72030", Offset = "0xD70C30", VA = "0x180D72030")]
		public void OnDestroy()
		{
		}

		// Token: 0x06015110 RID: 86288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015110")]
		[Address(RVA = "0xD73CB0", Offset = "0xD728B0", VA = "0x180D73CB0")]
		public UIGiantEnemySpWarning()
		{
		}

		// Token: 0x0401913B RID: 102715
		[Token(Token = "0x401913B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BattleUIConst.GiantBossInfoType _giantBossInfoType;

		// Token: 0x0401913C RID: 102716
		[Token(Token = "0x401913C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("SpWarning Params")]
		private Image _spWarningGlow;

		// Token: 0x0401913D RID: 102717
		[Token(Token = "0x401913D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("SpWarning Params")]
		[Inspect("isDefault")]
		private Image _spWarningIconYellow;

		// Token: 0x0401913E RID: 102718
		[Token(Token = "0x401913E")]
		[FieldOffset(Offset = "0x30")]
		[Inspect("isDefault")]
		[SerializeField]
		[Group("SpWarning Params")]
		private Image _spWarningIconYellow2;

		// Token: 0x0401913F RID: 102719
		[Token(Token = "0x401913F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("SpWarning Params")]
		[Inspect("isDefault")]
		private Image _spWarningIconRed;

		// Token: 0x04019140 RID: 102720
		[Token(Token = "0x4019140")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("SpWarning Params")]
		[Inspect("isDefault")]
		private Image _spWarningIconRed2;

		// Token: 0x04019141 RID: 102721
		[Token(Token = "0x4019141")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("SpWarning Params")]
		[Inspect("isDefault")]
		private Image _spWarningLine;

		// Token: 0x04019142 RID: 102722
		[Token(Token = "0x4019142")]
		[FieldOffset(Offset = "0x50")]
		[Inspect("isDefault")]
		[SerializeField]
		[Group("SpWarning Params")]
		private Image _spWarningLine2;

		// Token: 0x04019143 RID: 102723
		[Token(Token = "0x4019143")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("SpWarning Params")]
		[Inspect("isVgctrl")]
		private Image _spWarningClaw;

		// Token: 0x04019144 RID: 102724
		[Token(Token = "0x4019144")]
		[FieldOffset(Offset = "0x60")]
		private UITextSlider m_spSlider;

		// Token: 0x04019145 RID: 102725
		[Token(Token = "0x4019145")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float s_spWarningRatio;

		// Token: 0x04019146 RID: 102726
		[Token(Token = "0x4019146")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_spWarningLineTween;

		// Token: 0x04019147 RID: 102727
		[Token(Token = "0x4019147")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_spWarningTween;

		// Token: 0x04019148 RID: 102728
		[Token(Token = "0x4019148")]
		[FieldOffset(Offset = "0x78")]
		private int m_spWarningStage;

		// Token: 0x04019149 RID: 102729
		[Token(Token = "0x4019149")]
		[FieldOffset(Offset = "0x7C")]
		private Color m_spWarningIconColor;

		// Token: 0x0401914A RID: 102730
		[Token(Token = "0x401914A")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Color s_spWarningStage1Color;

		// Token: 0x0401914B RID: 102731
		[Token(Token = "0x401914B")]
		[FieldOffset(Offset = "0x14")]
		private static readonly Color s_spWarningStage2Color;

		// Token: 0x0401914C RID: 102732
		[Token(Token = "0x401914C")]
		[FieldOffset(Offset = "0x24")]
		private static readonly float s_spWarningLineTargetWidth;

		// Token: 0x0401914D RID: 102733
		[Token(Token = "0x401914D")]
		[FieldOffset(Offset = "0x28")]
		private static readonly float s_spWarningLineTweenDuration;

		// Token: 0x0401914E RID: 102734
		[Token(Token = "0x401914E")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly float s_spWarningLoopTweenDuration;

		// Token: 0x0401914F RID: 102735
		[Token(Token = "0x401914F")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_spSliderColorTween;

		// Token: 0x04019150 RID: 102736
		[Token(Token = "0x4019150")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Color s_spSliderStage0Color;

		// Token: 0x04019151 RID: 102737
		[Token(Token = "0x4019151")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Color s_spSliderStage1Color;

		// Token: 0x04019152 RID: 102738
		[Token(Token = "0x4019152")]
		[FieldOffset(Offset = "0x50")]
		private static readonly Color s_spSliderStage2Color;

		// Token: 0x04019153 RID: 102739
		[Token(Token = "0x4019153")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isDefault;

		// Token: 0x04019154 RID: 102740
		[Token(Token = "0x4019154")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isVgctrl;

		// Token: 0x04019155 RID: 102741
		[Token(Token = "0x4019155")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetSpSliderWarningTween;

		// Token: 0x04019156 RID: 102742
		[Token(Token = "0x4019156")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetSpSliderStageWarningTweenByProgress;

		// Token: 0x04019157 RID: 102743
		[Token(Token = "0x4019157")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04019158 RID: 102744
		[Token(Token = "0x4019158")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04019159 RID: 102745
		[Token(Token = "0x4019159")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401915A RID: 102746
		[Token(Token = "0x401915A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
