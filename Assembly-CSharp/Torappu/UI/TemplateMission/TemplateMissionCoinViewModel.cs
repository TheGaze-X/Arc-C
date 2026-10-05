using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DAB RID: 15787
	[Token(Token = "0x2003DAB")]
	public class TemplateMissionCoinViewModel : IHotfixable
	{
		// Token: 0x060188B9 RID: 100537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188B9")]
		[Address(RVA = "0x1109840", Offset = "0x1108440", VA = "0x181109840")]
		public TemplateMissionCoinViewModel(Func<int> getCoinFunc)
		{
		}

		// Token: 0x060188BA RID: 100538 RVA: 0x0009AAB8 File Offset: 0x00098CB8
		[Token(Token = "0x60188BA")]
		[Address(RVA = "0x11097C0", Offset = "0x11083C0", VA = "0x1811097C0")]
		public int GetCoinCount()
		{
			return 0;
		}

		// Token: 0x0401E17F RID: 123263
		[Token(Token = "0x401E17F")]
		[FieldOffset(Offset = "0x10")]
		private Func<int> m_getCoinFunc;

		// Token: 0x0401E180 RID: 123264
		[Token(Token = "0x401E180")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E181 RID: 123265
		[Token(Token = "0x401E181")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCoinCount;
	}
}
