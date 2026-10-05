using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200604F RID: 24655
	[Token(Token = "0x200604F")]
	public class CarvingTopInfoViewModel : IHotfixable
	{
		// Token: 0x17005427 RID: 21543
		// (get) Token: 0x06023A62 RID: 146018 RVA: 0x000C1728 File Offset: 0x000BF928
		// (set) Token: 0x06023A63 RID: 146019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005427")]
		public int curRound
		{
			[Token(Token = "0x6023A62")]
			[Address(RVA = "0x1E51280", Offset = "0x1E4FE80", VA = "0x181E51280")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023A63")]
			[Address(RVA = "0x1E513A0", Offset = "0x1E4FFA0", VA = "0x181E513A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005428 RID: 21544
		// (get) Token: 0x06023A64 RID: 146020 RVA: 0x000C1740 File Offset: 0x000BF940
		// (set) Token: 0x06023A65 RID: 146021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005428")]
		public int targetScore
		{
			[Token(Token = "0x6023A64")]
			[Address(RVA = "0x1E51340", Offset = "0x1E4FF40", VA = "0x181E51340")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023A65")]
			[Address(RVA = "0x1E51480", Offset = "0x1E50080", VA = "0x181E51480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005429 RID: 21545
		// (get) Token: 0x06023A66 RID: 146022 RVA: 0x000C1758 File Offset: 0x000BF958
		// (set) Token: 0x06023A67 RID: 146023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005429")]
		public bool inUnlimitedMode
		{
			[Token(Token = "0x6023A66")]
			[Address(RVA = "0x1E512E0", Offset = "0x1E4FEE0", VA = "0x181E512E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6023A67")]
			[Address(RVA = "0x1E51410", Offset = "0x1E50010", VA = "0x181E51410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06023A68 RID: 146024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A68")]
		[Address(RVA = "0x1E50F40", Offset = "0x1E4FB40", VA = "0x181E50F40")]
		public void LoadData(PlayerActivity.PlayerAct35SideActivity.PlayerAct35SideCarving carving, Act35SideData actData)
		{
		}

		// Token: 0x06023A69 RID: 146025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A69")]
		[Address(RVA = "0x1E51220", Offset = "0x1E4FE20", VA = "0x181E51220")]
		public CarvingTopInfoViewModel()
		{
		}

		// Token: 0x04031613 RID: 202259
		[Token(Token = "0x4031613")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curRound;

		// Token: 0x04031614 RID: 202260
		[Token(Token = "0x4031614")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curRound;

		// Token: 0x04031615 RID: 202261
		[Token(Token = "0x4031615")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetScore;

		// Token: 0x04031616 RID: 202262
		[Token(Token = "0x4031616")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_targetScore;

		// Token: 0x04031617 RID: 202263
		[Token(Token = "0x4031617")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inUnlimitedMode;

		// Token: 0x04031618 RID: 202264
		[Token(Token = "0x4031618")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_inUnlimitedMode;

		// Token: 0x04031619 RID: 202265
		[Token(Token = "0x4031619")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403161A RID: 202266
		[Token(Token = "0x403161A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
