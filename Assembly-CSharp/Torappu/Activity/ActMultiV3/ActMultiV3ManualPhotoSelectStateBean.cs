using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F4A RID: 28490
	[Token(Token = "0x2006F4A")]
	public class ActMultiV3ManualPhotoSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06028767 RID: 165735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028767")]
		[Address(RVA = "0x23C0CC0", Offset = "0x23BF8C0", VA = "0x1823C0CC0")]
		public void SetInputData(ActMultiV3ManualPhotoSelectStateBean.Input input)
		{
		}

		// Token: 0x06028768 RID: 165736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028768")]
		[Address(RVA = "0x23C0D70", Offset = "0x23BF970", VA = "0x1823C0D70")]
		public ActMultiV3ManualPhotoSelectStateBean()
		{
		}

		// Token: 0x040398DF RID: 235743
		[Token(Token = "0x40398DF")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3ManualPhotoSelectProperty property;

		// Token: 0x040398E0 RID: 235744
		[Token(Token = "0x40398E0")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, FriendDataWithNameCard> cachedNameCardDict;

		// Token: 0x040398E1 RID: 235745
		[Token(Token = "0x40398E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetInputData;

		// Token: 0x040398E2 RID: 235746
		[Token(Token = "0x40398E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F4B RID: 28491
		[Token(Token = "0x2006F4B")]
		public class Input
		{
			// Token: 0x06028769 RID: 165737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028769")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040398E3 RID: 235747
			[Token(Token = "0x40398E3")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x040398E4 RID: 235748
			[Token(Token = "0x40398E4")]
			[FieldOffset(Offset = "0x18")]
			public string weekRewardId;

			// Token: 0x040398E5 RID: 235749
			[Token(Token = "0x40398E5")]
			[FieldOffset(Offset = "0x20")]
			public string photoTemplateId;

			// Token: 0x040398E6 RID: 235750
			[Token(Token = "0x40398E6")]
			[FieldOffset(Offset = "0x28")]
			public int photoTypeIdx;
		}
	}
}
