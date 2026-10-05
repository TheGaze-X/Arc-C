using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.Log
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	[Serializable]
	public struct BitArray256
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x17000001")]
		public uint capacity
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x4A09480", Offset = "0x4A08080", VA = "0x184A09480")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000002")]
		public bool allFalse
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x4A09440", Offset = "0x4A08040", VA = "0x184A09440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x17000003")]
		public bool allTrue
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4A09460", Offset = "0x4A08060", VA = "0x184A09460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x17000004")]
		public string humanizedData
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4A09490", Offset = "0x4A08090", VA = "0x184A09490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		[Token(Token = "0x17000005")]
		public bool this[byte index]
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4A09080", Offset = "0x4A07C80", VA = "0x184A09080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4A09920", Offset = "0x4A08520", VA = "0x184A09920")]
			set
			{
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4A09210", Offset = "0x4A07E10", VA = "0x184A09210")]
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4A09230", Offset = "0x4A07E30", VA = "0x184A09230")]
		public BitArray256(IList<uint> bitIndexTrue)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4A098F0", Offset = "0x4A084F0", VA = "0x184A098F0")]
		public static BitArray256 operator ~(BitArray256 a)
		{
			return default(BitArray256);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4A097D0", Offset = "0x4A083D0", VA = "0x184A097D0")]
		public static BitArray256 operator |(BitArray256 a, BitArray256 b)
		{
			return default(BitArray256);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4A09790", Offset = "0x4A08390", VA = "0x184A09790")]
		public static BitArray256 operator &(BitArray256 a, BitArray256 b)
		{
			return default(BitArray256);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4A09810", Offset = "0x4A08410", VA = "0x184A09810")]
		public static bool operator ==(BitArray256 a, BitArray256 b)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4A09880", Offset = "0x4A08480", VA = "0x184A09880")]
		public static bool operator !=(BitArray256 a, BitArray256 b)
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4A08F40", Offset = "0x4A07B40", VA = "0x184A08F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4A090C0", Offset = "0x4A07CC0", VA = "0x184A090C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4A09080", Offset = "0x4A07C80", VA = "0x184A09080")]
		public bool GetBool(byte index)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4A09180", Offset = "0x4A07D80", VA = "0x184A09180")]
		public void SetBool(uint index, bool value)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4A09160", Offset = "0x4A07D60", VA = "0x184A09160")]
		public void SetAllTrue()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4A09140", Offset = "0x4A07D40", VA = "0x184A09140")]
		public void SetAllFalse()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4A08F10", Offset = "0x4A07B10", VA = "0x184A08F10")]
		public static BitArray256 AllTrue()
		{
			return default(BitArray256);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4A08F10", Offset = "0x4A07B10", VA = "0x184A08F10")]
		public static BitArray256 AllFalse()
		{
			return default(BitArray256);
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ulong data1;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ulong data2;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ulong data3;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ulong data4;
	}
}
