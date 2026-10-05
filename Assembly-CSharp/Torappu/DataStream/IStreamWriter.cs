using System;
using Il2CppDummyDll;

namespace Torappu.DataStream
{
	// Token: 0x020016C4 RID: 5828
	[Token(Token = "0x20016C4")]
	public interface IStreamWriter : IHotfixable
	{
		// Token: 0x060093A2 RID: 37794
		[Token(Token = "0x60093A2")]
		void WriteBool(bool v);

		// Token: 0x060093A3 RID: 37795
		[Token(Token = "0x60093A3")]
		void WriteSByte(sbyte v);

		// Token: 0x060093A4 RID: 37796
		[Token(Token = "0x60093A4")]
		void WriteByte(byte v);

		// Token: 0x060093A5 RID: 37797
		[Token(Token = "0x60093A5")]
		void WriteInt16(short v);

		// Token: 0x060093A6 RID: 37798
		[Token(Token = "0x60093A6")]
		void WriteUint16(ushort v);

		// Token: 0x060093A7 RID: 37799
		[Token(Token = "0x60093A7")]
		void WriteInt32(int v);

		// Token: 0x060093A8 RID: 37800
		[Token(Token = "0x60093A8")]
		void WriteUint32(uint v);

		// Token: 0x060093A9 RID: 37801
		[Token(Token = "0x60093A9")]
		void WriteInt64(long v);

		// Token: 0x060093AA RID: 37802
		[Token(Token = "0x60093AA")]
		void WriteUint64(ulong v);

		// Token: 0x060093AB RID: 37803
		[Token(Token = "0x60093AB")]
		int WriteBytes(byte[] src, int offset, int len);

		// Token: 0x060093AC RID: 37804
		[Token(Token = "0x60093AC")]
		void WriteString(string v);

		// Token: 0x060093AD RID: 37805
		[Token(Token = "0x60093AD")]
		void WriteString2(string v);
	}
}
