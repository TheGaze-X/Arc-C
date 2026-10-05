using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	[StructLayout(2)]
	public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible
	{
		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005DB")]
		internal unsafe byte* valuePtr
		{
			[Token(Token = "0x6001576")]
			[Address(RVA = "0x5615370", Offset = "0x5613F70", VA = "0x185615370")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x170005DC")]
		public TypeCode type
		{
			[Token(Token = "0x6001577")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return TypeCode.Empty;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x170005DD")]
		public bool isEmpty
		{
			[Token(Token = "0x6001578")]
			[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x56152D0", Offset = "0x5613ED0", VA = "0x1856152D0")]
		public PrimitiveValue(bool value)
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x5615230", Offset = "0x5613E30", VA = "0x185615230")]
		public PrimitiveValue(char value)
		{
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x5615300", Offset = "0x5613F00", VA = "0x185615300")]
		public PrimitiveValue(byte value)
		{
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x5615220", Offset = "0x5613E20", VA = "0x185615220")]
		public PrimitiveValue(sbyte value)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x56152B0", Offset = "0x5613EB0", VA = "0x1856152B0")]
		public PrimitiveValue(short value)
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x5615350", Offset = "0x5613F50", VA = "0x185615350")]
		public PrimitiveValue(ushort value)
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x5615330", Offset = "0x5613F30", VA = "0x185615330")]
		public PrimitiveValue(int value)
		{
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x5615310", Offset = "0x5613F10", VA = "0x185615310")]
		public PrimitiveValue(uint value)
		{
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x5615290", Offset = "0x5613E90", VA = "0x185615290")]
		public PrimitiveValue(long value)
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x5615270", Offset = "0x5613E70", VA = "0x185615270")]
		public PrimitiveValue(ulong value)
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x5615250", Offset = "0x5613E50", VA = "0x185615250")]
		public PrimitiveValue(float value)
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x56152E0", Offset = "0x5613EE0", VA = "0x1856152E0")]
		public PrimitiveValue(double value)
		{
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x5613010", Offset = "0x5611C10", VA = "0x185613010")]
		public PrimitiveValue ConvertTo(TypeCode type)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x56132C0", Offset = "0x5611EC0", VA = "0x1856132C0", Slot = "4")]
		public bool Equals(PrimitiveValue other)
		{
			return default(bool);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x56132F0", Offset = "0x5611EF0", VA = "0x1856132F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x5615380", Offset = "0x5613F80", VA = "0x185615380")]
		public static bool operator ==(PrimitiveValue left, PrimitiveValue right)
		{
			return default(bool);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x56153C0", Offset = "0x5613FC0", VA = "0x1856153C0")]
		public static bool operator !=(PrimitiveValue left, PrimitiveValue right)
		{
			return default(bool);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x5614470", Offset = "0x5613070", VA = "0x185614470", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x5614CC0", Offset = "0x56138C0", VA = "0x185614CC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x56140D0", Offset = "0x5612CD0", VA = "0x1856140D0")]
		public static PrimitiveValue FromString(string value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "5")]
		public TypeCode GetTypeCode()
		{
			return TypeCode.Empty;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x5614510", Offset = "0x5613110", VA = "0x185614510", Slot = "6")]
		public bool ToBoolean([Optional] IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x56146F0", Offset = "0x56132F0", VA = "0x1856146F0", Slot = "9")]
		public byte ToByte([Optional] IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x5614700", Offset = "0x5613300", VA = "0x185614700", Slot = "7")]
		public char ToChar([Optional] IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x56147B0", Offset = "0x56133B0", VA = "0x1856147B0", Slot = "19")]
		public DateTime ToDateTime([Optional] IFormatProvider provider)
		{
			return default(DateTime);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x5614810", Offset = "0x5613410", VA = "0x185614810", Slot = "18")]
		public decimal ToDecimal([Optional] IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x5614850", Offset = "0x5613450", VA = "0x185614850", Slot = "17")]
		public double ToDouble([Optional] IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x56146F0", Offset = "0x56132F0", VA = "0x1856146F0", Slot = "10")]
		public short ToInt16([Optional] IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x56146F0", Offset = "0x56132F0", VA = "0x1856146F0", Slot = "12")]
		public int ToInt32([Optional] IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x5614950", Offset = "0x5613550", VA = "0x185614950", Slot = "14")]
		public long ToInt64([Optional] IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x56146F0", Offset = "0x56132F0", VA = "0x1856146F0", Slot = "8")]
		public sbyte ToSByte([Optional] IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x5614CA0", Offset = "0x56138A0", VA = "0x185614CA0", Slot = "16")]
		public float ToSingle([Optional] IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x56150A0", Offset = "0x5613CA0", VA = "0x1856150A0", Slot = "20")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x56150B0", Offset = "0x5613CB0", VA = "0x1856150B0", Slot = "21")]
		public object ToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x5615100", Offset = "0x5613D00", VA = "0x185615100", Slot = "11")]
		public ushort ToUInt16([Optional] IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x5615100", Offset = "0x5613D00", VA = "0x185615100", Slot = "13")]
		public uint ToUInt32([Optional] IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x5615110", Offset = "0x5613D10", VA = "0x185615110", Slot = "15")]
		public ulong ToUInt64([Optional] IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x56149E0", Offset = "0x56135E0", VA = "0x1856149E0")]
		public object ToObject()
		{
			return null;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x600159F")]
		public static PrimitiveValue From<TValue>(TValue value) where TValue : struct
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x5613610", Offset = "0x5612210", VA = "0x185613610")]
		public static PrimitiveValue FromObject(object value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x5613530", Offset = "0x5612130", VA = "0x185613530")]
		public static implicit operator PrimitiveValue(bool value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x5613570", Offset = "0x5612170", VA = "0x185613570")]
		public static implicit operator PrimitiveValue(char value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x5613550", Offset = "0x5612150", VA = "0x185613550")]
		public static implicit operator PrimitiveValue(byte value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x5614090", Offset = "0x5612C90", VA = "0x185614090")]
		public static implicit operator PrimitiveValue(sbyte value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x56135B0", Offset = "0x56121B0", VA = "0x1856135B0")]
		public static implicit operator PrimitiveValue(short value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x5614410", Offset = "0x5613010", VA = "0x185614410")]
		public static implicit operator PrimitiveValue(ushort value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x56135D0", Offset = "0x56121D0", VA = "0x1856135D0")]
		public static implicit operator PrimitiveValue(int value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x5614430", Offset = "0x5613030", VA = "0x185614430")]
		public static implicit operator PrimitiveValue(uint value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x56135F0", Offset = "0x56121F0", VA = "0x1856135F0")]
		public static implicit operator PrimitiveValue(long value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x5614450", Offset = "0x5613050", VA = "0x185614450")]
		public static implicit operator PrimitiveValue(ulong value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x56140B0", Offset = "0x5612CB0", VA = "0x1856140B0")]
		public static implicit operator PrimitiveValue(float value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x5613590", Offset = "0x5612190", VA = "0x185613590")]
		public static implicit operator PrimitiveValue(double value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x5613530", Offset = "0x5612130", VA = "0x185613530")]
		public static PrimitiveValue FromBoolean(bool value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x5613570", Offset = "0x5612170", VA = "0x185613570")]
		public static PrimitiveValue FromChar(char value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x5613550", Offset = "0x5612150", VA = "0x185613550")]
		public static PrimitiveValue FromByte(byte value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0000BA30 File Offset: 0x00009C30
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x5614090", Offset = "0x5612C90", VA = "0x185614090")]
		public static PrimitiveValue FromSByte(sbyte value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x56135B0", Offset = "0x56121B0", VA = "0x1856135B0")]
		public static PrimitiveValue FromInt16(short value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x5614410", Offset = "0x5613010", VA = "0x185614410")]
		public static PrimitiveValue FromUInt16(ushort value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x56135D0", Offset = "0x56121D0", VA = "0x1856135D0")]
		public static PrimitiveValue FromInt32(int value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x5614430", Offset = "0x5613030", VA = "0x185614430")]
		public static PrimitiveValue FromUInt32(uint value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x56135F0", Offset = "0x56121F0", VA = "0x1856135F0")]
		public static PrimitiveValue FromInt64(long value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x5614450", Offset = "0x5613050", VA = "0x185614450")]
		public static PrimitiveValue FromUInt64(ulong value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x56140B0", Offset = "0x5612CB0", VA = "0x1856140B0")]
		public static PrimitiveValue FromSingle(float value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x5613590", Offset = "0x5612190", VA = "0x185613590")]
		public static PrimitiveValue FromDouble(double value)
		{
			return default(PrimitiveValue);
		}

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TypeCode m_Type;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private bool m_BoolValue;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private char m_CharValue;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private byte m_ByteValue;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private sbyte m_SByteValue;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private short m_ShortValue;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private ushort m_UShortValue;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int m_IntValue;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint m_UIntValue;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private long m_LongValue;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private ulong m_ULongValue;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private float m_FloatValue;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private double m_DoubleValue;
	}
}
