using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E4D RID: 15949
	[Token(Token = "0x2003E4D")]
	public abstract class SpecialOperatorBoardNodeBase : IHotfixable
	{
		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x06018C8D RID: 101517 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018C8E RID: 101518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B0C")]
		public string nodeId
		{
			[Token(Token = "0x6018C8D")]
			[Address(RVA = "0x1170090", Offset = "0x116EC90", VA = "0x181170090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018C8E")]
			[Address(RVA = "0x1170320", Offset = "0x116EF20", VA = "0x181170320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x06018C8F RID: 101519 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018C90 RID: 101520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B0D")]
		public string prevNodeId
		{
			[Token(Token = "0x6018C8F")]
			[Address(RVA = "0x1170150", Offset = "0x116ED50", VA = "0x181170150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018C90")]
			[Address(RVA = "0x1170410", Offset = "0x116F010", VA = "0x181170410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x06018C91 RID: 101521 RVA: 0x0009BCD0 File Offset: 0x00099ED0
		// (set) Token: 0x06018C92 RID: 101522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B0E")]
		public int sortOrder
		{
			[Token(Token = "0x6018C91")]
			[Address(RVA = "0x1170250", Offset = "0x116EE50", VA = "0x181170250")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6018C92")]
			[Address(RVA = "0x1170490", Offset = "0x116F090", VA = "0x181170490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x06018C93 RID: 101523 RVA: 0x0009BCE8 File Offset: 0x00099EE8
		// (set) Token: 0x06018C94 RID: 101524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B0F")]
		public bool isInGameMechanics
		{
			[Token(Token = "0x6018C93")]
			[Address(RVA = "0x116FF80", Offset = "0x116EB80", VA = "0x18116FF80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018C94")]
			[Address(RVA = "0x11702B0", Offset = "0x116EEB0", VA = "0x1811702B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x06018C95 RID: 101525 RVA: 0x0009BD00 File Offset: 0x00099F00
		// (set) Token: 0x06018C96 RID: 101526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B10")]
		public SpecialOperatorDetailNodeType nodeType
		{
			[Token(Token = "0x6018C95")]
			[Address(RVA = "0x11700F0", Offset = "0x116ECF0", VA = "0x1811700F0")]
			[CompilerGenerated]
			get
			{
				return SpecialOperatorDetailNodeType.NONE;
			}
			[Token(Token = "0x6018C96")]
			[Address(RVA = "0x11703A0", Offset = "0x116EFA0", VA = "0x1811703A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x06018C97 RID: 101527
		[Token(Token = "0x17003B11")]
		public abstract bool isUnlocked { [Token(Token = "0x6018C97")] get; }

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x06018C98 RID: 101528
		// (set) Token: 0x06018C99 RID: 101529
		[Token(Token = "0x17003B12")]
		public abstract bool evolveLevelMeet { [Token(Token = "0x6018C98")] get; [Token(Token = "0x6018C99")] protected set; }

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x06018C9A RID: 101530
		// (set) Token: 0x06018C9B RID: 101531
		[Token(Token = "0x17003B13")]
		public abstract bool unlockTaskMeet { [Token(Token = "0x6018C9A")] get; [Token(Token = "0x6018C9B")] protected set; }

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x06018C9C RID: 101532 RVA: 0x0009BD18 File Offset: 0x00099F18
		[Token(Token = "0x17003B14")]
		public bool meetUnlockCond
		{
			[Token(Token = "0x6018C9C")]
			[Address(RVA = "0x116FFE0", Offset = "0x116EBE0", VA = "0x18116FFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06018C9D RID: 101533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C9D")]
		[Address(RVA = "0x116FF20", Offset = "0x116EB20", VA = "0x18116FF20")]
		protected SpecialOperatorBoardNodeBase()
		{
		}

		// Token: 0x06018C9E RID: 101534
		[Token(Token = "0x6018C9E")]
		protected abstract void OnInitData();

		// Token: 0x06018C9F RID: 101535
		[Token(Token = "0x6018C9F")]
		public abstract void RefreshData(PlayerCharacter playerChar);

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x06018CA0 RID: 101536 RVA: 0x0009BD30 File Offset: 0x00099F30
		[Token(Token = "0x17003B15")]
		public virtual SpecialOperatorSelectAnchorType selectAnchorType
		{
			[Token(Token = "0x6018CA0")]
			[Address(RVA = "0x116F450", Offset = "0x116E050", VA = "0x18116F450", Slot = "11")]
			get
			{
				return SpecialOperatorSelectAnchorType.OFFSET;
			}
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x06018CA1 RID: 101537 RVA: 0x0009BD48 File Offset: 0x00099F48
		[Token(Token = "0x17003B16")]
		public virtual Vector2 selectAnchorOffset
		{
			[Token(Token = "0x6018CA1")]
			[Address(RVA = "0x11701B0", Offset = "0x116EDB0", VA = "0x1811701B0", Slot = "12")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06018CA2 RID: 101538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018CA2")]
		[Address(RVA = "0x116FCB0", Offset = "0x116E8B0", VA = "0x18116FCB0")]
		private void _InitData(string nodeId, SpecialOperatorDetailNodeUnlockData nodeData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018CA3 RID: 101539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018CA3")]
		[Address(RVA = "0x116F830", Offset = "0x116E430", VA = "0x18116F830")]
		public static SpecialOperatorBoardNodeBase CreateNode(string nodeId, SpecialOperatorDetailData detailData)
		{
			return null;
		}

		// Token: 0x0401E75B RID: 124763
		[Token(Token = "0x401E75B")]
		protected const float DEFAULT_SELECT_NODE_ANCHOR_OFFSET_LEFT = -30f;

		// Token: 0x0401E75C RID: 124764
		[Token(Token = "0x401E75C")]
		[FieldOffset(Offset = "0x10")]
		protected SpecialOperatorDetailData m_detailData;

		// Token: 0x0401E75D RID: 124765
		[Token(Token = "0x401E75D")]
		[FieldOffset(Offset = "0x18")]
		protected SpecialOperatorDetailNodeUnlockData m_unlockData;

		// Token: 0x0401E763 RID: 124771
		[Token(Token = "0x401E763")]
		[FieldOffset(Offset = "0x3C")]
		public bool canUnlock;

		// Token: 0x0401E764 RID: 124772
		[Token(Token = "0x401E764")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeId;

		// Token: 0x0401E765 RID: 124773
		[Token(Token = "0x401E765")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_nodeId;

		// Token: 0x0401E766 RID: 124774
		[Token(Token = "0x401E766")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_prevNodeId;

		// Token: 0x0401E767 RID: 124775
		[Token(Token = "0x401E767")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_prevNodeId;

		// Token: 0x0401E768 RID: 124776
		[Token(Token = "0x401E768")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortOrder;

		// Token: 0x0401E769 RID: 124777
		[Token(Token = "0x401E769")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortOrder;

		// Token: 0x0401E76A RID: 124778
		[Token(Token = "0x401E76A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isInGameMechanics;

		// Token: 0x0401E76B RID: 124779
		[Token(Token = "0x401E76B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isInGameMechanics;

		// Token: 0x0401E76C RID: 124780
		[Token(Token = "0x401E76C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401E76D RID: 124781
		[Token(Token = "0x401E76D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_nodeType;

		// Token: 0x0401E76E RID: 124782
		[Token(Token = "0x401E76E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_meetUnlockCond;

		// Token: 0x0401E76F RID: 124783
		[Token(Token = "0x401E76F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E770 RID: 124784
		[Token(Token = "0x401E770")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_selectAnchorType;

		// Token: 0x0401E771 RID: 124785
		[Token(Token = "0x401E771")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_selectAnchorOffset;

		// Token: 0x0401E772 RID: 124786
		[Token(Token = "0x401E772")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0401E773 RID: 124787
		[Token(Token = "0x401E773")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CreateNode;
	}
}
