using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DC8 RID: 28104
	[Token(Token = "0x2006DC8")]
	public class ActVecBreakV2AchvSquadItemModel : IHotfixable
	{
		// Token: 0x17005EA6 RID: 24230
		// (get) Token: 0x06028056 RID: 163926 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028057 RID: 163927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA6")]
		public ActVecBreakV2AchvSquadCharModel charModel
		{
			[Token(Token = "0x6028056")]
			[Address(RVA = "0x2349C50", Offset = "0x2348850", VA = "0x182349C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028057")]
			[Address(RVA = "0x2349D10", Offset = "0x2348910", VA = "0x182349D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005EA7 RID: 24231
		// (get) Token: 0x06028058 RID: 163928 RVA: 0x000D06C8 File Offset: 0x000CE8C8
		// (set) Token: 0x06028059 RID: 163929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA7")]
		public bool isAssist
		{
			[Token(Token = "0x6028058")]
			[Address(RVA = "0x2349CB0", Offset = "0x23488B0", VA = "0x182349CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028059")]
			[Address(RVA = "0x2349D90", Offset = "0x2348990", VA = "0x182349D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602805A RID: 163930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602805A")]
		[Address(RVA = "0x2349AB0", Offset = "0x23486B0", VA = "0x182349AB0")]
		public void LoadData(ActVecBreakV2AchvSquadCharModel charModel, bool isAssist)
		{
		}

		// Token: 0x0602805B RID: 163931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602805B")]
		[Address(RVA = "0x2349BF0", Offset = "0x23487F0", VA = "0x182349BF0")]
		public ActVecBreakV2AchvSquadItemModel()
		{
		}

		// Token: 0x04038BEC RID: 232428
		[Token(Token = "0x4038BEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charModel;

		// Token: 0x04038BED RID: 232429
		[Token(Token = "0x4038BED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charModel;

		// Token: 0x04038BEE RID: 232430
		[Token(Token = "0x4038BEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAssist;

		// Token: 0x04038BEF RID: 232431
		[Token(Token = "0x4038BEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isAssist;

		// Token: 0x04038BF0 RID: 232432
		[Token(Token = "0x4038BF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038BF1 RID: 232433
		[Token(Token = "0x4038BF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
