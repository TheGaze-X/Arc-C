using System;
using System.IO;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataStream
{
	// Token: 0x020016C1 RID: 5825
	[Token(Token = "0x20016C1")]
	public class FileReader : IStreamReader, IHotfixable, IDisposable
	{
		// Token: 0x0600937A RID: 37754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937A")]
		[Address(RVA = "0x2B35260", Offset = "0x2B33E60", VA = "0x182B35260")]
		public FileReader(FileStream file)
		{
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600937B")]
		[Address(RVA = "0x2B34AB0", Offset = "0x2B336B0", VA = "0x182B34AB0", Slot = "16")]
		public void Dispose()
		{
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x00039600 File Offset: 0x00037800
		[Token(Token = "0x600937C")]
		[Address(RVA = "0x2B34B40", Offset = "0x2B33740", VA = "0x182B34B40", Slot = "4")]
		public bool ReadBool()
		{
			return default(bool);
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x00039618 File Offset: 0x00037818
		[Token(Token = "0x600937D")]
		[Address(RVA = "0x2B34EC0", Offset = "0x2B33AC0", VA = "0x182B34EC0", Slot = "5")]
		public sbyte ReadSByte()
		{
			return 0;
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x00039630 File Offset: 0x00037830
		[Token(Token = "0x600937E")]
		[Address(RVA = "0x2B34BD0", Offset = "0x2B337D0", VA = "0x182B34BD0", Slot = "6")]
		public byte ReadByte()
		{
			return 0;
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x00039648 File Offset: 0x00037848
		[Token(Token = "0x600937F")]
		[Address(RVA = "0x2B34C60", Offset = "0x2B33860", VA = "0x182B34C60", Slot = "15")]
		public int ReadBytes(byte[] dest, int offset, int len)
		{
			return 0;
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x00039660 File Offset: 0x00037860
		[Token(Token = "0x6009380")]
		[Address(RVA = "0x2B34D10", Offset = "0x2B33910", VA = "0x182B34D10", Slot = "7")]
		public short ReadInt16()
		{
			return 0;
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x00039678 File Offset: 0x00037878
		[Token(Token = "0x6009381")]
		[Address(RVA = "0x2B34DA0", Offset = "0x2B339A0", VA = "0x182B34DA0", Slot = "9")]
		public int ReadInt32()
		{
			return 0;
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x00039690 File Offset: 0x00037890
		[Token(Token = "0x6009382")]
		[Address(RVA = "0x2B34E30", Offset = "0x2B33A30", VA = "0x182B34E30", Slot = "11")]
		public long ReadInt64()
		{
			return 0L;
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009383")]
		[Address(RVA = "0x2B35020", Offset = "0x2B33C20", VA = "0x182B35020", Slot = "13")]
		public string ReadString()
		{
			return null;
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009384")]
		[Address(RVA = "0x2B34F90", Offset = "0x2B33B90", VA = "0x182B34F90", Slot = "14")]
		public string ReadString2()
		{
			return null;
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x000396A8 File Offset: 0x000378A8
		[Token(Token = "0x6009385")]
		[Address(RVA = "0x2B350B0", Offset = "0x2B33CB0", VA = "0x182B350B0", Slot = "8")]
		public ushort ReadUint16()
		{
			return 0;
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x000396C0 File Offset: 0x000378C0
		[Token(Token = "0x6009386")]
		[Address(RVA = "0x2B35140", Offset = "0x2B33D40", VA = "0x182B35140", Slot = "10")]
		public uint ReadUint32()
		{
			return 0U;
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x000396D8 File Offset: 0x000378D8
		[Token(Token = "0x6009387")]
		[Address(RVA = "0x2B351D0", Offset = "0x2B33DD0", VA = "0x182B351D0", Slot = "12")]
		public ulong ReadUint64()
		{
			return 0UL;
		}

		// Token: 0x04008934 RID: 35124
		[Token(Token = "0x4008934")]
		[FieldOffset(Offset = "0x10")]
		private readonly BinaryReader m_reader;

		// Token: 0x04008935 RID: 35125
		[Token(Token = "0x4008935")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008936 RID: 35126
		[Token(Token = "0x4008936")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04008937 RID: 35127
		[Token(Token = "0x4008937")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReadBool;

		// Token: 0x04008938 RID: 35128
		[Token(Token = "0x4008938")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReadSByte;

		// Token: 0x04008939 RID: 35129
		[Token(Token = "0x4008939")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReadByte;

		// Token: 0x0400893A RID: 35130
		[Token(Token = "0x400893A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReadBytes;

		// Token: 0x0400893B RID: 35131
		[Token(Token = "0x400893B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReadInt16;

		// Token: 0x0400893C RID: 35132
		[Token(Token = "0x400893C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReadInt32;

		// Token: 0x0400893D RID: 35133
		[Token(Token = "0x400893D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ReadInt64;

		// Token: 0x0400893E RID: 35134
		[Token(Token = "0x400893E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ReadString;

		// Token: 0x0400893F RID: 35135
		[Token(Token = "0x400893F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ReadString2;

		// Token: 0x04008940 RID: 35136
		[Token(Token = "0x4008940")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ReadUint16;

		// Token: 0x04008941 RID: 35137
		[Token(Token = "0x4008941")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ReadUint32;

		// Token: 0x04008942 RID: 35138
		[Token(Token = "0x4008942")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ReadUint64;
	}
}
