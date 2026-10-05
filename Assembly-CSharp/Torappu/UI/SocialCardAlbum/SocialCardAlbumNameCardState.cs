using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.Friend;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EB3 RID: 16051
	[Token(Token = "0x2003EB3")]
	public class SocialCardAlbumNameCardState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06018EA1 RID: 102049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA1")]
		[Address(RVA = "0x11A5AF0", Offset = "0x11A46F0", VA = "0x1811A5AF0")]
		public void CloseNameCard()
		{
		}

		// Token: 0x06018EA2 RID: 102050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA2")]
		[Address(RVA = "0x11A60B0", Offset = "0x11A4CB0", VA = "0x1811A60B0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018EA3 RID: 102051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA3")]
		[Address(RVA = "0x11A74C0", Offset = "0x11A60C0", VA = "0x1811A74C0")]
		private void _SwitchOperatorStyle(string moduleId)
		{
		}

		// Token: 0x06018EA4 RID: 102052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA4")]
		[Address(RVA = "0x11A7300", Offset = "0x11A5F00", VA = "0x1811A7300")]
		private void _SwitchAssistStyle(string moduleId)
		{
		}

		// Token: 0x06018EA5 RID: 102053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA5")]
		[Address(RVA = "0x11A73E0", Offset = "0x11A5FE0", VA = "0x1811A73E0")]
		private void _SwitchEquipStyle(string moduleId)
		{
		}

		// Token: 0x06018EA6 RID: 102054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA6")]
		[Address(RVA = "0x11A67D0", Offset = "0x11A53D0", VA = "0x1811A67D0")]
		private void _CrossAppShare(string skinId, int skinTmpl, bool isDetail)
		{
		}

		// Token: 0x06018EA7 RID: 102055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA7")]
		[Address(RVA = "0x11A6CC0", Offset = "0x11A58C0", VA = "0x1811A6CC0")]
		private void _ExtendNameCard(bool isExtend)
		{
		}

		// Token: 0x06018EA8 RID: 102056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA8")]
		[Address(RVA = "0x11A6560", Offset = "0x11A5160", VA = "0x1811A6560")]
		private void _CloseButtonFadeIn()
		{
		}

		// Token: 0x06018EA9 RID: 102057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018EA9")]
		[Address(RVA = "0x11A6DF0", Offset = "0x11A59F0", VA = "0x1811A6DF0")]
		private IEnumerator _FadeInCloseButtonObj()
		{
			return null;
		}

		// Token: 0x06018EAA RID: 102058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018EAA")]
		[Address(RVA = "0x11A6EA0", Offset = "0x11A5AA0", VA = "0x1811A6EA0")]
		private IEnumerator _FadeOutCloseButtonObj()
		{
			return null;
		}

		// Token: 0x06018EAB RID: 102059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018EAB")]
		[Address(RVA = "0x11A5C30", Offset = "0x11A4830", VA = "0x1811A5C30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018EAC RID: 102060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EAC")]
		[Address(RVA = "0x11A5C90", Offset = "0x11A4890", VA = "0x1811A5C90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018EAD RID: 102061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EAD")]
		[Address(RVA = "0x11A64F0", Offset = "0x11A50F0", VA = "0x1811A64F0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06018EAE RID: 102062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EAE")]
		[Address(RVA = "0x11A6F50", Offset = "0x11A5B50", VA = "0x1811A6F50")]
		private void _InitNameCardIfNot()
		{
		}

		// Token: 0x06018EAF RID: 102063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EAF")]
		[Address(RVA = "0x11A70F0", Offset = "0x11A5CF0", VA = "0x1811A70F0")]
		private void _SaveStatusAndDismiss()
		{
		}

		// Token: 0x06018EB0 RID: 102064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EB0")]
		[Address(RVA = "0x11A6AB0", Offset = "0x11A56B0", VA = "0x1811A6AB0")]
		private void _DismissOrClosePage()
		{
		}

		// Token: 0x06018EB1 RID: 102065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EB1")]
		[Address(RVA = "0x11A75A0", Offset = "0x11A61A0", VA = "0x1811A75A0")]
		public SocialCardAlbumNameCardState()
		{
		}

		// Token: 0x06018EB2 RID: 102066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EB2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018EB3 RID: 102067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EB3")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401EBE5 RID: 125925
		[Token(Token = "0x401EBE5")]
		[NonSerialized]
		public const int SWITCH_OPERATOR_STYLE = 0;

		// Token: 0x0401EBE6 RID: 125926
		[Token(Token = "0x401EBE6")]
		[NonSerialized]
		public const int SWITCH_ASSIST_STYLE = 1;

		// Token: 0x0401EBE7 RID: 125927
		[Token(Token = "0x401EBE7")]
		[NonSerialized]
		public const int CROSS_APP_SHARE = 2;

		// Token: 0x0401EBE8 RID: 125928
		[Token(Token = "0x401EBE8")]
		[NonSerialized]
		public const int CROSS_APP_SHARE_SIMPLE = 3;

		// Token: 0x0401EBE9 RID: 125929
		[Token(Token = "0x401EBE9")]
		[NonSerialized]
		public const int EXTEND_NAME_CARD = 4;

		// Token: 0x0401EBEA RID: 125930
		[Token(Token = "0x401EBEA")]
		[NonSerialized]
		public const int CLOSE_BTN_FADE_IN = 5;

		// Token: 0x0401EBEB RID: 125931
		[Token(Token = "0x401EBEB")]
		[NonSerialized]
		public const int SWITCH_EQUIP_MODULE_STYLE = 6;

		// Token: 0x0401EBEC RID: 125932
		[Token(Token = "0x401EBEC")]
		private const int FADE_IN_TIME = 10;

		// Token: 0x0401EBED RID: 125933
		[Token(Token = "0x401EBED")]
		private const int CLOSE_BUTTON_HIDE_TIME = 2;

		// Token: 0x0401EBEE RID: 125934
		[Token(Token = "0x401EBEE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0401EBEF RID: 125935
		[Token(Token = "0x401EBEF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _closeButton;

		// Token: 0x0401EBF0 RID: 125936
		[Token(Token = "0x401EBF0")]
		[FieldOffset(Offset = "0x80")]
		private readonly NameCardV2Property m_property;

		// Token: 0x0401EBF1 RID: 125937
		[Token(Token = "0x401EBF1")]
		[FieldOffset(Offset = "0x88")]
		private SocialCardAlbumPage m_page;

		// Token: 0x0401EBF2 RID: 125938
		[Token(Token = "0x401EBF2")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasCardInited;

		// Token: 0x0401EBF3 RID: 125939
		[Token(Token = "0x401EBF3")]
		[FieldOffset(Offset = "0x98")]
		private NameCardV2View m_viewObj;

		// Token: 0x0401EBF4 RID: 125940
		[Token(Token = "0x401EBF4")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_coroutine;

		// Token: 0x0401EBF5 RID: 125941
		[Token(Token = "0x401EBF5")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_cachedShowDetail;

		// Token: 0x0401EBF6 RID: 125942
		[Token(Token = "0x401EBF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CloseNameCard;

		// Token: 0x0401EBF7 RID: 125943
		[Token(Token = "0x401EBF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401EBF8 RID: 125944
		[Token(Token = "0x401EBF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SwitchOperatorStyle;

		// Token: 0x0401EBF9 RID: 125945
		[Token(Token = "0x401EBF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SwitchAssistStyle;

		// Token: 0x0401EBFA RID: 125946
		[Token(Token = "0x401EBFA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SwitchEquipStyle;

		// Token: 0x0401EBFB RID: 125947
		[Token(Token = "0x401EBFB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CrossAppShare;

		// Token: 0x0401EBFC RID: 125948
		[Token(Token = "0x401EBFC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExtendNameCard;

		// Token: 0x0401EBFD RID: 125949
		[Token(Token = "0x401EBFD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CloseButtonFadeIn;

		// Token: 0x0401EBFE RID: 125950
		[Token(Token = "0x401EBFE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FadeInCloseButtonObj;

		// Token: 0x0401EBFF RID: 125951
		[Token(Token = "0x401EBFF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FadeOutCloseButtonObj;

		// Token: 0x0401EC00 RID: 125952
		[Token(Token = "0x401EC00")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401EC01 RID: 125953
		[Token(Token = "0x401EC01")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401EC02 RID: 125954
		[Token(Token = "0x401EC02")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401EC03 RID: 125955
		[Token(Token = "0x401EC03")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitNameCardIfNot;

		// Token: 0x0401EC04 RID: 125956
		[Token(Token = "0x401EC04")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SaveStatusAndDismiss;

		// Token: 0x0401EC05 RID: 125957
		[Token(Token = "0x401EC05")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DismissOrClosePage;

		// Token: 0x0401EC06 RID: 125958
		[Token(Token = "0x401EC06")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
