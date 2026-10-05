using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200762C RID: 30252
	[Token(Token = "0x200762C")]
	public class Act20sideDetailPage : StateEnginePage
	{
		// Token: 0x0602A95D RID: 174429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A95D")]
		[Address(RVA = "0x2657BE0", Offset = "0x26567E0", VA = "0x182657BE0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602A95E RID: 174430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A95E")]
		[Address(RVA = "0x2657D20", Offset = "0x2656920", VA = "0x182657D20", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x0602A95F RID: 174431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A95F")]
		[Address(RVA = "0x2657CC0", Offset = "0x26568C0", VA = "0x182657CC0", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0602A960 RID: 174432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A960")]
		[Address(RVA = "0x2657E60", Offset = "0x2656A60", VA = "0x182657E60")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0602A961 RID: 174433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A961")]
		[Address(RVA = "0x2657F00", Offset = "0x2656B00", VA = "0x182657F00")]
		public Act20sideDetailPage()
		{
		}

		// Token: 0x0602A963 RID: 174435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A963")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602A964 RID: 174436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A964")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x0602A965 RID: 174437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A965")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0403D4F6 RID: 251126
		[Token(Token = "0x403D4F6")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403D4F7 RID: 251127
		[Token(Token = "0x403D4F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403D4F8 RID: 251128
		[Token(Token = "0x403D4F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0403D4F9 RID: 251129
		[Token(Token = "0x403D4F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0403D4FA RID: 251130
		[Token(Token = "0x403D4FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0403D4FB RID: 251131
		[Token(Token = "0x403D4FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200762D RID: 30253
		[Token(Token = "0x200762D")]
		public class Param
		{
			// Token: 0x0602A966 RID: 174438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A966")]
			[Address(RVA = "0x2664E30", Offset = "0x2663A30", VA = "0x182664E30")]
			public Param(PlayerCartInfo.Cart cart, PlayerStatus status)
			{
			}

			// Token: 0x0602A967 RID: 174439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A967")]
			[Address(RVA = "0x2664D30", Offset = "0x2663930", VA = "0x182664D30")]
			public Param(bool isNpc, VoteCarViewModel carVoteViewModel)
			{
			}

			// Token: 0x0403D4FC RID: 251132
			[Token(Token = "0x403D4FC")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403D4FD RID: 251133
			[Token(Token = "0x403D4FD")]
			[FieldOffset(Offset = "0x18")]
			public PlayerCartInfo.Cart cart;

			// Token: 0x0403D4FE RID: 251134
			[Token(Token = "0x403D4FE")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x0403D4FF RID: 251135
			[Token(Token = "0x403D4FF")]
			[FieldOffset(Offset = "0x28")]
			public int playerLevel;

			// Token: 0x0403D500 RID: 251136
			[Token(Token = "0x403D500")]
			[FieldOffset(Offset = "0x30")]
			public string playerNumber;

			// Token: 0x0403D501 RID: 251137
			[Token(Token = "0x403D501")]
			[FieldOffset(Offset = "0x38")]
			public AvatarInfo playerAvatarInfo;

			// Token: 0x0403D502 RID: 251138
			[Token(Token = "0x403D502")]
			[FieldOffset(Offset = "0x40")]
			public bool isNpc;

			// Token: 0x0403D503 RID: 251139
			[Token(Token = "0x403D503")]
			[FieldOffset(Offset = "0x48")]
			public string npcPicId;
		}
	}
}
