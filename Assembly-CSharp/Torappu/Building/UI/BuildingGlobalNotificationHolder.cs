using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B19 RID: 6937
	[Token(Token = "0x2001B19")]
	public class BuildingGlobalNotificationHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AE")]
		public BuildingManufactGainNotify manufactNotifyView
		{
			[Token(Token = "0x600AEB6")]
			[Address(RVA = "0x3290A30", Offset = "0x328F630", VA = "0x183290A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600AEB7 RID: 44727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AF")]
		public BuildingWorkshopBySideNotify workshopBySideNotify
		{
			[Token(Token = "0x600AEB7")]
			[Address(RVA = "0x3290B50", Offset = "0x328F750", VA = "0x183290B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B0")]
		public BuildingLeveldownReturnNotify leveldownReturnNotify
		{
			[Token(Token = "0x600AEB8")]
			[Address(RVA = "0x32909D0", Offset = "0x328F5D0", VA = "0x1832909D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600AEB9 RID: 44729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B1")]
		public BuildingFavorNotifyView favorNotify
		{
			[Token(Token = "0x600AEB9")]
			[Address(RVA = "0x3290970", Offset = "0x328F570", VA = "0x183290970")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B2")]
		public BuildingTradingDeliveryNotify tradingNotifyView
		{
			[Token(Token = "0x600AEBA")]
			[Address(RVA = "0x3290AF0", Offset = "0x328F6F0", VA = "0x183290AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x0600AEBB RID: 44731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B3")]
		public BuildingManufactSupplementNotify manufatcSuppleView
		{
			[Token(Token = "0x600AEBB")]
			[Address(RVA = "0x3290A90", Offset = "0x328F690", VA = "0x183290A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B4")]
		public BuildingBatchToastView batchToastView
		{
			[Token(Token = "0x600AEBC")]
			[Address(RVA = "0x3290910", Offset = "0x328F510", VA = "0x183290910")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEBD")]
		[Address(RVA = "0x32908B0", Offset = "0x328F4B0", VA = "0x1832908B0")]
		public BuildingGlobalNotificationHolder()
		{
		}

		// Token: 0x0400A7B5 RID: 42933
		[Token(Token = "0x400A7B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingManufactGainNotify _manufactNotify;

		// Token: 0x0400A7B6 RID: 42934
		[Token(Token = "0x400A7B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingWorkshopBySideNotify _workshopBySideNotify;

		// Token: 0x0400A7B7 RID: 42935
		[Token(Token = "0x400A7B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingLeveldownReturnNotify _leveldownReturnNotify;

		// Token: 0x0400A7B8 RID: 42936
		[Token(Token = "0x400A7B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingFavorNotifyView _favorNotify;

		// Token: 0x0400A7B9 RID: 42937
		[Token(Token = "0x400A7B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingTradingDeliveryNotify _tradingNotify;

		// Token: 0x0400A7BA RID: 42938
		[Token(Token = "0x400A7BA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingManufactSupplementNotify _supplementNotify;

		// Token: 0x0400A7BB RID: 42939
		[Token(Token = "0x400A7BB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuildingBatchToastView _batchToast;

		// Token: 0x0400A7BC RID: 42940
		[Token(Token = "0x400A7BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_manufactNotifyView;

		// Token: 0x0400A7BD RID: 42941
		[Token(Token = "0x400A7BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_workshopBySideNotify;

		// Token: 0x0400A7BE RID: 42942
		[Token(Token = "0x400A7BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_leveldownReturnNotify;

		// Token: 0x0400A7BF RID: 42943
		[Token(Token = "0x400A7BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_favorNotify;

		// Token: 0x0400A7C0 RID: 42944
		[Token(Token = "0x400A7C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tradingNotifyView;

		// Token: 0x0400A7C1 RID: 42945
		[Token(Token = "0x400A7C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_manufatcSuppleView;

		// Token: 0x0400A7C2 RID: 42946
		[Token(Token = "0x400A7C2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_batchToastView;

		// Token: 0x0400A7C3 RID: 42947
		[Token(Token = "0x400A7C3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
