using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200133F RID: 4927
	[Token(Token = "0x200133F")]
	public class SpecialOperatorDiagramData
	{
		// Token: 0x060072FC RID: 29436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FC")]
		[Address(RVA = "0x2213510", Offset = "0x2212110", VA = "0x182213510")]
		public SpecialOperatorDiagramData()
		{
		}

		// Token: 0x04006D3F RID: 27967
		[Token(Token = "0x4006D3F")]
		[FieldOffset(Offset = "0x10")]
		public float width;

		// Token: 0x04006D40 RID: 27968
		[Token(Token = "0x4006D40")]
		[FieldOffset(Offset = "0x14")]
		public float height;

		// Token: 0x04006D41 RID: 27969
		[Token(Token = "0x4006D41")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SpecialOperatorPointPosData> pointPosDataMap;

		// Token: 0x04006D42 RID: 27970
		[Token(Token = "0x4006D42")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SpecialOperatorNodePointData> nodePointDataMap;

		// Token: 0x04006D43 RID: 27971
		[Token(Token = "0x4006D43")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SpecialOperatorElitePointData> elitePointDataMap;

		// Token: 0x04006D44 RID: 27972
		[Token(Token = "0x4006D44")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, SpecialOperatorLevelPointData> levelPointDataMap;

		// Token: 0x04006D45 RID: 27973
		[Token(Token = "0x4006D45")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, SpecialOperatorLinePosData> linePosDataMap;

		// Token: 0x04006D46 RID: 27974
		[Token(Token = "0x4006D46")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, SpecialOperatorLineRelationData> lineRelationDataMap;
	}
}
