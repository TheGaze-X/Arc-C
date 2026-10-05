using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x0200681C RID: 26652
	[Token(Token = "0x200681C")]
	public struct StageSideStoryZoneTabPluginShowParams : IHotfixable
	{
		// Token: 0x04035CAA RID: 220330
		[Token(Token = "0x4035CAA")]
		[FieldOffset(Offset = "0x0")]
		public ZoneViewModel model;

		// Token: 0x04035CAB RID: 220331
		[Token(Token = "0x4035CAB")]
		[FieldOffset(Offset = "0x8")]
		public string selectedZoneId;
	}
}
