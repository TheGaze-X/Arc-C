using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A0F RID: 6671
	[Token(Token = "0x2001A0F")]
	public interface ILODListener
	{
		// Token: 0x0600A73B RID: 42811
		[Token(Token = "0x600A73B")]
		void OnLODStateChanged(LODState state);
	}
}
