using System;
using System.Net;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class NetDataReader
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700002C")]
		public byte[] RawData
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x1700002D")]
		public int RawDataSize
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x1700002E")]
		public int UserDataOffset
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x1700002F")]
		public int UserDataSize
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x369D9E0", Offset = "0x369C5E0", VA = "0x18369D9E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x17000030")]
		public bool IsNull
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x2824A30", Offset = "0x2823630", VA = "0x182824A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x17000031")]
		public int Position
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x17000032")]
		public bool EndOfData
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x369D9D0", Offset = "0x369C5D0", VA = "0x18369D9D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x17000033")]
		public int AvailableBytes
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x369D9C0", Offset = "0x369C5C0", VA = "0x18369D9C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3122D10", Offset = "0x3121910", VA = "0x183122D10")]
		public void SkipBytes(int count)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x369CD80", Offset = "0x369B980", VA = "0x18369CD80")]
		public void SetSource(NetDataWriter dataWriter)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x369CD30", Offset = "0x369B930", VA = "0x18369CD30")]
		public void SetSource(byte[] source)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x369CDD0", Offset = "0x369B9D0", VA = "0x18369CDD0")]
		public void SetSource(byte[] source, int offset)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x369CE20", Offset = "0x369BA20", VA = "0x18369CE20")]
		public void SetSource(byte[] source, int offset, int maxSize)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NetDataReader()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x369D860", Offset = "0x369C460", VA = "0x18369D860")]
		public NetDataReader(NetDataWriter writer)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x369D910", Offset = "0x369C510", VA = "0x18369D910")]
		public NetDataReader(byte[] source)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x369D960", Offset = "0x369C560", VA = "0x18369D960")]
		public NetDataReader(byte[] source, int offset)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x369D8B0", Offset = "0x369C4B0", VA = "0x18369D8B0")]
		public NetDataReader(byte[] source, int offset, int maxSize)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x369BC10", Offset = "0x369A810", VA = "0x18369BC10")]
		public IPEndPoint GetNetEndPoint()
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x369B560", Offset = "0x369A160", VA = "0x18369B560")]
		public byte GetByte()
		{
			return 0;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x369B560", Offset = "0x369A160", VA = "0x18369B560")]
		public sbyte GetSByte()
		{
			return 0;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x369B470", Offset = "0x369A070", VA = "0x18369B470")]
		public bool[] GetBoolArray()
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x369C670", Offset = "0x369B270", VA = "0x18369C670")]
		public ushort[] GetUShortArray()
		{
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x369BEB0", Offset = "0x369AAB0", VA = "0x18369BEB0")]
		public short[] GetShortArray()
		{
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x369BAE0", Offset = "0x369A6E0", VA = "0x18369BAE0")]
		public long[] GetLongArray()
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x369C540", Offset = "0x369B140", VA = "0x18369C540")]
		public ulong[] GetULongArray()
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x369B9B0", Offset = "0x369A5B0", VA = "0x18369B9B0")]
		public int[] GetIntArray()
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x369C410", Offset = "0x369B010", VA = "0x18369C410")]
		public uint[] GetUIntArray()
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x369B880", Offset = "0x369A480", VA = "0x18369B880")]
		public float[] GetFloatArray()
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x369B750", Offset = "0x369A350", VA = "0x18369B750")]
		public double[] GetDoubleArray()
		{
			return null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x369BFE0", Offset = "0x369ABE0", VA = "0x18369BFE0")]
		public string[] GetStringArray()
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x369C100", Offset = "0x369AD00", VA = "0x18369C100")]
		public string[] GetStringArray(int maxStringLength)
		{
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x369B520", Offset = "0x369A120", VA = "0x18369B520")]
		public bool GetBool()
		{
			return default(bool);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x369B6E0", Offset = "0x369A2E0", VA = "0x18369B6E0")]
		public char GetChar()
		{
			return '\0';
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x369C730", Offset = "0x369B330", VA = "0x18369C730")]
		public ushort GetUShort()
		{
			return 0;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x369BF70", Offset = "0x369AB70", VA = "0x18369BF70")]
		public short GetShort()
		{
			return 0;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x369BBA0", Offset = "0x369A7A0", VA = "0x18369BBA0")]
		public long GetLong()
		{
			return 0L;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x369C600", Offset = "0x369B200", VA = "0x18369C600")]
		public ulong GetULong()
		{
			return 0UL;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x369BA70", Offset = "0x369A670", VA = "0x18369BA70")]
		public int GetInt()
		{
			return 0;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x369C4D0", Offset = "0x369B0D0", VA = "0x18369C4D0")]
		public uint GetUInt()
		{
			return 0U;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x369B940", Offset = "0x369A540", VA = "0x18369B940")]
		public float GetFloat()
		{
			return 0f;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x369B810", Offset = "0x369A410", VA = "0x18369B810")]
		public double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x369C220", Offset = "0x369AE20", VA = "0x18369C220")]
		public string GetString(int maxLength)
		{
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x369C330", Offset = "0x369AF30", VA = "0x18369C330")]
		public string GetString()
		{
			return null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x369BCE0", Offset = "0x369A8E0", VA = "0x18369BCE0")]
		public ArraySegment<byte> GetRemainingBytesSegment()
		{
			return default(ArraySegment<byte>);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001CC")]
		public T Get<T>() where T : INetSerializable, new()
		{
			return null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x369BD60", Offset = "0x369A960", VA = "0x18369BD60")]
		public byte[] GetRemainingBytes()
		{
			return null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x369B660", Offset = "0x369A260", VA = "0x18369B660")]
		public void GetBytes(byte[] destination, int start, int count)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x369B6A0", Offset = "0x369A2A0", VA = "0x18369B6A0")]
		public void GetBytes(byte[] destination, int count)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x369BDF0", Offset = "0x369A9F0", VA = "0x18369BDF0")]
		public sbyte[] GetSBytesWithLength()
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x369B5A0", Offset = "0x369A1A0", VA = "0x18369B5A0")]
		public byte[] GetBytesWithLength()
		{
			return null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x369C7D0", Offset = "0x369B3D0", VA = "0x18369C7D0")]
		public byte PeekByte()
		{
			return 0;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x369C7D0", Offset = "0x369B3D0", VA = "0x18369C7D0")]
		public sbyte PeekSByte()
		{
			return 0;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x369C7A0", Offset = "0x369B3A0", VA = "0x18369C7A0")]
		public bool PeekBool()
		{
			return default(bool);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x369C800", Offset = "0x369B400", VA = "0x18369C800")]
		public char PeekChar()
		{
			return '\0';
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x369CCD0", Offset = "0x369B8D0", VA = "0x18369CCD0")]
		public ushort PeekUShort()
		{
			return 0;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x369C9E0", Offset = "0x369B5E0", VA = "0x18369C9E0")]
		public short PeekShort()
		{
			return 0;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x369C980", Offset = "0x369B580", VA = "0x18369C980")]
		public long PeekLong()
		{
			return 0L;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x369CC70", Offset = "0x369B870", VA = "0x18369CC70")]
		public ulong PeekULong()
		{
			return 0UL;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x369C920", Offset = "0x369B520", VA = "0x18369C920")]
		public int PeekInt()
		{
			return 0;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x369CC10", Offset = "0x369B810", VA = "0x18369CC10")]
		public uint PeekUInt()
		{
			return 0U;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x369C8C0", Offset = "0x369B4C0", VA = "0x18369C8C0")]
		public float PeekFloat()
		{
			return 0f;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x369C860", Offset = "0x369B460", VA = "0x18369C860")]
		public double PeekDouble()
		{
			return 0.0;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x369CA40", Offset = "0x369B640", VA = "0x18369CA40")]
		public string PeekString(int maxLength)
		{
			return null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x369CB40", Offset = "0x369B740", VA = "0x18369CB40")]
		public string PeekString()
		{
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x369CEC0", Offset = "0x369BAC0", VA = "0x18369CEC0")]
		public bool TryGetByte(out byte result)
		{
			return default(bool);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x369CEC0", Offset = "0x369BAC0", VA = "0x18369CEC0")]
		public bool TryGetSByte(out sbyte result)
		{
			return default(bool);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x369CE60", Offset = "0x369BA60", VA = "0x18369CE60")]
		public bool TryGetBool(out bool result)
		{
			return default(bool);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x369D080", Offset = "0x369BC80", VA = "0x18369D080")]
		public bool TryGetChar(out char result)
		{
			return default(bool);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x369D340", Offset = "0x369BF40", VA = "0x18369D340")]
		public bool TryGetShort(out short result)
		{
			return default(bool);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x369D7C0", Offset = "0x369C3C0", VA = "0x18369D7C0")]
		public bool TryGetUShort(out ushort result)
		{
			return default(bool);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x369D260", Offset = "0x369BE60", VA = "0x18369D260")]
		public bool TryGetInt(out int result)
		{
			return default(bool);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x369D680", Offset = "0x369C280", VA = "0x18369D680")]
		public bool TryGetUInt(out uint result)
		{
			return default(bool);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x369D2A0", Offset = "0x369BEA0", VA = "0x18369D2A0")]
		public bool TryGetLong(out long result)
		{
			return default(bool);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x369D720", Offset = "0x369C320", VA = "0x18369D720")]
		public bool TryGetULong(out ulong result)
		{
			return default(bool);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x369D1C0", Offset = "0x369BDC0", VA = "0x18369D1C0")]
		public bool TryGetFloat(out float result)
		{
			return default(bool);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x369D120", Offset = "0x369BD20", VA = "0x18369D120")]
		public bool TryGetDouble(out double result)
		{
			return default(bool);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x369D5B0", Offset = "0x369C1B0", VA = "0x18369D5B0")]
		public bool TryGetString(out string result)
		{
			return default(bool);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x369D3E0", Offset = "0x369BFE0", VA = "0x18369D3E0")]
		public bool TryGetStringArray(out string[] result)
		{
			return default(bool);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x369CF20", Offset = "0x369BB20", VA = "0x18369CF20")]
		public bool TryGetBytesWithLength(out byte[] result)
		{
			return default(bool);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x369B450", Offset = "0x369A050", VA = "0x18369B450")]
		public void Clear()
		{
		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x18")]
		protected int _position;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x1C")]
		protected int _dataSize;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x20")]
		private int _offset;
	}
}
