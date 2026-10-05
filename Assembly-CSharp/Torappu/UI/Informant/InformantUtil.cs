using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A49 RID: 19017
	[Token(Token = "0x2004A49")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class InformantUtil
	{
		// Token: 0x0601C960 RID: 117088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C960")]
		[Address(RVA = "0x161BF40", Offset = "0x161AB40", VA = "0x18161BF40")]
		public static Sprite LoadNewsIcon(string imgId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601C961 RID: 117089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C961")]
		[Address(RVA = "0x161BEA0", Offset = "0x161AAA0", VA = "0x18161BEA0")]
		public static Sprite LoadCustomerIcon(string imgId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601C962 RID: 117090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C962")]
		[Address(RVA = "0x161BE00", Offset = "0x161AA00", VA = "0x18161BE00")]
		public static Sprite LoadChoiceTabIcon(string imgId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601C963 RID: 117091 RVA: 0x000A8AE0 File Offset: 0x000A6CE0
		[Token(Token = "0x601C963")]
		[Address(RVA = "0x161BBB0", Offset = "0x161A7B0", VA = "0x18161BBB0")]
		public static int GetSingleMilestonePoint(int currPoint)
		{
			return 0;
		}

		// Token: 0x0601C964 RID: 117092 RVA: 0x000A8AF8 File Offset: 0x000A6CF8
		[Token(Token = "0x601C964")]
		[Address(RVA = "0x161BC50", Offset = "0x161A850", VA = "0x18161BC50")]
		public static int GetTotalMilestonePoint(int totalPoint)
		{
			return 0;
		}

		// Token: 0x0601C965 RID: 117093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C965")]
		[Address(RVA = "0x161BA50", Offset = "0x161A650", VA = "0x18161BA50")]
		public static string GetInformantItemCount(int count)
		{
			return null;
		}

		// Token: 0x0601C966 RID: 117094 RVA: 0x000A8B10 File Offset: 0x000A6D10
		[Token(Token = "0x601C966")]
		[Address(RVA = "0x161B9B0", Offset = "0x161A5B0", VA = "0x18161B9B0")]
		public static int GetBusinessDay(int day)
		{
			return 0;
		}

		// Token: 0x0601C967 RID: 117095 RVA: 0x000A8B28 File Offset: 0x000A6D28
		[Token(Token = "0x601C967")]
		[Address(RVA = "0x161BCF0", Offset = "0x161A8F0", VA = "0x18161BCF0")]
		public static bool IsInformantNew(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601C968 RID: 117096 RVA: 0x000A8B40 File Offset: 0x000A6D40
		[Token(Token = "0x601C968")]
		[Address(RVA = "0x161BAD0", Offset = "0x161A6D0", VA = "0x18161BAD0")]
		public static int GetInformantRound(string actId)
		{
			return 0;
		}

		// Token: 0x04025884 RID: 153732
		[Token(Token = "0x4025884")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadNewsIcon;

		// Token: 0x04025885 RID: 153733
		[Token(Token = "0x4025885")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadCustomerIcon;

		// Token: 0x04025886 RID: 153734
		[Token(Token = "0x4025886")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadChoiceTabIcon;

		// Token: 0x04025887 RID: 153735
		[Token(Token = "0x4025887")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSingleMilestonePoint;

		// Token: 0x04025888 RID: 153736
		[Token(Token = "0x4025888")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetTotalMilestonePoint;

		// Token: 0x04025889 RID: 153737
		[Token(Token = "0x4025889")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetInformantItemCount;

		// Token: 0x0402588A RID: 153738
		[Token(Token = "0x402588A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetBusinessDay;

		// Token: 0x0402588B RID: 153739
		[Token(Token = "0x402588B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsInformantNew;

		// Token: 0x0402588C RID: 153740
		[Token(Token = "0x402588C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetInformantRound;
	}
}
