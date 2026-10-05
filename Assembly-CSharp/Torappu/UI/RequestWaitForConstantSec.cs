using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003964 RID: 14692
	[Token(Token = "0x2003964")]
	public class RequestWaitForConstantSec : LoopRequestSender.IRequestWaitStrategy, IHotfixable
	{
		// Token: 0x0601736F RID: 95087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601736F")]
		[Address(RVA = "0xF8FD80", Offset = "0xF8E980", VA = "0x180F8FD80")]
		public RequestWaitForConstantSec(int waitSec)
		{
		}

		// Token: 0x06017370 RID: 95088 RVA: 0x00095550 File Offset: 0x00093750
		[Token(Token = "0x6017370")]
		[Address(RVA = "0xF8FCF0", Offset = "0xF8E8F0", VA = "0x180F8FCF0", Slot = "4")]
		public bool IsWaitEnough(LoopRequestSender.RequestWaitParam waitParam)
		{
			return default(bool);
		}

		// Token: 0x0401C052 RID: 114770
		[Token(Token = "0x401C052")]
		[FieldOffset(Offset = "0x10")]
		private int m_waitSec;

		// Token: 0x0401C053 RID: 114771
		[Token(Token = "0x401C053")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C054 RID: 114772
		[Token(Token = "0x401C054")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsWaitEnough;
	}
}
