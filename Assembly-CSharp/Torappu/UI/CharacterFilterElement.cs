using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003506 RID: 13574
	[Token(Token = "0x2003506")]
	[Serializable]
	public struct CharacterFilterElement
	{
		// Token: 0x06015A91 RID: 88721 RVA: 0x0008D4E0 File Offset: 0x0008B6E0
		[Token(Token = "0x6015A91")]
		[Address(RVA = "0xE35A80", Offset = "0xE34680", VA = "0x180E35A80")]
		public bool IsIncluded(CharacterCardViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06015A92 RID: 88722 RVA: 0x0008D4F8 File Offset: 0x0008B6F8
		[Token(Token = "0x6015A92")]
		[Address(RVA = "0xE35AB0", Offset = "0xE346B0", VA = "0x180E35AB0")]
		public bool IsIncluded(ProfessionCategory charProfession)
		{
			return default(bool);
		}

		// Token: 0x04019F84 RID: 106372
		[Token(Token = "0x4019F84")]
		[FieldOffset(Offset = "0x0")]
		public CharacterFilterIdent ident;

		// Token: 0x04019F85 RID: 106373
		[Token(Token = "0x4019F85")]
		[FieldOffset(Offset = "0x4")]
		public ProfessionCategory profession;
	}
}
