using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF5 RID: 27381
	[Token(Token = "0x2006AF5")]
	public abstract class ActArchiveCompInfo : IHotfixable
	{
		// Token: 0x17005C8B RID: 23691
		// (get) Token: 0x0602726B RID: 160363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602726C RID: 160364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C8B")]
		private protected ActArchiveInfo archiveInfo
		{
			[Token(Token = "0x602726B")]
			[Address(RVA = "0x224AF20", Offset = "0x2249B20", VA = "0x18224AF20")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602726C")]
			[Address(RVA = "0x224AF80", Offset = "0x2249B80", VA = "0x18224AF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602726D RID: 160365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602726D")]
		[Address(RVA = "0x224AE60", Offset = "0x2249A60", VA = "0x18224AE60")]
		public ActArchiveCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602726E RID: 160366
		[Token(Token = "0x602726E")]
		public abstract void LoadData(string archiveId);

		// Token: 0x0602726F RID: 160367
		[Token(Token = "0x602726F")]
		public abstract void ApplyDataBundle(DataBundle data);

		// Token: 0x06027270 RID: 160368
		[Token(Token = "0x6027270")]
		public abstract bool IsValid();

		// Token: 0x06027271 RID: 160369
		[Token(Token = "0x6027271")]
		public abstract void NotifyUpdate();

		// Token: 0x06027272 RID: 160370 RVA: 0x000CD830 File Offset: 0x000CBA30
		[Token(Token = "0x6027272")]
		[Address(RVA = "0x224ACE0", Offset = "0x22498E0", VA = "0x18224ACE0", Slot = "8")]
		public virtual bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027273 RID: 160371 RVA: 0x000CD848 File Offset: 0x000CBA48
		[Token(Token = "0x6027273")]
		[Address(RVA = "0x224AD40", Offset = "0x2249940", VA = "0x18224AD40", Slot = "9")]
		public virtual bool IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06027274 RID: 160372 RVA: 0x000CD860 File Offset: 0x000CBA60
		[Token(Token = "0x6027274")]
		[Address(RVA = "0x224AE00", Offset = "0x2249A00", VA = "0x18224AE00", Slot = "10")]
		public virtual bool OnBackBtnPressed()
		{
			return default(bool);
		}

		// Token: 0x06027275 RID: 160373 RVA: 0x000CD878 File Offset: 0x000CBA78
		[Token(Token = "0x6027275")]
		[Address(RVA = "0x224ADA0", Offset = "0x22499A0", VA = "0x18224ADA0", Slot = "11")]
		public virtual bool NeedClosePageOnBack()
		{
			return default(bool);
		}

		// Token: 0x04037628 RID: 226856
		[Token(Token = "0x4037628")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_archiveInfo;

		// Token: 0x04037629 RID: 226857
		[Token(Token = "0x4037629")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_archiveInfo;

		// Token: 0x0403762A RID: 226858
		[Token(Token = "0x403762A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403762B RID: 226859
		[Token(Token = "0x403762B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HasNewItem;

		// Token: 0x0403762C RID: 226860
		[Token(Token = "0x403762C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsUnlocked;

		// Token: 0x0403762D RID: 226861
		[Token(Token = "0x403762D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBackBtnPressed;

		// Token: 0x0403762E RID: 226862
		[Token(Token = "0x403762E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NeedClosePageOnBack;
	}
}
