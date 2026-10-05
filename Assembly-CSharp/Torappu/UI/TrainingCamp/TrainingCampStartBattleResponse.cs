using System;
using Il2CppDummyDll;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D17 RID: 15639
	[Token(Token = "0x2003D17")]
	public class TrainingCampStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x0601861D RID: 99869 RVA: 0x0009A428 File Offset: 0x00098628
		[Token(Token = "0x601861D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0601861E RID: 99870 RVA: 0x0009A440 File Offset: 0x00098640
		[Token(Token = "0x601861E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0601861F RID: 99871 RVA: 0x0009A458 File Offset: 0x00098658
		[Token(Token = "0x601861F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06018620 RID: 99872 RVA: 0x0009A470 File Offset: 0x00098670
		[Token(Token = "0x6018620")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x06018621 RID: 99873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018621")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public TrainingCampStartBattleResponse()
		{
		}
	}
}
