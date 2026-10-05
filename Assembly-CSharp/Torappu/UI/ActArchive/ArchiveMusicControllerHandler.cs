using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BAE RID: 27566
	[Token(Token = "0x2006BAE")]
	public abstract class ArchiveMusicControllerHandler : IHotfixable
	{
		// Token: 0x060275D6 RID: 161238
		[Token(Token = "0x60275D6")]
		public abstract void OnItemClick(string funcId);

		// Token: 0x060275D7 RID: 161239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275D7")]
		[Address(RVA = "0x2291A80", Offset = "0x2290680", VA = "0x182291A80")]
		protected ArchiveMusicControllerHandler()
		{
		}

		// Token: 0x04037C4F RID: 228431
		[Token(Token = "0x4037C4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
