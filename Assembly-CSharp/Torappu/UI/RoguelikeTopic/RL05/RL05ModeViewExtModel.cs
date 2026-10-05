using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x0200459E RID: 17822
	[Token(Token = "0x200459E")]
	public class RL05ModeViewExtModel : RoguelikeTopicModeViewModelExtension
	{
		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x0601B217 RID: 111127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B218 RID: 111128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040A7")]
		public string copperGildDesc
		{
			[Token(Token = "0x601B217")]
			[Address(RVA = "0x1453040", Offset = "0x1451C40", VA = "0x181453040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B218")]
			[Address(RVA = "0x1453180", Offset = "0x1451D80", VA = "0x181453180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x0601B219 RID: 111129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B21A RID: 111130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040A8")]
		public string relicDesc
		{
			[Token(Token = "0x601B219")]
			[Address(RVA = "0x14530A0", Offset = "0x1451CA0", VA = "0x1814530A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B21A")]
			[Address(RVA = "0x1453200", Offset = "0x1451E00", VA = "0x181453200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x0601B21B RID: 111131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B21C RID: 111132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040A9")]
		public string buffDesc
		{
			[Token(Token = "0x601B21B")]
			[Address(RVA = "0x1452FE0", Offset = "0x1451BE0", VA = "0x181452FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B21C")]
			[Address(RVA = "0x1453100", Offset = "0x1451D00", VA = "0x181453100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B21D RID: 111133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B21D")]
		[Address(RVA = "0x1452110", Offset = "0x1450D10", VA = "0x181452110", Slot = "4")]
		public override void Load(RoguelikeTopicModeViewModel mainModel)
		{
		}

		// Token: 0x0601B21E RID: 111134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B21E")]
		[Address(RVA = "0x1452B10", Offset = "0x1451710", VA = "0x181452B10")]
		private void _LoadExtDifficultyList(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B21F RID: 111135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B21F")]
		[Address(RVA = "0x1452530", Offset = "0x1451130", VA = "0x181452530")]
		private void _LoadBuffs()
		{
		}

		// Token: 0x0601B220 RID: 111136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B220")]
		[Address(RVA = "0x1452360", Offset = "0x1450F60", VA = "0x181452360")]
		private RL05DifficultyExt _GetExtDiffData(RoguelikeTopicMode modeDifficulty, int grade)
		{
			return null;
		}

		// Token: 0x0601B221 RID: 111137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B221")]
		[Address(RVA = "0x1452EE0", Offset = "0x1451AE0", VA = "0x181452EE0")]
		public RL05ModeViewExtModel()
		{
		}

		// Token: 0x04022EAF RID: 143023
		[Token(Token = "0x4022EAF")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<RL05DifficultyViewModel> difficultyList;

		// Token: 0x04022EB3 RID: 143027
		[Token(Token = "0x4022EB3")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public List<RL05DifficultyRulesBuffModel> buffList;

		// Token: 0x04022EB4 RID: 143028
		[Token(Token = "0x4022EB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_copperGildDesc;

		// Token: 0x04022EB5 RID: 143029
		[Token(Token = "0x4022EB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_copperGildDesc;

		// Token: 0x04022EB6 RID: 143030
		[Token(Token = "0x4022EB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_relicDesc;

		// Token: 0x04022EB7 RID: 143031
		[Token(Token = "0x4022EB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_relicDesc;

		// Token: 0x04022EB8 RID: 143032
		[Token(Token = "0x4022EB8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_buffDesc;

		// Token: 0x04022EB9 RID: 143033
		[Token(Token = "0x4022EB9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_buffDesc;

		// Token: 0x04022EBA RID: 143034
		[Token(Token = "0x4022EBA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04022EBB RID: 143035
		[Token(Token = "0x4022EBB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadExtDifficultyList;

		// Token: 0x04022EBC RID: 143036
		[Token(Token = "0x4022EBC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadBuffs;

		// Token: 0x04022EBD RID: 143037
		[Token(Token = "0x4022EBD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetExtDiffData;

		// Token: 0x04022EBE RID: 143038
		[Token(Token = "0x4022EBE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
