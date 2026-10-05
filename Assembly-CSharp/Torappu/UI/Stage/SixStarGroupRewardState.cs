using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006821 RID: 26657
	[Token(Token = "0x2006821")]
	public class SixStarGroupRewardState : State, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x060262F6 RID: 156406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60262F6")]
		[Address(RVA = "0x2138970", Offset = "0x2137570", VA = "0x182138970", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060262F7 RID: 156407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262F7")]
		[Address(RVA = "0x21389D0", Offset = "0x21375D0", VA = "0x1821389D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060262F8 RID: 156408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60262F8")]
		[Address(RVA = "0x2138FB0", Offset = "0x2137BB0", VA = "0x182138FB0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060262F9 RID: 156409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262F9")]
		[Address(RVA = "0x2138C40", Offset = "0x2137840", VA = "0x182138C40", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060262FA RID: 156410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262FA")]
		[Address(RVA = "0x2139110", Offset = "0x2137D10", VA = "0x182139110")]
		private void _EventOnBackClicked()
		{
		}

		// Token: 0x060262FB RID: 156411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262FB")]
		[Address(RVA = "0x2139210", Offset = "0x2137E10", VA = "0x182139210")]
		private void _EventOnStageRewardClicked(string stageId)
		{
		}

		// Token: 0x060262FC RID: 156412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262FC")]
		[Address(RVA = "0x21393C0", Offset = "0x2137FC0", VA = "0x1821393C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060262FD RID: 156413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262FD")]
		[Address(RVA = "0x21394D0", Offset = "0x21380D0", VA = "0x1821394D0")]
		private void _OnJumpToStagePreviewReward(IStateBean stateBean)
		{
		}

		// Token: 0x060262FE RID: 156414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262FE")]
		[Address(RVA = "0x21395F0", Offset = "0x21381F0", VA = "0x1821395F0")]
		public SixStarGroupRewardState()
		{
		}

		// Token: 0x060262FF RID: 156415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262FF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026300 RID: 156416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026300")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04035CCC RID: 220364
		[Token(Token = "0x4035CCC")]
		[NonSerialized]
		public const int ON_BACK_BTN_CLICKED = 0;

		// Token: 0x04035CCD RID: 220365
		[Token(Token = "0x4035CCD")]
		[NonSerialized]
		public const int ON_STAGE_REWARD_CLICKED = 1;

		// Token: 0x04035CCE RID: 220366
		[Token(Token = "0x4035CCE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04035CCF RID: 220367
		[Token(Token = "0x4035CCF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SixStarGroupRewardView _rewardView;

		// Token: 0x04035CD0 RID: 220368
		[Token(Token = "0x4035CD0")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04035CD1 RID: 220369
		[Token(Token = "0x4035CD1")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedStageId;

		// Token: 0x04035CD2 RID: 220370
		[Token(Token = "0x4035CD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035CD3 RID: 220371
		[Token(Token = "0x4035CD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035CD4 RID: 220372
		[Token(Token = "0x4035CD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04035CD5 RID: 220373
		[Token(Token = "0x4035CD5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035CD6 RID: 220374
		[Token(Token = "0x4035CD6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnBackClicked;

		// Token: 0x04035CD7 RID: 220375
		[Token(Token = "0x4035CD7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnStageRewardClicked;

		// Token: 0x04035CD8 RID: 220376
		[Token(Token = "0x4035CD8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035CD9 RID: 220377
		[Token(Token = "0x4035CD9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToStagePreviewReward;

		// Token: 0x04035CDA RID: 220378
		[Token(Token = "0x4035CDA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
