using System;
using Il2CppDummyDll;
using Torappu.UI.SiracusaMap.Chat;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F6C RID: 16236
	[Token(Token = "0x2003F6C")]
	public class SiracusaMapChatState : PopupFloatState, IHotfixable, ISiracusaReplaceable
	{
		// Token: 0x0601931C RID: 103196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601931C")]
		[Address(RVA = "0x11EABF0", Offset = "0x11E97F0", VA = "0x1811EABF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601931D RID: 103197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601931D")]
		[Address(RVA = "0x11EAC50", Offset = "0x11E9850", VA = "0x1811EAC50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601931E RID: 103198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601931E")]
		[Address(RVA = "0x11EAEB0", Offset = "0x11E9AB0", VA = "0x1811EAEB0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601931F RID: 103199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601931F")]
		[Address(RVA = "0x11EADD0", Offset = "0x11E99D0", VA = "0x1811EADD0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06019320 RID: 103200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019320")]
		[Address(RVA = "0x11EA7E0", Offset = "0x11E93E0", VA = "0x1811EA7E0", Slot = "27")]
		protected sealed override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06019321 RID: 103201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019321")]
		[Address(RVA = "0x11EA930", Offset = "0x11E9530", VA = "0x1811EA930", Slot = "28")]
		protected sealed override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06019322 RID: 103202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019322")]
		[Address(RVA = "0x11EAA80", Offset = "0x11E9680", VA = "0x1811EAA80")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06019323 RID: 103203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019323")]
		[Address(RVA = "0x11EB5C0", Offset = "0x11EA1C0", VA = "0x1811EB5C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019324 RID: 103204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019324")]
		[Address(RVA = "0x11EC010", Offset = "0x11EAC10", VA = "0x1811EC010")]
		private void _RedirectTarget()
		{
		}

		// Token: 0x06019325 RID: 103205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019325")]
		[Address(RVA = "0x11EB0F0", Offset = "0x11E9CF0", VA = "0x1811EB0F0")]
		private void _ClearChatModel()
		{
		}

		// Token: 0x06019326 RID: 103206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019326")]
		[Address(RVA = "0x11EBC10", Offset = "0x11EA810", VA = "0x1811EBC10")]
		private void _OnOptionSelect(string optionId)
		{
		}

		// Token: 0x06019327 RID: 103207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019327")]
		[Address(RVA = "0x11EB840", Offset = "0x11EA440", VA = "0x1811EB840")]
		private void _OnItemObtain(string itemId)
		{
		}

		// Token: 0x06019328 RID: 103208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019328")]
		[Address(RVA = "0x11EB1D0", Offset = "0x11E9DD0", VA = "0x1811EB1D0")]
		private void _CompleteTaskIfNeed(Action onComplete)
		{
		}

		// Token: 0x06019329 RID: 103209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019329")]
		[Address(RVA = "0x11EC220", Offset = "0x11EAE20", VA = "0x1811EC220")]
		public SiracusaMapChatState()
		{
		}

		// Token: 0x0601932C RID: 103212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601932C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601932D RID: 103213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601932D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601932E RID: 103214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601932E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601932F RID: 103215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601932F")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x06019330 RID: 103216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019330")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x0401F3D5 RID: 127957
		[Token(Token = "0x401F3D5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SiracusaMapPointInfoView _pointInfoPrefab;

		// Token: 0x0401F3D6 RID: 127958
		[Token(Token = "0x401F3D6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _pointInfoContainer;

		// Token: 0x0401F3D7 RID: 127959
		[Token(Token = "0x401F3D7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SiracusaChatController _chatController;

		// Token: 0x0401F3D8 RID: 127960
		[Token(Token = "0x401F3D8")]
		[FieldOffset(Offset = "0x88")]
		private SiracusaMapChatStateBean m_stateBean;

		// Token: 0x0401F3D9 RID: 127961
		[Token(Token = "0x401F3D9")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0401F3DA RID: 127962
		[Token(Token = "0x401F3DA")]
		[FieldOffset(Offset = "0x98")]
		private SiracusaMapPointInfoView m_pointInfoView;

		// Token: 0x0401F3DB RID: 127963
		[Token(Token = "0x401F3DB")]
		[FieldOffset(Offset = "0xA0")]
		private SiracusaMapChatState.Bridge m_bridge;

		// Token: 0x0401F3DC RID: 127964
		[Token(Token = "0x401F3DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F3DD RID: 127965
		[Token(Token = "0x401F3DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F3DE RID: 127966
		[Token(Token = "0x401F3DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401F3DF RID: 127967
		[Token(Token = "0x401F3DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401F3E0 RID: 127968
		[Token(Token = "0x401F3E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x0401F3E1 RID: 127969
		[Token(Token = "0x401F3E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x0401F3E2 RID: 127970
		[Token(Token = "0x401F3E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0401F3E3 RID: 127971
		[Token(Token = "0x401F3E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F3E4 RID: 127972
		[Token(Token = "0x401F3E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RedirectTarget;

		// Token: 0x0401F3E5 RID: 127973
		[Token(Token = "0x401F3E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearChatModel;

		// Token: 0x0401F3E6 RID: 127974
		[Token(Token = "0x401F3E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnOptionSelect;

		// Token: 0x0401F3E7 RID: 127975
		[Token(Token = "0x401F3E7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnItemObtain;

		// Token: 0x0401F3E8 RID: 127976
		[Token(Token = "0x401F3E8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CompleteTaskIfNeed;

		// Token: 0x0401F3E9 RID: 127977
		[Token(Token = "0x401F3E9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F6D RID: 16237
		[Token(Token = "0x2003F6D")]
		public interface IBridge : IHotfixable
		{
			// Token: 0x06019331 RID: 103217
			[Token(Token = "0x6019331")]
			void OnOptionSelect(string optionId);

			// Token: 0x06019332 RID: 103218
			[Token(Token = "0x6019332")]
			void OnItemObtain(string itemId);

			// Token: 0x06019333 RID: 103219
			[Token(Token = "0x6019333")]
			void NotifyComplete();

			// Token: 0x06019334 RID: 103220
			[Token(Token = "0x6019334")]
			Sprite LoadSiracusaAvatar(string avatarId);
		}

		// Token: 0x02003F6E RID: 16238
		[Token(Token = "0x2003F6E")]
		private class Bridge : SiracusaMapChatState.IBridge, IHotfixable
		{
			// Token: 0x06019335 RID: 103221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019335")]
			[Address(RVA = "0x11DF620", Offset = "0x11DE220", VA = "0x1811DF620")]
			public Bridge(SiracusaMapChatState state)
			{
			}

			// Token: 0x06019336 RID: 103222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019336")]
			[Address(RVA = "0x11DF5A0", Offset = "0x11DE1A0", VA = "0x1811DF5A0", Slot = "4")]
			public void OnOptionSelect(string optionId)
			{
			}

			// Token: 0x06019337 RID: 103223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019337")]
			[Address(RVA = "0x11DF520", Offset = "0x11DE120", VA = "0x1811DF520", Slot = "5")]
			public void OnItemObtain(string itemId)
			{
			}

			// Token: 0x06019338 RID: 103224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019338")]
			[Address(RVA = "0x11DF4A0", Offset = "0x11DE0A0", VA = "0x1811DF4A0", Slot = "6")]
			public void NotifyComplete()
			{
			}

			// Token: 0x06019339 RID: 103225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019339")]
			[Address(RVA = "0x11DF410", Offset = "0x11DE010", VA = "0x1811DF410", Slot = "7")]
			public Sprite LoadSiracusaAvatar(string avatarId)
			{
				return null;
			}

			// Token: 0x0401F3EA RID: 127978
			[Token(Token = "0x401F3EA")]
			[FieldOffset(Offset = "0x10")]
			private SiracusaMapChatState m_state;

			// Token: 0x0401F3EB RID: 127979
			[Token(Token = "0x401F3EB")]
			[FieldOffset(Offset = "0x18")]
			private UIPage m_page;

			// Token: 0x0401F3EC RID: 127980
			[Token(Token = "0x401F3EC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F3ED RID: 127981
			[Token(Token = "0x401F3ED")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnOptionSelect;

			// Token: 0x0401F3EE RID: 127982
			[Token(Token = "0x401F3EE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnItemObtain;

			// Token: 0x0401F3EF RID: 127983
			[Token(Token = "0x401F3EF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyComplete;

			// Token: 0x0401F3F0 RID: 127984
			[Token(Token = "0x401F3F0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_LoadSiracusaAvatar;
		}
	}
}
