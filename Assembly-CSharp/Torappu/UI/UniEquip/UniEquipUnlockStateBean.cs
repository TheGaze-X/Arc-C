using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C46 RID: 15430
	[Token(Token = "0x2003C46")]
	public class UniEquipUnlockStateBean : IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x060181EE RID: 98798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181EE")]
		[Address(RVA = "0x109FDF0", Offset = "0x109E9F0", VA = "0x18109FDF0")]
		public void LoadData(UniEquipUnlockStateBean.Param param)
		{
		}

		// Token: 0x060181EF RID: 98799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181EF")]
		[Address(RVA = "0x10A03F0", Offset = "0x109EFF0", VA = "0x1810A03F0")]
		public void RefreshData()
		{
		}

		// Token: 0x060181F0 RID: 98800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60181F0")]
		[Address(RVA = "0x109FC70", Offset = "0x109E870", VA = "0x18109FC70")]
		public string CheckUnlockRequirements()
		{
			return null;
		}

		// Token: 0x060181F1 RID: 98801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181F1")]
		[Address(RVA = "0x10A0900", Offset = "0x109F500", VA = "0x1810A0900")]
		private void _GeneEquipData(CharQuery charQuery, string equipId)
		{
		}

		// Token: 0x060181F2 RID: 98802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181F2")]
		[Address(RVA = "0x10A04F0", Offset = "0x109F0F0", VA = "0x1810A04F0")]
		private void _CheckEquipMissionRequirementsSatisfied(UniEquipUnlockViewModel viewModel, out string msg)
		{
		}

		// Token: 0x060181F3 RID: 98803 RVA: 0x00099738 File Offset: 0x00097938
		[Token(Token = "0x60181F3")]
		[Address(RVA = "0x10A0700", Offset = "0x109F300", VA = "0x1810A0700")]
		private static bool _CheckEquipRequirementsSatisfied(List<RequireViewModel> requireViewModels, out string msg)
		{
			return default(bool);
		}

		// Token: 0x060181F4 RID: 98804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181F4")]
		[Address(RVA = "0x10A0B00", Offset = "0x109F700", VA = "0x1810A0B00")]
		public UniEquipUnlockStateBean()
		{
		}

		// Token: 0x0401D4F1 RID: 120049
		[Token(Token = "0x401D4F1")]
		[FieldOffset(Offset = "0x10")]
		public UnlockViewProperty unlockViewProperty;

		// Token: 0x0401D4F2 RID: 120050
		[Token(Token = "0x401D4F2")]
		[FieldOffset(Offset = "0x18")]
		public UniEquipData uniEquipData;

		// Token: 0x0401D4F3 RID: 120051
		[Token(Token = "0x401D4F3")]
		[FieldOffset(Offset = "0x20")]
		public List<UniEquipMissionData> uniEquipMissionList;

		// Token: 0x0401D4F4 RID: 120052
		[Token(Token = "0x401D4F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D4F5 RID: 120053
		[Token(Token = "0x401D4F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401D4F6 RID: 120054
		[Token(Token = "0x401D4F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckUnlockRequirements;

		// Token: 0x0401D4F7 RID: 120055
		[Token(Token = "0x401D4F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GeneEquipData;

		// Token: 0x0401D4F8 RID: 120056
		[Token(Token = "0x401D4F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckEquipMissionRequirementsSatisfied;

		// Token: 0x0401D4F9 RID: 120057
		[Token(Token = "0x401D4F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckEquipRequirementsSatisfied;

		// Token: 0x0401D4FA RID: 120058
		[Token(Token = "0x401D4FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C47 RID: 15431
		[Token(Token = "0x2003C47")]
		public struct Param
		{
			// Token: 0x0401D4FB RID: 120059
			[Token(Token = "0x401D4FB")]
			[FieldOffset(Offset = "0x0")]
			public int charInstId;

			// Token: 0x0401D4FC RID: 120060
			[Token(Token = "0x401D4FC")]
			[FieldOffset(Offset = "0x8")]
			public string templateId;

			// Token: 0x0401D4FD RID: 120061
			[Token(Token = "0x401D4FD")]
			[FieldOffset(Offset = "0x10")]
			public CharQuery charQuery;

			// Token: 0x0401D4FE RID: 120062
			[Token(Token = "0x401D4FE")]
			[FieldOffset(Offset = "0x28")]
			public string equipId;

			// Token: 0x0401D4FF RID: 120063
			[Token(Token = "0x401D4FF")]
			[FieldOffset(Offset = "0x30")]
			public string subProfessionId;
		}
	}
}
