using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002520 RID: 9504
	[Token(Token = "0x2002520")]
	public class RandomSelector : RangeSelector
	{
		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x0600F542 RID: 62786 RVA: 0x0005B068 File Offset: 0x00059268
		[Token(Token = "0x17002001")]
		public bool limitTargetNum
		{
			[Token(Token = "0x600F542")]
			[Address(RVA = "0x6CD990", Offset = "0x6CC590", VA = "0x1806CD990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x0600F543 RID: 62787 RVA: 0x0005B080 File Offset: 0x00059280
		[Token(Token = "0x17002002")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F543")]
			[Address(RVA = "0x6CDC20", Offset = "0x6CC820", VA = "0x1806CDC20", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x0600F544 RID: 62788 RVA: 0x0005B098 File Offset: 0x00059298
		[Token(Token = "0x17002003")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F544")]
			[Address(RVA = "0x6CDBC0", Offset = "0x6CC7C0", VA = "0x1806CDBC0", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x0600F545 RID: 62789 RVA: 0x0005B0B0 File Offset: 0x000592B0
		[Token(Token = "0x17002004")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F545")]
			[Address(RVA = "0x6CDB60", Offset = "0x6CC760", VA = "0x1806CDB60", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600F546 RID: 62790 RVA: 0x0005B0C8 File Offset: 0x000592C8
		[Token(Token = "0x17002005")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F546")]
			[Address(RVA = "0x6CD930", Offset = "0x6CC530", VA = "0x1806CD930", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600F547 RID: 62791 RVA: 0x0005B0E0 File Offset: 0x000592E0
		[Token(Token = "0x17002006")]
		protected override bool ignoreHealFree
		{
			[Token(Token = "0x600F547")]
			[Address(RVA = "0x6CD8D0", Offset = "0x6CC4D0", VA = "0x1806CD8D0", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x0600F548 RID: 62792 RVA: 0x0005B0F8 File Offset: 0x000592F8
		[Token(Token = "0x17002007")]
		protected override ProfessionCategory professionMask
		{
			[Token(Token = "0x600F548")]
			[Address(RVA = "0x6CDA50", Offset = "0x6CC650", VA = "0x1806CDA50", Slot = "34")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x0600F549 RID: 62793 RVA: 0x0005B110 File Offset: 0x00059310
		[Token(Token = "0x17002008")]
		protected bool excludeSelf
		{
			[Token(Token = "0x600F549")]
			[Address(RVA = "0x6CD870", Offset = "0x6CC470", VA = "0x1806CD870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x0600F54A RID: 62794 RVA: 0x0005B128 File Offset: 0x00059328
		[Token(Token = "0x17002009")]
		protected int selectNum
		{
			[Token(Token = "0x600F54A")]
			[Address(RVA = "0x6CDB00", Offset = "0x6CC700", VA = "0x1806CDB00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x0600F54B RID: 62795 RVA: 0x0005B140 File Offset: 0x00059340
		[Token(Token = "0x1700200A")]
		protected bool alwaysAppendSelf
		{
			[Token(Token = "0x600F54B")]
			[Address(RVA = "0x6CD810", Offset = "0x6CC410", VA = "0x1806CD810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x0600F54C RID: 62796 RVA: 0x0005B158 File Offset: 0x00059358
		[Token(Token = "0x1700200B")]
		protected bool needProfessionMask
		{
			[Token(Token = "0x600F54C")]
			[Address(RVA = "0x6CD9F0", Offset = "0x6CC5F0", VA = "0x1806CD9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F54D RID: 62797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F54D")]
		[Address(RVA = "0x6CD6C0", Offset = "0x6CC2C0", VA = "0x1806CD6C0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F54E RID: 62798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F54E")]
		[Address(RVA = "0x6CD460", Offset = "0x6CC060", VA = "0x1806CD460", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F54F RID: 62799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F54F")]
		[Address(RVA = "0x6CD660", Offset = "0x6CC260", VA = "0x1806CD660", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F550 RID: 62800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F550")]
		[Address(RVA = "0x6CD780", Offset = "0x6CC380", VA = "0x1806CD780")]
		public RandomSelector()
		{
		}

		// Token: 0x0600F551 RID: 62801 RVA: 0x0005B170 File Offset: 0x00059370
		[Token(Token = "0x600F551")]
		[Address(RVA = "0x6A2E20", Offset = "0x6A1A20", VA = "0x1806A2E20")]
		private bool <>xLuaBaseProxy_get_ignoreHealFree()
		{
			return default(bool);
		}

		// Token: 0x0600F552 RID: 62802 RVA: 0x0005B188 File Offset: 0x00059388
		[Token(Token = "0x600F552")]
		[Address(RVA = "0x6A2E50", Offset = "0x6A1A50", VA = "0x1806A2E50")]
		private ProfessionCategory <>xLuaBaseProxy_get_professionMask()
		{
			return ProfessionCategory.NONE;
		}

		// Token: 0x0600F553 RID: 62803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F553")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x04010FE0 RID: 69600
		[Token(Token = "0x4010FE0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04010FE1 RID: 69601
		[Token(Token = "0x4010FE1")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private MotionMask _targetMotion;

		// Token: 0x04010FE2 RID: 69602
		[Token(Token = "0x4010FE2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private EntityCategory _targetCategory;

		// Token: 0x04010FE3 RID: 69603
		[Token(Token = "0x4010FE3")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private int _selectNum;

		// Token: 0x04010FE4 RID: 69604
		[Token(Token = "0x4010FE4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _excludeSelf;

		// Token: 0x04010FE5 RID: 69605
		[Token(Token = "0x4010FE5")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _alwaysAppendSelf;

		// Token: 0x04010FE6 RID: 69606
		[Token(Token = "0x4010FE6")]
		[FieldOffset(Offset = "0xB2")]
		[SerializeField]
		private bool _ignoreTargetFree;

		// Token: 0x04010FE7 RID: 69607
		[Token(Token = "0x4010FE7")]
		[FieldOffset(Offset = "0xB3")]
		[SerializeField]
		private bool _ignoreHealFree;

		// Token: 0x04010FE8 RID: 69608
		[Token(Token = "0x4010FE8")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private bool _needProfessionMask;

		// Token: 0x04010FE9 RID: 69609
		[Token(Token = "0x4010FE9")]
		[FieldOffset(Offset = "0xB8")]
		[Enum(true, EnumDisplay.Checkbox)]
		[Inspect("needProfessionMask")]
		public ProfessionCategory _professionMask;

		// Token: 0x04010FEA RID: 69610
		[Token(Token = "0x4010FEA")]
		[FieldOffset(Offset = "0xBC")]
		private int m_selectNum;

		// Token: 0x04010FEB RID: 69611
		[Token(Token = "0x4010FEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitTargetNum;

		// Token: 0x04010FEC RID: 69612
		[Token(Token = "0x4010FEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010FED RID: 69613
		[Token(Token = "0x4010FED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010FEE RID: 69614
		[Token(Token = "0x4010FEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010FEF RID: 69615
		[Token(Token = "0x4010FEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010FF0 RID: 69616
		[Token(Token = "0x4010FF0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_ignoreHealFree;

		// Token: 0x04010FF1 RID: 69617
		[Token(Token = "0x4010FF1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_professionMask;

		// Token: 0x04010FF2 RID: 69618
		[Token(Token = "0x4010FF2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_excludeSelf;

		// Token: 0x04010FF3 RID: 69619
		[Token(Token = "0x4010FF3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectNum;

		// Token: 0x04010FF4 RID: 69620
		[Token(Token = "0x4010FF4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_alwaysAppendSelf;

		// Token: 0x04010FF5 RID: 69621
		[Token(Token = "0x4010FF5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_needProfessionMask;

		// Token: 0x04010FF6 RID: 69622
		[Token(Token = "0x4010FF6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010FF7 RID: 69623
		[Token(Token = "0x4010FF7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010FF8 RID: 69624
		[Token(Token = "0x4010FF8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010FF9 RID: 69625
		[Token(Token = "0x4010FF9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
