using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FBD RID: 28605
	[Token(Token = "0x2006FBD")]
	public class ActMultiV3SquadEffectSelectModel : IHotfixable
	{
		// Token: 0x17005FD6 RID: 24534
		// (get) Token: 0x060289D3 RID: 166355 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060289D4 RID: 166356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FD6")]
		public string actId
		{
			[Token(Token = "0x60289D3")]
			[Address(RVA = "0x23F20F0", Offset = "0x23F0CF0", VA = "0x1823F20F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60289D4")]
			[Address(RVA = "0x23F23F0", Offset = "0x23F0FF0", VA = "0x1823F23F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FD7 RID: 24535
		// (get) Token: 0x060289D5 RID: 166357 RVA: 0x000D2660 File Offset: 0x000D0860
		// (set) Token: 0x060289D6 RID: 166358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FD7")]
		public ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x60289D5")]
			[Address(RVA = "0x23F22D0", Offset = "0x23F0ED0", VA = "0x1823F22D0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
			[Token(Token = "0x60289D6")]
			[Address(RVA = "0x23F24E0", Offset = "0x23F10E0", VA = "0x1823F24E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FD8 RID: 24536
		// (get) Token: 0x060289D7 RID: 166359 RVA: 0x000D2678 File Offset: 0x000D0878
		// (set) Token: 0x060289D8 RID: 166360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FD8")]
		public int keyCount
		{
			[Token(Token = "0x60289D7")]
			[Address(RVA = "0x23F2270", Offset = "0x23F0E70", VA = "0x1823F2270")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60289D8")]
			[Address(RVA = "0x23F2470", Offset = "0x23F1070", VA = "0x1823F2470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FD9 RID: 24537
		// (get) Token: 0x060289D9 RID: 166361 RVA: 0x000D2690 File Offset: 0x000D0890
		// (set) Token: 0x060289DA RID: 166362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FD9")]
		public int starProgress
		{
			[Token(Token = "0x60289D9")]
			[Address(RVA = "0x23F2390", Offset = "0x23F0F90", VA = "0x1823F2390")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60289DA")]
			[Address(RVA = "0x23F25C0", Offset = "0x23F11C0", VA = "0x1823F25C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FDA RID: 24538
		// (get) Token: 0x060289DB RID: 166363 RVA: 0x000D26A8 File Offset: 0x000D08A8
		// (set) Token: 0x060289DC RID: 166364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FDA")]
		public int requireStarCnt
		{
			[Token(Token = "0x60289DB")]
			[Address(RVA = "0x23F2330", Offset = "0x23F0F30", VA = "0x1823F2330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60289DC")]
			[Address(RVA = "0x23F2550", Offset = "0x23F1150", VA = "0x1823F2550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FDB RID: 24539
		// (get) Token: 0x060289DD RID: 166365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FDB")]
		public string currEquipId
		{
			[Token(Token = "0x60289DD")]
			[Address(RVA = "0x23F2150", Offset = "0x23F0D50", VA = "0x1823F2150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FDC RID: 24540
		// (get) Token: 0x060289DE RID: 166366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FDC")]
		public string currSelectId
		{
			[Token(Token = "0x60289DE")]
			[Address(RVA = "0x23F21B0", Offset = "0x23F0DB0", VA = "0x1823F21B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FDD RID: 24541
		// (get) Token: 0x060289DF RID: 166367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FDD")]
		public List<ActMultiV3SquadEffectModel> effectList
		{
			[Token(Token = "0x60289DF")]
			[Address(RVA = "0x23F2210", Offset = "0x23F0E10", VA = "0x1823F2210")]
			get
			{
				return null;
			}
		}

		// Token: 0x060289E0 RID: 166368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60289E0")]
		[Address(RVA = "0x23F0D90", Offset = "0x23EF990", VA = "0x1823F0D90")]
		public ActMultiV3SquadEffectModel FindSelectModel()
		{
			return null;
		}

		// Token: 0x060289E1 RID: 166369 RVA: 0x000D26C0 File Offset: 0x000D08C0
		[Token(Token = "0x60289E1")]
		[Address(RVA = "0x23F1070", Offset = "0x23EFC70", VA = "0x1823F1070")]
		public bool IsAllKeyCollected()
		{
			return default(bool);
		}

		// Token: 0x060289E2 RID: 166370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60289E2")]
		[Address(RVA = "0x23F0CF0", Offset = "0x23EF8F0", VA = "0x1823F0CF0")]
		public string BuildEffectEditHint()
		{
			return null;
		}

		// Token: 0x060289E3 RID: 166371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289E3")]
		[Address(RVA = "0x23F1200", Offset = "0x23EFE00", VA = "0x1823F1200")]
		public void LoadData(string actId, ActMultiV3MapModeType modeType)
		{
		}

		// Token: 0x060289E4 RID: 166372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60289E4")]
		[Address(RVA = "0x23F1A80", Offset = "0x23F0680", VA = "0x1823F1A80")]
		private string _FindInitCurrSelectId()
		{
			return null;
		}

		// Token: 0x060289E5 RID: 166373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289E5")]
		[Address(RVA = "0x23F1A20", Offset = "0x23F0620", VA = "0x1823F1A20")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x060289E6 RID: 166374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289E6")]
		[Address(RVA = "0x23F1BF0", Offset = "0x23F07F0", VA = "0x1823F1BF0")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x060289E7 RID: 166375 RVA: 0x000D26D8 File Offset: 0x000D08D8
		[Token(Token = "0x60289E7")]
		[Address(RVA = "0x23F1890", Offset = "0x23F0490", VA = "0x1823F1890")]
		public bool TrySelectEffect(string effectId)
		{
			return default(bool);
		}

		// Token: 0x060289E8 RID: 166376 RVA: 0x000D26F0 File Offset: 0x000D08F0
		[Token(Token = "0x60289E8")]
		[Address(RVA = "0x23F0F20", Offset = "0x23EFB20", VA = "0x1823F0F20")]
		public bool IsAllEffectUnlock()
		{
			return default(bool);
		}

		// Token: 0x060289E9 RID: 166377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289E9")]
		[Address(RVA = "0x23F2030", Offset = "0x23F0C30", VA = "0x1823F2030")]
		public ActMultiV3SquadEffectSelectModel()
		{
		}

		// Token: 0x04039DD3 RID: 237011
		[Token(Token = "0x4039DD3")]
		[FieldOffset(Offset = "0x10")]
		private List<ActMultiV3SquadEffectModel> m_effectList;

		// Token: 0x04039DD4 RID: 237012
		[Token(Token = "0x4039DD4")]
		[FieldOffset(Offset = "0x18")]
		private string m_currSelectId;

		// Token: 0x04039DD5 RID: 237013
		[Token(Token = "0x4039DD5")]
		[FieldOffset(Offset = "0x20")]
		private string m_currEquipId;

		// Token: 0x04039DD6 RID: 237014
		[Token(Token = "0x4039DD6")]
		[FieldOffset(Offset = "0x28")]
		private string m_effectEditHint;

		// Token: 0x04039DD7 RID: 237015
		[Token(Token = "0x4039DD7")]
		[FieldOffset(Offset = "0x30")]
		private string m_squadName;

		// Token: 0x04039DDD RID: 237021
		[Token(Token = "0x4039DDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039DDE RID: 237022
		[Token(Token = "0x4039DDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039DDF RID: 237023
		[Token(Token = "0x4039DDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x04039DE0 RID: 237024
		[Token(Token = "0x4039DE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x04039DE1 RID: 237025
		[Token(Token = "0x4039DE1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_keyCount;

		// Token: 0x04039DE2 RID: 237026
		[Token(Token = "0x4039DE2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_keyCount;

		// Token: 0x04039DE3 RID: 237027
		[Token(Token = "0x4039DE3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_starProgress;

		// Token: 0x04039DE4 RID: 237028
		[Token(Token = "0x4039DE4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_starProgress;

		// Token: 0x04039DE5 RID: 237029
		[Token(Token = "0x4039DE5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_requireStarCnt;

		// Token: 0x04039DE6 RID: 237030
		[Token(Token = "0x4039DE6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_requireStarCnt;

		// Token: 0x04039DE7 RID: 237031
		[Token(Token = "0x4039DE7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_currEquipId;

		// Token: 0x04039DE8 RID: 237032
		[Token(Token = "0x4039DE8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_currSelectId;

		// Token: 0x04039DE9 RID: 237033
		[Token(Token = "0x4039DE9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_effectList;

		// Token: 0x04039DEA RID: 237034
		[Token(Token = "0x4039DEA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FindSelectModel;

		// Token: 0x04039DEB RID: 237035
		[Token(Token = "0x4039DEB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsAllKeyCollected;

		// Token: 0x04039DEC RID: 237036
		[Token(Token = "0x4039DEC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_BuildEffectEditHint;

		// Token: 0x04039DED RID: 237037
		[Token(Token = "0x4039DED")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039DEE RID: 237038
		[Token(Token = "0x4039DEE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__FindInitCurrSelectId;

		// Token: 0x04039DEF RID: 237039
		[Token(Token = "0x4039DEF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04039DF0 RID: 237040
		[Token(Token = "0x4039DF0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x04039DF1 RID: 237041
		[Token(Token = "0x4039DF1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TrySelectEffect;

		// Token: 0x04039DF2 RID: 237042
		[Token(Token = "0x4039DF2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsAllEffectUnlock;

		// Token: 0x04039DF3 RID: 237043
		[Token(Token = "0x4039DF3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
