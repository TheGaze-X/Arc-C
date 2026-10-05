using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D08 RID: 15624
	[Token(Token = "0x2003D08")]
	public class TuningProductConfirmStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x060185EC RID: 99820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A4E")]
		public TuningProductConfirmProperty prop
		{
			[Token(Token = "0x60185EC")]
			[Address(RVA = "0x10DF860", Offset = "0x10DE460", VA = "0x1810DF860")]
			get
			{
				return null;
			}
		}

		// Token: 0x060185ED RID: 99821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185ED")]
		[Address(RVA = "0x10DF4F0", Offset = "0x10DE0F0", VA = "0x1810DF4F0")]
		public void InitData(string actId)
		{
		}

		// Token: 0x060185EE RID: 99822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185EE")]
		[Address(RVA = "0x10DF680", Offset = "0x10DE280", VA = "0x1810DF680")]
		public void SetInputProductId(string iProductId)
		{
		}

		// Token: 0x060185EF RID: 99823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185EF")]
		[Address(RVA = "0x10DF700", Offset = "0x10DE300", VA = "0x1810DF700")]
		public void SetResultNew(bool iResultIsNew)
		{
		}

		// Token: 0x060185F0 RID: 99824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185F0")]
		[Address(RVA = "0x10DF770", Offset = "0x10DE370", VA = "0x1810DF770")]
		public TuningProductConfirmStateBean()
		{
		}

		// Token: 0x0401DCCA RID: 122058
		[Token(Token = "0x401DCCA")]
		[FieldOffset(Offset = "0x10")]
		private string m_inputProductId;

		// Token: 0x0401DCCB RID: 122059
		[Token(Token = "0x401DCCB")]
		[FieldOffset(Offset = "0x18")]
		private TuningProductConfirmProperty m_prop;

		// Token: 0x0401DCCC RID: 122060
		[Token(Token = "0x401DCCC")]
		[FieldOffset(Offset = "0x20")]
		private int m_enterSequenceNum;

		// Token: 0x0401DCCD RID: 122061
		[Token(Token = "0x401DCCD")]
		[FieldOffset(Offset = "0x24")]
		private bool m_resultIsNew;

		// Token: 0x0401DCCE RID: 122062
		[Token(Token = "0x401DCCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0401DCCF RID: 122063
		[Token(Token = "0x401DCCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DCD0 RID: 122064
		[Token(Token = "0x401DCD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetInputProductId;

		// Token: 0x0401DCD1 RID: 122065
		[Token(Token = "0x401DCD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetResultNew;

		// Token: 0x0401DCD2 RID: 122066
		[Token(Token = "0x401DCD2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
