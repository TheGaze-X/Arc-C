using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E0 RID: 24800
	[Token(Token = "0x20060E0")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CampaignUtil
	{
		// Token: 0x06023D93 RID: 146835 RVA: 0x000C23D0 File Offset: 0x000C05D0
		[Token(Token = "0x6023D93")]
		[Address(RVA = "0x1E77AC0", Offset = "0x1E766C0", VA = "0x181E77AC0")]
		public static bool IsPointInBounds(Vector2 point, Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x06023D94 RID: 146836 RVA: 0x000C23E8 File Offset: 0x000C05E8
		[Token(Token = "0x6023D94")]
		[Address(RVA = "0x1E77950", Offset = "0x1E76550", VA = "0x181E77950")]
		public static bool IntersectScreen(Vector2 p1, Vector2 p2, out Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06023D95 RID: 146837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D95")]
		[Address(RVA = "0x1E778D0", Offset = "0x1E764D0", VA = "0x181E778D0")]
		public static string GetCachedRotateStageId()
		{
			return null;
		}

		// Token: 0x06023D96 RID: 146838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D96")]
		[Address(RVA = "0x1E77D40", Offset = "0x1E76940", VA = "0x181E77D40")]
		public static void SetCachedRotateStageId(string stageId)
		{
		}

		// Token: 0x06023D97 RID: 146839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D97")]
		[Address(RVA = "0x1E77850", Offset = "0x1E76450", VA = "0x181E77850")]
		public static string GetCachedBriefId()
		{
			return null;
		}

		// Token: 0x06023D98 RID: 146840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D98")]
		[Address(RVA = "0x1E77CB0", Offset = "0x1E768B0", VA = "0x181E77CB0")]
		public static void SetCachedBriefId(string briefId)
		{
		}

		// Token: 0x06023D99 RID: 146841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D99")]
		[Address(RVA = "0x1E77BD0", Offset = "0x1E767D0", VA = "0x181E77BD0")]
		public static Sprite LoadWorldMapPiece(string pieceId)
		{
			return null;
		}

		// Token: 0x06023D9A RID: 146842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D9A")]
		[Address(RVA = "0x1E77C40", Offset = "0x1E76840", VA = "0x181E77C40")]
		public static Sprite LoadZoneIcon(string zoneId)
		{
			return null;
		}

		// Token: 0x06023D9B RID: 146843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D9B")]
		[Address(RVA = "0x1E77DD0", Offset = "0x1E769D0", VA = "0x181E77DD0")]
		private static Sprite _LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x04031B62 RID: 203618
		[Token(Token = "0x4031B62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsPointInBounds;

		// Token: 0x04031B63 RID: 203619
		[Token(Token = "0x4031B63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IntersectScreen;

		// Token: 0x04031B64 RID: 203620
		[Token(Token = "0x4031B64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCachedRotateStageId;

		// Token: 0x04031B65 RID: 203621
		[Token(Token = "0x4031B65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetCachedRotateStageId;

		// Token: 0x04031B66 RID: 203622
		[Token(Token = "0x4031B66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCachedBriefId;

		// Token: 0x04031B67 RID: 203623
		[Token(Token = "0x4031B67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetCachedBriefId;

		// Token: 0x04031B68 RID: 203624
		[Token(Token = "0x4031B68")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadWorldMapPiece;

		// Token: 0x04031B69 RID: 203625
		[Token(Token = "0x4031B69")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadZoneIcon;

		// Token: 0x04031B6A RID: 203626
		[Token(Token = "0x4031B6A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;
	}
}
