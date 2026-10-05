using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CE8 RID: 23784
	[Token(Token = "0x2005CE8")]
	public class TacticalBuffModel : IHotfixable
	{
		// Token: 0x060226F7 RID: 141047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226F7")]
		[Address(RVA = "0x1CE1E90", Offset = "0x1CE0A90", VA = "0x181CE1E90")]
		public TacticalBuffModel(ProfessionCategory profession, List<ClimbTowerTacticalBuffData> buffList, bool hasTowerPass)
		{
		}

		// Token: 0x060226F8 RID: 141048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226F8")]
		[Address(RVA = "0x1CE1C80", Offset = "0x1CE0880", VA = "0x181CE1C80")]
		public void SelectBuff(string tacticalId)
		{
		}

		// Token: 0x060226F9 RID: 141049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226F9")]
		[Address(RVA = "0x1CE1E00", Offset = "0x1CE0A00", VA = "0x181CE1E00")]
		public void ToggleBuff()
		{
		}

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x060226FA RID: 141050 RVA: 0x000BD6D8 File Offset: 0x000BB8D8
		[Token(Token = "0x170050F9")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x60226FA")]
			[Address(RVA = "0x1CE23E0", Offset = "0x1CE0FE0", VA = "0x181CE23E0")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x060226FB RID: 141051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050FA")]
		public List<TacticalBuffItemModel> buffList
		{
			[Token(Token = "0x60226FB")]
			[Address(RVA = "0x1CE20F0", Offset = "0x1CE0CF0", VA = "0x181CE20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x060226FC RID: 141052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050FB")]
		public string currentBuffId
		{
			[Token(Token = "0x60226FC")]
			[Address(RVA = "0x1CE2150", Offset = "0x1CE0D50", VA = "0x181CE2150")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x060226FD RID: 141053 RVA: 0x000BD6F0 File Offset: 0x000BB8F0
		[Token(Token = "0x170050FC")]
		public int currentIdx
		{
			[Token(Token = "0x60226FD")]
			[Address(RVA = "0x1CE2320", Offset = "0x1CE0F20", VA = "0x181CE2320")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x060226FE RID: 141054 RVA: 0x000BD708 File Offset: 0x000BB908
		[Token(Token = "0x170050FD")]
		public bool isToggle
		{
			[Token(Token = "0x60226FE")]
			[Address(RVA = "0x1CE2380", Offset = "0x1CE0F80", VA = "0x181CE2380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060226FF RID: 141055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60226FF")]
		[Address(RVA = "0x1CE1BC0", Offset = "0x1CE07C0", VA = "0x181CE1BC0")]
		public string GetProfessionIconName()
		{
			return null;
		}

		// Token: 0x06022700 RID: 141056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022700")]
		[Address(RVA = "0x1CE1AC0", Offset = "0x1CE06C0", VA = "0x181CE1AC0")]
		public string GetCurrentDesc()
		{
			return null;
		}

		// Token: 0x06022701 RID: 141057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022701")]
		[Address(RVA = "0x1CE1960", Offset = "0x1CE0560", VA = "0x181CE1960")]
		public string GetCurrentBuffName()
		{
			return null;
		}

		// Token: 0x0402F540 RID: 193856
		[Token(Token = "0x402F540")]
		[FieldOffset(Offset = "0x10")]
		private ProfessionCategory m_profession;

		// Token: 0x0402F541 RID: 193857
		[Token(Token = "0x402F541")]
		[FieldOffset(Offset = "0x18")]
		private List<TacticalBuffItemModel> m_buffItemList;

		// Token: 0x0402F542 RID: 193858
		[Token(Token = "0x402F542")]
		[FieldOffset(Offset = "0x20")]
		private int m_selectIdx;

		// Token: 0x0402F543 RID: 193859
		[Token(Token = "0x402F543")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402F544 RID: 193860
		[Token(Token = "0x402F544")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectBuff;

		// Token: 0x0402F545 RID: 193861
		[Token(Token = "0x402F545")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToggleBuff;

		// Token: 0x0402F546 RID: 193862
		[Token(Token = "0x402F546")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x0402F547 RID: 193863
		[Token(Token = "0x402F547")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_buffList;

		// Token: 0x0402F548 RID: 193864
		[Token(Token = "0x402F548")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentBuffId;

		// Token: 0x0402F549 RID: 193865
		[Token(Token = "0x402F549")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_currentIdx;

		// Token: 0x0402F54A RID: 193866
		[Token(Token = "0x402F54A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isToggle;

		// Token: 0x0402F54B RID: 193867
		[Token(Token = "0x402F54B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProfessionIconName;

		// Token: 0x0402F54C RID: 193868
		[Token(Token = "0x402F54C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetCurrentDesc;

		// Token: 0x0402F54D RID: 193869
		[Token(Token = "0x402F54D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCurrentBuffName;
	}
}
