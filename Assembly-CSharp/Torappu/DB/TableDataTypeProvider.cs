using System;
using Il2CppDummyDll;

namespace Torappu.DB
{
	// Token: 0x020016A4 RID: 5796
	[Token(Token = "0x20016A4")]
	public class TableDataTypeProvider : ITableDataType
	{
		// Token: 0x060092C5 RID: 37573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C5")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public TableDataTypeProvider(Type type)
		{
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092C6")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public Type GetDataType()
		{
			return null;
		}

		// Token: 0x04008868 RID: 34920
		[Token(Token = "0x4008868")]
		[FieldOffset(Offset = "0x10")]
		private Type m_type;
	}
}
