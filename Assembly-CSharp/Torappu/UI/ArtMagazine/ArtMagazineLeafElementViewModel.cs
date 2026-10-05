using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065C7 RID: 26055
	[Token(Token = "0x20065C7")]
	public class ArtMagazineLeafElementViewModel : ArtMagazineLeafItemViewModel
	{
		// Token: 0x06025715 RID: 153365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025715")]
		[Address(RVA = "0x2068880", Offset = "0x2067480", VA = "0x182068880", Slot = "4")]
		public override void LoadData(string itemId, ItemType itemType, int templateId, int leafInstId)
		{
		}

		// Token: 0x06025716 RID: 153366 RVA: 0x000C7EC0 File Offset: 0x000C60C0
		[Token(Token = "0x6025716")]
		[Address(RVA = "0x2068810", Offset = "0x2067410", VA = "0x182068810")]
		public int GetNextTemplateId()
		{
			return 0;
		}

		// Token: 0x06025717 RID: 153367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025717")]
		[Address(RVA = "0x2068750", Offset = "0x2067350", VA = "0x182068750")]
		public string GetKey()
		{
			return null;
		}

		// Token: 0x06025718 RID: 153368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025718")]
		[Address(RVA = "0x20689A0", Offset = "0x20675A0", VA = "0x1820689A0")]
		public ArtMagazineLeafElementViewModel()
		{
		}

		// Token: 0x06025719 RID: 153369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025719")]
		[Address(RVA = "0x2066660", Offset = "0x2065260", VA = "0x182066660")]
		private void <>xLuaBaseProxy_LoadData(string P0, ItemType P1, int P2, int P3)
		{
		}

		// Token: 0x040348D7 RID: 215255
		[Token(Token = "0x40348D7")]
		private const string KEY_FORMAT = "{0}_{1}";

		// Token: 0x040348D8 RID: 215256
		[Token(Token = "0x40348D8")]
		[FieldOffset(Offset = "0x40")]
		public UIItemViewModel itemViewModel;

		// Token: 0x040348D9 RID: 215257
		[Token(Token = "0x40348D9")]
		[FieldOffset(Offset = "0x48")]
		public int totalTemplateCount;

		// Token: 0x040348DA RID: 215258
		[Token(Token = "0x40348DA")]
		[FieldOffset(Offset = "0x4C")]
		public int order;

		// Token: 0x040348DB RID: 215259
		[Token(Token = "0x40348DB")]
		[FieldOffset(Offset = "0x50")]
		public int instId;

		// Token: 0x040348DC RID: 215260
		[Token(Token = "0x40348DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040348DD RID: 215261
		[Token(Token = "0x40348DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNextTemplateId;

		// Token: 0x040348DE RID: 215262
		[Token(Token = "0x40348DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetKey;

		// Token: 0x040348DF RID: 215263
		[Token(Token = "0x40348DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
