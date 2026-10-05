using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007153 RID: 29011
	[Token(Token = "0x2007153")]
	public class Act9D0StageMapDecor : ActivityStageSingleComponent
	{
		// Token: 0x0602930B RID: 168715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602930B")]
		[Address(RVA = "0x24A3F20", Offset = "0x24A2B20", VA = "0x1824A3F20", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602930C RID: 168716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602930C")]
		[Address(RVA = "0x24A3D70", Offset = "0x24A2970", VA = "0x1824A3D70")]
		public void EventOnShopClicked()
		{
		}

		// Token: 0x0602930D RID: 168717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602930D")]
		[Address(RVA = "0x24A40D0", Offset = "0x24A2CD0", VA = "0x1824A40D0")]
		public Act9D0StageMapDecor()
		{
		}

		// Token: 0x0602930E RID: 168718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602930E")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403AD0B RID: 240907
		[Token(Token = "0x403AD0B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act9D0CoinView _coinView;

		// Token: 0x0403AD0C RID: 240908
		[Token(Token = "0x403AD0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act9D0MapZoneGroupView _zoneGroupView;

		// Token: 0x0403AD0D RID: 240909
		[Token(Token = "0x403AD0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403AD0E RID: 240910
		[Token(Token = "0x403AD0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnShopClicked;

		// Token: 0x0403AD0F RID: 240911
		[Token(Token = "0x403AD0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
