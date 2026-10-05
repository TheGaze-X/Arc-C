using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EE6 RID: 24294
	[Token(Token = "0x2005EE6")]
	public class CharacterInfoSubProfessionDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023322 RID: 144162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023322")]
		[Address(RVA = "0x1DB2740", Offset = "0x1DB1340", VA = "0x181DB2740")]
		public CharacterInfoSubProfessionDetailStateBean()
		{
		}

		// Token: 0x040307F8 RID: 198648
		[Token(Token = "0x40307F8")]
		[FieldOffset(Offset = "0x10")]
		public CharacterProfileViewModel viewModel;

		// Token: 0x040307F9 RID: 198649
		[Token(Token = "0x40307F9")]
		[FieldOffset(Offset = "0x18")]
		public int instId;

		// Token: 0x040307FA RID: 198650
		[Token(Token = "0x40307FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
