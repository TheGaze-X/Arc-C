using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public sealed class SafeSerializationEventArgs : System.EventArgs
	{
		// Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x4BA9910", Offset = "0x4BA8510", VA = "0x184BA9910")]
		internal SafeSerializationEventArgs(StreamingContext streamingContext)
		{
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000444")]
		internal System.Collections.Generic.IList<object> SerializedStates
		{
			[Token(Token = "0x6002032")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x10")]
		private StreamingContext m_streamingContext;

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x20")]
		private System.Collections.Generic.List<object> m_serializedStates;
	}
}
