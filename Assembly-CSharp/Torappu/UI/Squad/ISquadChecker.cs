using System;
using Il2CppDummyDll;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E04 RID: 15876
	[Token(Token = "0x2003E04")]
	public interface ISquadChecker : IHotfixable
	{
		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x06018B3D RID: 101181
		[Token(Token = "0x17003ADD")]
		int id { [Token(Token = "0x6018B3D")] get; }

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x06018B3E RID: 101182
		[Token(Token = "0x17003ADE")]
		EvolvePhaseAndLevel maxEvolvePhaseAndLevel { [Token(Token = "0x6018B3E")] get; }

		// Token: 0x06018B3F RID: 101183
		[Token(Token = "0x6018B3F")]
		bool CheckIfContainedInCurSquad(string charId);

		// Token: 0x06018B40 RID: 101184
		[Token(Token = "0x6018B40")]
		bool TryGetMutuallyExclusiveCharInfoInCurSquad(string charId, out string exclusiveInfo, bool ignoreSame = false);
	}
}
