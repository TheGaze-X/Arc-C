using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B1E RID: 27422
	[Token(Token = "0x2006B1E")]
	public class BuffCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027333 RID: 160563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027333")]
		[Address(RVA = "0x2274CC0", Offset = "0x22738C0", VA = "0x182274CC0")]
		public BuffCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027334 RID: 160564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027334")]
		[Address(RVA = "0x2274860", Offset = "0x2273460", VA = "0x182274860", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027335 RID: 160565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027335")]
		[Address(RVA = "0x2274AC0", Offset = "0x22736C0", VA = "0x182274AC0")]
		public void SetSelectedBuffItem(string buffId)
		{
		}

		// Token: 0x06027336 RID: 160566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027336")]
		[Address(RVA = "0x2274480", Offset = "0x2273080", VA = "0x182274480", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027337 RID: 160567 RVA: 0x000CDA58 File Offset: 0x000CBC58
		[Token(Token = "0x6027337")]
		[Address(RVA = "0x22747E0", Offset = "0x22733E0", VA = "0x1822747E0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027338 RID: 160568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027338")]
		[Address(RVA = "0x2274A10", Offset = "0x2273610", VA = "0x182274A10", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027339 RID: 160569 RVA: 0x000CDA70 File Offset: 0x000CBC70
		[Token(Token = "0x6027339")]
		[Address(RVA = "0x2274520", Offset = "0x2273120", VA = "0x182274520", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0602733A RID: 160570 RVA: 0x000CDA88 File Offset: 0x000CBC88
		[Token(Token = "0x602733A")]
		[Address(RVA = "0x2274680", Offset = "0x2273280", VA = "0x182274680", Slot = "9")]
		public override bool IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x0602733B RID: 160571 RVA: 0x000CDAA0 File Offset: 0x000CBCA0
		[Token(Token = "0x602733B")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0602733C RID: 160572 RVA: 0x000CDAB8 File Offset: 0x000CBCB8
		[Token(Token = "0x602733C")]
		[Address(RVA = "0x2274CB0", Offset = "0x22738B0", VA = "0x182274CB0")]
		private bool <>xLuaBaseProxy_IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x04037762 RID: 227170
		[Token(Token = "0x4037762")]
		[FieldOffset(Offset = "0x18")]
		public BuffProperty buff;

		// Token: 0x04037763 RID: 227171
		[Token(Token = "0x4037763")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037764 RID: 227172
		[Token(Token = "0x4037764")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037765 RID: 227173
		[Token(Token = "0x4037765")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedBuffItem;

		// Token: 0x04037766 RID: 227174
		[Token(Token = "0x4037766")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037767 RID: 227175
		[Token(Token = "0x4037767")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037768 RID: 227176
		[Token(Token = "0x4037768")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037769 RID: 227177
		[Token(Token = "0x4037769")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;

		// Token: 0x0403776A RID: 227178
		[Token(Token = "0x403776A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsUnlocked;
	}
}
