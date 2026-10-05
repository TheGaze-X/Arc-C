using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D6C RID: 19820
	[Token(Token = "0x2004D6C")]
	public class FriendListStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0601DA9B RID: 121499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA9B")]
		[Address(RVA = "0x17269A0", Offset = "0x17255A0", VA = "0x1817269A0")]
		public void InitSpriteHub()
		{
		}

		// Token: 0x0601DA9C RID: 121500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA9C")]
		[Address(RVA = "0x1727320", Offset = "0x1725F20", VA = "0x181727320")]
		private void _InitSpriteHubsIfNeeded()
		{
		}

		// Token: 0x0601DA9D RID: 121501 RVA: 0x000AC2C0 File Offset: 0x000AA4C0
		[Token(Token = "0x601DA9D")]
		[Address(RVA = "0x1727070", Offset = "0x1725C70", VA = "0x181727070")]
		private bool _CheckIfAssistDiffFromPlayer()
		{
			return default(bool);
		}

		// Token: 0x0601DA9E RID: 121502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA9E")]
		[Address(RVA = "0x1726B10", Offset = "0x1725710", VA = "0x181726B10")]
		private void _ApplyAssist([Optional] FriendListStateBean.AssistApplyOptions options)
		{
		}

		// Token: 0x0601DA9F RID: 121503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA9F")]
		[Address(RVA = "0x1726A00", Offset = "0x1725600", VA = "0x181726A00")]
		public void LoadNecessarySprite(CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0601DAA0 RID: 121504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA0")]
		[Address(RVA = "0x1725670", Offset = "0x1724270", VA = "0x181725670")]
		public void ApplyListData(int index, GetFriendListResponse friendListData, List<string> idList)
		{
		}

		// Token: 0x0601DAA1 RID: 121505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA1")]
		[Address(RVA = "0x1726040", Offset = "0x1724C40", VA = "0x181726040")]
		public void ApplySearchData(int index, SearchPlayerResponse friendListData, List<string> idList)
		{
		}

		// Token: 0x0601DAA2 RID: 121506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA2")]
		[Address(RVA = "0x1725C40", Offset = "0x1724840", VA = "0x181725C40")]
		public void ApplyRequestListData(int index, GetFriendRequestResponse friendListData, List<string> idList)
		{
		}

		// Token: 0x0601DAA3 RID: 121507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA3")]
		[Address(RVA = "0x1725560", Offset = "0x1724160", VA = "0x181725560")]
		public void ApplyFriendAssistFloatPanel(int index, string id, FriendAssistItemFloatPanel.ItemType type)
		{
		}

		// Token: 0x0601DAA4 RID: 121508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA4")]
		[Address(RVA = "0x17268C0", Offset = "0x17254C0", VA = "0x1817268C0")]
		public void ApplySkillId(int characterIndex, string skillId)
		{
		}

		// Token: 0x0601DAA5 RID: 121509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA5")]
		[Address(RVA = "0x1725480", Offset = "0x1724080", VA = "0x181725480")]
		public void ApplyEquipId(int characterIndex, string equipId)
		{
		}

		// Token: 0x0601DAA6 RID: 121510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA6")]
		[Address(RVA = "0x1726A90", Offset = "0x1725690", VA = "0x181726A90")]
		public void SaveAssistIfNeeded()
		{
		}

		// Token: 0x0601DAA7 RID: 121511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA7")]
		[Address(RVA = "0x1726690", Offset = "0x1725290", VA = "0x181726690")]
		public void ApplySelectState(CharSelectStateBean selectStateBean)
		{
		}

		// Token: 0x0601DAA8 RID: 121512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAA8")]
		[Address(RVA = "0x17273D0", Offset = "0x1725FD0", VA = "0x1817273D0")]
		public FriendListStateBean()
		{
		}

		// Token: 0x04027306 RID: 160518
		[Token(Token = "0x4027306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string searchWord;

		// Token: 0x04027307 RID: 160519
		[Token(Token = "0x4027307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public SharedCharData[] selectedAssist;

		// Token: 0x04027308 RID: 160520
		[Token(Token = "0x4027308")]
		public const int PER_PAGE_COUNT = 10;

		// Token: 0x04027309 RID: 160521
		[Token(Token = "0x4027309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpriteHub m_professionIconHub;

		// Token: 0x0402730A RID: 160522
		[Token(Token = "0x402730A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public TrackPointViewProperty friendRequestTrackProp;

		// Token: 0x0402730B RID: 160523
		[Token(Token = "0x402730B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public TrackPointViewProperty friendListTrackProp;

		// Token: 0x0402730C RID: 160524
		[Token(Token = "0x402730C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public TrackPointViewProperty btnEditStarTrackProp;

		// Token: 0x0402730D RID: 160525
		[Token(Token = "0x402730D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FriendListProperty friendListProperty;

		// Token: 0x0402730E RID: 160526
		[Token(Token = "0x402730E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitSpriteHub;

		// Token: 0x0402730F RID: 160527
		[Token(Token = "0x402730F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitSpriteHubsIfNeeded;

		// Token: 0x04027310 RID: 160528
		[Token(Token = "0x4027310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfAssistDiffFromPlayer;

		// Token: 0x04027311 RID: 160529
		[Token(Token = "0x4027311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyAssist;

		// Token: 0x04027312 RID: 160530
		[Token(Token = "0x4027312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadNecessarySprite;

		// Token: 0x04027313 RID: 160531
		[Token(Token = "0x4027313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyListData;

		// Token: 0x04027314 RID: 160532
		[Token(Token = "0x4027314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplySearchData;

		// Token: 0x04027315 RID: 160533
		[Token(Token = "0x4027315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ApplyRequestListData;

		// Token: 0x04027316 RID: 160534
		[Token(Token = "0x4027316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyFriendAssistFloatPanel;

		// Token: 0x04027317 RID: 160535
		[Token(Token = "0x4027317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplySkillId;

		// Token: 0x04027318 RID: 160536
		[Token(Token = "0x4027318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyEquipId;

		// Token: 0x04027319 RID: 160537
		[Token(Token = "0x4027319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SaveAssistIfNeeded;

		// Token: 0x0402731A RID: 160538
		[Token(Token = "0x402731A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ApplySelectState;

		// Token: 0x0402731B RID: 160539
		[Token(Token = "0x402731B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D6D RID: 19821
		[Token(Token = "0x2004D6D")]
		private class AssistApplyOptions
		{
			// Token: 0x0601DAA9 RID: 121513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DAA9")]
			[Address(RVA = "0x173B1A0", Offset = "0x1739DA0", VA = "0x18173B1A0")]
			public AssistApplyOptions()
			{
			}

			// Token: 0x0402731C RID: 160540
			[Token(Token = "0x402731C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int characterIndex;

			// Token: 0x0402731D RID: 160541
			[Token(Token = "0x402731D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool applySkill;

			// Token: 0x0402731E RID: 160542
			[Token(Token = "0x402731E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string skillId;

			// Token: 0x0402731F RID: 160543
			[Token(Token = "0x402731F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool applyEquip;

			// Token: 0x04027320 RID: 160544
			[Token(Token = "0x4027320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string equipId;
		}
	}
}
