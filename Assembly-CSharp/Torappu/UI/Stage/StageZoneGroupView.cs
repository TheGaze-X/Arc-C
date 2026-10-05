using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006984 RID: 27012
	[Token(Token = "0x2006984")]
	public abstract class StageZoneGroupView : DataBinder<ZoneGroupViewProperty>, IHotfixable
	{
		// Token: 0x17005B3B RID: 23355
		// (get) Token: 0x06026A65 RID: 158309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B3B")]
		protected Transform zoneContainer
		{
			[Token(Token = "0x6026A65")]
			[Address(RVA = "0x21C0C70", Offset = "0x21BF870", VA = "0x1821C0C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B3C RID: 23356
		// (get) Token: 0x06026A66 RID: 158310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B3C")]
		protected StageZoneSelectItem zoneViewPrefab
		{
			[Token(Token = "0x6026A66")]
			[Address(RVA = "0x21C0CD0", Offset = "0x21BF8D0", VA = "0x1821C0CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B3D RID: 23357
		// (get) Token: 0x06026A67 RID: 158311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B3D")]
		protected CanvasGroup alphaHandler
		{
			[Token(Token = "0x6026A67")]
			[Address(RVA = "0x21C0960", Offset = "0x21BF560", VA = "0x1821C0960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B3E RID: 23358
		// (get) Token: 0x06026A68 RID: 158312 RVA: 0x000CBE80 File Offset: 0x000CA080
		[Token(Token = "0x17005B3E")]
		protected StageZoneGroupView.GroupState groupState
		{
			[Token(Token = "0x6026A68")]
			[Address(RVA = "0x21C0A30", Offset = "0x21BF630", VA = "0x1821C0A30")]
			get
			{
				return StageZoneGroupView.GroupState.NONE;
			}
		}

		// Token: 0x17005B3F RID: 23359
		// (get) Token: 0x06026A69 RID: 158313 RVA: 0x000CBE98 File Offset: 0x000CA098
		[Token(Token = "0x17005B3F")]
		protected bool isActive
		{
			[Token(Token = "0x6026A69")]
			[Address(RVA = "0x21C0AE0", Offset = "0x21BF6E0", VA = "0x1821C0AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B40 RID: 23360
		// (get) Token: 0x06026A6A RID: 158314 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026A6B RID: 158315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B40")]
		private protected ZoneGroupViewModel viewModel
		{
			[Token(Token = "0x6026A6A")]
			[Address(RVA = "0x21C0BB0", Offset = "0x21BF7B0", VA = "0x1821C0BB0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6026A6B")]
			[Address(RVA = "0x21C0DB0", Offset = "0x21BF9B0", VA = "0x1821C0DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005B41 RID: 23361
		// (get) Token: 0x06026A6C RID: 158316 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026A6D RID: 158317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B41")]
		private protected ZoneGroupViewProperty viewProp
		{
			[Token(Token = "0x6026A6C")]
			[Address(RVA = "0x21C0C10", Offset = "0x21BF810", VA = "0x1821C0C10")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6026A6D")]
			[Address(RVA = "0x21C0E30", Offset = "0x21BFA30", VA = "0x1821C0E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026A6E RID: 158318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A6E")]
		[Address(RVA = "0x21BFEC0", Offset = "0x21BEAC0", VA = "0x1821BFEC0", Slot = "7")]
		public sealed override void OnValueChanged(ZoneGroupViewProperty property)
		{
		}

		// Token: 0x17005B42 RID: 23362
		// (get) Token: 0x06026A6F RID: 158319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026A70 RID: 158320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B42")]
		public Action<ZoneGroupViewModel, ZoneViewModel> onZoneSelected
		{
			[Token(Token = "0x6026A6F")]
			[Address(RVA = "0x21C0B50", Offset = "0x21BF750", VA = "0x1821C0B50")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6026A70")]
			[Address(RVA = "0x21C0D30", Offset = "0x21BF930", VA = "0x1821C0D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005B43 RID: 23363
		// (get) Token: 0x06026A71 RID: 158321
		[Token(Token = "0x17005B43")]
		protected abstract bool showLockedZones { [Token(Token = "0x6026A71")] get; }

		// Token: 0x06026A72 RID: 158322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A72")]
		[Address(RVA = "0x21BFE00", Offset = "0x21BEA00", VA = "0x1821BFE00", Slot = "9")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06026A73 RID: 158323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A73")]
		[Address(RVA = "0x21BFD40", Offset = "0x21BE940", VA = "0x1821BFD40", Slot = "10")]
		protected virtual void OnEnter()
		{
		}

		// Token: 0x06026A74 RID: 158324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A74")]
		[Address(RVA = "0x21BFDA0", Offset = "0x21BE9A0", VA = "0x1821BFDA0", Slot = "11")]
		protected virtual void OnExit()
		{
		}

		// Token: 0x06026A75 RID: 158325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026A75")]
		[Address(RVA = "0x21BFBE0", Offset = "0x21BE7E0", VA = "0x1821BFBE0", Slot = "12")]
		protected virtual IEnumerator EnterCoroutine()
		{
			return null;
		}

		// Token: 0x06026A76 RID: 158326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026A76")]
		[Address(RVA = "0x21BFC90", Offset = "0x21BE890", VA = "0x1821BFC90", Slot = "13")]
		protected virtual IEnumerator ExitCoroutine()
		{
			return null;
		}

		// Token: 0x06026A77 RID: 158327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A77")]
		[Address(RVA = "0x21BFAC0", Offset = "0x21BE6C0", VA = "0x1821BFAC0", Slot = "14")]
		protected virtual void CancelEnter()
		{
		}

		// Token: 0x06026A78 RID: 158328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A78")]
		[Address(RVA = "0x21BFB50", Offset = "0x21BE750", VA = "0x1821BFB50", Slot = "15")]
		protected virtual void CancelExit()
		{
		}

		// Token: 0x06026A79 RID: 158329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A79")]
		[Address(RVA = "0x21BFE60", Offset = "0x21BEA60", VA = "0x1821BFE60", Slot = "16")]
		protected virtual void OnUpdate(bool isActive)
		{
		}

		// Token: 0x06026A7A RID: 158330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A7A")]
		[Address(RVA = "0x21C0280", Offset = "0x21BEE80", VA = "0x1821C0280")]
		private void _InitZoneListView()
		{
		}

		// Token: 0x06026A7B RID: 158331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026A7B")]
		[Address(RVA = "0x21C0090", Offset = "0x21BEC90", VA = "0x1821C0090")]
		private IEnumerator _EnterProcess()
		{
			return null;
		}

		// Token: 0x06026A7C RID: 158332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026A7C")]
		[Address(RVA = "0x21C0140", Offset = "0x21BED40", VA = "0x1821C0140")]
		private IEnumerator _ExitProcess()
		{
			return null;
		}

		// Token: 0x06026A7D RID: 158333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A7D")]
		[Address(RVA = "0x21C05D0", Offset = "0x21BF1D0", VA = "0x1821C05D0")]
		private void _UpdateLifecycle(ZoneGroupViewProperty property)
		{
		}

		// Token: 0x06026A7E RID: 158334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A7E")]
		[Address(RVA = "0x21C01F0", Offset = "0x21BEDF0", VA = "0x1821C01F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026A7F RID: 158335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A7F")]
		[Address(RVA = "0x21C0890", Offset = "0x21BF490", VA = "0x1821C0890")]
		protected StageZoneGroupView()
		{
		}

		// Token: 0x04036914 RID: 223508
		[Token(Token = "0x4036914")]
		private const float DEFAULT_ANIM_DUR = 0.2f;

		// Token: 0x04036915 RID: 223509
		[Token(Token = "0x4036915")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageZoneSelectItem _zoneViewPrefab;

		// Token: 0x04036916 RID: 223510
		[Token(Token = "0x4036916")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _zoneContainer;

		// Token: 0x04036917 RID: 223511
		[Token(Token = "0x4036917")]
		[FieldOffset(Offset = "0x30")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x04036918 RID: 223512
		[Token(Token = "0x4036918")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04036919 RID: 223513
		[Token(Token = "0x4036919")]
		[FieldOffset(Offset = "0x3C")]
		private StageZoneGroupView.GroupState m_groupState;

		// Token: 0x0403691A RID: 223514
		[Token(Token = "0x403691A")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_defaultEnterTween;

		// Token: 0x0403691B RID: 223515
		[Token(Token = "0x403691B")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_defaultExitTween;

		// Token: 0x0403691C RID: 223516
		[Token(Token = "0x403691C")]
		[FieldOffset(Offset = "0x50")]
		protected List<StageZoneSelectItem> zoneViews;

		// Token: 0x04036920 RID: 223520
		[Token(Token = "0x4036920")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneContainer;

		// Token: 0x04036921 RID: 223521
		[Token(Token = "0x4036921")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_zoneViewPrefab;

		// Token: 0x04036922 RID: 223522
		[Token(Token = "0x4036922")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x04036923 RID: 223523
		[Token(Token = "0x4036923")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_groupState;

		// Token: 0x04036924 RID: 223524
		[Token(Token = "0x4036924")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x04036925 RID: 223525
		[Token(Token = "0x4036925")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x04036926 RID: 223526
		[Token(Token = "0x4036926")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_viewModel;

		// Token: 0x04036927 RID: 223527
		[Token(Token = "0x4036927")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_viewProp;

		// Token: 0x04036928 RID: 223528
		[Token(Token = "0x4036928")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_viewProp;

		// Token: 0x04036929 RID: 223529
		[Token(Token = "0x4036929")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403692A RID: 223530
		[Token(Token = "0x403692A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_onZoneSelected;

		// Token: 0x0403692B RID: 223531
		[Token(Token = "0x403692B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_onZoneSelected;

		// Token: 0x0403692C RID: 223532
		[Token(Token = "0x403692C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403692D RID: 223533
		[Token(Token = "0x403692D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403692E RID: 223534
		[Token(Token = "0x403692E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403692F RID: 223535
		[Token(Token = "0x403692F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EnterCoroutine;

		// Token: 0x04036930 RID: 223536
		[Token(Token = "0x4036930")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ExitCoroutine;

		// Token: 0x04036931 RID: 223537
		[Token(Token = "0x4036931")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CancelEnter;

		// Token: 0x04036932 RID: 223538
		[Token(Token = "0x4036932")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CancelExit;

		// Token: 0x04036933 RID: 223539
		[Token(Token = "0x4036933")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04036934 RID: 223540
		[Token(Token = "0x4036934")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitZoneListView;

		// Token: 0x04036935 RID: 223541
		[Token(Token = "0x4036935")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EnterProcess;

		// Token: 0x04036936 RID: 223542
		[Token(Token = "0x4036936")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ExitProcess;

		// Token: 0x04036937 RID: 223543
		[Token(Token = "0x4036937")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateLifecycle;

		// Token: 0x04036938 RID: 223544
		[Token(Token = "0x4036938")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036939 RID: 223545
		[Token(Token = "0x4036939")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006985 RID: 27013
		[Token(Token = "0x2006985")]
		protected enum GroupState
		{
			// Token: 0x0403693B RID: 223547
			[Token(Token = "0x403693B")]
			NONE,
			// Token: 0x0403693C RID: 223548
			[Token(Token = "0x403693C")]
			ENTERING,
			// Token: 0x0403693D RID: 223549
			[Token(Token = "0x403693D")]
			ACTIVE,
			// Token: 0x0403693E RID: 223550
			[Token(Token = "0x403693E")]
			EXITING,
			// Token: 0x0403693F RID: 223551
			[Token(Token = "0x403693F")]
			INACTIVE
		}
	}
}
