using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002591 RID: 9617
	[Token(Token = "0x2002591")]
	public class TargetValidator : MonoBehaviour, IHotfixable
	{
		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600F7EB RID: 63467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002084")]
		protected Entity owner
		{
			[Token(Token = "0x600F7EB")]
			[Address(RVA = "0x716290", Offset = "0x714E90", VA = "0x180716290")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F7EC RID: 63468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7EC")]
		[Address(RVA = "0x715FC0", Offset = "0x714BC0", VA = "0x180715FC0", Slot = "4")]
		public virtual void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F7ED RID: 63469 RVA: 0x0005CD30 File Offset: 0x0005AF30
		[Token(Token = "0x600F7ED")]
		[Address(RVA = "0x7160B0", Offset = "0x714CB0", VA = "0x1807160B0", Slot = "5")]
		public virtual bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7EE RID: 63470 RVA: 0x0005CD48 File Offset: 0x0005AF48
		[Token(Token = "0x600F7EE")]
		[Address(RVA = "0x715F00", Offset = "0x714B00", VA = "0x180715F00")]
		public int GetLayerMask()
		{
			return 0;
		}

		// Token: 0x0600F7EF RID: 63471 RVA: 0x0005CD60 File Offset: 0x0005AF60
		[Token(Token = "0x600F7EF")]
		[Address(RVA = "0x716140", Offset = "0x714D40", VA = "0x180716140")]
		public bool VerifyOnlyMotionAndCategory(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7F0 RID: 63472 RVA: 0x0005CD78 File Offset: 0x0005AF78
		[Token(Token = "0x600F7F0")]
		[Address(RVA = "0x7161C0", Offset = "0x714DC0", VA = "0x1807161C0")]
		public bool VerifyTargetOptionsSideType(SideType sideType)
		{
			return default(bool);
		}

		// Token: 0x0600F7F1 RID: 63473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7F1")]
		[Address(RVA = "0x715F60", Offset = "0x714B60", VA = "0x180715F60", Slot = "6")]
		public virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600F7F2 RID: 63474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7F2")]
		[Address(RVA = "0x716230", Offset = "0x714E30", VA = "0x180716230")]
		public TargetValidator()
		{
		}

		// Token: 0x04011385 RID: 70533
		[Token(Token = "0x4011385")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x04011386 RID: 70534
		[Token(Token = "0x4011386")]
		[FieldOffset(Offset = "0x78")]
		private ObjectPtr<Entity> m_owner;

		// Token: 0x04011387 RID: 70535
		[Token(Token = "0x4011387")]
		[FieldOffset(Offset = "0x88")]
		private bool m_ignoreTargetSide;

		// Token: 0x04011388 RID: 70536
		[Token(Token = "0x4011388")]
		[FieldOffset(Offset = "0x89")]
		private bool m_inited;

		// Token: 0x04011389 RID: 70537
		[Token(Token = "0x4011389")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x0401138A RID: 70538
		[Token(Token = "0x401138A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401138B RID: 70539
		[Token(Token = "0x401138B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401138C RID: 70540
		[Token(Token = "0x401138C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetLayerMask;

		// Token: 0x0401138D RID: 70541
		[Token(Token = "0x401138D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_VerifyOnlyMotionAndCategory;

		// Token: 0x0401138E RID: 70542
		[Token(Token = "0x401138E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_VerifyTargetOptionsSideType;

		// Token: 0x0401138F RID: 70543
		[Token(Token = "0x401138F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011390 RID: 70544
		[Token(Token = "0x4011390")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
