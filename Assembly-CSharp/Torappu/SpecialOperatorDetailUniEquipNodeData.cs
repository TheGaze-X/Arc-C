using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200133D RID: 4925
	[Token(Token = "0x200133D")]
	public class SpecialOperatorDetailUniEquipNodeData
	{
		// Token: 0x060072FA RID: 29434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialOperatorDetailUniEquipNodeData()
		{
		}

		// Token: 0x04006D3B RID: 27963
		[Token(Token = "0x4006D3B")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04006D3C RID: 27964
		[Token(Token = "0x4006D3C")]
		[FieldOffset(Offset = "0x18")]
		public string uniEquipId;

		// Token: 0x04006D3D RID: 27965
		[Token(Token = "0x4006D3D")]
		[FieldOffset(Offset = "0x20")]
		public int equipLevel;
	}
}
