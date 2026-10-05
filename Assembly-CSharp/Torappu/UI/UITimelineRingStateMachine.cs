using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036D5 RID: 14037
	[Token(Token = "0x20036D5")]
	public class UITimelineRingStateMachine : IRingStateMachine, IHotfixable
	{
		// Token: 0x060164DE RID: 91358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164DE")]
		[Address(RVA = "0xEBFD80", Offset = "0xEBE980", VA = "0x180EBFD80")]
		public UITimelineRingStateMachine(PlayableDirector director)
		{
		}

		// Token: 0x060164DF RID: 91359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164DF")]
		[Address(RVA = "0xEBED60", Offset = "0xEBD960", VA = "0x180EBED60")]
		public static UIRingStateGraph CalcStateGraph(TimelineAsset asset)
		{
			return null;
		}

		// Token: 0x060164E0 RID: 91360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164E0")]
		[Address(RVA = "0xEBF5A0", Offset = "0xEBE1A0", VA = "0x180EBF5A0")]
		public void SetAsset(TimelineAsset timeline)
		{
		}

		// Token: 0x060164E1 RID: 91361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164E1")]
		[Address(RVA = "0xEBF320", Offset = "0xEBDF20", VA = "0x180EBF320")]
		public void Clear(bool bClearBindTargets)
		{
		}

		// Token: 0x060164E2 RID: 91362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164E2")]
		[Address(RVA = "0xEBF640", Offset = "0xEBE240", VA = "0x180EBF640")]
		public void SetBinding(string bindingName, UnityEngine.Object target)
		{
		}

		// Token: 0x060164E3 RID: 91363 RVA: 0x00090750 File Offset: 0x0008E950
		[Token(Token = "0x60164E3")]
		[Address(RVA = "0xEBF3C0", Offset = "0xEBDFC0", VA = "0x180EBF3C0", Slot = "4")]
		public bool ResetToState(string stateId)
		{
			return default(bool);
		}

		// Token: 0x060164E4 RID: 91364 RVA: 0x00090768 File Offset: 0x0008E968
		[Token(Token = "0x60164E4")]
		[Address(RVA = "0xEBF770", Offset = "0xEBE370", VA = "0x180EBF770", Slot = "5")]
		public bool TransToState(string fromStateId, string toStateId)
		{
			return default(bool);
		}

		// Token: 0x060164E5 RID: 91365 RVA: 0x00090780 File Offset: 0x0008E980
		[Token(Token = "0x60164E5")]
		[Address(RVA = "0xEBFAA0", Offset = "0xEBE6A0", VA = "0x180EBFAA0")]
		private bool _CheckIfAssetReady()
		{
			return default(bool);
		}

		// Token: 0x060164E6 RID: 91366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164E6")]
		[Address(RVA = "0xEBFB80", Offset = "0xEBE780", VA = "0x180EBFB80")]
		private Tween _PlaySegment(double fromTime, double toTime)
		{
			return null;
		}

		// Token: 0x060164E7 RID: 91367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164E7")]
		[Address(RVA = "0xEBF6E0", Offset = "0xEBE2E0", VA = "0x180EBF6E0", Slot = "6")]
		public void Stop()
		{
		}

		// Token: 0x0401AD39 RID: 109881
		[Token(Token = "0x401AD39")]
		[FieldOffset(Offset = "0x10")]
		private PlayableDirector m_director;

		// Token: 0x0401AD3A RID: 109882
		[Token(Token = "0x401AD3A")]
		[FieldOffset(Offset = "0x18")]
		private TimelineBindingHandler m_bindings;

		// Token: 0x0401AD3B RID: 109883
		[Token(Token = "0x401AD3B")]
		[FieldOffset(Offset = "0x20")]
		private UIRingStateGraph m_stateGraph;

		// Token: 0x0401AD3C RID: 109884
		[Token(Token = "0x401AD3C")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_transTween;

		// Token: 0x0401AD3D RID: 109885
		[Token(Token = "0x401AD3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401AD3E RID: 109886
		[Token(Token = "0x401AD3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalcStateGraph;

		// Token: 0x0401AD3F RID: 109887
		[Token(Token = "0x401AD3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetAsset;

		// Token: 0x0401AD40 RID: 109888
		[Token(Token = "0x401AD40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0401AD41 RID: 109889
		[Token(Token = "0x401AD41")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetBinding;

		// Token: 0x0401AD42 RID: 109890
		[Token(Token = "0x401AD42")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401AD43 RID: 109891
		[Token(Token = "0x401AD43")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TransToState;

		// Token: 0x0401AD44 RID: 109892
		[Token(Token = "0x401AD44")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfAssetReady;

		// Token: 0x0401AD45 RID: 109893
		[Token(Token = "0x401AD45")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlaySegment;

		// Token: 0x0401AD46 RID: 109894
		[Token(Token = "0x401AD46")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Stop;
	}
}
