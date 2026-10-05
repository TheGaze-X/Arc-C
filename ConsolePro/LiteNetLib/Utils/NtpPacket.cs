using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public class NtpPacket
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public byte[] Bytes
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x17000038")]
		public NtpLeapIndicator LeapIndicator
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x36B1710", Offset = "0x36B0310", VA = "0x1836B1710")]
			get
			{
				return NtpLeapIndicator.NoWarning;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public int VersionNumber
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x36B1B20", Offset = "0x36B0720", VA = "0x1836B1B20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x36B1D30", Offset = "0x36B0930", VA = "0x1836B1D30")]
			private set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00002D30 File Offset: 0x00000F30
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public NtpMode Mode
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x36B1740", Offset = "0x36B0340", VA = "0x1836B1740")]
			get
			{
				return (NtpMode)0;
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x36B1B60", Offset = "0x36B0760", VA = "0x1836B1B60")]
			private set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x1700003B")]
		public int Stratum
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x36B1AC0", Offset = "0x36B06C0", VA = "0x1836B1AC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x1700003C")]
		public int Poll
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x36B17A0", Offset = "0x36B03A0", VA = "0x1836B17A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x1700003D")]
		public int Precision
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x36B17D0", Offset = "0x36B03D0", VA = "0x1836B17D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x1700003E")]
		public TimeSpan RootDelay
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x36B1870", Offset = "0x36B0470", VA = "0x1836B1870")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x1700003F")]
		public TimeSpan RootDispersion
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x36B18E0", Offset = "0x36B04E0", VA = "0x1836B18E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x17000040")]
		public uint ReferenceId
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x36B1830", Offset = "0x36B0430", VA = "0x1836B1830")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x17000041")]
		public DateTime? ReferenceTimestamp
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x36B1840", Offset = "0x36B0440", VA = "0x1836B1840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x17000042")]
		public DateTime? OriginTimestamp
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x36B1770", Offset = "0x36B0370", VA = "0x1836B1770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x17000043")]
		public DateTime? ReceiveTimestamp
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x36B1800", Offset = "0x36B0400", VA = "0x1836B1800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002E20 File Offset: 0x00001020
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public DateTime? TransmitTimestamp
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x36B1AF0", Offset = "0x36B06F0", VA = "0x1836B1AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x36B1BA0", Offset = "0x36B07A0", VA = "0x1836B1BA0")]
			private set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00002E38 File Offset: 0x00001038
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public DateTime? DestinationTimestamp
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x36B1B50", Offset = "0x36B0750", VA = "0x1836B1B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x17000046")]
		public TimeSpan RoundTripTime
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x36B1950", Offset = "0x36B0550", VA = "0x1836B1950")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x17000047")]
		public TimeSpan CorrectionOffset
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x36B1590", Offset = "0x36B0190", VA = "0x1836B1590")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x36B12A0", Offset = "0x36AFEA0", VA = "0x1836B12A0")]
		public NtpPacket()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x36B11F0", Offset = "0x36AFDF0", VA = "0x1836B11F0")]
		internal NtpPacket(byte[] bytes)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x36B06A0", Offset = "0x36AF2A0", VA = "0x1836B06A0")]
		public static NtpPacket FromServerResponse(byte[] bytes, DateTime destinationTimestamp)
		{
			return null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x36B1010", Offset = "0x36AFC10", VA = "0x1836B1010")]
		internal void ValidateRequest()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x36B0E10", Offset = "0x36AFA10", VA = "0x1836B0E10")]
		internal void ValidateReply()
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x36B04D0", Offset = "0x36AF0D0", VA = "0x1836B04D0")]
		private void CheckTimestamps()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x36B07C0", Offset = "0x36AF3C0", VA = "0x1836B07C0")]
		private DateTime? GetDateTime64(int offset)
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x36B0B50", Offset = "0x36AF750", VA = "0x1836B0B50")]
		private void SetDateTime64(int offset, DateTime? value)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x36B09A0", Offset = "0x36AF5A0", VA = "0x1836B09A0")]
		private TimeSpan GetTimeSpan32(int offset)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x36B0AC0", Offset = "0x36AF6C0", VA = "0x1836B0AC0")]
		private ulong GetUInt64BE(int offset)
		{
			return 0UL;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x36B0CE0", Offset = "0x36AF8E0", VA = "0x1836B0CE0")]
		private void SetUInt64BE(int offset, ulong value)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x36B0990", Offset = "0x36AF590", VA = "0x1836B0990")]
		private int GetInt32BE(int offset)
		{
			return 0;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x36B0A10", Offset = "0x36AF610", VA = "0x1836B0A10")]
		private uint GetUInt32BE(int offset)
		{
			return 0U;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x36B0E00", Offset = "0x36AFA00", VA = "0x1836B0E00")]
		private static uint SwapEndianness(uint x)
		{
			return 0U;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x36B0D60", Offset = "0x36AF960", VA = "0x1836B0D60")]
		private static ulong SwapEndianness(ulong x)
		{
			return 0UL;
		}

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime Epoch;
	}
}
