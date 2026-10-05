using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F96 RID: 24470
	[Token(Token = "0x2005F96")]
	public class CharacterInfoRightHolderView : DataBinder<CharInfoGroupProperty>, IHotfixable
	{
		// Token: 0x0602366C RID: 145004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602366C")]
		[Address(RVA = "0x1E04D20", Offset = "0x1E03920", VA = "0x181E04D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602366D RID: 145005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602366D")]
		[Address(RVA = "0x1E04360", Offset = "0x1E02F60", VA = "0x181E04360")]
		public void OnEvolveStateChange()
		{
		}

		// Token: 0x0602366E RID: 145006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602366E")]
		[Address(RVA = "0x1E04C70", Offset = "0x1E03870", VA = "0x181E04C70")]
		private IEnumerator _EvolveStateChange()
		{
			return null;
		}

		// Token: 0x0602366F RID: 145007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602366F")]
		[Address(RVA = "0x1E045A0", Offset = "0x1E031A0", VA = "0x181E045A0")]
		public void OnSkillStateChange()
		{
		}

		// Token: 0x06023670 RID: 145008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023670")]
		[Address(RVA = "0x1E04480", Offset = "0x1E03080", VA = "0x181E04480")]
		public void OnProfStateChange()
		{
		}

		// Token: 0x06023671 RID: 145009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023671")]
		[Address(RVA = "0x1E04EA0", Offset = "0x1E03AA0", VA = "0x181E04EA0")]
		private void _OnFocusShow(float target)
		{
		}

		// Token: 0x06023672 RID: 145010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023672")]
		[Address(RVA = "0x1E04230", Offset = "0x1E02E30", VA = "0x181E04230")]
		public void DealWithHeightInfo(bool isInit)
		{
		}

		// Token: 0x06023673 RID: 145011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023673")]
		[Address(RVA = "0x1E04A40", Offset = "0x1E03640", VA = "0x181E04A40")]
		public void SetHide()
		{
		}

		// Token: 0x06023674 RID: 145012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023674")]
		[Address(RVA = "0x1E04B30", Offset = "0x1E03730", VA = "0x181E04B30")]
		public void SetSkillShow()
		{
		}

		// Token: 0x06023675 RID: 145013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023675")]
		[Address(RVA = "0x1E04710", Offset = "0x1E03310", VA = "0x181E04710", Slot = "7")]
		public override void OnValueChanged(CharInfoGroupProperty property)
		{
		}

		// Token: 0x06023676 RID: 145014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023676")]
		[Address(RVA = "0x1E05090", Offset = "0x1E03C90", VA = "0x181E05090")]
		public CharacterInfoRightHolderView()
		{
		}

		// Token: 0x04030E8B RID: 200331
		[Token(Token = "0x4030E8B")]
		private const float TWEEN_DURATION = 0.35f;

		// Token: 0x04030E8C RID: 200332
		[Token(Token = "0x4030E8C")]
		private const float EMPTY_HEIGHT = 53f;

		// Token: 0x04030E8D RID: 200333
		[Token(Token = "0x4030E8D")]
		private const float EVOLVE_ENLARGE_TIME = 0.2f;

		// Token: 0x04030E8E RID: 200334
		[Token(Token = "0x4030E8E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoRightProfView _profView;

		// Token: 0x04030E8F RID: 200335
		[Token(Token = "0x4030E8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterInfoRightLevelView _levelView;

		// Token: 0x04030E90 RID: 200336
		[Token(Token = "0x4030E90")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoRightSkillView _skillView;

		// Token: 0x04030E91 RID: 200337
		[Token(Token = "0x4030E91")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterInfoRightEvolvePotentialView _evolvePotentialView;

		// Token: 0x04030E92 RID: 200338
		[Token(Token = "0x4030E92")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HeightTweenLayoutElement _heightBar;

		// Token: 0x04030E93 RID: 200339
		[Token(Token = "0x4030E93")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04030E94 RID: 200340
		[Token(Token = "0x4030E94")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04030E95 RID: 200341
		[Token(Token = "0x4030E95")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04030E96 RID: 200342
		[Token(Token = "0x4030E96")]
		[FieldOffset(Offset = "0x59")]
		private bool m_currentSpread;

		// Token: 0x04030E97 RID: 200343
		[Token(Token = "0x4030E97")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_cacheTween;

		// Token: 0x04030E98 RID: 200344
		[Token(Token = "0x4030E98")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_cacheEmptyTween;

		// Token: 0x04030E99 RID: 200345
		[Token(Token = "0x4030E99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030E9A RID: 200346
		[Token(Token = "0x4030E9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvolveStateChange;

		// Token: 0x04030E9B RID: 200347
		[Token(Token = "0x4030E9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EvolveStateChange;

		// Token: 0x04030E9C RID: 200348
		[Token(Token = "0x4030E9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSkillStateChange;

		// Token: 0x04030E9D RID: 200349
		[Token(Token = "0x4030E9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProfStateChange;

		// Token: 0x04030E9E RID: 200350
		[Token(Token = "0x4030E9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFocusShow;

		// Token: 0x04030E9F RID: 200351
		[Token(Token = "0x4030E9F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DealWithHeightInfo;

		// Token: 0x04030EA0 RID: 200352
		[Token(Token = "0x4030EA0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetHide;

		// Token: 0x04030EA1 RID: 200353
		[Token(Token = "0x4030EA1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetSkillShow;

		// Token: 0x04030EA2 RID: 200354
		[Token(Token = "0x4030EA2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030EA3 RID: 200355
		[Token(Token = "0x4030EA3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
