using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E71 RID: 20081
	[Token(Token = "0x2004E71")]
	public class FireworkPuzzleResultStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x0601DF83 RID: 122755 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF84 RID: 122756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004659")]
		public FireworkPlateModel cachePlateModel
		{
			[Token(Token = "0x601DF83")]
			[Address(RVA = "0x17ACA20", Offset = "0x17AB620", VA = "0x1817ACA20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF84")]
			[Address(RVA = "0x17ACBA0", Offset = "0x17AB7A0", VA = "0x1817ACBA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x0601DF85 RID: 122757 RVA: 0x000AD0D0 File Offset: 0x000AB2D0
		// (set) Token: 0x0601DF86 RID: 122758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700465A")]
		public bool isFirstComplete
		{
			[Token(Token = "0x601DF85")]
			[Address(RVA = "0x17ACA80", Offset = "0x17AB680", VA = "0x1817ACA80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601DF86")]
			[Address(RVA = "0x17ACC20", Offset = "0x17AB820", VA = "0x1817ACC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x0601DF87 RID: 122759 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF88 RID: 122760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700465B")]
		public List<RewardItemModel> rewardList
		{
			[Token(Token = "0x601DF87")]
			[Address(RVA = "0x17ACB40", Offset = "0x17AB740", VA = "0x1817ACB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF88")]
			[Address(RVA = "0x17ACC90", Offset = "0x17AB890", VA = "0x1817ACC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x0601DF89 RID: 122761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700465C")]
		public FireworkPuzzleResultProp prop
		{
			[Token(Token = "0x601DF89")]
			[Address(RVA = "0x17ACAE0", Offset = "0x17AB6E0", VA = "0x1817ACAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DF8A RID: 122762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF8A")]
		[Address(RVA = "0x17AC930", Offset = "0x17AB530", VA = "0x1817AC930")]
		public FireworkPuzzleResultStateBean()
		{
		}

		// Token: 0x04027CD1 RID: 163025
		[Token(Token = "0x4027CD1")]
		[FieldOffset(Offset = "0x10")]
		private FireworkPuzzleResultProp m_prop;

		// Token: 0x04027CD5 RID: 163029
		[Token(Token = "0x4027CD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachePlateModel;

		// Token: 0x04027CD6 RID: 163030
		[Token(Token = "0x4027CD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cachePlateModel;

		// Token: 0x04027CD7 RID: 163031
		[Token(Token = "0x4027CD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isFirstComplete;

		// Token: 0x04027CD8 RID: 163032
		[Token(Token = "0x4027CD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isFirstComplete;

		// Token: 0x04027CD9 RID: 163033
		[Token(Token = "0x4027CD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rewardList;

		// Token: 0x04027CDA RID: 163034
		[Token(Token = "0x4027CDA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_rewardList;

		// Token: 0x04027CDB RID: 163035
		[Token(Token = "0x4027CDB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04027CDC RID: 163036
		[Token(Token = "0x4027CDC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
