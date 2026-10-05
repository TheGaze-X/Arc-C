using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F9E RID: 16286
	[Token(Token = "0x2003F9E")]
	public class SiracusaMapZoneInfoViewModel : IHotfixable
	{
		// Token: 0x06019425 RID: 103461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019425")]
		[Address(RVA = "0x11F4A70", Offset = "0x11F3670", VA = "0x1811F4A70")]
		public SiracusaMapZoneInfoViewModel()
		{
		}

		// Token: 0x0401F5B5 RID: 128437
		[Token(Token = "0x401F5B5")]
		[FieldOffset(Offset = "0x10")]
		public bool isTimeout;

		// Token: 0x0401F5B6 RID: 128438
		[Token(Token = "0x401F5B6")]
		[FieldOffset(Offset = "0x11")]
		public bool isTimeLocked;

		// Token: 0x0401F5B7 RID: 128439
		[Token(Token = "0x401F5B7")]
		[FieldOffset(Offset = "0x18")]
		public Act21SideData.ZoneAddtionData zoneAdditionData;

		// Token: 0x0401F5B8 RID: 128440
		[Token(Token = "0x401F5B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
