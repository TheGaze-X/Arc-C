using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main10
{
	// Token: 0x02006A3C RID: 27196
	[Token(Token = "0x2006A3C")]
	public class Main10ZoneRecordContentView : DataBinder<ZoneRecordViewProperty>, IHotfixable
	{
		// Token: 0x06026DF7 RID: 159223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DF7")]
		[Address(RVA = "0x21EC5E0", Offset = "0x21EB1E0", VA = "0x1821EC5E0", Slot = "7")]
		public override void OnValueChanged(ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026DF8 RID: 159224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DF8")]
		[Address(RVA = "0x21EC640", Offset = "0x21EB240", VA = "0x1821EC640")]
		public Main10ZoneRecordContentView()
		{
		}

		// Token: 0x04036F83 RID: 225155
		[Token(Token = "0x4036F83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036F84 RID: 225156
		[Token(Token = "0x4036F84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
