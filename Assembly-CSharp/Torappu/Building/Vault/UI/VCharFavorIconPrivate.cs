using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A92 RID: 6802
	[Token(Token = "0x2001A92")]
	public class VCharFavorIconPrivate : VCharFavorIcon
	{
		// Token: 0x0600AB71 RID: 43889 RVA: 0x00042510 File Offset: 0x00040710
		[Token(Token = "0x600AB71")]
		[Address(RVA = "0x3254BC0", Offset = "0x32537C0", VA = "0x183254BC0", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB72 RID: 43890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB72")]
		[Address(RVA = "0x3254D20", Offset = "0x3253920", VA = "0x183254D20", Slot = "10")]
		protected override void SendIncIntimacyService(Action onSucceed, Func<bool> onFail, Action onFinal)
		{
		}

		// Token: 0x0600AB73 RID: 43891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB73")]
		[Address(RVA = "0x32547D0", Offset = "0x32533D0", VA = "0x1832547D0")]
		public VCharFavorIconPrivate()
		{
		}
	}
}
