using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000240 RID: 576
	[Token(Token = "0x2000240")]
	internal static class MemoryHelpers
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x560F8A0", Offset = "0x560E4A0", VA = "0x18560F8A0")]
		public unsafe static bool Compare(void* ptr1, void* ptr2, MemoryHelpers.BitRegion region)
		{
			return default(bool);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x560F910", Offset = "0x560E510", VA = "0x18560F910")]
		public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits)
		{
			return 0U;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x56103D0", Offset = "0x560EFD0", VA = "0x1856103D0")]
		public unsafe static void WriteSingleBit(void* ptr, uint bitOffset, bool value)
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x5610030", Offset = "0x560EC30", VA = "0x185610030")]
		public unsafe static bool ReadSingleBit(void* ptr, uint bitOffset)
		{
			return default(bool);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x560FAB0", Offset = "0x560E6B0", VA = "0x18560FAB0")]
		public unsafe static void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount)
		{
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x560F930", Offset = "0x560E530", VA = "0x18560F930")]
		public unsafe static bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, [Optional] void* mask)
		{
			return default(bool);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x560FCD0", Offset = "0x560E8D0", VA = "0x18560FCD0")]
		public unsafe static void MemSet(void* destination, int numBytes, byte value)
		{
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x560FBC0", Offset = "0x560E7C0", VA = "0x18560FBC0")]
		public unsafe static void MemCpyMasked(void* destination, void* source, int numBytes, void* mask)
		{
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x560FE40", Offset = "0x560EA40", VA = "0x18560FE40")]
		public unsafe static uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount)
		{
			return 0U;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x5610400", Offset = "0x560F000", VA = "0x185610400")]
		public unsafe static void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value)
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x5610060", Offset = "0x560EC60", VA = "0x185610060")]
		public unsafe static int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount)
		{
			return 0;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x5610340", Offset = "0x560EF40", VA = "0x185610340")]
		public unsafe static void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value)
		{
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x560FDA0", Offset = "0x560E9A0", VA = "0x18560FDA0")]
		public unsafe static int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount)
		{
			return 0;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x5610310", Offset = "0x560EF10", VA = "0x185610310")]
		public unsafe static void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value)
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x560FDD0", Offset = "0x560E9D0", VA = "0x18560FDD0")]
		public unsafe static float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount)
		{
			return 0f;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x5610350", Offset = "0x560EF50", VA = "0x185610350")]
		public unsafe static void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value)
		{
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x5610070", Offset = "0x560EC70", VA = "0x185610070")]
		public unsafe static void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		public static void Swap<TValue>(ref TValue a, ref TValue b)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x560F820", Offset = "0x560E420", VA = "0x18560F820")]
		public static uint AlignNatural(uint offset, uint sizeInBytes)
		{
			return 0U;
		}

		// Token: 0x02000241 RID: 577
		[Token(Token = "0x2000241")]
		public struct BitRegion
		{
			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x06001504 RID: 5380 RVA: 0x0000B2F8 File Offset: 0x000094F8
			[Token(Token = "0x170005CF")]
			public bool isEmpty
			{
				[Token(Token = "0x6001504")]
				[Address(RVA = "0x560EF50", Offset = "0x560DB50", VA = "0x18560EF50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001505 RID: 5381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001505")]
			[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
			public BitRegion(uint bitOffset, uint sizeInBits)
			{
			}

			// Token: 0x06001506 RID: 5382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001506")]
			[Address(RVA = "0x560EF40", Offset = "0x560DB40", VA = "0x18560EF40")]
			public BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits)
			{
			}

			// Token: 0x06001507 RID: 5383 RVA: 0x0000B310 File Offset: 0x00009510
			[Token(Token = "0x6001507")]
			[Address(RVA = "0x560EE90", Offset = "0x560DA90", VA = "0x18560EE90")]
			public MemoryHelpers.BitRegion Overlap(MemoryHelpers.BitRegion other)
			{
				return default(MemoryHelpers.BitRegion);
			}

			// Token: 0x04000C24 RID: 3108
			[Token(Token = "0x4000C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint bitOffset;

			// Token: 0x04000C25 RID: 3109
			[Token(Token = "0x4000C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint sizeInBits;
		}
	}
}
