using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Appetizer
{
	// Token: 0x02002024 RID: 8228
	[Token(Token = "0x2002024")]
	public class AppetizerTrace : Singleton<AppetizerTrace>
	{
		// Token: 0x0600CAB2 RID: 51890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB2")]
		[Address(RVA = "0x34BE230", Offset = "0x34BCE30", VA = "0x1834BE230")]
		private AppetizerTrace()
		{
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB3")]
		[Address(RVA = "0x34BE040", Offset = "0x34BCC40", VA = "0x1834BE040")]
		public void NotifyHGLoginWithPhone()
		{
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB4")]
		[Address(RVA = "0x34BDF40", Offset = "0x34BCB40", VA = "0x1834BDF40")]
		public void NotifyHGLoginWithAccount()
		{
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB5")]
		[Address(RVA = "0x34BDFC0", Offset = "0x34BCBC0", VA = "0x1834BDFC0")]
		public void NotifyHGLoginWithGuest()
		{
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB6")]
		[Address(RVA = "0x34BE0C0", Offset = "0x34BCCC0", VA = "0x1834BE0C0")]
		public void NotifyHGLoginWithToken()
		{
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB7")]
		[Address(RVA = "0x34BDD00", Offset = "0x34BC900", VA = "0x1834BDD00")]
		public void LoginTrace()
		{
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB8")]
		[Address(RVA = "0x34BE140", Offset = "0x34BCD40", VA = "0x1834BE140")]
		private void _DoTrace(Dictionary<string, object> dict)
		{
		}

		// Token: 0x0400D468 RID: 54376
		[Token(Token = "0x400D468")]
		[FieldOffset(Offset = "0x10")]
		private string m_HGLoginMethod;

		// Token: 0x0400D469 RID: 54377
		[Token(Token = "0x400D469")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D46A RID: 54378
		[Token(Token = "0x400D46A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyHGLoginWithPhone;

		// Token: 0x0400D46B RID: 54379
		[Token(Token = "0x400D46B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyHGLoginWithAccount;

		// Token: 0x0400D46C RID: 54380
		[Token(Token = "0x400D46C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyHGLoginWithGuest;

		// Token: 0x0400D46D RID: 54381
		[Token(Token = "0x400D46D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyHGLoginWithToken;

		// Token: 0x0400D46E RID: 54382
		[Token(Token = "0x400D46E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoginTrace;

		// Token: 0x0400D46F RID: 54383
		[Token(Token = "0x400D46F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoTrace;
	}
}
