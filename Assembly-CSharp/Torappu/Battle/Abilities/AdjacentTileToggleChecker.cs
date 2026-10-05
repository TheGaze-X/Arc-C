using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B52 RID: 11090
	[Token(Token = "0x2002B52")]
	public class AdjacentTileToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x060129D8 RID: 76248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129D8")]
		[Address(RVA = "0xA9A650", Offset = "0xA99250", VA = "0x180A9A650", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129D9 RID: 76249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129D9")]
		[Address(RVA = "0xA9A700", Offset = "0xA99300", VA = "0x180A9A700", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x060129DA RID: 76250 RVA: 0x00072048 File Offset: 0x00070248
		[Token(Token = "0x60129DA")]
		[Address(RVA = "0xA9A420", Offset = "0xA99020", VA = "0x180A9A420", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x060129DB RID: 76251 RVA: 0x00072060 File Offset: 0x00070260
		[Token(Token = "0x60129DB")]
		[Address(RVA = "0xA9A760", Offset = "0xA99360", VA = "0x180A9A760")]
		private bool _CheckCondition(GridPosition pos, AdjacentTileToggleChecker.TileCondition cond)
		{
			return default(bool);
		}

		// Token: 0x060129DC RID: 76252 RVA: 0x00072078 File Offset: 0x00070278
		[Token(Token = "0x60129DC")]
		[Address(RVA = "0xA9A8C0", Offset = "0xA994C0", VA = "0x180A9A8C0")]
		private GridPosition _ObjectToWorldPosition(Entity obj, GridPosition pos)
		{
			return default(GridPosition);
		}

		// Token: 0x060129DD RID: 76253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129DD")]
		[Address(RVA = "0xA9AA00", Offset = "0xA99600", VA = "0x180A9AA00")]
		public AdjacentTileToggleChecker()
		{
		}

		// Token: 0x060129DE RID: 76254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129DE")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x0401507E RID: 86142
		[Token(Token = "0x401507E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridPosition[] posList;

		// Token: 0x0401507F RID: 86143
		[Token(Token = "0x401507F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isLocalPosition;

		// Token: 0x04015080 RID: 86144
		[Token(Token = "0x4015080")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AdjacentTileToggleChecker.TileCondition _condition;

		// Token: 0x04015081 RID: 86145
		[Token(Token = "0x4015081")]
		[FieldOffset(Offset = "0x34")]
		private int m_minCnt;

		// Token: 0x04015082 RID: 86146
		[Token(Token = "0x4015082")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015083 RID: 86147
		[Token(Token = "0x4015083")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015084 RID: 86148
		[Token(Token = "0x4015084")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015085 RID: 86149
		[Token(Token = "0x4015085")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015086 RID: 86150
		[Token(Token = "0x4015086")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ObjectToWorldPosition;

		// Token: 0x04015087 RID: 86151
		[Token(Token = "0x4015087")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B53 RID: 11091
		[Token(Token = "0x2002B53")]
		[Serializable]
		public struct TileCondition
		{
			// Token: 0x04015088 RID: 86152
			[Token(Token = "0x4015088")]
			[FieldOffset(Offset = "0x0")]
			public TileData.HeightType heightType;

			// Token: 0x04015089 RID: 86153
			[Token(Token = "0x4015089")]
			[FieldOffset(Offset = "0x4")]
			public BuildableType _buildableType;
		}
	}
}
