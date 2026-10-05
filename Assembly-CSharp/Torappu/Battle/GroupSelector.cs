using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002517 RID: 9495
	[Token(Token = "0x2002517")]
	public class GroupSelector : RangeSelector
	{
		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x0600F4F1 RID: 62705 RVA: 0x0005AD80 File Offset: 0x00058F80
		[Token(Token = "0x17001FE7")]
		protected bool limitTargetNum
		{
			[Token(Token = "0x600F4F1")]
			[Address(RVA = "0x6CA8A0", Offset = "0x6C94A0", VA = "0x1806CA8A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x0600F4F2 RID: 62706 RVA: 0x0005AD98 File Offset: 0x00058F98
		[Token(Token = "0x17001FE8")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F4F2")]
			[Address(RVA = "0x6CAAC0", Offset = "0x6C96C0", VA = "0x1806CAAC0", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x0600F4F3 RID: 62707 RVA: 0x0005ADB0 File Offset: 0x00058FB0
		[Token(Token = "0x17001FE9")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F4F3")]
			[Address(RVA = "0x6CA9E0", Offset = "0x6C95E0", VA = "0x1806CA9E0", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		[Token(Token = "0x17001FEA")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F4F4")]
			[Address(RVA = "0x6CA900", Offset = "0x6C9500", VA = "0x1806CA900", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x0600F4F5 RID: 62709 RVA: 0x0005ADE0 File Offset: 0x00058FE0
		[Token(Token = "0x17001FEB")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F4F5")]
			[Address(RVA = "0x6CA7C0", Offset = "0x6C93C0", VA = "0x1806CA7C0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F4F6 RID: 62710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4F6")]
		[Address(RVA = "0x6CA250", Offset = "0x6C8E50", VA = "0x1806CA250", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F4F7 RID: 62711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4F7")]
		[Address(RVA = "0x6CA430", Offset = "0x6C9030", VA = "0x1806CA430", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F4F8 RID: 62712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F4F8")]
		[Address(RVA = "0x6C9E30", Offset = "0x6C8A30", VA = "0x1806C9E30", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F4F9 RID: 62713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4F9")]
		[Address(RVA = "0x6CA0F0", Offset = "0x6C8CF0", VA = "0x1806CA0F0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F4FA RID: 62714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4FA")]
		[Address(RVA = "0x6CA1A0", Offset = "0x6C8DA0", VA = "0x1806CA1A0", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F4FB RID: 62715 RVA: 0x0005ADF8 File Offset: 0x00058FF8
		[Token(Token = "0x600F4FB")]
		[Address(RVA = "0x6CA670", Offset = "0x6C9270", VA = "0x1806CA670", Slot = "18")]
		public override bool VerifyTarget(List<Entity> candidates)
		{
			return default(bool);
		}

		// Token: 0x0600F4FC RID: 62716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4FC")]
		[Address(RVA = "0x6CA720", Offset = "0x6C9320", VA = "0x1806CA720")]
		public GroupSelector()
		{
		}

		// Token: 0x0600F4FD RID: 62717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4FD")]
		[Address(RVA = "0x6A2DA0", Offset = "0x6A19A0", VA = "0x1806A2DA0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F4FE RID: 62718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4FE")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F4FF RID: 62719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F4FF")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F500 RID: 62720 RVA: 0x0005AE10 File Offset: 0x00059010
		[Token(Token = "0x600F500")]
		[Address(RVA = "0x6CA660", Offset = "0x6C9260", VA = "0x1806CA660")]
		private bool <>xLuaBaseProxy_VerifyTarget(List<Entity> P0)
		{
			return default(bool);
		}

		// Token: 0x04010F7A RID: 69498
		[Token(Token = "0x4010F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<TargetSelector> _rangeSelectorsList;

		// Token: 0x04010F7B RID: 69499
		[Token(Token = "0x4010F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _limitTargetNum;

		// Token: 0x04010F7C RID: 69500
		[Token(Token = "0x4010F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Inspect("limitTargetNum")]
		private int _maxNum;

		// Token: 0x04010F7D RID: 69501
		[Token(Token = "0x4010F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Inspect("limitTargetNum")]
		private string _maxNumBlackboardKey;

		// Token: 0x04010F7E RID: 69502
		[Token(Token = "0x4010F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RangeSelector _overrideSelector;

		// Token: 0x04010F7F RID: 69503
		[Token(Token = "0x4010F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _selectable;

		// Token: 0x04010F80 RID: 69504
		[Token(Token = "0x4010F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int m_maxTargetNum;

		// Token: 0x04010F81 RID: 69505
		[Token(Token = "0x4010F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitTargetNum;

		// Token: 0x04010F82 RID: 69506
		[Token(Token = "0x4010F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010F83 RID: 69507
		[Token(Token = "0x4010F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010F84 RID: 69508
		[Token(Token = "0x4010F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010F85 RID: 69509
		[Token(Token = "0x4010F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010F86 RID: 69510
		[Token(Token = "0x4010F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010F87 RID: 69511
		[Token(Token = "0x4010F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010F88 RID: 69512
		[Token(Token = "0x4010F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010F89 RID: 69513
		[Token(Token = "0x4010F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010F8A RID: 69514
		[Token(Token = "0x4010F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010F8B RID: 69515
		[Token(Token = "0x4010F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x04010F8C RID: 69516
		[Token(Token = "0x4010F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
