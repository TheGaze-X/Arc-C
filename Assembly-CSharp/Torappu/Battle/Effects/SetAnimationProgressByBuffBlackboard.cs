using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003218 RID: 12824
	[Token(Token = "0x2003218")]
	public class SetAnimationProgressByBuffBlackboard : Effect.Behaviour
	{
		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x06014585 RID: 83333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003030")]
		private Animator animator
		{
			[Token(Token = "0x6014585")]
			[Address(RVA = "0xC941C0", Offset = "0xC92DC0", VA = "0x180C941C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x06014586 RID: 83334 RVA: 0x00086970 File Offset: 0x00084B70
		[Token(Token = "0x17003031")]
		private ObjectPtr<Buff> holdBuff
		{
			[Token(Token = "0x6014586")]
			[Address(RVA = "0xC94290", Offset = "0xC92E90", VA = "0x180C94290")]
			get
			{
				return default(ObjectPtr<Buff>);
			}
		}

		// Token: 0x06014587 RID: 83335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014587")]
		[Address(RVA = "0xC93910", Offset = "0xC92510", VA = "0x180C93910", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014588 RID: 83336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014588")]
		[Address(RVA = "0xC93850", Offset = "0xC92450", VA = "0x180C93850", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014589 RID: 83337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014589")]
		[Address(RVA = "0xC93EA0", Offset = "0xC92AA0", VA = "0x180C93EA0")]
		private void _UpdateEffect()
		{
		}

		// Token: 0x0601458A RID: 83338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601458A")]
		[Address(RVA = "0xC93DB0", Offset = "0xC929B0", VA = "0x180C93DB0")]
		private void Update()
		{
		}

		// Token: 0x0601458B RID: 83339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601458B")]
		[Address(RVA = "0xC93CA0", Offset = "0xC928A0", VA = "0x180C93CA0")]
		private void SetProgress(float progress)
		{
		}

		// Token: 0x0601458C RID: 83340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601458C")]
		[Address(RVA = "0xC940E0", Offset = "0xC92CE0", VA = "0x180C940E0")]
		public SetAnimationProgressByBuffBlackboard()
		{
		}

		// Token: 0x0601458D RID: 83341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601458D")]
		[Address(RVA = "0xC82030", Offset = "0xC80C30", VA = "0x180C82030")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601458E RID: 83342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601458E")]
		[Address(RVA = "0xC81FD0", Offset = "0xC80BD0", VA = "0x180C81FD0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04017FDB RID: 98267
		[Token(Token = "0x4017FDB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animState;

		// Token: 0x04017FDC RID: 98268
		[Token(Token = "0x4017FDC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _animLayer;

		// Token: 0x04017FDD RID: 98269
		[Token(Token = "0x4017FDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _blackboardKey;

		// Token: 0x04017FDE RID: 98270
		[Token(Token = "0x4017FDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _lerpFactor;

		// Token: 0x04017FDF RID: 98271
		[Token(Token = "0x4017FDF")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x04017FE0 RID: 98272
		[Token(Token = "0x4017FE0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04017FE1 RID: 98273
		[Token(Token = "0x4017FE1")]
		[FieldOffset(Offset = "0x48")]
		private Animator m_animator;

		// Token: 0x04017FE2 RID: 98274
		[Token(Token = "0x4017FE2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x04017FE3 RID: 98275
		[Token(Token = "0x4017FE3")]
		[FieldOffset(Offset = "0x54")]
		private float m_updateInterval;

		// Token: 0x04017FE4 RID: 98276
		[Token(Token = "0x4017FE4")]
		[FieldOffset(Offset = "0x58")]
		private float m_lastValue;

		// Token: 0x04017FE5 RID: 98277
		[Token(Token = "0x4017FE5")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPtr<Buff> m_holdBuff;

		// Token: 0x04017FE6 RID: 98278
		[Token(Token = "0x4017FE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x04017FE7 RID: 98279
		[Token(Token = "0x4017FE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_holdBuff;

		// Token: 0x04017FE8 RID: 98280
		[Token(Token = "0x4017FE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04017FE9 RID: 98281
		[Token(Token = "0x4017FE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04017FEA RID: 98282
		[Token(Token = "0x4017FEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateEffect;

		// Token: 0x04017FEB RID: 98283
		[Token(Token = "0x4017FEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04017FEC RID: 98284
		[Token(Token = "0x4017FEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetProgress;

		// Token: 0x04017FED RID: 98285
		[Token(Token = "0x4017FED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
