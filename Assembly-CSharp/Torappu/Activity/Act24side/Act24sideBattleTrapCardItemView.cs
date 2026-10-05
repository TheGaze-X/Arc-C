using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200756B RID: 30059
	[Token(Token = "0x200756B")]
	public class Act24sideBattleTrapCardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A526 RID: 173350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A526")]
		[Address(RVA = "0x25F6400", Offset = "0x25F5000", VA = "0x1825F6400")]
		public void Render(Act24sideBattleTrapItemViewModel model)
		{
		}

		// Token: 0x0602A527 RID: 173351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A527")]
		[Address(RVA = "0x25F63A0", Offset = "0x25F4FA0", VA = "0x1825F63A0")]
		public void OnDestroy()
		{
		}

		// Token: 0x0602A528 RID: 173352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A528")]
		[Address(RVA = "0x25F6BD0", Offset = "0x25F57D0", VA = "0x1825F6BD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A529 RID: 173353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A529")]
		[Address(RVA = "0x25F6E00", Offset = "0x25F5A00", VA = "0x1825F6E00")]
		private void _PlaySelectAnim(bool isSelect, bool isFastMode)
		{
		}

		// Token: 0x0602A52A RID: 173354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A52A")]
		[Address(RVA = "0x25F6ED0", Offset = "0x25F5AD0", VA = "0x1825F6ED0")]
		private void _ResetNewUnlockTween()
		{
		}

		// Token: 0x0602A52B RID: 173355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A52B")]
		[Address(RVA = "0x25F6CF0", Offset = "0x25F58F0", VA = "0x1825F6CF0")]
		private void _PlayNewUnlockAnim()
		{
		}

		// Token: 0x0602A52C RID: 173356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A52C")]
		[Address(RVA = "0x25F6290", Offset = "0x25F4E90", VA = "0x1825F6290")]
		public void OnCardClick()
		{
		}

		// Token: 0x0602A52D RID: 173357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A52D")]
		[Address(RVA = "0x25F6F70", Offset = "0x25F5B70", VA = "0x1825F6F70")]
		public Act24sideBattleTrapCardItemView()
		{
		}

		// Token: 0x0403CDBB RID: 249275
		[Token(Token = "0x403CDBB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCardBg;

		// Token: 0x0403CDBC RID: 249276
		[Token(Token = "0x403CDBC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _newUnlockAnim;

		// Token: 0x0403CDBD RID: 249277
		[Token(Token = "0x403CDBD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objLockPart;

		// Token: 0x0403CDBE RID: 249278
		[Token(Token = "0x403CDBE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Lock Part")]
		private Text _txtLockDesc;

		// Token: 0x0403CDBF RID: 249279
		[Token(Token = "0x403CDBF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Unlock Part")]
		private GameObject _objUnlockPart;

		// Token: 0x0403CDC0 RID: 249280
		[Token(Token = "0x403CDC0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Unlock Part")]
		private Image _imgIconDec;

		// Token: 0x0403CDC1 RID: 249281
		[Token(Token = "0x403CDC1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Unlock Part")]
		private GameObject _objNewUnlockTag;

		// Token: 0x0403CDC2 RID: 249282
		[Token(Token = "0x403CDC2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Unlock Part")]
		private Image _imgIcon;

		// Token: 0x0403CDC3 RID: 249283
		[Token(Token = "0x403CDC3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Unlock Part")]
		private Text _txtToolTitle;

		// Token: 0x0403CDC4 RID: 249284
		[Token(Token = "0x403CDC4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Unlock Part")]
		private Image _imgIconSmall;

		// Token: 0x0403CDC5 RID: 249285
		[Token(Token = "0x403CDC5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Unlock Part")]
		private Text _txtToolDesc;

		// Token: 0x0403CDC6 RID: 249286
		[Token(Token = "0x403CDC6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Unlock Part")]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0403CDC7 RID: 249287
		[Token(Token = "0x403CDC7")]
		[FieldOffset(Offset = "0x88")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x0403CDC8 RID: 249288
		[Token(Token = "0x403CDC8")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0403CDC9 RID: 249289
		[Token(Token = "0x403CDC9")]
		[FieldOffset(Offset = "0x91")]
		private bool m_isSelectAnimFastMode;

		// Token: 0x0403CDCA RID: 249290
		[Token(Token = "0x403CDCA")]
		[FieldOffset(Offset = "0x92")]
		private bool m_isNewUnlockAnimPlayed;

		// Token: 0x0403CDCB RID: 249291
		[Token(Token = "0x403CDCB")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedTrapId;

		// Token: 0x0403CDCC RID: 249292
		[Token(Token = "0x403CDCC")]
		[FieldOffset(Offset = "0xA0")]
		private Act24sideBattleTrapItemViewModel.UnlockState m_cachedUnlockState;

		// Token: 0x0403CDCD RID: 249293
		[Token(Token = "0x403CDCD")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_finder;

		// Token: 0x0403CDCE RID: 249294
		[Token(Token = "0x403CDCE")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_cachedNewUnlockTween;

		// Token: 0x0403CDCF RID: 249295
		[Token(Token = "0x403CDCF")]
		private const float NEW_UNLOCK_ANIM_DELAY = 1f;

		// Token: 0x0403CDD0 RID: 249296
		[Token(Token = "0x403CDD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CDD1 RID: 249297
		[Token(Token = "0x403CDD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403CDD2 RID: 249298
		[Token(Token = "0x403CDD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CDD3 RID: 249299
		[Token(Token = "0x403CDD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlaySelectAnim;

		// Token: 0x0403CDD4 RID: 249300
		[Token(Token = "0x403CDD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetNewUnlockTween;

		// Token: 0x0403CDD5 RID: 249301
		[Token(Token = "0x403CDD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayNewUnlockAnim;

		// Token: 0x0403CDD6 RID: 249302
		[Token(Token = "0x403CDD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x0403CDD7 RID: 249303
		[Token(Token = "0x403CDD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
