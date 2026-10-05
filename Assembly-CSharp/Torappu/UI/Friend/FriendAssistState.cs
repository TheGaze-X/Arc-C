using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D52 RID: 19794
	[Token(Token = "0x2004D52")]
	public class FriendAssistState : State
	{
		// Token: 0x0601D9DD RID: 121309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9DD")]
		[Address(RVA = "0x1724740", Offset = "0x1723340", VA = "0x181724740", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D9DE RID: 121310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9DE")]
		[Address(RVA = "0x1724860", Offset = "0x1723460", VA = "0x181724860", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D9DF RID: 121311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9DF")]
		[Address(RVA = "0x1724A10", Offset = "0x1723610", VA = "0x181724A10", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601D9E0 RID: 121312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9E0")]
		[Address(RVA = "0x1724350", Offset = "0x1722F50", VA = "0x181724350")]
		public void ApplyFloatPanel(int index, string id, FriendAssistItemFloatPanel.ItemType type)
		{
		}

		// Token: 0x0601D9E1 RID: 121313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9E1")]
		[Address(RVA = "0x17247A0", Offset = "0x17233A0", VA = "0x1817247A0")]
		public void HideFloatPanel()
		{
		}

		// Token: 0x0601D9E2 RID: 121314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9E2")]
		[Address(RVA = "0x17244C0", Offset = "0x17230C0", VA = "0x1817244C0")]
		public void ApplySelect(int index, string id, FriendAssistItemFloatPanel.ItemType type)
		{
		}

		// Token: 0x0601D9E3 RID: 121315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9E3")]
		[Address(RVA = "0x1724D90", Offset = "0x1723990", VA = "0x181724D90")]
		public void ToSelectState(int index)
		{
		}

		// Token: 0x0601D9E4 RID: 121316 RVA: 0x000AC248 File Offset: 0x000AA448
		[Token(Token = "0x601D9E4")]
		[Address(RVA = "0x17253A0", Offset = "0x1723FA0", VA = "0x1817253A0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601D9E5 RID: 121317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9E5")]
		[Address(RVA = "0x1724AD0", Offset = "0x17236D0", VA = "0x181724AD0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601D9E6 RID: 121318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9E6")]
		[Address(RVA = "0x1724C30", Offset = "0x1723830", VA = "0x181724C30", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601D9E7 RID: 121319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9E7")]
		[Address(RVA = "0x1725410", Offset = "0x1724010", VA = "0x181725410")]
		public FriendAssistState()
		{
		}

		// Token: 0x0601D9EA RID: 121322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9EA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601D9EB RID: 121323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9EB")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601D9EC RID: 121324 RVA: 0x000AC260 File Offset: 0x000AA460
		[Token(Token = "0x601D9EC")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601D9ED RID: 121325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9ED")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601D9EE RID: 121326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9EE")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x040271EF RID: 160239
		[Token(Token = "0x40271EF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x040271F0 RID: 160240
		[Token(Token = "0x40271F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FriendListStateBean _stateBean;

		// Token: 0x040271F1 RID: 160241
		[Token(Token = "0x40271F1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private FriendStateControl _stateControl;

		// Token: 0x040271F2 RID: 160242
		[Token(Token = "0x40271F2")]
		[FieldOffset(Offset = "0x68")]
		private CharSelectStateBean.Input m_paramToSelectState;

		// Token: 0x040271F3 RID: 160243
		[Token(Token = "0x40271F3")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cachedSelectIndex;

		// Token: 0x040271F4 RID: 160244
		[Token(Token = "0x40271F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040271F5 RID: 160245
		[Token(Token = "0x40271F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040271F6 RID: 160246
		[Token(Token = "0x40271F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040271F7 RID: 160247
		[Token(Token = "0x40271F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyFloatPanel;

		// Token: 0x040271F8 RID: 160248
		[Token(Token = "0x40271F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideFloatPanel;

		// Token: 0x040271F9 RID: 160249
		[Token(Token = "0x40271F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplySelect;

		// Token: 0x040271FA RID: 160250
		[Token(Token = "0x40271FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ToSelectState;

		// Token: 0x040271FB RID: 160251
		[Token(Token = "0x40271FB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x040271FC RID: 160252
		[Token(Token = "0x40271FC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x040271FD RID: 160253
		[Token(Token = "0x40271FD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040271FE RID: 160254
		[Token(Token = "0x40271FE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D53 RID: 19795
		[Token(Token = "0x2004D53")]
		public class SelectCharPlugin : UICharacterSelectState.Plugin<FriendAssistState>
		{
			// Token: 0x17004587 RID: 17799
			// (get) Token: 0x0601D9EF RID: 121327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004587")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x601D9EF")]
				[Address(RVA = "0x173A130", Offset = "0x1738D30", VA = "0x18173A130", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004588 RID: 17800
			// (get) Token: 0x0601D9F0 RID: 121328 RVA: 0x000AC278 File Offset: 0x000AA478
			[Token(Token = "0x17004588")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x601D9F0")]
				[Address(RVA = "0x173A1A0", Offset = "0x1738DA0", VA = "0x18173A1A0", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004589 RID: 17801
			// (get) Token: 0x0601D9F1 RID: 121329 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004589")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x601D9F1")]
				[Address(RVA = "0x173A0D0", Offset = "0x1738CD0", VA = "0x18173A0D0", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601D9F2 RID: 121330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F2")]
			[Address(RVA = "0x17399D0", Offset = "0x17385D0", VA = "0x1817399D0", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x0601D9F3 RID: 121331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F3")]
			[Address(RVA = "0x1739DB0", Offset = "0x17389B0", VA = "0x181739DB0", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0601D9F4 RID: 121332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F4")]
			[Address(RVA = "0x1739E30", Offset = "0x1738A30", VA = "0x181739E30", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x0601D9F5 RID: 121333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F5")]
			[Address(RVA = "0x1739F30", Offset = "0x1738B30", VA = "0x181739F30", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x0601D9F6 RID: 121334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F6")]
			[Address(RVA = "0x1739930", Offset = "0x1738530", VA = "0x181739930", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x0601D9F7 RID: 121335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F7")]
			[Address(RVA = "0x1739FD0", Offset = "0x1738BD0", VA = "0x181739FD0", Slot = "24")]
			public override void PostUpdateAttribute(CharAttrViewModel attrModel)
			{
			}

			// Token: 0x0601D9F8 RID: 121336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F8")]
			[Address(RVA = "0x1739EB0", Offset = "0x1738AB0", VA = "0x181739EB0", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x0601D9F9 RID: 121337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9F9")]
			[Address(RVA = "0x17398B0", Offset = "0x17384B0", VA = "0x1817398B0", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x0601D9FA RID: 121338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9FA")]
			[Address(RVA = "0x173A060", Offset = "0x1738C60", VA = "0x18173A060")]
			public SelectCharPlugin()
			{
			}

			// Token: 0x040271FF RID: 160255
			[Token(Token = "0x40271FF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x04027200 RID: 160256
			[Token(Token = "0x4027200")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x04027201 RID: 160257
			[Token(Token = "0x4027201")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x04027202 RID: 160258
			[Token(Token = "0x4027202")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x04027203 RID: 160259
			[Token(Token = "0x4027203")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x04027204 RID: 160260
			[Token(Token = "0x4027204")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x04027205 RID: 160261
			[Token(Token = "0x4027205")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x04027206 RID: 160262
			[Token(Token = "0x4027206")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x04027207 RID: 160263
			[Token(Token = "0x4027207")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_PostUpdateAttribute;

			// Token: 0x04027208 RID: 160264
			[Token(Token = "0x4027208")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x04027209 RID: 160265
			[Token(Token = "0x4027209")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x0402720A RID: 160266
			[Token(Token = "0x402720A")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
