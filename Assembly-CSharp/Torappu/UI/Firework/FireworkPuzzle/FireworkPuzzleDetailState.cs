using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E69 RID: 20073
	[Token(Token = "0x2004E69")]
	public class FireworkPuzzleDetailState : FireworkBaseState
	{
		// Token: 0x0601DF4F RID: 122703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF4F")]
		[Address(RVA = "0x17A4B30", Offset = "0x17A3730", VA = "0x1817A4B30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DF50 RID: 122704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF50")]
		[Address(RVA = "0x17A5810", Offset = "0x17A4410", VA = "0x1817A5810", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601DF51 RID: 122705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF51")]
		[Address(RVA = "0x17A6590", Offset = "0x17A5190", VA = "0x1817A6590")]
		private void _RegisterToResultState(IStateBean targetBean)
		{
		}

		// Token: 0x0601DF52 RID: 122706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF52")]
		[Address(RVA = "0x17A4B90", Offset = "0x17A3790", VA = "0x1817A4B90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DF53 RID: 122707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF53")]
		[Address(RVA = "0x17A57A0", Offset = "0x17A43A0", VA = "0x1817A57A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601DF54 RID: 122708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF54")]
		[Address(RVA = "0x17A6370", Offset = "0x17A4F70", VA = "0x1817A6370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DF55 RID: 122709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF55")]
		[Address(RVA = "0x17A59B0", Offset = "0x17A45B0", VA = "0x1817A59B0")]
		private void _EventOnBack()
		{
		}

		// Token: 0x0601DF56 RID: 122710 RVA: 0x000AD070 File Offset: 0x000AB270
		[Token(Token = "0x601DF56")]
		[Address(RVA = "0x17A6440", Offset = "0x17A5040", VA = "0x1817A6440")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601DF57 RID: 122711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF57")]
		[Address(RVA = "0x17A5140", Offset = "0x17A3D40", VA = "0x1817A5140", Slot = "32")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601DF58 RID: 122712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF58")]
		[Address(RVA = "0x17A6230", Offset = "0x17A4E30", VA = "0x1817A6230")]
		private void _EventOnSubListRaycastClick()
		{
		}

		// Token: 0x0601DF59 RID: 122713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF59")]
		[Address(RVA = "0x17A5F50", Offset = "0x17A4B50", VA = "0x1817A5F50")]
		private void _EventOnPlateListItemClick(string groupId)
		{
		}

		// Token: 0x0601DF5A RID: 122714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF5A")]
		[Address(RVA = "0x17A60A0", Offset = "0x17A4CA0", VA = "0x1817A60A0")]
		private void _EventOnPlateSubListItemClick(object objVal)
		{
		}

		// Token: 0x0601DF5B RID: 122715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF5B")]
		[Address(RVA = "0x17A5DE0", Offset = "0x17A49E0", VA = "0x1817A5DE0")]
		private void _EventOnPlateFilledListItemClick(object objVal)
		{
		}

		// Token: 0x0601DF5C RID: 122716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF5C")]
		[Address(RVA = "0x17A5CA0", Offset = "0x17A48A0", VA = "0x1817A5CA0")]
		private void _EventOnBtnClearAllClick()
		{
		}

		// Token: 0x0601DF5D RID: 122717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF5D")]
		[Address(RVA = "0x17A6500", Offset = "0x17A5100", VA = "0x1817A6500")]
		private void _OpenResultState()
		{
		}

		// Token: 0x0601DF5E RID: 122718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF5E")]
		[Address(RVA = "0x17A4670", Offset = "0x17A3270", VA = "0x1817A4670")]
		public void EventOnBtnHintClick()
		{
		}

		// Token: 0x0601DF5F RID: 122719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF5F")]
		[Address(RVA = "0x17A42F0", Offset = "0x17A2EF0", VA = "0x1817A42F0")]
		public void EventOnBtnComfirm()
		{
		}

		// Token: 0x0601DF60 RID: 122720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF60")]
		[Address(RVA = "0x17A6970", Offset = "0x17A5570", VA = "0x1817A6970")]
		public FireworkPuzzleDetailState()
		{
		}

		// Token: 0x0601DF62 RID: 122722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF62")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601DF63 RID: 122723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF63")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601DF64 RID: 122724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF64")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04027C64 RID: 162916
		[Token(Token = "0x4027C64")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FireworkPuzzleDetailView _view;

		// Token: 0x04027C65 RID: 162917
		[Token(Token = "0x4027C65")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04027C66 RID: 162918
		[Token(Token = "0x4027C66")]
		[FieldOffset(Offset = "0x80")]
		private FireworkPuzzleDetailStateBean m_stateBean;

		// Token: 0x04027C67 RID: 162919
		[Token(Token = "0x4027C67")]
		[FieldOffset(Offset = "0x88")]
		private List<FireworkData.PlateSlotData> m_cacheSlotList;

		// Token: 0x04027C68 RID: 162920
		[Token(Token = "0x4027C68")]
		[FieldOffset(Offset = "0x90")]
		private List<RewardItemModel> m_cacheRewardList;

		// Token: 0x04027C69 RID: 162921
		[Token(Token = "0x4027C69")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04027C6A RID: 162922
		[Token(Token = "0x4027C6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027C6B RID: 162923
		[Token(Token = "0x4027C6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04027C6C RID: 162924
		[Token(Token = "0x4027C6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterToResultState;

		// Token: 0x04027C6D RID: 162925
		[Token(Token = "0x4027C6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027C6E RID: 162926
		[Token(Token = "0x4027C6E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04027C6F RID: 162927
		[Token(Token = "0x4027C6F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027C70 RID: 162928
		[Token(Token = "0x4027C70")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnBack;

		// Token: 0x04027C71 RID: 162929
		[Token(Token = "0x4027C71")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x04027C72 RID: 162930
		[Token(Token = "0x4027C72")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04027C73 RID: 162931
		[Token(Token = "0x4027C73")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnSubListRaycastClick;

		// Token: 0x04027C74 RID: 162932
		[Token(Token = "0x4027C74")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnPlateListItemClick;

		// Token: 0x04027C75 RID: 162933
		[Token(Token = "0x4027C75")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnPlateSubListItemClick;

		// Token: 0x04027C76 RID: 162934
		[Token(Token = "0x4027C76")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnPlateFilledListItemClick;

		// Token: 0x04027C77 RID: 162935
		[Token(Token = "0x4027C77")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnBtnClearAllClick;

		// Token: 0x04027C78 RID: 162936
		[Token(Token = "0x4027C78")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OpenResultState;

		// Token: 0x04027C79 RID: 162937
		[Token(Token = "0x4027C79")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnBtnHintClick;

		// Token: 0x04027C7A RID: 162938
		[Token(Token = "0x4027C7A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnBtnComfirm;

		// Token: 0x04027C7B RID: 162939
		[Token(Token = "0x4027C7B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
