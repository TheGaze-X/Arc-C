using System;
using Il2CppDummyDll;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	[Serializable]
	public class MessageEventArgs
	{
		// Token: 0x06000D44 RID: 3396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MessageEventArgs()
		{
		}

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x10")]
		public int playerId;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x18")]
		public byte[] data;
	}
}
