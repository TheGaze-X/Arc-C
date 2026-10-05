using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BD3 RID: 7123
	[Token(Token = "0x2001BD3")]
	public class BuildingWorkshopWholeViewModel : IHotfixable
	{
		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x0600B1C2 RID: 45506 RVA: 0x00043EA8 File Offset: 0x000420A8
		// (set) Token: 0x0600B1C3 RID: 45507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001548")]
		public int workCount
		{
			[Token(Token = "0x600B1C2")]
			[Address(RVA = "0x32C7D40", Offset = "0x32C6940", VA = "0x1832C7D40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B1C3")]
			[Address(RVA = "0x32C7DA0", Offset = "0x32C69A0", VA = "0x1832C7DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x00043EC0 File Offset: 0x000420C0
		[Token(Token = "0x600B1C4")]
		[Address(RVA = "0x32C7B90", Offset = "0x32C6790", VA = "0x1832C7B90")]
		public MaxCountLimitReason TryToSetWorkCount(int targetCount)
		{
			return MaxCountLimitReason.UNKNOWN;
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x00043ED8 File Offset: 0x000420D8
		[Token(Token = "0x600B1C5")]
		[Address(RVA = "0x32C7A90", Offset = "0x32C6690", VA = "0x1832C7A90")]
		public bool CheckIfNeedProtectPanel()
		{
			return default(bool);
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1C6")]
		[Address(RVA = "0x32C7CE0", Offset = "0x32C68E0", VA = "0x1832C7CE0")]
		public BuildingWorkshopWholeViewModel()
		{
		}

		// Token: 0x0400AC4E RID: 44110
		[Token(Token = "0x400AC4E")]
		[FieldOffset(Offset = "0x10")]
		public BuildingWorkshopModel workshopModel;

		// Token: 0x0400AC50 RID: 44112
		[Token(Token = "0x400AC50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_workCount;

		// Token: 0x0400AC51 RID: 44113
		[Token(Token = "0x400AC51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_workCount;

		// Token: 0x0400AC52 RID: 44114
		[Token(Token = "0x400AC52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryToSetWorkCount;

		// Token: 0x0400AC53 RID: 44115
		[Token(Token = "0x400AC53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfNeedProtectPanel;

		// Token: 0x0400AC54 RID: 44116
		[Token(Token = "0x400AC54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
