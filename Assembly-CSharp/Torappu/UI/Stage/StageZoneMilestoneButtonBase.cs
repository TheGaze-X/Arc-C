using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069A8 RID: 27048
	[Token(Token = "0x20069A8")]
	public abstract class StageZoneMilestoneButtonBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B6A RID: 23402
		// (get) Token: 0x06026B5B RID: 158555
		[Token(Token = "0x17005B6A")]
		public abstract StageZoneMilestoneButtonBase.StageZoneMilestoneButtonType buttonType { [Token(Token = "0x6026B5B")] get; }

		// Token: 0x06026B5C RID: 158556
		[Token(Token = "0x6026B5C")]
		public abstract void Render(ZoneViewModel selectedZoneModel);

		// Token: 0x06026B5D RID: 158557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B5D")]
		[Address(RVA = "0x21C66B0", Offset = "0x21C52B0", VA = "0x1821C66B0")]
		protected StageZoneMilestoneButtonBase()
		{
		}

		// Token: 0x04036A3C RID: 223804
		[Token(Token = "0x4036A3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069A9 RID: 27049
		[Token(Token = "0x20069A9")]
		public enum StageZoneMilestoneButtonType
		{
			// Token: 0x04036A3E RID: 223806
			[Token(Token = "0x4036A3E")]
			NONE,
			// Token: 0x04036A3F RID: 223807
			[Token(Token = "0x4036A3F")]
			SIX_STAR
		}
	}
}
