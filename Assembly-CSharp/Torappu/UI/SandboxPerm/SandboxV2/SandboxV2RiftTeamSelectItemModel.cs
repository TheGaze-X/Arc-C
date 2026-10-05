using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043A4 RID: 17316
	[Token(Token = "0x20043A4")]
	public class SandboxV2RiftTeamSelectItemModel : IHotfixable
	{
		// Token: 0x0601A92D RID: 108845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A92D")]
		[Address(RVA = "0x13B8170", Offset = "0x13B6D70", VA = "0x1813B8170")]
		public SandboxV2RiftTeamSelectItemModel()
		{
		}

		// Token: 0x04021DB9 RID: 138681
		[Token(Token = "0x4021DB9")]
		[FieldOffset(Offset = "0x10")]
		public string teamId;

		// Token: 0x04021DBA RID: 138682
		[Token(Token = "0x4021DBA")]
		[FieldOffset(Offset = "0x18")]
		public string teamBgId;

		// Token: 0x04021DBB RID: 138683
		[Token(Token = "0x4021DBB")]
		[FieldOffset(Offset = "0x20")]
		public string teamName;

		// Token: 0x04021DBC RID: 138684
		[Token(Token = "0x4021DBC")]
		[FieldOffset(Offset = "0x28")]
		public string teamBigIconId;

		// Token: 0x04021DBD RID: 138685
		[Token(Token = "0x4021DBD")]
		[FieldOffset(Offset = "0x30")]
		public string teamDesc;

		// Token: 0x04021DBE RID: 138686
		[Token(Token = "0x4021DBE")]
		[FieldOffset(Offset = "0x38")]
		public List<string> teamBuffDescs;

		// Token: 0x04021DBF RID: 138687
		[Token(Token = "0x4021DBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
