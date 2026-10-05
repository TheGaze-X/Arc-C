using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046D4 RID: 18132
	[Token(Token = "0x20046D4")]
	public class RL04ModeViewExtModel : RoguelikeTopicModeViewModelExtension
	{
		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x0601B7EC RID: 112620 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B7ED RID: 112621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004175")]
		public string relicDesc
		{
			[Token(Token = "0x601B7EC")]
			[Address(RVA = "0x14C9730", Offset = "0x14C8330", VA = "0x1814C9730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B7ED")]
			[Address(RVA = "0x14C9810", Offset = "0x14C8410", VA = "0x1814C9810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x0601B7EE RID: 112622 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B7EF RID: 112623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004176")]
		public string buffDesc
		{
			[Token(Token = "0x601B7EE")]
			[Address(RVA = "0x14C96D0", Offset = "0x14C82D0", VA = "0x1814C96D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B7EF")]
			[Address(RVA = "0x14C9790", Offset = "0x14C8390", VA = "0x1814C9790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B7F0 RID: 112624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7F0")]
		[Address(RVA = "0x14C8870", Offset = "0x14C7470", VA = "0x1814C8870", Slot = "4")]
		public override void Load(RoguelikeTopicModeViewModel mainModel)
		{
		}

		// Token: 0x0601B7F1 RID: 112625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7F1")]
		[Address(RVA = "0x14C9200", Offset = "0x14C7E00", VA = "0x1814C9200")]
		private void _LoadExtDifficultyList(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B7F2 RID: 112626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7F2")]
		[Address(RVA = "0x14C8C20", Offset = "0x14C7820", VA = "0x1814C8C20")]
		private void _LoadBuffs()
		{
		}

		// Token: 0x0601B7F3 RID: 112627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B7F3")]
		[Address(RVA = "0x14C8A50", Offset = "0x14C7650", VA = "0x1814C8A50")]
		private RL04DifficultyExt _GetExtDiffData(RoguelikeTopicMode modeDifficulty, int grade)
		{
			return null;
		}

		// Token: 0x0601B7F4 RID: 112628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7F4")]
		[Address(RVA = "0x14C95D0", Offset = "0x14C81D0", VA = "0x1814C95D0")]
		public RL04ModeViewExtModel()
		{
		}

		// Token: 0x040239D2 RID: 145874
		[Token(Token = "0x40239D2")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<RL04DifficultyViewModel> difficultyList;

		// Token: 0x040239D5 RID: 145877
		[Token(Token = "0x40239D5")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public List<RL04DifficultyRulesBuffModel> buffList;

		// Token: 0x040239D6 RID: 145878
		[Token(Token = "0x40239D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicDesc;

		// Token: 0x040239D7 RID: 145879
		[Token(Token = "0x40239D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_relicDesc;

		// Token: 0x040239D8 RID: 145880
		[Token(Token = "0x40239D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_buffDesc;

		// Token: 0x040239D9 RID: 145881
		[Token(Token = "0x40239D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_buffDesc;

		// Token: 0x040239DA RID: 145882
		[Token(Token = "0x40239DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x040239DB RID: 145883
		[Token(Token = "0x40239DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadExtDifficultyList;

		// Token: 0x040239DC RID: 145884
		[Token(Token = "0x40239DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadBuffs;

		// Token: 0x040239DD RID: 145885
		[Token(Token = "0x40239DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetExtDiffData;

		// Token: 0x040239DE RID: 145886
		[Token(Token = "0x40239DE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
