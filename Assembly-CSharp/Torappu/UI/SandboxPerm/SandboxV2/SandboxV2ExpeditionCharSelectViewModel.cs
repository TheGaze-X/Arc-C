using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004057 RID: 16471
	[Token(Token = "0x2004057")]
	public class SandboxV2ExpeditionCharSelectViewModel : IHotfixable
	{
		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0601979A RID: 104346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C9D")]
		public string expeditionId
		{
			[Token(Token = "0x601979A")]
			[Address(RVA = "0x123E230", Offset = "0x123CE30", VA = "0x18123E230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0601979B RID: 104347 RVA: 0x0009E2E0 File Offset: 0x0009C4E0
		[Token(Token = "0x17003C9E")]
		public bool isValid
		{
			[Token(Token = "0x601979B")]
			[Address(RVA = "0x123E310", Offset = "0x123CF10", VA = "0x18123E310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0601979C RID: 104348 RVA: 0x0009E2F8 File Offset: 0x0009C4F8
		[Token(Token = "0x17003C9F")]
		public int minEliteRank
		{
			[Token(Token = "0x601979C")]
			[Address(RVA = "0x123E370", Offset = "0x123CF70", VA = "0x18123E370")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0601979D RID: 104349 RVA: 0x0009E310 File Offset: 0x0009C510
		[Token(Token = "0x17003CA0")]
		public int duration
		{
			[Token(Token = "0x601979D")]
			[Address(RVA = "0x123E1D0", Offset = "0x123CDD0", VA = "0x18123E1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0601979E RID: 104350 RVA: 0x0009E328 File Offset: 0x0009C528
		[Token(Token = "0x17003CA1")]
		public int drinkCost
		{
			[Token(Token = "0x601979E")]
			[Address(RVA = "0x123E110", Offset = "0x123CD10", VA = "0x18123E110")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0601979F RID: 104351 RVA: 0x0009E340 File Offset: 0x0009C540
		[Token(Token = "0x17003CA2")]
		public int drinkObtain
		{
			[Token(Token = "0x601979F")]
			[Address(RVA = "0x123E170", Offset = "0x123CD70", VA = "0x18123E170")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x060197A0 RID: 104352 RVA: 0x0009E358 File Offset: 0x0009C558
		[Token(Token = "0x17003CA3")]
		public int costAction
		{
			[Token(Token = "0x60197A0")]
			[Address(RVA = "0x123E0B0", Offset = "0x123CCB0", VA = "0x18123E0B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x060197A1 RID: 104353 RVA: 0x0009E370 File Offset: 0x0009C570
		[Token(Token = "0x17003CA4")]
		public int actionObtain
		{
			[Token(Token = "0x60197A1")]
			[Address(RVA = "0x123DFF0", Offset = "0x123CBF0", VA = "0x18123DFF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x060197A2 RID: 104354 RVA: 0x0009E388 File Offset: 0x0009C588
		[Token(Token = "0x17003CA5")]
		public int charCount
		{
			[Token(Token = "0x60197A2")]
			[Address(RVA = "0x123E050", Offset = "0x123CC50", VA = "0x18123E050")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x060197A3 RID: 104355 RVA: 0x0009E3A0 File Offset: 0x0009C5A0
		[Token(Token = "0x17003CA6")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x60197A3")]
			[Address(RVA = "0x123E3D0", Offset = "0x123CFD0", VA = "0x18123E3D0")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x060197A4 RID: 104356 RVA: 0x0009E3B8 File Offset: 0x0009C5B8
		[Token(Token = "0x17003CA7")]
		public SandboxV2AdminCharSelectStateBean.ExpeditionOption expeditionOption
		{
			[Token(Token = "0x60197A4")]
			[Address(RVA = "0x123E290", Offset = "0x123CE90", VA = "0x18123E290")]
			get
			{
				return default(SandboxV2AdminCharSelectStateBean.ExpeditionOption);
			}
		}

		// Token: 0x060197A5 RID: 104357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197A5")]
		[Address(RVA = "0x123DC20", Offset = "0x123C820", VA = "0x18123DC20")]
		public void LoadData(string topicId, SandboxV2AdminCharSelectStateBean.ExpeditionOption expeditionOption)
		{
		}

		// Token: 0x060197A6 RID: 104358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197A6")]
		[Address(RVA = "0x123DE20", Offset = "0x123CA20", VA = "0x18123DE20")]
		public void RefreshData(string topicId, [Optional] SandboxV2Data topicDetailData)
		{
		}

		// Token: 0x060197A7 RID: 104359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197A7")]
		[Address(RVA = "0x123DF90", Offset = "0x123CB90", VA = "0x18123DF90")]
		public SandboxV2ExpeditionCharSelectViewModel()
		{
		}

		// Token: 0x0401FBFA RID: 130042
		[Token(Token = "0x401FBFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_expeditionId;

		// Token: 0x0401FBFB RID: 130043
		[Token(Token = "0x401FBFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_isValid;

		// Token: 0x0401FBFC RID: 130044
		[Token(Token = "0x401FBFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_minEliteRank;

		// Token: 0x0401FBFD RID: 130045
		[Token(Token = "0x401FBFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_duration;

		// Token: 0x0401FBFE RID: 130046
		[Token(Token = "0x401FBFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int m_drinkCost;

		// Token: 0x0401FBFF RID: 130047
		[Token(Token = "0x401FBFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_drinkObtain;

		// Token: 0x0401FC00 RID: 130048
		[Token(Token = "0x401FC00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_costAction;

		// Token: 0x0401FC01 RID: 130049
		[Token(Token = "0x401FC01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_actionObtain;

		// Token: 0x0401FC02 RID: 130050
		[Token(Token = "0x401FC02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_charCount;

		// Token: 0x0401FC03 RID: 130051
		[Token(Token = "0x401FC03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ProfessionCategory m_profession;

		// Token: 0x0401FC04 RID: 130052
		[Token(Token = "0x401FC04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SandboxV2AdminCharSelectStateBean.ExpeditionOption m_expeditionOption;

		// Token: 0x0401FC05 RID: 130053
		[Token(Token = "0x401FC05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_expeditionId;

		// Token: 0x0401FC06 RID: 130054
		[Token(Token = "0x401FC06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0401FC07 RID: 130055
		[Token(Token = "0x401FC07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_minEliteRank;

		// Token: 0x0401FC08 RID: 130056
		[Token(Token = "0x401FC08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_duration;

		// Token: 0x0401FC09 RID: 130057
		[Token(Token = "0x401FC09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_drinkCost;

		// Token: 0x0401FC0A RID: 130058
		[Token(Token = "0x401FC0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_drinkObtain;

		// Token: 0x0401FC0B RID: 130059
		[Token(Token = "0x401FC0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_costAction;

		// Token: 0x0401FC0C RID: 130060
		[Token(Token = "0x401FC0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_actionObtain;

		// Token: 0x0401FC0D RID: 130061
		[Token(Token = "0x401FC0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_charCount;

		// Token: 0x0401FC0E RID: 130062
		[Token(Token = "0x401FC0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x0401FC0F RID: 130063
		[Token(Token = "0x401FC0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_expeditionOption;

		// Token: 0x0401FC10 RID: 130064
		[Token(Token = "0x401FC10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401FC11 RID: 130065
		[Token(Token = "0x401FC11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401FC12 RID: 130066
		[Token(Token = "0x401FC12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
