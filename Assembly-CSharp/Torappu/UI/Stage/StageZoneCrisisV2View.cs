using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200693E RID: 26942
	[Token(Token = "0x200693E")]
	public class StageZoneCrisisV2View : StageZoneSeasonEntryItem<CrisisV2ZoneEntryModel>
	{
		// Token: 0x06026941 RID: 158017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026941")]
		[Address(RVA = "0x21B8910", Offset = "0x21B7510", VA = "0x1821B8910", Slot = "4")]
		public override void Render(CrisisV2ZoneEntryModel crisisEntryModel)
		{
		}

		// Token: 0x06026942 RID: 158018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026942")]
		[Address(RVA = "0x21B8790", Offset = "0x21B7390", VA = "0x1821B8790")]
		public void OpenCrisisAchivePage()
		{
		}

		// Token: 0x06026943 RID: 158019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026943")]
		[Address(RVA = "0x21B8890", Offset = "0x21B7490", VA = "0x1821B8890")]
		public void OpenCrisisShopPage()
		{
		}

		// Token: 0x06026944 RID: 158020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026944")]
		[Address(RVA = "0x21B8810", Offset = "0x21B7410", VA = "0x1821B8810")]
		public void OpenCrisisMapPage()
		{
		}

		// Token: 0x06026945 RID: 158021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026945")]
		[Address(RVA = "0x21B8AB0", Offset = "0x21B76B0", VA = "0x1821B8AB0")]
		public StageZoneCrisisV2View()
		{
		}

		// Token: 0x040366C0 RID: 222912
		[Token(Token = "0x40366C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("CrisisV2")]
		private GameObject _unAvailPart;

		// Token: 0x040366C1 RID: 222913
		[Token(Token = "0x40366C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("CrisisV2")]
		private GameObject _availPart;

		// Token: 0x040366C2 RID: 222914
		[Token(Token = "0x40366C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("CrisisV2")]
		private StageZoneCrisisV2AvailPanel _availPanel;

		// Token: 0x040366C3 RID: 222915
		[Token(Token = "0x40366C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("CrisisV2")]
		private Text _shopCoin;

		// Token: 0x040366C4 RID: 222916
		[Token(Token = "0x40366C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("CrisisV2")]
		private Text _shopItemName;

		// Token: 0x040366C5 RID: 222917
		[Token(Token = "0x40366C5")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isCrisisInited;

		// Token: 0x040366C6 RID: 222918
		[Token(Token = "0x40366C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040366C7 RID: 222919
		[Token(Token = "0x40366C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenCrisisAchivePage;

		// Token: 0x040366C8 RID: 222920
		[Token(Token = "0x40366C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenCrisisShopPage;

		// Token: 0x040366C9 RID: 222921
		[Token(Token = "0x40366C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenCrisisMapPage;

		// Token: 0x040366CA RID: 222922
		[Token(Token = "0x40366CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
