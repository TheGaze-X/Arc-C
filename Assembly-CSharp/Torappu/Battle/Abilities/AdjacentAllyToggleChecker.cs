using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B4F RID: 11087
	[Token(Token = "0x2002B4F")]
	public class AdjacentAllyToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x060129C7 RID: 76231 RVA: 0x00071F58 File Offset: 0x00070158
		[Token(Token = "0x17002901")]
		protected bool isManhatten
		{
			[Token(Token = "0x60129C7")]
			[Address(RVA = "0xA9A2A0", Offset = "0xA98EA0", VA = "0x180A9A2A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x060129C8 RID: 76232 RVA: 0x00071F70 File Offset: 0x00070170
		[Token(Token = "0x17002902")]
		protected bool isSquare
		{
			[Token(Token = "0x60129C8")]
			[Address(RVA = "0xA9A300", Offset = "0xA98F00", VA = "0x180A9A300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x060129C9 RID: 76233 RVA: 0x00071F88 File Offset: 0x00070188
		[Token(Token = "0x17002903")]
		protected bool isInRange
		{
			[Token(Token = "0x60129C9")]
			[Address(RVA = "0xA9A240", Offset = "0xA98E40", VA = "0x180A9A240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x060129CA RID: 76234 RVA: 0x00071FA0 File Offset: 0x000701A0
		[Token(Token = "0x17002904")]
		protected bool needProfessionMask
		{
			[Token(Token = "0x60129CA")]
			[Address(RVA = "0xA9A3C0", Offset = "0xA98FC0", VA = "0x180A9A3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x060129CB RID: 76235 RVA: 0x00071FB8 File Offset: 0x000701B8
		[Token(Token = "0x17002905")]
		protected bool needBuildableType
		{
			[Token(Token = "0x60129CB")]
			[Address(RVA = "0xA9A360", Offset = "0xA98F60", VA = "0x180A9A360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x060129CC RID: 76236 RVA: 0x00071FD0 File Offset: 0x000701D0
		[Token(Token = "0x17002906")]
		protected bool forceCheckSide
		{
			[Token(Token = "0x60129CC")]
			[Address(RVA = "0xA9A1E0", Offset = "0xA98DE0", VA = "0x180A9A1E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060129CD RID: 76237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129CD")]
		[Address(RVA = "0xA99270", Offset = "0xA97E70", VA = "0x180A99270", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129CE RID: 76238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129CE")]
		[Address(RVA = "0xA992D0", Offset = "0xA97ED0", VA = "0x180A992D0", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x060129CF RID: 76239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129CF")]
		[Address(RVA = "0xA994F0", Offset = "0xA980F0", VA = "0x180A994F0", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x060129D0 RID: 76240 RVA: 0x00071FE8 File Offset: 0x000701E8
		[Token(Token = "0x60129D0")]
		[Address(RVA = "0xA99200", Offset = "0xA97E00", VA = "0x180A99200", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x060129D1 RID: 76241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129D1")]
		[Address(RVA = "0xA99FA0", Offset = "0xA98BA0", VA = "0x180A99FA0")]
		private void _OnAdjacentChanged(object arg)
		{
		}

		// Token: 0x060129D2 RID: 76242 RVA: 0x00072000 File Offset: 0x00070200
		[Token(Token = "0x60129D2")]
		[Address(RVA = "0xA99710", Offset = "0xA98310", VA = "0x180A99710")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x060129D3 RID: 76243 RVA: 0x00072018 File Offset: 0x00070218
		[Token(Token = "0x60129D3")]
		[Address(RVA = "0xA99A00", Offset = "0xA98600", VA = "0x180A99A00")]
		private bool _CheckDetail(Unit other)
		{
			return default(bool);
		}

		// Token: 0x060129D4 RID: 76244 RVA: 0x00072030 File Offset: 0x00070230
		[Token(Token = "0x60129D4")]
		[Address(RVA = "0xA99BC0", Offset = "0xA987C0", VA = "0x180A99BC0")]
		private bool _CheckDistance(Unit other)
		{
			return default(bool);
		}

		// Token: 0x060129D5 RID: 76245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129D5")]
		[Address(RVA = "0xA9A100", Offset = "0xA98D00", VA = "0x180A9A100")]
		public AdjacentAllyToggleChecker()
		{
		}

		// Token: 0x060129D6 RID: 76246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129D6")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x060129D7 RID: 76247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129D7")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x0401505A RID: 86106
		[Token(Token = "0x401505A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AdjacentAllyToggleChecker.DistanceType _distanceType;

		// Token: 0x0401505B RID: 86107
		[Token(Token = "0x401505B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Inspect("isManhatten")]
		private int _minManhattan;

		// Token: 0x0401505C RID: 86108
		[Token(Token = "0x401505C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("isManhatten")]
		private int _maxManhattan;

		// Token: 0x0401505D RID: 86109
		[Token(Token = "0x401505D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Inspect("isSquare")]
		private int _minSquareDistance;

		// Token: 0x0401505E RID: 86110
		[Token(Token = "0x401505E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Inspect("isSquare")]
		private int _maxSquareDistance;

		// Token: 0x0401505F RID: 86111
		[Token(Token = "0x401505F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Inspect("isInRange")]
		private string _rangeId;

		// Token: 0x04015060 RID: 86112
		[Token(Token = "0x4015060")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AdjacentAllyToggleChecker.CheckType _checkType;

		// Token: 0x04015061 RID: 86113
		[Token(Token = "0x4015061")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _needProfessionMask;

		// Token: 0x04015062 RID: 86114
		[Token(Token = "0x4015062")]
		[FieldOffset(Offset = "0x48")]
		[Enum(true, EnumDisplay.Checkbox)]
		[Inspect("needProfessionMask")]
		public ProfessionCategory _professionMask;

		// Token: 0x04015063 RID: 86115
		[Token(Token = "0x4015063")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _needBuildableType;

		// Token: 0x04015064 RID: 86116
		[Token(Token = "0x4015064")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Inspect("needBuildableType")]
		public BuildableType _buildableType;

		// Token: 0x04015065 RID: 86117
		[Token(Token = "0x4015065")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _forceCheckSide;

		// Token: 0x04015066 RID: 86118
		[Token(Token = "0x4015066")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Inspect("forceCheckSide")]
		private SideType _checkSide;

		// Token: 0x04015067 RID: 86119
		[Token(Token = "0x4015067")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Tooltip("Reverse the result of toggle check")]
		private bool _reverseToggle;

		// Token: 0x04015068 RID: 86120
		[Token(Token = "0x4015068")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isManhatten;

		// Token: 0x04015069 RID: 86121
		[Token(Token = "0x4015069")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSquare;

		// Token: 0x0401506A RID: 86122
		[Token(Token = "0x401506A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isInRange;

		// Token: 0x0401506B RID: 86123
		[Token(Token = "0x401506B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_needProfessionMask;

		// Token: 0x0401506C RID: 86124
		[Token(Token = "0x401506C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_needBuildableType;

		// Token: 0x0401506D RID: 86125
		[Token(Token = "0x401506D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_forceCheckSide;

		// Token: 0x0401506E RID: 86126
		[Token(Token = "0x401506E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401506F RID: 86127
		[Token(Token = "0x401506F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04015070 RID: 86128
		[Token(Token = "0x4015070")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015071 RID: 86129
		[Token(Token = "0x4015071")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015072 RID: 86130
		[Token(Token = "0x4015072")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnAdjacentChanged;

		// Token: 0x04015073 RID: 86131
		[Token(Token = "0x4015073")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015074 RID: 86132
		[Token(Token = "0x4015074")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckDetail;

		// Token: 0x04015075 RID: 86133
		[Token(Token = "0x4015075")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckDistance;

		// Token: 0x04015076 RID: 86134
		[Token(Token = "0x4015076")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B50 RID: 11088
		[Token(Token = "0x2002B50")]
		public enum CheckType
		{
			// Token: 0x04015078 RID: 86136
			[Token(Token = "0x4015078")]
			AT_LEAST_ONE,
			// Token: 0x04015079 RID: 86137
			[Token(Token = "0x4015079")]
			ALL
		}

		// Token: 0x02002B51 RID: 11089
		[Token(Token = "0x2002B51")]
		public enum DistanceType
		{
			// Token: 0x0401507B RID: 86139
			[Token(Token = "0x401507B")]
			MANHATTEN,
			// Token: 0x0401507C RID: 86140
			[Token(Token = "0x401507C")]
			SQUARE,
			// Token: 0x0401507D RID: 86141
			[Token(Token = "0x401507D")]
			INRANGE
		}
	}
}
