using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;

namespace Torappu.UI.ActivityStage.Extern
{
	// Token: 0x02006D23 RID: 27939
	[Token(Token = "0x2006D23")]
	public class ActivityZoneViewModel : ZoneViewModel
	{
		// Token: 0x06027D89 RID: 163209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D89")]
		[Address(RVA = "0x22F70B0", Offset = "0x22F5CB0", VA = "0x1822F70B0", Slot = "11")]
		public override void LoadExtraData(string zoneId)
		{
		}

		// Token: 0x06027D8A RID: 163210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D8A")]
		[Address(RVA = "0x21DB1B0", Offset = "0x21D9DB0", VA = "0x1821DB1B0")]
		public ActivityZoneViewModel()
		{
		}

		// Token: 0x040387A8 RID: 231336
		[Token(Token = "0x40387A8")]
		[FieldOffset(Offset = "0x90")]
		public string activityId;

		// Token: 0x040387A9 RID: 231337
		[Token(Token = "0x40387A9")]
		[FieldOffset(Offset = "0x98")]
		public bool isRetroUnlocked;
	}
}
