using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF2 RID: 16114
	[Token(Token = "0x2003EF2")]
	public class SiracusaMapNavigationStageButtonView : SiracusaMapNavigationButtonBaseView
	{
		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x06019011 RID: 102417 RVA: 0x0009CA98 File Offset: 0x0009AC98
		[Token(Token = "0x17003BAA")]
		public bool showNewIfNeed
		{
			[Token(Token = "0x6019011")]
			[Address(RVA = "0x11B9080", Offset = "0x11B7C80", VA = "0x1811B9080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x06019012 RID: 102418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019013 RID: 102419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BAB")]
		public SiracusaMapController closure
		{
			[Token(Token = "0x6019012")]
			[Address(RVA = "0x11B9020", Offset = "0x11B7C20", VA = "0x1811B9020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019013")]
			[Address(RVA = "0x11B9110", Offset = "0x11B7D10", VA = "0x1811B9110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019014 RID: 102420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019014")]
		[Address(RVA = "0x11B8AE0", Offset = "0x11B76E0", VA = "0x1811B8AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019015 RID: 102421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019015")]
		[Address(RVA = "0x11B8880", Offset = "0x11B7480", VA = "0x1811B8880", Slot = "4")]
		public override void Render(SiracusaMapNavigationDetailViewModel viewModel)
		{
		}

		// Token: 0x06019016 RID: 102422 RVA: 0x0009CAB0 File Offset: 0x0009ACB0
		[Token(Token = "0x6019016")]
		[Address(RVA = "0x11B8BC0", Offset = "0x11B77C0", VA = "0x1811B8BC0")]
		private bool _IsEntryLockedShowToast()
		{
			return default(bool);
		}

		// Token: 0x06019017 RID: 102423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019017")]
		[Address(RVA = "0x11B8DA0", Offset = "0x11B79A0", VA = "0x1811B8DA0")]
		private string _TryGetLockTips()
		{
			return null;
		}

		// Token: 0x06019018 RID: 102424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019018")]
		[Address(RVA = "0x11B8710", Offset = "0x11B7310", VA = "0x1811B8710")]
		public void OnEntryClick()
		{
		}

		// Token: 0x06019019 RID: 102425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019019")]
		[Address(RVA = "0x11B8F80", Offset = "0x11B7B80", VA = "0x1811B8F80")]
		public SiracusaMapNavigationStageButtonView()
		{
		}

		// Token: 0x0601901A RID: 102426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601901A")]
		[Address(RVA = "0x11B6910", Offset = "0x11B5510", VA = "0x1811B6910")]
		private void <>xLuaBaseProxy_Render(SiracusaMapNavigationDetailViewModel P0)
		{
		}

		// Token: 0x0401EE72 RID: 126578
		[Token(Token = "0x401EE72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objEntryLock;

		// Token: 0x0401EE73 RID: 126579
		[Token(Token = "0x401EE73")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0401EE74 RID: 126580
		[Token(Token = "0x401EE74")]
		[FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_newProperty;

		// Token: 0x0401EE75 RID: 126581
		[Token(Token = "0x401EE75")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401EE77 RID: 126583
		[Token(Token = "0x401EE77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showNewIfNeed;

		// Token: 0x0401EE78 RID: 126584
		[Token(Token = "0x401EE78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_closure;

		// Token: 0x0401EE79 RID: 126585
		[Token(Token = "0x401EE79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_closure;

		// Token: 0x0401EE7A RID: 126586
		[Token(Token = "0x401EE7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EE7B RID: 126587
		[Token(Token = "0x401EE7B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EE7C RID: 126588
		[Token(Token = "0x401EE7C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsEntryLockedShowToast;

		// Token: 0x0401EE7D RID: 126589
		[Token(Token = "0x401EE7D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryGetLockTips;

		// Token: 0x0401EE7E RID: 126590
		[Token(Token = "0x401EE7E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEntryClick;

		// Token: 0x0401EE7F RID: 126591
		[Token(Token = "0x401EE7F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
