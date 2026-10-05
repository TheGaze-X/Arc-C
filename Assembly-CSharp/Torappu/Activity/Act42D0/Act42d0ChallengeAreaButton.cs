using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007397 RID: 29591
	[Token(Token = "0x2007397")]
	public class Act42d0ChallengeAreaButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D45 RID: 171333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D45")]
		[Address(RVA = "0x257A690", Offset = "0x2579290", VA = "0x18257A690")]
		public void RenderBtn(Act42D0ChallengeStageViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x06029D46 RID: 171334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D46")]
		[Address(RVA = "0x257AA10", Offset = "0x2579610", VA = "0x18257AA10")]
		private void _PlaySelectAnimIfNeed(bool isSelected)
		{
		}

		// Token: 0x06029D47 RID: 171335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D47")]
		[Address(RVA = "0x257A5A0", Offset = "0x25791A0", VA = "0x18257A5A0")]
		public void EventOnChallengeStageClick()
		{
		}

		// Token: 0x06029D48 RID: 171336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D48")]
		[Address(RVA = "0x257AB50", Offset = "0x2579750", VA = "0x18257AB50")]
		public Act42d0ChallengeAreaButton()
		{
		}

		// Token: 0x0403BE93 RID: 245395
		[Token(Token = "0x403BE93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _areaCodeText;

		// Token: 0x0403BE94 RID: 245396
		[Token(Token = "0x403BE94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _lockTime;

		// Token: 0x0403BE95 RID: 245397
		[Token(Token = "0x403BE95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0403BE96 RID: 245398
		[Token(Token = "0x403BE96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403BE97 RID: 245399
		[Token(Token = "0x403BE97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _finishPartGo;

		// Token: 0x0403BE98 RID: 245400
		[Token(Token = "0x403BE98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selectedPartGo;

		// Token: 0x0403BE99 RID: 245401
		[Token(Token = "0x403BE99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _iconCompleteGo;

		// Token: 0x0403BE9A RID: 245402
		[Token(Token = "0x403BE9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _isNew;

		// Token: 0x0403BE9B RID: 245403
		[Token(Token = "0x403BE9B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _lockIconGo;

		// Token: 0x0403BE9C RID: 245404
		[Token(Token = "0x403BE9C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0403BE9D RID: 245405
		[Token(Token = "0x403BE9D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorCodeNormal;

		// Token: 0x0403BE9E RID: 245406
		[Token(Token = "0x403BE9E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorCodeLocked;

		// Token: 0x0403BE9F RID: 245407
		[Token(Token = "0x403BE9F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _colorCodeAllCompleted;

		// Token: 0x0403BEA0 RID: 245408
		[Token(Token = "0x403BEA0")]
		[FieldOffset(Offset = "0xA0")]
		private string m_stageId;

		// Token: 0x0403BEA1 RID: 245409
		[Token(Token = "0x403BEA1")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BEA2 RID: 245410
		[Token(Token = "0x403BEA2")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_tween;

		// Token: 0x0403BEA3 RID: 245411
		[Token(Token = "0x403BEA3")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_cachedSelected;

		// Token: 0x0403BEA4 RID: 245412
		[Token(Token = "0x403BEA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderBtn;

		// Token: 0x0403BEA5 RID: 245413
		[Token(Token = "0x403BEA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlaySelectAnimIfNeed;

		// Token: 0x0403BEA6 RID: 245414
		[Token(Token = "0x403BEA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnChallengeStageClick;

		// Token: 0x0403BEA7 RID: 245415
		[Token(Token = "0x403BEA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
