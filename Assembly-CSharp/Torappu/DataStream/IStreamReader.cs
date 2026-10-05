using System;
using Il2CppDummyDll;

namespace Torappu.DataStream
{
	// Token: 0x020016C3 RID: 5827
	[Token(Token = "0x20016C3")]
	public interface IStreamReader : IHotfixable
	{
		// Token: 0x06009396 RID: 37782
		[Token(Token = "0x6009396")]
		bool ReadBool();

		// Token: 0x06009397 RID: 37783
		[Token(Token = "0x6009397")]
		sbyte ReadSByte();

		// Token: 0x06009398 RID: 37784
		[Token(Token = "0x6009398")]
		byte ReadByte();

		// Token: 0x06009399 RID: 37785
		[Token(Token = "0x6009399")]
		short ReadInt16();

		// Token: 0x0600939A RID: 37786
		[Token(Token = "0x600939A")]
		ushort ReadUint16();

		// Token: 0x0600939B RID: 37787
		[Token(Token = "0x600939B")]
		int ReadInt32();

		// Token: 0x0600939C RID: 37788
		[Token(Token = "0x600939C")]
		uint ReadUint32();

		// Token: 0x0600939D RID: 37789
		[Token(Token = "0x600939D")]
		long ReadInt64();

		// Token: 0x0600939E RID: 37790
		[Token(Token = "0x600939E")]
		ulong ReadUint64();

		// Token: 0x0600939F RID: 37791
		[Token(Token = "0x600939F")]
		string ReadString();

		// Token: 0x060093A0 RID: 37792
		[Token(Token = "0x60093A0")]
		string ReadString2();

		// Token: 0x060093A1 RID: 37793
		[Token(Token = "0x60093A1")]
		int ReadBytes(byte[] dest, int offset, int len);
	}
}
