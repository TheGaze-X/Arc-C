using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004517 RID: 17687
	[Token(Token = "0x2004517")]
	public class RoguelikeCommonOuterBuffSummaryMergedItemModel : IHotfixable
	{
		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x0601AF9E RID: 110494 RVA: 0x000A3C50 File Offset: 0x000A1E50
		[Token(Token = "0x17004009")]
		public bool isLocked
		{
			[Token(Token = "0x601AF9E")]
			[Address(RVA = "0x1422160", Offset = "0x1420D60", VA = "0x181422160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601AF9F RID: 110495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AF9F")]
		[Address(RVA = "0x1422070", Offset = "0x1420C70", VA = "0x181422070")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601AFA0 RID: 110496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFA0")]
		[Address(RVA = "0x1422100", Offset = "0x1420D00", VA = "0x181422100")]
		public RoguelikeCommonOuterBuffSummaryMergedItemModel()
		{
		}

		// Token: 0x04022A28 RID: 141864
		[Token(Token = "0x4022A28")]
		[FieldOffset(Offset = "0x10")]
		public int viewIndex;

		// Token: 0x04022A29 RID: 141865
		[Token(Token = "0x4022A29")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicDisplayItem displayItem;

		// Token: 0x04022A2A RID: 141866
		[Token(Token = "0x4022A2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04022A2B RID: 141867
		[Token(Token = "0x4022A2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x04022A2C RID: 141868
		[Token(Token = "0x4022A2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
