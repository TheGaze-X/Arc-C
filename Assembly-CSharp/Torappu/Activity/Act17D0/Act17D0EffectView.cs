using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act17D0
{
	// Token: 0x020079BA RID: 31162
	[Token(Token = "0x20079BA")]
	public class Act17D0EffectView : ActivityStageComponent
	{
		// Token: 0x0602BB4F RID: 179023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB4F")]
		[Address(RVA = "0x279F500", Offset = "0x279E100", VA = "0x18279F500", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602BB50 RID: 179024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB50")]
		[Address(RVA = "0x279F210", Offset = "0x279DE10", VA = "0x18279F210", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x0602BB51 RID: 179025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB51")]
		[Address(RVA = "0x279F450", Offset = "0x279E050", VA = "0x18279F450")]
		private void OnEnable()
		{
		}

		// Token: 0x0602BB52 RID: 179026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB52")]
		[Address(RVA = "0x279F3D0", Offset = "0x279DFD0", VA = "0x18279F3D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602BB53 RID: 179027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB53")]
		[Address(RVA = "0x279F800", Offset = "0x279E400", VA = "0x18279F800")]
		private void _DisableEffect([Optional] object _)
		{
		}

		// Token: 0x0602BB54 RID: 179028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB54")]
		[Address(RVA = "0x279F8C0", Offset = "0x279E4C0", VA = "0x18279F8C0")]
		public Act17D0EffectView()
		{
		}

		// Token: 0x0602BB55 RID: 179029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB55")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0602BB56 RID: 179030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB56")]
		[Address(RVA = "0x22E9250", Offset = "0x22E7E50", VA = "0x1822E9250")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x0403F3B5 RID: 258997
		[Token(Token = "0x403F3B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScreenEffectHolder _effectHolder;

		// Token: 0x0403F3B6 RID: 258998
		[Token(Token = "0x403F3B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Act17D0EffectView.RendererCollection m_rendererCollection;

		// Token: 0x0403F3B7 RID: 258999
		[Token(Token = "0x403F3B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F3B8 RID: 259000
		[Token(Token = "0x403F3B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x0403F3B9 RID: 259001
		[Token(Token = "0x403F3B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403F3BA RID: 259002
		[Token(Token = "0x403F3BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403F3BB RID: 259003
		[Token(Token = "0x403F3BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DisableEffect;

		// Token: 0x0403F3BC RID: 259004
		[Token(Token = "0x403F3BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079BB RID: 31163
		[Token(Token = "0x20079BB")]
		private class RendererCollection : IPageUIRenderer, IHotfixable, IDisposable
		{
			// Token: 0x0602BB57 RID: 179031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB57")]
			[Address(RVA = "0x27A93D0", Offset = "0x27A7FD0", VA = "0x1827A93D0")]
			public RendererCollection(UIPage page, ScreenEffectHolder holder)
			{
			}

			// Token: 0x0602BB58 RID: 179032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB58")]
			[Address(RVA = "0x27A9150", Offset = "0x27A7D50", VA = "0x1827A9150", Slot = "4")]
			public void InitSortingInfo(SortingInfo sortingInfo)
			{
			}

			// Token: 0x0602BB59 RID: 179033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB59")]
			[Address(RVA = "0x27A8FA0", Offset = "0x27A7BA0", VA = "0x1827A8FA0", Slot = "5")]
			public void AdjustToTargetLayer(SortingInfo sortingInfo)
			{
			}

			// Token: 0x0602BB5A RID: 179034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB5A")]
			[Address(RVA = "0x27A9200", Offset = "0x27A7E00", VA = "0x1827A9200", Slot = "6")]
			public void RestoreLayers()
			{
			}

			// Token: 0x0602BB5B RID: 179035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB5B")]
			[Address(RVA = "0x27A9050", Offset = "0x27A7C50", VA = "0x1827A9050", Slot = "7")]
			public void Dispose()
			{
			}

			// Token: 0x0602BB5C RID: 179036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB5C")]
			[Address(RVA = "0x27A9280", Offset = "0x27A7E80", VA = "0x1827A9280")]
			private void _InitCacheIfNot()
			{
			}

			// Token: 0x0403F3BD RID: 259005
			[Token(Token = "0x403F3BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ScreenEffectHolder m_holder;

			// Token: 0x0403F3BE RID: 259006
			[Token(Token = "0x403F3BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_isInited;

			// Token: 0x0403F3BF RID: 259007
			[Token(Token = "0x403F3BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UIRendererSortingInfoStorage m_sortingInfo;

			// Token: 0x0403F3C0 RID: 259008
			[Token(Token = "0x403F3C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UIPage m_registeredPage;

			// Token: 0x0403F3C1 RID: 259009
			[Token(Token = "0x403F3C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403F3C2 RID: 259010
			[Token(Token = "0x403F3C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitSortingInfo;

			// Token: 0x0403F3C3 RID: 259011
			[Token(Token = "0x403F3C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AdjustToTargetLayer;

			// Token: 0x0403F3C4 RID: 259012
			[Token(Token = "0x403F3C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RestoreLayers;

			// Token: 0x0403F3C5 RID: 259013
			[Token(Token = "0x403F3C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x0403F3C6 RID: 259014
			[Token(Token = "0x403F3C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__InitCacheIfNot;
		}
	}
}
