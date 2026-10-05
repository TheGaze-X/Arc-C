using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CBA RID: 23738
	[Token(Token = "0x2005CBA")]
	public abstract class ClimbTowerTowerLayerStackAdapter : IHotfixable
	{
		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x060225A6 RID: 140710
		[Token(Token = "0x170050B6")]
		public abstract List<ClimbTowerLevelModel> data { [Token(Token = "0x60225A6")] get; }

		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x060225A7 RID: 140711
		[Token(Token = "0x170050B7")]
		public abstract string selectedItem { [Token(Token = "0x60225A7")] get; }

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x060225A8 RID: 140712
		[Token(Token = "0x170050B8")]
		public abstract int arrowIndex { [Token(Token = "0x60225A8")] get; }

		// Token: 0x060225A9 RID: 140713
		[Token(Token = "0x60225A9")]
		public abstract bool IsLevelPassed(ClimbTowerLevelModel levelModel);

		// Token: 0x060225AA RID: 140714
		[Token(Token = "0x60225AA")]
		public abstract bool IsHardMode();

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x060225AB RID: 140715
		[Token(Token = "0x170050B9")]
		public abstract int subCardStageSortBefore { [Token(Token = "0x60225AB")] get; }

		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x060225AC RID: 140716
		[Token(Token = "0x170050BA")]
		public abstract bool hasSelectedSubCard { [Token(Token = "0x60225AC")] get; }

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x060225AD RID: 140717
		[Token(Token = "0x170050BB")]
		public abstract ClimbTowerTowerLayerBaseSelectArrow selectArrowPrefab { [Token(Token = "0x60225AD")] get; }

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x060225AE RID: 140718
		[Token(Token = "0x170050BC")]
		public abstract ClimbTowerTowerLayerBaseGodCardTips godCardTipsPrefab { [Token(Token = "0x60225AE")] get; }

		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x060225AF RID: 140719 RVA: 0x000BD1E0 File Offset: 0x000BB3E0
		[Token(Token = "0x170050BD")]
		public int count
		{
			[Token(Token = "0x60225AF")]
			[Address(RVA = "0x1CD8EB0", Offset = "0x1CD7AB0", VA = "0x181CD8EB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060225B0 RID: 140720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225B0")]
		[Address(RVA = "0x1CD89A0", Offset = "0x1CD75A0", VA = "0x181CD89A0")]
		public void NotifyDataSetConstructed()
		{
		}

		// Token: 0x060225B1 RID: 140721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225B1")]
		[Address(RVA = "0x1CD8A10", Offset = "0x1CD7610", VA = "0x181CD8A10")]
		public void NotifyDataSetUpdated()
		{
		}

		// Token: 0x060225B2 RID: 140722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225B2")]
		[Address(RVA = "0x1CD8C10", Offset = "0x1CD7810", VA = "0x181CD8C10")]
		public void UpdateViewInstance(int position, ClimbTowerTowerLayerStackAdapter.ClimbTowerLayerCardVirtualView view)
		{
		}

		// Token: 0x060225B3 RID: 140723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225B3")]
		[Address(RVA = "0x1CD88F0", Offset = "0x1CD74F0", VA = "0x181CD88F0")]
		public ClimbTowerTowerLayerStackAdapter.ClimbTowerLayerCardVirtualView GetView(int position)
		{
			return null;
		}

		// Token: 0x060225B4 RID: 140724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225B4")]
		[Address(RVA = "0x1CD8510", Offset = "0x1CD7110", VA = "0x181CD8510")]
		public void CleanView()
		{
		}

		// Token: 0x060225B5 RID: 140725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225B5")]
		[Address(RVA = "0x1CD86A0", Offset = "0x1CD72A0", VA = "0x181CD86A0")]
		public ClimbTowerLayerCard ConstructView(int position, ClimbTowerLayerCard prefabNormal, ClimbTowerLayerCard prefabSpecial, ClimbTowerLayerCard prefabBoss, Transform parent)
		{
			return null;
		}

		// Token: 0x060225B6 RID: 140726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225B6")]
		[Address(RVA = "0x1CD8A80", Offset = "0x1CD7680", VA = "0x181CD8A80")]
		public void RenderView(int position)
		{
		}

		// Token: 0x060225B7 RID: 140727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225B7")]
		[Address(RVA = "0x1CD8E00", Offset = "0x1CD7A00", VA = "0x181CD8E00")]
		protected ClimbTowerTowerLayerStackAdapter()
		{
		}

		// Token: 0x0402F356 RID: 193366
		[Token(Token = "0x402F356")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerTowerLayerStackAdapter.ClimbTowerLayerCardVirtualView> m_views;

		// Token: 0x0402F357 RID: 193367
		[Token(Token = "0x402F357")]
		[FieldOffset(Offset = "0x18")]
		public Action<ClimbTowerTowerLayerStackAdapter> constructObserver;

		// Token: 0x0402F358 RID: 193368
		[Token(Token = "0x402F358")]
		[FieldOffset(Offset = "0x20")]
		public Action<ClimbTowerTowerLayerStackAdapter> updateObserver;

		// Token: 0x0402F359 RID: 193369
		[Token(Token = "0x402F359")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402F35A RID: 193370
		[Token(Token = "0x402F35A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyDataSetConstructed;

		// Token: 0x0402F35B RID: 193371
		[Token(Token = "0x402F35B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyDataSetUpdated;

		// Token: 0x0402F35C RID: 193372
		[Token(Token = "0x402F35C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateViewInstance;

		// Token: 0x0402F35D RID: 193373
		[Token(Token = "0x402F35D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetView;

		// Token: 0x0402F35E RID: 193374
		[Token(Token = "0x402F35E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CleanView;

		// Token: 0x0402F35F RID: 193375
		[Token(Token = "0x402F35F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConstructView;

		// Token: 0x0402F360 RID: 193376
		[Token(Token = "0x402F360")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402F361 RID: 193377
		[Token(Token = "0x402F361")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CBB RID: 23739
		[Token(Token = "0x2005CBB")]
		public class ClimbTowerLayerCardVirtualView
		{
			// Token: 0x060225B8 RID: 140728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60225B8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClimbTowerLayerCardVirtualView()
			{
			}

			// Token: 0x0402F362 RID: 193378
			[Token(Token = "0x402F362")]
			[FieldOffset(Offset = "0x10")]
			public float posOnAxis;

			// Token: 0x0402F363 RID: 193379
			[Token(Token = "0x402F363")]
			[FieldOffset(Offset = "0x14")]
			public float sizeOnAxis;

			// Token: 0x0402F364 RID: 193380
			[Token(Token = "0x402F364")]
			[FieldOffset(Offset = "0x18")]
			public float arrowOffsetOnAxis;

			// Token: 0x0402F365 RID: 193381
			[Token(Token = "0x402F365")]
			[FieldOffset(Offset = "0x20")]
			public ClimbTowerLayerCard viewObj;
		}
	}
}
