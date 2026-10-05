using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E05 RID: 24069
	[Token(Token = "0x2005E05")]
	public class CardGroupViewModel : CharacterCardGroupViewModel
	{
		// Token: 0x06022E29 RID: 142889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E29")]
		[Address(RVA = "0x1D60400", Offset = "0x1D5F000", VA = "0x181D60400")]
		public CharacterCardViewModel FindCardModelById(int charInstId)
		{
			return null;
		}

		// Token: 0x06022E2A RID: 142890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E2A")]
		[Address(RVA = "0x1D60480", Offset = "0x1D5F080", VA = "0x181D60480")]
		public CardGroupViewModel()
		{
		}

		// Token: 0x04030081 RID: 196737
		[Token(Token = "0x4030081")]
		[FieldOffset(Offset = "0x70")]
		public bool showSelectOrder;

		// Token: 0x04030082 RID: 196738
		[Token(Token = "0x4030082")]
		[FieldOffset(Offset = "0x78")]
		public string noCharText;

		// Token: 0x04030083 RID: 196739
		[Token(Token = "0x4030083")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<int, CharacterCardViewModel> instMap;
	}
}
