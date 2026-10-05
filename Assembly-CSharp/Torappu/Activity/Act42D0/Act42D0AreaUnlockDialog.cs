using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007331 RID: 29489
	[Token(Token = "0x2007331")]
	public class Act42D0AreaUnlockDialog : UICustomDialog<Act42D0AreaUnlockDialog.Options>
	{
		// Token: 0x06029B40 RID: 170816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B40")]
		[Address(RVA = "0x2503E10", Offset = "0x2502A10", VA = "0x182503E10", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06029B41 RID: 170817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B41")]
		[Address(RVA = "0x2503E70", Offset = "0x2502A70", VA = "0x182503E70", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x06029B42 RID: 170818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B42")]
		[Address(RVA = "0x2503F90", Offset = "0x2502B90", VA = "0x182503F90", Slot = "7")]
		protected override void OnRender(Act42D0AreaUnlockDialog.Options options)
		{
		}

		// Token: 0x06029B43 RID: 170819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B43")]
		[Address(RVA = "0x2503D80", Offset = "0x2502980", VA = "0x182503D80")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06029B44 RID: 170820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B44")]
		[Address(RVA = "0x2504240", Offset = "0x2502E40", VA = "0x182504240")]
		public Act42D0AreaUnlockDialog()
		{
		}

		// Token: 0x0403BB01 RID: 244481
		[Token(Token = "0x403BB01")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _areaCodeIcon;

		// Token: 0x0403BB02 RID: 244482
		[Token(Token = "0x403BB02")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _areaUnlockText;

		// Token: 0x0403BB03 RID: 244483
		[Token(Token = "0x403BB03")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403BB04 RID: 244484
		[Token(Token = "0x403BB04")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0403BB05 RID: 244485
		[Token(Token = "0x403BB05")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0403BB06 RID: 244486
		[Token(Token = "0x403BB06")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_enterTween;

		// Token: 0x0403BB07 RID: 244487
		[Token(Token = "0x403BB07")]
		[FieldOffset(Offset = "0x88")]
		private Act42D0AreaUnlockDialog.Options m_options;

		// Token: 0x0403BB08 RID: 244488
		[Token(Token = "0x403BB08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403BB09 RID: 244489
		[Token(Token = "0x403BB09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403BB0A RID: 244490
		[Token(Token = "0x403BB0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403BB0B RID: 244491
		[Token(Token = "0x403BB0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0403BB0C RID: 244492
		[Token(Token = "0x403BB0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007332 RID: 29490
		[Token(Token = "0x2007332")]
		public struct Options
		{
			// Token: 0x0403BB0D RID: 244493
			[Token(Token = "0x403BB0D")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x0403BB0E RID: 244494
			[Token(Token = "0x403BB0E")]
			[FieldOffset(Offset = "0x8")]
			public string areaId;

			// Token: 0x0403BB0F RID: 244495
			[Token(Token = "0x403BB0F")]
			[FieldOffset(Offset = "0x10")]
			public Action callback;
		}
	}
}
