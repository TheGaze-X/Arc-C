using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E27 RID: 24103
	[Token(Token = "0x2005E27")]
	public class CharacterRepoPage : StateEnginePage, IHotfixable
	{
		// Token: 0x170052C7 RID: 21191
		// (get) Token: 0x06022EBF RID: 143039 RVA: 0x000BF778 File Offset: 0x000BD978
		[Token(Token = "0x170052C7")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x6022EBF")]
			[Address(RVA = "0x1D7D750", Offset = "0x1D7C350", VA = "0x181D7D750", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x06022EC0 RID: 143040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EC0")]
		[Address(RVA = "0x1D7CC40", Offset = "0x1D7B840", VA = "0x181D7CC40", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06022EC1 RID: 143041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EC1")]
		[Address(RVA = "0x1D7CB60", Offset = "0x1D7B760", VA = "0x181D7CB60", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06022EC2 RID: 143042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022EC2")]
		[Address(RVA = "0x1D7BC80", Offset = "0x1D7A880", VA = "0x181D7BC80", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06022EC3 RID: 143043 RVA: 0x000BF790 File Offset: 0x000BD990
		[Token(Token = "0x6022EC3")]
		[Address(RVA = "0x1D7BB50", Offset = "0x1D7A750", VA = "0x181D7BB50", Slot = "18")]
		public override bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x06022EC4 RID: 143044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EC4")]
		[Address(RVA = "0x1D7C390", Offset = "0x1D7AF90", VA = "0x181D7C390")]
		public void EventOnSortTypeClick(CharacterSortType sortType)
		{
		}

		// Token: 0x06022EC5 RID: 143045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EC5")]
		[Address(RVA = "0x1D7C8A0", Offset = "0x1D7B4A0", VA = "0x181D7C8A0")]
		public void EventOnTrackPointFilterClick()
		{
		}

		// Token: 0x06022EC6 RID: 143046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EC6")]
		[Address(RVA = "0x1D7C5C0", Offset = "0x1D7B1C0", VA = "0x181D7C5C0")]
		public void EventOnStarMarkTopClick()
		{
		}

		// Token: 0x06022EC7 RID: 143047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EC7")]
		[Address(RVA = "0x1D7BD60", Offset = "0x1D7A960", VA = "0x181D7BD60")]
		public void EventOnCharacterCardClick(int chrInstId)
		{
		}

		// Token: 0x06022EC8 RID: 143048 RVA: 0x000BF7A8 File Offset: 0x000BD9A8
		[Token(Token = "0x6022EC8")]
		[Address(RVA = "0x1D7CF30", Offset = "0x1D7BB30", VA = "0x181D7CF30")]
		private bool _CheckJumpToHandBookStage(CharacterRepoStateBean stateBean, int chrInstId)
		{
			return default(bool);
		}

		// Token: 0x06022EC9 RID: 143049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022EC9")]
		[Address(RVA = "0x1D7D0F0", Offset = "0x1D7BCF0", VA = "0x181D7D0F0")]
		private DataBundle _GenJumpToHandBookStageBundle(string charId, List<int> charList)
		{
			return null;
		}

		// Token: 0x06022ECA RID: 143050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ECA")]
		[Address(RVA = "0x1D7D220", Offset = "0x1D7BE20", VA = "0x181D7D220")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06022ECB RID: 143051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ECB")]
		[Address(RVA = "0x1D7D530", Offset = "0x1D7C130", VA = "0x181D7D530")]
		private void _ShowCharacterInfo(int charInstId, List<int> charList)
		{
		}

		// Token: 0x06022ECC RID: 143052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ECC")]
		[Address(RVA = "0x1D7D350", Offset = "0x1D7BF50", VA = "0x181D7D350")]
		private void _ShowCharacterHandbookStageInfo(string charId, List<int> charList)
		{
		}

		// Token: 0x06022ECD RID: 143053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022ECD")]
		[Address(RVA = "0x1D7D060", Offset = "0x1D7BC60", VA = "0x181D7D060")]
		private static IEnumerator<string> _EnumAllPlayerCharIds()
		{
			return null;
		}

		// Token: 0x06022ECE RID: 143054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022ECE")]
		[Address(RVA = "0x1D7D660", Offset = "0x1D7C260", VA = "0x181D7D660")]
		private static IEnumerator<KeyValuePair<string, TrackPointCacheGroup>> _TraceForCharsViewed()
		{
			return null;
		}

		// Token: 0x06022ECF RID: 143055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ECF")]
		[Address(RVA = "0x1D7D6F0", Offset = "0x1D7C2F0", VA = "0x181D7D6F0")]
		public CharacterRepoPage()
		{
		}

		// Token: 0x06022ED2 RID: 143058 RVA: 0x000BF7C0 File Offset: 0x000BD9C0
		[Token(Token = "0x6022ED2")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x06022ED3 RID: 143059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ED3")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06022ED4 RID: 143060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ED4")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06022ED5 RID: 143061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022ED5")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x06022ED6 RID: 143062 RVA: 0x000BF7D8 File Offset: 0x000BD9D8
		[Token(Token = "0x6022ED6")]
		[Address(RVA = "0x1071280", Offset = "0x106FE80", VA = "0x181071280")]
		private bool <>xLuaBaseProxy_CustomSetActive(bool P0)
		{
			return default(bool);
		}

		// Token: 0x040301CC RID: 197068
		[Token(Token = "0x40301CC")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Tooltip("The scroll rect to stop when screen shotting")]
		private LoopScrollRect _scrollRectToStop;

		// Token: 0x040301CD RID: 197069
		[Token(Token = "0x40301CD")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _cardGroupPage;

		// Token: 0x040301CE RID: 197070
		[Token(Token = "0x40301CE")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x040301CF RID: 197071
		[Token(Token = "0x40301CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x040301D0 RID: 197072
		[Token(Token = "0x40301D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040301D1 RID: 197073
		[Token(Token = "0x40301D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040301D2 RID: 197074
		[Token(Token = "0x40301D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x040301D3 RID: 197075
		[Token(Token = "0x40301D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x040301D4 RID: 197076
		[Token(Token = "0x40301D4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSortTypeClick;

		// Token: 0x040301D5 RID: 197077
		[Token(Token = "0x40301D5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnTrackPointFilterClick;

		// Token: 0x040301D6 RID: 197078
		[Token(Token = "0x40301D6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnStarMarkTopClick;

		// Token: 0x040301D7 RID: 197079
		[Token(Token = "0x40301D7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnCharacterCardClick;

		// Token: 0x040301D8 RID: 197080
		[Token(Token = "0x40301D8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckJumpToHandBookStage;

		// Token: 0x040301D9 RID: 197081
		[Token(Token = "0x40301D9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenJumpToHandBookStageBundle;

		// Token: 0x040301DA RID: 197082
		[Token(Token = "0x40301DA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x040301DB RID: 197083
		[Token(Token = "0x40301DB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowCharacterInfo;

		// Token: 0x040301DC RID: 197084
		[Token(Token = "0x40301DC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ShowCharacterHandbookStageInfo;

		// Token: 0x040301DD RID: 197085
		[Token(Token = "0x40301DD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EnumAllPlayerCharIds;

		// Token: 0x040301DE RID: 197086
		[Token(Token = "0x40301DE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TraceForCharsViewed;

		// Token: 0x040301DF RID: 197087
		[Token(Token = "0x40301DF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
