using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020069F9 RID: 27129
	[Token(Token = "0x20069F9")]
	public class WeeklyZoneViewModel : ZoneViewModel
	{
		// Token: 0x06026CB4 RID: 158900 RVA: 0x000CC648 File Offset: 0x000CA848
		[Token(Token = "0x6026CB4")]
		[Address(RVA = "0x21DAEB0", Offset = "0x21D9AB0", VA = "0x1821DAEB0", Slot = "10")]
		public override int CompareTo(ZoneViewModel otherModel)
		{
			return 0;
		}

		// Token: 0x06026CB5 RID: 158901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CB5")]
		[Address(RVA = "0x21DB040", Offset = "0x21D9C40", VA = "0x1821DB040", Slot = "11")]
		public override void LoadExtraData(string zoneId)
		{
		}

		// Token: 0x06026CB6 RID: 158902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CB6")]
		[Address(RVA = "0x21DB1B0", Offset = "0x21D9DB0", VA = "0x1821DB1B0")]
		public WeeklyZoneViewModel()
		{
		}

		// Token: 0x04036CE7 RID: 224487
		[Token(Token = "0x4036CE7")]
		[FieldOffset(Offset = "0x90")]
		public bool isFuncUnLocked;

		// Token: 0x04036CE8 RID: 224488
		[Token(Token = "0x4036CE8")]
		[FieldOffset(Offset = "0x98")]
		public ZoneOpenDetailState todayOpenState;

		// Token: 0x04036CE9 RID: 224489
		[Token(Token = "0x4036CE9")]
		[FieldOffset(Offset = "0xA0")]
		public WeekStruct<ZoneOpenDetailState> weekOpenInfo;

		// Token: 0x04036CEA RID: 224490
		[Token(Token = "0x4036CEA")]
		[FieldOffset(Offset = "0xD8")]
		public WeeklyType weeklyType;
	}
}
