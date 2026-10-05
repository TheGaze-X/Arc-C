using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200284A RID: 10314
	[Token(Token = "0x200284A")]
	public class LevelScriptNodes
	{
		// Token: 0x060112BF RID: 70335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112BF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LevelScriptNodes()
		{
		}

		// Token: 0x0200284B RID: 10315
		[Token(Token = "0x200284B")]
		[NodeInfo("角色事件 ", "部署干员落地时", -1100)]
		public class OnCharacterBorn : LevelEventHeader
		{
			// Token: 0x170025DB RID: 9691
			// (get) Token: 0x060112C0 RID: 70336 RVA: 0x00069BA0 File Offset: 0x00067DA0
			[Token(Token = "0x170025DB")]
			public override GameLevelEvent levelEventKey
			{
				[Token(Token = "0x60112C0")]
				[Address(RVA = "0x916F50", Offset = "0x915B50", VA = "0x180916F50", Slot = "11")]
				get
				{
					return GameLevelEvent.CUSTOM;
				}
			}

			// Token: 0x060112C1 RID: 70337 RVA: 0x00069BB8 File Offset: 0x00067DB8
			[Token(Token = "0x60112C1")]
			[Address(RVA = "0x916BD0", Offset = "0x9157D0", VA = "0x180916BD0", Slot = "9")]
			protected override bool Process(ParamBlackboard eventContext)
			{
				return default(bool);
			}

			// Token: 0x060112C2 RID: 70338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112C2")]
			[Address(RVA = "0x916AF0", Offset = "0x9156F0", VA = "0x180916AF0", Slot = "8")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112C3 RID: 70339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112C3")]
			[Address(RVA = "0x916EB0", Offset = "0x915AB0", VA = "0x180916EB0")]
			public OnCharacterBorn()
			{
			}

			// Token: 0x060112C4 RID: 70340 RVA: 0x00069BD0 File Offset: 0x00067DD0
			[Token(Token = "0x60112C4")]
			[Address(RVA = "0x906D10", Offset = "0x905910", VA = "0x180906D10")]
			private bool <>xLuaBaseProxy_Process(ParamBlackboard P0)
			{
				return default(bool);
			}

			// Token: 0x060112C5 RID: 70341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112C5")]
			[Address(RVA = "0x916EA0", Offset = "0x915AA0", VA = "0x180916EA0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133BD RID: 78781
			[Token(Token = "0x40133BD")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private ParamOutput<string> _character;

			// Token: 0x040133BE RID: 78782
			[Token(Token = "0x40133BE")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private ParamOutput<Vector2> _tile;

			// Token: 0x040133BF RID: 78783
			[Token(Token = "0x40133BF")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private bool _filterTiles;

			// Token: 0x040133C0 RID: 78784
			[Token(Token = "0x40133C0")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private Param<List<Vector2>> _tiles;

			// Token: 0x040133C1 RID: 78785
			[Token(Token = "0x40133C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_levelEventKey;

			// Token: 0x040133C2 RID: 78786
			[Token(Token = "0x40133C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Process;

			// Token: 0x040133C3 RID: 78787
			[Token(Token = "0x40133C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133C4 RID: 78788
			[Token(Token = "0x40133C4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200284C RID: 10316
		[Token(Token = "0x200284C")]
		[NodeInfo("角色事件 ", "干员撤退时", -1100)]
		public class OnCharacterWithDraw : LevelEventHeader
		{
			// Token: 0x170025DC RID: 9692
			// (get) Token: 0x060112C6 RID: 70342 RVA: 0x00069BE8 File Offset: 0x00067DE8
			[Token(Token = "0x170025DC")]
			public override GameLevelEvent levelEventKey
			{
				[Token(Token = "0x60112C6")]
				[Address(RVA = "0x9173F0", Offset = "0x915FF0", VA = "0x1809173F0", Slot = "11")]
				get
				{
					return GameLevelEvent.CUSTOM;
				}
			}

			// Token: 0x060112C7 RID: 70343 RVA: 0x00069C00 File Offset: 0x00067E00
			[Token(Token = "0x60112C7")]
			[Address(RVA = "0x917080", Offset = "0x915C80", VA = "0x180917080", Slot = "9")]
			protected override bool Process(ParamBlackboard eventContext)
			{
				return default(bool);
			}

			// Token: 0x060112C8 RID: 70344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112C8")]
			[Address(RVA = "0x916FB0", Offset = "0x915BB0", VA = "0x180916FB0", Slot = "8")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112C9 RID: 70345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112C9")]
			[Address(RVA = "0x917350", Offset = "0x915F50", VA = "0x180917350")]
			public OnCharacterWithDraw()
			{
			}

			// Token: 0x060112CA RID: 70346 RVA: 0x00069C18 File Offset: 0x00067E18
			[Token(Token = "0x60112CA")]
			[Address(RVA = "0x906D10", Offset = "0x905910", VA = "0x180906D10")]
			private bool <>xLuaBaseProxy_Process(ParamBlackboard P0)
			{
				return default(bool);
			}

			// Token: 0x060112CB RID: 70347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112CB")]
			[Address(RVA = "0x916EA0", Offset = "0x915AA0", VA = "0x180916EA0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133C5 RID: 78789
			[Token(Token = "0x40133C5")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private ParamOutput<string> _character;

			// Token: 0x040133C6 RID: 78790
			[Token(Token = "0x40133C6")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private ParamOutput<Vector2> _tile;

			// Token: 0x040133C7 RID: 78791
			[Token(Token = "0x40133C7")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private bool _filterTiles;

			// Token: 0x040133C8 RID: 78792
			[Token(Token = "0x40133C8")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private Param<List<Vector2>> _tiles;

			// Token: 0x040133C9 RID: 78793
			[Token(Token = "0x40133C9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_levelEventKey;

			// Token: 0x040133CA RID: 78794
			[Token(Token = "0x40133CA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Process;

			// Token: 0x040133CB RID: 78795
			[Token(Token = "0x40133CB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133CC RID: 78796
			[Token(Token = "0x40133CC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200284D RID: 10317
		[Token(Token = "0x200284D")]
		[NodeInfo("敌人事件 ", "敌人死亡时", -1000)]
		public class OnEnemyDie : LevelEventHeader
		{
			// Token: 0x170025DD RID: 9693
			// (get) Token: 0x060112CC RID: 70348 RVA: 0x00069C30 File Offset: 0x00067E30
			[Token(Token = "0x170025DD")]
			public override GameLevelEvent levelEventKey
			{
				[Token(Token = "0x60112CC")]
				[Address(RVA = "0x9182E0", Offset = "0x916EE0", VA = "0x1809182E0", Slot = "11")]
				get
				{
					return GameLevelEvent.CUSTOM;
				}
			}

			// Token: 0x060112CD RID: 70349 RVA: 0x00069C48 File Offset: 0x00067E48
			[Token(Token = "0x60112CD")]
			[Address(RVA = "0x918110", Offset = "0x916D10", VA = "0x180918110", Slot = "9")]
			protected override bool Process(ParamBlackboard eventContext)
			{
				return default(bool);
			}

			// Token: 0x060112CE RID: 70350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112CE")]
			[Address(RVA = "0x918070", Offset = "0x916C70", VA = "0x180918070", Slot = "8")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112CF RID: 70351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112CF")]
			[Address(RVA = "0x918240", Offset = "0x916E40", VA = "0x180918240")]
			public OnEnemyDie()
			{
			}

			// Token: 0x060112D0 RID: 70352 RVA: 0x00069C60 File Offset: 0x00067E60
			[Token(Token = "0x60112D0")]
			[Address(RVA = "0x906D10", Offset = "0x905910", VA = "0x180906D10")]
			private bool <>xLuaBaseProxy_Process(ParamBlackboard P0)
			{
				return default(bool);
			}

			// Token: 0x060112D1 RID: 70353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112D1")]
			[Address(RVA = "0x916EA0", Offset = "0x915AA0", VA = "0x180916EA0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133CD RID: 78797
			[Token(Token = "0x40133CD")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private Param<string> _enemy;

			// Token: 0x040133CE RID: 78798
			[Token(Token = "0x40133CE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_levelEventKey;

			// Token: 0x040133CF RID: 78799
			[Token(Token = "0x40133CF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Process;

			// Token: 0x040133D0 RID: 78800
			[Token(Token = "0x40133D0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133D1 RID: 78801
			[Token(Token = "0x40133D1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200284E RID: 10318
		[Token(Token = "0x200284E")]
		[NodeInfo("Getter ", "获取事件参数Int", -400)]
		public class GetEventParamInt : PureGetter<int>
		{
			// Token: 0x060112D2 RID: 70354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112D2")]
			[Address(RVA = "0x90D580", Offset = "0x90C180", VA = "0x18090D580", Slot = "6")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112D3 RID: 70355 RVA: 0x00069C78 File Offset: 0x00067E78
			[Token(Token = "0x60112D3")]
			[Address(RVA = "0x90D650", Offset = "0x90C250", VA = "0x18090D650", Slot = "7")]
			public override int GetResult()
			{
				return 0;
			}

			// Token: 0x060112D4 RID: 70356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112D4")]
			[Address(RVA = "0x90D800", Offset = "0x90C400", VA = "0x18090D800")]
			public GetEventParamInt()
			{
			}

			// Token: 0x060112D5 RID: 70357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112D5")]
			[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133D2 RID: 78802
			[Token(Token = "0x40133D2")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Param<string> key;

			// Token: 0x040133D3 RID: 78803
			[Token(Token = "0x40133D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133D4 RID: 78804
			[Token(Token = "0x40133D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x040133D5 RID: 78805
			[Token(Token = "0x40133D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200284F RID: 10319
		[Token(Token = "0x200284F")]
		[NodeInfo("关卡蓝图", "自定义关卡事件", -800)]
		public class OnCustomLevelEvent : LevelEventHeader
		{
			// Token: 0x170025DE RID: 9694
			// (get) Token: 0x060112D6 RID: 70358 RVA: 0x00069C90 File Offset: 0x00067E90
			[Token(Token = "0x170025DE")]
			public override GameLevelEvent levelEventKey
			{
				[Token(Token = "0x60112D6")]
				[Address(RVA = "0x918010", Offset = "0x916C10", VA = "0x180918010", Slot = "11")]
				get
				{
					return GameLevelEvent.CUSTOM;
				}
			}

			// Token: 0x170025DF RID: 9695
			// (get) Token: 0x060112D7 RID: 70359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170025DF")]
			public override string keyFilter
			{
				[Token(Token = "0x60112D7")]
				[Address(RVA = "0x917F90", Offset = "0x916B90", VA = "0x180917F90", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060112D8 RID: 70360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112D8")]
			[Address(RVA = "0x917E50", Offset = "0x916A50", VA = "0x180917E50", Slot = "8")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112D9 RID: 70361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112D9")]
			[Address(RVA = "0x917EF0", Offset = "0x916AF0", VA = "0x180917EF0")]
			public OnCustomLevelEvent()
			{
			}

			// Token: 0x060112DA RID: 70362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60112DA")]
			[Address(RVA = "0x917620", Offset = "0x916220", VA = "0x180917620")]
			private string <>xLuaBaseProxy_get_keyFilter()
			{
				return null;
			}

			// Token: 0x060112DB RID: 70363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112DB")]
			[Address(RVA = "0x916EA0", Offset = "0x915AA0", VA = "0x180916EA0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133D6 RID: 78806
			[Token(Token = "0x40133D6")]
			[FieldOffset(Offset = "0x50")]
			public Param<string> _eventKey;

			// Token: 0x040133D7 RID: 78807
			[Token(Token = "0x40133D7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_levelEventKey;

			// Token: 0x040133D8 RID: 78808
			[Token(Token = "0x40133D8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_keyFilter;

			// Token: 0x040133D9 RID: 78809
			[Token(Token = "0x40133D9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133DA RID: 78810
			[Token(Token = "0x40133DA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002850 RID: 10320
		[Token(Token = "0x2002850")]
		[NodeInfo("关卡蓝图", "自定义关卡事件(带Char)", -800)]
		public class OnCustomLevelEventCharacterPtr : LevelEventHeader
		{
			// Token: 0x170025E0 RID: 9696
			// (get) Token: 0x060112DC RID: 70364 RVA: 0x00069CA8 File Offset: 0x00067EA8
			[Token(Token = "0x170025E0")]
			public override GameLevelEvent levelEventKey
			{
				[Token(Token = "0x60112DC")]
				[Address(RVA = "0x917750", Offset = "0x916350", VA = "0x180917750", Slot = "11")]
				get
				{
					return GameLevelEvent.CUSTOM;
				}
			}

			// Token: 0x170025E1 RID: 9697
			// (get) Token: 0x060112DD RID: 70365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170025E1")]
			public override string keyFilter
			{
				[Token(Token = "0x60112DD")]
				[Address(RVA = "0x9176D0", Offset = "0x9162D0", VA = "0x1809176D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060112DE RID: 70366 RVA: 0x00069CC0 File Offset: 0x00067EC0
			[Token(Token = "0x60112DE")]
			[Address(RVA = "0x917510", Offset = "0x916110", VA = "0x180917510", Slot = "9")]
			protected override bool Process(ParamBlackboard eventContext)
			{
				return default(bool);
			}

			// Token: 0x060112DF RID: 70367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112DF")]
			[Address(RVA = "0x917450", Offset = "0x916050", VA = "0x180917450", Slot = "8")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112E0 RID: 70368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112E0")]
			[Address(RVA = "0x917630", Offset = "0x916230", VA = "0x180917630")]
			public OnCustomLevelEventCharacterPtr()
			{
			}

			// Token: 0x060112E1 RID: 70369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60112E1")]
			[Address(RVA = "0x917620", Offset = "0x916220", VA = "0x180917620")]
			private string <>xLuaBaseProxy_get_keyFilter()
			{
				return null;
			}

			// Token: 0x060112E2 RID: 70370 RVA: 0x00069CD8 File Offset: 0x00067ED8
			[Token(Token = "0x60112E2")]
			[Address(RVA = "0x906D10", Offset = "0x905910", VA = "0x180906D10")]
			private bool <>xLuaBaseProxy_Process(ParamBlackboard P0)
			{
				return default(bool);
			}

			// Token: 0x060112E3 RID: 70371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112E3")]
			[Address(RVA = "0x916EA0", Offset = "0x915AA0", VA = "0x180916EA0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133DB RID: 78811
			[Token(Token = "0x40133DB")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			public Param<string> _eventKey;

			// Token: 0x040133DC RID: 78812
			[Token(Token = "0x40133DC")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public ParamOutput<CharacterPtr> _characterPtr;

			// Token: 0x040133DD RID: 78813
			[Token(Token = "0x40133DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_levelEventKey;

			// Token: 0x040133DE RID: 78814
			[Token(Token = "0x40133DE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_keyFilter;

			// Token: 0x040133DF RID: 78815
			[Token(Token = "0x40133DF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Process;

			// Token: 0x040133E0 RID: 78816
			[Token(Token = "0x40133E0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133E1 RID: 78817
			[Token(Token = "0x40133E1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002851 RID: 10321
		[Token(Token = "0x2002851")]
		[NodeInfo("关卡蓝图", "自定义关卡事件(带敌人)", -800)]
		public class OnCustomLevelEventEnemyPtr : LevelEventHeader
		{
			// Token: 0x170025E2 RID: 9698
			// (get) Token: 0x060112E4 RID: 70372 RVA: 0x00069CF0 File Offset: 0x00067EF0
			[Token(Token = "0x170025E2")]
			public override GameLevelEvent levelEventKey
			{
				[Token(Token = "0x60112E4")]
				[Address(RVA = "0x917DF0", Offset = "0x9169F0", VA = "0x180917DF0", Slot = "11")]
				get
				{
					return GameLevelEvent.CUSTOM;
				}
			}

			// Token: 0x170025E3 RID: 9699
			// (get) Token: 0x060112E5 RID: 70373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170025E3")]
			public override string keyFilter
			{
				[Token(Token = "0x60112E5")]
				[Address(RVA = "0x917D70", Offset = "0x916970", VA = "0x180917D70", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060112E6 RID: 70374 RVA: 0x00069D08 File Offset: 0x00067F08
			[Token(Token = "0x60112E6")]
			[Address(RVA = "0x917BC0", Offset = "0x9167C0", VA = "0x180917BC0", Slot = "9")]
			protected override bool Process(ParamBlackboard eventContext)
			{
				return default(bool);
			}

			// Token: 0x060112E7 RID: 70375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112E7")]
			[Address(RVA = "0x917B00", Offset = "0x916700", VA = "0x180917B00", Slot = "8")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112E8 RID: 70376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112E8")]
			[Address(RVA = "0x917CD0", Offset = "0x9168D0", VA = "0x180917CD0")]
			public OnCustomLevelEventEnemyPtr()
			{
			}

			// Token: 0x060112E9 RID: 70377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60112E9")]
			[Address(RVA = "0x917620", Offset = "0x916220", VA = "0x180917620")]
			private string <>xLuaBaseProxy_get_keyFilter()
			{
				return null;
			}

			// Token: 0x060112EA RID: 70378 RVA: 0x00069D20 File Offset: 0x00067F20
			[Token(Token = "0x60112EA")]
			[Address(RVA = "0x906D10", Offset = "0x905910", VA = "0x180906D10")]
			private bool <>xLuaBaseProxy_Process(ParamBlackboard P0)
			{
				return default(bool);
			}

			// Token: 0x060112EB RID: 70379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112EB")]
			[Address(RVA = "0x916EA0", Offset = "0x915AA0", VA = "0x180916EA0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133E2 RID: 78818
			[Token(Token = "0x40133E2")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			public Param<string> eventKey;

			// Token: 0x040133E3 RID: 78819
			[Token(Token = "0x40133E3")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public ParamOutput<EnemyPtr> enemyPtr;

			// Token: 0x040133E4 RID: 78820
			[Token(Token = "0x40133E4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_levelEventKey;

			// Token: 0x040133E5 RID: 78821
			[Token(Token = "0x40133E5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_keyFilter;

			// Token: 0x040133E6 RID: 78822
			[Token(Token = "0x40133E6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Process;

			// Token: 0x040133E7 RID: 78823
			[Token(Token = "0x40133E7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133E8 RID: 78824
			[Token(Token = "0x40133E8")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002852 RID: 10322
		[Token(Token = "0x2002852")]
		[NodeInfo("关卡蓝图", "自定义关卡事件(带敌人和整型)", -800)]
		public class OnCustomLevelEventEnemyPtrWithInteger : LevelScriptNodes.OnCustomLevelEventEnemyPtr
		{
			// Token: 0x060112EC RID: 70380 RVA: 0x00069D38 File Offset: 0x00067F38
			[Token(Token = "0x60112EC")]
			[Address(RVA = "0x917880", Offset = "0x916480", VA = "0x180917880", Slot = "9")]
			protected override bool Process(ParamBlackboard eventContext)
			{
				return default(bool);
			}

			// Token: 0x060112ED RID: 70381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112ED")]
			[Address(RVA = "0x9177B0", Offset = "0x9163B0", VA = "0x1809177B0", Slot = "8")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112EE RID: 70382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112EE")]
			[Address(RVA = "0x917A20", Offset = "0x916620", VA = "0x180917A20")]
			public OnCustomLevelEventEnemyPtrWithInteger()
			{
			}

			// Token: 0x060112EF RID: 70383 RVA: 0x00069D50 File Offset: 0x00067F50
			[Token(Token = "0x60112EF")]
			[Address(RVA = "0x917A10", Offset = "0x916610", VA = "0x180917A10")]
			private bool <>xLuaBaseProxy_Process(ParamBlackboard P0)
			{
				return default(bool);
			}

			// Token: 0x060112F0 RID: 70384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112F0")]
			[Address(RVA = "0x917A00", Offset = "0x916600", VA = "0x180917A00")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x040133E9 RID: 78825
			[Token(Token = "0x40133E9")]
			private const string INTERGR_STR = "integer";

			// Token: 0x040133EA RID: 78826
			[Token(Token = "0x40133EA")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public ParamOutput<int> integer;

			// Token: 0x040133EB RID: 78827
			[Token(Token = "0x40133EB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Process;

			// Token: 0x040133EC RID: 78828
			[Token(Token = "0x40133EC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133ED RID: 78829
			[Token(Token = "0x40133ED")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002853 RID: 10323
		[Token(Token = "0x2002853")]
		[NodeInfo("关卡蓝图", "脚本临时变量改变", -800)]
		public class OnTempValueChanged : ScriptEventHeader
		{
			// Token: 0x170025E4 RID: 9700
			// (get) Token: 0x060112F1 RID: 70385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170025E4")]
			public override string keyFilter
			{
				[Token(Token = "0x60112F1")]
				[Address(RVA = "0x9187E0", Offset = "0x9173E0", VA = "0x1809187E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060112F2 RID: 70386 RVA: 0x00069D68 File Offset: 0x00067F68
			[Token(Token = "0x60112F2")]
			[Address(RVA = "0x9184B0", Offset = "0x9170B0", VA = "0x1809184B0", Slot = "9")]
			protected override bool Process(ParamBlackboard eventContext)
			{
				return default(bool);
			}

			// Token: 0x060112F3 RID: 70387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112F3")]
			[Address(RVA = "0x918340", Offset = "0x916F40", VA = "0x180918340", Slot = "10")]
			public override void OnAfterLevelScriptTriggerRegistered(string scriptPtr, ActionContext actionContext)
			{
			}

			// Token: 0x060112F4 RID: 70388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112F4")]
			[Address(RVA = "0x918740", Offset = "0x917340", VA = "0x180918740")]
			public OnTempValueChanged()
			{
			}

			// Token: 0x060112F5 RID: 70389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60112F5")]
			[Address(RVA = "0x906E80", Offset = "0x905A80", VA = "0x180906E80")]
			private string <>xLuaBaseProxy_get_keyFilter()
			{
				return null;
			}

			// Token: 0x060112F6 RID: 70390 RVA: 0x00069D80 File Offset: 0x00067F80
			[Token(Token = "0x60112F6")]
			[Address(RVA = "0x906D10", Offset = "0x905910", VA = "0x180906D10")]
			private bool <>xLuaBaseProxy_Process(ParamBlackboard P0)
			{
				return default(bool);
			}

			// Token: 0x060112F7 RID: 70391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112F7")]
			[Address(RVA = "0x906C90", Offset = "0x905890", VA = "0x180906C90")]
			private void <>xLuaBaseProxy_OnAfterLevelScriptTriggerRegistered(string P0, ActionContext P1)
			{
			}

			// Token: 0x040133EE RID: 78830
			[Token(Token = "0x40133EE")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<string> _tempKey;

			// Token: 0x040133EF RID: 78831
			[Token(Token = "0x40133EF")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public ParamOutput<object> _value;

			// Token: 0x040133F0 RID: 78832
			[Token(Token = "0x40133F0")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			public ParamOutput<object> _oldValue;

			// Token: 0x040133F1 RID: 78833
			[Token(Token = "0x40133F1")]
			[FieldOffset(Offset = "0x78")]
			private string m_key;

			// Token: 0x040133F2 RID: 78834
			[Token(Token = "0x40133F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_keyFilter;

			// Token: 0x040133F3 RID: 78835
			[Token(Token = "0x40133F3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Process;

			// Token: 0x040133F4 RID: 78836
			[Token(Token = "0x40133F4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnAfterLevelScriptTriggerRegistered;

			// Token: 0x040133F5 RID: 78837
			[Token(Token = "0x40133F5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002854 RID: 10324
		[Token(Token = "0x2002854")]
		[NodeInfo("卡牌 ", "隐藏指定手牌以外的其他手牌", -600)]
		public class HideCard : LevelScriptActionBase
		{
			// Token: 0x060112F8 RID: 70392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112F8")]
			[Address(RVA = "0x90EF70", Offset = "0x90DB70", VA = "0x18090EF70", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112F9 RID: 70393 RVA: 0x00069D98 File Offset: 0x00067F98
			[Token(Token = "0x60112F9")]
			[Address(RVA = "0x90F050", Offset = "0x90DC50", VA = "0x18090F050", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x060112FA RID: 70394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112FA")]
			[Address(RVA = "0x90F270", Offset = "0x90DE70", VA = "0x18090F270")]
			public HideCard()
			{
			}

			// Token: 0x060112FB RID: 70395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112FB")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x060112FC RID: 70396 RVA: 0x00069DB0 File Offset: 0x00067FB0
			[Token(Token = "0x60112FC")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x040133F6 RID: 78838
			[Token(Token = "0x40133F6")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<string> _cardId;

			// Token: 0x040133F7 RID: 78839
			[Token(Token = "0x40133F7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133F8 RID: 78840
			[Token(Token = "0x40133F8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x040133F9 RID: 78841
			[Token(Token = "0x40133F9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002855 RID: 10325
		[Token(Token = "0x2002855")]
		[NodeInfo("角色 ", "撤退干员", -1100)]
		public class WithDrawCharacter : LevelScriptActionBase
		{
			// Token: 0x060112FD RID: 70397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112FD")]
			[Address(RVA = "0x91B690", Offset = "0x91A290", VA = "0x18091B690", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x060112FE RID: 70398 RVA: 0x00069DC8 File Offset: 0x00067FC8
			[Token(Token = "0x60112FE")]
			[Address(RVA = "0x91B770", Offset = "0x91A370", VA = "0x18091B770", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x060112FF RID: 70399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60112FF")]
			[Address(RVA = "0x91B8B0", Offset = "0x91A4B0", VA = "0x18091B8B0")]
			public WithDrawCharacter()
			{
			}

			// Token: 0x06011300 RID: 70400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011300")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011301 RID: 70401 RVA: 0x00069DE0 File Offset: 0x00067FE0
			[Token(Token = "0x6011301")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x040133FA RID: 78842
			[Token(Token = "0x40133FA")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private Param<string> _character;

			// Token: 0x040133FB RID: 78843
			[Token(Token = "0x40133FB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x040133FC RID: 78844
			[Token(Token = "0x40133FC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x040133FD RID: 78845
			[Token(Token = "0x40133FD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002856 RID: 10326
		[Token(Token = "0x2002856")]
		[NodeInfo("关卡脚本节点测试 ", "测试节点", -50)]
		public class LevelScriptTestNode : LevelScriptActionBase
		{
			// Token: 0x06011302 RID: 70402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011302")]
			[Address(RVA = "0x9162D0", Offset = "0x914ED0", VA = "0x1809162D0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011303 RID: 70403 RVA: 0x00069DF8 File Offset: 0x00067FF8
			[Token(Token = "0x6011303")]
			[Address(RVA = "0x9163E0", Offset = "0x914FE0", VA = "0x1809163E0", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011304 RID: 70404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011304")]
			[Address(RVA = "0x916540", Offset = "0x915140", VA = "0x180916540")]
			public LevelScriptTestNode()
			{
			}

			// Token: 0x06011305 RID: 70405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011305")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011306 RID: 70406 RVA: 0x00069E10 File Offset: 0x00068010
			[Token(Token = "0x6011306")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x040133FE RID: 78846
			[Token(Token = "0x40133FE")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<string> testString;

			// Token: 0x040133FF RID: 78847
			[Token(Token = "0x40133FF")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<float> testFloat;

			// Token: 0x04013400 RID: 78848
			[Token(Token = "0x4013400")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public Param<Vector2> testVector2;

			// Token: 0x04013401 RID: 78849
			[Token(Token = "0x4013401")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013402 RID: 78850
			[Token(Token = "0x4013402")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013403 RID: 78851
			[Token(Token = "0x4013403")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002857 RID: 10327
		[Token(Token = "0x2002857")]
		[NodeInfo("敌人 ", "召唤敌人（指定起点终点）", -1000)]
		public class SummonEnemyWithRuntimeRoute : LevelScriptActionBase
		{
			// Token: 0x06011307 RID: 70407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011307")]
			[Address(RVA = "0x91AB50", Offset = "0x919750", VA = "0x18091AB50", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011308 RID: 70408 RVA: 0x00069E28 File Offset: 0x00068028
			[Token(Token = "0x6011308")]
			[Address(RVA = "0x91AC70", Offset = "0x919870", VA = "0x18091AC70", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011309 RID: 70409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011309")]
			[Address(RVA = "0x91AE80", Offset = "0x919A80", VA = "0x18091AE80")]
			public SummonEnemyWithRuntimeRoute()
			{
			}

			// Token: 0x0601130A RID: 70410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601130A")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x0601130B RID: 70411 RVA: 0x00069E40 File Offset: 0x00068040
			[Token(Token = "0x601130B")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013404 RID: 78852
			[Token(Token = "0x4013404")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<string> _enemyKey;

			// Token: 0x04013405 RID: 78853
			[Token(Token = "0x4013405")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<MotionMode> _motionMode;

			// Token: 0x04013406 RID: 78854
			[Token(Token = "0x4013406")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public Param<Vector2> _startTile;

			// Token: 0x04013407 RID: 78855
			[Token(Token = "0x4013407")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			public Param<Vector2> _endTile;

			// Token: 0x04013408 RID: 78856
			[Token(Token = "0x4013408")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013409 RID: 78857
			[Token(Token = "0x4013409")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x0401340A RID: 78858
			[Token(Token = "0x401340A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002858 RID: 10328
		[Token(Token = "0x2002858")]
		[NodeInfo("关卡流程控制 ", "关卡胜利", -400)]
		public class WinGame : LevelScriptActionBase
		{
			// Token: 0x0601130C RID: 70412 RVA: 0x00069E58 File Offset: 0x00068058
			[Token(Token = "0x601130C")]
			[Address(RVA = "0x91B590", Offset = "0x91A190", VA = "0x18091B590", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x0601130D RID: 70413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601130D")]
			[Address(RVA = "0x91B630", Offset = "0x91A230", VA = "0x18091B630")]
			public WinGame()
			{
			}

			// Token: 0x0601130E RID: 70414 RVA: 0x00069E70 File Offset: 0x00068070
			[Token(Token = "0x601130E")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x0401340B RID: 78859
			[Token(Token = "0x401340B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x0401340C RID: 78860
			[Token(Token = "0x401340C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002859 RID: 10329
		[Token(Token = "0x2002859")]
		[NodeInfo("关卡蓝图", "If Else", -800)]
		public class IfElse : LevelScriptActionBase
		{
			// Token: 0x0601130F RID: 70415 RVA: 0x00069E88 File Offset: 0x00068088
			[Token(Token = "0x601130F")]
			[Address(RVA = "0x90F720", Offset = "0x90E320", VA = "0x18090F720", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011310 RID: 70416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011310")]
			[Address(RVA = "0x90F690", Offset = "0x90E290", VA = "0x18090F690", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011311 RID: 70417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011311")]
			[Address(RVA = "0x90F820", Offset = "0x90E420", VA = "0x18090F820")]
			public IfElse()
			{
			}

			// Token: 0x06011312 RID: 70418 RVA: 0x00069EA0 File Offset: 0x000680A0
			[Token(Token = "0x6011312")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x06011313 RID: 70419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011313")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x0401340D RID: 78861
			[Token(Token = "0x401340D")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private Param<bool> _condition;

			// Token: 0x0401340E RID: 78862
			[Token(Token = "0x401340E")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			[HideInInspector]
			public int _onTrueID;

			// Token: 0x0401340F RID: 78863
			[Token(Token = "0x401340F")]
			[FieldOffset(Offset = "0x64")]
			[SerializeField]
			[HideInInspector]
			public int _onFalseID;

			// Token: 0x04013410 RID: 78864
			[Token(Token = "0x4013410")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013411 RID: 78865
			[Token(Token = "0x4013411")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013412 RID: 78866
			[Token(Token = "0x4013412")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200285A RID: 10330
		[Token(Token = "0x200285A")]
		[NodeInfo("临时变量 ", "修改临时变量String", -800)]
		public class ModifyTempValueString : LevelScriptActionBase
		{
			// Token: 0x06011314 RID: 70420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011314")]
			[Address(RVA = "0x9168A0", Offset = "0x9154A0", VA = "0x1809168A0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011315 RID: 70421 RVA: 0x00069EB8 File Offset: 0x000680B8
			[Token(Token = "0x6011315")]
			[Address(RVA = "0x916990", Offset = "0x915590", VA = "0x180916990", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011316 RID: 70422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011316")]
			[Address(RVA = "0x916A30", Offset = "0x915630", VA = "0x180916A30")]
			public ModifyTempValueString()
			{
			}

			// Token: 0x06011317 RID: 70423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011317")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011318 RID: 70424 RVA: 0x00069ED0 File Offset: 0x000680D0
			[Token(Token = "0x6011318")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013413 RID: 78867
			[Token(Token = "0x4013413")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public ParamOutput<string> targetKey;

			// Token: 0x04013414 RID: 78868
			[Token(Token = "0x4013414")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<string> newValue;

			// Token: 0x04013415 RID: 78869
			[Token(Token = "0x4013415")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013416 RID: 78870
			[Token(Token = "0x4013416")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013417 RID: 78871
			[Token(Token = "0x4013417")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200285B RID: 10331
		[Token(Token = "0x200285B")]
		[NodeInfo("关卡蓝图", "Split 2", -800)]
		public class Split2Action : LevelScriptActionBase
		{
			// Token: 0x06011319 RID: 70425 RVA: 0x00069EE8 File Offset: 0x000680E8
			[Token(Token = "0x6011319")]
			[Address(RVA = "0x91A850", Offset = "0x919450", VA = "0x18091A850", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x0601131A RID: 70426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601131A")]
			[Address(RVA = "0x91A8C0", Offset = "0x9194C0", VA = "0x18091A8C0")]
			public Split2Action()
			{
			}

			// Token: 0x0601131B RID: 70427 RVA: 0x00069F00 File Offset: 0x00068100
			[Token(Token = "0x601131B")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013418 RID: 78872
			[Token(Token = "0x4013418")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			[HideInInspector]
			public int _first;

			// Token: 0x04013419 RID: 78873
			[Token(Token = "0x4013419")]
			[FieldOffset(Offset = "0x5C")]
			[SerializeField]
			[HideInInspector]
			public int _second;

			// Token: 0x0401341A RID: 78874
			[Token(Token = "0x401341A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x0401341B RID: 78875
			[Token(Token = "0x401341B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200285C RID: 10332
		[Token(Token = "0x200285C")]
		[NodeInfo("时间相关 ", "等待数秒", -800)]
		public class WaitForSeconds : LevelScriptActionBase
		{
			// Token: 0x0601131C RID: 70428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601131C")]
			[Address(RVA = "0x91B370", Offset = "0x919F70", VA = "0x18091B370", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x0601131D RID: 70429 RVA: 0x00069F18 File Offset: 0x00068118
			[Token(Token = "0x601131D")]
			[Address(RVA = "0x91B450", Offset = "0x91A050", VA = "0x18091B450", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x0601131E RID: 70430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601131E")]
			[Address(RVA = "0x91B530", Offset = "0x91A130", VA = "0x18091B530")]
			public WaitForSeconds()
			{
			}

			// Token: 0x0601131F RID: 70431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601131F")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011320 RID: 70432 RVA: 0x00069F30 File Offset: 0x00068130
			[Token(Token = "0x6011320")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x0401341C RID: 78876
			[Token(Token = "0x401341C")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private Param<float> _seconds;

			// Token: 0x0401341D RID: 78877
			[Token(Token = "0x401341D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x0401341E RID: 78878
			[Token(Token = "0x401341E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x0401341F RID: 78879
			[Token(Token = "0x401341F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200285D RID: 10333
		[Token(Token = "0x200285D")]
		[NodeInfo("数据处理 ", "浮点型相加", -700)]
		public class GetResultAdditionFloatWithFloat : LevelScriptActionBase
		{
			// Token: 0x06011321 RID: 70433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011321")]
			[Address(RVA = "0x90DEE0", Offset = "0x90CAE0", VA = "0x18090DEE0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011322 RID: 70434 RVA: 0x00069F48 File Offset: 0x00068148
			[Token(Token = "0x6011322")]
			[Address(RVA = "0x90DFF0", Offset = "0x90CBF0", VA = "0x18090DFF0", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011323 RID: 70435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011323")]
			[Address(RVA = "0x90E170", Offset = "0x90CD70", VA = "0x18090E170")]
			public GetResultAdditionFloatWithFloat()
			{
			}

			// Token: 0x06011324 RID: 70436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011324")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011325 RID: 70437 RVA: 0x00069F60 File Offset: 0x00068160
			[Token(Token = "0x6011325")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013420 RID: 78880
			[Token(Token = "0x4013420")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<float> _inputIntegerFirst;

			// Token: 0x04013421 RID: 78881
			[Token(Token = "0x4013421")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<float> _inputIntegerSecond;

			// Token: 0x04013422 RID: 78882
			[Token(Token = "0x4013422")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public ParamOutput<float> _outputFloat;

			// Token: 0x04013423 RID: 78883
			[Token(Token = "0x4013423")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013424 RID: 78884
			[Token(Token = "0x4013424")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013425 RID: 78885
			[Token(Token = "0x4013425")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200285E RID: 10334
		[Token(Token = "0x200285E")]
		[NodeInfo("数据处理 ", "浮点型约束范围", -700)]
		public class GetResultFloatLimitWithRange : LevelScriptActionBase
		{
			// Token: 0x06011326 RID: 70438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011326")]
			[Address(RVA = "0x90E1D0", Offset = "0x90CDD0", VA = "0x18090E1D0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011327 RID: 70439 RVA: 0x00069F78 File Offset: 0x00068178
			[Token(Token = "0x6011327")]
			[Address(RVA = "0x90E2F0", Offset = "0x90CEF0", VA = "0x18090E2F0", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011328 RID: 70440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011328")]
			[Address(RVA = "0x90E430", Offset = "0x90D030", VA = "0x18090E430")]
			public GetResultFloatLimitWithRange()
			{
			}

			// Token: 0x06011329 RID: 70441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011329")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x0601132A RID: 70442 RVA: 0x00069F90 File Offset: 0x00068190
			[Token(Token = "0x601132A")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013426 RID: 78886
			[Token(Token = "0x4013426")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<float> _inputFloat;

			// Token: 0x04013427 RID: 78887
			[Token(Token = "0x4013427")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<float> _inputFloatLimitMin;

			// Token: 0x04013428 RID: 78888
			[Token(Token = "0x4013428")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public Param<float> _inputFloatLimitMax;

			// Token: 0x04013429 RID: 78889
			[Token(Token = "0x4013429")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			public ParamOutput<float> _outputLimitedFloat;

			// Token: 0x0401342A RID: 78890
			[Token(Token = "0x401342A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x0401342B RID: 78891
			[Token(Token = "0x401342B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x0401342C RID: 78892
			[Token(Token = "0x401342C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200285F RID: 10335
		[Token(Token = "0x200285F")]
		[NodeInfo("数据处理 ", "浮点型相乘", -700)]
		public class GetResultMultiplyFloatWithFloat : LevelScriptActionBase
		{
			// Token: 0x0601132B RID: 70443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601132B")]
			[Address(RVA = "0x90E490", Offset = "0x90D090", VA = "0x18090E490", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x0601132C RID: 70444 RVA: 0x00069FA8 File Offset: 0x000681A8
			[Token(Token = "0x601132C")]
			[Address(RVA = "0x90E5A0", Offset = "0x90D1A0", VA = "0x18090E5A0", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x0601132D RID: 70445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601132D")]
			[Address(RVA = "0x90E660", Offset = "0x90D260", VA = "0x18090E660")]
			public GetResultMultiplyFloatWithFloat()
			{
			}

			// Token: 0x0601132E RID: 70446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601132E")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x0601132F RID: 70447 RVA: 0x00069FC0 File Offset: 0x000681C0
			[Token(Token = "0x601132F")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x0401342D RID: 78893
			[Token(Token = "0x401342D")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<float> _inputIntegerFirst;

			// Token: 0x0401342E RID: 78894
			[Token(Token = "0x401342E")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<float> _inputIntegerSecond;

			// Token: 0x0401342F RID: 78895
			[Token(Token = "0x401342F")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public ParamOutput<float> _outputInteger;

			// Token: 0x04013430 RID: 78896
			[Token(Token = "0x4013430")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013431 RID: 78897
			[Token(Token = "0x4013431")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013432 RID: 78898
			[Token(Token = "0x4013432")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002860 RID: 10336
		[Token(Token = "0x2002860")]
		[NodeInfo("数据处理 ", "整型相乘", -700)]
		public class GetResultMultiplyIntWithInt : LevelScriptActionBase
		{
			// Token: 0x06011330 RID: 70448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011330")]
			[Address(RVA = "0x90E6C0", Offset = "0x90D2C0", VA = "0x18090E6C0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011331 RID: 70449 RVA: 0x00069FD8 File Offset: 0x000681D8
			[Token(Token = "0x6011331")]
			[Address(RVA = "0x90E7D0", Offset = "0x90D3D0", VA = "0x18090E7D0", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011332 RID: 70450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011332")]
			[Address(RVA = "0x90E890", Offset = "0x90D490", VA = "0x18090E890")]
			public GetResultMultiplyIntWithInt()
			{
			}

			// Token: 0x06011333 RID: 70451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011333")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011334 RID: 70452 RVA: 0x00069FF0 File Offset: 0x000681F0
			[Token(Token = "0x6011334")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013433 RID: 78899
			[Token(Token = "0x4013433")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<int> _inputIntegerFirst;

			// Token: 0x04013434 RID: 78900
			[Token(Token = "0x4013434")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<int> _inputIntegerSecond;

			// Token: 0x04013435 RID: 78901
			[Token(Token = "0x4013435")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public ParamOutput<int> _outputInteger;

			// Token: 0x04013436 RID: 78902
			[Token(Token = "0x4013436")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013437 RID: 78903
			[Token(Token = "0x4013437")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013438 RID: 78904
			[Token(Token = "0x4013438")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002861 RID: 10337
		[Token(Token = "0x2002861")]
		[NodeInfo("数据处理 ", "二维向量分解", -700)]
		public class SplitVector2 : LevelScriptActionBase
		{
			// Token: 0x06011335 RID: 70453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011335")]
			[Address(RVA = "0x91A920", Offset = "0x919520", VA = "0x18091A920", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011336 RID: 70454 RVA: 0x0006A008 File Offset: 0x00068208
			[Token(Token = "0x6011336")]
			[Address(RVA = "0x91AA30", Offset = "0x919630", VA = "0x18091AA30", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011337 RID: 70455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011337")]
			[Address(RVA = "0x91AAF0", Offset = "0x9196F0", VA = "0x18091AAF0")]
			public SplitVector2()
			{
			}

			// Token: 0x06011338 RID: 70456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011338")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011339 RID: 70457 RVA: 0x0006A020 File Offset: 0x00068220
			[Token(Token = "0x6011339")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013439 RID: 78905
			[Token(Token = "0x4013439")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<Vector2> inputVector2;

			// Token: 0x0401343A RID: 78906
			[Token(Token = "0x401343A")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public ParamOutput<float> outputX;

			// Token: 0x0401343B RID: 78907
			[Token(Token = "0x401343B")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public ParamOutput<float> outputY;

			// Token: 0x0401343C RID: 78908
			[Token(Token = "0x401343C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x0401343D RID: 78909
			[Token(Token = "0x401343D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x0401343E RID: 78910
			[Token(Token = "0x401343E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002862 RID: 10338
		[Token(Token = "0x2002862")]
		[NodeInfo("地块 ", "修改地块基本可部署性", -900)]
		public class ReWriteTileBuildableType : LevelScriptActionBase
		{
			// Token: 0x0601133A RID: 70458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601133A")]
			[Address(RVA = "0x919FF0", Offset = "0x918BF0", VA = "0x180919FF0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x0601133B RID: 70459 RVA: 0x0006A038 File Offset: 0x00068238
			[Token(Token = "0x601133B")]
			[Address(RVA = "0x91A0E0", Offset = "0x918CE0", VA = "0x18091A0E0", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x0601133C RID: 70460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601133C")]
			[Address(RVA = "0x91A320", Offset = "0x918F20", VA = "0x18091A320")]
			public ReWriteTileBuildableType()
			{
			}

			// Token: 0x0601133D RID: 70461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601133D")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x0601133E RID: 70462 RVA: 0x0006A050 File Offset: 0x00068250
			[Token(Token = "0x601133E")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x0401343F RID: 78911
			[Token(Token = "0x401343F")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<bool> _restoreTileOptions;

			// Token: 0x04013440 RID: 78912
			[Token(Token = "0x4013440")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<BuildableType> _buildableType;

			// Token: 0x04013441 RID: 78913
			[Token(Token = "0x4013441")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public Param<List<Vector2>> _tiles;

			// Token: 0x04013442 RID: 78914
			[Token(Token = "0x4013442")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013443 RID: 78915
			[Token(Token = "0x4013443")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013444 RID: 78916
			[Token(Token = "0x4013444")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002863 RID: 10339
		[Token(Token = "0x2002863")]
		[NodeInfo("数据转换 ", "整型转浮点型", -700)]
		public class TransformIntToFloat : LevelScriptActionBase
		{
			// Token: 0x0601133F RID: 70463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601133F")]
			[Address(RVA = "0x91AEE0", Offset = "0x919AE0", VA = "0x18091AEE0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011340 RID: 70464 RVA: 0x0006A068 File Offset: 0x00068268
			[Token(Token = "0x6011340")]
			[Address(RVA = "0x91AFD0", Offset = "0x919BD0", VA = "0x18091AFD0", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011341 RID: 70465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011341")]
			[Address(RVA = "0x91B070", Offset = "0x919C70", VA = "0x18091B070")]
			public TransformIntToFloat()
			{
			}

			// Token: 0x06011342 RID: 70466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011342")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011343 RID: 70467 RVA: 0x0006A080 File Offset: 0x00068280
			[Token(Token = "0x6011343")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013445 RID: 78917
			[Token(Token = "0x4013445")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public Param<int> _inputInteger;

			// Token: 0x04013446 RID: 78918
			[Token(Token = "0x4013446")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public ParamOutput<float> _outputFloat;

			// Token: 0x04013447 RID: 78919
			[Token(Token = "0x4013447")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013448 RID: 78920
			[Token(Token = "0x4013448")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x04013449 RID: 78921
			[Token(Token = "0x4013449")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002864 RID: 10340
		[Token(Token = "0x2002864")]
		[NodeInfo("Getter ", "获取Char阻挡数", -400)]
		public class GetCharacterBlockCnt : PureGetter<int>
		{
			// Token: 0x06011344 RID: 70468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011344")]
			[Address(RVA = "0x90CF80", Offset = "0x90BB80", VA = "0x18090CF80", Slot = "6")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011345 RID: 70469 RVA: 0x0006A098 File Offset: 0x00068298
			[Token(Token = "0x6011345")]
			[Address(RVA = "0x90D050", Offset = "0x90BC50", VA = "0x18090D050", Slot = "7")]
			public override int GetResult()
			{
				return 0;
			}

			// Token: 0x06011346 RID: 70470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011346")]
			[Address(RVA = "0x90D1D0", Offset = "0x90BDD0", VA = "0x18090D1D0")]
			public GetCharacterBlockCnt()
			{
			}

			// Token: 0x06011347 RID: 70471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011347")]
			[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x0401344A RID: 78922
			[Token(Token = "0x401344A")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Param<CharacterPtr> _characterPtr;

			// Token: 0x0401344B RID: 78923
			[Token(Token = "0x401344B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x0401344C RID: 78924
			[Token(Token = "0x401344C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x0401344D RID: 78925
			[Token(Token = "0x401344D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002865 RID: 10341
		[Token(Token = "0x2002865")]
		[NodeInfo("Getter ", "获取当前地图id", -400)]
		public class GetCurrentLevelId : PureGetter<string>
		{
			// Token: 0x06011348 RID: 70472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011348")]
			[Address(RVA = "0x90D240", Offset = "0x90BE40", VA = "0x18090D240", Slot = "7")]
			public override string GetResult()
			{
				return null;
			}

			// Token: 0x06011349 RID: 70473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011349")]
			[Address(RVA = "0x90D2D0", Offset = "0x90BED0", VA = "0x18090D2D0")]
			public GetCurrentLevelId()
			{
			}

			// Token: 0x0401344E RID: 78926
			[Token(Token = "0x401344E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x0401344F RID: 78927
			[Token(Token = "0x401344F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002866 RID: 10342
		[Token(Token = "0x2002866")]
		[NodeInfo("Getter ", "获取敌人id", -400)]
		public class GetEnemyId : PureGetter<string>
		{
			// Token: 0x0601134A RID: 70474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601134A")]
			[Address(RVA = "0x90D340", Offset = "0x90BF40", VA = "0x18090D340", Slot = "6")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x0601134B RID: 70475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601134B")]
			[Address(RVA = "0x90D410", Offset = "0x90C010", VA = "0x18090D410", Slot = "7")]
			public override string GetResult()
			{
				return null;
			}

			// Token: 0x0601134C RID: 70476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601134C")]
			[Address(RVA = "0x90D510", Offset = "0x90C110", VA = "0x18090D510")]
			public GetEnemyId()
			{
			}

			// Token: 0x0601134D RID: 70477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601134D")]
			[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x04013450 RID: 78928
			[Token(Token = "0x4013450")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Param<EnemyPtr> enemyPtr;

			// Token: 0x04013451 RID: 78929
			[Token(Token = "0x4013451")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013452 RID: 78930
			[Token(Token = "0x4013452")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x04013453 RID: 78931
			[Token(Token = "0x4013453")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002867 RID: 10343
		[Token(Token = "0x2002867")]
		[NodeInfo("Getter ", "根据Key从String数组中获取下标", -400)]
		public class GetIndexFromStringListViaKey : PureGetter<int>
		{
			// Token: 0x0601134E RID: 70478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601134E")]
			[Address(RVA = "0x90D870", Offset = "0x90C470", VA = "0x18090D870", Slot = "6")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x0601134F RID: 70479 RVA: 0x0006A0B0 File Offset: 0x000682B0
			[Token(Token = "0x601134F")]
			[Address(RVA = "0x90D940", Offset = "0x90C540", VA = "0x18090D940", Slot = "7")]
			public override int GetResult()
			{
				return 0;
			}

			// Token: 0x06011350 RID: 70480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011350")]
			[Address(RVA = "0x90DB30", Offset = "0x90C730", VA = "0x18090DB30")]
			public GetIndexFromStringListViaKey()
			{
			}

			// Token: 0x06011351 RID: 70481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011351")]
			[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x04013454 RID: 78932
			[Token(Token = "0x4013454")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Param<string> _key;

			// Token: 0x04013455 RID: 78933
			[Token(Token = "0x4013455")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			public string _stringListName;

			// Token: 0x04013456 RID: 78934
			[Token(Token = "0x4013456")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013457 RID: 78935
			[Token(Token = "0x4013457")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x04013458 RID: 78936
			[Token(Token = "0x4013458")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002868 RID: 10344
		[Token(Token = "0x2002868")]
		[NodeInfo("Getter ", "根据下标从Int数组中获取值", -400)]
		public class GetIntegerFromListViaIndex : PureGetter<int>
		{
			// Token: 0x06011352 RID: 70482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011352")]
			[Address(RVA = "0x90DBD0", Offset = "0x90C7D0", VA = "0x18090DBD0", Slot = "6")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011353 RID: 70483 RVA: 0x0006A0C8 File Offset: 0x000682C8
			[Token(Token = "0x6011353")]
			[Address(RVA = "0x90DCA0", Offset = "0x90C8A0", VA = "0x18090DCA0", Slot = "7")]
			public override int GetResult()
			{
				return 0;
			}

			// Token: 0x06011354 RID: 70484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011354")]
			[Address(RVA = "0x90DE40", Offset = "0x90CA40", VA = "0x18090DE40")]
			public GetIntegerFromListViaIndex()
			{
			}

			// Token: 0x06011355 RID: 70485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011355")]
			[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x04013459 RID: 78937
			[Token(Token = "0x4013459")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Param<int> _index;

			// Token: 0x0401345A RID: 78938
			[Token(Token = "0x401345A")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			public string _integerListName;

			// Token: 0x0401345B RID: 78939
			[Token(Token = "0x401345B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x0401345C RID: 78940
			[Token(Token = "0x401345C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x0401345D RID: 78941
			[Token(Token = "0x401345D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002869 RID: 10345
		[Token(Token = "0x2002869")]
		[NodeInfo("Getter ", "根据Key获取临时数据值Float", -400)]
		public class GetTempValueFloat : PureGetter<float>
		{
			// Token: 0x06011356 RID: 70486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011356")]
			[Address(RVA = "0x90E8F0", Offset = "0x90D4F0", VA = "0x18090E8F0", Slot = "6")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x06011357 RID: 70487 RVA: 0x0006A0E0 File Offset: 0x000682E0
			[Token(Token = "0x6011357")]
			[Address(RVA = "0x90E9C0", Offset = "0x90D5C0", VA = "0x18090E9C0", Slot = "7")]
			public override float GetResult()
			{
				return 0f;
			}

			// Token: 0x06011358 RID: 70488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011358")]
			[Address(RVA = "0x90EB40", Offset = "0x90D740", VA = "0x18090EB40")]
			public GetTempValueFloat()
			{
			}

			// Token: 0x06011359 RID: 70489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011359")]
			[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x0401345E RID: 78942
			[Token(Token = "0x401345E")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Param<string> key;

			// Token: 0x0401345F RID: 78943
			[Token(Token = "0x401345F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013460 RID: 78944
			[Token(Token = "0x4013460")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x04013461 RID: 78945
			[Token(Token = "0x4013461")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200286A RID: 10346
		[Token(Token = "0x200286A")]
		[NodeInfo("Getter ", "根据Key获取临时数据值Int", -400)]
		public class GetTempValueInt : PureGetter<int>
		{
			// Token: 0x0601135A RID: 70490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601135A")]
			[Address(RVA = "0x90EBB0", Offset = "0x90D7B0", VA = "0x18090EBB0", Slot = "6")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x0601135B RID: 70491 RVA: 0x0006A0F8 File Offset: 0x000682F8
			[Token(Token = "0x601135B")]
			[Address(RVA = "0x90EC80", Offset = "0x90D880", VA = "0x18090EC80", Slot = "7")]
			public override int GetResult()
			{
				return 0;
			}

			// Token: 0x0601135C RID: 70492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601135C")]
			[Address(RVA = "0x90EE00", Offset = "0x90DA00", VA = "0x18090EE00")]
			public GetTempValueInt()
			{
			}

			// Token: 0x0601135D RID: 70493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601135D")]
			[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x04013462 RID: 78946
			[Token(Token = "0x4013462")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Param<string> key;

			// Token: 0x04013463 RID: 78947
			[Token(Token = "0x4013463")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013464 RID: 78948
			[Token(Token = "0x4013464")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetResult;

			// Token: 0x04013465 RID: 78949
			[Token(Token = "0x4013465")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200286B RID: 10347
		[Token(Token = "0x200286B")]
		[NodeInfo("临时变量 ", "修改临时变量Float", -800)]
		public class ModifyTempValueFloat : LevelScriptActionBase
		{
			// Token: 0x0601135E RID: 70494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601135E")]
			[Address(RVA = "0x9165A0", Offset = "0x9151A0", VA = "0x1809165A0", Slot = "10")]
			public override void CollectParams(ref List<IParamBindable> paramList)
			{
			}

			// Token: 0x0601135F RID: 70495 RVA: 0x0006A110 File Offset: 0x00068310
			[Token(Token = "0x601135F")]
			[Address(RVA = "0x916680", Offset = "0x915280", VA = "0x180916680", Slot = "6")]
			public override bool Execute()
			{
				return default(bool);
			}

			// Token: 0x06011360 RID: 70496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011360")]
			[Address(RVA = "0x916810", Offset = "0x915410", VA = "0x180916810")]
			public ModifyTempValueFloat()
			{
			}

			// Token: 0x06011361 RID: 70497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011361")]
			[Address(RVA = "0x90E0B0", Offset = "0x90CCB0", VA = "0x18090E0B0")]
			private void <>xLuaBaseProxy_CollectParams(ref List<IParamBindable> P0)
			{
			}

			// Token: 0x06011362 RID: 70498 RVA: 0x0006A128 File Offset: 0x00068328
			[Token(Token = "0x6011362")]
			[Address(RVA = "0x90E110", Offset = "0x90CD10", VA = "0x18090E110")]
			private bool <>xLuaBaseProxy_Execute()
			{
				return default(bool);
			}

			// Token: 0x04013466 RID: 78950
			[Token(Token = "0x4013466")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public string _targetKey;

			// Token: 0x04013467 RID: 78951
			[Token(Token = "0x4013467")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public Param<float> _modifyValue;

			// Token: 0x04013468 RID: 78952
			[Token(Token = "0x4013468")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectParams;

			// Token: 0x04013469 RID: 78953
			[Token(Token = "0x4013469")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x0401346A RID: 78954
			[Token(Token = "0x401346A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
