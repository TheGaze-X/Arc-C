using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062CD RID: 25293
	[Token(Token = "0x20062CD")]
	public class AutoChessModeChoiceView : DataBinder<AutoChessModeChoiceViewProperty>
	{
		// Token: 0x06024723 RID: 149283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024723")]
		[Address(RVA = "0x1F478E0", Offset = "0x1F464E0", VA = "0x181F478E0", Slot = "7")]
		public override void OnValueChanged(AutoChessModeChoiceViewProperty property)
		{
		}

		// Token: 0x06024724 RID: 149284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024724")]
		[Address(RVA = "0x1F47B00", Offset = "0x1F46700", VA = "0x181F47B00")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x06024725 RID: 149285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024725")]
		[Address(RVA = "0x1F47C50", Offset = "0x1F46850", VA = "0x181F47C50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024726 RID: 149286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024726")]
		[Address(RVA = "0x1F47D30", Offset = "0x1F46930", VA = "0x181F47D30")]
		private void _ShowBgAnim(AutoChessModeChoiceView.AnimationBGType bgType)
		{
		}

		// Token: 0x06024727 RID: 149287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024727")]
		[Address(RVA = "0x1F47FF0", Offset = "0x1F46BF0", VA = "0x181F47FF0")]
		public AutoChessModeChoiceView()
		{
		}

		// Token: 0x04032BF2 RID: 207858
		[Token(Token = "0x4032BF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objFunnyModeBg;

		// Token: 0x04032BF3 RID: 207859
		[Token(Token = "0x4032BF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objNormalModeBg;

		// Token: 0x04032BF4 RID: 207860
		[Token(Token = "0x4032BF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objHardModeBg;

		// Token: 0x04032BF5 RID: 207861
		[Token(Token = "0x4032BF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objAbyssModeBg;

		// Token: 0x04032BF6 RID: 207862
		[Token(Token = "0x4032BF6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AutoChessModeChoicePopView _prefabPopView;

		// Token: 0x04032BF7 RID: 207863
		[Token(Token = "0x4032BF7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _popViewContainer;

		// Token: 0x04032BF8 RID: 207864
		[Token(Token = "0x4032BF8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _funnyEnterAnim;

		// Token: 0x04032BF9 RID: 207865
		[Token(Token = "0x4032BF9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _funnyLoopAnim;

		// Token: 0x04032BFA RID: 207866
		[Token(Token = "0x4032BFA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _normalEnterAnim;

		// Token: 0x04032BFB RID: 207867
		[Token(Token = "0x4032BFB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _normalLoopAnim;

		// Token: 0x04032BFC RID: 207868
		[Token(Token = "0x4032BFC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _hardEnterAnim;

		// Token: 0x04032BFD RID: 207869
		[Token(Token = "0x4032BFD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _hardLoopAnim;

		// Token: 0x04032BFE RID: 207870
		[Token(Token = "0x4032BFE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _abyssEnterAnim;

		// Token: 0x04032BFF RID: 207871
		[Token(Token = "0x4032BFF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _abyssLoopAnim;

		// Token: 0x04032C00 RID: 207872
		[Token(Token = "0x4032C00")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x04032C01 RID: 207873
		[Token(Token = "0x4032C01")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationWrapper m_bgEnterAnimWrapper;

		// Token: 0x04032C02 RID: 207874
		[Token(Token = "0x4032C02")]
		[FieldOffset(Offset = "0xE0")]
		private AnimationWrapper m_bgLoopAnimWrapper;

		// Token: 0x04032C03 RID: 207875
		[Token(Token = "0x4032C03")]
		[FieldOffset(Offset = "0xE8")]
		private AutoChessModeChoicePopView m_choicePopView;

		// Token: 0x04032C04 RID: 207876
		[Token(Token = "0x4032C04")]
		[FieldOffset(Offset = "0xF0")]
		private ActAutoChessModeDifficultyType m_cachedModeType;

		// Token: 0x04032C05 RID: 207877
		[Token(Token = "0x4032C05")]
		[FieldOffset(Offset = "0xF4")]
		private int m_enterSeqNum;

		// Token: 0x04032C06 RID: 207878
		[Token(Token = "0x4032C06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032C07 RID: 207879
		[Token(Token = "0x4032C07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x04032C08 RID: 207880
		[Token(Token = "0x4032C08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032C09 RID: 207881
		[Token(Token = "0x4032C09")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowBgAnim;

		// Token: 0x04032C0A RID: 207882
		[Token(Token = "0x4032C0A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062CE RID: 25294
		[Token(Token = "0x20062CE")]
		private enum AnimationBGType
		{
			// Token: 0x04032C0C RID: 207884
			[Token(Token = "0x4032C0C")]
			FUNNY,
			// Token: 0x04032C0D RID: 207885
			[Token(Token = "0x4032C0D")]
			NORMAL,
			// Token: 0x04032C0E RID: 207886
			[Token(Token = "0x4032C0E")]
			HARD,
			// Token: 0x04032C0F RID: 207887
			[Token(Token = "0x4032C0F")]
			ABYSS
		}
	}
}
