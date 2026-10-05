using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BDC RID: 15324
	[Token(Token = "0x2003BDC")]
	public class UniEquipArchiveEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06017FAE RID: 98222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FAE")]
		[Address(RVA = "0x1062190", Offset = "0x1060D90", VA = "0x181062190")]
		public UniEquipArchiveEntryStateBean()
		{
		}

		// Token: 0x0401D086 RID: 118918
		[Token(Token = "0x401D086")]
		[FieldOffset(Offset = "0x10")]
		public UniEquipArchiveEntryProperty prop;

		// Token: 0x0401D087 RID: 118919
		[Token(Token = "0x401D087")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
