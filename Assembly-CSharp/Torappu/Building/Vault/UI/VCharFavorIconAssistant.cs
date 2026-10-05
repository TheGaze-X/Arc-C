using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A8E RID: 6798
	[Token(Token = "0x2001A8E")]
	public class VCharFavorIconAssistant : VCharFavorIcon
	{
		// Token: 0x0600AB65 RID: 43877 RVA: 0x000424B0 File Offset: 0x000406B0
		[Token(Token = "0x600AB65")]
		[Address(RVA = "0x32543E0", Offset = "0x3252FE0", VA = "0x1832543E0", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB66")]
		[Address(RVA = "0x3254590", Offset = "0x3253190", VA = "0x183254590", Slot = "10")]
		protected override void SendIncIntimacyService(Action onSucceed, Func<bool> onFail, Action onFinal)
		{
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB67")]
		[Address(RVA = "0x32547D0", Offset = "0x32533D0", VA = "0x1832547D0")]
		public VCharFavorIconAssistant()
		{
		}
	}
}
