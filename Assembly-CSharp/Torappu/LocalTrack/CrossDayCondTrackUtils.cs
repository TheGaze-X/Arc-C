using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200209C RID: 8348
	[Token(Token = "0x200209C")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CrossDayCondTrackUtils
	{
		// Token: 0x0600CD89 RID: 52617 RVA: 0x0004A178 File Offset: 0x00048378
		[Token(Token = "0x600CD89")]
		[Address(RVA = "0x34FC430", Offset = "0x34FB030", VA = "0x1834FC430")]
		public static bool CheckCrossDayCondTrackTypeInAct(string typeId)
		{
			return default(bool);
		}

		// Token: 0x0600CD8A RID: 52618 RVA: 0x0004A190 File Offset: 0x00048390
		[Token(Token = "0x600CD8A")]
		[Address(RVA = "0x34FC300", Offset = "0x34FAF00", VA = "0x1834FC300")]
		public static bool CheckCrossDayCondTrackInAct(string actId, string id)
		{
			return default(bool);
		}

		// Token: 0x0600CD8B RID: 52619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD8B")]
		[Address(RVA = "0x34FC5F0", Offset = "0x34FB1F0", VA = "0x1834FC5F0")]
		public static void ConsumeCrossDayCondTrackTypeInAct(string typeId)
		{
		}

		// Token: 0x0600CD8C RID: 52620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD8C")]
		[Address(RVA = "0x34FC4D0", Offset = "0x34FB0D0", VA = "0x1834FC4D0")]
		public static void ConsumeCrossDayCondTrackInAct(string actId, string id)
		{
		}

		// Token: 0x0600CD8D RID: 52621 RVA: 0x0004A1A8 File Offset: 0x000483A8
		[Token(Token = "0x600CD8D")]
		[Address(RVA = "0x34FC690", Offset = "0x34FB290", VA = "0x1834FC690")]
		public static bool ConsumeCrossDayTypeTrackIfExpired(CrossDayTrackTypeData typeData, long nowPlayerRefreshTs)
		{
			return default(bool);
		}

		// Token: 0x0600CD8E RID: 52622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD8E")]
		[Address(RVA = "0x34FC760", Offset = "0x34FB360", VA = "0x1834FC760")]
		private static List<string> _GetTypesFromActId(string actId)
		{
			return null;
		}

		// Token: 0x0400D8DA RID: 55514
		[Token(Token = "0x400D8DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckCrossDayCondTrackTypeInAct;

		// Token: 0x0400D8DB RID: 55515
		[Token(Token = "0x400D8DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckCrossDayCondTrackInAct;

		// Token: 0x0400D8DC RID: 55516
		[Token(Token = "0x400D8DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConsumeCrossDayCondTrackTypeInAct;

		// Token: 0x0400D8DD RID: 55517
		[Token(Token = "0x400D8DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ConsumeCrossDayCondTrackInAct;

		// Token: 0x0400D8DE RID: 55518
		[Token(Token = "0x400D8DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeCrossDayTypeTrackIfExpired;

		// Token: 0x0400D8DF RID: 55519
		[Token(Token = "0x400D8DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTypesFromActId;
	}
}
