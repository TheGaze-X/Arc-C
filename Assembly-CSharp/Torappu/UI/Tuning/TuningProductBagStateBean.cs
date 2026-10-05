using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D02 RID: 15618
	[Token(Token = "0x2003D02")]
	public class TuningProductBagStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x060185BC RID: 99772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A3B")]
		public TuningProductBagProperty prop
		{
			[Token(Token = "0x60185BC")]
			[Address(RVA = "0x10DC450", Offset = "0x10DB050", VA = "0x1810DC450")]
			get
			{
				return null;
			}
		}

		// Token: 0x060185BD RID: 99773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185BD")]
		[Address(RVA = "0x10DC160", Offset = "0x10DAD60", VA = "0x1810DC160")]
		public void InitData(string actId)
		{
		}

		// Token: 0x060185BE RID: 99774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185BE")]
		[Address(RVA = "0x10DC360", Offset = "0x10DAF60", VA = "0x1810DC360")]
		public TuningProductBagStateBean()
		{
		}

		// Token: 0x0401DC6E RID: 121966
		[Token(Token = "0x401DC6E")]
		[FieldOffset(Offset = "0x10")]
		private TuningProductBagProperty m_prop;

		// Token: 0x0401DC6F RID: 121967
		[Token(Token = "0x401DC6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0401DC70 RID: 121968
		[Token(Token = "0x401DC70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DC71 RID: 121969
		[Token(Token = "0x401DC71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
