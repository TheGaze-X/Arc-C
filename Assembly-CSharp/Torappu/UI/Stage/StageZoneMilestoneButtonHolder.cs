using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069AA RID: 27050
	[Token(Token = "0x20069AA")]
	public class StageZoneMilestoneButtonHolder : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026B5E RID: 158558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B5E")]
		[Address(RVA = "0x21C6710", Offset = "0x21C5310", VA = "0x1821C6710", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty selectedZoneProperty)
		{
		}

		// Token: 0x06026B5F RID: 158559 RVA: 0x000CC108 File Offset: 0x000CA308
		[Token(Token = "0x6026B5F")]
		[Address(RVA = "0x21C69F0", Offset = "0x21C55F0", VA = "0x1821C69F0")]
		private bool _TryLoadMilestoneButton(ZoneViewModel selectedZoneModel)
		{
			return default(bool);
		}

		// Token: 0x06026B60 RID: 158560 RVA: 0x000CC120 File Offset: 0x000CA320
		[Token(Token = "0x6026B60")]
		[Address(RVA = "0x21C6900", Offset = "0x21C5500", VA = "0x1821C6900")]
		private StageZoneMilestoneButtonBase.StageZoneMilestoneButtonType _GetMilestoneButtonType(ZoneViewModel selectedZoneModel)
		{
			return StageZoneMilestoneButtonBase.StageZoneMilestoneButtonType.NONE;
		}

		// Token: 0x06026B61 RID: 158561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B61")]
		[Address(RVA = "0x21C6860", Offset = "0x21C5460", VA = "0x1821C6860")]
		private string _GetMilestoneButtonPath(StageZoneMilestoneButtonBase.StageZoneMilestoneButtonType buttonType)
		{
			return null;
		}

		// Token: 0x06026B62 RID: 158562 RVA: 0x000CC138 File Offset: 0x000CA338
		[Token(Token = "0x6026B62")]
		[Address(RVA = "0x21C67C0", Offset = "0x21C53C0", VA = "0x1821C67C0")]
		private bool _CheckSixStarMilestoneAvail(ZoneViewModel selectedZoneModel)
		{
			return default(bool);
		}

		// Token: 0x06026B63 RID: 158563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B63")]
		[Address(RVA = "0x21C6E00", Offset = "0x21C5A00", VA = "0x1821C6E00")]
		public StageZoneMilestoneButtonHolder()
		{
		}

		// Token: 0x04036A40 RID: 223808
		[Token(Token = "0x4036A40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _zoneMilestoneRoot;

		// Token: 0x04036A41 RID: 223809
		[Token(Token = "0x4036A41")]
		[FieldOffset(Offset = "0x28")]
		private StageZoneMilestoneButtonBase m_milestoneButtonCache;

		// Token: 0x04036A42 RID: 223810
		[Token(Token = "0x4036A42")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_uiPageFinder;

		// Token: 0x04036A43 RID: 223811
		[Token(Token = "0x4036A43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036A44 RID: 223812
		[Token(Token = "0x4036A44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryLoadMilestoneButton;

		// Token: 0x04036A45 RID: 223813
		[Token(Token = "0x4036A45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetMilestoneButtonType;

		// Token: 0x04036A46 RID: 223814
		[Token(Token = "0x4036A46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetMilestoneButtonPath;

		// Token: 0x04036A47 RID: 223815
		[Token(Token = "0x4036A47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckSixStarMilestoneAvail;

		// Token: 0x04036A48 RID: 223816
		[Token(Token = "0x4036A48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
