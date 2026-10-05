using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200699D RID: 27037
	[Token(Token = "0x200699D")]
	public class StageZoneGroupPanel : DataBinder<ZoneGroupViewProperty>, IHotfixable
	{
		// Token: 0x17005B54 RID: 23380
		// (get) Token: 0x06026AEE RID: 158446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B54")]
		protected StagePage stagePage
		{
			[Token(Token = "0x6026AEE")]
			[Address(RVA = "0x21BF8A0", Offset = "0x21BE4A0", VA = "0x1821BF8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B55 RID: 23381
		// (get) Token: 0x06026AEF RID: 158447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B55")]
		protected Action<ZoneGroupViewModel, ZoneViewModel> onZoneSelected
		{
			[Token(Token = "0x6026AEF")]
			[Address(RVA = "0x21BF840", Offset = "0x21BE440", VA = "0x1821BF840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B56 RID: 23382
		// (get) Token: 0x06026AF0 RID: 158448 RVA: 0x000CC000 File Offset: 0x000CA200
		[Token(Token = "0x17005B56")]
		protected StageZoneGroupPanel.GroupState groupState
		{
			[Token(Token = "0x6026AF0")]
			[Address(RVA = "0x21BF6B0", Offset = "0x21BE2B0", VA = "0x1821BF6B0")]
			get
			{
				return StageZoneGroupPanel.GroupState.NONE;
			}
		}

		// Token: 0x17005B57 RID: 23383
		// (get) Token: 0x06026AF1 RID: 158449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B57")]
		protected CanvasGroup alphaHandler
		{
			[Token(Token = "0x6026AF1")]
			[Address(RVA = "0x21BF5E0", Offset = "0x21BE1E0", VA = "0x1821BF5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B58 RID: 23384
		// (get) Token: 0x06026AF2 RID: 158450 RVA: 0x000CC018 File Offset: 0x000CA218
		[Token(Token = "0x17005B58")]
		protected bool isActive
		{
			[Token(Token = "0x6026AF2")]
			[Address(RVA = "0x21BF760", Offset = "0x21BE360", VA = "0x1821BF760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B59 RID: 23385
		// (get) Token: 0x06026AF3 RID: 158451 RVA: 0x000CC030 File Offset: 0x000CA230
		[Token(Token = "0x17005B59")]
		protected bool isTransiting
		{
			[Token(Token = "0x6026AF3")]
			[Address(RVA = "0x21BF7D0", Offset = "0x21BE3D0", VA = "0x1821BF7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B5A RID: 23386
		// (get) Token: 0x06026AF4 RID: 158452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026AF5 RID: 158453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B5A")]
		private protected ZoneGroupViewModel viewModel
		{
			[Token(Token = "0x6026AF4")]
			[Address(RVA = "0x21BF900", Offset = "0x21BE500", VA = "0x1821BF900")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6026AF5")]
			[Address(RVA = "0x21BF9C0", Offset = "0x21BE5C0", VA = "0x1821BF9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005B5B RID: 23387
		// (get) Token: 0x06026AF6 RID: 158454 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026AF7 RID: 158455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B5B")]
		private protected ZoneGroupViewProperty viewProp
		{
			[Token(Token = "0x6026AF6")]
			[Address(RVA = "0x21BF960", Offset = "0x21BE560", VA = "0x1821BF960")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6026AF7")]
			[Address(RVA = "0x21BFA40", Offset = "0x21BE640", VA = "0x1821BFA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026AF8 RID: 158456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AF8")]
		[Address(RVA = "0x21BDE90", Offset = "0x21BCA90", VA = "0x1821BDE90", Slot = "8")]
		protected virtual void OnEnter()
		{
		}

		// Token: 0x06026AF9 RID: 158457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AF9")]
		[Address(RVA = "0x21BDE30", Offset = "0x21BCA30", VA = "0x1821BDE30", Slot = "9")]
		protected virtual void OnDataUpdated(ZoneGroupViewProperty prop)
		{
		}

		// Token: 0x06026AFA RID: 158458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AFA")]
		[Address(RVA = "0x21BF410", Offset = "0x21BE010", VA = "0x1821BF410")]
		private IEnumerator _EnterProcess()
		{
			return null;
		}

		// Token: 0x06026AFB RID: 158459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AFB")]
		[Address(RVA = "0x21BF4C0", Offset = "0x21BE0C0", VA = "0x1821BF4C0")]
		private IEnumerator _ExitProcess()
		{
			return null;
		}

		// Token: 0x06026AFC RID: 158460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AFC")]
		[Address(RVA = "0x21BEE40", Offset = "0x21BDA40", VA = "0x1821BEE40", Slot = "10")]
		protected virtual IEnumerator EnterYieldInstruction()
		{
			return null;
		}

		// Token: 0x06026AFD RID: 158461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026AFD")]
		[Address(RVA = "0x21BEEF0", Offset = "0x21BDAF0", VA = "0x1821BEEF0", Slot = "11")]
		protected virtual IEnumerator ExitYieldInstruction()
		{
			return null;
		}

		// Token: 0x06026AFE RID: 158462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AFE")]
		[Address(RVA = "0x21BED20", Offset = "0x21BD920", VA = "0x1821BED20", Slot = "12")]
		protected virtual void CancelEnter()
		{
		}

		// Token: 0x06026AFF RID: 158463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AFF")]
		[Address(RVA = "0x21BEDB0", Offset = "0x21BD9B0", VA = "0x1821BEDB0", Slot = "13")]
		protected virtual void CancelExit()
		{
		}

		// Token: 0x06026B00 RID: 158464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B00")]
		[Address(RVA = "0x21BEF80", Offset = "0x21BDB80", VA = "0x1821BEF80")]
		public void Init(StageZoneGroupPanel.InitOptions initOptions)
		{
		}

		// Token: 0x06026B01 RID: 158465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B01")]
		[Address(RVA = "0x21BF010", Offset = "0x21BDC10", VA = "0x1821BF010", Slot = "7")]
		public override void OnValueChanged(ZoneGroupViewProperty property)
		{
		}

		// Token: 0x06026B02 RID: 158466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B02")]
		[Address(RVA = "0x21BF350", Offset = "0x21BDF50", VA = "0x1821BF350")]
		private void _CoroutineWithPage(IEnumerator coroutine)
		{
		}

		// Token: 0x06026B03 RID: 158467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B03")]
		[Address(RVA = "0x21BF570", Offset = "0x21BE170", VA = "0x1821BF570")]
		public StageZoneGroupPanel()
		{
		}

		// Token: 0x040369C3 RID: 223683
		[Token(Token = "0x40369C3")]
		protected const float DEFAULT_ANIM_DUR = 0.8f;

		// Token: 0x040369C4 RID: 223684
		[Token(Token = "0x40369C4")]
		protected const float DEFAULT_FADEOUT_DUR = 0.2f;

		// Token: 0x040369C5 RID: 223685
		[Token(Token = "0x40369C5")]
		[FieldOffset(Offset = "0x20")]
		private Tween m_defaultEnterTween;

		// Token: 0x040369C6 RID: 223686
		[Token(Token = "0x40369C6")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_defaultExitTween;

		// Token: 0x040369C7 RID: 223687
		[Token(Token = "0x40369C7")]
		[FieldOffset(Offset = "0x30")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x040369C8 RID: 223688
		[Token(Token = "0x40369C8")]
		[FieldOffset(Offset = "0x38")]
		private StageZoneGroupPanel.GroupState m_groupState;

		// Token: 0x040369C9 RID: 223689
		[Token(Token = "0x40369C9")]
		[FieldOffset(Offset = "0x40")]
		protected StageZoneGroupPanel.InitOptions initOptions;

		// Token: 0x040369CC RID: 223692
		[Token(Token = "0x40369CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stagePage;

		// Token: 0x040369CD RID: 223693
		[Token(Token = "0x40369CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onZoneSelected;

		// Token: 0x040369CE RID: 223694
		[Token(Token = "0x40369CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_groupState;

		// Token: 0x040369CF RID: 223695
		[Token(Token = "0x40369CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x040369D0 RID: 223696
		[Token(Token = "0x40369D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x040369D1 RID: 223697
		[Token(Token = "0x40369D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isTransiting;

		// Token: 0x040369D2 RID: 223698
		[Token(Token = "0x40369D2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x040369D3 RID: 223699
		[Token(Token = "0x40369D3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_viewModel;

		// Token: 0x040369D4 RID: 223700
		[Token(Token = "0x40369D4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_viewProp;

		// Token: 0x040369D5 RID: 223701
		[Token(Token = "0x40369D5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_viewProp;

		// Token: 0x040369D6 RID: 223702
		[Token(Token = "0x40369D6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040369D7 RID: 223703
		[Token(Token = "0x40369D7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040369D8 RID: 223704
		[Token(Token = "0x40369D8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EnterProcess;

		// Token: 0x040369D9 RID: 223705
		[Token(Token = "0x40369D9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExitProcess;

		// Token: 0x040369DA RID: 223706
		[Token(Token = "0x40369DA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EnterYieldInstruction;

		// Token: 0x040369DB RID: 223707
		[Token(Token = "0x40369DB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ExitYieldInstruction;

		// Token: 0x040369DC RID: 223708
		[Token(Token = "0x40369DC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CancelEnter;

		// Token: 0x040369DD RID: 223709
		[Token(Token = "0x40369DD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CancelExit;

		// Token: 0x040369DE RID: 223710
		[Token(Token = "0x40369DE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040369DF RID: 223711
		[Token(Token = "0x40369DF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040369E0 RID: 223712
		[Token(Token = "0x40369E0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CoroutineWithPage;

		// Token: 0x040369E1 RID: 223713
		[Token(Token = "0x40369E1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200699E RID: 27038
		[Token(Token = "0x200699E")]
		public struct InitOptions
		{
			// Token: 0x040369E2 RID: 223714
			[Token(Token = "0x40369E2")]
			[FieldOffset(Offset = "0x0")]
			public Action<ZoneGroupViewModel, ZoneViewModel> onZoneSelected;

			// Token: 0x040369E3 RID: 223715
			[Token(Token = "0x40369E3")]
			[FieldOffset(Offset = "0x8")]
			public StagePage stagePage;
		}

		// Token: 0x0200699F RID: 27039
		[Token(Token = "0x200699F")]
		protected enum GroupState
		{
			// Token: 0x040369E5 RID: 223717
			[Token(Token = "0x40369E5")]
			NONE,
			// Token: 0x040369E6 RID: 223718
			[Token(Token = "0x40369E6")]
			ENTERING,
			// Token: 0x040369E7 RID: 223719
			[Token(Token = "0x40369E7")]
			ACTIVE,
			// Token: 0x040369E8 RID: 223720
			[Token(Token = "0x40369E8")]
			EXITING,
			// Token: 0x040369E9 RID: 223721
			[Token(Token = "0x40369E9")]
			INACTIVE
		}
	}
}
