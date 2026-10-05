using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045C0 RID: 17856
	[Token(Token = "0x20045C0")]
	public class RL03ModeViewExtModel : RoguelikeTopicModeViewModelExtension
	{
		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x0601B2B8 RID: 111288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B2B9 RID: 111289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040BB")]
		public string totemDesc
		{
			[Token(Token = "0x601B2B8")]
			[Address(RVA = "0x144C270", Offset = "0x144AE70", VA = "0x18144C270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B2B9")]
			[Address(RVA = "0x144C3D0", Offset = "0x144AFD0", VA = "0x18144C3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x0601B2BA RID: 111290 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B2BB RID: 111291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040BC")]
		public string relicDesc
		{
			[Token(Token = "0x601B2BA")]
			[Address(RVA = "0x144C210", Offset = "0x144AE10", VA = "0x18144C210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B2BB")]
			[Address(RVA = "0x144C350", Offset = "0x144AF50", VA = "0x18144C350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x0601B2BC RID: 111292 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B2BD RID: 111293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040BD")]
		public string buffDesc
		{
			[Token(Token = "0x601B2BC")]
			[Address(RVA = "0x144C1B0", Offset = "0x144ADB0", VA = "0x18144C1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B2BD")]
			[Address(RVA = "0x144C2D0", Offset = "0x144AED0", VA = "0x18144C2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B2BE RID: 111294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2BE")]
		[Address(RVA = "0x144B2F0", Offset = "0x1449EF0", VA = "0x18144B2F0", Slot = "4")]
		public override void Load(RoguelikeTopicModeViewModel mainModel)
		{
		}

		// Token: 0x0601B2BF RID: 111295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2BF")]
		[Address(RVA = "0x144BD10", Offset = "0x144A910", VA = "0x18144BD10")]
		private void _LoadExtDifficultyList(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B2C0 RID: 111296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2C0")]
		[Address(RVA = "0x144B710", Offset = "0x144A310", VA = "0x18144B710")]
		private void _LoadBuffs(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B2C1 RID: 111297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B2C1")]
		[Address(RVA = "0x144B550", Offset = "0x144A150", VA = "0x18144B550")]
		private RL03DifficultyExt _GetExtDiffData(RoguelikeTopicMode modeDifficulty, int grade)
		{
			return null;
		}

		// Token: 0x0601B2C2 RID: 111298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2C2")]
		[Address(RVA = "0x144C0B0", Offset = "0x144ACB0", VA = "0x18144C0B0")]
		public RL03ModeViewExtModel()
		{
		}

		// Token: 0x04022FEA RID: 143338
		[Token(Token = "0x4022FEA")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<RL03DifficultyViewModel> difficultyList;

		// Token: 0x04022FEE RID: 143342
		[Token(Token = "0x4022FEE")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public List<RL03DifficultyRulesBuffModel> buffList;

		// Token: 0x04022FEF RID: 143343
		[Token(Token = "0x4022FEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totemDesc;

		// Token: 0x04022FF0 RID: 143344
		[Token(Token = "0x4022FF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_totemDesc;

		// Token: 0x04022FF1 RID: 143345
		[Token(Token = "0x4022FF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_relicDesc;

		// Token: 0x04022FF2 RID: 143346
		[Token(Token = "0x4022FF2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_relicDesc;

		// Token: 0x04022FF3 RID: 143347
		[Token(Token = "0x4022FF3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_buffDesc;

		// Token: 0x04022FF4 RID: 143348
		[Token(Token = "0x4022FF4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_buffDesc;

		// Token: 0x04022FF5 RID: 143349
		[Token(Token = "0x4022FF5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04022FF6 RID: 143350
		[Token(Token = "0x4022FF6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadExtDifficultyList;

		// Token: 0x04022FF7 RID: 143351
		[Token(Token = "0x4022FF7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadBuffs;

		// Token: 0x04022FF8 RID: 143352
		[Token(Token = "0x4022FF8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetExtDiffData;

		// Token: 0x04022FF9 RID: 143353
		[Token(Token = "0x4022FF9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
