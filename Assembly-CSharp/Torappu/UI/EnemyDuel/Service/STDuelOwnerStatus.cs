using System;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005086 RID: 20614
	[Token(Token = "0x2005086")]
	public struct STDuelOwnerStatus : IStreamDeserialize
	{
		// Token: 0x0601E886 RID: 125062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E886")]
		[Address(RVA = "0x184D060", Offset = "0x184BC60", VA = "0x18184D060", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04028E65 RID: 167525
		[Token(Token = "0x4028E65")]
		[FieldOffset(Offset = "0x0")]
		public string uid;
	}
}
