using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006028 RID: 24616
	[Token(Token = "0x2006028")]
	public class CarvingHomeEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602399C RID: 145820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602399C")]
		[Address(RVA = "0x1E44C40", Offset = "0x1E43840", VA = "0x181E44C40")]
		public CarvingHomeEntryStateBean()
		{
		}

		// Token: 0x04031495 RID: 201877
		[Token(Token = "0x4031495")]
		[FieldOffset(Offset = "0x10")]
		public CarvingHomeEntryProperty property;

		// Token: 0x04031496 RID: 201878
		[Token(Token = "0x4031496")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
