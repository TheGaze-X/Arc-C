using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x0200463E RID: 17982
	[Token(Token = "0x200463E")]
	public class RL01ModeViewExtModel : RoguelikeTopicModeViewModelExtension
	{
		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x0601B4EE RID: 111854 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B4EF RID: 111855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700410F")]
		public string relicDesc
		{
			[Token(Token = "0x601B4EE")]
			[Address(RVA = "0x149D160", Offset = "0x149BD60", VA = "0x18149D160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B4EF")]
			[Address(RVA = "0x149D240", Offset = "0x149BE40", VA = "0x18149D240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x0601B4F0 RID: 111856 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B4F1 RID: 111857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004110")]
		public string buffDesc
		{
			[Token(Token = "0x601B4F0")]
			[Address(RVA = "0x149D100", Offset = "0x149BD00", VA = "0x18149D100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B4F1")]
			[Address(RVA = "0x149D1C0", Offset = "0x149BDC0", VA = "0x18149D1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B4F2 RID: 111858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4F2")]
		[Address(RVA = "0x149CAC0", Offset = "0x149B6C0", VA = "0x18149CAC0", Slot = "4")]
		public override void Load(RoguelikeTopicModeViewModel mainModel)
		{
		}

		// Token: 0x0601B4F3 RID: 111859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4F3")]
		[Address(RVA = "0x149CE40", Offset = "0x149BA40", VA = "0x18149CE40")]
		private void _LoadExtDifficultyList(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B4F4 RID: 111860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B4F4")]
		[Address(RVA = "0x149CC70", Offset = "0x149B870", VA = "0x18149CC70")]
		private RL01DifficultyExt _GetExtDiffData(RoguelikeTopicMode modeDifficulty, int grade)
		{
			return null;
		}

		// Token: 0x0601B4F5 RID: 111861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4F5")]
		[Address(RVA = "0x149D050", Offset = "0x149BC50", VA = "0x18149D050")]
		public RL01ModeViewExtModel()
		{
		}

		// Token: 0x04023458 RID: 144472
		[Token(Token = "0x4023458")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<RL01DifficultyViewModel> difficultyList;

		// Token: 0x0402345B RID: 144475
		[Token(Token = "0x402345B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicDesc;

		// Token: 0x0402345C RID: 144476
		[Token(Token = "0x402345C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_relicDesc;

		// Token: 0x0402345D RID: 144477
		[Token(Token = "0x402345D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_buffDesc;

		// Token: 0x0402345E RID: 144478
		[Token(Token = "0x402345E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_buffDesc;

		// Token: 0x0402345F RID: 144479
		[Token(Token = "0x402345F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04023460 RID: 144480
		[Token(Token = "0x4023460")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadExtDifficultyList;

		// Token: 0x04023461 RID: 144481
		[Token(Token = "0x4023461")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetExtDiffData;

		// Token: 0x04023462 RID: 144482
		[Token(Token = "0x4023462")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
