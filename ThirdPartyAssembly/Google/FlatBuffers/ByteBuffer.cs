using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Google.FlatBuffers
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public class ByteBuffer
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
		public ByteBuffer(ByteBufferAllocator allocator, int position)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x54408E0", Offset = "0x543F4E0", VA = "0x1854408E0")]
		public ByteBuffer(int size)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x5440820", Offset = "0x543F420", VA = "0x185440820")]
		public ByteBuffer(byte[] buffer)
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x5440750", Offset = "0x543F350", VA = "0x185440750")]
		public ByteBuffer(byte[] buffer, int pos)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00004050 File Offset: 0x00002250
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000091")]
		public int Position
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x17000092")]
		public int Length
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1FC1100", Offset = "0x1FBFD00", VA = "0x181FC1100")]
		public void Reset()
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x543F550", Offset = "0x543E150", VA = "0x18543F550")]
		public ByteBuffer Duplicate()
		{
			return null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x543F7B0", Offset = "0x543E3B0", VA = "0x18543F7B0")]
		public void GrowFront(int newSize)
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x5440160", Offset = "0x543ED60", VA = "0x185440160")]
		public byte[] ToArray(int pos, int len)
		{
			return null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x600050E")]
		public static int SizeOf<T>()
		{
			return 0;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x600050F")]
		public static bool IsSupportedType<T>()
		{
			return default(bool);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x6000510")]
		public static int ArraySize<T>(T[] x)
		{
			return 0;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000511")]
		public static int ArraySize<T>(ArraySegment<T> x)
		{
			return 0;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		public T[] ToArray<T>(int pos, int len) where T : struct
		{
			return null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x54402B0", Offset = "0x543EEB0", VA = "0x1854402B0")]
		public byte[] ToSizedArray()
		{
			return null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x54401C0", Offset = "0x543EDC0", VA = "0x1854401C0")]
		public byte[] ToFullArray()
		{
			return null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x54400D0", Offset = "0x543ECD0", VA = "0x1854400D0")]
		public ArraySegment<byte> ToArraySegment(int pos, int len)
		{
			return default(ArraySegment<byte>);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x5440210", Offset = "0x543EE10", VA = "0x185440210")]
		public MemoryStream ToMemoryStream(int pos, int len)
		{
			return null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x51AF910", Offset = "0x51AE510", VA = "0x1851AF910")]
		public static ushort ReverseBytes(ushort input)
		{
			return 0;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x36B0E00", Offset = "0x36AFA00", VA = "0x1836B0E00")]
		public static uint ReverseBytes(uint input)
		{
			return 0U;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x5440040", Offset = "0x543EC40", VA = "0x185440040")]
		public static ulong ReverseBytes(ulong input)
		{
			return 0UL;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x5440310", Offset = "0x543EF10", VA = "0x185440310")]
		protected void WriteLittleEndian(int offset, int count, ulong data)
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x543FEB0", Offset = "0x543EAB0", VA = "0x18543FEB0")]
		protected ulong ReadLittleEndian(int offset, int count)
		{
			return 0UL;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x543F4E0", Offset = "0x543E0E0", VA = "0x18543F4E0")]
		private void AssertOffsetAndLength(int offset, int length)
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x543F800", Offset = "0x543E400", VA = "0x18543F800")]
		public void PutSbyte(int offset, sbyte value)
		{
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x543F800", Offset = "0x543E400", VA = "0x18543F800")]
		public void PutByte(int offset, byte value)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x543F890", Offset = "0x543E490", VA = "0x18543F890")]
		public void PutByte(int offset, byte value, int count)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x543FEA0", Offset = "0x543EAA0", VA = "0x18543FEA0")]
		public void Put(int offset, byte value)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x543FC70", Offset = "0x543E870", VA = "0x18543FC70")]
		public void PutStringUTF8(int offset, string value)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x543FBE0", Offset = "0x543E7E0", VA = "0x18543FBE0")]
		public void PutShort(int offset, short value)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x543FE10", Offset = "0x543EA10", VA = "0x18543FE10")]
		public void PutUshort(int offset, ushort value)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x543FAC0", Offset = "0x543E6C0", VA = "0x18543FAC0")]
		public void PutInt(int offset, int value)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x543FD80", Offset = "0x543E980", VA = "0x18543FD80")]
		public void PutUint(int offset, uint value)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x543FB50", Offset = "0x543E750", VA = "0x18543FB50")]
		public void PutLong(int offset, long value)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x543FB50", Offset = "0x543E750", VA = "0x18543FB50")]
		public void PutUlong(int offset, ulong value)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x543FA30", Offset = "0x543E630", VA = "0x18543FA30")]
		public void PutFloat(int offset, float value)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x543F950", Offset = "0x543E550", VA = "0x18543F950")]
		public void PutDouble(int offset, double value)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x543F680", Offset = "0x543E280", VA = "0x18543F680")]
		public sbyte GetSbyte(int index)
		{
			return 0;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x543F680", Offset = "0x543E280", VA = "0x18543F680")]
		public byte Get(int index)
		{
			return 0;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x543F720", Offset = "0x543E320", VA = "0x18543F720")]
		public string GetStringUTF8(int startPos, int len)
		{
			return null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x543F710", Offset = "0x543E310", VA = "0x18543F710")]
		public short GetShort(int index)
		{
			return 0;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x543F710", Offset = "0x543E310", VA = "0x18543F710")]
		public ushort GetUshort(int index)
		{
			return 0;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x543F660", Offset = "0x543E260", VA = "0x18543F660")]
		public int GetInt(int index)
		{
			return 0;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x543F660", Offset = "0x543E260", VA = "0x18543F660")]
		public uint GetUint(int index)
		{
			return 0U;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x543F670", Offset = "0x543E270", VA = "0x18543F670")]
		public long GetLong(int index)
		{
			return 0L;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x543F670", Offset = "0x543E270", VA = "0x18543F670")]
		public ulong GetUlong(int index)
		{
			return 0UL;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x543F640", Offset = "0x543E240", VA = "0x18543F640")]
		public float GetFloat(int index)
		{
			return 0f;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x543F5D0", Offset = "0x543E1D0", VA = "0x18543F5D0")]
		public double GetDouble(int index)
		{
			return 0.0;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x6000535")]
		public int Put<T>(int offset, T[] x) where T : struct
		{
			return 0;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x6000536")]
		public int Put<T>(int offset, ArraySegment<T> x) where T : struct
		{
			return 0;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x6000537")]
		public int Put<T>(int offset, IntPtr ptr, int sizeInBytes) where T : struct
		{
			return 0;
		}

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ByteBufferAllocator _buffer;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _pos;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, int> genericSizes;

		// Token: 0x0200010B RID: 267
		[Token(Token = "0x200010B")]
		[StructLayout(2)]
		private struct ConversionUnion
		{
			// Token: 0x040005EB RID: 1515
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int intValue;

			// Token: 0x040005EC RID: 1516
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float floatValue;
		}
	}
}
