using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BFA RID: 15354
	[Token(Token = "0x2003BFA")]
	public class UniEquipArchiveCharacterItemViewModel
	{
		// Token: 0x06018039 RID: 98361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018039")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipArchiveCharacterItemViewModel()
		{
		}

		// Token: 0x0401D1C2 RID: 119234
		[Token(Token = "0x401D1C2")]
		[FieldOffset(Offset = "0x10")]
		public CharacterCardViewModel charCard;

		// Token: 0x0401D1C3 RID: 119235
		[Token(Token = "0x401D1C3")]
		[FieldOffset(Offset = "0x18")]
		public TrackPointViewProperty trackProp;

		// Token: 0x0401D1C4 RID: 119236
		[Token(Token = "0x401D1C4")]
		[FieldOffset(Offset = "0x20")]
		public bool haveUnlokcedEquipWithoutInitial;

		// Token: 0x0401D1C5 RID: 119237
		[Token(Token = "0x401D1C5")]
		[FieldOffset(Offset = "0x21")]
		public bool showStarMark;

		// Token: 0x0401D1C6 RID: 119238
		[Token(Token = "0x401D1C6")]
		[FieldOffset(Offset = "0x28")]
		public List<UniEquipArchiveEquipTypeViewModel> equips;
	}
}
