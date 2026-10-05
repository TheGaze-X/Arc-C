using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057CE RID: 22478
	[Token(Token = "0x20057CE")]
	public class RoguelikeInitModeRelicContext : RoguelikeInitConfirmContext
	{
		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x06020E04 RID: 134660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D18")]
		public override List<RoguelikeInitRelic.Model> relicList
		{
			[Token(Token = "0x6020E04")]
			[Address(RVA = "0x1B3BFB0", Offset = "0x1B3ABB0", VA = "0x181B3BFB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x06020E05 RID: 134661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D19")]
		public override string name
		{
			[Token(Token = "0x6020E05")]
			[Address(RVA = "0x1B3BF30", Offset = "0x1B3AB30", VA = "0x181B3BF30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020E06 RID: 134662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E06")]
		[Address(RVA = "0x1B3BB30", Offset = "0x1B3A730", VA = "0x181B3BB30", Slot = "4")]
		public override void Load(PlayerRoguelikePendingEvent evt)
		{
		}

		// Token: 0x06020E07 RID: 134663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E07")]
		[Address(RVA = "0x1B3BE80", Offset = "0x1B3AA80", VA = "0x181B3BE80")]
		public RoguelikeInitModeRelicContext()
		{
		}

		// Token: 0x06020E08 RID: 134664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020E08")]
		[Address(RVA = "0x1B393A0", Offset = "0x1B37FA0", VA = "0x181B393A0")]
		private List<RoguelikeInitRelic.Model> <>xLuaBaseProxy_get_relicList()
		{
			return null;
		}

		// Token: 0x0402CAC6 RID: 182982
		[Token(Token = "0x402CAC6")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeInitRelic.Model> m_relics;

		// Token: 0x0402CAC7 RID: 182983
		[Token(Token = "0x402CAC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicList;

		// Token: 0x0402CAC8 RID: 182984
		[Token(Token = "0x402CAC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CAC9 RID: 182985
		[Token(Token = "0x402CAC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CACA RID: 182986
		[Token(Token = "0x402CACA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
