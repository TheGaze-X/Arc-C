using System;
using System.Text;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using XLua;

namespace Torappu.DataStream
{
	// Token: 0x020016BD RID: 5821
	[Token(Token = "0x20016BD")]
	public class ByteArray : IReusable, IStreamReader, IHotfixable, IStreamWriter
	{
		// Token: 0x06009335 RID: 37685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009335")]
		[Address(RVA = "0x2B2C990", Offset = "0x2B2B590", VA = "0x182B2C990")]
		public ByteArray(int capacity)
		{
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009336")]
		[Address(RVA = "0x2B2C850", Offset = "0x2B2B450", VA = "0x182B2C850")]
		private ByteArray(int capacity, bool littleEndian)
		{
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009337")]
		[Address(RVA = "0x2B285B0", Offset = "0x2B271B0", VA = "0x182B285B0")]
		public void Clear()
		{
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009338")]
		[Address(RVA = "0x2B2A1D0", Offset = "0x2B28DD0", VA = "0x182B2A1D0")]
		public void RemoveFront(int len)
		{
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06009339 RID: 37689 RVA: 0x00039420 File Offset: 0x00037620
		// (set) Token: 0x0600933A RID: 37690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FAA")]
		private bool isLittleEndian
		{
			[Token(Token = "0x6009339")]
			[Address(RVA = "0x2B2CC70", Offset = "0x2B2B870", VA = "0x182B2CC70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600933A")]
			[Address(RVA = "0x2B2CE40", Offset = "0x2B2BA40", VA = "0x182B2CE40")]
			set
			{
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x0600933B RID: 37691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAB")]
		public byte[] bytes
		{
			[Token(Token = "0x600933B")]
			[Address(RVA = "0x2B2CB80", Offset = "0x2B2B780", VA = "0x182B2CB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x0600933C RID: 37692 RVA: 0x00039438 File Offset: 0x00037638
		// (set) Token: 0x0600933D RID: 37693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FAC")]
		public int position
		{
			[Token(Token = "0x600933C")]
			[Address(RVA = "0x2B2CCE0", Offset = "0x2B2B8E0", VA = "0x182B2CCE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600933D")]
			[Address(RVA = "0x2B2CEE0", Offset = "0x2B2BAE0", VA = "0x182B2CEE0")]
			set
			{
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600933E RID: 37694 RVA: 0x00039450 File Offset: 0x00037650
		// (set) Token: 0x0600933F RID: 37695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FAD")]
		public int size
		{
			[Token(Token = "0x600933E")]
			[Address(RVA = "0x2B2CDD0", Offset = "0x2B2B9D0", VA = "0x182B2CDD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600933F")]
			[Address(RVA = "0x2B2CF70", Offset = "0x2B2BB70", VA = "0x182B2CF70")]
			set
			{
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06009340 RID: 37696 RVA: 0x00039468 File Offset: 0x00037668
		[Token(Token = "0x17000FAE")]
		public int capacity
		{
			[Token(Token = "0x6009340")]
			[Address(RVA = "0x2B2CBF0", Offset = "0x2B2B7F0", VA = "0x182B2CBF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x00039480 File Offset: 0x00037680
		[Token(Token = "0x17000FAF")]
		public int residualCapacity
		{
			[Token(Token = "0x6009341")]
			[Address(RVA = "0x2B2CD50", Offset = "0x2B2B950", VA = "0x182B2CD50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06009342 RID: 37698 RVA: 0x00039498 File Offset: 0x00037698
		[Token(Token = "0x17000FB0")]
		public int bytesAvailable
		{
			[Token(Token = "0x6009342")]
			[Address(RVA = "0x2B2CB10", Offset = "0x2B2B710", VA = "0x182B2CB10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009343 RID: 37699 RVA: 0x000394B0 File Offset: 0x000376B0
		[Token(Token = "0x6009343")]
		[Address(RVA = "0x2B28750", Offset = "0x2B27350", VA = "0x182B28750", Slot = "6")]
		public bool ReadBool()
		{
			return default(bool);
		}

		// Token: 0x06009344 RID: 37700 RVA: 0x000394C8 File Offset: 0x000376C8
		[Token(Token = "0x6009344")]
		[Address(RVA = "0x2B294D0", Offset = "0x2B280D0", VA = "0x182B294D0", Slot = "7")]
		public sbyte ReadSByte()
		{
			return 0;
		}

		// Token: 0x06009345 RID: 37701 RVA: 0x000394E0 File Offset: 0x000376E0
		[Token(Token = "0x6009345")]
		[Address(RVA = "0x2B287D0", Offset = "0x2B273D0", VA = "0x182B287D0", Slot = "8")]
		public byte ReadByte()
		{
			return 0;
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x000394F8 File Offset: 0x000376F8
		[Token(Token = "0x6009346")]
		[Address(RVA = "0x2B28970", Offset = "0x2B27570", VA = "0x182B28970", Slot = "9")]
		public short ReadInt16()
		{
			return 0;
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x00039510 File Offset: 0x00037710
		[Token(Token = "0x6009347")]
		[Address(RVA = "0x2B29670", Offset = "0x2B28270", VA = "0x182B29670", Slot = "10")]
		public ushort ReadUint16()
		{
			return 0;
		}

		// Token: 0x06009348 RID: 37704 RVA: 0x00039528 File Offset: 0x00037728
		[Token(Token = "0x6009348")]
		[Address(RVA = "0x2B28B60", Offset = "0x2B27760", VA = "0x182B28B60", Slot = "11")]
		public int ReadInt32()
		{
			return 0;
		}

		// Token: 0x06009349 RID: 37705 RVA: 0x00039540 File Offset: 0x00037740
		[Token(Token = "0x6009349")]
		[Address(RVA = "0x2B29860", Offset = "0x2B28460", VA = "0x182B29860", Slot = "12")]
		public uint ReadUint32()
		{
			return 0U;
		}

		// Token: 0x0600934A RID: 37706 RVA: 0x00039558 File Offset: 0x00037758
		[Token(Token = "0x600934A")]
		[Address(RVA = "0x2B28EC0", Offset = "0x2B27AC0", VA = "0x182B28EC0", Slot = "13")]
		public long ReadInt64()
		{
			return 0L;
		}

		// Token: 0x0600934B RID: 37707 RVA: 0x00039570 File Offset: 0x00037770
		[Token(Token = "0x600934B")]
		[Address(RVA = "0x2B29BC0", Offset = "0x2B287C0", VA = "0x182B29BC0", Slot = "14")]
		public ulong ReadUint64()
		{
			return 0UL;
		}

		// Token: 0x0600934C RID: 37708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600934C")]
		[Address(RVA = "0x2B295E0", Offset = "0x2B281E0", VA = "0x182B295E0", Slot = "15")]
		public string ReadString()
		{
			return null;
		}

		// Token: 0x0600934D RID: 37709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600934D")]
		[Address(RVA = "0x2B29550", Offset = "0x2B28150", VA = "0x182B29550", Slot = "16")]
		public string ReadString2()
		{
			return null;
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600934E")]
		[Address(RVA = "0x2B2C6C0", Offset = "0x2B2B2C0", VA = "0x182B2C6C0")]
		public string _ReadString(int len)
		{
			return null;
		}

		// Token: 0x0600934F RID: 37711 RVA: 0x00039588 File Offset: 0x00037788
		[Token(Token = "0x600934F")]
		[Address(RVA = "0x2B28880", Offset = "0x2B27480", VA = "0x182B28880", Slot = "17")]
		public int ReadBytes(byte[] dest, int offset, int len)
		{
			return 0;
		}

		// Token: 0x06009350 RID: 37712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009350")]
		[Address(RVA = "0x2B2C550", Offset = "0x2B2B150", VA = "0x182B2C550")]
		private void _CheckAvaliable(int bytesToRead)
		{
		}

		// Token: 0x06009351 RID: 37713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009351")]
		[Address(RVA = "0x2B2A2A0", Offset = "0x2B28EA0", VA = "0x182B2A2A0", Slot = "18")]
		public void WriteBool(bool v)
		{
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009352")]
		[Address(RVA = "0x2B2B2F0", Offset = "0x2B29EF0", VA = "0x182B2B2F0", Slot = "19")]
		public void WriteSByte(sbyte v)
		{
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009353")]
		[Address(RVA = "0x2B2A340", Offset = "0x2B28F40", VA = "0x182B2A340", Slot = "20")]
		public void WriteByte(byte v)
		{
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009354")]
		[Address(RVA = "0x2B2A770", Offset = "0x2B29370", VA = "0x182B2A770", Slot = "21")]
		public void WriteInt16(short v)
		{
		}

		// Token: 0x06009355 RID: 37717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009355")]
		[Address(RVA = "0x2B2B7C0", Offset = "0x2B2A3C0", VA = "0x182B2B7C0", Slot = "22")]
		public void WriteUint16(ushort v)
		{
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009356")]
		[Address(RVA = "0x2B2A9B0", Offset = "0x2B295B0", VA = "0x182B2A9B0", Slot = "23")]
		public void WriteInt32(int v)
		{
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009357")]
		[Address(RVA = "0x2B2BA00", Offset = "0x2B2A600", VA = "0x182B2BA00", Slot = "24")]
		public void WriteUint32(uint v)
		{
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009358")]
		[Address(RVA = "0x2B2AD20", Offset = "0x2B29920", VA = "0x182B2AD20", Slot = "25")]
		public void WriteInt64(long v)
		{
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009359")]
		[Address(RVA = "0x2B2BD70", Offset = "0x2B2A970", VA = "0x182B2BD70", Slot = "26")]
		public void WriteUint64(ulong v)
		{
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x000395A0 File Offset: 0x000377A0
		[Token(Token = "0x600935A")]
		[Address(RVA = "0x2B2A640", Offset = "0x2B29240", VA = "0x182B2A640", Slot = "27")]
		public int WriteBytes(byte[] src, int offset, int len)
		{
			return 0;
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600935B")]
		[Address(RVA = "0x2B2B5A0", Offset = "0x2B2A1A0", VA = "0x182B2B5A0", Slot = "28")]
		public void WriteString(string v)
		{
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600935C")]
		[Address(RVA = "0x2B2B380", Offset = "0x2B29F80", VA = "0x182B2B380", Slot = "29")]
		public void WriteString2(string v)
		{
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x000395B8 File Offset: 0x000377B8
		[Token(Token = "0x600935D")]
		[Address(RVA = "0x2B2A440", Offset = "0x2B29040", VA = "0x182B2A440")]
		public int WriteBytes(ByteArray src, int offset, int len)
		{
			return 0;
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600935E")]
		[Address(RVA = "0x2B2C340", Offset = "0x2B2AF40", VA = "0x182B2C340")]
		private void _AdjustCapacity(int size)
		{
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x000395D0 File Offset: 0x000377D0
		[Token(Token = "0x600935F")]
		[Address(RVA = "0x2B2C450", Offset = "0x2B2B050", VA = "0x182B2C450")]
		private int _CalculateInitialOffset(int cntOfByte)
		{
			return 0;
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x000395E8 File Offset: 0x000377E8
		[Token(Token = "0x6009360")]
		[Address(RVA = "0x2B2C630", Offset = "0x2B2B230", VA = "0x182B2C630")]
		private int _Offset(ref int offset)
		{
			return 0;
		}

		// Token: 0x06009361 RID: 37729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009361")]
		[Address(RVA = "0x2B28620", Offset = "0x2B27220", VA = "0x182B28620", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x06009362 RID: 37730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009362")]
		[Address(RVA = "0x2B28690", Offset = "0x2B27290", VA = "0x182B28690", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x040088ED RID: 35053
		[Token(Token = "0x40088ED")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding ENCODING;

		// Token: 0x040088EE RID: 35054
		[Token(Token = "0x40088EE")]
		[FieldOffset(Offset = "0x10")]
		private int m_inc;

		// Token: 0x040088EF RID: 35055
		[Token(Token = "0x40088EF")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_buffer;

		// Token: 0x040088F0 RID: 35056
		[Token(Token = "0x40088F0")]
		[FieldOffset(Offset = "0x20")]
		private int m_pos;

		// Token: 0x040088F1 RID: 35057
		[Token(Token = "0x40088F1")]
		[FieldOffset(Offset = "0x24")]
		private int m_size;

		// Token: 0x040088F2 RID: 35058
		[Token(Token = "0x40088F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040088F3 RID: 35059
		[Token(Token = "0x40088F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x040088F4 RID: 35060
		[Token(Token = "0x40088F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x040088F5 RID: 35061
		[Token(Token = "0x40088F5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RemoveFront;

		// Token: 0x040088F6 RID: 35062
		[Token(Token = "0x40088F6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isLittleEndian;

		// Token: 0x040088F7 RID: 35063
		[Token(Token = "0x40088F7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isLittleEndian;

		// Token: 0x040088F8 RID: 35064
		[Token(Token = "0x40088F8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_bytes;

		// Token: 0x040088F9 RID: 35065
		[Token(Token = "0x40088F9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x040088FA RID: 35066
		[Token(Token = "0x40088FA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_position;

		// Token: 0x040088FB RID: 35067
		[Token(Token = "0x40088FB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_size;

		// Token: 0x040088FC RID: 35068
		[Token(Token = "0x40088FC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_size;

		// Token: 0x040088FD RID: 35069
		[Token(Token = "0x40088FD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_capacity;

		// Token: 0x040088FE RID: 35070
		[Token(Token = "0x40088FE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_residualCapacity;

		// Token: 0x040088FF RID: 35071
		[Token(Token = "0x40088FF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_bytesAvailable;

		// Token: 0x04008900 RID: 35072
		[Token(Token = "0x4008900")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ReadBool;

		// Token: 0x04008901 RID: 35073
		[Token(Token = "0x4008901")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ReadSByte;

		// Token: 0x04008902 RID: 35074
		[Token(Token = "0x4008902")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ReadByte;

		// Token: 0x04008903 RID: 35075
		[Token(Token = "0x4008903")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ReadInt16;

		// Token: 0x04008904 RID: 35076
		[Token(Token = "0x4008904")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ReadUint16;

		// Token: 0x04008905 RID: 35077
		[Token(Token = "0x4008905")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ReadInt32;

		// Token: 0x04008906 RID: 35078
		[Token(Token = "0x4008906")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ReadUint32;

		// Token: 0x04008907 RID: 35079
		[Token(Token = "0x4008907")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ReadInt64;

		// Token: 0x04008908 RID: 35080
		[Token(Token = "0x4008908")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ReadUint64;

		// Token: 0x04008909 RID: 35081
		[Token(Token = "0x4008909")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ReadString;

		// Token: 0x0400890A RID: 35082
		[Token(Token = "0x400890A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ReadString2;

		// Token: 0x0400890B RID: 35083
		[Token(Token = "0x400890B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ReadString;

		// Token: 0x0400890C RID: 35084
		[Token(Token = "0x400890C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ReadBytes;

		// Token: 0x0400890D RID: 35085
		[Token(Token = "0x400890D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckAvaliable;

		// Token: 0x0400890E RID: 35086
		[Token(Token = "0x400890E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_WriteBool;

		// Token: 0x0400890F RID: 35087
		[Token(Token = "0x400890F")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_WriteSByte;

		// Token: 0x04008910 RID: 35088
		[Token(Token = "0x4008910")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_WriteByte;

		// Token: 0x04008911 RID: 35089
		[Token(Token = "0x4008911")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_WriteInt16;

		// Token: 0x04008912 RID: 35090
		[Token(Token = "0x4008912")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_WriteUint16;

		// Token: 0x04008913 RID: 35091
		[Token(Token = "0x4008913")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_WriteInt32;

		// Token: 0x04008914 RID: 35092
		[Token(Token = "0x4008914")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_WriteUint32;

		// Token: 0x04008915 RID: 35093
		[Token(Token = "0x4008915")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_WriteInt64;

		// Token: 0x04008916 RID: 35094
		[Token(Token = "0x4008916")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_WriteUint64;

		// Token: 0x04008917 RID: 35095
		[Token(Token = "0x4008917")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_WriteBytes;

		// Token: 0x04008918 RID: 35096
		[Token(Token = "0x4008918")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_WriteString;

		// Token: 0x04008919 RID: 35097
		[Token(Token = "0x4008919")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_WriteString2;

		// Token: 0x0400891A RID: 35098
		[Token(Token = "0x400891A")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix1_WriteBytes;

		// Token: 0x0400891B RID: 35099
		[Token(Token = "0x400891B")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__AdjustCapacity;

		// Token: 0x0400891C RID: 35100
		[Token(Token = "0x400891C")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__CalculateInitialOffset;

		// Token: 0x0400891D RID: 35101
		[Token(Token = "0x400891D")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__Offset;

		// Token: 0x0400891E RID: 35102
		[Token(Token = "0x400891E")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0400891F RID: 35103
		[Token(Token = "0x400891F")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnRecycle;
	}
}
