using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BDA RID: 15322
	[Token(Token = "0x2003BDA")]
	public class UniEquipArchiveCharacterStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06017FA0 RID: 98208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA0")]
		[Address(RVA = "0x1060D60", Offset = "0x105F960", VA = "0x181060D60")]
		public UniEquipArchiveCharacterStateBean()
		{
		}

		// Token: 0x0401D071 RID: 118897
		[Token(Token = "0x401D071")]
		[FieldOffset(Offset = "0x10")]
		public UniEquipArchiveCharacterProperty prop;

		// Token: 0x0401D072 RID: 118898
		[Token(Token = "0x401D072")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
