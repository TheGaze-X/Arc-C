using System;
using Il2CppDummyDll;
using Torappu.Scripts.UI.Squad;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DF0 RID: 15856
	[Token(Token = "0x2003DF0")]
	public class RuneSquadGroupViewModel : SquadGroupViewModel
	{
		// Token: 0x06018AA7 RID: 101031 RVA: 0x0009B2E0 File Offset: 0x000994E0
		[Token(Token = "0x6018AA7")]
		[Address(RVA = "0x111E190", Offset = "0x111CD90", VA = "0x18111E190")]
		public bool RestrictSquadMembers(ExternalRuneChecker runeChecker, SquadMaxNumInfo squadMaxNumInfo)
		{
			return default(bool);
		}

		// Token: 0x06018AA8 RID: 101032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AA8")]
		[Address(RVA = "0x111E570", Offset = "0x111D170", VA = "0x18111E570")]
		public RuneSquadGroupViewModel()
		{
		}

		// Token: 0x0401E3A9 RID: 123817
		[Token(Token = "0x401E3A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RestrictSquadMembers;

		// Token: 0x0401E3AA RID: 123818
		[Token(Token = "0x401E3AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
