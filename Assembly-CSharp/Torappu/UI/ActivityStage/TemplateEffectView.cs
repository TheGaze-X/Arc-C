using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CD4 RID: 27860
	[Token(Token = "0x2006CD4")]
	public class TemplateEffectView : ActivityStageComponent
	{
		// Token: 0x06027BD8 RID: 162776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BD8")]
		[Address(RVA = "0x22E8EC0", Offset = "0x22E7AC0", VA = "0x1822E8EC0", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06027BD9 RID: 162777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BD9")]
		[Address(RVA = "0x22E8C00", Offset = "0x22E7800", VA = "0x1822E8C00", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x06027BDA RID: 162778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BDA")]
		[Address(RVA = "0x22E8DF0", Offset = "0x22E79F0", VA = "0x1822E8DF0")]
		private void OnEnable()
		{
		}

		// Token: 0x06027BDB RID: 162779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BDB")]
		[Address(RVA = "0x22E8D70", Offset = "0x22E7970", VA = "0x1822E8D70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06027BDC RID: 162780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BDC")]
		[Address(RVA = "0x22E9170", Offset = "0x22E7D70", VA = "0x1822E9170")]
		public void SetEffectEnable(TemplateEffectView.DisableSource source, bool enable)
		{
		}

		// Token: 0x06027BDD RID: 162781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BDD")]
		[Address(RVA = "0x22E9260", Offset = "0x22E7E60", VA = "0x1822E9260")]
		public TemplateEffectView()
		{
		}

		// Token: 0x06027BDE RID: 162782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BDE")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06027BDF RID: 162783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BDF")]
		[Address(RVA = "0x22E9250", Offset = "0x22E7E50", VA = "0x1822E9250")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x040385C5 RID: 230853
		[Token(Token = "0x40385C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScreenEffectHolder _effectHolder;

		// Token: 0x040385C6 RID: 230854
		[Token(Token = "0x40385C6")]
		[FieldOffset(Offset = "0x28")]
		private TemplateEffectView.RendererCollection m_rendererCollection;

		// Token: 0x040385C7 RID: 230855
		[Token(Token = "0x40385C7")]
		[FieldOffset(Offset = "0x30")]
		private int m_disable;

		// Token: 0x040385C8 RID: 230856
		[Token(Token = "0x40385C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x040385C9 RID: 230857
		[Token(Token = "0x40385C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x040385CA RID: 230858
		[Token(Token = "0x40385CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x040385CB RID: 230859
		[Token(Token = "0x40385CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040385CC RID: 230860
		[Token(Token = "0x40385CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetEffectEnable;

		// Token: 0x040385CD RID: 230861
		[Token(Token = "0x40385CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CD5 RID: 27861
		[Token(Token = "0x2006CD5")]
		public enum DisableSource
		{
			// Token: 0x040385CF RID: 230863
			[Token(Token = "0x40385CF")]
			SELF = 1,
			// Token: 0x040385D0 RID: 230864
			[Token(Token = "0x40385D0")]
			STATE,
			// Token: 0x040385D1 RID: 230865
			[Token(Token = "0x40385D1")]
			PAGE = 4
		}

		// Token: 0x02006CD6 RID: 27862
		[Token(Token = "0x2006CD6")]
		private class RendererCollection : IPageUIRenderer, IHotfixable, IDisposable
		{
			// Token: 0x06027BE0 RID: 162784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BE0")]
			[Address(RVA = "0x22D5110", Offset = "0x22D3D10", VA = "0x1822D5110")]
			public RendererCollection(UIPage page, ScreenEffectHolder holder)
			{
			}

			// Token: 0x06027BE1 RID: 162785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BE1")]
			[Address(RVA = "0x22D4E90", Offset = "0x22D3A90", VA = "0x1822D4E90", Slot = "4")]
			public void InitSortingInfo(SortingInfo sortingInfo)
			{
			}

			// Token: 0x06027BE2 RID: 162786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BE2")]
			[Address(RVA = "0x22D4CE0", Offset = "0x22D38E0", VA = "0x1822D4CE0", Slot = "5")]
			public void AdjustToTargetLayer(SortingInfo sortingInfo)
			{
			}

			// Token: 0x06027BE3 RID: 162787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BE3")]
			[Address(RVA = "0x22D4F40", Offset = "0x22D3B40", VA = "0x1822D4F40", Slot = "6")]
			public void RestoreLayers()
			{
			}

			// Token: 0x06027BE4 RID: 162788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BE4")]
			[Address(RVA = "0x22D4D90", Offset = "0x22D3990", VA = "0x1822D4D90", Slot = "7")]
			public void Dispose()
			{
			}

			// Token: 0x06027BE5 RID: 162789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BE5")]
			[Address(RVA = "0x22D4FC0", Offset = "0x22D3BC0", VA = "0x1822D4FC0")]
			private void _InitCacheIfNot()
			{
			}

			// Token: 0x040385D2 RID: 230866
			[Token(Token = "0x40385D2")]
			[FieldOffset(Offset = "0x10")]
			private ScreenEffectHolder m_holder;

			// Token: 0x040385D3 RID: 230867
			[Token(Token = "0x40385D3")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isInited;

			// Token: 0x040385D4 RID: 230868
			[Token(Token = "0x40385D4")]
			[FieldOffset(Offset = "0x20")]
			private UIRendererSortingInfoStorage m_sortingInfo;

			// Token: 0x040385D5 RID: 230869
			[Token(Token = "0x40385D5")]
			[FieldOffset(Offset = "0x28")]
			private UIPage m_registeredPage;

			// Token: 0x040385D6 RID: 230870
			[Token(Token = "0x40385D6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040385D7 RID: 230871
			[Token(Token = "0x40385D7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitSortingInfo;

			// Token: 0x040385D8 RID: 230872
			[Token(Token = "0x40385D8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AdjustToTargetLayer;

			// Token: 0x040385D9 RID: 230873
			[Token(Token = "0x40385D9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RestoreLayers;

			// Token: 0x040385DA RID: 230874
			[Token(Token = "0x40385DA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x040385DB RID: 230875
			[Token(Token = "0x40385DB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__InitCacheIfNot;
		}
	}
}
