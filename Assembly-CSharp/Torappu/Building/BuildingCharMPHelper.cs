using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017F5 RID: 6133
	[Token(Token = "0x20017F5")]
	public class BuildingCharMPHelper
	{
		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06009AEA RID: 39658 RVA: 0x0003C468 File Offset: 0x0003A668
		[Token(Token = "0x170010E5")]
		public BuildingCharModel charModel
		{
			[Token(Token = "0x6009AEA")]
			[Address(RVA = "0x3151A20", Offset = "0x3150620", VA = "0x183151A20")]
			get
			{
				return default(BuildingCharModel);
			}
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEB")]
		[Address(RVA = "0x3151710", Offset = "0x3150310", VA = "0x183151710")]
		public void Reset(BuildingCharModel model)
		{
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEC")]
		[Address(RVA = "0x3151780", Offset = "0x3150380", VA = "0x183151780")]
		public void Tick()
		{
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AED")]
		[Address(RVA = "0x31517A0", Offset = "0x31503A0", VA = "0x1831517A0")]
		private void _OnTimeout()
		{
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEE")]
		[Address(RVA = "0x31517E0", Offset = "0x31503E0", VA = "0x1831517E0")]
		private void _UpdateCountDown()
		{
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AEF")]
		[Address(RVA = "0x3151910", Offset = "0x3150510", VA = "0x183151910")]
		public BuildingCharMPHelper()
		{
		}

		// Token: 0x04009148 RID: 37192
		[Token(Token = "0x4009148")]
		[FieldOffset(Offset = "0x10")]
		private CountDownTask m_countDown;

		// Token: 0x04009149 RID: 37193
		[Token(Token = "0x4009149")]
		[FieldOffset(Offset = "0x18")]
		private BuildingCharModel m_cachedModel;

		// Token: 0x0400914A RID: 37194
		[Token(Token = "0x400914A")]
		[FieldOffset(Offset = "0x90")]
		public Action onManpowerChanged;
	}
}
