using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	public abstract class TlsUtilities
	{
		// Token: 0x06001717 RID: 5911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x5277020", Offset = "0x5275C20", VA = "0x185277020")]
		public static void CheckUint8(int i)
		{
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001718")]
		[Address(RVA = "0x52770B0", Offset = "0x5275CB0", VA = "0x1852770B0")]
		public static void CheckUint8(long i)
		{
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001719")]
		[Address(RVA = "0x5276C60", Offset = "0x5275860", VA = "0x185276C60")]
		public static void CheckUint16(int i)
		{
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171A")]
		[Address(RVA = "0x5276CF0", Offset = "0x52758F0", VA = "0x185276CF0")]
		public static void CheckUint16(long i)
		{
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x5276E20", Offset = "0x5275A20", VA = "0x185276E20")]
		public static void CheckUint24(int i)
		{
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171C")]
		[Address(RVA = "0x5276D80", Offset = "0x5275980", VA = "0x185276D80")]
		public static void CheckUint24(long i)
		{
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171D")]
		[Address(RVA = "0x5276EB0", Offset = "0x5275AB0", VA = "0x185276EB0")]
		public static void CheckUint32(long i)
		{
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171E")]
		[Address(RVA = "0x5276F40", Offset = "0x5275B40", VA = "0x185276F40")]
		public static void CheckUint48(long i)
		{
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600171F")]
		[Address(RVA = "0x5276FE0", Offset = "0x5275BE0", VA = "0x185276FE0")]
		public static void CheckUint64(long i)
		{
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x6001720")]
		[Address(RVA = "0x527A930", Offset = "0x5279530", VA = "0x18527A930")]
		public static bool IsValidUint8(int i)
		{
			return default(bool);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x6001721")]
		[Address(RVA = "0x527A920", Offset = "0x5279520", VA = "0x18527A920")]
		public static bool IsValidUint8(long i)
		{
			return default(bool);
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x6001722")]
		[Address(RVA = "0x527A8B0", Offset = "0x52794B0", VA = "0x18527A8B0")]
		public static bool IsValidUint16(int i)
		{
			return default(bool);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x6001723")]
		[Address(RVA = "0x527A8C0", Offset = "0x52794C0", VA = "0x18527A8C0")]
		public static bool IsValidUint16(long i)
		{
			return default(bool);
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x527A8E0", Offset = "0x52794E0", VA = "0x18527A8E0")]
		public static bool IsValidUint24(int i)
		{
			return default(bool);
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x527A8D0", Offset = "0x52794D0", VA = "0x18527A8D0")]
		public static bool IsValidUint24(long i)
		{
			return default(bool);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x527A8F0", Offset = "0x52794F0", VA = "0x18527A8F0")]
		public static bool IsValidUint32(long i)
		{
			return default(bool);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x6001727")]
		[Address(RVA = "0x527A900", Offset = "0x5279500", VA = "0x18527A900")]
		public static bool IsValidUint48(long i)
		{
			return default(bool);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x6001728")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		public static bool IsValidUint64(long i)
		{
			return default(bool);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x527A330", Offset = "0x5278F30", VA = "0x18527A330")]
		public static bool IsSsl(TlsContext context)
		{
			return default(bool);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600172A")]
		[Address(RVA = "0x527A3E0", Offset = "0x5278FE0", VA = "0x18527A3E0")]
		public static bool IsTlsV11(ProtocolVersion version)
		{
			return default(bool);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x527A470", Offset = "0x5279070", VA = "0x18527A470")]
		public static bool IsTlsV11(TlsContext context)
		{
			return default(bool);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x600172C")]
		[Address(RVA = "0x527A650", Offset = "0x5279250", VA = "0x18527A650")]
		public static bool IsTlsV12(ProtocolVersion version)
		{
			return default(bool);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x527A560", Offset = "0x5279160", VA = "0x18527A560")]
		public static bool IsTlsV12(TlsContext context)
		{
			return default(bool);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x527E1B0", Offset = "0x527CDB0", VA = "0x18527E1B0")]
		public static void WriteUint8(byte i, Stream output)
		{
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x527E200", Offset = "0x527CE00", VA = "0x18527E200")]
		public static void WriteUint8(byte i, byte[] buf, int offset)
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x527D760", Offset = "0x527C360", VA = "0x18527D760")]
		public static void WriteUint16(int i, Stream output)
		{
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x527D7E0", Offset = "0x527C3E0", VA = "0x18527D7E0")]
		public static void WriteUint16(int i, byte[] buf, int offset)
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x527D820", Offset = "0x527C420", VA = "0x18527D820")]
		public static void WriteUint24(int i, Stream output)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x527D8D0", Offset = "0x527C4D0", VA = "0x18527D8D0")]
		public static void WriteUint24(int i, byte[] buf, int offset)
		{
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x527D990", Offset = "0x527C590", VA = "0x18527D990")]
		public static void WriteUint32(long i, Stream output)
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x527D920", Offset = "0x527C520", VA = "0x18527D920")]
		public static void WriteUint32(long i, byte[] buf, int offset)
		{
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x527DA70", Offset = "0x527C670", VA = "0x18527DA70")]
		public static void WriteUint48(long i, Stream output)
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x527DBA0", Offset = "0x527C7A0", VA = "0x18527DBA0")]
		public static void WriteUint48(long i, byte[] buf, int offset)
		{
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x527DC40", Offset = "0x527C840", VA = "0x18527DC40")]
		public static void WriteUint64(long i, Stream output)
		{
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x527DDD0", Offset = "0x527C9D0", VA = "0x18527DDD0")]
		public static void WriteUint64(long i, byte[] buf, int offset)
		{
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x527D1F0", Offset = "0x527BDF0", VA = "0x18527D1F0")]
		public static void WriteOpaque8(byte[] buf, Stream output)
		{
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x527CFC0", Offset = "0x527BBC0", VA = "0x18527CFC0")]
		public static void WriteOpaque16(byte[] buf, Stream output)
		{
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x527D0C0", Offset = "0x527BCC0", VA = "0x18527D0C0")]
		public static void WriteOpaque24(byte[] buf, Stream output)
		{
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173D")]
		[Address(RVA = "0x527E140", Offset = "0x527CD40", VA = "0x18527E140")]
		public static void WriteUint8Array(byte[] uints, Stream output)
		{
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173E")]
		[Address(RVA = "0x527E090", Offset = "0x527CC90", VA = "0x18527E090")]
		public static void WriteUint8Array(byte[] uints, byte[] buf, int offset)
		{
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173F")]
		[Address(RVA = "0x527DEA0", Offset = "0x527CAA0", VA = "0x18527DEA0")]
		public static void WriteUint8ArrayWithUint8Length(byte[] uints, Stream output)
		{
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001740")]
		[Address(RVA = "0x527DF80", Offset = "0x527CB80", VA = "0x18527DF80")]
		public static void WriteUint8ArrayWithUint8Length(byte[] uints, byte[] buf, int offset)
		{
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001741")]
		[Address(RVA = "0x527D590", Offset = "0x527C190", VA = "0x18527D590")]
		public static void WriteUint16Array(int[] uints, Stream output)
		{
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001742")]
		[Address(RVA = "0x527D690", Offset = "0x527C290", VA = "0x18527D690")]
		public static void WriteUint16Array(int[] uints, byte[] buf, int offset)
		{
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001743")]
		[Address(RVA = "0x527D2C0", Offset = "0x527BEC0", VA = "0x18527D2C0")]
		public static void WriteUint16ArrayWithUint16Length(int[] uints, Stream output)
		{
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x527D450", Offset = "0x527C050", VA = "0x18527D450")]
		public static void WriteUint16ArrayWithUint16Length(int[] uints, byte[] buf, int offset)
		{
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x5277B00", Offset = "0x5276700", VA = "0x185277B00")]
		public static byte[] EncodeOpaque8(byte[] buf)
		{
			return null;
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x5278140", Offset = "0x5276D40", VA = "0x185278140")]
		public static byte[] EncodeUint8ArrayWithUint8Length(byte[] uints)
		{
			return null;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x5277FB0", Offset = "0x5276BB0", VA = "0x185277FB0")]
		public static byte[] EncodeUint16ArrayWithUint16Length(int[] uints)
		{
			return null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x527C2C0", Offset = "0x527AEC0", VA = "0x18527C2C0")]
		public static byte ReadUint8(Stream input)
		{
			return 0;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x527C350", Offset = "0x527AF50", VA = "0x18527C350")]
		public static byte ReadUint8(byte[] buf, int offset)
		{
			return 0;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x600174A")]
		[Address(RVA = "0x527BC60", Offset = "0x527A860", VA = "0x18527BC60")]
		public static int ReadUint16(Stream input)
		{
			return 0;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x600174B")]
		[Address(RVA = "0x527BC20", Offset = "0x527A820", VA = "0x18527BC20")]
		public static int ReadUint16(byte[] buf, int offset)
		{
			return 0;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x600174C")]
		[Address(RVA = "0x527BD20", Offset = "0x527A920", VA = "0x18527BD20")]
		public static int ReadUint24(Stream input)
		{
			return 0;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x527BE20", Offset = "0x527AA20", VA = "0x18527BE20")]
		public static int ReadUint24(byte[] buf, int offset)
		{
			return 0;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x527BE80", Offset = "0x527AA80", VA = "0x18527BE80")]
		public static long ReadUint32(Stream input)
		{
			return 0L;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x527BFC0", Offset = "0x527ABC0", VA = "0x18527BFC0")]
		public static long ReadUint32(byte[] buf, int offset)
		{
			return 0L;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x527C120", Offset = "0x527AD20", VA = "0x18527C120")]
		public static long ReadUint48(Stream input)
		{
			return 0L;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x6001751")]
		[Address(RVA = "0x527C030", Offset = "0x527AC30", VA = "0x18527C030")]
		public static long ReadUint48(byte[] buf, int offset)
		{
			return 0L;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001752")]
		[Address(RVA = "0x527B070", Offset = "0x5279C70", VA = "0x18527B070")]
		public static byte[] ReadAllOrNothing(int length, Stream input)
		{
			return null;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x527B610", Offset = "0x527A210", VA = "0x18527B610")]
		public static byte[] ReadFully(int length, Stream input)
		{
			return null;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001754")]
		[Address(RVA = "0x527B590", Offset = "0x527A190", VA = "0x18527B590")]
		public static void ReadFully(byte[] buf, Stream input)
		{
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x527B840", Offset = "0x527A440", VA = "0x18527B840")]
		public static byte[] ReadOpaque8(Stream input)
		{
			return null;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x527B700", Offset = "0x527A300", VA = "0x18527B700")]
		public static byte[] ReadOpaque16(Stream input)
		{
			return null;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x527B7E0", Offset = "0x527A3E0", VA = "0x18527B7E0")]
		public static byte[] ReadOpaque24(Stream input)
		{
			return null;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001758")]
		[Address(RVA = "0x527C190", Offset = "0x527AD90", VA = "0x18527C190")]
		public static byte[] ReadUint8Array(int count, Stream input)
		{
			return null;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x527BAB0", Offset = "0x527A6B0", VA = "0x18527BAB0")]
		public static int[] ReadUint16Array(int count, Stream input)
		{
			return null;
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x527C540", Offset = "0x527B140", VA = "0x18527C540")]
		public static ProtocolVersion ReadVersion(byte[] buf, int offset)
		{
			return null;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x527C440", Offset = "0x527B040", VA = "0x18527C440")]
		public static ProtocolVersion ReadVersion(Stream input)
		{
			return null;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x527BC20", Offset = "0x527A820", VA = "0x18527BC20")]
		public static int ReadVersionRaw(byte[] buf, int offset)
		{
			return 0;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x527C380", Offset = "0x527AF80", VA = "0x18527C380")]
		public static int ReadVersionRaw(Stream input)
		{
			return 0;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x527B180", Offset = "0x5279D80", VA = "0x18527B180")]
		public static Asn1Object ReadAsn1Object(byte[] encoding)
		{
			return null;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175F")]
		[Address(RVA = "0x527B330", Offset = "0x5279F30", VA = "0x18527B330")]
		public static Asn1Object ReadDerObject(byte[] encoding)
		{
			return null;
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x527CEF0", Offset = "0x527BAF0", VA = "0x18527CEF0")]
		public static void WriteGmtUnixTime(byte[] buf, int offset)
		{
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x527E2A0", Offset = "0x527CEA0", VA = "0x18527E2A0")]
		public static void WriteVersion(ProtocolVersion version, Stream output)
		{
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x527E230", Offset = "0x527CE30", VA = "0x18527E230")]
		public static void WriteVersion(ProtocolVersion version, byte[] buf, int offset)
		{
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x5278770", Offset = "0x5277370", VA = "0x185278770")]
		public static IList GetDefaultDssSignatureAlgorithms()
		{
			return null;
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x52787F0", Offset = "0x52773F0", VA = "0x1852787F0")]
		public static IList GetDefaultECDsaSignatureAlgorithms()
		{
			return null;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001765")]
		[Address(RVA = "0x5278870", Offset = "0x5277470", VA = "0x185278870")]
		public static IList GetDefaultRsaSignatureAlgorithms()
		{
			return null;
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001766")]
		[Address(RVA = "0x5278E50", Offset = "0x5277A50", VA = "0x185278E50")]
		public static byte[] GetExtensionData(IDictionary extensions, int extensionType)
		{
			return null;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x52788F0", Offset = "0x52774F0", VA = "0x1852788F0")]
		public static IList GetDefaultSupportedSignatureAlgorithms()
		{
			return null;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x5279BF0", Offset = "0x52787F0", VA = "0x185279BF0")]
		public static SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(TlsContext context, TlsSignerCredentials signerCredentials)
		{
			return null;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x527A0A0", Offset = "0x5278CA0", VA = "0x18527A0A0")]
		public static bool HasExpectedEmptyExtensionData(IDictionary extensions, int extensionType, byte alertDescription)
		{
			return default(bool);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x527A190", Offset = "0x5278D90", VA = "0x18527A190")]
		public static TlsSession ImportSession(byte[] sessionID, SessionParameters sessionParameters)
		{
			return null;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x527A2A0", Offset = "0x5278EA0", VA = "0x18527A2A0")]
		public static bool IsSignatureAlgorithmsExtensionAllowed(ProtocolVersion clientVersion)
		{
			return default(bool);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x52757D0", Offset = "0x52743D0", VA = "0x1852757D0")]
		public static void AddSignatureAlgorithmsExtension(IDictionary extensions, IList supportedSignatureAlgorithms)
		{
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x5279A30", Offset = "0x5278630", VA = "0x185279A30")]
		public static IList GetSignatureAlgorithmsExtension(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176E")]
		[Address(RVA = "0x5277910", Offset = "0x5276510", VA = "0x185277910")]
		public static byte[] CreateSignatureAlgorithmsExtension(IList supportedSignatureAlgorithms)
		{
			return null;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176F")]
		[Address(RVA = "0x527B990", Offset = "0x527A590", VA = "0x18527B990")]
		public static IList ReadSignatureAlgorithmsExtension(byte[] extensionData)
		{
			return null;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001770")]
		[Address(RVA = "0x5277B70", Offset = "0x5276770", VA = "0x185277B70")]
		public static void EncodeSupportedSignatureAlgorithms(IList supportedSignatureAlgorithms, bool allowAnonymous, Stream output)
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x527AEB0", Offset = "0x5279AB0", VA = "0x18527AEB0")]
		public static IList ParseSupportedSignatureAlgorithms(bool allowAnonymous, Stream input)
		{
			return null;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x527CAF0", Offset = "0x527B6F0", VA = "0x18527CAF0")]
		public static void VerifySupportedSignatureAlgorithm(IList supportedSignatureAlgorithms, SignatureAndHashAlgorithm signatureAlgorithm)
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x527AC00", Offset = "0x5279800", VA = "0x18527AC00")]
		public static byte[] PRF(TlsContext context, byte[] secret, string asciiLabel, byte[] seed, int size)
		{
			return null;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x527A940", Offset = "0x5279540", VA = "0x18527A940")]
		public static byte[] PRF_legacy(byte[] secret, string asciiLabel, byte[] seed, int size)
		{
			return null;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x527AA70", Offset = "0x5279670", VA = "0x18527AA70")]
		internal static byte[] PRF_legacy(byte[] secret, byte[] label, byte[] labelSeed, int size)
		{
			return null;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x5277500", Offset = "0x5276100", VA = "0x185277500")]
		internal static byte[] Concat(byte[] a, byte[] b)
		{
			return null;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x5279D50", Offset = "0x5278950", VA = "0x185279D50")]
		internal static void HMacHash(IDigest digest, byte[] secret, byte[] seed, byte[] output)
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001778")]
		[Address(RVA = "0x527C920", Offset = "0x527B520", VA = "0x18527C920")]
		internal static void ValidateKeyUsage(X509CertificateStructure c, int keyUsageBits)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x5275F70", Offset = "0x5274B70", VA = "0x185275F70")]
		internal static byte[] CalculateKeyBlock(TlsContext context, int size)
		{
			return null;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x5275930", Offset = "0x5274530", VA = "0x185275930")]
		internal static byte[] CalculateKeyBlock_Ssl(byte[] master_secret, byte[] random, int size)
		{
			return null;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x5276800", Offset = "0x5275400", VA = "0x185276800")]
		internal static byte[] CalculateMasterSecret(TlsContext context, byte[] pre_master_secret)
		{
			return null;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x52761D0", Offset = "0x5274DD0", VA = "0x1852761D0")]
		internal static byte[] CalculateMasterSecret_Ssl(byte[] pre_master_secret, byte[] random)
		{
			return null;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x5276AD0", Offset = "0x52756D0", VA = "0x185276AD0")]
		internal static byte[] CalculateVerifyData(TlsContext context, string asciiLabel, byte[] handshakeHash)
		{
			return null;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x52775B0", Offset = "0x52761B0", VA = "0x1852775B0")]
		public static IDigest CreateHash(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x52777C0", Offset = "0x52763C0", VA = "0x1852777C0")]
		public static IDigest CreateHash(SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x5277140", Offset = "0x5275D40", VA = "0x185277140")]
		public static IDigest CloneHash(byte hashAlgorithm, IDigest hash)
		{
			return null;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x5277880", Offset = "0x5276480", VA = "0x185277880")]
		public static IDigest CreatePrfHash(int prfAlgorithm)
		{
			return null;
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x52773E0", Offset = "0x5275FE0", VA = "0x1852773E0")]
		public static IDigest ClonePrfHash(int prfAlgorithm, IDigest hash)
		{
			return null;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x5278F00", Offset = "0x5277B00", VA = "0x185278F00")]
		public static byte GetHashAlgorithmForPrfAlgorithm(int prfAlgorithm)
		{
			return 0;
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x5279820", Offset = "0x5278420", VA = "0x185279820")]
		public static DerObjectIdentifier GetOidForHashAlgorithm(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x5278470", Offset = "0x5277070", VA = "0x185278470")]
		internal static short GetClientCertificateType(Certificate clientCertificate, Certificate serverCertificate)
		{
			return 0;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x527C5D0", Offset = "0x527B1D0", VA = "0x18527C5D0")]
		internal static void TrackHashAlgorithms(TlsHandshakeHash handshakeHash, IList supportedSignatureAlgorithms)
		{
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x527A170", Offset = "0x5278D70", VA = "0x18527A170")]
		public static bool HasSigningCapability(byte clientCertificateType)
		{
			return default(bool);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x52779C0", Offset = "0x52765C0", VA = "0x1852779C0")]
		public static TlsSigner CreateTlsSigner(byte clientCertificateType)
		{
			return null;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001789")]
		[Address(RVA = "0x5278280", Offset = "0x5276E80", VA = "0x185278280")]
		private static byte[][] GenSsl3Const()
		{
			return null;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178A")]
		[Address(RVA = "0x527CA60", Offset = "0x527B660", VA = "0x18527CA60")]
		private static IList VectorOfOne(object obj)
		{
			return null;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x5278370", Offset = "0x5276F70", VA = "0x185278370")]
		public static int GetCipherType(int ciphersuite)
		{
			return 0;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x5278AA0", Offset = "0x52776A0", VA = "0x185278AA0")]
		public static int GetEncryptionAlgorithm(int ciphersuite)
		{
			return 0;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x5279000", Offset = "0x5277C00", VA = "0x185279000")]
		public static int GetKeyExchangeAlgorithm(int ciphersuite)
		{
			return 0;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x5279400", Offset = "0x5278000", VA = "0x185279400")]
		public static int GetMacAlgorithm(int ciphersuite)
		{
			return 0;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x52796C0", Offset = "0x52782C0", VA = "0x1852796C0")]
		public static ProtocolVersion GetMinimumVersion(int ciphersuite)
		{
			return null;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x527A200", Offset = "0x5278E00", VA = "0x18527A200")]
		public static bool IsAeadCipherSuite(int ciphersuite)
		{
			return default(bool);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x527A250", Offset = "0x5278E50", VA = "0x18527A250")]
		public static bool IsBlockCipherSuite(int ciphersuite)
		{
			return default(bool);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x527A390", Offset = "0x5278F90", VA = "0x18527A390")]
		public static bool IsStreamCipherSuite(int ciphersuite)
		{
			return default(bool);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x6001793")]
		[Address(RVA = "0x527A6E0", Offset = "0x52792E0", VA = "0x18527A6E0")]
		public static bool IsValidCipherSuiteForVersion(int cipherSuite, ProtocolVersion serverVersion)
		{
			return default(bool);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TlsUtilities()
		{
		}

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0x0")]
		public static readonly byte[] EmptyBytes;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0x8")]
		public static readonly short[] EmptyShorts;

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int[] EmptyInts;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x18")]
		public static readonly long[] EmptyLongs;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly byte[] SSL_CLIENT;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly byte[] SSL_SERVER;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly byte[][] SSL3_CONST;
	}
}
