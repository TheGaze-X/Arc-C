using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B91 RID: 15249
	[Token(Token = "0x2003B91")]
	public class VoucherSkinHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x06017E52 RID: 97874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003911")]
		public VoucherSkinHomeViewProperty prop
		{
			[Token(Token = "0x6017E52")]
			[Address(RVA = "0x1024B90", Offset = "0x1023790", VA = "0x181024B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017E53 RID: 97875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E53")]
		[Address(RVA = "0x1024A00", Offset = "0x1023600", VA = "0x181024A00")]
		public void LoadData(VoucherSkinPage.Params param)
		{
		}

		// Token: 0x06017E54 RID: 97876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E54")]
		[Address(RVA = "0x1024AA0", Offset = "0x10236A0", VA = "0x181024AA0")]
		public VoucherSkinHomeStateBean()
		{
		}

		// Token: 0x0401CE41 RID: 118337
		[Token(Token = "0x401CE41")]
		[FieldOffset(Offset = "0x10")]
		private VoucherSkinHomeViewProperty m_prop;

		// Token: 0x0401CE42 RID: 118338
		[Token(Token = "0x401CE42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0401CE43 RID: 118339
		[Token(Token = "0x401CE43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401CE44 RID: 118340
		[Token(Token = "0x401CE44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
