using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200256E RID: 9582
	[Token(Token = "0x200256E")]
	public class NeverTrigger : TargetTrigger
	{
		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x0600F746 RID: 63302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002071")]
		public override Entity target
		{
			[Token(Token = "0x600F746")]
			[Address(RVA = "0x7114A0", Offset = "0x7100A0", VA = "0x1807114A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F747 RID: 63303 RVA: 0x0005C598 File Offset: 0x0005A798
		[Token(Token = "0x600F747")]
		[Address(RVA = "0x711390", Offset = "0x70FF90", VA = "0x180711390", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F748 RID: 63304 RVA: 0x0005C5B0 File Offset: 0x0005A7B0
		[Token(Token = "0x600F748")]
		[Address(RVA = "0x711320", Offset = "0x70FF20", VA = "0x180711320", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F749 RID: 63305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F749")]
		[Address(RVA = "0x711400", Offset = "0x710000", VA = "0x180711400")]
		public NeverTrigger()
		{
		}

		// Token: 0x040112B7 RID: 70327
		[Token(Token = "0x40112B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x040112B8 RID: 70328
		[Token(Token = "0x40112B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112B9 RID: 70329
		[Token(Token = "0x40112B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040112BA RID: 70330
		[Token(Token = "0x40112BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
