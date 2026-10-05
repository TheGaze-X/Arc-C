using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000282 RID: 642
	[Token(Token = "0x2000282")]
	[UsedByNativeCode("FrameRate")]
	[NativeHeader("Runtime/Director/Core/FrameRate.h")]
	internal struct FrameRate : IEquatable<FrameRate>
	{
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00007260 File Offset: 0x00005460
		[Token(Token = "0x170002F1")]
		public bool dropFrame
		{
			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x4D4FC50", Offset = "0x4D4E850", VA = "0x184D4FC50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x170002F2")]
		public double rate
		{
			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x597EB30", Offset = "0x597D730", VA = "0x18597EB30")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x597EB10", Offset = "0x597D710", VA = "0x18597EB10")]
		public FrameRate(uint frameRate = 0U, bool drop = false)
		{
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x597E7C0", Offset = "0x597D3C0", VA = "0x18597E7C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x5921240", Offset = "0x591FE40", VA = "0x185921240", Slot = "4")]
		public bool Equals(FrameRate other)
		{
			return default(bool);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x597E720", Offset = "0x597D320", VA = "0x18597E720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x597EBA0", Offset = "0x597D7A0", VA = "0x18597EBA0")]
		public static bool operator ==(FrameRate a, FrameRate b)
		{
			return default(bool);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x597E9F0", Offset = "0x597D5F0", VA = "0x18597E9F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x597E7D0", Offset = "0x597D3D0", VA = "0x18597E7D0")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x597E5D0", Offset = "0x597D1D0", VA = "0x18597E5D0")]
		internal static FrameRate DoubleToFrameRate(double framerate)
		{
			return default(FrameRate);
		}

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x0")]
		[Ignore]
		public static readonly FrameRate k_24Fps;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x4")]
		[Ignore]
		public static readonly FrameRate k_23_976Fps;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x8")]
		[Ignore]
		public static readonly FrameRate k_25Fps;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0xC")]
		[Ignore]
		public static readonly FrameRate k_30Fps;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x10")]
		[Ignore]
		public static readonly FrameRate k_29_97Fps;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x14")]
		[Ignore]
		public static readonly FrameRate k_50Fps;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x18")]
		[Ignore]
		public static readonly FrameRate k_60Fps;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x1C")]
		[Ignore]
		public static readonly FrameRate k_59_94Fps;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int m_Rate;
	}
}
