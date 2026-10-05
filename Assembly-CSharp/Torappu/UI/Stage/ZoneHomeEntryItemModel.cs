using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067D6 RID: 26582
	[Token(Token = "0x20067D6")]
	public abstract class ZoneHomeEntryItemModel : IHotfixable
	{
		// Token: 0x17005A20 RID: 23072
		// (get) Token: 0x060261C5 RID: 156101 RVA: 0x000CA128 File Offset: 0x000C8328
		// (set) Token: 0x060261C6 RID: 156102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A20")]
		public HomeEntrySortIndex sortIndex
		{
			[Token(Token = "0x60261C5")]
			[Address(RVA = "0x212B3D0", Offset = "0x2129FD0", VA = "0x18212B3D0")]
			[CompilerGenerated]
			get
			{
				return HomeEntrySortIndex.NONE;
			}
			[Token(Token = "0x60261C6")]
			[Address(RVA = "0x212B590", Offset = "0x212A190", VA = "0x18212B590")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005A21 RID: 23073
		// (get) Token: 0x060261C7 RID: 156103 RVA: 0x000CA140 File Offset: 0x000C8340
		// (set) Token: 0x060261C8 RID: 156104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A21")]
		public HomeEntryFuncType funcType
		{
			[Token(Token = "0x60261C7")]
			[Address(RVA = "0x212B370", Offset = "0x2129F70", VA = "0x18212B370")]
			get
			{
				return HomeEntryFuncType.NONE;
			}
			[Token(Token = "0x60261C8")]
			[Address(RVA = "0x212B510", Offset = "0x212A110", VA = "0x18212B510")]
			set
			{
			}
		}

		// Token: 0x17005A22 RID: 23074
		// (get) Token: 0x060261C9 RID: 156105 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060261CA RID: 156106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A22")]
		public string funcId
		{
			[Token(Token = "0x60261C9")]
			[Address(RVA = "0x212B310", Offset = "0x2129F10", VA = "0x18212B310")]
			get
			{
				return null;
			}
			[Token(Token = "0x60261CA")]
			[Address(RVA = "0x212B430", Offset = "0x212A030", VA = "0x18212B430")]
			set
			{
			}
		}

		// Token: 0x060261CB RID: 156107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261CB")]
		[Address(RVA = "0x212B000", Offset = "0x2129C00", VA = "0x18212B000")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x060261CC RID: 156108 RVA: 0x000CA158 File Offset: 0x000C8358
		[Token(Token = "0x60261CC")]
		[Address(RVA = "0x212B1F0", Offset = "0x2129DF0", VA = "0x18212B1F0", Slot = "4")]
		public virtual ZoneHomeEntryMedalStatus GetMedalStatus()
		{
			return default(ZoneHomeEntryMedalStatus);
		}

		// Token: 0x060261CD RID: 156109 RVA: 0x000CA170 File Offset: 0x000C8370
		[Token(Token = "0x60261CD")]
		[Address(RVA = "0x2128CE0", Offset = "0x21278E0", VA = "0x182128CE0", Slot = "5")]
		public virtual ZoneHomeEntryLockInfo GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x060261CE RID: 156110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261CE")]
		[Address(RVA = "0x212B2A0", Offset = "0x2129EA0", VA = "0x18212B2A0")]
		protected ZoneHomeEntryItemModel()
		{
		}

		// Token: 0x04035A8E RID: 219790
		[Token(Token = "0x4035A8E")]
		[FieldOffset(Offset = "0x10")]
		private HomeEntryFuncType m_funcType;

		// Token: 0x04035A8F RID: 219791
		[Token(Token = "0x4035A8F")]
		[FieldOffset(Offset = "0x18")]
		private string m_funcId;

		// Token: 0x04035A90 RID: 219792
		[Token(Token = "0x4035A90")]
		[FieldOffset(Offset = "0x20")]
		public int entryViewIndex;

		// Token: 0x04035A91 RID: 219793
		[Token(Token = "0x4035A91")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;

		// Token: 0x04035A93 RID: 219795
		[Token(Token = "0x4035A93")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedId;

		// Token: 0x04035A94 RID: 219796
		[Token(Token = "0x4035A94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortIndex;

		// Token: 0x04035A95 RID: 219797
		[Token(Token = "0x4035A95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_sortIndex;

		// Token: 0x04035A96 RID: 219798
		[Token(Token = "0x4035A96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_funcType;

		// Token: 0x04035A97 RID: 219799
		[Token(Token = "0x4035A97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_funcType;

		// Token: 0x04035A98 RID: 219800
		[Token(Token = "0x4035A98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_funcId;

		// Token: 0x04035A99 RID: 219801
		[Token(Token = "0x4035A99")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_funcId;

		// Token: 0x04035A9A RID: 219802
		[Token(Token = "0x4035A9A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x04035A9B RID: 219803
		[Token(Token = "0x4035A9B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetMedalStatus;

		// Token: 0x04035A9C RID: 219804
		[Token(Token = "0x4035A9C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLockInfo;

		// Token: 0x04035A9D RID: 219805
		[Token(Token = "0x4035A9D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
