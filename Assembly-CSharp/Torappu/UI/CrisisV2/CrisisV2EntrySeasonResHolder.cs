using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005909 RID: 22793
	[Token(Token = "0x2005909")]
	public class CrisisV2EntrySeasonResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602136D RID: 136045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602136D")]
		[Address(RVA = "0x1B8FEB0", Offset = "0x1B8EAB0", VA = "0x181B8FEB0")]
		public Sprite GetHomeEntry()
		{
			return null;
		}

		// Token: 0x0602136E RID: 136046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602136E")]
		[Address(RVA = "0x1B8FE50", Offset = "0x1B8EA50", VA = "0x181B8FE50")]
		public Sprite GetHomeEntryMultiMode()
		{
			return null;
		}

		// Token: 0x0602136F RID: 136047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602136F")]
		[Address(RVA = "0x1B8FF10", Offset = "0x1B8EB10", VA = "0x181B8FF10")]
		public Sprite GetZoneHomeDailySprite()
		{
			return null;
		}

		// Token: 0x06021370 RID: 136048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021370")]
		[Address(RVA = "0x1B8FF70", Offset = "0x1B8EB70", VA = "0x181B8FF70")]
		public CrisisV2EntrySeasonResHolder()
		{
		}

		// Token: 0x0402D3DA RID: 185306
		[Token(Token = "0x402D3DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeEntry;

		// Token: 0x0402D3DB RID: 185307
		[Token(Token = "0x402D3DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeEntryMultiMode;

		// Token: 0x0402D3DC RID: 185308
		[Token(Token = "0x402D3DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _zoneHomeDaily;

		// Token: 0x0402D3DD RID: 185309
		[Token(Token = "0x402D3DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHomeEntry;

		// Token: 0x0402D3DE RID: 185310
		[Token(Token = "0x402D3DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetHomeEntryMultiMode;

		// Token: 0x0402D3DF RID: 185311
		[Token(Token = "0x402D3DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetZoneHomeDailySprite;

		// Token: 0x0402D3E0 RID: 185312
		[Token(Token = "0x402D3E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
