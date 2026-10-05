using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DEB RID: 28139
	[Token(Token = "0x2006DEB")]
	public class ActVecBreakV2OffenseBattleFinishBuffListPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028115 RID: 164117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028115")]
		[Address(RVA = "0x2351350", Offset = "0x234FF50", VA = "0x182351350")]
		public void Render(ActVecBreakV2OffenseBattleFinishViewModel model)
		{
		}

		// Token: 0x06028116 RID: 164118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028116")]
		[Address(RVA = "0x2351440", Offset = "0x2350040", VA = "0x182351440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028117 RID: 164119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028117")]
		[Address(RVA = "0x2351610", Offset = "0x2350210", VA = "0x182351610")]
		public ActVecBreakV2OffenseBattleFinishBuffListPanel()
		{
		}

		// Token: 0x04038D61 RID: 232801
		[Token(Token = "0x4038D61")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x04038D62 RID: 232802
		[Token(Token = "0x4038D62")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _lockList;

		// Token: 0x04038D63 RID: 232803
		[Token(Token = "0x4038D63")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x04038D64 RID: 232804
		[Token(Token = "0x4038D64")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x04038D65 RID: 232805
		[Token(Token = "0x4038D65")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04038D66 RID: 232806
		[Token(Token = "0x4038D66")]
		[FieldOffset(Offset = "0x40")]
		private ActVecBreakV2OffenseBattleFinishBuffListPanel.BuffAdapter m_buffAdapter;

		// Token: 0x04038D67 RID: 232807
		[Token(Token = "0x4038D67")]
		[FieldOffset(Offset = "0x48")]
		private ActVecBreakV2OffenseBattleFinishBuffListPanel.LockAdapter m_lockAdapter;

		// Token: 0x04038D68 RID: 232808
		[Token(Token = "0x4038D68")]
		[FieldOffset(Offset = "0x50")]
		private ActVecBreakV2OffenseBattleFinishViewModel m_cachedModel;

		// Token: 0x04038D69 RID: 232809
		[Token(Token = "0x4038D69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038D6A RID: 232810
		[Token(Token = "0x4038D6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038D6B RID: 232811
		[Token(Token = "0x4038D6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DEC RID: 28140
		[Token(Token = "0x2006DEC")]
		private class BuffAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028118 RID: 164120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028118")]
			[Address(RVA = "0x235AB00", Offset = "0x2359700", VA = "0x18235AB00")]
			public BuffAdapter(ActVecBreakV2OffenseBattleFinishBuffListPanel closure)
			{
			}

			// Token: 0x17005EC4 RID: 24260
			// (get) Token: 0x06028119 RID: 164121 RVA: 0x000D09B0 File Offset: 0x000CEBB0
			[Token(Token = "0x17005EC4")]
			public override int count
			{
				[Token(Token = "0x6028119")]
				[Address(RVA = "0x235AB80", Offset = "0x2359780", VA = "0x18235AB80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602811A RID: 164122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602811A")]
			[Address(RVA = "0x235A880", Offset = "0x2359480", VA = "0x18235A880", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038D6C RID: 232812
			[Token(Token = "0x4038D6C")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2OffenseBattleFinishBuffListPanel m_closure;

			// Token: 0x04038D6D RID: 232813
			[Token(Token = "0x4038D6D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038D6E RID: 232814
			[Token(Token = "0x4038D6E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038D6F RID: 232815
			[Token(Token = "0x4038D6F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006DED RID: 28141
		[Token(Token = "0x2006DED")]
		private class LockAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602811B RID: 164123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602811B")]
			[Address(RVA = "0x235B440", Offset = "0x235A040", VA = "0x18235B440")]
			public LockAdapter(ActVecBreakV2OffenseBattleFinishBuffListPanel closure)
			{
			}

			// Token: 0x17005EC5 RID: 24261
			// (get) Token: 0x0602811C RID: 164124 RVA: 0x000D09C8 File Offset: 0x000CEBC8
			[Token(Token = "0x17005EC5")]
			public override int count
			{
				[Token(Token = "0x602811C")]
				[Address(RVA = "0x235B4C0", Offset = "0x235A0C0", VA = "0x18235B4C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602811D RID: 164125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602811D")]
			[Address(RVA = "0x235B340", Offset = "0x2359F40", VA = "0x18235B340", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038D70 RID: 232816
			[Token(Token = "0x4038D70")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2OffenseBattleFinishBuffListPanel m_closure;

			// Token: 0x04038D71 RID: 232817
			[Token(Token = "0x4038D71")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038D72 RID: 232818
			[Token(Token = "0x4038D72")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038D73 RID: 232819
			[Token(Token = "0x4038D73")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
