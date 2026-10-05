using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200599A RID: 22938
	[Token(Token = "0x200599A")]
	public class CrisisV2BagDetailMapView : CrisisV2DetailMapViewBase
	{
		// Token: 0x060216F1 RID: 136945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216F1")]
		[Address(RVA = "0x1BBE230", Offset = "0x1BBCE30", VA = "0x181BBE230", Slot = "10")]
		protected override void UpdateDictPool(CrisisV2MapModel mapModel)
		{
		}

		// Token: 0x060216F2 RID: 136946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216F2")]
		[Address(RVA = "0x1BBDBE0", Offset = "0x1BBC7E0", VA = "0x181BBDBE0", Slot = "12")]
		protected override void ForceRecycleDictPool()
		{
		}

		// Token: 0x060216F3 RID: 136947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216F3")]
		[Address(RVA = "0x1BBDEF0", Offset = "0x1BBCAF0", VA = "0x181BBDEF0", Slot = "9")]
		protected override void InitDictPool()
		{
		}

		// Token: 0x060216F4 RID: 136948 RVA: 0x000BA438 File Offset: 0x000B8638
		[Token(Token = "0x60216F4")]
		[Address(RVA = "0x1BBDE90", Offset = "0x1BBCA90", VA = "0x181BBDE90", Slot = "8")]
		protected override CrisisV2MapModel.ViewType GetViewType()
		{
			return CrisisV2MapModel.ViewType.NONE;
		}

		// Token: 0x060216F5 RID: 136949 RVA: 0x000BA450 File Offset: 0x000B8650
		[Token(Token = "0x60216F5")]
		[Address(RVA = "0x1BBDCD0", Offset = "0x1BBC8D0", VA = "0x181BBDCD0", Slot = "11")]
		protected override Vector2 GetMapSize(CrisisV2MapModel mapModel)
		{
			return default(Vector2);
		}

		// Token: 0x060216F6 RID: 136950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216F6")]
		[Address(RVA = "0x1BBDB50", Offset = "0x1BBC750", VA = "0x181BBDB50")]
		public void ClosePreviewViewIfOpen()
		{
		}

		// Token: 0x060216F7 RID: 136951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216F7")]
		[Address(RVA = "0x1BBE370", Offset = "0x1BBCF70", VA = "0x181BBE370")]
		public CrisisV2BagDetailMapView()
		{
		}

		// Token: 0x0402DA0B RID: 186891
		[Token(Token = "0x402DA0B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CrisisV2MapRoadView _roadPrefab;

		// Token: 0x0402DA0C RID: 186892
		[Token(Token = "0x402DA0C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _unselectRoadContainer;

		// Token: 0x0402DA0D RID: 186893
		[Token(Token = "0x402DA0D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _selectRoadContainer;

		// Token: 0x0402DA0E RID: 186894
		[Token(Token = "0x402DA0E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CrisisV2MapRoadPointView _roadPointPrefab;

		// Token: 0x0402DA0F RID: 186895
		[Token(Token = "0x402DA0F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _unselectRoadPointContainer;

		// Token: 0x0402DA10 RID: 186896
		[Token(Token = "0x402DA10")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _selectRoadPointContainer;

		// Token: 0x0402DA11 RID: 186897
		[Token(Token = "0x402DA11")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CrisisV2MapBagView _bagPrefab;

		// Token: 0x0402DA12 RID: 186898
		[Token(Token = "0x402DA12")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _bagContainer;

		// Token: 0x0402DA13 RID: 186899
		[Token(Token = "0x402DA13")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CrisisV2MapNodeViewHolder _nodeHolderPrefab;

		// Token: 0x0402DA14 RID: 186900
		[Token(Token = "0x402DA14")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _nodeContainer;

		// Token: 0x0402DA15 RID: 186901
		[Token(Token = "0x402DA15")]
		[FieldOffset(Offset = "0xD8")]
		private CrisisV2MapRoadDictPool m_roadDictPool;

		// Token: 0x0402DA16 RID: 186902
		[Token(Token = "0x402DA16")]
		[FieldOffset(Offset = "0xE0")]
		private CrisisV2MapRoadPointDictPool m_roadPointDictPool;

		// Token: 0x0402DA17 RID: 186903
		[Token(Token = "0x402DA17")]
		[FieldOffset(Offset = "0xE8")]
		private CrisisV2BagDetailMapView.CrisisV2MapBagDictPool m_bagDictPool;

		// Token: 0x0402DA18 RID: 186904
		[Token(Token = "0x402DA18")]
		[FieldOffset(Offset = "0xF0")]
		private CrisisV2BagDetailMapView.CrisisV2MapTreasureDictPool m_treasureDictPool;

		// Token: 0x0402DA19 RID: 186905
		[Token(Token = "0x402DA19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateDictPool;

		// Token: 0x0402DA1A RID: 186906
		[Token(Token = "0x402DA1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceRecycleDictPool;

		// Token: 0x0402DA1B RID: 186907
		[Token(Token = "0x402DA1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitDictPool;

		// Token: 0x0402DA1C RID: 186908
		[Token(Token = "0x402DA1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402DA1D RID: 186909
		[Token(Token = "0x402DA1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMapSize;

		// Token: 0x0402DA1E RID: 186910
		[Token(Token = "0x402DA1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClosePreviewViewIfOpen;

		// Token: 0x0402DA1F RID: 186911
		[Token(Token = "0x402DA1F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200599B RID: 22939
		[Token(Token = "0x200599B")]
		private class CrisisV2MapTreasureDictPool : GameObjectDictPool<CrisisV2MapNodeViewHolder>
		{
			// Token: 0x060216F8 RID: 136952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60216F8")]
			[Address(RVA = "0x1BC8C30", Offset = "0x1BC7830", VA = "0x181BC8C30")]
			public CrisisV2MapTreasureDictPool(CrisisV2BagDetailMapView closure)
			{
			}

			// Token: 0x060216F9 RID: 136953 RVA: 0x000BA468 File Offset: 0x000B8668
			[Token(Token = "0x60216F9")]
			[Address(RVA = "0x1BC84F0", Offset = "0x1BC70F0", VA = "0x181BC84F0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x060216FA RID: 136954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60216FA")]
			[Address(RVA = "0x1BC85E0", Offset = "0x1BC71E0", VA = "0x181BC85E0", Slot = "7")]
			protected override CrisisV2MapNodeViewHolder GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x060216FB RID: 136955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60216FB")]
			[Address(RVA = "0x1BC8660", Offset = "0x1BC7260", VA = "0x181BC8660", Slot = "8")]
			protected override CrisisV2MapNodeViewHolder Instantiate(string key, CrisisV2MapNodeViewHolder prefab)
			{
				return null;
			}

			// Token: 0x060216FC RID: 136956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60216FC")]
			[Address(RVA = "0x1BC8740", Offset = "0x1BC7340", VA = "0x181BC8740", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x060216FD RID: 136957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60216FD")]
			[Address(RVA = "0x1BC87F0", Offset = "0x1BC73F0", VA = "0x181BC87F0", Slot = "10")]
			protected override void OnAllocate(string key, CrisisV2MapNodeViewHolder obj)
			{
			}

			// Token: 0x060216FE RID: 136958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60216FE")]
			[Address(RVA = "0x1BC89C0", Offset = "0x1BC75C0", VA = "0x181BC89C0", Slot = "9")]
			protected override void Render(string key, CrisisV2MapNodeViewHolder obj)
			{
			}

			// Token: 0x0402DA20 RID: 186912
			[Token(Token = "0x402DA20")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2BagDetailMapView m_closure;

			// Token: 0x0402DA21 RID: 186913
			[Token(Token = "0x402DA21")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DA22 RID: 186914
			[Token(Token = "0x402DA22")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402DA23 RID: 186915
			[Token(Token = "0x402DA23")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402DA24 RID: 186916
			[Token(Token = "0x402DA24")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402DA25 RID: 186917
			[Token(Token = "0x402DA25")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402DA26 RID: 186918
			[Token(Token = "0x402DA26")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0402DA27 RID: 186919
			[Token(Token = "0x402DA27")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x0200599D RID: 22941
		[Token(Token = "0x200599D")]
		private class CrisisV2MapBagDictPool : GameObjectDictPool<CrisisV2MapBagView>
		{
			// Token: 0x06021707 RID: 136967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021707")]
			[Address(RVA = "0x1BC3B10", Offset = "0x1BC2710", VA = "0x181BC3B10")]
			public CrisisV2MapBagDictPool(CrisisV2BagDetailMapView closure)
			{
			}

			// Token: 0x06021708 RID: 136968 RVA: 0x000BA498 File Offset: 0x000B8698
			[Token(Token = "0x6021708")]
			[Address(RVA = "0x1BC2EB0", Offset = "0x1BC1AB0", VA = "0x181BC2EB0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x06021709 RID: 136969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021709")]
			[Address(RVA = "0x1BC2FA0", Offset = "0x1BC1BA0", VA = "0x181BC2FA0", Slot = "7")]
			protected override CrisisV2MapBagView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0602170A RID: 136970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602170A")]
			[Address(RVA = "0x1BC3020", Offset = "0x1BC1C20", VA = "0x181BC3020", Slot = "8")]
			protected override CrisisV2MapBagView Instantiate(string key, CrisisV2MapBagView prefab)
			{
				return null;
			}

			// Token: 0x0602170B RID: 136971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602170B")]
			[Address(RVA = "0x1BC3100", Offset = "0x1BC1D00", VA = "0x181BC3100", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0602170C RID: 136972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602170C")]
			[Address(RVA = "0x1BC31B0", Offset = "0x1BC1DB0", VA = "0x181BC31B0", Slot = "10")]
			protected override void OnAllocate(string key, CrisisV2MapBagView obj)
			{
			}

			// Token: 0x0602170D RID: 136973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602170D")]
			[Address(RVA = "0x1BC3550", Offset = "0x1BC2150", VA = "0x181BC3550", Slot = "9")]
			protected override void Render(string key, CrisisV2MapBagView obj)
			{
			}

			// Token: 0x0402DA2E RID: 186926
			[Token(Token = "0x402DA2E")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2BagDetailMapView m_closure;

			// Token: 0x0402DA2F RID: 186927
			[Token(Token = "0x402DA2F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DA30 RID: 186928
			[Token(Token = "0x402DA30")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402DA31 RID: 186929
			[Token(Token = "0x402DA31")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402DA32 RID: 186930
			[Token(Token = "0x402DA32")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402DA33 RID: 186931
			[Token(Token = "0x402DA33")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402DA34 RID: 186932
			[Token(Token = "0x402DA34")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0402DA35 RID: 186933
			[Token(Token = "0x402DA35")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;
		}
	}
}
