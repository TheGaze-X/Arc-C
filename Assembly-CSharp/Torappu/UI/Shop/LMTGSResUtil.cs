using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF3 RID: 23283
	[Token(Token = "0x2005AF3")]
	public static class LMTGSResUtil
	{
		// Token: 0x06021D5C RID: 138588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D5C")]
		[Address(RVA = "0x1C43590", Offset = "0x1C42190", VA = "0x181C43590")]
		public static GameObject LoadLMGTSRes(string resId)
		{
			return null;
		}

		// Token: 0x06021D5D RID: 138589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D5D")]
		[Address(RVA = "0x1C435F0", Offset = "0x1C421F0", VA = "0x181C435F0")]
		public static SpriteHub LoadPriceTypeHub()
		{
			return null;
		}

		// Token: 0x06021D5E RID: 138590 RVA: 0x000BB620 File Offset: 0x000B9820
		[Token(Token = "0x6021D5E")]
		[Address(RVA = "0x1C43960", Offset = "0x1C42560", VA = "0x181C43960")]
		public static bool ReturnOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x06021D5F RID: 138591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D5F")]
		[Address(RVA = "0x1C43670", Offset = "0x1C42270", VA = "0x181C43670")]
		public static Sprite LoadTabButtonSprite(List<string> activeLMGTSShop, bool active)
		{
			return null;
		}

		// Token: 0x0402E549 RID: 189769
		[Token(Token = "0x402E549")]
		public const string LMTGS_BUTTON = "qctab_lm";

		// Token: 0x0402E54A RID: 189770
		[Token(Token = "0x402E54A")]
		public const string EPGS_BUTTON = "qctab_eq";

		// Token: 0x0402E54B RID: 189771
		[Token(Token = "0x402E54B")]
		public const string LMTGS_VIEW = "limit_qc_shop";

		// Token: 0x0402E54C RID: 189772
		[Token(Token = "0x402E54C")]
		public const string EPGS_VIEW = "e_qc_shop";

		// Token: 0x0402E54D RID: 189773
		[Token(Token = "0x402E54D")]
		public const string EPGS_DETAIL_BUTTON = "qc_limit_detail_button";

		// Token: 0x0402E54E RID: 189774
		[Token(Token = "0x402E54E")]
		public const string PRICE_TYPE = "price_type";

		// Token: 0x0402E54F RID: 189775
		[Token(Token = "0x402E54F")]
		private const string DEFAULT_LMGTS_TAG_NAME = "default";
	}
}
