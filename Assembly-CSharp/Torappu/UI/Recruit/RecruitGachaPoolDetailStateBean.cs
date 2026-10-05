using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200470B RID: 18187
	[Token(Token = "0x200470B")]
	public class RecruitGachaPoolDetailStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0601B92F RID: 112943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B92F")]
		[Address(RVA = "0x14DFF60", Offset = "0x14DEB60", VA = "0x1814DFF60")]
		public RecruitGachaPoolDetailStateBean()
		{
		}

		// Token: 0x04023B67 RID: 146279
		[Token(Token = "0x4023B67")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string poolId;

		// Token: 0x04023B68 RID: 146280
		[Token(Token = "0x4023B68")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public RecruitGachaPoolDetailStateBean.GachaDetailExtraInput extraInput;

		// Token: 0x04023B69 RID: 146281
		[Token(Token = "0x4023B69")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		public bool needCleanCache;

		// Token: 0x04023B6A RID: 146282
		[Token(Token = "0x4023B6A")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Dictionary<string, GetDetailGachaResponse> cacheDetailDataMap;

		// Token: 0x04023B6B RID: 146283
		[Token(Token = "0x4023B6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200470C RID: 18188
		[Token(Token = "0x200470C")]
		public struct GachaDetailExtraInput
		{
			// Token: 0x04023B6C RID: 146284
			[Token(Token = "0x4023B6C")]
			[FieldOffset(Offset = "0x0")]
			public bool needScroll;

			// Token: 0x04023B6D RID: 146285
			[Token(Token = "0x4023B6D")]
			[FieldOffset(Offset = "0x4")]
			public int scrollIndex;

			// Token: 0x04023B6E RID: 146286
			[Token(Token = "0x4023B6E")]
			[FieldOffset(Offset = "0x8")]
			public GachaDetailData.GachaObjGroupType usingGroupType;
		}
	}
}
