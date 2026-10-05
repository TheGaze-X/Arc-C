using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CA5 RID: 27813
	[Token(Token = "0x2006CA5")]
	public abstract class TemplateActivityViewModel : IHotfixable
	{
		// Token: 0x17005DB9 RID: 23993
		// (get) Token: 0x06027AD9 RID: 162521 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027ADA RID: 162522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005DB9")]
		public string activityId
		{
			[Token(Token = "0x6027AD9")]
			[Address(RVA = "0x22E8AE0", Offset = "0x22E76E0", VA = "0x1822E8AE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6027ADA")]
			[Address(RVA = "0x22E8B80", Offset = "0x22E7780", VA = "0x1822E8B80")]
			set
			{
			}
		}

		// Token: 0x06027ADB RID: 162523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ADB")]
		[Address(RVA = "0x22E8A50", Offset = "0x22E7650", VA = "0x1822E8A50")]
		public TemplateActivityViewModel(object param)
		{
		}

		// Token: 0x04038460 RID: 230496
		[Token(Token = "0x4038460")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x04038461 RID: 230497
		[Token(Token = "0x4038461")]
		[FieldOffset(Offset = "0x18")]
		public Action NotifyDataUpdate;

		// Token: 0x04038462 RID: 230498
		[Token(Token = "0x4038462")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04038463 RID: 230499
		[Token(Token = "0x4038463")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x04038464 RID: 230500
		[Token(Token = "0x4038464")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
