using System;
using System.Net;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public class NetDataWriter
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000034")]
		public int Capacity
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x369EE20", Offset = "0x369DA20", VA = "0x18369EE20")]
		public NetDataWriter()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x369EE80", Offset = "0x369DA80", VA = "0x18369EE80")]
		public NetDataWriter(bool autoResize)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x369EEF0", Offset = "0x369DAF0", VA = "0x18369EEF0")]
		public NetDataWriter(bool autoResize, int initialSize)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x369DA60", Offset = "0x369C660", VA = "0x18369DA60")]
		public static NetDataWriter FromBytes(byte[] bytes, bool copy)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x369DC20", Offset = "0x369C820", VA = "0x18369DC20")]
		public static NetDataWriter FromBytes(byte[] bytes, int offset, int length)
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x369DD60", Offset = "0x369C960", VA = "0x18369DD60")]
		public static NetDataWriter FromString(string value)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x369EDA0", Offset = "0x369D9A0", VA = "0x18369EDA0")]
		public void ResizeIfNeed(int newSize)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x369ED30", Offset = "0x369D930", VA = "0x18369ED30")]
		public void Reset(int size)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1FC1100", Offset = "0x1FBFD00", VA = "0x181FC1100")]
		public void Reset()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x369D9F0", Offset = "0x369C5F0", VA = "0x18369D9F0")]
		public byte[] CopyData()
		{
			return null;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000035")]
		public byte[] Data
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000036")]
		public int Length
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x369EE10", Offset = "0x369DA10", VA = "0x18369EE10")]
		public int SetPosition(int position)
		{
			return 0;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x369E780", Offset = "0x369D380", VA = "0x18369E780")]
		public void Put(float value)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x369E870", Offset = "0x369D470", VA = "0x18369E870")]
		public void Put(double value)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x369E650", Offset = "0x369D250", VA = "0x18369E650")]
		public void Put(long value)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x369E650", Offset = "0x369D250", VA = "0x18369E650")]
		public void Put(ulong value)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x369EAB0", Offset = "0x369D6B0", VA = "0x18369EAB0")]
		public void Put(int value)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x369EAB0", Offset = "0x369D6B0", VA = "0x18369EAB0")]
		public void Put(uint value)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x369E430", Offset = "0x369D030", VA = "0x18369E430")]
		public void Put(char value)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x369E430", Offset = "0x369D030", VA = "0x18369E430")]
		public void Put(ushort value)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x369E430", Offset = "0x369D030", VA = "0x18369E430")]
		public void Put(short value)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x369E6E0", Offset = "0x369D2E0", VA = "0x18369E6E0")]
		public void Put(sbyte value)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x369E6E0", Offset = "0x369D2E0", VA = "0x18369E6E0")]
		public void Put(byte value)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x369E590", Offset = "0x369D190", VA = "0x18369E590")]
		public void Put(byte[] data, int offset, int length)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x369E4E0", Offset = "0x369D0E0", VA = "0x18369E4E0")]
		public void Put(byte[] data)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x369E1E0", Offset = "0x369CDE0", VA = "0x18369E1E0")]
		public void PutSBytesWithLength(sbyte[] data, int offset, int length)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x369E310", Offset = "0x369CF10", VA = "0x18369E310")]
		public void PutSBytesWithLength(sbyte[] data)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x369E1E0", Offset = "0x369CDE0", VA = "0x18369E1E0")]
		public void PutBytesWithLength(byte[] data, int offset, int length)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x369E310", Offset = "0x369CF10", VA = "0x18369E310")]
		public void PutBytesWithLength(byte[] data)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x369EC90", Offset = "0x369D890", VA = "0x18369EC90")]
		public void Put(bool value)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x369DE40", Offset = "0x369CA40", VA = "0x18369DE40")]
		private void PutArray(Array arr, int sz)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x369DFE0", Offset = "0x369CBE0", VA = "0x18369DFE0")]
		public void PutArray(float[] value)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x369DE30", Offset = "0x369CA30", VA = "0x18369DE30")]
		public void PutArray(double[] value)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x369DE30", Offset = "0x369CA30", VA = "0x18369DE30")]
		public void PutArray(long[] value)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x369DE30", Offset = "0x369CA30", VA = "0x18369DE30")]
		public void PutArray(ulong[] value)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x369DFE0", Offset = "0x369CBE0", VA = "0x18369DFE0")]
		public void PutArray(int[] value)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x369DFE0", Offset = "0x369CBE0", VA = "0x18369DFE0")]
		public void PutArray(uint[] value)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x369DE20", Offset = "0x369CA20", VA = "0x18369DE20")]
		public void PutArray(ushort[] value)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x369DE20", Offset = "0x369CA20", VA = "0x18369DE20")]
		public void PutArray(short[] value)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x369DE10", Offset = "0x369CA10", VA = "0x18369DE10")]
		public void PutArray(bool[] value)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x369DF50", Offset = "0x369CB50", VA = "0x18369DF50")]
		public void PutArray(string[] value)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x369DFF0", Offset = "0x369CBF0", VA = "0x18369DFF0")]
		public void PutArray(string[] value, int maxLength)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x369E910", Offset = "0x369D510", VA = "0x18369E910")]
		public void Put(IPEndPoint endPoint)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x369EB90", Offset = "0x369D790", VA = "0x18369EB90")]
		public void Put(string value)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x369E990", Offset = "0x369D590", VA = "0x18369E990")]
		public void Put(string value, int maxLength)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		public void Put<T>(T obj) where T : INetSerializable
		{
		}

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x18")]
		protected int _position;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		private const int InitialSize = 64;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x1C")]
		private readonly bool _autoResize;
	}
}
