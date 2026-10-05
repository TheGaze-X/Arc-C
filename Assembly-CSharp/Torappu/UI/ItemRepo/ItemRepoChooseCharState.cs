using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E54 RID: 24148
	[Token(Token = "0x2005E54")]
	public class ItemRepoChooseCharState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x06022FC5 RID: 143301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FC5")]
		[Address(RVA = "0x1D81F00", Offset = "0x1D80B00", VA = "0x181D81F00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022FC6 RID: 143302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FC6")]
		[Address(RVA = "0x1D826E0", Offset = "0x1D812E0", VA = "0x181D826E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022FC7 RID: 143303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FC7")]
		[Address(RVA = "0x1D82840", Offset = "0x1D81440", VA = "0x181D82840")]
		public void ToDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x06022FC8 RID: 143304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FC8")]
		[Address(RVA = "0x1D82560", Offset = "0x1D81160", VA = "0x181D82560", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022FC9 RID: 143305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FC9")]
		[Address(RVA = "0x1D824A0", Offset = "0x1D810A0", VA = "0x181D824A0")]
		public void OnItemClick(string itemId)
		{
		}

		// Token: 0x06022FCA RID: 143306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FCA")]
		[Address(RVA = "0x1D829B0", Offset = "0x1D815B0", VA = "0x181D829B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022FCB RID: 143307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FCB")]
		[Address(RVA = "0x1D81F60", Offset = "0x1D80B60", VA = "0x181D81F60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022FCC RID: 143308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FCC")]
		[Address(RVA = "0x1D82B70", Offset = "0x1D81770", VA = "0x181D82B70")]
		public ItemRepoChooseCharState()
		{
		}

		// Token: 0x06022FCD RID: 143309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FCD")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06022FCE RID: 143310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FCE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04030321 RID: 197409
		[Token(Token = "0x4030321")]
		public const int ITEM_CLICK_CALL = 0;

		// Token: 0x04030322 RID: 197410
		[Token(Token = "0x4030322")]
		[FieldOffset(Offset = "0x70")]
		private ItemRepoChooseCharStateBean m_stateBean;

		// Token: 0x04030323 RID: 197411
		[Token(Token = "0x4030323")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ItemRepoSelectCharView _selectCharView;

		// Token: 0x04030324 RID: 197412
		[Token(Token = "0x4030324")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ItemRepoSelectCharGridView _selectCharGrid;

		// Token: 0x04030325 RID: 197413
		[Token(Token = "0x4030325")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _viewTitleText;

		// Token: 0x04030326 RID: 197414
		[Token(Token = "0x4030326")]
		[FieldOffset(Offset = "0x90")]
		private UIStringEvent m_clickEvent;

		// Token: 0x04030327 RID: 197415
		[Token(Token = "0x4030327")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04030328 RID: 197416
		[Token(Token = "0x4030328")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030329 RID: 197417
		[Token(Token = "0x4030329")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403032A RID: 197418
		[Token(Token = "0x403032A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToDetailState;

		// Token: 0x0403032B RID: 197419
		[Token(Token = "0x403032B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403032C RID: 197420
		[Token(Token = "0x403032C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403032D RID: 197421
		[Token(Token = "0x403032D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403032E RID: 197422
		[Token(Token = "0x403032E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403032F RID: 197423
		[Token(Token = "0x403032F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
