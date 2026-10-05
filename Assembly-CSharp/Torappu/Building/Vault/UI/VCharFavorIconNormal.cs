using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A90 RID: 6800
	[Token(Token = "0x2001A90")]
	public class VCharFavorIconNormal : VCharFavorIcon
	{
		// Token: 0x0600AB6B RID: 43883 RVA: 0x000424E0 File Offset: 0x000406E0
		[Token(Token = "0x600AB6B")]
		[Address(RVA = "0x32547E0", Offset = "0x32533E0", VA = "0x1832547E0", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB6C")]
		[Address(RVA = "0x3254980", Offset = "0x3253580", VA = "0x183254980", Slot = "10")]
		protected override void SendIncIntimacyService(Action onSucceed, Func<bool> onFail, Action onFinal)
		{
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB6D")]
		[Address(RVA = "0x32547D0", Offset = "0x32533D0", VA = "0x1832547D0")]
		public VCharFavorIconNormal()
		{
		}
	}
}
