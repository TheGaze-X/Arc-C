using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059BD RID: 22973
	[Token(Token = "0x20059BD")]
	public class CrisisV2MapRoadPointDictPool : GameObjectDictPool<CrisisV2MapRoadPointView>
	{
		// Token: 0x060217C4 RID: 137156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217C4")]
		[Address(RVA = "0x1BD6080", Offset = "0x1BD4C80", VA = "0x181BD6080")]
		public CrisisV2MapRoadPointDictPool(CrisisV2MapRoadPointDictPool.Input input)
		{
		}

		// Token: 0x060217C5 RID: 137157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217C5")]
		[Address(RVA = "0x1BD5F30", Offset = "0x1BD4B30", VA = "0x181BD5F30")]
		public void UpdateModel(CrisisV2MapModel mapModel)
		{
		}

		// Token: 0x060217C6 RID: 137158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217C6")]
		[Address(RVA = "0x1BD5FB0", Offset = "0x1BD4BB0", VA = "0x181BD5FB0")]
		private Dictionary<string, CrisisV2RoadPosData> _GetRoadPosMap()
		{
			return null;
		}

		// Token: 0x060217C7 RID: 137159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217C7")]
		[Address(RVA = "0x1BD5790", Offset = "0x1BD4390", VA = "0x181BD5790", Slot = "10")]
		protected override void OnAllocate(string key, CrisisV2MapRoadPointView obj)
		{
		}

		// Token: 0x060217C8 RID: 137160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217C8")]
		[Address(RVA = "0x1BD5A90", Offset = "0x1BD4690", VA = "0x181BD5A90", Slot = "11")]
		protected override void OnRecycle(string key, CrisisV2MapRoadPointView obj)
		{
		}

		// Token: 0x060217C9 RID: 137161 RVA: 0x000BA6C0 File Offset: 0x000B88C0
		[Token(Token = "0x60217C9")]
		[Address(RVA = "0x1BD5500", Offset = "0x1BD4100", VA = "0x181BD5500", Slot = "5")]
		protected override bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x060217CA RID: 137162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217CA")]
		[Address(RVA = "0x1BD55A0", Offset = "0x1BD41A0", VA = "0x181BD55A0", Slot = "7")]
		protected override CrisisV2MapRoadPointView GetPrefab(string key)
		{
			return null;
		}

		// Token: 0x060217CB RID: 137163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217CB")]
		[Address(RVA = "0x1BD5610", Offset = "0x1BD4210", VA = "0x181BD5610", Slot = "8")]
		protected override CrisisV2MapRoadPointView Instantiate(string key, CrisisV2MapRoadPointView prefab)
		{
			return null;
		}

		// Token: 0x060217CC RID: 137164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217CC")]
		[Address(RVA = "0x1BD56E0", Offset = "0x1BD42E0", VA = "0x181BD56E0", Slot = "6")]
		protected override IEnumerable<string> IterKeys()
		{
			return null;
		}

		// Token: 0x060217CD RID: 137165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217CD")]
		[Address(RVA = "0x1BD5B60", Offset = "0x1BD4760", VA = "0x181BD5B60", Slot = "9")]
		protected override void Render(string key, CrisisV2MapRoadPointView obj)
		{
		}

		// Token: 0x0402DBD8 RID: 187352
		[Token(Token = "0x402DBD8")]
		[FieldOffset(Offset = "0x20")]
		private CrisisV2MapModel m_mapModel;

		// Token: 0x0402DBD9 RID: 187353
		[Token(Token = "0x402DBD9")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_selectContainer;

		// Token: 0x0402DBDA RID: 187354
		[Token(Token = "0x402DBDA")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform m_unselectContainer;

		// Token: 0x0402DBDB RID: 187355
		[Token(Token = "0x402DBDB")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2MapRoadPointView m_pointPrefab;

		// Token: 0x0402DBDC RID: 187356
		[Token(Token = "0x402DBDC")]
		[FieldOffset(Offset = "0x40")]
		private CrisisV2MapModel.ViewType m_viewType;

		// Token: 0x0402DBDD RID: 187357
		[Token(Token = "0x402DBDD")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<string> m_unselectRoadSet;

		// Token: 0x0402DBDE RID: 187358
		[Token(Token = "0x402DBDE")]
		[FieldOffset(Offset = "0x50")]
		private HashSet<string> m_selectRoadSet;

		// Token: 0x0402DBDF RID: 187359
		[Token(Token = "0x402DBDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402DBE0 RID: 187360
		[Token(Token = "0x402DBE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateModel;

		// Token: 0x0402DBE1 RID: 187361
		[Token(Token = "0x402DBE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetRoadPosMap;

		// Token: 0x0402DBE2 RID: 187362
		[Token(Token = "0x402DBE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0402DBE3 RID: 187363
		[Token(Token = "0x402DBE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0402DBE4 RID: 187364
		[Token(Token = "0x402DBE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ContainsKey;

		// Token: 0x0402DBE5 RID: 187365
		[Token(Token = "0x402DBE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x0402DBE6 RID: 187366
		[Token(Token = "0x402DBE6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Instantiate;

		// Token: 0x0402DBE7 RID: 187367
		[Token(Token = "0x402DBE7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IterKeys;

		// Token: 0x0402DBE8 RID: 187368
		[Token(Token = "0x402DBE8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x020059BE RID: 22974
		[Token(Token = "0x20059BE")]
		public struct Input
		{
			// Token: 0x0402DBE9 RID: 187369
			[Token(Token = "0x402DBE9")]
			[FieldOffset(Offset = "0x0")]
			public CrisisV2MapModel.ViewType viewType;

			// Token: 0x0402DBEA RID: 187370
			[Token(Token = "0x402DBEA")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform selectPointContainer;

			// Token: 0x0402DBEB RID: 187371
			[Token(Token = "0x402DBEB")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform unselectPointContainer;

			// Token: 0x0402DBEC RID: 187372
			[Token(Token = "0x402DBEC")]
			[FieldOffset(Offset = "0x18")]
			public CrisisV2MapRoadPointView pointViewPrefab;
		}
	}
}
