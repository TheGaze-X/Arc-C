using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007771 RID: 30577
	[Token(Token = "0x2007771")]
	public class Act1VHalfIdlePlotSquadStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170064AF RID: 25775
		// (get) Token: 0x0602AF2C RID: 175916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064AF")]
		public Act1VHalfIdlePlotSquadProperty property
		{
			[Token(Token = "0x602AF2C")]
			[Address(RVA = "0x26B4EB0", Offset = "0x26B3AB0", VA = "0x1826B4EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602AF2D RID: 175917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF2D")]
		[Address(RVA = "0x26B4E10", Offset = "0x26B3A10", VA = "0x1826B4E10")]
		public Act1VHalfIdlePlotSquadStateBean()
		{
		}

		// Token: 0x0403DF79 RID: 253817
		[Token(Token = "0x403DF79")]
		[FieldOffset(Offset = "0x10")]
		private Act1VHalfIdlePlotSquadProperty m_property;

		// Token: 0x0403DF7A RID: 253818
		[Token(Token = "0x403DF7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x0403DF7B RID: 253819
		[Token(Token = "0x403DF7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
