using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054E2 RID: 21730
	[Token(Token = "0x20054E2")]
	public class RoguelikeGameShopDialogViewModel : IHotfixable
	{
		// Token: 0x17004AD9 RID: 19161
		// (get) Token: 0x0601FF5C RID: 130908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AD9")]
		public string dialogStr
		{
			[Token(Token = "0x601FF5C")]
			[Address(RVA = "0x1A10250", Offset = "0x1A0EE50", VA = "0x181A10250")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004ADA RID: 19162
		// (get) Token: 0x0601FF5D RID: 130909 RVA: 0x000B3EC8 File Offset: 0x000B20C8
		[Token(Token = "0x17004ADA")]
		public bool npcExist
		{
			[Token(Token = "0x601FF5D")]
			[Address(RVA = "0x1A102B0", Offset = "0x1A0EEB0", VA = "0x181A102B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601FF5E RID: 130910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF5E")]
		[Address(RVA = "0x1A0FDA0", Offset = "0x1A0E9A0", VA = "0x181A0FDA0")]
		public void InjectPlugin(RoguelikeGameShopDialogViewModel.DialogViewModelPlugin plugin)
		{
		}

		// Token: 0x0601FF5F RID: 130911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF5F")]
		[Address(RVA = "0x1A0FC30", Offset = "0x1A0E830", VA = "0x181A0FC30")]
		public void Init(string topicId, bool npcExist = true)
		{
		}

		// Token: 0x0601FF60 RID: 130912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF60")]
		[Address(RVA = "0x1A0FE20", Offset = "0x1A0EA20", VA = "0x181A0FE20")]
		public void UpdateDialogType(RoguelikeGameShopDialogType dialogType, RoguelikeGameItemType itemType = RoguelikeGameItemType.NONE)
		{
		}

		// Token: 0x0601FF61 RID: 130913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FF61")]
		[Address(RVA = "0x1A10060", Offset = "0x1A0EC60", VA = "0x181A10060")]
		private string _GetRandomDialog(RoguelikeGameShopDialogType dialogType, RoguelikeGameItemType itemType)
		{
			return null;
		}

		// Token: 0x0601FF62 RID: 130914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF62")]
		[Address(RVA = "0x1A101F0", Offset = "0x1A0EDF0", VA = "0x181A101F0")]
		public RoguelikeGameShopDialogViewModel()
		{
		}

		// Token: 0x0402B1D7 RID: 176599
		[Token(Token = "0x402B1D7")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeGameShopDialogViewModel.DialogViewModelPlugin m_dialogPlugin;

		// Token: 0x0402B1D8 RID: 176600
		[Token(Token = "0x402B1D8")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x0402B1D9 RID: 176601
		[Token(Token = "0x402B1D9")]
		[FieldOffset(Offset = "0x20")]
		private RoguelikeGameShopDialogData m_dialogData;

		// Token: 0x0402B1DA RID: 176602
		[Token(Token = "0x402B1DA")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeGameShopDialogType m_dialogType;

		// Token: 0x0402B1DB RID: 176603
		[Token(Token = "0x402B1DB")]
		[FieldOffset(Offset = "0x30")]
		private string m_dialogStr;

		// Token: 0x0402B1DC RID: 176604
		[Token(Token = "0x402B1DC")]
		private const int REWARD_HINT_MAX = 5;

		// Token: 0x0402B1DD RID: 176605
		[Token(Token = "0x402B1DD")]
		[FieldOffset(Offset = "0x38")]
		private int m_rewardHintCount;

		// Token: 0x0402B1DE RID: 176606
		[Token(Token = "0x402B1DE")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_npcExsit;

		// Token: 0x0402B1DF RID: 176607
		[Token(Token = "0x402B1DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogStr;

		// Token: 0x0402B1E0 RID: 176608
		[Token(Token = "0x402B1E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_npcExist;

		// Token: 0x0402B1E1 RID: 176609
		[Token(Token = "0x402B1E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x0402B1E2 RID: 176610
		[Token(Token = "0x402B1E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402B1E3 RID: 176611
		[Token(Token = "0x402B1E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateDialogType;

		// Token: 0x0402B1E4 RID: 176612
		[Token(Token = "0x402B1E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetRandomDialog;

		// Token: 0x0402B1E5 RID: 176613
		[Token(Token = "0x402B1E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020054E3 RID: 21731
		[Token(Token = "0x20054E3")]
		public abstract class DialogViewModelPlugin
		{
			// Token: 0x0601FF63 RID: 130915
			[Token(Token = "0x601FF63")]
			public abstract RoguelikeGameShopDialogData OverrideDialogData(string topicId);

			// Token: 0x0601FF64 RID: 130916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF64")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected DialogViewModelPlugin()
			{
			}
		}
	}
}
