using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200044B RID: 1099
	[Token(Token = "0x200044B")]
	[System.Serializable]
	internal sealed class SizedArray : System.ICloneable
	{
		// Token: 0x060021D8 RID: 8664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D8")]
		[Address(RVA = "0x4BC5C60", Offset = "0x4BC4860", VA = "0x184BC5C60")]
		internal SizedArray()
		{
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D9")]
		[Address(RVA = "0x4BC5CE0", Offset = "0x4BC48E0", VA = "0x184BC5CE0")]
		internal SizedArray(int length)
		{
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DA")]
		[Address(RVA = "0x4BC5D60", Offset = "0x4BC4960", VA = "0x184BC5D60")]
		private SizedArray(SizedArray sizedArray)
		{
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021DB")]
		[Address(RVA = "0x4BC5970", Offset = "0x4BC4570", VA = "0x184BC5970", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x17000463 RID: 1123
		[Token(Token = "0x17000463")]
		internal object this[int index]
		{
			[Token(Token = "0x60021DC")]
			[Address(RVA = "0x4BC5E40", Offset = "0x4BC4A40", VA = "0x184BC5E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021DD")]
			[Address(RVA = "0x4BC5EB0", Offset = "0x4BC4AB0", VA = "0x184BC5EB0")]
			set
			{
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x4BC5A90", Offset = "0x4BC4690", VA = "0x184BC5A90")]
		internal void IncreaseCapacity(int index)
		{
		}

		// Token: 0x040012D7 RID: 4823
		[Token(Token = "0x40012D7")]
		[FieldOffset(Offset = "0x10")]
		internal object[] objects;

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		[FieldOffset(Offset = "0x18")]
		internal object[] negObjects;
	}
}
