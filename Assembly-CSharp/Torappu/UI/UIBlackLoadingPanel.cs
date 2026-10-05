using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039D1 RID: 14801
	[Token(Token = "0x20039D1")]
	public class UIBlackLoadingPanel : UIReentrantFloatPanel
	{
		// Token: 0x06017610 RID: 95760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017610")]
		[Address(RVA = "0xFBC1C0", Offset = "0xFBADC0", VA = "0x180FBC1C0", Slot = "4")]
		protected override IEnumerator ShowEffect()
		{
			return null;
		}

		// Token: 0x06017611 RID: 95761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017611")]
		[Address(RVA = "0xFBC110", Offset = "0xFBAD10", VA = "0x180FBC110", Slot = "5")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x06017612 RID: 95762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017612")]
		[Address(RVA = "0xFBC290", Offset = "0xFBAE90", VA = "0x180FBC290")]
		private void _ResetSharedTween()
		{
		}

		// Token: 0x06017613 RID: 95763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017613")]
		[Address(RVA = "0xFBC330", Offset = "0xFBAF30", VA = "0x180FBC330")]
		public UIBlackLoadingPanel()
		{
		}

		// Token: 0x06017614 RID: 95764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017614")]
		[Address(RVA = "0xFBC280", Offset = "0xFBAE80", VA = "0x180FBC280")]
		private IEnumerator <>xLuaBaseProxy_ShowEffect()
		{
			return null;
		}

		// Token: 0x06017615 RID: 95765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017615")]
		[Address(RVA = "0xFBC270", Offset = "0xFBAE70", VA = "0x180FBC270")]
		private IEnumerator <>xLuaBaseProxy_HideEffect()
		{
			return null;
		}

		// Token: 0x0401C3D0 RID: 115664
		[Token(Token = "0x401C3D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401C3D1 RID: 115665
		[Token(Token = "0x401C3D1")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_sharedTween;

		// Token: 0x0401C3D2 RID: 115666
		[Token(Token = "0x401C3D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x0401C3D3 RID: 115667
		[Token(Token = "0x401C3D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0401C3D4 RID: 115668
		[Token(Token = "0x401C3D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetSharedTween;

		// Token: 0x0401C3D5 RID: 115669
		[Token(Token = "0x401C3D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
