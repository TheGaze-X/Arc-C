using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000CAA RID: 3242
	[Token(Token = "0x2000CAA")]
	public class Act1VHalfIdleDiagramData
	{
		// Token: 0x06006989 RID: 27017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006989")]
		[Address(RVA = "0x1FF3690", Offset = "0x1FF2290", VA = "0x181FF3690")]
		public Act1VHalfIdleDiagramData()
		{
		}

		// Token: 0x04004232 RID: 16946
		[Token(Token = "0x4004232")]
		[FieldOffset(Offset = "0x10")]
		public float width;

		// Token: 0x04004233 RID: 16947
		[Token(Token = "0x4004233")]
		[FieldOffset(Offset = "0x14")]
		public float height;

		// Token: 0x04004234 RID: 16948
		[Token(Token = "0x4004234")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act1VHalfIdleDiagramData.PointPosData> pointPosDataMap;

		// Token: 0x04004235 RID: 16949
		[Token(Token = "0x4004235")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act1VHalfIdleDiagramData.LinePosData> linePosDataMap;

		// Token: 0x04004236 RID: 16950
		[Token(Token = "0x4004236")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act1VHalfIdleDiagramData.LineRelationData> lineRelationDataMap;

		// Token: 0x04004237 RID: 16951
		[Token(Token = "0x4004237")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act1VHalfIdleDiagramData.NodePointData> nodePointDataMap;

		// Token: 0x02000CAB RID: 3243
		[Token(Token = "0x2000CAB")]
		public class PointPosData
		{
			// Token: 0x0600698A RID: 27018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600698A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PointPosData()
			{
			}

			// Token: 0x04004238 RID: 16952
			[Token(Token = "0x4004238")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 pos;
		}

		// Token: 0x02000CAC RID: 3244
		[Token(Token = "0x2000CAC")]
		public class LinePosData
		{
			// Token: 0x0600698B RID: 27019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600698B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LinePosData()
			{
			}

			// Token: 0x04004239 RID: 16953
			[Token(Token = "0x4004239")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 startPos;

			// Token: 0x0400423A RID: 16954
			[Token(Token = "0x400423A")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 endPos;
		}

		// Token: 0x02000CAD RID: 3245
		[Token(Token = "0x2000CAD")]
		public class LineRelationData
		{
			// Token: 0x0600698C RID: 27020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600698C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LineRelationData()
			{
			}

			// Token: 0x0400423B RID: 16955
			[Token(Token = "0x400423B")]
			[FieldOffset(Offset = "0x10")]
			public List<string> startPointList;

			// Token: 0x0400423C RID: 16956
			[Token(Token = "0x400423C")]
			[FieldOffset(Offset = "0x18")]
			public List<string> endPointList;
		}

		// Token: 0x02000CAE RID: 3246
		[Token(Token = "0x2000CAE")]
		public class NodePointData
		{
			// Token: 0x0600698D RID: 27021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600698D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NodePointData()
			{
			}

			// Token: 0x0400423D RID: 16957
			[Token(Token = "0x400423D")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;
		}
	}
}
