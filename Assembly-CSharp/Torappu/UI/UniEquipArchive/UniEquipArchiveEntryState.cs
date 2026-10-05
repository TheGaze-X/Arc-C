using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BDB RID: 15323
	[Token(Token = "0x2003BDB")]
	public class UniEquipArchiveEntryState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06017FA1 RID: 98209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017FA1")]
		[Address(RVA = "0x1062230", Offset = "0x1060E30", VA = "0x181062230", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06017FA2 RID: 98210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA2")]
		[Address(RVA = "0x1062930", Offset = "0x1061530", VA = "0x181062930")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017FA3 RID: 98211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA3")]
		[Address(RVA = "0x1062290", Offset = "0x1060E90", VA = "0x181062290", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06017FA4 RID: 98212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA4")]
		[Address(RVA = "0x1062860", Offset = "0x1061460", VA = "0x181062860", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06017FA5 RID: 98213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA5")]
		[Address(RVA = "0x1062440", Offset = "0x1061040", VA = "0x181062440", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06017FA6 RID: 98214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA6")]
		[Address(RVA = "0x1062E00", Offset = "0x1061A00", VA = "0x181062E00")]
		private void _OnOpenCharState()
		{
		}

		// Token: 0x06017FA7 RID: 98215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA7")]
		[Address(RVA = "0x1062EC0", Offset = "0x1061AC0", VA = "0x181062EC0")]
		private void _OnOpenModuleState()
		{
		}

		// Token: 0x06017FA8 RID: 98216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA8")]
		[Address(RVA = "0x1062AD0", Offset = "0x10616D0", VA = "0x181062AD0")]
		private void _OnNewEditionItemClick(string uniEquipId)
		{
		}

		// Token: 0x06017FA9 RID: 98217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FA9")]
		[Address(RVA = "0x10629D0", Offset = "0x10615D0", VA = "0x1810629D0")]
		private void _OnNewEditionItemCharPartClick(string uniEquipId)
		{
		}

		// Token: 0x06017FAA RID: 98218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FAA")]
		[Address(RVA = "0x1062F80", Offset = "0x1061B80", VA = "0x181062F80")]
		private void _OnSwitchInfoBtnClick()
		{
		}

		// Token: 0x06017FAB RID: 98219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FAB")]
		[Address(RVA = "0x1063060", Offset = "0x1061C60", VA = "0x181063060")]
		public UniEquipArchiveEntryState()
		{
		}

		// Token: 0x06017FAC RID: 98220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FAC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06017FAD RID: 98221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FAD")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401D073 RID: 118899
		[Token(Token = "0x401D073")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipArchiveEntryView _view;

		// Token: 0x0401D074 RID: 118900
		[Token(Token = "0x401D074")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401D075 RID: 118901
		[Token(Token = "0x401D075")]
		[FieldOffset(Offset = "0x80")]
		private UniEquipArchiveEntryStateBean m_stateBean;

		// Token: 0x0401D076 RID: 118902
		[Token(Token = "0x401D076")]
		[NonSerialized]
		public const int ON_OPEN_CHAR_CLICK = 0;

		// Token: 0x0401D077 RID: 118903
		[Token(Token = "0x401D077")]
		[NonSerialized]
		public const int ON_OPEN_MODULE_CLICK = 1;

		// Token: 0x0401D078 RID: 118904
		[Token(Token = "0x401D078")]
		[NonSerialized]
		public const int ON_NEW_EDITION_ITEM_CLICK = 2;

		// Token: 0x0401D079 RID: 118905
		[Token(Token = "0x401D079")]
		[NonSerialized]
		public const int ON_NEW_EDITION_ITEM_CHAR_PART_CLICK = 3;

		// Token: 0x0401D07A RID: 118906
		[Token(Token = "0x401D07A")]
		[NonSerialized]
		public const int ON_SWITCH_INFO_BTN_CLICK = 4;

		// Token: 0x0401D07B RID: 118907
		[Token(Token = "0x401D07B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D07C RID: 118908
		[Token(Token = "0x401D07C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D07D RID: 118909
		[Token(Token = "0x401D07D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D07E RID: 118910
		[Token(Token = "0x401D07E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D07F RID: 118911
		[Token(Token = "0x401D07F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D080 RID: 118912
		[Token(Token = "0x401D080")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnOpenCharState;

		// Token: 0x0401D081 RID: 118913
		[Token(Token = "0x401D081")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnOpenModuleState;

		// Token: 0x0401D082 RID: 118914
		[Token(Token = "0x401D082")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnNewEditionItemClick;

		// Token: 0x0401D083 RID: 118915
		[Token(Token = "0x401D083")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnNewEditionItemCharPartClick;

		// Token: 0x0401D084 RID: 118916
		[Token(Token = "0x401D084")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSwitchInfoBtnClick;

		// Token: 0x0401D085 RID: 118917
		[Token(Token = "0x401D085")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
