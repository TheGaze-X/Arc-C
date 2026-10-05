using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200044C RID: 1100
	[Token(Token = "0x200044C")]
	[System.Serializable]
	internal sealed class IntSizedArray : System.ICloneable
	{
		// Token: 0x060021DF RID: 8671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DF")]
		[Address(RVA = "0x4BB5A70", Offset = "0x4BB4670", VA = "0x184BB5A70")]
		public IntSizedArray()
		{
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E0")]
		[Address(RVA = "0x4BB5940", Offset = "0x4BB4540", VA = "0x184BB5940")]
		private IntSizedArray(IntSizedArray sizedArray)
		{
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021E1")]
		[Address(RVA = "0x4BB5610", Offset = "0x4BB4210", VA = "0x184BB5610", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x17000464 RID: 1124
		[Token(Token = "0x17000464")]
		internal int this[int index]
		{
			[Token(Token = "0x60021E2")]
			[Address(RVA = "0x4BB5AF0", Offset = "0x4BB46F0", VA = "0x184BB5AF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021E3")]
			[Address(RVA = "0x4BB5B60", Offset = "0x4BB4760", VA = "0x184BB5B60")]
			set
			{
			}
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E4")]
		[Address(RVA = "0x4BB5770", Offset = "0x4BB4370", VA = "0x184BB5770")]
		internal void IncreaseCapacity(int index)
		{
		}

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		[FieldOffset(Offset = "0x10")]
		internal int[] objects;

		// Token: 0x040012DA RID: 4826
		[Token(Token = "0x40012DA")]
		[FieldOffset(Offset = "0x18")]
		internal int[] negObjects;
	}
}
