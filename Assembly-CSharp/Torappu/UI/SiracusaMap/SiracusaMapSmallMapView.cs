using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F91 RID: 16273
	[Token(Token = "0x2003F91")]
	public class SiracusaMapSmallMapView : SiracusaMapViewBase<SiracusaMapPanelMapProperty>
	{
		// Token: 0x060193E5 RID: 103397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193E5")]
		[Address(RVA = "0x11F3150", Offset = "0x11F1D50", VA = "0x1811F3150")]
		public void DoInit()
		{
		}

		// Token: 0x060193E6 RID: 103398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193E6")]
		[Address(RVA = "0x11F31B0", Offset = "0x11F1DB0", VA = "0x1811F31B0", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x060193E7 RID: 103399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193E7")]
		[Address(RVA = "0x11F35F0", Offset = "0x11F21F0", VA = "0x1811F35F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060193E8 RID: 103400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193E8")]
		[Address(RVA = "0x11F3B00", Offset = "0x11F2700", VA = "0x1811F3B00")]
		private void _InitOnValueChanged()
		{
		}

		// Token: 0x060193E9 RID: 103401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193E9")]
		[Address(RVA = "0x11F3B90", Offset = "0x11F2790", VA = "0x1811F3B90")]
		public SiracusaMapSmallMapView()
		{
		}

		// Token: 0x0401F534 RID: 128308
		[Token(Token = "0x401F534")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("SmallMap")]
		private Canvas[] _canvases;

		// Token: 0x0401F535 RID: 128309
		[Token(Token = "0x401F535")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("SmallMap")]
		private UIAnimationLocation _showAnim;

		// Token: 0x0401F536 RID: 128310
		[Token(Token = "0x401F536")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0401F537 RID: 128311
		[Token(Token = "0x401F537")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_hasValueChangedInited;

		// Token: 0x0401F538 RID: 128312
		[Token(Token = "0x401F538")]
		[FieldOffset(Offset = "0xA2")]
		private bool m_cachedIsSmallMapMode;

		// Token: 0x0401F539 RID: 128313
		[Token(Token = "0x401F539")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_showSwitchTween;

		// Token: 0x0401F53A RID: 128314
		[Token(Token = "0x401F53A")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageListener m_pageListener;

		// Token: 0x0401F53B RID: 128315
		[Token(Token = "0x401F53B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoInit;

		// Token: 0x0401F53C RID: 128316
		[Token(Token = "0x401F53C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F53D RID: 128317
		[Token(Token = "0x401F53D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F53E RID: 128318
		[Token(Token = "0x401F53E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitOnValueChanged;

		// Token: 0x0401F53F RID: 128319
		[Token(Token = "0x401F53F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
