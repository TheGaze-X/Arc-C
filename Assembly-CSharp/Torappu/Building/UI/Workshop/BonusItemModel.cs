using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BDE RID: 7134
	[Token(Token = "0x2001BDE")]
	public struct BonusItemModel : IHotfixable
	{
		// Token: 0x0600B209 RID: 45577 RVA: 0x00043F68 File Offset: 0x00042168
		[Token(Token = "0x600B209")]
		[Address(RVA = "0x32BAB00", Offset = "0x32B9700", VA = "0x1832BAB00")]
		public float GetProgress()
		{
			return 0f;
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x00043F80 File Offset: 0x00042180
		[Token(Token = "0x600B20A")]
		[Address(RVA = "0x32BABB0", Offset = "0x32B97B0", VA = "0x1832BABB0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0400AC9F RID: 44191
		[Token(Token = "0x400AC9F")]
		[FieldOffset(Offset = "0x0")]
		public string bonusId;

		// Token: 0x0400ACA0 RID: 44192
		[Token(Token = "0x400ACA0")]
		[FieldOffset(Offset = "0x8")]
		public int curPoint;

		// Token: 0x0400ACA1 RID: 44193
		[Token(Token = "0x400ACA1")]
		[FieldOffset(Offset = "0xC")]
		public int totalPoint;

		// Token: 0x0400ACA2 RID: 44194
		[Token(Token = "0x400ACA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetProgress;

		// Token: 0x0400ACA3 RID: 44195
		[Token(Token = "0x400ACA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsEmpty;
	}
}
