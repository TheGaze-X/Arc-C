using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D1 RID: 1489
	[Token(Token = "0x20005D1")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/RetroDB")]
	[Serializable]
	public class RetroDB : ConstTable<RetroStageTable, RetroDB>
	{
		// Token: 0x06006165 RID: 24933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006165")]
		[Address(RVA = "0x1DF0FB0", Offset = "0x1DEFBB0", VA = "0x181DF0FB0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006166")]
		[Address(RVA = "0x1DF0EB0", Offset = "0x1DEFAB0", VA = "0x181DF0EB0")]
		public string GetRetroIdByZoneId(string zoneId)
		{
			return null;
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006167")]
		[Address(RVA = "0x1DF0D40", Offset = "0x1DEF940", VA = "0x181DF0D40")]
		public RetroActData GetActInfoNullable(string retroId)
		{
			return null;
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006168")]
		[Address(RVA = "0x1DF0E20", Offset = "0x1DEFA20", VA = "0x181DF0E20")]
		public string GetRetroIdByActId(string actId)
		{
			return null;
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006169")]
		[Address(RVA = "0x1DF1480", Offset = "0x1DF0080", VA = "0x181DF1480")]
		private static void _FlushLevelsToDefault(RetroStageTable stageTable)
		{
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616A")]
		[Address(RVA = "0x1DF1610", Offset = "0x1DF0210", VA = "0x181DF1610")]
		public RetroDB()
		{
		}

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, string> m_actToRetroMap;

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRetroIdByZoneId;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActInfoNullable;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRetroIdByActId;

		// Token: 0x04002B0C RID: 11020
		[Token(Token = "0x4002B0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FlushLevelsToDefault;

		// Token: 0x04002B0D RID: 11021
		[Token(Token = "0x4002B0D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
