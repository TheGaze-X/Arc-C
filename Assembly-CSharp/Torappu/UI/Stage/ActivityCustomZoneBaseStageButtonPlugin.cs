using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068DB RID: 26843
	[Token(Token = "0x20068DB")]
	public abstract class ActivityCustomZoneBaseStageButtonPlugin : MonoBehaviour, IActivityCustomZoneStageButtonPlugin, IHotfixable
	{
		// Token: 0x06026756 RID: 157526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026756")]
		[Address(RVA = "0x21762C0", Offset = "0x2174EC0", VA = "0x1821762C0", Slot = "5")]
		public virtual void Render(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel, bool isSelected, bool isFastMode)
		{
		}

		// Token: 0x06026757 RID: 157527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026757")]
		[Address(RVA = "0x2176350", Offset = "0x2174F50", VA = "0x182176350")]
		protected ActivityCustomZoneBaseStageButtonPlugin()
		{
		}

		// Token: 0x040362EB RID: 221931
		[Token(Token = "0x40362EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040362EC RID: 221932
		[Token(Token = "0x40362EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
