using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020069BB RID: 27067
	[Token(Token = "0x20069BB")]
	public class StageZoneTabViewModel
	{
		// Token: 0x06026BCA RID: 158666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BCA")]
		[Address(RVA = "0x21D7310", Offset = "0x21D5F10", VA = "0x1821D7310")]
		public StageZoneTabViewModel()
		{
		}

		// Token: 0x04036B2B RID: 224043
		[Token(Token = "0x4036B2B")]
		[FieldOffset(Offset = "0x10")]
		public ZoneViewType type;

		// Token: 0x04036B2C RID: 224044
		[Token(Token = "0x4036B2C")]
		[FieldOffset(Offset = "0x14")]
		public bool isUnlocked;

		// Token: 0x04036B2D RID: 224045
		[Token(Token = "0x4036B2D")]
		[FieldOffset(Offset = "0x15")]
		public bool isSelected;

		// Token: 0x04036B2E RID: 224046
		[Token(Token = "0x4036B2E")]
		[FieldOffset(Offset = "0x16")]
		public bool isSysOpen;

		// Token: 0x04036B2F RID: 224047
		[Token(Token = "0x4036B2F")]
		[FieldOffset(Offset = "0x18")]
		public string timelyDropKey;
	}
}
