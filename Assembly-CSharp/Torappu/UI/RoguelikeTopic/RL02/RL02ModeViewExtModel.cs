using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004605 RID: 17925
	[Token(Token = "0x2004605")]
	public class RL02ModeViewExtModel : RoguelikeTopicModeViewModelExtension
	{
		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x0601B3EB RID: 111595 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B3EC RID: 111596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040F8")]
		public string relicDesc
		{
			[Token(Token = "0x601B3EB")]
			[Address(RVA = "0x1460E00", Offset = "0x145FA00", VA = "0x181460E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B3EC")]
			[Address(RVA = "0x1460EE0", Offset = "0x145FAE0", VA = "0x181460EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x0601B3ED RID: 111597 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B3EE RID: 111598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040F9")]
		public string buffDesc
		{
			[Token(Token = "0x601B3ED")]
			[Address(RVA = "0x1460DA0", Offset = "0x145F9A0", VA = "0x181460DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B3EE")]
			[Address(RVA = "0x1460E60", Offset = "0x145FA60", VA = "0x181460E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B3EF RID: 111599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3EF")]
		[Address(RVA = "0x14605A0", Offset = "0x145F1A0", VA = "0x1814605A0", Slot = "4")]
		public override void Load(RoguelikeTopicModeViewModel mainModel)
		{
		}

		// Token: 0x0601B3F0 RID: 111600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F0")]
		[Address(RVA = "0x1460920", Offset = "0x145F520", VA = "0x181460920")]
		private void _LoadExtDifficultyList(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B3F1 RID: 111601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B3F1")]
		[Address(RVA = "0x1460750", Offset = "0x145F350", VA = "0x181460750")]
		private RL02DifficultyExt _GetExtDiffData(RoguelikeTopicMode modeDifficulty, int grade)
		{
			return null;
		}

		// Token: 0x0601B3F2 RID: 111602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3F2")]
		[Address(RVA = "0x1460CF0", Offset = "0x145F8F0", VA = "0x181460CF0")]
		public RL02ModeViewExtModel()
		{
		}

		// Token: 0x0402324C RID: 143948
		[Token(Token = "0x402324C")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<RL02DifficultyViewModel> difficultyList;

		// Token: 0x0402324F RID: 143951
		[Token(Token = "0x402324F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicDesc;

		// Token: 0x04023250 RID: 143952
		[Token(Token = "0x4023250")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_relicDesc;

		// Token: 0x04023251 RID: 143953
		[Token(Token = "0x4023251")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_buffDesc;

		// Token: 0x04023252 RID: 143954
		[Token(Token = "0x4023252")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_buffDesc;

		// Token: 0x04023253 RID: 143955
		[Token(Token = "0x4023253")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04023254 RID: 143956
		[Token(Token = "0x4023254")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadExtDifficultyList;

		// Token: 0x04023255 RID: 143957
		[Token(Token = "0x4023255")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetExtDiffData;

		// Token: 0x04023256 RID: 143958
		[Token(Token = "0x4023256")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
