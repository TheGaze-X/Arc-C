using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002119 RID: 8473
	[Token(Token = "0x2002119")]
	[Serializable]
	public class FaceSwitcher : MonoBehaviour
	{
		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x0600CFC7 RID: 53191 RVA: 0x0004B048 File Offset: 0x00049248
		[Token(Token = "0x170018BF")]
		public int faceSign
		{
			[Token(Token = "0x600CFC7")]
			[Address(RVA = "0x350FBF0", Offset = "0x350E7F0", VA = "0x18350FBF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x0600CFC8 RID: 53192 RVA: 0x0004B060 File Offset: 0x00049260
		[Token(Token = "0x170018C0")]
		public SharedConsts.Direction currentLOrR
		{
			[Token(Token = "0x600CFC8")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x0600CFC9 RID: 53193 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CFCA RID: 53194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018C1")]
		private UnitAnimator animator
		{
			[Token(Token = "0x600CFC9")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600CFCA")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600CFCB RID: 53195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFCB")]
		[Address(RVA = "0x350F200", Offset = "0x350DE00", VA = "0x18350F200")]
		public void Reset()
		{
		}

		// Token: 0x0600CFCC RID: 53196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFCC")]
		[Address(RVA = "0x350F2C0", Offset = "0x350DEC0", VA = "0x18350F2C0")]
		public void StartSwitch(SharedConsts.Direction lOrR, SharedConsts.Direction fourDir, bool immediately, bool idle, Action<SharedConsts.Direction, SharedConsts.Direction> onSwitchFace)
		{
		}

		// Token: 0x0600CFCD RID: 53197 RVA: 0x0004B078 File Offset: 0x00049278
		[Token(Token = "0x600CFCD")]
		[Address(RVA = "0x350FAF0", Offset = "0x350E6F0", VA = "0x18350FAF0")]
		private bool _TryUpdateDirection(SharedConsts.Direction lOrR, SharedConsts.Direction fourDir, bool idle, out bool clockwise)
		{
			return default(bool);
		}

		// Token: 0x0600CFCE RID: 53198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFCE")]
		[Address(RVA = "0x350F3F0", Offset = "0x350DFF0", VA = "0x18350F3F0")]
		private void _DoSwitchFaceInternal(bool clockwise, Action<SharedConsts.Direction, SharedConsts.Direction> onSwitchFace)
		{
		}

		// Token: 0x0600CFCF RID: 53199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFCF")]
		[Address(RVA = "0x350F9F0", Offset = "0x350E5F0", VA = "0x18350F9F0")]
		private void _KillLastTween()
		{
		}

		// Token: 0x0600CFD0 RID: 53200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFD0")]
		[Address(RVA = "0x350FBD0", Offset = "0x350E7D0", VA = "0x18350FBD0")]
		public FaceSwitcher()
		{
		}

		// Token: 0x0400DDEC RID: 56812
		[Token(Token = "0x400DDEC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _switchTime;

		// Token: 0x0400DDED RID: 56813
		[Token(Token = "0x400DDED")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SharedConsts.Direction _defaultLOrR;

		// Token: 0x0400DDEE RID: 56814
		[Token(Token = "0x400DDEE")]
		[FieldOffset(Offset = "0x20")]
		private SharedConsts.Direction m_currentUOrD;

		// Token: 0x0400DDEF RID: 56815
		[Token(Token = "0x400DDEF")]
		[FieldOffset(Offset = "0x24")]
		private SharedConsts.Direction m_currentLOrR;

		// Token: 0x0400DDF0 RID: 56816
		[Token(Token = "0x400DDF0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_firstTouch;

		// Token: 0x0400DDF1 RID: 56817
		[Token(Token = "0x400DDF1")]
		[FieldOffset(Offset = "0x30")]
		private ITweenHandler m_lastTween;

		// Token: 0x0200211A RID: 8474
		[Token(Token = "0x200211A")]
		private class HardCoded_InternalSwitchAnimation_BattleTweenVersion : ITweenHandler
		{
			// Token: 0x0600CFD1 RID: 53201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CFD1")]
			[Address(RVA = "0x3511DE0", Offset = "0x35109E0", VA = "0x183511DE0")]
			public HardCoded_InternalSwitchAnimation_BattleTweenVersion(Transform transform, FP switchTime, Vector3 phase0Angles, Vector3 phase1Angles, Vector3 endAngles, Action onPhaseSwitch, Action onComplete)
			{
			}

			// Token: 0x0600CFD2 RID: 53202 RVA: 0x0004B090 File Offset: 0x00049290
			[Token(Token = "0x600CFD2")]
			[Address(RVA = "0x35116F0", Offset = "0x35102F0", VA = "0x1835116F0", Slot = "4")]
			public bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x0600CFD3 RID: 53203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CFD3")]
			[Address(RVA = "0x35117A0", Offset = "0x35103A0", VA = "0x1835117A0")]
			public FaceSwitcher.HardCoded_InternalSwitchAnimation_BattleTweenVersion Play()
			{
				return null;
			}

			// Token: 0x0600CFD4 RID: 53204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CFD4")]
			[Address(RVA = "0x3511700", Offset = "0x3510300", VA = "0x183511700", Slot = "5")]
			public void Kill(bool complete)
			{
			}

			// Token: 0x0600CFD5 RID: 53205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CFD5")]
			[Address(RVA = "0x3511D90", Offset = "0x3510990", VA = "0x183511D90")]
			private void _OnComplete()
			{
			}

			// Token: 0x0600CFD6 RID: 53206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CFD6")]
			[Address(RVA = "0x3511C00", Offset = "0x3510800", VA = "0x183511C00")]
			private void _ConstructTweenChain()
			{
			}

			// Token: 0x0400DDF3 RID: 56819
			[Token(Token = "0x400DDF3")]
			[FieldOffset(Offset = "0x10")]
			private FaceSwitcher.HardCoded_InternalSwitchAnimation_BattleTweenVersion.State m_state;

			// Token: 0x0400DDF4 RID: 56820
			[Token(Token = "0x400DDF4")]
			[FieldOffset(Offset = "0x18")]
			private Transform m_transform;

			// Token: 0x0400DDF5 RID: 56821
			[Token(Token = "0x400DDF5")]
			[FieldOffset(Offset = "0x20")]
			private FP m_switchTime;

			// Token: 0x0400DDF6 RID: 56822
			[Token(Token = "0x400DDF6")]
			[FieldOffset(Offset = "0x28")]
			private Quaternion m_startQuaternion;

			// Token: 0x0400DDF7 RID: 56823
			[Token(Token = "0x400DDF7")]
			[FieldOffset(Offset = "0x38")]
			private Quaternion m_phase0Quaternion;

			// Token: 0x0400DDF8 RID: 56824
			[Token(Token = "0x400DDF8")]
			[FieldOffset(Offset = "0x48")]
			private Quaternion m_phase1Quaternion;

			// Token: 0x0400DDF9 RID: 56825
			[Token(Token = "0x400DDF9")]
			[FieldOffset(Offset = "0x58")]
			private Quaternion m_endQuaternion;

			// Token: 0x0400DDFA RID: 56826
			[Token(Token = "0x400DDFA")]
			[FieldOffset(Offset = "0x68")]
			private Action m_onPhaseSwitch;

			// Token: 0x0400DDFB RID: 56827
			[Token(Token = "0x400DDFB")]
			[FieldOffset(Offset = "0x70")]
			private Action m_onComplete;

			// Token: 0x0400DDFC RID: 56828
			[Token(Token = "0x400DDFC")]
			[FieldOffset(Offset = "0x78")]
			private BattleTweenMgr.Tween m_curTween;

			// Token: 0x0200211B RID: 8475
			[Token(Token = "0x200211B")]
			private enum State : byte
			{
				// Token: 0x0400DDFE RID: 56830
				[Token(Token = "0x400DDFE")]
				INITED,
				// Token: 0x0400DDFF RID: 56831
				[Token(Token = "0x400DDFF")]
				PLAYING,
				// Token: 0x0400DE00 RID: 56832
				[Token(Token = "0x400DE00")]
				STOPPED
			}
		}
	}
}
