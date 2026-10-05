using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A3B RID: 14907
	[Token(Token = "0x2003A3B")]
	public class UITransloadingMask : UIFloatMask
	{
		// Token: 0x06017883 RID: 96387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017883")]
		[Address(RVA = "0xFD7BE0", Offset = "0xFD67E0", VA = "0x180FD7BE0", Slot = "4")]
		protected override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06017884 RID: 96388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017884")]
		[Address(RVA = "0xFD7A70", Offset = "0xFD6670", VA = "0x180FD7A70", Slot = "5")]
		protected override void OnShow()
		{
		}

		// Token: 0x06017885 RID: 96389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017885")]
		[Address(RVA = "0xFD7930", Offset = "0xFD6530", VA = "0x180FD7930", Slot = "6")]
		protected override IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06017886 RID: 96390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017886")]
		[Address(RVA = "0xFD79E0", Offset = "0xFD65E0", VA = "0x180FD79E0", Slot = "7")]
		protected override void OnHide()
		{
		}

		// Token: 0x06017887 RID: 96391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017887")]
		[Address(RVA = "0xFD7C90", Offset = "0xFD6890", VA = "0x180FD7C90")]
		public UITransloadingMask()
		{
		}

		// Token: 0x06017888 RID: 96392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017888")]
		[Address(RVA = "0xFCC030", Offset = "0xFCAC30", VA = "0x180FCC030")]
		private void <>xLuaBaseProxy_OnShow()
		{
		}

		// Token: 0x06017889 RID: 96393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017889")]
		[Address(RVA = "0xED08C0", Offset = "0xECF4C0", VA = "0x180ED08C0")]
		private void <>xLuaBaseProxy_OnHide()
		{
		}

		// Token: 0x0401C6B1 RID: 116401
		[Token(Token = "0x401C6B1")]
		public const float ANIM_DURATION = 0.36f;

		// Token: 0x0401C6B2 RID: 116402
		[Token(Token = "0x401C6B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animationForShow;

		// Token: 0x0401C6B3 RID: 116403
		[Token(Token = "0x401C6B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _rippleAnim;

		// Token: 0x0401C6B4 RID: 116404
		[Token(Token = "0x401C6B4")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_rippleTween;

		// Token: 0x0401C6B5 RID: 116405
		[Token(Token = "0x401C6B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401C6B6 RID: 116406
		[Token(Token = "0x401C6B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401C6B7 RID: 116407
		[Token(Token = "0x401C6B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401C6B8 RID: 116408
		[Token(Token = "0x401C6B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x0401C6B9 RID: 116409
		[Token(Token = "0x401C6B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
