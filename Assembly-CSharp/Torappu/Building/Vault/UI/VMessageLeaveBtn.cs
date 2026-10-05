using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A84 RID: 6788
	[Token(Token = "0x2001A84")]
	public class VMessageLeaveBtn : VFuncFurnitureBtn
	{
		// Token: 0x0600AB30 RID: 43824 RVA: 0x00042318 File Offset: 0x00040518
		[Token(Token = "0x600AB30")]
		[Address(RVA = "0x3264780", Offset = "0x3263380", VA = "0x183264780", Slot = "10")]
		protected override bool _CheckShowBtn()
		{
			return default(bool);
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB31")]
		[Address(RVA = "0x32648B0", Offset = "0x32634B0", VA = "0x1832648B0", Slot = "11")]
		protected override void _UpdateStatus()
		{
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB32")]
		[Address(RVA = "0x3253DC0", Offset = "0x32529C0", VA = "0x183253DC0")]
		public VMessageLeaveBtn()
		{
		}

		// Token: 0x0400A37E RID: 41854
		[Token(Token = "0x400A37E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_forceShowBtn;
	}
}
