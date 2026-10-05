using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065C5 RID: 26053
	[Token(Token = "0x20065C5")]
	public abstract class ArtMagazineLeafItemViewModel : IHotfixable
	{
		// Token: 0x0602570E RID: 153358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602570E")]
		[Address(RVA = "0x2068AE0", Offset = "0x20676E0", VA = "0x182068AE0", Slot = "4")]
		public virtual void LoadData(string itemId, ItemType itemType, int templateId, int leafInstId)
		{
		}

		// Token: 0x0602570F RID: 153359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602570F")]
		[Address(RVA = "0x2068CC0", Offset = "0x20678C0", VA = "0x182068CC0")]
		protected ArtMagazineLeafItemViewModel()
		{
		}

		// Token: 0x040348C3 RID: 215235
		[Token(Token = "0x40348C3")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x040348C4 RID: 215236
		[Token(Token = "0x40348C4")]
		[FieldOffset(Offset = "0x18")]
		public ItemType itemType;

		// Token: 0x040348C5 RID: 215237
		[Token(Token = "0x40348C5")]
		[FieldOffset(Offset = "0x1C")]
		public int templateId;

		// Token: 0x040348C6 RID: 215238
		[Token(Token = "0x40348C6")]
		[FieldOffset(Offset = "0x20")]
		public string elemTypeStr;

		// Token: 0x040348C7 RID: 215239
		[Token(Token = "0x40348C7")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 initPos;

		// Token: 0x040348C8 RID: 215240
		[Token(Token = "0x40348C8")]
		[FieldOffset(Offset = "0x30")]
		public float initScale;

		// Token: 0x040348C9 RID: 215241
		[Token(Token = "0x40348C9")]
		[FieldOffset(Offset = "0x34")]
		public float maxScale;

		// Token: 0x040348CA RID: 215242
		[Token(Token = "0x40348CA")]
		[FieldOffset(Offset = "0x38")]
		public float minScale;

		// Token: 0x040348CB RID: 215243
		[Token(Token = "0x40348CB")]
		[FieldOffset(Offset = "0x3C")]
		public int leafInstId;

		// Token: 0x040348CC RID: 215244
		[Token(Token = "0x40348CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040348CD RID: 215245
		[Token(Token = "0x40348CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
