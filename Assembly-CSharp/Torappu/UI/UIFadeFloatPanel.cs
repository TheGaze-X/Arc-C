using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039FB RID: 14843
	[Token(Token = "0x20039FB")]
	public class UIFadeFloatPanel : UIReentrantFloatPanel
	{
		// Token: 0x060176DD RID: 95965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176DD")]
		[Address(RVA = "0xFC3960", Offset = "0xFC2560", VA = "0x180FC3960", Slot = "4")]
		protected override IEnumerator ShowEffect()
		{
			return null;
		}

		// Token: 0x060176DE RID: 95966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176DE")]
		[Address(RVA = "0xFC38B0", Offset = "0xFC24B0", VA = "0x180FC38B0", Slot = "5")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x060176DF RID: 95967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176DF")]
		[Address(RVA = "0xFC3A10", Offset = "0xFC2610", VA = "0x180FC3A10")]
		private void _ResetSharedTween()
		{
		}

		// Token: 0x060176E0 RID: 95968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176E0")]
		[Address(RVA = "0xFC3AB0", Offset = "0xFC26B0", VA = "0x180FC3AB0")]
		public UIFadeFloatPanel()
		{
		}

		// Token: 0x060176E1 RID: 95969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176E1")]
		[Address(RVA = "0xFBC280", Offset = "0xFBAE80", VA = "0x180FBC280")]
		private IEnumerator <>xLuaBaseProxy_ShowEffect()
		{
			return null;
		}

		// Token: 0x060176E2 RID: 95970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176E2")]
		[Address(RVA = "0xFBC270", Offset = "0xFBAE70", VA = "0x180FBC270")]
		private IEnumerator <>xLuaBaseProxy_HideEffect()
		{
			return null;
		}

		// Token: 0x0401C4E4 RID: 115940
		[Token(Token = "0x401C4E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401C4E5 RID: 115941
		[Token(Token = "0x401C4E5")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_sharedTween;

		// Token: 0x0401C4E6 RID: 115942
		[Token(Token = "0x401C4E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x0401C4E7 RID: 115943
		[Token(Token = "0x401C4E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0401C4E8 RID: 115944
		[Token(Token = "0x401C4E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetSharedTween;

		// Token: 0x0401C4E9 RID: 115945
		[Token(Token = "0x401C4E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
