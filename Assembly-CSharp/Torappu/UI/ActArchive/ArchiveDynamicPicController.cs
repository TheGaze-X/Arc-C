using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BCF RID: 27599
	[Token(Token = "0x2006BCF")]
	public class ArchiveDynamicPicController : ActArchiveController
	{
		// Token: 0x17005D0F RID: 23823
		// (get) Token: 0x060276A3 RID: 161443 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060276A4 RID: 161444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D0F")]
		public Action<bool> onFullscreenToggled
		{
			[Token(Token = "0x60276A3")]
			[Address(RVA = "0x22902B0", Offset = "0x228EEB0", VA = "0x1822902B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60276A4")]
			[Address(RVA = "0x2290310", Offset = "0x228EF10", VA = "0x182290310")]
			set
			{
			}
		}

		// Token: 0x060276A5 RID: 161445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276A5")]
		[Address(RVA = "0x228FF70", Offset = "0x228EB70", VA = "0x18228FF70", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060276A6 RID: 161446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276A6")]
		[Address(RVA = "0x2290010", Offset = "0x228EC10", VA = "0x182290010")]
		public void OnPicClicked()
		{
		}

		// Token: 0x060276A7 RID: 161447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276A7")]
		[Address(RVA = "0x2290120", Offset = "0x228ED20", VA = "0x182290120")]
		public void OnSetHomeKV()
		{
		}

		// Token: 0x060276A8 RID: 161448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276A8")]
		[Address(RVA = "0x228FB40", Offset = "0x228E740", VA = "0x18228FB40")]
		public List<DataBinder<PicProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060276A9 RID: 161449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276A9")]
		[Address(RVA = "0x228FE20", Offset = "0x228EA20", VA = "0x18228FE20", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060276AA RID: 161450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276AA")]
		[Address(RVA = "0x2290190", Offset = "0x228ED90", VA = "0x182290190", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x060276AB RID: 161451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276AB")]
		[Address(RVA = "0x2290250", Offset = "0x228EE50", VA = "0x182290250")]
		public ArchiveDynamicPicController()
		{
		}

		// Token: 0x060276AC RID: 161452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276AC")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x060276AD RID: 161453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276AD")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x060276AE RID: 161454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276AE")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04037D82 RID: 228738
		[Token(Token = "0x4037D82")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchivePicListDataBinder _picListBinder;

		// Token: 0x04037D83 RID: 228739
		[Token(Token = "0x4037D83")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchivePicContentDataBinder _picContentBinder;

		// Token: 0x04037D84 RID: 228740
		[Token(Token = "0x4037D84")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArchiveDynamicPicFullscreenDataBinder _picFullscreenDataBinder;

		// Token: 0x04037D85 RID: 228741
		[Token(Token = "0x4037D85")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action onSetHomeKV;

		// Token: 0x04037D86 RID: 228742
		[Token(Token = "0x4037D86")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<ActArchiveType, string> onPicItemClicked;

		// Token: 0x04037D87 RID: 228743
		[Token(Token = "0x4037D87")]
		[FieldOffset(Offset = "0x60")]
		private Action<bool> m_onFullscreenToggled;

		// Token: 0x04037D88 RID: 228744
		[Token(Token = "0x4037D88")]
		[FieldOffset(Offset = "0x68")]
		private ArchiveDynamicPicController.Handler m_handler;

		// Token: 0x04037D89 RID: 228745
		[Token(Token = "0x4037D89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onFullscreenToggled;

		// Token: 0x04037D8A RID: 228746
		[Token(Token = "0x4037D8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onFullscreenToggled;

		// Token: 0x04037D8B RID: 228747
		[Token(Token = "0x4037D8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037D8C RID: 228748
		[Token(Token = "0x4037D8C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPicClicked;

		// Token: 0x04037D8D RID: 228749
		[Token(Token = "0x4037D8D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSetHomeKV;

		// Token: 0x04037D8E RID: 228750
		[Token(Token = "0x4037D8E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037D8F RID: 228751
		[Token(Token = "0x4037D8F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037D90 RID: 228752
		[Token(Token = "0x4037D90")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04037D91 RID: 228753
		[Token(Token = "0x4037D91")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BD0 RID: 27600
		[Token(Token = "0x2006BD0")]
		private class Handler : ArchivePicControllerHandler
		{
			// Token: 0x060276AF RID: 161455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60276AF")]
			[Address(RVA = "0x22A2230", Offset = "0x22A0E30", VA = "0x1822A2230")]
			public Handler(ArchiveDynamicPicController closure)
			{
			}

			// Token: 0x060276B0 RID: 161456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60276B0")]
			[Address(RVA = "0x22A1E10", Offset = "0x22A0A10", VA = "0x1822A1E10", Slot = "4")]
			public override void OnItemClick(string funcId)
			{
			}

			// Token: 0x04037D92 RID: 228754
			[Token(Token = "0x4037D92")]
			[FieldOffset(Offset = "0x10")]
			private ArchiveDynamicPicController m_closure;

			// Token: 0x04037D93 RID: 228755
			[Token(Token = "0x4037D93")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037D94 RID: 228756
			[Token(Token = "0x4037D94")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnItemClick;
		}
	}
}
