using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002229 RID: 8745
	[Token(Token = "0x2002229")]
	public interface IExcludeTarget
	{
		// Token: 0x0600DC08 RID: 56328
		[Token(Token = "0x600DC08")]
		void AddExcludeTarget(Entity target);

		// Token: 0x0600DC09 RID: 56329
		[Token(Token = "0x600DC09")]
		void ClearExcludeTarget();
	}
}
