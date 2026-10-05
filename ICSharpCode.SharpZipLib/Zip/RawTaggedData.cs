using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public class RawTaggedData : ITaggedData
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x485B2B0", Offset = "0x4859EB0", VA = "0x18485B2B0")]
		public RawTaggedData(short tag)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00003B58 File Offset: 0x00001D58
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		public short TagID
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x4889950", Offset = "0x4888550", VA = "0x184889950", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x4A5EB20", Offset = "0x4A5D720", VA = "0x184A5EB20")]
			set
			{
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x4A5EA30", Offset = "0x4A5D630", VA = "0x184A5EA30", Slot = "5")]
		public void SetData(byte[] data, int offset, int count)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
		public byte[] GetData()
		{
			return null;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		public byte[] Data
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x10")]
		private short _tag;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _data;
	}
}
