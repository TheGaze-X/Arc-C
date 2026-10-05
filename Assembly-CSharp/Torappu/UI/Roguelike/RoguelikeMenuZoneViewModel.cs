using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005357 RID: 21335
	[Token(Token = "0x2005357")]
	public class RoguelikeMenuZoneViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x0601F73B RID: 128827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F73B")]
		[Address(RVA = "0x192B950", Offset = "0x192A550", VA = "0x18192B950", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F73C RID: 128828 RVA: 0x000B1F78 File Offset: 0x000B0178
		[Token(Token = "0x601F73C")]
		[Address(RVA = "0x192B7E0", Offset = "0x192A3E0", VA = "0x18192B7E0")]
		public bool HasVariation()
		{
			return default(bool);
		}

		// Token: 0x0601F73D RID: 128829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F73D")]
		[Address(RVA = "0x192BE80", Offset = "0x192AA80", VA = "0x18192BE80")]
		public RoguelikeMenuZoneViewModel()
		{
		}

		// Token: 0x0601F73E RID: 128830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F73E")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A519 RID: 173337
		[Token(Token = "0x402A519")]
		[FieldOffset(Offset = "0x18")]
		public string currZoneId;

		// Token: 0x0402A51A RID: 173338
		[Token(Token = "0x402A51A")]
		[FieldOffset(Offset = "0x20")]
		public string currZoneName;

		// Token: 0x0402A51B RID: 173339
		[Token(Token = "0x402A51B")]
		[FieldOffset(Offset = "0x28")]
		public string currZoneDesc;

		// Token: 0x0402A51C RID: 173340
		[Token(Token = "0x402A51C")]
		[FieldOffset(Offset = "0x30")]
		public List<RoguelikeVariationModel> variationModels;

		// Token: 0x0402A51D RID: 173341
		[Token(Token = "0x402A51D")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeFusionModel fusionModel;

		// Token: 0x0402A51E RID: 173342
		[Token(Token = "0x402A51E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A51F RID: 173343
		[Token(Token = "0x402A51F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasVariation;

		// Token: 0x0402A520 RID: 173344
		[Token(Token = "0x402A520")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
