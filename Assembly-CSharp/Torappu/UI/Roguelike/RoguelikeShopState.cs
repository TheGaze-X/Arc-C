using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005513 RID: 21779
	[Token(Token = "0x2005513")]
	public class RoguelikeShopState : PopupFadeState
	{
		// Token: 0x0602007C RID: 131196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602007C")]
		[Address(RVA = "0x1A27800", Offset = "0x1A26400", VA = "0x181A27800", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602007D RID: 131197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602007D")]
		[Address(RVA = "0x1A27A10", Offset = "0x1A26610", VA = "0x181A27A10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602007E RID: 131198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602007E")]
		[Address(RVA = "0x1A28080", Offset = "0x1A26C80", VA = "0x181A28080", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602007F RID: 131199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602007F")]
		[Address(RVA = "0x1A27F90", Offset = "0x1A26B90", VA = "0x181A27F90", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06020080 RID: 131200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020080")]
		[Address(RVA = "0x1A27860", Offset = "0x1A26460", VA = "0x181A27860", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06020081 RID: 131201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020081")]
		[Address(RVA = "0x1A279B0", Offset = "0x1A265B0", VA = "0x181A279B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06020082 RID: 131202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020082")]
		[Address(RVA = "0x1A287F0", Offset = "0x1A273F0", VA = "0x181A287F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020083 RID: 131203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020083")]
		[Address(RVA = "0x1A288D0", Offset = "0x1A274D0", VA = "0x181A288D0")]
		private void _TriggerBGMSignal(string topicId, RoguelikeDungeonController controller)
		{
		}

		// Token: 0x06020084 RID: 131204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020084")]
		[Address(RVA = "0x1A28210", Offset = "0x1A26E10", VA = "0x181A28210")]
		private void _ClearBGM()
		{
		}

		// Token: 0x06020085 RID: 131205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020085")]
		[Address(RVA = "0x1A28540", Offset = "0x1A27140", VA = "0x181A28540")]
		private void _EnsureShopPlugin(ILoadAsset iLoadAsset, string topicId)
		{
		}

		// Token: 0x06020086 RID: 131206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020086")]
		[Address(RVA = "0x1A282B0", Offset = "0x1A26EB0", VA = "0x181A282B0")]
		private void _EnsureShopController(ILoadAsset iLoadAsset, string controllerPath)
		{
		}

		// Token: 0x06020087 RID: 131207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020087")]
		[Address(RVA = "0x1A28AD0", Offset = "0x1A276D0", VA = "0x181A28AD0")]
		public RoguelikeShopState()
		{
		}

		// Token: 0x0602008A RID: 131210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602008A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602008B RID: 131211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602008B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602008C RID: 131212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602008C")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0602008D RID: 131213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602008D")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0402B3FE RID: 177150
		[Token(Token = "0x402B3FE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402B3FF RID: 177151
		[Token(Token = "0x402B3FF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIGuidebookTrigger _guideBookTrigger;

		// Token: 0x0402B400 RID: 177152
		[Token(Token = "0x402B400")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _shopControllerContainer;

		// Token: 0x0402B401 RID: 177153
		[Token(Token = "0x402B401")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x0402B402 RID: 177154
		[Token(Token = "0x402B402")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeShopStateBean m_stateBean;

		// Token: 0x0402B403 RID: 177155
		[Token(Token = "0x402B403")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedTopicId;

		// Token: 0x0402B404 RID: 177156
		[Token(Token = "0x402B404")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeShopPlugin m_shopPlugin;

		// Token: 0x0402B405 RID: 177157
		[Token(Token = "0x402B405")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedControllerPath;

		// Token: 0x0402B406 RID: 177158
		[Token(Token = "0x402B406")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeShopControllerBase m_shopController;

		// Token: 0x0402B407 RID: 177159
		[Token(Token = "0x402B407")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402B408 RID: 177160
		[Token(Token = "0x402B408")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B409 RID: 177161
		[Token(Token = "0x402B409")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402B40A RID: 177162
		[Token(Token = "0x402B40A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402B40B RID: 177163
		[Token(Token = "0x402B40B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0402B40C RID: 177164
		[Token(Token = "0x402B40C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402B40D RID: 177165
		[Token(Token = "0x402B40D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B40E RID: 177166
		[Token(Token = "0x402B40E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x0402B40F RID: 177167
		[Token(Token = "0x402B40F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x0402B410 RID: 177168
		[Token(Token = "0x402B410")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EnsureShopPlugin;

		// Token: 0x0402B411 RID: 177169
		[Token(Token = "0x402B411")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EnsureShopController;

		// Token: 0x0402B412 RID: 177170
		[Token(Token = "0x402B412")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
