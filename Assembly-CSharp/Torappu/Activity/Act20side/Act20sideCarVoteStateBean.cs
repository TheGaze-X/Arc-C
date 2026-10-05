using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007669 RID: 30313
	[Token(Token = "0x2007669")]
	public class Act20sideCarVoteStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AA32 RID: 174642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA32")]
		[Address(RVA = "0x266C2A0", Offset = "0x266AEA0", VA = "0x18266C2A0")]
		public Act20sideCarVoteStateBean()
		{
		}

		// Token: 0x0403D68B RID: 251531
		[Token(Token = "0x403D68B")]
		[FieldOffset(Offset = "0x10")]
		public Act20sideCarVoteProperty carVoteProperty;

		// Token: 0x0403D68C RID: 251532
		[Token(Token = "0x403D68C")]
		[FieldOffset(Offset = "0x18")]
		public ExhibitionVersus versus;

		// Token: 0x0403D68D RID: 251533
		[Token(Token = "0x403D68D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
