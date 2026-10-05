using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F2B RID: 16171
	[Token(Token = "0x2003F2B")]
	public class SiracusaCharSelectTaskRingRewardInfo : IHotfixable
	{
		// Token: 0x060191E7 RID: 102887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60191E7")]
		[Address(RVA = "0x11CB3E0", Offset = "0x11C9FE0", VA = "0x1811CB3E0")]
		public static SiracusaCharSelectTaskRingRewardInfo CreateInfo(string ringId, ItemBundle item, bool hasGet)
		{
			return null;
		}

		// Token: 0x060191E8 RID: 102888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191E8")]
		[Address(RVA = "0x11CB560", Offset = "0x11CA160", VA = "0x1811CB560")]
		public SiracusaCharSelectTaskRingRewardInfo()
		{
		}

		// Token: 0x0401F196 RID: 127382
		[Token(Token = "0x401F196")]
		[FieldOffset(Offset = "0x10")]
		public string taskRingId;

		// Token: 0x0401F197 RID: 127383
		[Token(Token = "0x401F197")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel item;

		// Token: 0x0401F198 RID: 127384
		[Token(Token = "0x401F198")]
		[FieldOffset(Offset = "0x20")]
		public bool hasGet;

		// Token: 0x0401F199 RID: 127385
		[Token(Token = "0x401F199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateInfo;

		// Token: 0x0401F19A RID: 127386
		[Token(Token = "0x401F19A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
