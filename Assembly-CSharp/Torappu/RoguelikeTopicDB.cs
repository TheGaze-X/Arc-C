using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D3 RID: 1491
	[Token(Token = "0x20005D3")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/RoguelikeTopicDB")]
	[Serializable]
	public class RoguelikeTopicDB : ConstTable<RoguelikeTopicTable, RoguelikeTopicDB>
	{
		// Token: 0x0600616C RID: 24940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616C")]
		[Address(RVA = "0x1DF2320", Offset = "0x1DF0F20", VA = "0x181DF2320", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600616D")]
		[Address(RVA = "0x1DF1F60", Offset = "0x1DF0B60", VA = "0x181DF1F60")]
		public string GetItemIcon(string itemId)
		{
			return null;
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		[Token(Token = "0x600616E")]
		[Address(RVA = "0x1DF2970", Offset = "0x1DF1570", VA = "0x181DF2970")]
		public static bool TryGetArchiveCompData(string topicId, out RoguelikeArchiveComponentData compData)
		{
			return default(bool);
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
		[Token(Token = "0x600616F")]
		[Address(RVA = "0x1DF2A80", Offset = "0x1DF1680", VA = "0x181DF2A80")]
		public static bool TryGetItem(string topicId, string itemId, out RoguelikeTopicItemModel item)
		{
			return default(bool);
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x0002FB08 File Offset: 0x0002DD08
		[Token(Token = "0x6006170")]
		[Address(RVA = "0x1DF3000", Offset = "0x1DF1C00", VA = "0x181DF3000")]
		public static bool TryGetTask(string topicId, string taskId, out RoguelikeTaskData taskData)
		{
			return default(bool);
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006171")]
		[Address(RVA = "0x1DF1B10", Offset = "0x1DF0710", VA = "0x181DF1B10")]
		public static ActArchiveChatGroupData GetArchiveChatGroupOrDetail(string topicId, string teamId)
		{
			return null;
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x0002FB20 File Offset: 0x0002DD20
		[Token(Token = "0x6006172")]
		[Address(RVA = "0x1DF2180", Offset = "0x1DF0D80", VA = "0x181DF2180")]
		public static long GetPrevNearestMonthRefreshTimeData(string topicId, long timestamp)
		{
			return 0L;
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x0002FB38 File Offset: 0x0002DD38
		[Token(Token = "0x6006173")]
		[Address(RVA = "0x1DF2030", Offset = "0x1DF0C30", VA = "0x181DF2030")]
		public static long GetOpenTimeByEnrollId(string topicId, string enrollId)
		{
			return 0L;
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x0002FB50 File Offset: 0x0002DD50
		[Token(Token = "0x6006174")]
		[Address(RVA = "0x1DF1C40", Offset = "0x1DF0840", VA = "0x181DF1C40")]
		public static long GetEndTimeByEnrollId(string topicId, string enrollId)
		{
			return 0L;
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x0002FB68 File Offset: 0x0002DD68
		[Token(Token = "0x6006175")]
		[Address(RVA = "0x1DF1E20", Offset = "0x1DF0A20", VA = "0x181DF1E20")]
		public static RoguelikeEnrollType GetEnrollTypeByEnrollId(string topicId, string enrollId)
		{
			return RoguelikeEnrollType.DLC;
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x0002FB80 File Offset: 0x0002DD80
		[Token(Token = "0x6006176")]
		[Address(RVA = "0x1DF1750", Offset = "0x1DF0350", VA = "0x181DF1750")]
		public static bool CheckIfInEnrollByType(string topicId, RoguelikeEnrollType enrollType)
		{
			return default(bool);
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006177")]
		[Address(RVA = "0x1DF3140", Offset = "0x1DF1D40", VA = "0x181DF3140")]
		public RoguelikeTopicDB()
		{
		}

		// Token: 0x04002B0F RID: 11023
		[Token(Token = "0x4002B0F")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, string> m_itemId2ItemIcon;

		// Token: 0x04002B10 RID: 11024
		[Token(Token = "0x4002B10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B11 RID: 11025
		[Token(Token = "0x4002B11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetItemIcon;

		// Token: 0x04002B12 RID: 11026
		[Token(Token = "0x4002B12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetArchiveCompData;

		// Token: 0x04002B13 RID: 11027
		[Token(Token = "0x4002B13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetItem;

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetTask;

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetArchiveChatGroupOrDetail;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPrevNearestMonthRefreshTimeData;

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetOpenTimeByEnrollId;

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEndTimeByEnrollId;

		// Token: 0x04002B19 RID: 11033
		[Token(Token = "0x4002B19")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEnrollTypeByEnrollId;

		// Token: 0x04002B1A RID: 11034
		[Token(Token = "0x4002B1A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfInEnrollByType;

		// Token: 0x04002B1B RID: 11035
		[Token(Token = "0x4002B1B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
