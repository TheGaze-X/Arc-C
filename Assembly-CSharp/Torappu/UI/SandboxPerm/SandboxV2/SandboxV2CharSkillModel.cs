using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004440 RID: 17472
	[Token(Token = "0x2004440")]
	public class SandboxV2CharSkillModel : IHotfixable
	{
		// Token: 0x0601AB39 RID: 109369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB39")]
		[Address(RVA = "0x13C2180", Offset = "0x13C0D80", VA = "0x1813C2180")]
		public SandboxV2CharSkillModel()
		{
		}

		// Token: 0x0402215F RID: 139615
		[Token(Token = "0x402215F")]
		[FieldOffset(Offset = "0x10")]
		public string skillId;

		// Token: 0x04022160 RID: 139616
		[Token(Token = "0x4022160")]
		[FieldOffset(Offset = "0x18")]
		public bool isUnlock;

		// Token: 0x04022161 RID: 139617
		[Token(Token = "0x4022161")]
		[FieldOffset(Offset = "0x1C")]
		public int specLv;

		// Token: 0x04022162 RID: 139618
		[Token(Token = "0x4022162")]
		[FieldOffset(Offset = "0x20")]
		public int mainSkillLv;

		// Token: 0x04022163 RID: 139619
		[Token(Token = "0x4022163")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
