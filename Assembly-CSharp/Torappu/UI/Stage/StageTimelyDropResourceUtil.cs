using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006803 RID: 26627
	[Token(Token = "0x2006803")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public static class StageTimelyDropResourceUtil
	{
		// Token: 0x0602627E RID: 156286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602627E")]
		[Address(RVA = "0x213DFF0", Offset = "0x213CBF0", VA = "0x18213DFF0")]
		public static GameObject GetZoneSelectTimelyDropItem(string dropGroupId)
		{
			return null;
		}

		// Token: 0x0602627F RID: 156287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602627F")]
		[Address(RVA = "0x213DE10", Offset = "0x213CA10", VA = "0x18213DE10")]
		public static GameObject GetDropPicTimelyDropItem(string dropGroupId)
		{
			return null;
		}

		// Token: 0x06026280 RID: 156288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026280")]
		[Address(RVA = "0x213DEF0", Offset = "0x213CAF0", VA = "0x18213DEF0")]
		public static GameObject GetStagePicTimelyDropItem(string dropGroupId)
		{
			return null;
		}

		// Token: 0x06026281 RID: 156289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026281")]
		[Address(RVA = "0x213DE80", Offset = "0x213CA80", VA = "0x18213DE80")]
		public static GameObject GetStagePicTimelyDropAndApProtectItem(string dropGroupId)
		{
			return null;
		}

		// Token: 0x06026282 RID: 156290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026282")]
		[Address(RVA = "0x213DF60", Offset = "0x213CB60", VA = "0x18213DF60")]
		public static StageTimelyDropStyle GetStageTimelyDropStyle(string dropGroupId)
		{
			return null;
		}

		// Token: 0x06026283 RID: 156291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026283")]
		private static T _GetTimelyDropAssetImpl<T>(string dropGroupId, TimelyDropAssetType assetType) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x04035BD5 RID: 220117
		[Token(Token = "0x4035BD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetZoneSelectTimelyDropItem;

		// Token: 0x04035BD6 RID: 220118
		[Token(Token = "0x4035BD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDropPicTimelyDropItem;

		// Token: 0x04035BD7 RID: 220119
		[Token(Token = "0x4035BD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetStagePicTimelyDropItem;

		// Token: 0x04035BD8 RID: 220120
		[Token(Token = "0x4035BD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStagePicTimelyDropAndApProtectItem;

		// Token: 0x04035BD9 RID: 220121
		[Token(Token = "0x4035BD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetStageTimelyDropStyle;

		// Token: 0x04035BDA RID: 220122
		[Token(Token = "0x4035BDA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTimelyDropAssetImpl;
	}
}
