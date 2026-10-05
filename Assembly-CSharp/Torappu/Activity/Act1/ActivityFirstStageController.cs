using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B3C RID: 31548
	[Token(Token = "0x2007B3C")]
	public class ActivityFirstStageController : ActivityStageController
	{
		// Token: 0x0602C2A0 RID: 180896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2A0")]
		[Address(RVA = "0x2816A90", Offset = "0x2815690", VA = "0x182816A90", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x0602C2A1 RID: 180897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2A1")]
		[Address(RVA = "0x2816B20", Offset = "0x2815720", VA = "0x182816B20")]
		public ActivityFirstStageController()
		{
		}

		// Token: 0x0404005D RID: 262237
		[Token(Token = "0x404005D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0404005E RID: 262238
		[Token(Token = "0x404005E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007B3D RID: 31549
		[Token(Token = "0x2007B3D")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x0602C2A2 RID: 180898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C2A2")]
			[Address(RVA = "0x2818DF0", Offset = "0x28179F0", VA = "0x182818DF0", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x0602C2A3 RID: 180899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C2A3")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}
	}
}
