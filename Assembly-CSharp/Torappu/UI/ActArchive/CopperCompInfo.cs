using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B5E RID: 27486
	[Token(Token = "0x2006B5E")]
	public class CopperCompInfo : ActArchiveCompInfo, IHotfixable
	{
		// Token: 0x06027468 RID: 160872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027468")]
		[Address(RVA = "0x22872C0", Offset = "0x2285EC0", VA = "0x1822872C0")]
		public CopperCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027469 RID: 160873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027469")]
		[Address(RVA = "0x2287190", Offset = "0x2285D90", VA = "0x182287190")]
		public void SetSelectedCopperId(string copperId)
		{
		}

		// Token: 0x0602746A RID: 160874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602746A")]
		[Address(RVA = "0x2286F50", Offset = "0x2285B50", VA = "0x182286F50", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602746B RID: 160875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602746B")]
		[Address(RVA = "0x2286C80", Offset = "0x2285880", VA = "0x182286C80", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602746C RID: 160876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602746C")]
		[Address(RVA = "0x22870E0", Offset = "0x2285CE0", VA = "0x1822870E0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602746D RID: 160877 RVA: 0x000CDE48 File Offset: 0x000CC048
		[Token(Token = "0x602746D")]
		[Address(RVA = "0x2286ED0", Offset = "0x2285AD0", VA = "0x182286ED0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602746E RID: 160878 RVA: 0x000CDE60 File Offset: 0x000CC060
		[Token(Token = "0x602746E")]
		[Address(RVA = "0x2286E10", Offset = "0x2285A10", VA = "0x182286E10", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0602746F RID: 160879 RVA: 0x000CDE78 File Offset: 0x000CC078
		[Token(Token = "0x602746F")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x040379AF RID: 227759
		[Token(Token = "0x40379AF")]
		[FieldOffset(Offset = "0x18")]
		public CopperProperty copper;

		// Token: 0x040379B0 RID: 227760
		[Token(Token = "0x40379B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040379B1 RID: 227761
		[Token(Token = "0x40379B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedCopperId;

		// Token: 0x040379B2 RID: 227762
		[Token(Token = "0x40379B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040379B3 RID: 227763
		[Token(Token = "0x40379B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x040379B4 RID: 227764
		[Token(Token = "0x40379B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x040379B5 RID: 227765
		[Token(Token = "0x40379B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040379B6 RID: 227766
		[Token(Token = "0x40379B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
