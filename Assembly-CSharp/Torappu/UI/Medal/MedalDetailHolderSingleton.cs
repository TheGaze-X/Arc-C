using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200497A RID: 18810
	[Token(Token = "0x200497A")]
	public class MedalDetailHolderSingleton : PageSingleComponent
	{
		// Token: 0x0601C58C RID: 116108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C58C")]
		[Address(RVA = "0x15C8610", Offset = "0x15C7210", VA = "0x1815C8610")]
		public static void LockClick()
		{
		}

		// Token: 0x0601C58D RID: 116109 RVA: 0x000A7F28 File Offset: 0x000A6128
		[Token(Token = "0x601C58D")]
		[Address(RVA = "0x15C83C0", Offset = "0x15C6FC0", VA = "0x1815C83C0")]
		public static bool GetUnlockFlag()
		{
			return default(bool);
		}

		// Token: 0x0601C58E RID: 116110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C58E")]
		[Address(RVA = "0x15C8F20", Offset = "0x15C7B20", VA = "0x1815C8F20")]
		public static void UnlockClick()
		{
		}

		// Token: 0x0601C58F RID: 116111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C58F")]
		[Address(RVA = "0x15C9110", Offset = "0x15C7D10", VA = "0x1815C9110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C590 RID: 116112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C590")]
		[Address(RVA = "0x15C8790", Offset = "0x15C7390", VA = "0x1815C8790")]
		public static void OnOpenDetailStatic(RectTransform rect, MedalCommonViewModel viewModel, UIStringEvent dismissAct)
		{
		}

		// Token: 0x0601C591 RID: 116113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C591")]
		[Address(RVA = "0x15C88B0", Offset = "0x15C74B0", VA = "0x1815C88B0")]
		public void OnOpenDetail(RectTransform rect, MedalCommonViewModel viewModel, UIStringEvent dismissAct)
		{
		}

		// Token: 0x0601C592 RID: 116114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C592")]
		[Address(RVA = "0x15C8FF0", Offset = "0x15C7BF0", VA = "0x1815C8FF0")]
		private void _Close(string targetMedalId)
		{
		}

		// Token: 0x0601C593 RID: 116115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C593")]
		[Address(RVA = "0x15C8230", Offset = "0x15C6E30", VA = "0x1815C8230")]
		public static void CloseStatic()
		{
		}

		// Token: 0x0601C594 RID: 116116 RVA: 0x000A7F40 File Offset: 0x000A6140
		[Token(Token = "0x601C594")]
		[Address(RVA = "0x15C8490", Offset = "0x15C7090", VA = "0x1815C8490")]
		public static bool IsShow()
		{
			return default(bool);
		}

		// Token: 0x0601C595 RID: 116117 RVA: 0x000A7F58 File Offset: 0x000A6158
		[Token(Token = "0x601C595")]
		[Address(RVA = "0x15C85B0", Offset = "0x15C71B0", VA = "0x1815C85B0")]
		public bool IsShown()
		{
			return default(bool);
		}

		// Token: 0x0601C596 RID: 116118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C596")]
		[Address(RVA = "0x15C86E0", Offset = "0x15C72E0", VA = "0x1815C86E0")]
		public void OnClickDetail(string medalId)
		{
		}

		// Token: 0x0601C597 RID: 116119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C597")]
		[Address(RVA = "0x15C8310", Offset = "0x15C6F10", VA = "0x1815C8310")]
		public void Close()
		{
		}

		// Token: 0x0601C598 RID: 116120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C598")]
		[Address(RVA = "0x15C8AF0", Offset = "0x15C76F0", VA = "0x1815C8AF0")]
		public void OpenAlready(RectTransform rect, MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C599 RID: 116121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C599")]
		[Address(RVA = "0x15C8DE0", Offset = "0x15C79E0", VA = "0x1815C8DE0")]
		public void OpenNotGet(RectTransform rect, MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C59A RID: 116122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C59A")]
		[Address(RVA = "0x15C92F0", Offset = "0x15C7EF0", VA = "0x1815C92F0")]
		public MedalDetailHolderSingleton()
		{
		}

		// Token: 0x0402518A RID: 151946
		[Token(Token = "0x402518A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MedalListAlreadyGetItemDetailView _detailView;

		// Token: 0x0402518B RID: 151947
		[Token(Token = "0x402518B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalListNoGetItemDetailView _noGetDetailView;

		// Token: 0x0402518C RID: 151948
		[Token(Token = "0x402518C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402518D RID: 151949
		[Token(Token = "0x402518D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _activeHolder;

		// Token: 0x0402518E RID: 151950
		[Token(Token = "0x402518E")]
		[FieldOffset(Offset = "0x40")]
		private UIStringEvent m_dismissAct;

		// Token: 0x0402518F RID: 151951
		[Token(Token = "0x402518F")]
		[FieldOffset(Offset = "0x48")]
		private MedalListAlreadyGetItemDetailView m_detailView;

		// Token: 0x04025190 RID: 151952
		[Token(Token = "0x4025190")]
		[FieldOffset(Offset = "0x50")]
		private MedalListNoGetItemDetailView m_noGetDetailView;

		// Token: 0x04025191 RID: 151953
		[Token(Token = "0x4025191")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04025192 RID: 151954
		[Token(Token = "0x4025192")]
		[FieldOffset(Offset = "0x59")]
		private bool m_lockedFlag;

		// Token: 0x04025193 RID: 151955
		[Token(Token = "0x4025193")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_isShow;

		// Token: 0x04025194 RID: 151956
		[Token(Token = "0x4025194")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LockClick;

		// Token: 0x04025195 RID: 151957
		[Token(Token = "0x4025195")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetUnlockFlag;

		// Token: 0x04025196 RID: 151958
		[Token(Token = "0x4025196")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UnlockClick;

		// Token: 0x04025197 RID: 151959
		[Token(Token = "0x4025197")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025198 RID: 151960
		[Token(Token = "0x4025198")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenDetailStatic;

		// Token: 0x04025199 RID: 151961
		[Token(Token = "0x4025199")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOpenDetail;

		// Token: 0x0402519A RID: 151962
		[Token(Token = "0x402519A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Close;

		// Token: 0x0402519B RID: 151963
		[Token(Token = "0x402519B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CloseStatic;

		// Token: 0x0402519C RID: 151964
		[Token(Token = "0x402519C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsShow;

		// Token: 0x0402519D RID: 151965
		[Token(Token = "0x402519D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsShown;

		// Token: 0x0402519E RID: 151966
		[Token(Token = "0x402519E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClickDetail;

		// Token: 0x0402519F RID: 151967
		[Token(Token = "0x402519F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x040251A0 RID: 151968
		[Token(Token = "0x40251A0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OpenAlready;

		// Token: 0x040251A1 RID: 151969
		[Token(Token = "0x40251A1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OpenNotGet;

		// Token: 0x040251A2 RID: 151970
		[Token(Token = "0x40251A2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
