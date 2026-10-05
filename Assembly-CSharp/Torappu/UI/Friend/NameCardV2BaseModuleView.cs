using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DFE RID: 19966
	[Token(Token = "0x2004DFE")]
	public abstract class NameCardV2BaseModuleView : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x0601DD6F RID: 122223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004604")]
		public string moduleId
		{
			[Token(Token = "0x601DD6F")]
			[Address(RVA = "0x1772CE0", Offset = "0x17718E0", VA = "0x181772CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DD70 RID: 122224
		[Token(Token = "0x601DD70")]
		public abstract void RenderModuleView(NameCardV2ModuleBaseModel model);

		// Token: 0x0601DD71 RID: 122225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD71")]
		[Address(RVA = "0x1772BA0", Offset = "0x17717A0", VA = "0x181772BA0", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DD72 RID: 122226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD72")]
		[Address(RVA = "0x1772C70", Offset = "0x1771870", VA = "0x181772C70")]
		protected NameCardV2BaseModuleView()
		{
		}

		// Token: 0x0402789D RID: 161949
		[Token(Token = "0x402789D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Module Basic")]
		private string _moduleId;

		// Token: 0x0402789E RID: 161950
		[Token(Token = "0x402789E")]
		[FieldOffset(Offset = "0x28")]
		protected UIStateFinder m_stateFinder;

		// Token: 0x0402789F RID: 161951
		[Token(Token = "0x402789F")]
		[FieldOffset(Offset = "0x38")]
		protected UIPageFinder m_pageFinder;

		// Token: 0x040278A0 RID: 161952
		[Token(Token = "0x40278A0")]
		[FieldOffset(Offset = "0x48")]
		protected NameCardV2ViewModel.ShowType m_cachedShowType;

		// Token: 0x040278A1 RID: 161953
		[Token(Token = "0x40278A1")]
		[FieldOffset(Offset = "0x4C")]
		protected bool m_cachedShowDetail;

		// Token: 0x040278A2 RID: 161954
		[Token(Token = "0x40278A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moduleId;

		// Token: 0x040278A3 RID: 161955
		[Token(Token = "0x40278A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x040278A4 RID: 161956
		[Token(Token = "0x40278A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
