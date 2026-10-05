using System;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200508A RID: 20618
	[Token(Token = "0x200508A")]
	public struct GetNameCardResponse : IStreamDeserialize
	{
		// Token: 0x0601E88E RID: 125070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E88E")]
		[Address(RVA = "0x184C8A0", Offset = "0x184B4A0", VA = "0x18184C8A0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04028E7D RID: 167549
		[Token(Token = "0x4028E7D")]
		[FieldOffset(Offset = "0x0")]
		public string cardJson;
	}
}
