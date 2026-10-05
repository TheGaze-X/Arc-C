using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005608 RID: 22024
	[Token(Token = "0x2005608")]
	public class RL05RoguelikeCharSortGetCandleRecruitPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x0602051E RID: 132382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BB3")]
		public override List<RoguelikeCharCardComparer> additionalComparers
		{
			[Token(Token = "0x602051E")]
			[Address(RVA = "0x1A6EFC0", Offset = "0x1A6DBC0", VA = "0x181A6EFC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602051F RID: 132383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602051F")]
		[Address(RVA = "0x1A6EC70", Offset = "0x1A6D870", VA = "0x181A6EC70", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x06020520 RID: 132384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020520")]
		[Address(RVA = "0x1A6ED50", Offset = "0x1A6D950", VA = "0x181A6ED50", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020521 RID: 132385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020521")]
		[Address(RVA = "0x1A6EF30", Offset = "0x1A6DB30", VA = "0x181A6EF30")]
		public RL05RoguelikeCharSortGetCandleRecruitPluginContext()
		{
		}

		// Token: 0x06020523 RID: 132387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020523")]
		[Address(RVA = "0x1A6EDE0", Offset = "0x1A6D9E0", VA = "0x181A6EDE0")]
		private List<RoguelikeCharCardComparer> <>xLuaBaseProxy_get_additionalComparers()
		{
			return null;
		}

		// Token: 0x0402BBEE RID: 179182
		[Token(Token = "0x402BBEE")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x0402BBEF RID: 179183
		[Token(Token = "0x402BBEF")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isComparerAvail;

		// Token: 0x0402BBF0 RID: 179184
		[Token(Token = "0x402BBF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_additionalComparers;

		// Token: 0x0402BBF1 RID: 179185
		[Token(Token = "0x402BBF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402BBF2 RID: 179186
		[Token(Token = "0x402BBF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BBF3 RID: 179187
		[Token(Token = "0x402BBF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005609 RID: 22025
		[Token(Token = "0x2005609")]
		public class RL05SelectCharSortPlugin : RoguelikeCharCardPlugin<RL05RoguelikeCharSortGetCandleRecruitPluginContext>
		{
			// Token: 0x06020524 RID: 132388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020524")]
			[Address(RVA = "0x1A710B0", Offset = "0x1A6FCB0", VA = "0x181A710B0")]
			public RL05SelectCharSortPlugin()
			{
			}

			// Token: 0x0402BBF4 RID: 179188
			[Token(Token = "0x402BBF4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
