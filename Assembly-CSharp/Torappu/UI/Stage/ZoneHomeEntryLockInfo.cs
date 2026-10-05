using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067D3 RID: 26579
	[Token(Token = "0x20067D3")]
	public struct ZoneHomeEntryLockInfo : IHotfixable
	{
		// Token: 0x060261A1 RID: 156065 RVA: 0x000C9F78 File Offset: 0x000C8178
		[Token(Token = "0x60261A1")]
		[Address(RVA = "0x212BAA0", Offset = "0x212A6A0", VA = "0x18212BAA0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x17005A17 RID: 23063
		// (get) Token: 0x060261A2 RID: 156066 RVA: 0x000C9F90 File Offset: 0x000C8190
		// (set) Token: 0x060261A3 RID: 156067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A17")]
		public UILockTarget lockTarget
		{
			[Token(Token = "0x60261A2")]
			[Address(RVA = "0x212BC40", Offset = "0x212A840", VA = "0x18212BC40")]
			[CompilerGenerated]
			readonly get
			{
				return UILockTarget.NONE;
			}
			[Token(Token = "0x60261A3")]
			[Address(RVA = "0x212BD70", Offset = "0x212A970", VA = "0x18212BD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A18 RID: 23064
		// (get) Token: 0x060261A4 RID: 156068 RVA: 0x000C9FA8 File Offset: 0x000C81A8
		// (set) Token: 0x060261A5 RID: 156069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A18")]
		public bool isLocked
		{
			[Token(Token = "0x60261A4")]
			[Address(RVA = "0x212BBB0", Offset = "0x212A7B0", VA = "0x18212BBB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60261A5")]
			[Address(RVA = "0x212BCD0", Offset = "0x212A8D0", VA = "0x18212BCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060261A6 RID: 156070 RVA: 0x000C9FC0 File Offset: 0x000C81C0
		[Token(Token = "0x60261A6")]
		[Address(RVA = "0x212B7D0", Offset = "0x212A3D0", VA = "0x18212B7D0")]
		public static ZoneHomeEntryLockInfo Create(UILockTarget target)
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x060261A7 RID: 156071 RVA: 0x000C9FD8 File Offset: 0x000C81D8
		[Token(Token = "0x60261A7")]
		[Address(RVA = "0x212B600", Offset = "0x212A200", VA = "0x18212B600")]
		public static ZoneHomeEntryLockInfo Create(bool isLocked, string lockAlert)
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x060261A8 RID: 156072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261A8")]
		[Address(RVA = "0x212B9A0", Offset = "0x212A5A0", VA = "0x18212B9A0")]
		public string GetLockAlert()
		{
			return null;
		}

		// Token: 0x04035A5C RID: 219740
		[Token(Token = "0x4035A5C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ZoneHomeEntryLockInfo EMPTY;

		// Token: 0x04035A5D RID: 219741
		[Token(Token = "0x4035A5D")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isEmpty;

		// Token: 0x04035A5E RID: 219742
		[Token(Token = "0x4035A5E")]
		[FieldOffset(Offset = "0x8")]
		private string m_customLockAlert;

		// Token: 0x04035A61 RID: 219745
		[Token(Token = "0x4035A61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04035A62 RID: 219746
		[Token(Token = "0x4035A62")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_lockTarget;

		// Token: 0x04035A63 RID: 219747
		[Token(Token = "0x4035A63")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_lockTarget;

		// Token: 0x04035A64 RID: 219748
		[Token(Token = "0x4035A64")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04035A65 RID: 219749
		[Token(Token = "0x4035A65")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isLocked;

		// Token: 0x04035A66 RID: 219750
		[Token(Token = "0x4035A66")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04035A67 RID: 219751
		[Token(Token = "0x4035A67")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_Create;

		// Token: 0x04035A68 RID: 219752
		[Token(Token = "0x4035A68")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetLockAlert;
	}
}
