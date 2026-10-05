using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004151 RID: 16721
	[Token(Token = "0x2004151")]
	public class SandboxV2BasementUpgradeResourceViewModel : IHotfixable
	{
		// Token: 0x06019D21 RID: 105761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D21")]
		[Address(RVA = "0x12A4C20", Offset = "0x12A3820", VA = "0x1812A4C20")]
		public void LoadData(string id, ItemType type, int need, int count)
		{
		}

		// Token: 0x06019D22 RID: 105762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D22")]
		[Address(RVA = "0x12A4D50", Offset = "0x12A3950", VA = "0x1812A4D50")]
		public SandboxV2BasementUpgradeResourceViewModel()
		{
		}

		// Token: 0x040206AB RID: 132779
		[Token(Token = "0x40206AB")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x040206AC RID: 132780
		[Token(Token = "0x40206AC")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel item;

		// Token: 0x040206AD RID: 132781
		[Token(Token = "0x40206AD")]
		[FieldOffset(Offset = "0x20")]
		public int itemNeed;

		// Token: 0x040206AE RID: 132782
		[Token(Token = "0x40206AE")]
		[FieldOffset(Offset = "0x24")]
		public int itemCount;

		// Token: 0x040206AF RID: 132783
		[Token(Token = "0x40206AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040206B0 RID: 132784
		[Token(Token = "0x40206B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
