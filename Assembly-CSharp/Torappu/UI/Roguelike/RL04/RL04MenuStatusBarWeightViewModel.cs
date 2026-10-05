using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056ED RID: 22253
	[Token(Token = "0x20056ED")]
	public class RL04MenuStatusBarWeightViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x06020A43 RID: 133699 RVA: 0x000B6A60 File Offset: 0x000B4C60
		[Token(Token = "0x17004C8B")]
		public bool haveNextLevelRelatedData
		{
			[Token(Token = "0x6020A43")]
			[Address(RVA = "0x1AC79C0", Offset = "0x1AC65C0", VA = "0x181AC79C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020A44 RID: 133700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A44")]
		[Address(RVA = "0x1AC75B0", Offset = "0x1AC61B0", VA = "0x181AC75B0", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020A45 RID: 133701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A45")]
		[Address(RVA = "0x1AC7800", Offset = "0x1AC6400", VA = "0x181AC7800")]
		private RoguelikeFragmentLevelRelatedData _GetTargetFragmentLevelData(string topicId, int targetLevel, int maxLevel)
		{
			return null;
		}

		// Token: 0x06020A46 RID: 133702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A46")]
		[Address(RVA = "0x1AC7960", Offset = "0x1AC6560", VA = "0x181AC7960")]
		public RL04MenuStatusBarWeightViewModel()
		{
		}

		// Token: 0x06020A47 RID: 133703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A47")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402C465 RID: 181349
		[Token(Token = "0x402C465")]
		[FieldOffset(Offset = "0x18")]
		public int nextWeightUp;

		// Token: 0x0402C466 RID: 181350
		[Token(Token = "0x402C466")]
		[FieldOffset(Offset = "0x20")]
		private RoguelikeFragmentLevelRelatedData m_nextFragmentLevelRelatedData;

		// Token: 0x0402C467 RID: 181351
		[Token(Token = "0x402C467")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_haveNextLevelRelatedData;

		// Token: 0x0402C468 RID: 181352
		[Token(Token = "0x402C468")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C469 RID: 181353
		[Token(Token = "0x402C469")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetTargetFragmentLevelData;

		// Token: 0x0402C46A RID: 181354
		[Token(Token = "0x402C46A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
