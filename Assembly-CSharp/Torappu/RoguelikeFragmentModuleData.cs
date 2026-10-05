using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011A6 RID: 4518
	[Token(Token = "0x20011A6")]
	public class RoguelikeFragmentModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06006F90 RID: 28560 RVA: 0x00032718 File Offset: 0x00030918
		[Token(Token = "0x17000D40")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F90")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F91")]
		[Address(RVA = "0x21118F0", Offset = "0x21104F0", VA = "0x1821118F0")]
		public RoguelikeFragmentModuleData()
		{
		}

		// Token: 0x040060BF RID: 24767
		[Token(Token = "0x40060BF")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeFragmentData> fragmentData;

		// Token: 0x040060C0 RID: 24768
		[Token(Token = "0x40060C0")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeFragmentTypeData> fragmentTypeData;

		// Token: 0x040060C1 RID: 24769
		[Token(Token = "0x40060C1")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeFragmentModuleConsts moduleConsts;

		// Token: 0x040060C2 RID: 24770
		[Token(Token = "0x40060C2")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RoguelikeFragmentBuffData> fragmentBuffData;

		// Token: 0x040060C3 RID: 24771
		[Token(Token = "0x40060C3")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, RoguelikeAlchemyData> alchemyData;

		// Token: 0x040060C4 RID: 24772
		[Token(Token = "0x40060C4")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, RoguelikeAlchemyFormulationData> alchemyFormulaData;

		// Token: 0x040060C5 RID: 24773
		[Token(Token = "0x40060C5")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<int, RoguelikeFragmentLevelRelatedData> fragmentLevelData;
	}
}
