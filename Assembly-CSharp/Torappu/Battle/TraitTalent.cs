using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020024A4 RID: 9380
	[Token(Token = "0x20024A4")]
	[Obsolete("Features of the |TraitTalent| is too limited, Use |UnitDataFlowConfig| instead")]
	public class TraitTalent : Talent
	{
		// Token: 0x0600F130 RID: 61744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F130")]
		[Address(RVA = "0x698920", Offset = "0x697520", VA = "0x180698920", Slot = "27")]
		public override void ProcessTraitBlackboard(Blackboard traitBlackboard)
		{
		}

		// Token: 0x0600F131 RID: 61745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F131")]
		[Address(RVA = "0x698A60", Offset = "0x697660", VA = "0x180698A60")]
		public TraitTalent()
		{
		}

		// Token: 0x04010AE7 RID: 68327
		[Token(Token = "0x4010AE7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TraitTalent.TraitModifier[] _modifiers;

		// Token: 0x020024A5 RID: 9381
		[Token(Token = "0x20024A5")]
		[Serializable]
		public class TraitModifier
		{
			// Token: 0x0600F132 RID: 61746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F132")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TraitModifier()
			{
			}

			// Token: 0x04010AE8 RID: 68328
			[Token(Token = "0x4010AE8")]
			[FieldOffset(Offset = "0x10")]
			public TraitTalent.TraitModifier.Type type;

			// Token: 0x04010AE9 RID: 68329
			[Token(Token = "0x4010AE9")]
			[FieldOffset(Offset = "0x18")]
			public string key;

			// Token: 0x020024A6 RID: 9382
			[Token(Token = "0x20024A6")]
			public enum Type
			{
				// Token: 0x04010AEB RID: 68331
				[Token(Token = "0x4010AEB")]
				ADDITION,
				// Token: 0x04010AEC RID: 68332
				[Token(Token = "0x4010AEC")]
				MULTIPLIER
			}
		}
	}
}
