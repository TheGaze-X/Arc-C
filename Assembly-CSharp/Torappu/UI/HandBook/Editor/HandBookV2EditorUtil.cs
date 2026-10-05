using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x0200673E RID: 26430
	[Token(Token = "0x200673E")]
	public static class HandBookV2EditorUtil
	{
		// Token: 0x06025E8B RID: 155275 RVA: 0x000C9678 File Offset: 0x000C7878
		[Token(Token = "0x6025E8B")]
		[Address(RVA = "0x20D2060", Offset = "0x20D0C60", VA = "0x1820D2060")]
		public static Vector2 RoundToUnit(Vector2 pos)
		{
			return default(Vector2);
		}

		// Token: 0x06025E8C RID: 155276 RVA: 0x000C9690 File Offset: 0x000C7890
		[Token(Token = "0x6025E8C")]
		[Address(RVA = "0x20D2040", Offset = "0x20D0C40", VA = "0x1820D2040")]
		public static bool IsInHexRange(Vector2 origin, Vector2 target)
		{
			return default(bool);
		}

		// Token: 0x06025E8D RID: 155277 RVA: 0x000C96A8 File Offset: 0x000C78A8
		[Token(Token = "0x6025E8D")]
		[Address(RVA = "0x20D1E30", Offset = "0x20D0A30", VA = "0x1820D1E30")]
		public static bool AlmostEqual(Vector2 v1, Vector2 v2, float precision)
		{
			return default(bool);
		}

		// Token: 0x06025E8E RID: 155278 RVA: 0x000C96C0 File Offset: 0x000C78C0
		[Token(Token = "0x6025E8E")]
		[Address(RVA = "0x20D2110", Offset = "0x20D0D10", VA = "0x1820D2110")]
		public static float Round(float value, int digits)
		{
			return 0f;
		}

		// Token: 0x06025E8F RID: 155279 RVA: 0x000C96D8 File Offset: 0x000C78D8
		[Token(Token = "0x6025E8F")]
		[Address(RVA = "0x20D20C0", Offset = "0x20D0CC0", VA = "0x1820D20C0")]
		public static Vector2 Round(Vector2 value, int digits)
		{
			return default(Vector2);
		}

		// Token: 0x06025E90 RID: 155280 RVA: 0x000C96F0 File Offset: 0x000C78F0
		[Token(Token = "0x6025E90")]
		[Address(RVA = "0x20D1FD0", Offset = "0x20D0BD0", VA = "0x1820D1FD0")]
		public static HexagonDirection GetOtherDirection(HexagonDirection direction)
		{
			return HexagonDirection.TOP_LEFT;
		}

		// Token: 0x06025E91 RID: 155281 RVA: 0x000C9708 File Offset: 0x000C7908
		[Token(Token = "0x6025E91")]
		[Address(RVA = "0x20D1E80", Offset = "0x20D0A80", VA = "0x1820D1E80")]
		public static Vector2 GetAdjacentPos(Vector2 origin, HexagonDirection direction)
		{
			return default(Vector2);
		}

		// Token: 0x040354E2 RID: 218338
		[Token(Token = "0x40354E2")]
		public const float WIDTH_UNIT = 25f;

		// Token: 0x040354E3 RID: 218339
		[Token(Token = "0x40354E3")]
		public const float HEIGHT_UNIT = 43.3f;
	}
}
