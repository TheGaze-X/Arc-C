using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002115 RID: 8469
	[Token(Token = "0x2002115")]
	public class UpdateMeshOffset : UnitAnimator.Behaviour
	{
		// Token: 0x0600CF62 RID: 53090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF62")]
		[Address(RVA = "0x3523B40", Offset = "0x3522740", VA = "0x183523B40", Slot = "4")]
		public override void Init(UnitAnimator unitAnimator)
		{
		}

		// Token: 0x0600CF63 RID: 53091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF63")]
		[Address(RVA = "0x3523EE0", Offset = "0x3522AE0", VA = "0x183523EE0", Slot = "6")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF64")]
		[Address(RVA = "0x3524300", Offset = "0x3522F00", VA = "0x183524300")]
		public UpdateMeshOffset()
		{
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF65")]
		[Address(RVA = "0x3509390", Offset = "0x3507F90", VA = "0x183509390")]
		private void <>xLuaBaseProxy_Init(UnitAnimator P0)
		{
		}

		// Token: 0x0600CF66 RID: 53094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF66")]
		[Address(RVA = "0x3522640", Offset = "0x3521240", VA = "0x183522640")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400DD74 RID: 56692
		[Token(Token = "0x400DD74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _meshList;

		// Token: 0x0400DD75 RID: 56693
		[Token(Token = "0x400DD75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Vector3> _maxOffset;

		// Token: 0x0400DD76 RID: 56694
		[Token(Token = "0x400DD76")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxOpenSpeed;

		// Token: 0x0400DD77 RID: 56695
		[Token(Token = "0x400DD77")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxCloseSpeed;

		// Token: 0x0400DD78 RID: 56696
		[Token(Token = "0x400DD78")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _onlyTickWhenAlive;

		// Token: 0x0400DD79 RID: 56697
		[Token(Token = "0x400DD79")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _offsetCurve;

		// Token: 0x0400DD7A RID: 56698
		[Token(Token = "0x400DD7A")]
		[FieldOffset(Offset = "0x48")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private float _axisValue;

		// Token: 0x0400DD7B RID: 56699
		[Token(Token = "0x400DD7B")]
		[FieldOffset(Offset = "0x4C")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private float _lastValue;

		// Token: 0x0400DD7C RID: 56700
		[Token(Token = "0x400DD7C")]
		[FieldOffset(Offset = "0x50")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private readonly Dictionary<GameObject, Vector3> _originalLocalPosition;

		// Token: 0x0400DD7D RID: 56701
		[Token(Token = "0x400DD7D")]
		[FieldOffset(Offset = "0x58")]
		private float m_maxOpenSpeed;

		// Token: 0x0400DD7E RID: 56702
		[Token(Token = "0x400DD7E")]
		[FieldOffset(Offset = "0x5C")]
		private float m_maxCloseSpeed;

		// Token: 0x0400DD7F RID: 56703
		[Token(Token = "0x400DD7F")]
		[FieldOffset(Offset = "0x60")]
		private MeshAnimator m_meshAnimator;

		// Token: 0x0400DD80 RID: 56704
		[Token(Token = "0x400DD80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DD81 RID: 56705
		[Token(Token = "0x400DD81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400DD82 RID: 56706
		[Token(Token = "0x400DD82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
