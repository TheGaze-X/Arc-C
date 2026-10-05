using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	[System.Serializable]
	[StructLayout(2)]
	public readonly struct Decimal : System.IFormattable, System.IComparable, System.IConvertible, System.IComparable<decimal>, System.IEquatable<decimal>, System.Runtime.Serialization.IDeserializationCallback, ISpanFormattable
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		[Token(Token = "0x17000189")]
		internal uint High
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		[Token(Token = "0x1700018A")]
		internal uint Low
		{
			[Token(Token = "0x6001101")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[Token(Token = "0x1700018B")]
		internal uint Mid
		{
			[Token(Token = "0x6001102")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[Token(Token = "0x1700018C")]
		internal bool IsNegative
		{
			[Token(Token = "0x6001103")]
			[Address(RVA = "0x4D4FC50", Offset = "0x4D4E850", VA = "0x184D4FC50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0000DB18 File Offset: 0x0000BD18
		[Token(Token = "0x1700018D")]
		internal int Scale
		{
			[Token(Token = "0x6001104")]
			[Address(RVA = "0x217A7C0", Offset = "0x21793C0", VA = "0x18217A7C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[Token(Token = "0x1700018E")]
		private ulong Low64
		{
			[Token(Token = "0x6001105")]
			[Address(RVA = "0x4D52200", Offset = "0x4D50E00", VA = "0x184D52200")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001106")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		private static ref decimal.DecCalc AsMutable(ref decimal d)
		{
			return null;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0000DB48 File Offset: 0x0000BD48
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x4D4FEC0", Offset = "0x4D4EAC0", VA = "0x184D4FEC0")]
		internal static uint DecDivMod1E9(ref decimal value)
		{
			return 0U;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x4D51EF0", Offset = "0x4D50AF0", VA = "0x184D51EF0")]
		public Decimal(int value)
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x4D51E60", Offset = "0x4D50A60", VA = "0x184D51E60")]
		[System.CLSCompliant(false)]
		public Decimal(uint value)
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x4D51FF0", Offset = "0x4D50BF0", VA = "0x184D51FF0")]
		public Decimal(long value)
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x4D51F20", Offset = "0x4D50B20", VA = "0x184D51F20")]
		[System.CLSCompliant(false)]
		public Decimal(ulong value)
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x4D52180", Offset = "0x4D50D80", VA = "0x184D52180")]
		public Decimal(float value)
		{
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x4D51E70", Offset = "0x4D50A70", VA = "0x184D51E70")]
		public Decimal(double value)
		{
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0000DB60 File Offset: 0x0000BD60
		[Token(Token = "0x600110E")]
		[Address(RVA = "0x4D502E0", Offset = "0x4D4EEE0", VA = "0x184D502E0")]
		private static bool IsValid(int flags)
		{
			return default(bool);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110F")]
		[Address(RVA = "0x4D52020", Offset = "0x4D50C20", VA = "0x184D52020")]
		public Decimal(int[] bits)
		{
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001110")]
		[Address(RVA = "0x4D51F40", Offset = "0x4D50B40", VA = "0x184D51F40")]
		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x4D50D60", Offset = "0x4D4F960", VA = "0x184D50D60", Slot = "25")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x4D51F30", Offset = "0x4D50B30", VA = "0x184D51F30")]
		private Decimal(in decimal d, int flags)
		{
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0000DB78 File Offset: 0x0000BD78
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x4D4FD50", Offset = "0x4D4E950", VA = "0x184D4FD50", Slot = "5")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[Token(Token = "0x6001114")]
		[Address(RVA = "0x4D4FE60", Offset = "0x4D4EA60", VA = "0x184D4FE60", Slot = "23")]
		public int CompareTo(decimal value)
		{
			return 0;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x4D50000", Offset = "0x4D4EC00", VA = "0x184D50000", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x4D4FFA0", Offset = "0x4D4EBA0", VA = "0x184D4FFA0", Slot = "24")]
		public bool Equals(decimal value)
		{
			return default(bool);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x4D50150", Offset = "0x4D4ED50", VA = "0x184D50150", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001118")]
		[Address(RVA = "0x4D51680", Offset = "0x4D50280", VA = "0x184D51680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x4D514B0", Offset = "0x4D500B0", VA = "0x184D514B0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600111A")]
		[Address(RVA = "0x4D51400", Offset = "0x4D50000", VA = "0x184D51400", Slot = "21")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x4D51590", Offset = "0x4D50190", VA = "0x184D51590", Slot = "4")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x4D51AD0", Offset = "0x4D506D0", VA = "0x184D51AD0", Slot = "26")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0000DC08 File Offset: 0x0000BE08
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x4D50430", Offset = "0x4D4F030", VA = "0x184D50430")]
		public static decimal Parse(string s, System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x4D50320", Offset = "0x4D4EF20", VA = "0x184D50320")]
		public static decimal Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0000DC38 File Offset: 0x0000BE38
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x4D51BA0", Offset = "0x4D507A0", VA = "0x184D51BA0")]
		public static bool TryParse(string s, out decimal result)
		{
			return default(bool);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0000DC50 File Offset: 0x0000BE50
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x4D51C80", Offset = "0x4D50880", VA = "0x184D51C80")]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out decimal result)
		{
			return default(bool);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x4D500C0", Offset = "0x4D4ECC0", VA = "0x184D500C0")]
		public static int[] GetBits(decimal d)
		{
			return null;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000DC68 File Offset: 0x0000BE68
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x4D50300", Offset = "0x4D4EF00", VA = "0x184D50300")]
		public static decimal Negate(decimal d)
		{
			return 0m;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x4D50530", Offset = "0x4D4F130", VA = "0x184D50530")]
		public static decimal Round(decimal d, int decimals)
		{
			return 0m;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x4D505B0", Offset = "0x4D4F1B0", VA = "0x184D505B0")]
		private static decimal Round(ref decimal d, int decimals, System.MidpointRounding mode)
		{
			return 0m;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x4D50E10", Offset = "0x4D4FA10", VA = "0x184D50E10")]
		public static byte ToByte(decimal value)
		{
			return 0;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x4D51260", Offset = "0x4D4FE60", VA = "0x184D51260")]
		[System.CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			return 0;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x4D50F80", Offset = "0x4D4FB80", VA = "0x184D50F80")]
		public static short ToInt16(decimal value)
		{
			return 0;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x4D50F30", Offset = "0x4D4FB30", VA = "0x184D50F30")]
		public static double ToDouble(decimal d)
		{
			return 0.0;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x4D510A0", Offset = "0x4D4FCA0", VA = "0x184D510A0")]
		public static int ToInt32(decimal d)
		{
			return 0;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x4D51180", Offset = "0x4D4FD80", VA = "0x184D51180")]
		public static long ToInt64(decimal d)
		{
			return 0L;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x4D51720", Offset = "0x4D50320", VA = "0x184D51720")]
		[System.CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			return 0;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x4D51840", Offset = "0x4D50440", VA = "0x184D51840")]
		[System.CLSCompliant(false)]
		public static uint ToUInt32(decimal d)
		{
			return 0U;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x4D51910", Offset = "0x4D50510", VA = "0x184D51910")]
		[System.CLSCompliant(false)]
		public static ulong ToUInt64(decimal d)
		{
			return 0UL;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0000DD88 File Offset: 0x0000BF88
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x4D51380", Offset = "0x4D4FF80", VA = "0x184D51380")]
		public static float ToSingle(decimal d)
		{
			return 0f;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x4D51A70", Offset = "0x4D50670", VA = "0x184D51A70")]
		public static decimal Truncate(decimal d)
		{
			return 0m;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x4D519E0", Offset = "0x4D505E0", VA = "0x184D519E0")]
		[MethodImpl(256)]
		private static void Truncate(ref decimal d)
		{
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x4D52BF0", Offset = "0x4D517F0", VA = "0x184D52BF0")]
		public static implicit operator decimal(byte value)
		{
			return 0m;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x4D52B60", Offset = "0x4D51760", VA = "0x184D52B60")]
		[System.CLSCompliant(false)]
		public static implicit operator decimal(sbyte value)
		{
			return 0m;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x4D52BC0", Offset = "0x4D517C0", VA = "0x184D52BC0")]
		public static implicit operator decimal(short value)
		{
			return 0m;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0000DE00 File Offset: 0x0000C000
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x4D52AD0", Offset = "0x4D516D0", VA = "0x184D52AD0")]
		[System.CLSCompliant(false)]
		public static implicit operator decimal(ushort value)
		{
			return 0m;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0000DE18 File Offset: 0x0000C018
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x4D52AD0", Offset = "0x4D516D0", VA = "0x184D52AD0")]
		public static implicit operator decimal(char value)
		{
			return 0m;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x4D52B90", Offset = "0x4D51790", VA = "0x184D52B90")]
		public static implicit operator decimal(int value)
		{
			return 0m;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x4D52B50", Offset = "0x4D51750", VA = "0x184D52B50")]
		[System.CLSCompliant(false)]
		public static implicit operator decimal(uint value)
		{
			return 0m;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x4D52AF0", Offset = "0x4D516F0", VA = "0x184D52AF0")]
		public static implicit operator decimal(long value)
		{
			return 0m;
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Token(Token = "0x6001139")]
		[Address(RVA = "0x4D52B30", Offset = "0x4D51730", VA = "0x184D52B30")]
		[System.CLSCompliant(false)]
		public static implicit operator decimal(ulong value)
		{
			return 0m;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0000DE90 File Offset: 0x0000C090
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x4D52630", Offset = "0x4D51230", VA = "0x184D52630")]
		public static explicit operator decimal(float value)
		{
			return 0m;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x4D528D0", Offset = "0x4D514D0", VA = "0x184D528D0")]
		public static explicit operator decimal(double value)
		{
			return 0m;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x4D528F0", Offset = "0x4D514F0", VA = "0x184D528F0")]
		public static explicit operator int(decimal value)
		{
			return 0;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x4D52430", Offset = "0x4D51030", VA = "0x184D52430")]
		public static explicit operator long(decimal value)
		{
			return 0L;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x4D52650", Offset = "0x4D51250", VA = "0x184D52650")]
		[System.CLSCompliant(false)]
		public static explicit operator ulong(decimal value)
		{
			return 0UL;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x4D52950", Offset = "0x4D51550", VA = "0x184D52950")]
		public static explicit operator float(decimal value)
		{
			return 0f;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x4D52840", Offset = "0x4D51440", VA = "0x184D52840")]
		public static explicit operator double(decimal value)
		{
			return 0.0;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x4D52290", Offset = "0x4D50E90", VA = "0x184D52290")]
		public static decimal operator +(decimal d1, decimal d2)
		{
			return 0m;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x4D52DD0", Offset = "0x4D519D0", VA = "0x184D52DD0")]
		public static decimal operator -(decimal d1, decimal d2)
		{
			return 0m;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0000DF68 File Offset: 0x0000C168
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x4D52D30", Offset = "0x4D51930", VA = "0x184D52D30")]
		public static decimal operator *(decimal d1, decimal d2)
		{
			return 0m;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x4D52330", Offset = "0x4D50F30", VA = "0x184D52330")]
		public static decimal operator /(decimal d1, decimal d2)
		{
			return 0m;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x4D523D0", Offset = "0x4D50FD0", VA = "0x184D523D0")]
		public static bool operator ==(decimal d1, decimal d2)
		{
			return default(bool);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x4D52C10", Offset = "0x4D51810", VA = "0x184D52C10")]
		public static bool operator !=(decimal d1, decimal d2)
		{
			return default(bool);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x4D52CD0", Offset = "0x4D518D0", VA = "0x184D52CD0")]
		public static bool operator <(decimal d1, decimal d2)
		{
			return default(bool);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x4D52C70", Offset = "0x4D51870", VA = "0x184D52C70")]
		public static bool operator <=(decimal d1, decimal d2)
		{
			return default(bool);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x4D52A70", Offset = "0x4D51670", VA = "0x184D52A70")]
		public static bool operator >(decimal d1, decimal d2)
		{
			return default(bool);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x4D52A10", Offset = "0x4D51610", VA = "0x184D52A10")]
		public static bool operator >=(decimal d1, decimal d2)
		{
			return default(bool);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x4D502D0", Offset = "0x4D4EED0", VA = "0x184D502D0", Slot = "6")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x4D50780", Offset = "0x4D4F380", VA = "0x184D50780", Slot = "7")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x600114D")]
		[Address(RVA = "0x4D50840", Offset = "0x4D4F440", VA = "0x184D50840", Slot = "8")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x4D50AE0", Offset = "0x4D4F6E0", VA = "0x184D50AE0", Slot = "9")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0000E088 File Offset: 0x0000C288
		[Token(Token = "0x600114F")]
		[Address(RVA = "0x4D507E0", Offset = "0x4D4F3E0", VA = "0x184D507E0", Slot = "10")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x4D509C0", Offset = "0x4D4F5C0", VA = "0x184D509C0", Slot = "11")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x4D50C40", Offset = "0x4D4F840", VA = "0x184D50C40", Slot = "12")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x4D50A20", Offset = "0x4D4F620", VA = "0x184D50A20", Slot = "13")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x4D50CA0", Offset = "0x4D4F8A0", VA = "0x184D50CA0", Slot = "14")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0000E100 File Offset: 0x0000C300
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x4D50A80", Offset = "0x4D4F680", VA = "0x184D50A80", Slot = "15")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0000E118 File Offset: 0x0000C318
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x4D50D00", Offset = "0x4D4F900", VA = "0x184D50D00", Slot = "16")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0000E130 File Offset: 0x0000C330
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x4D50B40", Offset = "0x4D4F740", VA = "0x184D50B40", Slot = "17")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0000E148 File Offset: 0x0000C348
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x4D50960", Offset = "0x4D4F560", VA = "0x184D50960", Slot = "18")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0", Slot = "19")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x4D508D0", Offset = "0x4D4F4D0", VA = "0x184D508D0", Slot = "20")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x4D50BA0", Offset = "0x4D4F7A0", VA = "0x184D50BA0", Slot = "22")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		private const int SignMask = -2147483648;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		private const int ScaleMask = 16711680;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		private const int ScaleShift = 16;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public const decimal Zero = 0m;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public const decimal One = 1m;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public const decimal MinusOne = -1m;

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public const decimal MaxValue = 79228162514264337593543950335m;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public const decimal MinValue = -79228162514264337593543950335m;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int flags;

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private readonly int hi;

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly int lo;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly int mid;

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[System.NonSerialized]
		private readonly ulong ulomidLE;

		// Token: 0x020001E1 RID: 481
		[Token(Token = "0x20001E1")]
		[StructLayout(2)]
		private struct DecCalc
		{
			// Token: 0x1700018F RID: 399
			// (get) Token: 0x0600115C RID: 4444 RVA: 0x0000E190 File Offset: 0x0000C390
			// (set) Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700018F")]
			private uint High
			{
				[Token(Token = "0x600115C")]
				[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600115D")]
				[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
				set
				{
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x0600115E RID: 4446 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
			// (set) Token: 0x0600115F RID: 4447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000190")]
			private uint Low
			{
				[Token(Token = "0x600115E")]
				[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600115F")]
				[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
				set
				{
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06001160 RID: 4448 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
			// (set) Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000191")]
			private uint Mid
			{
				[Token(Token = "0x6001160")]
				[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6001161")]
				[Address(RVA = "0x375DB10", Offset = "0x375C710", VA = "0x18375DB10")]
				set
				{
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x06001162 RID: 4450 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
			[Token(Token = "0x17000192")]
			private bool IsNegative
			{
				[Token(Token = "0x6001162")]
				[Address(RVA = "0x4D4FC50", Offset = "0x4D4E850", VA = "0x184D4FC50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06001163 RID: 4451 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
			// (set) Token: 0x06001164 RID: 4452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000193")]
			private ulong Low64
			{
				[Token(Token = "0x6001163")]
				[Address(RVA = "0x4D4FC60", Offset = "0x4D4E860", VA = "0x184D4FC60")]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x6001164")]
				[Address(RVA = "0x4D4FCD0", Offset = "0x4D4E8D0", VA = "0x184D4FCD0")]
				set
				{
				}
			}

			// Token: 0x06001165 RID: 4453 RVA: 0x0000E208 File Offset: 0x0000C408
			[Token(Token = "0x6001165")]
			[Address(RVA = "0x4D4BEA0", Offset = "0x4D4AAA0", VA = "0x184D4BEA0")]
			private static uint GetExponent(float f)
			{
				return 0U;
			}

			// Token: 0x06001166 RID: 4454 RVA: 0x0000E220 File Offset: 0x0000C420
			[Token(Token = "0x6001166")]
			[Address(RVA = "0x4D4BE80", Offset = "0x4D4AA80", VA = "0x184D4BE80")]
			private static uint GetExponent(double d)
			{
				return 0U;
			}

			// Token: 0x06001167 RID: 4455 RVA: 0x0000E238 File Offset: 0x0000C438
			[Token(Token = "0x6001167")]
			[Address(RVA = "0x4CE1650", Offset = "0x4CE0250", VA = "0x184CE1650")]
			private static ulong UInt32x32To64(uint a, uint b)
			{
				return 0UL;
			}

			// Token: 0x06001168 RID: 4456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001168")]
			[Address(RVA = "0x4D4CF90", Offset = "0x4D4BB90", VA = "0x184D4CF90")]
			private static void UInt64x64To128(ulong a, ulong b, ref decimal.DecCalc result)
			{
			}

			// Token: 0x06001169 RID: 4457 RVA: 0x0000E250 File Offset: 0x0000C450
			[Token(Token = "0x6001169")]
			[Address(RVA = "0x4D4BB60", Offset = "0x4D4A760", VA = "0x184D4BB60")]
			private static uint Div96By32(ref decimal.DecCalc.Buf12 bufNum, uint den)
			{
				return 0U;
			}

			// Token: 0x0600116A RID: 4458 RVA: 0x0000E268 File Offset: 0x0000C468
			[Token(Token = "0x600116A")]
			[Address(RVA = "0x4D4BD80", Offset = "0x4D4A980", VA = "0x184D4BD80")]
			[MethodImpl(256)]
			private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
			{
				return default(bool);
			}

			// Token: 0x0600116B RID: 4459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600116B")]
			[Address(RVA = "0x4D4D110", Offset = "0x4D4BD10", VA = "0x184D4D110")]
			[MethodImpl(256)]
			private static void Unscale(ref uint low, ref ulong high64, ref int scale)
			{
			}

			// Token: 0x0600116C RID: 4460 RVA: 0x0000E280 File Offset: 0x0000C480
			[Token(Token = "0x600116C")]
			[Address(RVA = "0x4D4BC20", Offset = "0x4D4A820", VA = "0x184D4BC20")]
			private static uint Div96By64(ref decimal.DecCalc.Buf12 bufNum, ulong den)
			{
				return 0U;
			}

			// Token: 0x0600116D RID: 4461 RVA: 0x0000E298 File Offset: 0x0000C498
			[Token(Token = "0x600116D")]
			[Address(RVA = "0x4D4B9C0", Offset = "0x4D4A5C0", VA = "0x184D4B9C0")]
			private static uint Div128By96(ref decimal.DecCalc.Buf16 bufNum, ref decimal.DecCalc.Buf12 bufDen)
			{
				return 0U;
			}

			// Token: 0x0600116E RID: 4462 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
			[Token(Token = "0x600116E")]
			[Address(RVA = "0x4D4C090", Offset = "0x4D4AC90", VA = "0x184D4C090")]
			private static uint IncreaseScale(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
				return 0U;
			}

			// Token: 0x0600116F RID: 4463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600116F")]
			[Address(RVA = "0x4D4C010", Offset = "0x4D4AC10", VA = "0x184D4C010")]
			private static void IncreaseScale64(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
			}

			// Token: 0x06001170 RID: 4464 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
			[Token(Token = "0x6001170")]
			[Address(RVA = "0x4D4C610", Offset = "0x4D4B210", VA = "0x184D4C610")]
			private unsafe static int ScaleResult(decimal.DecCalc.Buf24* bufRes, uint hiRes, int scale)
			{
				return 0;
			}

			// Token: 0x06001171 RID: 4465 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
			[Token(Token = "0x6001171")]
			[Address(RVA = "0x4D4BE00", Offset = "0x4D4AA00", VA = "0x184D4BE00")]
			[MethodImpl(256)]
			private unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
			{
				return 0U;
			}

			// Token: 0x06001172 RID: 4466 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
			[Token(Token = "0x6001172")]
			[Address(RVA = "0x4D4C480", Offset = "0x4D4B080", VA = "0x184D4C480")]
			[MethodImpl(256)]
			private static int LeadingZeroCount(uint value)
			{
				return 0;
			}

			// Token: 0x06001173 RID: 4467 RVA: 0x0000E310 File Offset: 0x0000C510
			[Token(Token = "0x6001173")]
			[Address(RVA = "0x4D4C4E0", Offset = "0x4D4B0E0", VA = "0x184D4C4E0")]
			private static int OverflowUnscale(ref decimal.DecCalc.Buf12 bufQuo, int scale, bool sticky)
			{
				return 0;
			}

			// Token: 0x06001174 RID: 4468 RVA: 0x0000E328 File Offset: 0x0000C528
			[Token(Token = "0x6001174")]
			[Address(RVA = "0x4D4CD50", Offset = "0x4D4B950", VA = "0x184D4CD50")]
			private static int SearchScale(ref decimal.DecCalc.Buf12 bufQuo, int scale)
			{
				return 0;
			}

			// Token: 0x06001175 RID: 4469 RVA: 0x0000E340 File Offset: 0x0000C540
			[Token(Token = "0x6001175")]
			[Address(RVA = "0x4D4AF50", Offset = "0x4D49B50", VA = "0x184D4AF50")]
			private static bool Add32To96(ref decimal.DecCalc.Buf12 bufNum, uint value)
			{
				return default(bool);
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001176")]
			[Address(RVA = "0x4D4B000", Offset = "0x4D49C00", VA = "0x184D4B000")]
			internal static void DecAddSub(ref decimal.DecCalc d1, ref decimal.DecCalc d2, bool sign)
			{
			}

			// Token: 0x06001177 RID: 4471 RVA: 0x0000E358 File Offset: 0x0000C558
			[Token(Token = "0x6001177")]
			[Address(RVA = "0x4D4D520", Offset = "0x4D4C120", VA = "0x184D4D520")]
			internal static int VarDecCmp(in decimal d1, in decimal d2)
			{
				return 0;
			}

			// Token: 0x06001178 RID: 4472 RVA: 0x0000E370 File Offset: 0x0000C570
			[Token(Token = "0x6001178")]
			[Address(RVA = "0x4D4D360", Offset = "0x4D4BF60", VA = "0x184D4D360")]
			private static int VarDecCmpSub(in decimal d1, in decimal d2)
			{
				return 0;
			}

			// Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001179")]
			[Address(RVA = "0x4D4F190", Offset = "0x4D4DD90", VA = "0x184D4F190")]
			internal static void VarDecMul(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117A")]
			[Address(RVA = "0x4D4E980", Offset = "0x4D4D580", VA = "0x184D4E980")]
			internal static void VarDecFromR4(float input, out decimal.DecCalc result)
			{
			}

			// Token: 0x0600117B RID: 4475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117B")]
			[Address(RVA = "0x4D4ED90", Offset = "0x4D4D990", VA = "0x184D4ED90")]
			internal static void VarDecFromR8(double input, out decimal.DecCalc result)
			{
			}

			// Token: 0x0600117C RID: 4476 RVA: 0x0000E388 File Offset: 0x0000C588
			[Token(Token = "0x600117C")]
			[Address(RVA = "0x4D4F7E0", Offset = "0x4D4E3E0", VA = "0x184D4F7E0")]
			internal static float VarR4FromDec(in decimal value)
			{
				return 0f;
			}

			// Token: 0x0600117D RID: 4477 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
			[Token(Token = "0x600117D")]
			[Address(RVA = "0x4D4F830", Offset = "0x4D4E430", VA = "0x184D4F830")]
			internal static double VarR8FromDec(in decimal value)
			{
				return 0.0;
			}

			// Token: 0x0600117E RID: 4478 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
			[Token(Token = "0x600117E")]
			[Address(RVA = "0x4D4BEC0", Offset = "0x4D4AAC0", VA = "0x184D4BEC0")]
			internal static int GetHashCode(in decimal d)
			{
				return 0;
			}

			// Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117F")]
			[Address(RVA = "0x4D4D630", Offset = "0x4D4C230", VA = "0x184D4D630")]
			internal static void VarDecDiv(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
			}

			// Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x4D4C120", Offset = "0x4D4AD20", VA = "0x184D4C120")]
			internal static void InternalRound(ref decimal.DecCalc d, uint scale, decimal.DecCalc.RoundingMode mode)
			{
			}

			// Token: 0x06001181 RID: 4481 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
			[Token(Token = "0x6001181")]
			[Address(RVA = "0x4D4B940", Offset = "0x4D4A540", VA = "0x184D4B940")]
			internal static uint DecDivMod1E9(ref decimal.DecCalc value)
			{
				return 0U;
			}

			// Token: 0x040009C2 RID: 2498
			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private uint uflags;

			// Token: 0x040009C3 RID: 2499
			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private uint uhi;

			// Token: 0x040009C4 RID: 2500
			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private uint ulo;

			// Token: 0x040009C5 RID: 2501
			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private uint umid;

			// Token: 0x040009C6 RID: 2502
			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ulong ulomidLE;

			// Token: 0x040009C7 RID: 2503
			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly uint[] s_powers10;

			// Token: 0x040009C8 RID: 2504
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static readonly ulong[] s_ulongPowers10;

			// Token: 0x040009C9 RID: 2505
			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static readonly double[] s_doublePowers10;

			// Token: 0x040009CA RID: 2506
			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static readonly decimal.DecCalc.PowerOvfl[] PowerOvflValues;

			// Token: 0x020001E2 RID: 482
			[Token(Token = "0x20001E2")]
			internal enum RoundingMode
			{
				// Token: 0x040009CC RID: 2508
				[Token(Token = "0x40009CC")]
				ToEven,
				// Token: 0x040009CD RID: 2509
				[Token(Token = "0x40009CD")]
				AwayFromZero,
				// Token: 0x040009CE RID: 2510
				[Token(Token = "0x40009CE")]
				Truncate,
				// Token: 0x040009CF RID: 2511
				[Token(Token = "0x40009CF")]
				Floor,
				// Token: 0x040009D0 RID: 2512
				[Token(Token = "0x40009D0")]
				Ceiling
			}

			// Token: 0x020001E3 RID: 483
			[Token(Token = "0x20001E3")]
			private struct PowerOvfl
			{
				// Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001183")]
				[Address(RVA = "0x4D58770", Offset = "0x4D57370", VA = "0x184D58770")]
				public PowerOvfl(uint hi, uint mid, uint lo)
				{
				}

				// Token: 0x040009D1 RID: 2513
				[Token(Token = "0x40009D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public readonly uint Hi;

				// Token: 0x040009D2 RID: 2514
				[Token(Token = "0x40009D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public readonly ulong MidLo;
			}

			// Token: 0x020001E4 RID: 484
			[Token(Token = "0x20001E4")]
			[StructLayout(2)]
			private struct Buf12
			{
				// Token: 0x17000194 RID: 404
				// (get) Token: 0x06001184 RID: 4484 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
				// (set) Token: 0x06001185 RID: 4485 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000194")]
				public ulong Low64
				{
					[Token(Token = "0x6001184")]
					[Address(RVA = "0x4D48160", Offset = "0x4D46D60", VA = "0x184D48160")]
					get
					{
						return 0UL;
					}
					[Token(Token = "0x6001185")]
					[Address(RVA = "0x4D48250", Offset = "0x4D46E50", VA = "0x184D48250")]
					set
					{
					}
				}

				// Token: 0x17000195 RID: 405
				// (get) Token: 0x06001186 RID: 4486 RVA: 0x0000E400 File Offset: 0x0000C600
				// (set) Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000195")]
				public ulong High64
				{
					[Token(Token = "0x6001186")]
					[Address(RVA = "0x4D480F0", Offset = "0x4D46CF0", VA = "0x184D480F0")]
					get
					{
						return 0UL;
					}
					[Token(Token = "0x6001187")]
					[Address(RVA = "0x4D481D0", Offset = "0x4D46DD0", VA = "0x184D481D0")]
					set
					{
					}
				}

				// Token: 0x040009D3 RID: 2515
				[Token(Token = "0x40009D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint U0;

				// Token: 0x040009D4 RID: 2516
				[Token(Token = "0x40009D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public uint U1;

				// Token: 0x040009D5 RID: 2517
				[Token(Token = "0x40009D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public uint U2;

				// Token: 0x040009D6 RID: 2518
				[Token(Token = "0x40009D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ulong ulo64LE;

				// Token: 0x040009D7 RID: 2519
				[Token(Token = "0x40009D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				private ulong uhigh64LE;
			}

			// Token: 0x020001E5 RID: 485
			[Token(Token = "0x20001E5")]
			[StructLayout(2)]
			private struct Buf16
			{
				// Token: 0x17000196 RID: 406
				// (get) Token: 0x06001188 RID: 4488 RVA: 0x0000E418 File Offset: 0x0000C618
				// (set) Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000196")]
				public ulong Low64
				{
					[Token(Token = "0x6001188")]
					[Address(RVA = "0x4D48340", Offset = "0x4D46F40", VA = "0x184D48340")]
					get
					{
						return 0UL;
					}
					[Token(Token = "0x6001189")]
					[Address(RVA = "0x4D48430", Offset = "0x4D47030", VA = "0x184D48430")]
					set
					{
					}
				}

				// Token: 0x17000197 RID: 407
				// (get) Token: 0x0600118A RID: 4490 RVA: 0x0000E430 File Offset: 0x0000C630
				// (set) Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000197")]
				public ulong High64
				{
					[Token(Token = "0x600118A")]
					[Address(RVA = "0x4D482D0", Offset = "0x4D46ED0", VA = "0x184D482D0")]
					get
					{
						return 0UL;
					}
					[Token(Token = "0x600118B")]
					[Address(RVA = "0x4D483B0", Offset = "0x4D46FB0", VA = "0x184D483B0")]
					set
					{
					}
				}

				// Token: 0x040009D8 RID: 2520
				[Token(Token = "0x40009D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint U0;

				// Token: 0x040009D9 RID: 2521
				[Token(Token = "0x40009D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public uint U1;

				// Token: 0x040009DA RID: 2522
				[Token(Token = "0x40009DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public uint U2;

				// Token: 0x040009DB RID: 2523
				[Token(Token = "0x40009DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public uint U3;

				// Token: 0x040009DC RID: 2524
				[Token(Token = "0x40009DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ulong ulo64LE;

				// Token: 0x040009DD RID: 2525
				[Token(Token = "0x40009DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private ulong uhigh64LE;
			}

			// Token: 0x020001E6 RID: 486
			[Token(Token = "0x20001E6")]
			[StructLayout(2)]
			private struct Buf24
			{
				// Token: 0x17000198 RID: 408
				// (get) Token: 0x0600118C RID: 4492 RVA: 0x0000E448 File Offset: 0x0000C648
				// (set) Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000198")]
				public ulong Low64
				{
					[Token(Token = "0x600118C")]
					[Address(RVA = "0x4D484B0", Offset = "0x4D470B0", VA = "0x184D484B0")]
					get
					{
						return 0UL;
					}
					[Token(Token = "0x600118D")]
					[Address(RVA = "0x4D485A0", Offset = "0x4D471A0", VA = "0x184D485A0")]
					set
					{
					}
				}

				// Token: 0x17000199 RID: 409
				// (set) Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000199")]
				public ulong Mid64
				{
					[Token(Token = "0x600118E")]
					[Address(RVA = "0x4D48620", Offset = "0x4D47220", VA = "0x184D48620")]
					set
					{
					}
				}

				// Token: 0x1700019A RID: 410
				// (set) Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x1700019A")]
				public ulong High64
				{
					[Token(Token = "0x600118F")]
					[Address(RVA = "0x4D48520", Offset = "0x4D47120", VA = "0x184D48520")]
					set
					{
					}
				}

				// Token: 0x040009DE RID: 2526
				[Token(Token = "0x40009DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint U0;

				// Token: 0x040009DF RID: 2527
				[Token(Token = "0x40009DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public uint U1;

				// Token: 0x040009E0 RID: 2528
				[Token(Token = "0x40009E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public uint U2;

				// Token: 0x040009E1 RID: 2529
				[Token(Token = "0x40009E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public uint U3;

				// Token: 0x040009E2 RID: 2530
				[Token(Token = "0x40009E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public uint U4;

				// Token: 0x040009E3 RID: 2531
				[Token(Token = "0x40009E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public uint U5;

				// Token: 0x040009E4 RID: 2532
				[Token(Token = "0x40009E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ulong ulo64LE;

				// Token: 0x040009E5 RID: 2533
				[Token(Token = "0x40009E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private ulong umid64LE;

				// Token: 0x040009E6 RID: 2534
				[Token(Token = "0x40009E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private ulong uhigh64LE;
			}
		}
	}
}
