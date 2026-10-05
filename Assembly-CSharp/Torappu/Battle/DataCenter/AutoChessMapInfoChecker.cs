using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.DataCenter
{
	// Token: 0x020026F4 RID: 9972
	[Token(Token = "0x20026F4")]
	public class AutoChessMapInfoChecker : IHotfixable
	{
		// Token: 0x0601038C RID: 66444 RVA: 0x00062EE0 File Offset: 0x000610E0
		[Token(Token = "0x601038C")]
		[Address(RVA = "0x7E1D90", Offset = "0x7E0990", VA = "0x1807E1D90")]
		public bool IsDirty()
		{
			return default(bool);
		}

		// Token: 0x0601038D RID: 66445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601038D")]
		[Address(RVA = "0x7E1E20", Offset = "0x7E0A20", VA = "0x1807E1E20")]
		public AutoChessMapInfoChecker()
		{
		}

		// Token: 0x04012255 RID: 74325
		[Token(Token = "0x4012255")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessDataCenter.DataChecker m_dataChecker;

		// Token: 0x04012256 RID: 74326
		[Token(Token = "0x4012256")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsDirty;

		// Token: 0x04012257 RID: 74327
		[Token(Token = "0x4012257")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
