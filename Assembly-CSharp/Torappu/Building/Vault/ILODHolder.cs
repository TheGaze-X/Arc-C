using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A0E RID: 6670
	[Token(Token = "0x2001A0E")]
	public interface ILODHolder
	{
		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x0600A738 RID: 42808
		[Token(Token = "0x1700134A")]
		LODState lodState { [Token(Token = "0x600A738")] get; }

		// Token: 0x0600A739 RID: 42809
		[Token(Token = "0x600A739")]
		void AddLODListener(ILODListener listener);

		// Token: 0x0600A73A RID: 42810
		[Token(Token = "0x600A73A")]
		void RemoveLODListener(ILODListener listener);
	}
}
