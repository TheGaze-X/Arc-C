using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Action
{
	// Token: 0x02002C47 RID: 11335
	[Token(Token = "0x2002C47")]
	public interface IDamageOrHealSourceNode
	{
		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x0601323C RID: 78396
		[Token(Token = "0x17002A0D")]
		ActionPurposeMask purposeMask { [Token(Token = "0x601323C")] get; }

		// Token: 0x0601323D RID: 78397
		[Token(Token = "0x601323D")]
		void PreprocessForProjectile(Entity source);
	}
}
