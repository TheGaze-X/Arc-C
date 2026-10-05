using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200579C RID: 22428
	[Token(Token = "0x200579C")]
	public class RL02ZoneWithSanViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x06020CE6 RID: 134374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CE6")]
		[Address(RVA = "0x1B2A990", Offset = "0x1B29590", VA = "0x181B2A990", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020CE7 RID: 134375 RVA: 0x000B7600 File Offset: 0x000B5800
		[Token(Token = "0x6020CE7")]
		[Address(RVA = "0x1B2A8B0", Offset = "0x1B294B0", VA = "0x181B2A8B0")]
		public bool HasVariation()
		{
			return default(bool);
		}

		// Token: 0x06020CE8 RID: 134376 RVA: 0x000B7618 File Offset: 0x000B5818
		[Token(Token = "0x6020CE8")]
		[Address(RVA = "0x1B2A930", Offset = "0x1B29530", VA = "0x181B2A930")]
		public bool IsSanSystemValid()
		{
			return default(bool);
		}

		// Token: 0x06020CE9 RID: 134377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CE9")]
		[Address(RVA = "0x1B2AF80", Offset = "0x1B29B80", VA = "0x181B2AF80")]
		public RL02ZoneWithSanViewModel()
		{
		}

		// Token: 0x06020CEA RID: 134378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CEA")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402C93F RID: 182591
		[Token(Token = "0x402C93F")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402C940 RID: 182592
		[Token(Token = "0x402C940")]
		[FieldOffset(Offset = "0x20")]
		public string currZoneId;

		// Token: 0x0402C941 RID: 182593
		[Token(Token = "0x402C941")]
		[FieldOffset(Offset = "0x28")]
		public string currZoneName;

		// Token: 0x0402C942 RID: 182594
		[Token(Token = "0x402C942")]
		[FieldOffset(Offset = "0x30")]
		public List<RoguelikeVariationModel> variations;

		// Token: 0x0402C943 RID: 182595
		[Token(Token = "0x402C943")]
		[FieldOffset(Offset = "0x38")]
		public int sanValue;

		// Token: 0x0402C944 RID: 182596
		[Token(Token = "0x402C944")]
		[FieldOffset(Offset = "0x40")]
		public string sanDesc;

		// Token: 0x0402C945 RID: 182597
		[Token(Token = "0x402C945")]
		[FieldOffset(Offset = "0x48")]
		public SanEffectRank sanEffectRank;

		// Token: 0x0402C946 RID: 182598
		[Token(Token = "0x402C946")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C947 RID: 182599
		[Token(Token = "0x402C947")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasVariation;

		// Token: 0x0402C948 RID: 182600
		[Token(Token = "0x402C948")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsSanSystemValid;

		// Token: 0x0402C949 RID: 182601
		[Token(Token = "0x402C949")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
