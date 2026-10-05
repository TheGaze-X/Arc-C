using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BD7 RID: 27607
	[Token(Token = "0x2006BD7")]
	public class ArchivePicController : ActArchiveController
	{
		// Token: 0x17005D13 RID: 23827
		// (get) Token: 0x060276CD RID: 161485 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060276CE RID: 161486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D13")]
		public Action<bool> onFullscreenToggled
		{
			[Token(Token = "0x60276CD")]
			[Address(RVA = "0x2299D40", Offset = "0x2298940", VA = "0x182299D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60276CE")]
			[Address(RVA = "0x2299DA0", Offset = "0x22989A0", VA = "0x182299DA0")]
			set
			{
			}
		}

		// Token: 0x060276CF RID: 161487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276CF")]
		[Address(RVA = "0x2299A00", Offset = "0x2298600", VA = "0x182299A00", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060276D0 RID: 161488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276D0")]
		[Address(RVA = "0x2299AA0", Offset = "0x22986A0", VA = "0x182299AA0")]
		public void OnPicClicked()
		{
		}

		// Token: 0x060276D1 RID: 161489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276D1")]
		[Address(RVA = "0x2299BB0", Offset = "0x22987B0", VA = "0x182299BB0")]
		public void OnSetHomeKV()
		{
		}

		// Token: 0x060276D2 RID: 161490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276D2")]
		[Address(RVA = "0x2299410", Offset = "0x2298010", VA = "0x182299410")]
		public List<DataBinder<PicProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060276D3 RID: 161491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276D3")]
		[Address(RVA = "0x22996F0", Offset = "0x22982F0", VA = "0x1822996F0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060276D4 RID: 161492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276D4")]
		[Address(RVA = "0x2299C20", Offset = "0x2298820", VA = "0x182299C20", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x060276D5 RID: 161493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276D5")]
		[Address(RVA = "0x2299CE0", Offset = "0x22988E0", VA = "0x182299CE0")]
		public ArchivePicController()
		{
		}

		// Token: 0x060276D6 RID: 161494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276D6")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x060276D7 RID: 161495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276D7")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x060276D8 RID: 161496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276D8")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04037DBB RID: 228795
		[Token(Token = "0x4037DBB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchivePicListDataBinder _picListBinder;

		// Token: 0x04037DBC RID: 228796
		[Token(Token = "0x4037DBC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchivePicContentDataBinder _picContentBinder;

		// Token: 0x04037DBD RID: 228797
		[Token(Token = "0x4037DBD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArchivePicFullscreenDataBinder _picFullscreenDataBinder;

		// Token: 0x04037DBE RID: 228798
		[Token(Token = "0x4037DBE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04037DBF RID: 228799
		[Token(Token = "0x4037DBF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x04037DC0 RID: 228800
		[Token(Token = "0x4037DC0")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action onSetHomeKV;

		// Token: 0x04037DC1 RID: 228801
		[Token(Token = "0x4037DC1")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<ActArchiveType, string> onPicItemClicked;

		// Token: 0x04037DC2 RID: 228802
		[Token(Token = "0x4037DC2")]
		[FieldOffset(Offset = "0x70")]
		private Action<bool> m_onFullscreenToggled;

		// Token: 0x04037DC3 RID: 228803
		[Token(Token = "0x4037DC3")]
		[FieldOffset(Offset = "0x78")]
		private ArchivePicController.Handler m_handler;

		// Token: 0x04037DC4 RID: 228804
		[Token(Token = "0x4037DC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onFullscreenToggled;

		// Token: 0x04037DC5 RID: 228805
		[Token(Token = "0x4037DC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onFullscreenToggled;

		// Token: 0x04037DC6 RID: 228806
		[Token(Token = "0x4037DC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037DC7 RID: 228807
		[Token(Token = "0x4037DC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPicClicked;

		// Token: 0x04037DC8 RID: 228808
		[Token(Token = "0x4037DC8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSetHomeKV;

		// Token: 0x04037DC9 RID: 228809
		[Token(Token = "0x4037DC9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037DCA RID: 228810
		[Token(Token = "0x4037DCA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037DCB RID: 228811
		[Token(Token = "0x4037DCB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04037DCC RID: 228812
		[Token(Token = "0x4037DCC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BD8 RID: 27608
		[Token(Token = "0x2006BD8")]
		private class Handler : ArchivePicControllerHandler
		{
			// Token: 0x060276D9 RID: 161497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60276D9")]
			[Address(RVA = "0x22A20B0", Offset = "0x22A0CB0", VA = "0x1822A20B0")]
			public Handler(ArchivePicController closure)
			{
			}

			// Token: 0x060276DA RID: 161498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60276DA")]
			[Address(RVA = "0x22A1EB0", Offset = "0x22A0AB0", VA = "0x1822A1EB0", Slot = "4")]
			public override void OnItemClick(string funcId)
			{
			}

			// Token: 0x04037DCD RID: 228813
			[Token(Token = "0x4037DCD")]
			[FieldOffset(Offset = "0x10")]
			private ArchivePicController m_closure;

			// Token: 0x04037DCE RID: 228814
			[Token(Token = "0x4037DCE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037DCF RID: 228815
			[Token(Token = "0x4037DCF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnItemClick;
		}
	}
}
