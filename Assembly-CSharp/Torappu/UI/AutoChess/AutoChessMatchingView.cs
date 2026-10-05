using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062C5 RID: 25285
	[Token(Token = "0x20062C5")]
	public class AutoChessMatchingView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060246E6 RID: 149222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246E6")]
		[Address(RVA = "0x1F3EA40", Offset = "0x1F3D640", VA = "0x181F3EA40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060246E7 RID: 149223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246E7")]
		[Address(RVA = "0x1F3EE50", Offset = "0x1F3DA50", VA = "0x181F3EE50")]
		private void _SetMatchingActive(bool active)
		{
		}

		// Token: 0x060246E8 RID: 149224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246E8")]
		[Address(RVA = "0x1F3EDA0", Offset = "0x1F3D9A0", VA = "0x181F3EDA0")]
		private void _OnSucAnimChanged(bool isShow)
		{
		}

		// Token: 0x060246E9 RID: 149225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246E9")]
		[Address(RVA = "0x1F3ECF0", Offset = "0x1F3D8F0", VA = "0x181F3ECF0")]
		private void _OnFailAnimChanged(bool isShow)
		{
		}

		// Token: 0x060246EA RID: 149226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246EA")]
		[Address(RVA = "0x1F3E400", Offset = "0x1F3D000", VA = "0x181F3E400")]
		public void Render(AutoChessMultiMatchViewModel matchViewModel)
		{
		}

		// Token: 0x060246EB RID: 149227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246EB")]
		[Address(RVA = "0x1F3E310", Offset = "0x1F3CF10", VA = "0x181F3E310")]
		public void PlayEnterAnimation()
		{
		}

		// Token: 0x060246EC RID: 149228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246EC")]
		[Address(RVA = "0x1F3E280", Offset = "0x1F3CE80", VA = "0x181F3E280")]
		public void EventOnClickCancel()
		{
		}

		// Token: 0x060246ED RID: 149229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246ED")]
		[Address(RVA = "0x1F3EF10", Offset = "0x1F3DB10", VA = "0x181F3EF10")]
		public AutoChessMatchingView()
		{
		}

		// Token: 0x04032B65 RID: 207717
		[Token(Token = "0x4032B65")]
		private const float FADE_DURATION = 0.17f;

		// Token: 0x04032B66 RID: 207718
		[Token(Token = "0x4032B66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<AutoChessMatchingView.ModeConfig> _modeConfigs;

		// Token: 0x04032B67 RID: 207719
		[Token(Token = "0x4032B67")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _matchingCanvasGroup;

		// Token: 0x04032B68 RID: 207720
		[Token(Token = "0x4032B68")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04032B69 RID: 207721
		[Token(Token = "0x4032B69")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _sucAnim;

		// Token: 0x04032B6A RID: 207722
		[Token(Token = "0x4032B6A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _failAnim;

		// Token: 0x04032B6B RID: 207723
		[Token(Token = "0x4032B6B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _matchingTimeText;

		// Token: 0x04032B6C RID: 207724
		[Token(Token = "0x4032B6C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _preciseToggle;

		// Token: 0x04032B6D RID: 207725
		[Token(Token = "0x4032B6D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _cancelBtnObj;

		// Token: 0x04032B6E RID: 207726
		[Token(Token = "0x4032B6E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _gameTipText;

		// Token: 0x04032B6F RID: 207727
		[Token(Token = "0x4032B6F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04032B70 RID: 207728
		[Token(Token = "0x4032B70")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_enterTween;

		// Token: 0x04032B71 RID: 207729
		[Token(Token = "0x4032B71")]
		[FieldOffset(Offset = "0x88")]
		private UICompDialogFinder m_dlgFinder;

		// Token: 0x04032B72 RID: 207730
		[Token(Token = "0x4032B72")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedStatusSeqNum;

		// Token: 0x04032B73 RID: 207731
		[Token(Token = "0x4032B73")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_sucAnimSwitch;

		// Token: 0x04032B74 RID: 207732
		[Token(Token = "0x4032B74")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_failAnimSwitch;

		// Token: 0x04032B75 RID: 207733
		[Token(Token = "0x4032B75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032B76 RID: 207734
		[Token(Token = "0x4032B76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetMatchingActive;

		// Token: 0x04032B77 RID: 207735
		[Token(Token = "0x4032B77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSucAnimChanged;

		// Token: 0x04032B78 RID: 207736
		[Token(Token = "0x4032B78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnFailAnimChanged;

		// Token: 0x04032B79 RID: 207737
		[Token(Token = "0x4032B79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032B7A RID: 207738
		[Token(Token = "0x4032B7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayEnterAnimation;

		// Token: 0x04032B7B RID: 207739
		[Token(Token = "0x4032B7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickCancel;

		// Token: 0x04032B7C RID: 207740
		[Token(Token = "0x4032B7C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062C6 RID: 25286
		[Token(Token = "0x20062C6")]
		[Serializable]
		private class ModeConfig
		{
			// Token: 0x060246EE RID: 149230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246EE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ModeConfig()
			{
			}

			// Token: 0x04032B7D RID: 207741
			[Token(Token = "0x4032B7D")]
			[FieldOffset(Offset = "0x10")]
			public ActAutoChessModeDifficultyType difficultyType;

			// Token: 0x04032B7E RID: 207742
			[Token(Token = "0x4032B7E")]
			[FieldOffset(Offset = "0x18")]
			public GameObject container;

			// Token: 0x04032B7F RID: 207743
			[Token(Token = "0x4032B7F")]
			[FieldOffset(Offset = "0x20")]
			public Text modeNameText;
		}
	}
}
