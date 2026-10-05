using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;

namespace Torappu.Battle
{
	// Token: 0x02002610 RID: 9744
	[Token(Token = "0x2002610")]
	public interface IUseEnemyTrace : IPtrObject
	{
		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x0600FDFA RID: 65018
		// (set) Token: 0x0600FDFB RID: 65019
		[Token(Token = "0x17002237")]
		BaseTraceTargetAbility enemyTraceEnemyAbility { [Token(Token = "0x600FDFA")] get; [Token(Token = "0x600FDFB")] set; }

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x0600FDFC RID: 65020
		[Token(Token = "0x17002238")]
		bool hasTargetInRange { [Token(Token = "0x600FDFC")] get; }

		// Token: 0x0600FDFD RID: 65021
		[Token(Token = "0x600FDFD")]
		void UpdateTargetInRange();
	}
}
