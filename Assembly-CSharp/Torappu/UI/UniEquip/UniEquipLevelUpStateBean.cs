using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C36 RID: 15414
	[Token(Token = "0x2003C36")]
	public class UniEquipLevelUpStateBean : IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x060181A9 RID: 98729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181A9")]
		[Address(RVA = "0x1092840", Offset = "0x1091440", VA = "0x181092840")]
		public void LoadData(UniEquipLevelUpStateBean.Param param)
		{
		}

		// Token: 0x060181AA RID: 98730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181AA")]
		[Address(RVA = "0x1093050", Offset = "0x1091C50", VA = "0x181093050")]
		public void RefreshRequiresData()
		{
		}

		// Token: 0x060181AB RID: 98731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181AB")]
		[Address(RVA = "0x1092CD0", Offset = "0x10918D0", VA = "0x181092CD0")]
		public void ReLoadData()
		{
		}

		// Token: 0x060181AC RID: 98732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60181AC")]
		[Address(RVA = "0x1092730", Offset = "0x1091330", VA = "0x181092730")]
		public string CheckLevelUpRequirements()
		{
			return null;
		}

		// Token: 0x060181AD RID: 98733 RVA: 0x000995A0 File Offset: 0x000977A0
		[Token(Token = "0x60181AD")]
		[Address(RVA = "0x1093150", Offset = "0x1091D50", VA = "0x181093150")]
		public bool TrySelectLevel(int selectLevel)
		{
			return default(bool);
		}

		// Token: 0x060181AE RID: 98734 RVA: 0x000995B8 File Offset: 0x000977B8
		[Token(Token = "0x60181AE")]
		[Address(RVA = "0x1093250", Offset = "0x1091E50", VA = "0x181093250")]
		private static bool _CheckEquipRequirementsSatisfied(List<RequireViewModel> requireViewModels, out string msg)
		{
			return default(bool);
		}

		// Token: 0x060181AF RID: 98735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181AF")]
		[Address(RVA = "0x1093430", Offset = "0x1092030", VA = "0x181093430")]
		public UniEquipLevelUpStateBean()
		{
		}

		// Token: 0x0401D452 RID: 119890
		[Token(Token = "0x401D452")]
		[FieldOffset(Offset = "0x10")]
		public LevelUpViewProperty levelUpViewProperty;

		// Token: 0x0401D453 RID: 119891
		[Token(Token = "0x401D453")]
		[FieldOffset(Offset = "0x18")]
		public UniEquipData uniEquipData;

		// Token: 0x0401D454 RID: 119892
		[Token(Token = "0x401D454")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D455 RID: 119893
		[Token(Token = "0x401D455")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshRequiresData;

		// Token: 0x0401D456 RID: 119894
		[Token(Token = "0x401D456")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReLoadData;

		// Token: 0x0401D457 RID: 119895
		[Token(Token = "0x401D457")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckLevelUpRequirements;

		// Token: 0x0401D458 RID: 119896
		[Token(Token = "0x401D458")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TrySelectLevel;

		// Token: 0x0401D459 RID: 119897
		[Token(Token = "0x401D459")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckEquipRequirementsSatisfied;

		// Token: 0x0401D45A RID: 119898
		[Token(Token = "0x401D45A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C37 RID: 15415
		[Token(Token = "0x2003C37")]
		public struct Param
		{
			// Token: 0x0401D45B RID: 119899
			[Token(Token = "0x401D45B")]
			[FieldOffset(Offset = "0x0")]
			public int charInstId;

			// Token: 0x0401D45C RID: 119900
			[Token(Token = "0x401D45C")]
			[FieldOffset(Offset = "0x8")]
			public string templateId;

			// Token: 0x0401D45D RID: 119901
			[Token(Token = "0x401D45D")]
			[FieldOffset(Offset = "0x10")]
			public CharQuery charQuery;

			// Token: 0x0401D45E RID: 119902
			[Token(Token = "0x401D45E")]
			[FieldOffset(Offset = "0x28")]
			public string equipId;
		}
	}
}
