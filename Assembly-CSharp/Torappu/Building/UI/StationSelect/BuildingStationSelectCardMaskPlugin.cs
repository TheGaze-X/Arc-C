using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C7E RID: 7294
	[Token(Token = "0x2001C7E")]
	public abstract class BuildingStationSelectCardMaskPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B538 RID: 46392
		[Token(Token = "0x600B538")]
		public abstract void Init(BuildingStationSelectCharItemView cardView, StationSelectStateBean stateBean, object context);

		// Token: 0x0600B539 RID: 46393
		[Token(Token = "0x600B539")]
		public abstract void Render(StationCharViewModel cardModel);

		// Token: 0x0600B53A RID: 46394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B53A")]
		[Address(RVA = "0x32EE510", Offset = "0x32ED110", VA = "0x1832EE510")]
		protected BuildingStationSelectCardMaskPlugin()
		{
		}

		// Token: 0x0400B147 RID: 45383
		[Token(Token = "0x400B147")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
