using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F93 RID: 16275
	[Token(Token = "0x2003F93")]
	public class SiracusaMapZoneMapHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x060193EE RID: 103406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060193EF RID: 103407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C47")]
		public Action<SiracusaMapMapNodeViewModel> onNodeClicked
		{
			[Token(Token = "0x60193EE")]
			[Address(RVA = "0x11F54A0", Offset = "0x11F40A0", VA = "0x1811F54A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60193EF")]
			[Address(RVA = "0x11F5580", Offset = "0x11F4180", VA = "0x1811F5580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x060193F0 RID: 103408 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060193F1 RID: 103409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C48")]
		public Action onBigMapBlankClicked
		{
			[Token(Token = "0x60193F0")]
			[Address(RVA = "0x11F5440", Offset = "0x11F4040", VA = "0x1811F5440")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60193F1")]
			[Address(RVA = "0x11F5500", Offset = "0x11F4100", VA = "0x1811F5500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060193F2 RID: 103410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F2")]
		[Address(RVA = "0x11F4AD0", Offset = "0x11F36D0", VA = "0x1811F4AD0")]
		public void Init(SiracusaMapController mapController)
		{
		}

		// Token: 0x060193F3 RID: 103411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F3")]
		[Address(RVA = "0x11F51E0", Offset = "0x11F3DE0", VA = "0x1811F51E0")]
		private void _OnFogClicked()
		{
		}

		// Token: 0x060193F4 RID: 103412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F4")]
		[Address(RVA = "0x11F52C0", Offset = "0x11F3EC0", VA = "0x1811F52C0")]
		private void _OnNodeClick(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x060193F5 RID: 103413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F5")]
		[Address(RVA = "0x11F50D0", Offset = "0x11F3CD0", VA = "0x1811F50D0")]
		private void _OnBigMapBlankClicked()
		{
		}

		// Token: 0x060193F6 RID: 103414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F6")]
		[Address(RVA = "0x11F53E0", Offset = "0x11F3FE0", VA = "0x1811F53E0")]
		public SiracusaMapZoneMapHolder()
		{
		}

		// Token: 0x0401F551 RID: 128337
		[Token(Token = "0x401F551")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _bigMapContainer;

		// Token: 0x0401F552 RID: 128338
		[Token(Token = "0x401F552")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _smallMapContainer;

		// Token: 0x0401F553 RID: 128339
		[Token(Token = "0x401F553")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SiracusaMapBigMapView _bigMapPrefab;

		// Token: 0x0401F554 RID: 128340
		[Token(Token = "0x401F554")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SiracusaMapSmallMapView _smallMapPrefab;

		// Token: 0x0401F555 RID: 128341
		[Token(Token = "0x401F555")]
		[FieldOffset(Offset = "0x38")]
		private SiracusaMapBigMapView m_bigMapView;

		// Token: 0x0401F556 RID: 128342
		[Token(Token = "0x401F556")]
		[FieldOffset(Offset = "0x40")]
		private SiracusaMapSmallMapView m_smallMapView;

		// Token: 0x0401F557 RID: 128343
		[Token(Token = "0x401F557")]
		[FieldOffset(Offset = "0x48")]
		private SiracusaMapController m_closure;

		// Token: 0x0401F55A RID: 128346
		[Token(Token = "0x401F55A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeClicked;

		// Token: 0x0401F55B RID: 128347
		[Token(Token = "0x401F55B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeClicked;

		// Token: 0x0401F55C RID: 128348
		[Token(Token = "0x401F55C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onBigMapBlankClicked;

		// Token: 0x0401F55D RID: 128349
		[Token(Token = "0x401F55D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onBigMapBlankClicked;

		// Token: 0x0401F55E RID: 128350
		[Token(Token = "0x401F55E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F55F RID: 128351
		[Token(Token = "0x401F55F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFogClicked;

		// Token: 0x0401F560 RID: 128352
		[Token(Token = "0x401F560")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnNodeClick;

		// Token: 0x0401F561 RID: 128353
		[Token(Token = "0x401F561")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBigMapBlankClicked;

		// Token: 0x0401F562 RID: 128354
		[Token(Token = "0x401F562")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
