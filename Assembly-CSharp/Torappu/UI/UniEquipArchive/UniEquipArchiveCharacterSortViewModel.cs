using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BFB RID: 15355
	[Token(Token = "0x2003BFB")]
	public class UniEquipArchiveCharacterSortViewModel : IHotfixable
	{
		// Token: 0x0601803A RID: 98362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601803A")]
		[Address(RVA = "0x1077B10", Offset = "0x1076710", VA = "0x181077B10")]
		public UniEquipArchiveCharacterSortViewModel()
		{
		}

		// Token: 0x0401D1C7 RID: 119239
		[Token(Token = "0x401D1C7")]
		[FieldOffset(Offset = "0x10")]
		public bool hasStarMark;

		// Token: 0x0401D1C8 RID: 119240
		[Token(Token = "0x401D1C8")]
		[FieldOffset(Offset = "0x14")]
		public CharacterSortType sortType;

		// Token: 0x0401D1C9 RID: 119241
		[Token(Token = "0x401D1C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
