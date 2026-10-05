using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BD2 RID: 7122
	[Token(Token = "0x2001BD2")]
	public class BuildingWorkshopStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0600B1BC RID: 45500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1BC")]
		[Address(RVA = "0x32C73E0", Offset = "0x32C5FE0", VA = "0x1832C73E0")]
		public void LoadData(BuildingWorkshopModel workshopModel)
		{
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1BD")]
		[Address(RVA = "0x32C7560", Offset = "0x32C6160", VA = "0x1832C7560")]
		public void RefreshViewModel(bool reCalcCount = false)
		{
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x0600B1BE RID: 45502 RVA: 0x00043E78 File Offset: 0x00042078
		[Token(Token = "0x17001547")]
		public int workCount
		{
			[Token(Token = "0x600B1BE")]
			[Address(RVA = "0x32C79D0", Offset = "0x32C65D0", VA = "0x1832C79D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x00043E90 File Offset: 0x00042090
		[Token(Token = "0x600B1BF")]
		[Address(RVA = "0x32C7810", Offset = "0x32C6410", VA = "0x1832C7810")]
		public MaxCountLimitReason TryToSetWorkCount(int count)
		{
			return MaxCountLimitReason.UNKNOWN;
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1C0")]
		[Address(RVA = "0x32C7690", Offset = "0x32C6290", VA = "0x1832C7690")]
		public void SwitchItemProtect()
		{
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1C1")]
		[Address(RVA = "0x32C78E0", Offset = "0x32C64E0", VA = "0x1832C78E0")]
		public BuildingWorkshopStateBean()
		{
		}

		// Token: 0x0400AC47 RID: 44103
		[Token(Token = "0x400AC47")]
		[FieldOffset(Offset = "0x18")]
		public BuildingWorkshopProperty property;

		// Token: 0x0400AC48 RID: 44104
		[Token(Token = "0x400AC48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400AC49 RID: 44105
		[Token(Token = "0x400AC49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshViewModel;

		// Token: 0x0400AC4A RID: 44106
		[Token(Token = "0x400AC4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_workCount;

		// Token: 0x0400AC4B RID: 44107
		[Token(Token = "0x400AC4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryToSetWorkCount;

		// Token: 0x0400AC4C RID: 44108
		[Token(Token = "0x400AC4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchItemProtect;

		// Token: 0x0400AC4D RID: 44109
		[Token(Token = "0x400AC4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
