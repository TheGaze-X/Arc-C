using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200262C RID: 9772
	[Token(Token = "0x200262C")]
	[Serializable]
	public struct DialogueActionCommand
	{
		// Token: 0x04011C2F RID: 72751
		[Token(Token = "0x4011C2F")]
		[FieldOffset(Offset = "0x0")]
		public string actionId;

		// Token: 0x04011C30 RID: 72752
		[Token(Token = "0x4011C30")]
		[FieldOffset(Offset = "0x8")]
		public ActionArray actionArray;

		// Token: 0x04011C31 RID: 72753
		[Token(Token = "0x4011C31")]
		[FieldOffset(Offset = "0x10")]
		public List<Blackboard.DataPair> blackboard;
	}
}
