using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005745 RID: 22341
	[Token(Token = "0x2005745")]
	public class RL02ReportController : RoguelikeReportController<RL02EndingFrameViewModel>
	{
		// Token: 0x06020BC5 RID: 134085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC5")]
		[Address(RVA = "0x1B09370", Offset = "0x1B07F70", VA = "0x181B09370", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06020BC6 RID: 134086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC6")]
		[Address(RVA = "0x1B09960", Offset = "0x1B08560", VA = "0x181B09960")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020BC7 RID: 134087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC7")]
		[Address(RVA = "0x1B095A0", Offset = "0x1B081A0", VA = "0x181B095A0")]
		private void _BindAction(RL02CommonReportViewBase reportView)
		{
		}

		// Token: 0x06020BC8 RID: 134088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC8")]
		[Address(RVA = "0x1B09C70", Offset = "0x1B08870", VA = "0x181B09C70")]
		private void _TurnToPrevView()
		{
		}

		// Token: 0x06020BC9 RID: 134089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC9")]
		[Address(RVA = "0x1B09B80", Offset = "0x1B08780", VA = "0x181B09B80")]
		private void _TurnToNextView()
		{
		}

		// Token: 0x06020BCA RID: 134090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BCA")]
		[Address(RVA = "0x1B09AA0", Offset = "0x1B086A0", VA = "0x181B09AA0")]
		private void _SkipToFinView()
		{
		}

		// Token: 0x06020BCB RID: 134091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BCB")]
		[Address(RVA = "0x1B098C0", Offset = "0x1B084C0", VA = "0x181B098C0")]
		private void _CloseReport()
		{
		}

		// Token: 0x06020BCC RID: 134092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BCC")]
		[Address(RVA = "0x1B09A30", Offset = "0x1B08630", VA = "0x181B09A30")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x06020BCD RID: 134093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BCD")]
		[Address(RVA = "0x1B0A010", Offset = "0x1B08C10", VA = "0x181B0A010")]
		public RL02ReportController()
		{
		}

		// Token: 0x0402C709 RID: 182025
		[Token(Token = "0x402C709")]
		[FieldOffset(Offset = "0x0")]
		private static List<RL02ReportController.ReportViewType> VIEW_ORDER;

		// Token: 0x0402C70A RID: 182026
		[Token(Token = "0x402C70A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL02CommonReportViewBase[] _reportViews;

		// Token: 0x0402C70B RID: 182027
		[Token(Token = "0x402C70B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0402C70C RID: 182028
		[Token(Token = "0x402C70C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402C70D RID: 182029
		[Token(Token = "0x402C70D")]
		[FieldOffset(Offset = "0x41")]
		private bool m_isTransiting;

		// Token: 0x0402C70E RID: 182030
		[Token(Token = "0x402C70E")]
		[FieldOffset(Offset = "0x48")]
		private RL02ReportController.ReportViewController m_viewController;

		// Token: 0x0402C70F RID: 182031
		[Token(Token = "0x402C70F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402C710 RID: 182032
		[Token(Token = "0x402C710")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C711 RID: 182033
		[Token(Token = "0x402C711")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__BindAction;

		// Token: 0x0402C712 RID: 182034
		[Token(Token = "0x402C712")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TurnToPrevView;

		// Token: 0x0402C713 RID: 182035
		[Token(Token = "0x402C713")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TurnToNextView;

		// Token: 0x0402C714 RID: 182036
		[Token(Token = "0x402C714")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SkipToFinView;

		// Token: 0x0402C715 RID: 182037
		[Token(Token = "0x402C715")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CloseReport;

		// Token: 0x0402C716 RID: 182038
		[Token(Token = "0x402C716")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x0402C717 RID: 182039
		[Token(Token = "0x402C717")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005746 RID: 22342
		[Token(Token = "0x2005746")]
		public enum ReportViewType
		{
			// Token: 0x0402C719 RID: 182041
			[Token(Token = "0x402C719")]
			NONE,
			// Token: 0x0402C71A RID: 182042
			[Token(Token = "0x402C71A")]
			TYPE_ENTER,
			// Token: 0x0402C71B RID: 182043
			[Token(Token = "0x402C71B")]
			TYPE_ZONE,
			// Token: 0x0402C71C RID: 182044
			[Token(Token = "0x402C71C")]
			TYPE_BUFF,
			// Token: 0x0402C71D RID: 182045
			[Token(Token = "0x402C71D")]
			TYPE_DICE,
			// Token: 0x0402C71E RID: 182046
			[Token(Token = "0x402C71E")]
			TYPE_NEWS,
			// Token: 0x0402C71F RID: 182047
			[Token(Token = "0x402C71F")]
			TYPE_FIN
		}

		// Token: 0x02005747 RID: 22343
		[Token(Token = "0x2005747")]
		public class ReportViewController : IHotfixable
		{
			// Token: 0x06020BCF RID: 134095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020BCF")]
			[Address(RVA = "0x1B16F50", Offset = "0x1B15B50", VA = "0x181B16F50")]
			public ReportViewController(RL02ReportController closure)
			{
			}

			// Token: 0x06020BD0 RID: 134096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020BD0")]
			[Address(RVA = "0x1B169C0", Offset = "0x1B155C0", VA = "0x181B169C0")]
			public void Init()
			{
			}

			// Token: 0x06020BD1 RID: 134097 RVA: 0x000B7018 File Offset: 0x000B5218
			[Token(Token = "0x6020BD1")]
			[Address(RVA = "0x1B168F0", Offset = "0x1B154F0", VA = "0x181B168F0")]
			public RL02ReportController.ReportViewType GetCurrentViewType()
			{
				return RL02ReportController.ReportViewType.NONE;
			}

			// Token: 0x06020BD2 RID: 134098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020BD2")]
			[Address(RVA = "0x1B16D00", Offset = "0x1B15900", VA = "0x181B16D00")]
			public void SwitchView(RL02ReportController.ReportViewType targetViewType, bool isForward)
			{
			}

			// Token: 0x06020BD3 RID: 134099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020BD3")]
			[Address(RVA = "0x1B16E70", Offset = "0x1B15A70", VA = "0x181B16E70")]
			private IEnumerator _SwitchViewCoroutine(RL02ReportController.ReportViewType targetViewType, bool isForward)
			{
				return null;
			}

			// Token: 0x0402C720 RID: 182048
			[Token(Token = "0x402C720")]
			[FieldOffset(Offset = "0x10")]
			private RL02ReportController m_closure;

			// Token: 0x0402C721 RID: 182049
			[Token(Token = "0x402C721")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<RL02ReportController.ReportViewType, RL02CommonReportViewBase> m_prefabMap;

			// Token: 0x0402C722 RID: 182050
			[Token(Token = "0x402C722")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<RL02ReportController.ReportViewType, RL02CommonReportViewBase> m_instMap;

			// Token: 0x0402C723 RID: 182051
			[Token(Token = "0x402C723")]
			[FieldOffset(Offset = "0x28")]
			private RL02CommonReportViewBase m_currentView;

			// Token: 0x0402C724 RID: 182052
			[Token(Token = "0x402C724")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C725 RID: 182053
			[Token(Token = "0x402C725")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0402C726 RID: 182054
			[Token(Token = "0x402C726")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetCurrentViewType;

			// Token: 0x0402C727 RID: 182055
			[Token(Token = "0x402C727")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SwitchView;

			// Token: 0x0402C728 RID: 182056
			[Token(Token = "0x402C728")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__SwitchViewCoroutine;
		}
	}
}
