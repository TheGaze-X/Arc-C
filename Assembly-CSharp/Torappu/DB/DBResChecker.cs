using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DB
{
	// Token: 0x0200169D RID: 5789
	[Token(Token = "0x200169D")]
	public class DBResChecker : SingletonMonoBehaviour<DBResChecker>, ISingletonNotAutoCreate
	{
		// Token: 0x060092AB RID: 37547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AB")]
		[Address(RVA = "0x2B31440", Offset = "0x2B30040", VA = "0x182B31440", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AC")]
		[Address(RVA = "0x2B314C0", Offset = "0x2B300C0", VA = "0x182B314C0")]
		private void _CheckAllDBs()
		{
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AD")]
		[Address(RVA = "0x2B31770", Offset = "0x2B30370", VA = "0x182B31770")]
		private void _MarkDBInvalid(AbstractTable table)
		{
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092AE")]
		[Address(RVA = "0x2B31840", Offset = "0x2B30440", VA = "0x182B31840")]
		public DBResChecker()
		{
		}

		// Token: 0x0400884E RID: 34894
		[Token(Token = "0x400884E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400884F RID: 34895
		[Token(Token = "0x400884F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckAllDBs;

		// Token: 0x04008850 RID: 34896
		[Token(Token = "0x4008850")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MarkDBInvalid;

		// Token: 0x04008851 RID: 34897
		[Token(Token = "0x4008851")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
