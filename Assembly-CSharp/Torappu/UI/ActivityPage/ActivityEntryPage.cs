using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x0200676A RID: 26474
	[Token(Token = "0x200676A")]
	public abstract class ActivityEntryPage : StateEnginePage, IActEntry, IHotfixable
	{
		// Token: 0x170059D8 RID: 23000
		// (get) Token: 0x06025FA7 RID: 155559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059D8")]
		public string actId
		{
			[Token(Token = "0x6025FA7")]
			[Address(RVA = "0x20ED8F0", Offset = "0x20EC4F0", VA = "0x1820ED8F0", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059D9 RID: 23001
		// (get) Token: 0x06025FA8 RID: 155560 RVA: 0x000C9978 File Offset: 0x000C7B78
		[Token(Token = "0x170059D9")]
		public bool isFromBattle
		{
			[Token(Token = "0x6025FA8")]
			[Address(RVA = "0x20ED9F0", Offset = "0x20EC5F0", VA = "0x1820ED9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025FA9 RID: 155561 RVA: 0x000C9990 File Offset: 0x000C7B90
		[Token(Token = "0x6025FA9")]
		[Address(RVA = "0x20ED190", Offset = "0x20EBD90", VA = "0x1820ED190", Slot = "30")]
		public long GetInstID()
		{
			return 0L;
		}

		// Token: 0x06025FAA RID: 155562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FAA")]
		[Address(RVA = "0x20ED250", Offset = "0x20EBE50", VA = "0x1820ED250", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06025FAB RID: 155563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FAB")]
		[Address(RVA = "0x20ED370", Offset = "0x20EBF70", VA = "0x1820ED370", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06025FAC RID: 155564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FAC")]
		[Address(RVA = "0x20ED520", Offset = "0x20EC120", VA = "0x1820ED520", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x06025FAD RID: 155565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FAD")]
		[Address(RVA = "0x20ED440", Offset = "0x20EC040", VA = "0x1820ED440", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06025FAE RID: 155566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FAE")]
		[Address(RVA = "0x20ED0D0", Offset = "0x20EBCD0", VA = "0x1820ED0D0", Slot = "25")]
		protected sealed override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06025FAF RID: 155567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FAF")]
		[Address(RVA = "0x20ECFF0", Offset = "0x20EBBF0", VA = "0x1820ECFF0", Slot = "26")]
		protected sealed override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06025FB0 RID: 155568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FB0")]
		[Address(RVA = "0x20ED6D0", Offset = "0x20EC2D0", VA = "0x1820ED6D0")]
		private IEnumerator _HandleMask(bool isPageShow)
		{
			return null;
		}

		// Token: 0x06025FB1 RID: 155569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FB1")]
		[Address(RVA = "0x20ED790", Offset = "0x20EC390", VA = "0x1820ED790")]
		private void _ResetMask(bool isShow)
		{
		}

		// Token: 0x06025FB2 RID: 155570
		[Token(Token = "0x6025FB2")]
		public abstract IPageActHandler GetActivityHandler();

		// Token: 0x170059DA RID: 23002
		// (get) Token: 0x06025FB3 RID: 155571 RVA: 0x000C99A8 File Offset: 0x000C7BA8
		[Token(Token = "0x170059DA")]
		protected virtual ActivityEntryPage.PageInOutType pageInOutType
		{
			[Token(Token = "0x6025FB3")]
			[Address(RVA = "0x20EDA80", Offset = "0x20EC680", VA = "0x1820EDA80", Slot = "32")]
			get
			{
				return ActivityEntryPage.PageInOutType.NONE;
			}
		}

		// Token: 0x06025FB4 RID: 155572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FB4")]
		[Address(RVA = "0x20ED1F0", Offset = "0x20EBDF0", VA = "0x1820ED1F0", Slot = "33")]
		protected virtual IPageMaskHandler GetPageMaskHandler()
		{
			return null;
		}

		// Token: 0x06025FB5 RID: 155573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FB5")]
		[Address(RVA = "0x20ECF40", Offset = "0x20EBB40", VA = "0x1820ECF40", Slot = "34")]
		protected virtual IEnumerator EffectOnActPageShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06025FB6 RID: 155574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FB6")]
		[Address(RVA = "0x20ECE90", Offset = "0x20EBA90", VA = "0x1820ECE90", Slot = "35")]
		protected virtual IEnumerator EffectOnActPageHide(bool isIntoStack)
		{
			return null;
		}

		// Token: 0x06025FB7 RID: 155575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FB7")]
		[Address(RVA = "0x20ED670", Offset = "0x20EC270", VA = "0x1820ED670", Slot = "36")]
		protected virtual void SetPageShow(bool isShow)
		{
		}

		// Token: 0x06025FB8 RID: 155576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FB8")]
		[Address(RVA = "0x20ED890", Offset = "0x20EC490", VA = "0x1820ED890")]
		protected ActivityEntryPage()
		{
		}

		// Token: 0x06025FB9 RID: 155577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FB9")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06025FBA RID: 155578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FBA")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06025FBB RID: 155579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FBB")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x06025FBC RID: 155580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FBC")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06025FBD RID: 155581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FBD")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06025FBE RID: 155582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025FBE")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0403571D RID: 218909
		[Token(Token = "0x403571D")]
		[FieldOffset(Offset = "0xF0")]
		private ActivityEntryPage.IParams m_param;

		// Token: 0x0403571E RID: 218910
		[Token(Token = "0x403571E")]
		[FieldOffset(Offset = "0xF8")]
		private DataBundle m_savedInst;

		// Token: 0x0403571F RID: 218911
		[Token(Token = "0x403571F")]
		[FieldOffset(Offset = "0x100")]
		private IPageActHandler m_actHandler;

		// Token: 0x04035720 RID: 218912
		[Token(Token = "0x4035720")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04035721 RID: 218913
		[Token(Token = "0x4035721")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isFromBattle;

		// Token: 0x04035722 RID: 218914
		[Token(Token = "0x4035722")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetInstID;

		// Token: 0x04035723 RID: 218915
		[Token(Token = "0x4035723")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04035724 RID: 218916
		[Token(Token = "0x4035724")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04035725 RID: 218917
		[Token(Token = "0x4035725")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x04035726 RID: 218918
		[Token(Token = "0x4035726")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04035727 RID: 218919
		[Token(Token = "0x4035727")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04035728 RID: 218920
		[Token(Token = "0x4035728")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04035729 RID: 218921
		[Token(Token = "0x4035729")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleMask;

		// Token: 0x0403572A RID: 218922
		[Token(Token = "0x403572A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetMask;

		// Token: 0x0403572B RID: 218923
		[Token(Token = "0x403572B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_pageInOutType;

		// Token: 0x0403572C RID: 218924
		[Token(Token = "0x403572C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetPageMaskHandler;

		// Token: 0x0403572D RID: 218925
		[Token(Token = "0x403572D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EffectOnActPageShow;

		// Token: 0x0403572E RID: 218926
		[Token(Token = "0x403572E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EffectOnActPageHide;

		// Token: 0x0403572F RID: 218927
		[Token(Token = "0x403572F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetPageShow;

		// Token: 0x04035730 RID: 218928
		[Token(Token = "0x4035730")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200676B RID: 26475
		[Token(Token = "0x200676B")]
		public enum PageInOutType
		{
			// Token: 0x04035732 RID: 218930
			[Token(Token = "0x4035732")]
			NONE,
			// Token: 0x04035733 RID: 218931
			[Token(Token = "0x4035733")]
			BLACK_IN_OUT,
			// Token: 0x04035734 RID: 218932
			[Token(Token = "0x4035734")]
			MASK_IN_OUT
		}

		// Token: 0x0200676C RID: 26476
		[Token(Token = "0x200676C")]
		public interface IParams
		{
			// Token: 0x06025FBF RID: 155583
			[Token(Token = "0x6025FBF")]
			string GetActId();
		}
	}
}
