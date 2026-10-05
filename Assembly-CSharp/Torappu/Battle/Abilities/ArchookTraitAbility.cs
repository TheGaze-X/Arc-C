using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B7E RID: 11134
	[Token(Token = "0x2002B7E")]
	public class ArchookTraitAbility : PassiveBuffAbility
	{
		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x06012B72 RID: 76658 RVA: 0x00072AB0 File Offset: 0x00070CB0
		[Token(Token = "0x17002933")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Face")]
		public Vector2 direction
		{
			[Token(Token = "0x6012B72")]
			[Address(RVA = "0xAACC10", Offset = "0xAAB810", VA = "0x180AACC10")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06012B73 RID: 76659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B73")]
		[Address(RVA = "0xAABFD0", Offset = "0xAAABD0", VA = "0x180AABFD0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012B74 RID: 76660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B74")]
		[Address(RVA = "0xAABEF0", Offset = "0xAAAAF0", VA = "0x180AABEF0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012B75 RID: 76661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B75")]
		[Address(RVA = "0xAAC770", Offset = "0xAAB370", VA = "0x180AAC770", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012B76 RID: 76662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B76")]
		[Address(RVA = "0xAACBB0", Offset = "0xAAB7B0", VA = "0x180AACBB0")]
		public ArchookTraitAbility()
		{
		}

		// Token: 0x06012B77 RID: 76663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B77")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012B78 RID: 76664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B78")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012B79 RID: 76665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B79")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401525F RID: 86623
		[Token(Token = "0x401525F")]
		private const int MAX_ANGLE = 360;

		// Token: 0x04015260 RID: 86624
		[Token(Token = "0x4015260")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Skin")]
		private Entity.MountPointType _rotatepoint;

		// Token: 0x04015261 RID: 86625
		[Token(Token = "0x4015261")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[Group("Skin")]
		private Entity.MountPointType _hookpoint;

		// Token: 0x04015262 RID: 86626
		[Token(Token = "0x4015262")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isCW;

		// Token: 0x04015263 RID: 86627
		[Token(Token = "0x4015263")]
		[FieldOffset(Offset = "0x121")]
		private bool m_isCircle;

		// Token: 0x04015264 RID: 86628
		[Token(Token = "0x4015264")]
		[FieldOffset(Offset = "0x122")]
		private bool m_currentCW;

		// Token: 0x04015265 RID: 86629
		[Token(Token = "0x4015265")]
		[FieldOffset(Offset = "0x128")]
		private FP m_curAngle;

		// Token: 0x04015266 RID: 86630
		[Token(Token = "0x4015266")]
		[FieldOffset(Offset = "0x130")]
		private FixedPosition m_direction;

		// Token: 0x04015267 RID: 86631
		[Token(Token = "0x4015267")]
		[FieldOffset(Offset = "0x158")]
		private FP m_rotateSpeed;

		// Token: 0x04015268 RID: 86632
		[Token(Token = "0x4015268")]
		[FieldOffset(Offset = "0x160")]
		private FP m_minAngle;

		// Token: 0x04015269 RID: 86633
		[Token(Token = "0x4015269")]
		[FieldOffset(Offset = "0x168")]
		private FP m_maxAngle;

		// Token: 0x0401526A RID: 86634
		[Token(Token = "0x401526A")]
		[FieldOffset(Offset = "0x170")]
		private FP m_rotateZ;

		// Token: 0x0401526B RID: 86635
		[Token(Token = "0x401526B")]
		[FieldOffset(Offset = "0x178")]
		private ObjectPtr<Character> m_character;

		// Token: 0x0401526C RID: 86636
		[Token(Token = "0x401526C")]
		[FieldOffset(Offset = "0x188")]
		private Transform m_rotateTransform;

		// Token: 0x0401526D RID: 86637
		[Token(Token = "0x401526D")]
		[FieldOffset(Offset = "0x190")]
		private Transform m_hookTransform;

		// Token: 0x0401526E RID: 86638
		[Token(Token = "0x401526E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_direction;

		// Token: 0x0401526F RID: 86639
		[Token(Token = "0x401526F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015270 RID: 86640
		[Token(Token = "0x4015270")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015271 RID: 86641
		[Token(Token = "0x4015271")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015272 RID: 86642
		[Token(Token = "0x4015272")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
