using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BD6 RID: 27606
	[Token(Token = "0x2006BD6")]
	public abstract class ArchivePicControllerHandler : IHotfixable
	{
		// Token: 0x060276CB RID: 161483
		[Token(Token = "0x60276CB")]
		public abstract void OnItemClick(string funcId);

		// Token: 0x060276CC RID: 161484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276CC")]
		[Address(RVA = "0x22993B0", Offset = "0x2297FB0", VA = "0x1822993B0")]
		protected ArchivePicControllerHandler()
		{
		}

		// Token: 0x04037DBA RID: 228794
		[Token(Token = "0x4037DBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
