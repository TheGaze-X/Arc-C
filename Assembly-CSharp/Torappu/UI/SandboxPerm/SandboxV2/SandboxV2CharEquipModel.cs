using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004441 RID: 17473
	[Token(Token = "0x2004441")]
	public class SandboxV2CharEquipModel : IComparable<SandboxV2CharEquipModel>, IHotfixable
	{
		// Token: 0x0601AB3A RID: 109370 RVA: 0x000A3050 File Offset: 0x000A1250
		[Token(Token = "0x601AB3A")]
		[Address(RVA = "0x13BD0B0", Offset = "0x13BBCB0", VA = "0x1813BD0B0", Slot = "4")]
		public int CompareTo(SandboxV2CharEquipModel other)
		{
			return 0;
		}

		// Token: 0x0601AB3B RID: 109371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB3B")]
		[Address(RVA = "0x13BD140", Offset = "0x13BBD40", VA = "0x1813BD140")]
		public SandboxV2CharEquipModel()
		{
		}

		// Token: 0x04022164 RID: 139620
		[Token(Token = "0x4022164")]
		[FieldOffset(Offset = "0x10")]
		public string equipId;

		// Token: 0x04022165 RID: 139621
		[Token(Token = "0x4022165")]
		[FieldOffset(Offset = "0x18")]
		public int equipOrder;

		// Token: 0x04022166 RID: 139622
		[Token(Token = "0x4022166")]
		[FieldOffset(Offset = "0x20")]
		public string typeIcon;

		// Token: 0x04022167 RID: 139623
		[Token(Token = "0x4022167")]
		[FieldOffset(Offset = "0x28")]
		public int equipLv;

		// Token: 0x04022168 RID: 139624
		[Token(Token = "0x4022168")]
		[FieldOffset(Offset = "0x2C")]
		public bool isAvail;

		// Token: 0x04022169 RID: 139625
		[Token(Token = "0x4022169")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402216A RID: 139626
		[Token(Token = "0x402216A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
