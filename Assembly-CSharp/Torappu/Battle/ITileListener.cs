using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020023A4 RID: 9124
	[Token(Token = "0x20023A4")]
	public interface ITileListener
	{
		// Token: 0x0600E77C RID: 59260
		[Token(Token = "0x600E77C")]
		void OnLocatedCharacterUpdate(Character character);

		// Token: 0x0600E77D RID: 59261
		[Token(Token = "0x600E77D")]
		void OnEntityEnter(Entity entity);

		// Token: 0x0600E77E RID: 59262
		[Token(Token = "0x600E77E")]
		void OnEntityLeave(Entity entity);
	}
}
