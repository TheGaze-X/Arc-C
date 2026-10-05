using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Mission;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007182 RID: 29058
	[Token(Token = "0x2007182")]
	public class Act9D0MissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x1700619D RID: 24989
		// (get) Token: 0x060293F4 RID: 168948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700619D")]
		public List<SubMissionViewModel> subMissionList
		{
			[Token(Token = "0x60293F4")]
			[Address(RVA = "0x249B0F0", Offset = "0x2499CF0", VA = "0x18249B0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700619E RID: 24990
		// (get) Token: 0x060293F5 RID: 168949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700619E")]
		public List<MissionViewModel> notSubMissionList
		{
			[Token(Token = "0x60293F5")]
			[Address(RVA = "0x249AF20", Offset = "0x2499B20", VA = "0x18249AF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700619F RID: 24991
		// (get) Token: 0x060293F6 RID: 168950 RVA: 0x000D4D48 File Offset: 0x000D2F48
		// (set) Token: 0x060293F7 RID: 168951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700619F")]
		public int completedMissionCount
		{
			[Token(Token = "0x60293F6")]
			[Address(RVA = "0x249ADF0", Offset = "0x24999F0", VA = "0x18249ADF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60293F7")]
			[Address(RVA = "0x249B310", Offset = "0x2499F10", VA = "0x18249B310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061A0 RID: 24992
		// (get) Token: 0x060293F8 RID: 168952 RVA: 0x000D4D60 File Offset: 0x000D2F60
		[Token(Token = "0x170061A0")]
		public int missionCount
		{
			[Token(Token = "0x60293F8")]
			[Address(RVA = "0x249AEB0", Offset = "0x2499AB0", VA = "0x18249AEB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170061A1 RID: 24993
		// (get) Token: 0x060293F9 RID: 168953 RVA: 0x000D4D78 File Offset: 0x000D2F78
		[Token(Token = "0x170061A1")]
		public bool hasMissionCanClaim
		{
			[Token(Token = "0x60293F9")]
			[Address(RVA = "0x249AE50", Offset = "0x2499A50", VA = "0x18249AE50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060293FA RID: 168954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293FA")]
		[Address(RVA = "0x249A5D0", Offset = "0x24991D0", VA = "0x18249A5D0")]
		public void LoadData()
		{
		}

		// Token: 0x060293FB RID: 168955 RVA: 0x000D4D90 File Offset: 0x000D2F90
		[Token(Token = "0x60293FB")]
		[Address(RVA = "0x249AB40", Offset = "0x2499740", VA = "0x18249AB40")]
		private bool _CheckHasMissionCanClaim()
		{
			return default(bool);
		}

		// Token: 0x060293FC RID: 168956 RVA: 0x000D4DA8 File Offset: 0x000D2FA8
		[Token(Token = "0x60293FC")]
		[Address(RVA = "0x249AC20", Offset = "0x2499820", VA = "0x18249AC20")]
		private int _CompareMission(MissionViewModel lhs, MissionViewModel rhs)
		{
			return 0;
		}

		// Token: 0x060293FD RID: 168957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293FD")]
		[Address(RVA = "0x249AD40", Offset = "0x2499940", VA = "0x18249AD40")]
		public Act9D0MissionStateBean()
		{
		}

		// Token: 0x0403AE97 RID: 241303
		[Token(Token = "0x403AE97")]
		[FieldOffset(Offset = "0x10")]
		public List<MissionViewModel> missionModelList;

		// Token: 0x0403AE99 RID: 241305
		[Token(Token = "0x403AE99")]
		[FieldOffset(Offset = "0x1C")]
		private bool _hasMissionCanClaim;

		// Token: 0x0403AE9A RID: 241306
		[Token(Token = "0x403AE9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_subMissionList;

		// Token: 0x0403AE9B RID: 241307
		[Token(Token = "0x403AE9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_notSubMissionList;

		// Token: 0x0403AE9C RID: 241308
		[Token(Token = "0x403AE9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_completedMissionCount;

		// Token: 0x0403AE9D RID: 241309
		[Token(Token = "0x403AE9D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_completedMissionCount;

		// Token: 0x0403AE9E RID: 241310
		[Token(Token = "0x403AE9E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_missionCount;

		// Token: 0x0403AE9F RID: 241311
		[Token(Token = "0x403AE9F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_hasMissionCanClaim;

		// Token: 0x0403AEA0 RID: 241312
		[Token(Token = "0x403AEA0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AEA1 RID: 241313
		[Token(Token = "0x403AEA1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckHasMissionCanClaim;

		// Token: 0x0403AEA2 RID: 241314
		[Token(Token = "0x403AEA2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CompareMission;

		// Token: 0x0403AEA3 RID: 241315
		[Token(Token = "0x403AEA3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
