using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005358 RID: 21336
	[Token(Token = "0x2005358")]
	public class RoguelikeStatusBarHpWithMaxHpViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x0601F73F RID: 128831 RVA: 0x000B1F90 File Offset: 0x000B0190
		[Token(Token = "0x170049BF")]
		public bool needHideHpStatus
		{
			[Token(Token = "0x601F73F")]
			[Address(RVA = "0x1934ED0", Offset = "0x1933AD0", VA = "0x181934ED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F740 RID: 128832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F740")]
		[Address(RVA = "0x1934CF0", Offset = "0x19338F0", VA = "0x181934CF0", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F741 RID: 128833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F741")]
		[Address(RVA = "0x1934E30", Offset = "0x1933A30", VA = "0x181934E30")]
		public RoguelikeStatusBarHpWithMaxHpViewModel()
		{
		}

		// Token: 0x0601F742 RID: 128834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F742")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A521 RID: 173345
		[Token(Token = "0x402A521")]
		[FieldOffset(Offset = "0x18")]
		public int currHp;

		// Token: 0x0402A522 RID: 173346
		[Token(Token = "0x402A522")]
		[FieldOffset(Offset = "0x1C")]
		public int currMaxHp;

		// Token: 0x0402A523 RID: 173347
		[Token(Token = "0x402A523")]
		[FieldOffset(Offset = "0x20")]
		public int currShield;

		// Token: 0x0402A524 RID: 173348
		[Token(Token = "0x402A524")]
		[FieldOffset(Offset = "0x24")]
		public PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties.RewardHpShowStatus hpShowStatus;

		// Token: 0x0402A525 RID: 173349
		[Token(Token = "0x402A525")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needHideHpStatus;

		// Token: 0x0402A526 RID: 173350
		[Token(Token = "0x402A526")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A527 RID: 173351
		[Token(Token = "0x402A527")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
