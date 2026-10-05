using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068D5 RID: 26837
	[Token(Token = "0x20068D5")]
	public abstract class ActivityCustomZoneMapBasePlugin : MonoBehaviour, IActivityCustomZoneMapPlugin, IHotfixable
	{
		// Token: 0x06026743 RID: 157507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026743")]
		[Address(RVA = "0x21763B0", Offset = "0x2174FB0", VA = "0x1821763B0", Slot = "5")]
		public virtual void Render(ActivityCustomZoneMapViewModel model, bool isFastMode)
		{
		}

		// Token: 0x06026744 RID: 157508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026744")]
		[Address(RVA = "0x2176430", Offset = "0x2175030", VA = "0x182176430")]
		protected ActivityCustomZoneMapBasePlugin()
		{
		}

		// Token: 0x040362D5 RID: 221909
		[Token(Token = "0x40362D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040362D6 RID: 221910
		[Token(Token = "0x40362D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
