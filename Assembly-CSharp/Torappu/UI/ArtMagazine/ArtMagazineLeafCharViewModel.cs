using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065C6 RID: 26054
	[Token(Token = "0x20065C6")]
	public class ArtMagazineLeafCharViewModel : ArtMagazineLeafItemViewModel
	{
		// Token: 0x06025710 RID: 153360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025710")]
		[Address(RVA = "0x20663B0", Offset = "0x2064FB0", VA = "0x1820663B0", Slot = "4")]
		public override void LoadData(string itemId, ItemType itemType, int templateId, int leafInstId)
		{
		}

		// Token: 0x06025711 RID: 153361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025711")]
		[Address(RVA = "0x2066310", Offset = "0x2064F10", VA = "0x182066310")]
		public string GetKey()
		{
			return null;
		}

		// Token: 0x06025712 RID: 153362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025712")]
		[Address(RVA = "0x2066250", Offset = "0x2064E50", VA = "0x182066250")]
		public void Clear()
		{
		}

		// Token: 0x06025713 RID: 153363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025713")]
		[Address(RVA = "0x2066670", Offset = "0x2065270", VA = "0x182066670")]
		public ArtMagazineLeafCharViewModel()
		{
		}

		// Token: 0x06025714 RID: 153364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025714")]
		[Address(RVA = "0x2066660", Offset = "0x2065260", VA = "0x182066660")]
		private void <>xLuaBaseProxy_LoadData(string P0, ItemType P1, int P2, int P3)
		{
		}

		// Token: 0x040348CE RID: 215246
		[Token(Token = "0x40348CE")]
		private const string KEY_FORMAT = "{0}_{1}";

		// Token: 0x040348CF RID: 215247
		[Token(Token = "0x40348CF")]
		[FieldOffset(Offset = "0x40")]
		public string charName;

		// Token: 0x040348D0 RID: 215248
		[Token(Token = "0x40348D0")]
		[FieldOffset(Offset = "0x48")]
		public string skinName;

		// Token: 0x040348D1 RID: 215249
		[Token(Token = "0x40348D1")]
		[FieldOffset(Offset = "0x50")]
		public CharUISkinStruct charSkin;

		// Token: 0x040348D2 RID: 215250
		[Token(Token = "0x40348D2")]
		[FieldOffset(Offset = "0x68")]
		public bool useIllustDftSize;

		// Token: 0x040348D3 RID: 215251
		[Token(Token = "0x40348D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040348D4 RID: 215252
		[Token(Token = "0x40348D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetKey;

		// Token: 0x040348D5 RID: 215253
		[Token(Token = "0x40348D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x040348D6 RID: 215254
		[Token(Token = "0x40348D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
