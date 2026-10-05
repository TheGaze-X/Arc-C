using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	public struct InputStateBlock
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x56EF290", Offset = "0x56EDE90", VA = "0x1856EF290")]
		public static int GetSizeOfPrimitiveFormatInBits(FourCC type)
		{
			return 0;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x56EECA0", Offset = "0x56ED8A0", VA = "0x1856EECA0")]
		public static FourCC GetPrimitiveFormatFromType(Type type)
		{
			return default(FourCC);
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00008EB0 File Offset: 0x000070B0
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E9")]
		public FourCC format
		{
			[Token(Token = "0x6001125")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return default(FourCC);
			}
			[Token(Token = "0x6001126")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00008EC8 File Offset: 0x000070C8
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EA")]
		public uint byteOffset
		{
			[Token(Token = "0x6001127")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001128")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			set
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00008EE0 File Offset: 0x000070E0
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EB")]
		public uint bitOffset
		{
			[Token(Token = "0x6001129")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600112A")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00008EF8 File Offset: 0x000070F8
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EC")]
		public uint sizeInBits
		{
			[Token(Token = "0x600112B")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600112C")]
			[Address(RVA = "0x375DB10", Offset = "0x375C710", VA = "0x18375DB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x170004ED")]
		internal uint alignedSizeInBytes
		{
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x56F1400", Offset = "0x56F0000", VA = "0x1856F1400")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x170004EE")]
		internal uint effectiveByteOffset
		{
			[Token(Token = "0x600112E")]
			[Address(RVA = "0x56F14A0", Offset = "0x56F00A0", VA = "0x1856F14A0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x170004EF")]
		internal uint effectiveBitOffset
		{
			[Token(Token = "0x600112F")]
			[Address(RVA = "0x56F1450", Offset = "0x56F0050", VA = "0x1856F1450")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x56EFF20", Offset = "0x56EEB20", VA = "0x1856EFF20")]
		public unsafe int ReadInt(void* statePtr)
		{
			return 0;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x56F0980", Offset = "0x56EF580", VA = "0x1856F0980")]
		public unsafe void WriteInt(void* statePtr, int value)
		{
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x56EFA90", Offset = "0x56EE690", VA = "0x1856EFA90")]
		public unsafe float ReadFloat(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x56F05C0", Offset = "0x56EF1C0", VA = "0x1856F05C0")]
		public unsafe void WriteFloat(void* statePtr, float value)
		{
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x56EE810", Offset = "0x56ED410", VA = "0x1856EE810")]
		internal PrimitiveValue FloatToPrimitiveValue(float value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x56EF5E0", Offset = "0x56EE1E0", VA = "0x1856EF5E0")]
		public unsafe double ReadDouble(void* statePtr)
		{
			return 0.0;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x56F01E0", Offset = "0x56EEDE0", VA = "0x1856F01E0")]
		public unsafe void WriteDouble(void* statePtr, double value)
		{
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x56F0BE0", Offset = "0x56EF7E0", VA = "0x1856F0BE0")]
		public unsafe void Write(void* statePtr, PrimitiveValue value)
		{
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x56EE6C0", Offset = "0x56ED2C0", VA = "0x1856EE6C0")]
		public unsafe void CopyToFrom(void* toStatePtr, void* fromStatePtr)
		{
		}

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		public const uint InvalidOffset = 4294967295U;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		public const uint AutomaticOffset = 4294967294U;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FourCC FormatInvalid;

		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		internal const int kFormatInvalid = 0;

		// Token: 0x04000A35 RID: 2613
		[Token(Token = "0x4000A35")]
		[FieldOffset(Offset = "0x4")]
		public static readonly FourCC FormatBit;

		// Token: 0x04000A36 RID: 2614
		[Token(Token = "0x4000A36")]
		internal const int kFormatBit = 1112101920;

		// Token: 0x04000A37 RID: 2615
		[Token(Token = "0x4000A37")]
		[FieldOffset(Offset = "0x8")]
		public static readonly FourCC FormatSBit;

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		internal const int kFormatSBit = 1396853076;

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0xC")]
		public static readonly FourCC FormatInt;

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		internal const int kFormatInt = 1229870112;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly FourCC FormatUInt;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		internal const int kFormatUInt = 1430867540;

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x14")]
		public static readonly FourCC FormatShort;

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		internal const int kFormatShort = 1397248596;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x18")]
		public static readonly FourCC FormatUShort;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		internal const int kFormatUShort = 1431521364;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly FourCC FormatByte;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		internal const int kFormatByte = 1113150533;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x20")]
		public static readonly FourCC FormatSByte;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		internal const int kFormatSByte = 1396857172;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x24")]
		public static readonly FourCC FormatLong;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		internal const int kFormatLong = 1280198432;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x28")]
		public static readonly FourCC FormatULong;

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		internal const int kFormatULong = 1431064135;

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly FourCC FormatFloat;

		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		internal const int kFormatFloat = 1179407392;

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		[FieldOffset(Offset = "0x30")]
		public static readonly FourCC FormatDouble;

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		internal const int kFormatDouble = 1145195552;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x34")]
		public static readonly FourCC FormatVector2;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		internal const int kFormatVector2 = 1447379762;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x38")]
		public static readonly FourCC FormatVector3;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		internal const int kFormatVector3 = 1447379763;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly FourCC FormatQuaternion;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		internal const int kFormatQuaternion = 1364541780;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x40")]
		public static readonly FourCC FormatVector2Short;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x44")]
		public static readonly FourCC FormatVector3Short;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x48")]
		public static readonly FourCC FormatVector2Byte;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly FourCC FormatVector3Byte;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x50")]
		public static readonly FourCC FormatPose;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		internal const int kFormatPose = 1349481317;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0x4")]
		internal uint m_ByteOffset;
	}
}
