using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200596D RID: 22893
	[Token(Token = "0x200596D")]
	public class CrisisV2BagDetailViewModel : IHotfixable
	{
		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x0602162C RID: 136748 RVA: 0x000BA030 File Offset: 0x000B8230
		[Token(Token = "0x17004E7B")]
		public Vector2 mapSize
		{
			[Token(Token = "0x602162C")]
			[Address(RVA = "0x1BBE580", Offset = "0x1BBD180", VA = "0x181BBE580")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x0602162D RID: 136749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E7C")]
		public Dictionary<string, CrisisV2RoadPosData> roadPosMap
		{
			[Token(Token = "0x602162D")]
			[Address(RVA = "0x1BBE6A0", Offset = "0x1BBD2A0", VA = "0x181BBE6A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x0602162E RID: 136750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E7D")]
		public Dictionary<string, CrisisV2BagPosData> bagPosMap
		{
			[Token(Token = "0x602162E")]
			[Address(RVA = "0x1BBE510", Offset = "0x1BBD110", VA = "0x181BBE510")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x0602162F RID: 136751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E7E")]
		public Dictionary<string, CrisisV2NodePosData> nodePosMap
		{
			[Token(Token = "0x602162F")]
			[Address(RVA = "0x1BBE630", Offset = "0x1BBD230", VA = "0x181BBE630")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021630 RID: 136752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021630")]
		[Address(RVA = "0x1BBE420", Offset = "0x1BBD020", VA = "0x181BBE420")]
		public void LoadData(CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x06021631 RID: 136753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021631")]
		[Address(RVA = "0x1BBE4B0", Offset = "0x1BBD0B0", VA = "0x181BBE4B0")]
		public CrisisV2BagDetailViewModel()
		{
		}

		// Token: 0x0402D884 RID: 186500
		[Token(Token = "0x402D884")]
		[FieldOffset(Offset = "0x10")]
		private CrisisV2BagViewData m_bagViewData;

		// Token: 0x0402D885 RID: 186501
		[Token(Token = "0x402D885")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mapSize;

		// Token: 0x0402D886 RID: 186502
		[Token(Token = "0x402D886")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_roadPosMap;

		// Token: 0x0402D887 RID: 186503
		[Token(Token = "0x402D887")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bagPosMap;

		// Token: 0x0402D888 RID: 186504
		[Token(Token = "0x402D888")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nodePosMap;

		// Token: 0x0402D889 RID: 186505
		[Token(Token = "0x402D889")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D88A RID: 186506
		[Token(Token = "0x402D88A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
