using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public static class LineBuilder
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x0000611C File Offset: 0x0000431C
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x5521880", Offset = "0x5520480", VA = "0x185521880")]
		public static float StoreLineData(LineBuilderData lineData, Matrix4x4 toCam, List<Vector3> inVertices, float maxWidth)
		{
			return 0f;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00006134 File Offset: 0x00004334
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x5521520", Offset = "0x5520120", VA = "0x185521520")]
		public static Vector2 Calculate2DLineExtrusion(Vector3 p0, Vector3 delta)
		{
			return default(Vector2);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000614C File Offset: 0x0000434C
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x5521610", Offset = "0x5520210", VA = "0x185521610")]
		public static Vector2 LineIntersection(Vector2 p0, Vector2 p1, float maxWidthScalar)
		{
			return default(Vector2);
		}
	}
}
