using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main10
{
	// Token: 0x02006A3E RID: 27198
	[Token(Token = "0x2006A3E")]
	public class Main10ZoneRecordCoverView : DataBinder<ZoneRecordViewProperty>, IHotfixable
	{
		// Token: 0x06026E15 RID: 159253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E15")]
		[Address(RVA = "0x21EE5F0", Offset = "0x21ED1F0", VA = "0x1821EE5F0", Slot = "7")]
		public override void OnValueChanged(ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026E16 RID: 159254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E16")]
		[Address(RVA = "0x21EE650", Offset = "0x21ED250", VA = "0x1821EE650")]
		public Main10ZoneRecordCoverView()
		{
		}

		// Token: 0x04036FA8 RID: 225192
		[Token(Token = "0x4036FA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036FA9 RID: 225193
		[Token(Token = "0x4036FA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
