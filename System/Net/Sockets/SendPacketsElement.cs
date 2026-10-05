using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	public class SendPacketsElement
	{
		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x10")]
		internal string m_FilePath;

		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		[FieldOffset(Offset = "0x18")]
		internal byte[] m_Buffer;

		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		[FieldOffset(Offset = "0x20")]
		internal int m_Offset;

		// Token: 0x0400103D RID: 4157
		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x24")]
		internal int m_Count;

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x28")]
		private bool m_endOfPacket;
	}
}
