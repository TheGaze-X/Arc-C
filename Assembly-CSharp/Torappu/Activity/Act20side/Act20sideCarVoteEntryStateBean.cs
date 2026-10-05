using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007666 RID: 30310
	[Token(Token = "0x2007666")]
	public class Act20sideCarVoteEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AA1D RID: 174621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA1D")]
		[Address(RVA = "0x2667F60", Offset = "0x2666B60", VA = "0x182667F60")]
		public Act20sideCarVoteEntryStateBean()
		{
		}

		// Token: 0x0403D673 RID: 251507
		[Token(Token = "0x403D673")]
		[FieldOffset(Offset = "0x10")]
		public Act20sideCarVoteEntryProperty carVoteEntryProperty;

		// Token: 0x0403D674 RID: 251508
		[Token(Token = "0x403D674")]
		[FieldOffset(Offset = "0x18")]
		public TrackPointViewProperty trackPointViewProperty;

		// Token: 0x0403D675 RID: 251509
		[Token(Token = "0x403D675")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
