using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Action.TNodeAction
{
	// Token: 0x020031FC RID: 12796
	[Token(Token = "0x20031FC")]
	[Serializable]
	public struct TNodePortIDPair
	{
		// Token: 0x060144AA RID: 83114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144AA")]
		[Address(RVA = "0xC97EA0", Offset = "0xC96AA0", VA = "0x180C97EA0")]
		public TNodePortIDPair(string targetID, string sourcePortName, string targetPortName)
		{
		}

		// Token: 0x060144AB RID: 83115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144AB")]
		[Address(RVA = "0xC97C30", Offset = "0xC96830", VA = "0x180C97C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04017EE1 RID: 98017
		[Token(Token = "0x4017EE1")]
		[FieldOffset(Offset = "0x0")]
		public string sourcePortName;

		// Token: 0x04017EE2 RID: 98018
		[Token(Token = "0x4017EE2")]
		[FieldOffset(Offset = "0x8")]
		public string targetPortName;

		// Token: 0x04017EE3 RID: 98019
		[Token(Token = "0x4017EE3")]
		[FieldOffset(Offset = "0x10")]
		public string targetID;
	}
}
