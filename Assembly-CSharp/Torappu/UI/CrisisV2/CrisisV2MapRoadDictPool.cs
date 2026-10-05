using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059BA RID: 22970
	[Token(Token = "0x20059BA")]
	public class CrisisV2MapRoadDictPool : GameObjectDictPool<CrisisV2MapRoadView>
	{
		// Token: 0x060217B1 RID: 137137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217B1")]
		[Address(RVA = "0x1BD5370", Offset = "0x1BD3F70", VA = "0x181BD5370")]
		public CrisisV2MapRoadDictPool(CrisisV2MapRoadDictPool.Input input)
		{
		}

		// Token: 0x060217B2 RID: 137138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217B2")]
		[Address(RVA = "0x1BD5220", Offset = "0x1BD3E20", VA = "0x181BD5220")]
		public void UpdateModel(CrisisV2MapModel mapModel)
		{
		}

		// Token: 0x060217B3 RID: 137139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217B3")]
		[Address(RVA = "0x1BD52A0", Offset = "0x1BD3EA0", VA = "0x181BD52A0")]
		private Dictionary<string, CrisisV2RoadPosData> _GetRoadPosMap()
		{
			return null;
		}

		// Token: 0x060217B4 RID: 137140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217B4")]
		[Address(RVA = "0x1BD4B70", Offset = "0x1BD3770", VA = "0x181BD4B70", Slot = "10")]
		protected override void OnAllocate(string key, CrisisV2MapRoadView obj)
		{
		}

		// Token: 0x060217B5 RID: 137141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217B5")]
		[Address(RVA = "0x1BD4E90", Offset = "0x1BD3A90", VA = "0x181BD4E90", Slot = "11")]
		protected override void OnRecycle(string key, CrisisV2MapRoadView obj)
		{
		}

		// Token: 0x060217B6 RID: 137142 RVA: 0x000BA690 File Offset: 0x000B8890
		[Token(Token = "0x60217B6")]
		[Address(RVA = "0x1BD48E0", Offset = "0x1BD34E0", VA = "0x181BD48E0", Slot = "5")]
		protected override bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x060217B7 RID: 137143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217B7")]
		[Address(RVA = "0x1BD4980", Offset = "0x1BD3580", VA = "0x181BD4980", Slot = "7")]
		protected override CrisisV2MapRoadView GetPrefab(string key)
		{
			return null;
		}

		// Token: 0x060217B8 RID: 137144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217B8")]
		[Address(RVA = "0x1BD49F0", Offset = "0x1BD35F0", VA = "0x181BD49F0", Slot = "8")]
		protected override CrisisV2MapRoadView Instantiate(string key, CrisisV2MapRoadView prefab)
		{
			return null;
		}

		// Token: 0x060217B9 RID: 137145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217B9")]
		[Address(RVA = "0x1BD4AC0", Offset = "0x1BD36C0", VA = "0x181BD4AC0", Slot = "6")]
		protected override IEnumerable<string> IterKeys()
		{
			return null;
		}

		// Token: 0x060217BA RID: 137146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217BA")]
		[Address(RVA = "0x1BD4F60", Offset = "0x1BD3B60", VA = "0x181BD4F60", Slot = "9")]
		protected override void Render(string key, CrisisV2MapRoadView obj)
		{
		}

		// Token: 0x0402DBBE RID: 187326
		[Token(Token = "0x402DBBE")]
		[FieldOffset(Offset = "0x20")]
		private CrisisV2MapModel m_mapModel;

		// Token: 0x0402DBBF RID: 187327
		[Token(Token = "0x402DBBF")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_selectContainer;

		// Token: 0x0402DBC0 RID: 187328
		[Token(Token = "0x402DBC0")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform m_unselectContainer;

		// Token: 0x0402DBC1 RID: 187329
		[Token(Token = "0x402DBC1")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2MapRoadView m_roadPrefab;

		// Token: 0x0402DBC2 RID: 187330
		[Token(Token = "0x402DBC2")]
		[FieldOffset(Offset = "0x40")]
		private CrisisV2MapModel.ViewType m_viewType;

		// Token: 0x0402DBC3 RID: 187331
		[Token(Token = "0x402DBC3")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<string> m_unselectRoadSet;

		// Token: 0x0402DBC4 RID: 187332
		[Token(Token = "0x402DBC4")]
		[FieldOffset(Offset = "0x50")]
		private HashSet<string> m_selectRoadSet;

		// Token: 0x0402DBC5 RID: 187333
		[Token(Token = "0x402DBC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402DBC6 RID: 187334
		[Token(Token = "0x402DBC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateModel;

		// Token: 0x0402DBC7 RID: 187335
		[Token(Token = "0x402DBC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetRoadPosMap;

		// Token: 0x0402DBC8 RID: 187336
		[Token(Token = "0x402DBC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0402DBC9 RID: 187337
		[Token(Token = "0x402DBC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0402DBCA RID: 187338
		[Token(Token = "0x402DBCA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ContainsKey;

		// Token: 0x0402DBCB RID: 187339
		[Token(Token = "0x402DBCB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x0402DBCC RID: 187340
		[Token(Token = "0x402DBCC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Instantiate;

		// Token: 0x0402DBCD RID: 187341
		[Token(Token = "0x402DBCD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IterKeys;

		// Token: 0x0402DBCE RID: 187342
		[Token(Token = "0x402DBCE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x020059BB RID: 22971
		[Token(Token = "0x20059BB")]
		public struct Input
		{
			// Token: 0x0402DBCF RID: 187343
			[Token(Token = "0x402DBCF")]
			[FieldOffset(Offset = "0x0")]
			public CrisisV2MapModel.ViewType viewType;

			// Token: 0x0402DBD0 RID: 187344
			[Token(Token = "0x402DBD0")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform selectRoadContainer;

			// Token: 0x0402DBD1 RID: 187345
			[Token(Token = "0x402DBD1")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform unselectRoadContainer;

			// Token: 0x0402DBD2 RID: 187346
			[Token(Token = "0x402DBD2")]
			[FieldOffset(Offset = "0x18")]
			public CrisisV2MapRoadView roadViewPrefab;
		}
	}
}
