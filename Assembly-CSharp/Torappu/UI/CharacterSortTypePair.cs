using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200354E RID: 13646
	[Token(Token = "0x200354E")]
	public struct CharacterSortTypePair
	{
		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x06015BF0 RID: 89072 RVA: 0x0008DAB0 File Offset: 0x0008BCB0
		[Token(Token = "0x170033A6")]
		public bool isEmpty
		{
			[Token(Token = "0x6015BF0")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0401A237 RID: 107063
		[Token(Token = "0x401A237")]
		[FieldOffset(Offset = "0x0")]
		public string sortTitle;

		// Token: 0x0401A238 RID: 107064
		[Token(Token = "0x401A238")]
		[FieldOffset(Offset = "0x8")]
		public CharacterSortType sortUpType;

		// Token: 0x0401A239 RID: 107065
		[Token(Token = "0x401A239")]
		[FieldOffset(Offset = "0xC")]
		public CharacterSortType sortDownType;
	}
}
