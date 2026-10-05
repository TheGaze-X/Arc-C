using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005C6 RID: 1478
	[Token(Token = "0x20005C6")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/HandbookTeamTable")]
	[Serializable]
	public class HandbookTeamDB : SimpleKVTable<HandbookTeamData, HandbookTeamDB>
	{
		// Token: 0x06006146 RID: 24902 RVA: 0x0002FA48 File Offset: 0x0002DC48
		[Token(Token = "0x6006146")]
		[Address(RVA = "0x1DEDFD0", Offset = "0x1DECBD0", VA = "0x181DEDFD0")]
		public bool TryGetTeamSort(string powerId, out int teamSort)
		{
			return default(bool);
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x0002FA60 File Offset: 0x0002DC60
		[Token(Token = "0x6006147")]
		[Address(RVA = "0x1DEDF10", Offset = "0x1DECB10", VA = "0x181DEDF10")]
		public bool IsTeamIconRaw(string powerId)
		{
			return default(bool);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x0002FA78 File Offset: 0x0002DC78
		[Token(Token = "0x6006148")]
		[Address(RVA = "0x1DEDE30", Offset = "0x1DECA30", VA = "0x181DEDE30")]
		public static Color GetColor(string colorString)
		{
			return default(Color);
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006149")]
		[Address(RVA = "0x1DEE0B0", Offset = "0x1DECCB0", VA = "0x181DEE0B0")]
		public HandbookTeamDB()
		{
		}

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		public const string DEFAULT_POWER_ID = "none";

		// Token: 0x04002ADF RID: 10975
		[Token(Token = "0x4002ADF")]
		public const string RHODES_ID = "rhodes";

		// Token: 0x04002AE0 RID: 10976
		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetTeamSort;

		// Token: 0x04002AE1 RID: 10977
		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsTeamIconRaw;

		// Token: 0x04002AE2 RID: 10978
		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetColor;

		// Token: 0x04002AE3 RID: 10979
		[Token(Token = "0x4002AE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020005C7 RID: 1479
		[Token(Token = "0x20005C7")]
		public enum PowerLevel
		{
			// Token: 0x04002AE5 RID: 10981
			[Token(Token = "0x4002AE5")]
			Nation,
			// Token: 0x04002AE6 RID: 10982
			[Token(Token = "0x4002AE6")]
			Group,
			// Token: 0x04002AE7 RID: 10983
			[Token(Token = "0x4002AE7")]
			Team
		}
	}
}
