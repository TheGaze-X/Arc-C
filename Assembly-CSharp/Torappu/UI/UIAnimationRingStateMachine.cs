using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036CE RID: 14030
	[Token(Token = "0x20036CE")]
	public class UIAnimationRingStateMachine : IRingStateMachine, IHotfixable
	{
		// Token: 0x060164B9 RID: 91321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164B9")]
		[Address(RVA = "0xEB9920", Offset = "0xEB8520", VA = "0x180EB9920")]
		public UIAnimationRingStateMachine(UIAnimationRingClip closure)
		{
		}

		// Token: 0x060164BA RID: 91322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164BA")]
		[Address(RVA = "0xEB81A0", Offset = "0xEB6DA0", VA = "0x180EB81A0")]
		public static UIRingStateGraph CalcStateGraph(AnimationClip clip)
		{
			return null;
		}

		// Token: 0x060164BB RID: 91323 RVA: 0x000906C0 File Offset: 0x0008E8C0
		[Token(Token = "0x60164BB")]
		[Address(RVA = "0xEB8400", Offset = "0xEB7000", VA = "0x180EB8400", Slot = "4")]
		public bool ResetToState(string stateId)
		{
			return default(bool);
		}

		// Token: 0x060164BC RID: 91324 RVA: 0x000906D8 File Offset: 0x0008E8D8
		[Token(Token = "0x60164BC")]
		[Address(RVA = "0xEB8880", Offset = "0xEB7480", VA = "0x180EB8880", Slot = "5")]
		public bool TransToState(string fromStateId, string toStateId)
		{
			return default(bool);
		}

		// Token: 0x060164BD RID: 91325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164BD")]
		[Address(RVA = "0xEB8760", Offset = "0xEB7360", VA = "0x180EB8760", Slot = "6")]
		public void Stop()
		{
		}

		// Token: 0x060164BE RID: 91326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164BE")]
		[Address(RVA = "0xEB85A0", Offset = "0xEB71A0", VA = "0x180EB85A0")]
		public void SetAsset(AnimationClip clip, GameObject target)
		{
		}

		// Token: 0x060164BF RID: 91327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164BF")]
		[Address(RVA = "0xEB7F90", Offset = "0xEB6B90", VA = "0x180EB7F90")]
		public void AddTask(string stateId, UIRingStateGraph.UIRingClipTask task)
		{
		}

		// Token: 0x060164C0 RID: 91328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164C0")]
		[Address(RVA = "0xEB8F80", Offset = "0xEB7B80", VA = "0x180EB8F80")]
		private Tween _PlaySegment(float fromTime, float toTime)
		{
			return null;
		}

		// Token: 0x060164C1 RID: 91329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164C1")]
		[Address(RVA = "0xEB95D0", Offset = "0xEB81D0", VA = "0x180EB95D0")]
		private void _SetTransTween(UIAnimationRingStateMachine.PendingSegment segment)
		{
		}

		// Token: 0x060164C2 RID: 91330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164C2")]
		[Address(RVA = "0xEB8BD0", Offset = "0xEB77D0", VA = "0x180EB8BD0")]
		private Tween _BuildSegmentTween(UIAnimationRingStateMachine.PendingSegment segment)
		{
			return null;
		}

		// Token: 0x060164C3 RID: 91331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164C3")]
		[Address(RVA = "0xEB8D50", Offset = "0xEB7950", VA = "0x180EB8D50")]
		private void _CheckAndPlayNextTween()
		{
		}

		// Token: 0x060164C4 RID: 91332 RVA: 0x000906F0 File Offset: 0x0008E8F0
		[Token(Token = "0x60164C4")]
		[Address(RVA = "0xEB8E10", Offset = "0xEB7A10", VA = "0x180EB8E10")]
		private bool _CheckIfAssetReady()
		{
			return default(bool);
		}

		// Token: 0x060164C5 RID: 91333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164C5")]
		[Address(RVA = "0xEB8EE0", Offset = "0xEB7AE0", VA = "0x180EB8EE0")]
		private void _Clear()
		{
		}

		// Token: 0x060164C6 RID: 91334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164C6")]
		[Address(RVA = "0xEB9320", Offset = "0xEB7F20", VA = "0x180EB9320")]
		private void _ProcessTask(UIRingStateGraph.UIRingClipTask task, [Optional] Action nextStep)
		{
		}

		// Token: 0x060164C7 RID: 91335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164C7")]
		[Address(RVA = "0xEB9220", Offset = "0xEB7E20", VA = "0x180EB9220")]
		private IEnumerator _ProcessTaskCoroutine(IEnumerator taskCoroutine, Action nextStep, bool block)
		{
			return null;
		}

		// Token: 0x0401AD02 RID: 109826
		[Token(Token = "0x401AD02")]
		private const string MARKER_ANIM_NAME = "_AnimMarkerEvent";

		// Token: 0x0401AD03 RID: 109827
		[Token(Token = "0x401AD03")]
		private const float INVALID_ANIM_LENGTH = -1f;

		// Token: 0x0401AD04 RID: 109828
		[Token(Token = "0x401AD04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UIAnimationRingClip m_closure;

		// Token: 0x0401AD05 RID: 109829
		[Token(Token = "0x401AD05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UIRingStateGraph m_stateGraph;

		// Token: 0x0401AD06 RID: 109830
		[Token(Token = "0x401AD06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimationClip m_clip;

		// Token: 0x0401AD07 RID: 109831
		[Token(Token = "0x401AD07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_animTarget;

		// Token: 0x0401AD08 RID: 109832
		[Token(Token = "0x401AD08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_animLength;

		// Token: 0x0401AD09 RID: 109833
		[Token(Token = "0x401AD09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Tween m_transTween;

		// Token: 0x0401AD0A RID: 109834
		[Token(Token = "0x401AD0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine m_coroutine;

		// Token: 0x0401AD0B RID: 109835
		[Token(Token = "0x401AD0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Queue<UIAnimationRingStateMachine.PendingSegment> m_queue;

		// Token: 0x0401AD0C RID: 109836
		[Token(Token = "0x401AD0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401AD0D RID: 109837
		[Token(Token = "0x401AD0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalcStateGraph;

		// Token: 0x0401AD0E RID: 109838
		[Token(Token = "0x401AD0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401AD0F RID: 109839
		[Token(Token = "0x401AD0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TransToState;

		// Token: 0x0401AD10 RID: 109840
		[Token(Token = "0x401AD10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0401AD11 RID: 109841
		[Token(Token = "0x401AD11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetAsset;

		// Token: 0x0401AD12 RID: 109842
		[Token(Token = "0x401AD12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddTask;

		// Token: 0x0401AD13 RID: 109843
		[Token(Token = "0x401AD13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlaySegment;

		// Token: 0x0401AD14 RID: 109844
		[Token(Token = "0x401AD14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetTransTween;

		// Token: 0x0401AD15 RID: 109845
		[Token(Token = "0x401AD15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BuildSegmentTween;

		// Token: 0x0401AD16 RID: 109846
		[Token(Token = "0x401AD16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckAndPlayNextTween;

		// Token: 0x0401AD17 RID: 109847
		[Token(Token = "0x401AD17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckIfAssetReady;

		// Token: 0x0401AD18 RID: 109848
		[Token(Token = "0x401AD18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Clear;

		// Token: 0x0401AD19 RID: 109849
		[Token(Token = "0x401AD19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ProcessTask;

		// Token: 0x0401AD1A RID: 109850
		[Token(Token = "0x401AD1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ProcessTaskCoroutine;

		// Token: 0x020036CF RID: 14031
		[Token(Token = "0x20036CF")]
		private class PendingSegment
		{
			// Token: 0x060164C8 RID: 91336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60164C8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PendingSegment()
			{
			}

			// Token: 0x0401AD1B RID: 109851
			[Token(Token = "0x401AD1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float startTime;

			// Token: 0x0401AD1C RID: 109852
			[Token(Token = "0x401AD1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float endTime;

			// Token: 0x0401AD1D RID: 109853
			[Token(Token = "0x401AD1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool useForward;

			// Token: 0x0401AD1E RID: 109854
			[Token(Token = "0x401AD1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIRingStateGraph.UIRingClipTask endTask;
		}
	}
}
