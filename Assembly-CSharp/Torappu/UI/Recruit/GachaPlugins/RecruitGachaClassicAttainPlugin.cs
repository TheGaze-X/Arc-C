using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit.GachaPlugins
{
	// Token: 0x02004773 RID: 18291
	[Token(Token = "0x2004773")]
	public class RecruitGachaClassicAttainPlugin : RecruitGachaItemPlugin
	{
		// Token: 0x0601BB1A RID: 113434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB1A")]
		[Address(RVA = "0x15159D0", Offset = "0x15145D0", VA = "0x1815159D0", Slot = "4")]
		protected override void OnRefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BB1B RID: 113435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB1B")]
		[Address(RVA = "0x1515B30", Offset = "0x1514730", VA = "0x181515B30")]
		public RecruitGachaClassicAttainPlugin()
		{
		}

		// Token: 0x04023FC9 RID: 147401
		[Token(Token = "0x4023FC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _classicGachaObj;

		// Token: 0x04023FCA RID: 147402
		[Token(Token = "0x4023FCA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _classicGachaTenObj;

		// Token: 0x04023FCB RID: 147403
		[Token(Token = "0x4023FCB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _classicGachaBatchedTenObj;

		// Token: 0x04023FCC RID: 147404
		[Token(Token = "0x4023FCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023FCD RID: 147405
		[Token(Token = "0x4023FCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
