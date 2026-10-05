using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067AA RID: 26538
	[Token(Token = "0x20067AA")]
	public abstract class StageZoneHomeEntryItemBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x060260FC RID: 155900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260FC")]
		[Address(RVA = "0x211F720", Offset = "0x211E320", VA = "0x18211F720")]
		public void SetData(ZoneHomeEntryItemModel viewModel)
		{
		}

		// Token: 0x17005A07 RID: 23047
		// (get) Token: 0x060260FD RID: 155901
		[Token(Token = "0x17005A07")]
		public abstract CanvasGroup alphaHandler { [Token(Token = "0x60260FD")] get; }

		// Token: 0x060260FE RID: 155902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260FE")]
		[Address(RVA = "0x211F670", Offset = "0x211E270", VA = "0x18211F670")]
		public void RenderBeforeLayout(HomeEntryLayoutLevel layoutLevel)
		{
		}

		// Token: 0x060260FF RID: 155903
		[Token(Token = "0x60260FF")]
		protected abstract void OnRender(ZoneHomeEntryItemModel viewModel, HomeEntryLayoutLevel level);

		// Token: 0x06026100 RID: 155904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026100")]
		[Address(RVA = "0x211F7A0", Offset = "0x211E3A0", VA = "0x18211F7A0")]
		protected StageZoneHomeEntryItemBase()
		{
		}

		// Token: 0x04035918 RID: 219416
		[Token(Token = "0x4035918")]
		[FieldOffset(Offset = "0x18")]
		private ZoneHomeEntryItemModel m_viewModel;

		// Token: 0x04035919 RID: 219417
		[Token(Token = "0x4035919")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0403591A RID: 219418
		[Token(Token = "0x403591A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderBeforeLayout;

		// Token: 0x0403591B RID: 219419
		[Token(Token = "0x403591B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
