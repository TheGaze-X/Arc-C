using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019EA RID: 6634
	[Token(Token = "0x20019EA")]
	public class DIYFilterSubTypeModel : IHotfixable
	{
		// Token: 0x0600A689 RID: 42633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A689")]
		[Address(RVA = "0x321B310", Offset = "0x3219F10", VA = "0x18321B310")]
		public DIYFilterSubTypeModel()
		{
		}

		// Token: 0x04009E9D RID: 40605
		[Token(Token = "0x4009E9D")]
		[FieldOffset(Offset = "0x10")]
		public BuildingData.FurnitureSubType subType;

		// Token: 0x04009E9E RID: 40606
		[Token(Token = "0x4009E9E")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04009E9F RID: 40607
		[Token(Token = "0x4009E9F")]
		[FieldOffset(Offset = "0x20")]
		public bool hasTrackpoint;

		// Token: 0x04009EA0 RID: 40608
		[Token(Token = "0x4009EA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
