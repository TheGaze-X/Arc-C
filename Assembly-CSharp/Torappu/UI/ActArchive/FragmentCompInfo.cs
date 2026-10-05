using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B95 RID: 27541
	[Token(Token = "0x2006B95")]
	public class FragmentCompInfo : ActArchiveCompInfo, IHotfixable
	{
		// Token: 0x06027565 RID: 161125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027565")]
		[Address(RVA = "0x228B690", Offset = "0x228A290", VA = "0x18228B690")]
		public FragmentCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027566 RID: 161126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027566")]
		[Address(RVA = "0x228B5B0", Offset = "0x228A1B0", VA = "0x18228B5B0")]
		public void SetSelectedItemId(string fragmentId)
		{
		}

		// Token: 0x06027567 RID: 161127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027567")]
		[Address(RVA = "0x228B370", Offset = "0x2289F70", VA = "0x18228B370", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027568 RID: 161128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027568")]
		[Address(RVA = "0x228AFF0", Offset = "0x2289BF0", VA = "0x18228AFF0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027569 RID: 161129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027569")]
		[Address(RVA = "0x228B500", Offset = "0x228A100", VA = "0x18228B500", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602756A RID: 161130 RVA: 0x000CE1A8 File Offset: 0x000CC3A8
		[Token(Token = "0x602756A")]
		[Address(RVA = "0x228B2F0", Offset = "0x2289EF0", VA = "0x18228B2F0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602756B RID: 161131 RVA: 0x000CE1C0 File Offset: 0x000CC3C0
		[Token(Token = "0x602756B")]
		[Address(RVA = "0x228B140", Offset = "0x2289D40", VA = "0x18228B140", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0602756C RID: 161132 RVA: 0x000CE1D8 File Offset: 0x000CC3D8
		[Token(Token = "0x602756C")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04037BAA RID: 228266
		[Token(Token = "0x4037BAA")]
		[FieldOffset(Offset = "0x18")]
		public FragmentProperty fragment;

		// Token: 0x04037BAB RID: 228267
		[Token(Token = "0x4037BAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037BAC RID: 228268
		[Token(Token = "0x4037BAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedItemId;

		// Token: 0x04037BAD RID: 228269
		[Token(Token = "0x4037BAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037BAE RID: 228270
		[Token(Token = "0x4037BAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037BAF RID: 228271
		[Token(Token = "0x4037BAF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037BB0 RID: 228272
		[Token(Token = "0x4037BB0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037BB1 RID: 228273
		[Token(Token = "0x4037BB1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
