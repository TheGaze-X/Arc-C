using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036D3 RID: 14035
	[Token(Token = "0x20036D3")]
	public class UIAnimationRingClip : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x060164D4 RID: 91348 RVA: 0x00090738 File Offset: 0x0008E938
		[Token(Token = "0x1700359E")]
		public bool enableReverse
		{
			[Token(Token = "0x60164D4")]
			[Address(RVA = "0xEB7F30", Offset = "0xEB6B30", VA = "0x180EB7F30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x060164D5 RID: 91349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700359F")]
		public UIAnimationRingStateMachine animStateMachine
		{
			[Token(Token = "0x60164D5")]
			[Address(RVA = "0xEB7D80", Offset = "0xEB6980", VA = "0x180EB7D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060164D6 RID: 91350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164D6")]
		[Address(RVA = "0xEB7AF0", Offset = "0xEB66F0", VA = "0x180EB7AF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060164D7 RID: 91351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164D7")]
		[Address(RVA = "0xEB7580", Offset = "0xEB6180", VA = "0x180EB7580")]
		public void AddTask(string stateId, UIRingStateGraph.UIRingClipTask task)
		{
		}

		// Token: 0x060164D8 RID: 91352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164D8")]
		[Address(RVA = "0xEB7640", Offset = "0xEB6240", VA = "0x180EB7640")]
		public void ResetToState(string stateId)
		{
		}

		// Token: 0x060164D9 RID: 91353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164D9")]
		[Address(RVA = "0xEB7920", Offset = "0xEB6520", VA = "0x180EB7920")]
		public void TransToState(string stateId)
		{
		}

		// Token: 0x060164DA RID: 91354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164DA")]
		[Address(RVA = "0xEB78A0", Offset = "0xEB64A0", VA = "0x180EB78A0")]
		public void Stop()
		{
		}

		// Token: 0x060164DB RID: 91355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164DB")]
		[Address(RVA = "0xEB7A90", Offset = "0xEB6690", VA = "0x180EB7A90")]
		private void _AnimMarkerEvent(string stateId)
		{
		}

		// Token: 0x060164DC RID: 91356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164DC")]
		[Address(RVA = "0xEB7D20", Offset = "0xEB6920", VA = "0x180EB7D20")]
		public UIAnimationRingClip()
		{
		}

		// Token: 0x0401AD29 RID: 109865
		[Token(Token = "0x401AD29")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationClip _animClip;

		// Token: 0x0401AD2A RID: 109866
		[Token(Token = "0x401AD2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _animTarget;

		// Token: 0x0401AD2B RID: 109867
		[Token(Token = "0x401AD2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _enableReverse;

		// Token: 0x0401AD2C RID: 109868
		[Token(Token = "0x401AD2C")]
		[FieldOffset(Offset = "0x30")]
		private UIAnimationRingStateMachine m_animStateMachine;

		// Token: 0x0401AD2D RID: 109869
		[Token(Token = "0x401AD2D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0401AD2E RID: 109870
		[Token(Token = "0x401AD2E")]
		[FieldOffset(Offset = "0x40")]
		private string m_currStateId;

		// Token: 0x0401AD2F RID: 109871
		[Token(Token = "0x401AD2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enableReverse;

		// Token: 0x0401AD30 RID: 109872
		[Token(Token = "0x401AD30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_animStateMachine;

		// Token: 0x0401AD31 RID: 109873
		[Token(Token = "0x401AD31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401AD32 RID: 109874
		[Token(Token = "0x401AD32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddTask;

		// Token: 0x0401AD33 RID: 109875
		[Token(Token = "0x401AD33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401AD34 RID: 109876
		[Token(Token = "0x401AD34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TransToState;

		// Token: 0x0401AD35 RID: 109877
		[Token(Token = "0x401AD35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0401AD36 RID: 109878
		[Token(Token = "0x401AD36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AnimMarkerEvent;

		// Token: 0x0401AD37 RID: 109879
		[Token(Token = "0x401AD37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
