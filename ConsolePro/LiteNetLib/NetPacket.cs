using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal sealed class NetPacket
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public PacketProperty Property
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x36A66C0", Offset = "0x36A52C0", VA = "0x1836A66C0")]
			get
			{
				return PacketProperty.Unreliable;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x36A6880", Offset = "0x36A5480", VA = "0x1836A6880")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public byte ConnectionNumber
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x36A6540", Offset = "0x36A5140", VA = "0x1836A6540")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x36A6780", Offset = "0x36A5380", VA = "0x1836A6780")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public ushort Sequence
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x36A66F0", Offset = "0x36A52F0", VA = "0x1836A66F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x36A68C0", Offset = "0x36A54C0", VA = "0x1836A68C0")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x17000016")]
		public bool IsFragmented
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x36A6690", Offset = "0x36A5290", VA = "0x1836A6690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x36A6000", Offset = "0x36A4C00", VA = "0x1836A6000")]
		public void MarkFragmented()
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public byte ChannelId
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x36A6510", Offset = "0x36A5110", VA = "0x1836A6510")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x36A6750", Offset = "0x36A5350", VA = "0x1836A6750")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public ushort FragmentId
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x36A6570", Offset = "0x36A5170", VA = "0x1836A6570")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x36A67C0", Offset = "0x36A53C0", VA = "0x1836A67C0")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public ushort FragmentPart
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x36A65D0", Offset = "0x36A51D0", VA = "0x1836A65D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x36A6800", Offset = "0x36A5400", VA = "0x1836A6800")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public ushort FragmentsTotal
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x36A6630", Offset = "0x36A5230", VA = "0x1836A6630")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x36A6840", Offset = "0x36A5440", VA = "0x1836A6840")]
			set
			{
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x36A64B0", Offset = "0x36A50B0", VA = "0x1836A64B0")]
		public NetPacket(int size)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x36A6390", Offset = "0x36A4F90", VA = "0x1836A6390")]
		public NetPacket(PacketProperty property, int size)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x36A5F00", Offset = "0x36A4B00", VA = "0x1836A5F00")]
		public static int GetHeaderSize(PacketProperty property)
		{
			return 0;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x36A5F70", Offset = "0x36A4B70", VA = "0x1836A5F70")]
		public int GetHeaderSize()
		{
			return 0;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x36A6030", Offset = "0x36A4C30", VA = "0x1836A6030")]
		public bool Verify()
		{
			return default(bool);
		}

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int LastProperty;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] HeaderSizes;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x10")]
		public byte[] RawData;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x18")]
		public int Size;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x20")]
		public object UserData;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x28")]
		public NetPacket Next;
	}
}
