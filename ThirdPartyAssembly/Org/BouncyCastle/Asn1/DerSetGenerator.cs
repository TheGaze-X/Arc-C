using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	public class DerSetGenerator : DerGenerator
	{
		// Token: 0x060020C7 RID: 8391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x5336650", Offset = "0x5335250", VA = "0x185336650")]
		public DerSetGenerator(Stream outStream)
		{
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x53365A0", Offset = "0x53351A0", VA = "0x1853365A0")]
		public DerSetGenerator(Stream outStream, int tagNo, bool isExplicit)
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x53364A0", Offset = "0x53350A0", VA = "0x1853364A0", Slot = "4")]
		public override void AddObject(Asn1Encodable obj)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
		public override Stream GetRawOutputStream()
		{
			return null;
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x5336540", Offset = "0x5335140", VA = "0x185336540", Slot = "6")]
		public override void Close()
		{
		}

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x20")]
		private readonly MemoryStream _bOut;
	}
}
