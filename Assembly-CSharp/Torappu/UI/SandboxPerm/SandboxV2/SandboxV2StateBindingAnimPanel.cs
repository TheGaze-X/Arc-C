using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200412D RID: 16685
	[Token(Token = "0x200412D")]
	public class SandboxV2StateBindingAnimPanel : SandboxV2StateBindingPanel
	{
		// Token: 0x06019C55 RID: 105557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C55")]
		[Address(RVA = "0x12B5B40", Offset = "0x12B4740", VA = "0x1812B5B40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019C56 RID: 105558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C56")]
		[Address(RVA = "0x12B59B0", Offset = "0x12B45B0", VA = "0x1812B59B0", Slot = "4")]
		public override void SetShow(bool isShow)
		{
		}

		// Token: 0x06019C57 RID: 105559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C57")]
		[Address(RVA = "0x12B5C50", Offset = "0x12B4850", VA = "0x1812B5C50")]
		public SandboxV2StateBindingAnimPanel()
		{
		}

		// Token: 0x04020505 RID: 132357
		[Token(Token = "0x4020505")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04020506 RID: 132358
		[Token(Token = "0x4020506")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04020507 RID: 132359
		[Token(Token = "0x4020507")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_showTween;

		// Token: 0x04020508 RID: 132360
		[Token(Token = "0x4020508")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020509 RID: 132361
		[Token(Token = "0x4020509")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402050A RID: 132362
		[Token(Token = "0x402050A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
