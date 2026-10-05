using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041B3 RID: 16819
	[Token(Token = "0x20041B3")]
	public class SandboxV2DungeonReadArchiveStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x06019F01 RID: 106241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DC3")]
		public SandboxV2DungeonReadArchiveProp readArchiveProp
		{
			[Token(Token = "0x6019F01")]
			[Address(RVA = "0x12E1A40", Offset = "0x12E0640", VA = "0x1812E1A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019F02 RID: 106242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F02")]
		[Address(RVA = "0x12E1950", Offset = "0x12E0550", VA = "0x1812E1950")]
		public SandboxV2DungeonReadArchiveStateBean()
		{
		}

		// Token: 0x04020A7F RID: 133759
		[Token(Token = "0x4020A7F")]
		[FieldOffset(Offset = "0x10")]
		private SandboxV2DungeonReadArchiveProp m_readArchiveProp;

		// Token: 0x04020A80 RID: 133760
		[Token(Token = "0x4020A80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_readArchiveProp;

		// Token: 0x04020A81 RID: 133761
		[Token(Token = "0x4020A81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
