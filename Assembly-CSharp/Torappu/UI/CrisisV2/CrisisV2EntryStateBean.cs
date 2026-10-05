using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005951 RID: 22865
	[Token(Token = "0x2005951")]
	public class CrisisV2EntryStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06021532 RID: 136498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021532")]
		[Address(RVA = "0x1BA2710", Offset = "0x1BA1310", VA = "0x181BA2710")]
		public void InitData()
		{
		}

		// Token: 0x06021533 RID: 136499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021533")]
		[Address(RVA = "0x1BA2E70", Offset = "0x1BA1A70", VA = "0x181BA2E70")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06021534 RID: 136500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021534")]
		[Address(RVA = "0x1BA27E0", Offset = "0x1BA13E0", VA = "0x181BA27E0")]
		public void InitServerData(CrisisV2CacheServerData data)
		{
		}

		// Token: 0x06021535 RID: 136501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021535")]
		[Address(RVA = "0x1BA2660", Offset = "0x1BA1260", VA = "0x181BA2660")]
		public string GetPermStageId()
		{
			return null;
		}

		// Token: 0x06021536 RID: 136502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021536")]
		[Address(RVA = "0x1BA30C0", Offset = "0x1BA1CC0", VA = "0x181BA30C0")]
		public CrisisV2EntryStateBean()
		{
		}

		// Token: 0x0402D717 RID: 186135
		[Token(Token = "0x402D717")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public CrisisV2EntryProperty property;

		// Token: 0x0402D718 RID: 186136
		[Token(Token = "0x402D718")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402D719 RID: 186137
		[Token(Token = "0x402D719")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0402D71A RID: 186138
		[Token(Token = "0x402D71A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitServerData;

		// Token: 0x0402D71B RID: 186139
		[Token(Token = "0x402D71B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPermStageId;

		// Token: 0x0402D71C RID: 186140
		[Token(Token = "0x402D71C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
