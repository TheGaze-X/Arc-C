using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001380 RID: 4992
	[Token(Token = "0x2001380")]
	[Serializable]
	public class StorylineSSData
	{
		// Token: 0x0600735E RID: 29534 RVA: 0x000334B0 File Offset: 0x000316B0
		[Token(Token = "0x600735E")]
		[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
		public bool ShouldSerializereopenActivityId()
		{
			return default(bool);
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x000334C8 File Offset: 0x000316C8
		[Token(Token = "0x600735F")]
		[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0")]
		public bool ShouldSerializeretroActivityId()
		{
			return default(bool);
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x000334E0 File Offset: 0x000316E0
		[Token(Token = "0x6007360")]
		[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
		public bool ShouldSerializeisRecommended()
		{
			return default(bool);
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x000334F8 File Offset: 0x000316F8
		[Token(Token = "0x6007361")]
		[Address(RVA = "0x1FFA6F0", Offset = "0x1FF92F0", VA = "0x181FFA6F0")]
		public bool ShouldSerializerecommendHideStageId()
		{
			return default(bool);
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x00033510 File Offset: 0x00031710
		[Token(Token = "0x6007362")]
		[Address(RVA = "0x2215900", Offset = "0x2214500", VA = "0x182215900")]
		public bool ShouldSerializeoverrideStageList()
		{
			return default(bool);
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007363")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineSSData()
		{
		}

		// Token: 0x04006ECB RID: 28363
		[Token(Token = "0x4006ECB")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x04006ECC RID: 28364
		[Token(Token = "0x4006ECC")]
		[FieldOffset(Offset = "0x18")]
		public string backgroundId;

		// Token: 0x04006ECD RID: 28365
		[Token(Token = "0x4006ECD")]
		[FieldOffset(Offset = "0x20")]
		public List<string> tags;

		// Token: 0x04006ECE RID: 28366
		[Token(Token = "0x4006ECE")]
		[FieldOffset(Offset = "0x28")]
		public string reopenActivityId;

		// Token: 0x04006ECF RID: 28367
		[Token(Token = "0x4006ECF")]
		[FieldOffset(Offset = "0x30")]
		public string retroActivityId;

		// Token: 0x04006ED0 RID: 28368
		[Token(Token = "0x4006ED0")]
		[FieldOffset(Offset = "0x38")]
		public bool isRecommended;

		// Token: 0x04006ED1 RID: 28369
		[Token(Token = "0x4006ED1")]
		[FieldOffset(Offset = "0x40")]
		public string recommendHideStageId;

		// Token: 0x04006ED2 RID: 28370
		[Token(Token = "0x4006ED2")]
		[FieldOffset(Offset = "0x48")]
		public List<string> overrideStageList;
	}
}
