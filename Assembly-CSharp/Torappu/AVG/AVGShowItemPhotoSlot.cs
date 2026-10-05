using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F6E RID: 8046
	[Token(Token = "0x2001F6E")]
	public class AVGShowItemPhotoSlot : AVGShowItemSlot
	{
		// Token: 0x0600C7E5 RID: 51173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E5")]
		[Address(RVA = "0x3490C70", Offset = "0x348F870", VA = "0x183490C70", Slot = "4")]
		public override void Show(Command command, Sprite sprite, Action onShowEnd)
		{
		}

		// Token: 0x0600C7E6 RID: 51174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E6")]
		[Address(RVA = "0x3490AC0", Offset = "0x348F6C0", VA = "0x183490AC0", Slot = "5")]
		public override void Hide(Command command, Action onShowEnd)
		{
		}

		// Token: 0x0600C7E7 RID: 51175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E7")]
		[Address(RVA = "0x3490F30", Offset = "0x348FB30", VA = "0x183490F30", Slot = "6")]
		protected override void _InitSlot()
		{
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E8")]
		[Address(RVA = "0x3490F90", Offset = "0x348FB90", VA = "0x183490F90")]
		public AVGShowItemPhotoSlot()
		{
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7E9")]
		[Address(RVA = "0x348FA20", Offset = "0x348E620", VA = "0x18348FA20")]
		private void <>xLuaBaseProxy_Show(Command P0, Sprite P1, Action P2)
		{
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7EA")]
		[Address(RVA = "0x348FA10", Offset = "0x348E610", VA = "0x18348FA10")]
		private void <>xLuaBaseProxy_Hide(Command P0, Action P1)
		{
		}

		// Token: 0x0400CE2B RID: 52779
		[Token(Token = "0x400CE2B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _defaultFadeTime;

		// Token: 0x0400CE2C RID: 52780
		[Token(Token = "0x400CE2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0400CE2D RID: 52781
		[Token(Token = "0x400CE2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400CE2E RID: 52782
		[Token(Token = "0x400CE2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitSlot;

		// Token: 0x0400CE2F RID: 52783
		[Token(Token = "0x400CE2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
