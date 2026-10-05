using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C09 RID: 7177
	[Token(Token = "0x2001C09")]
	public class BuildingTrainingStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x0600B2F2 RID: 45810 RVA: 0x000441A8 File Offset: 0x000423A8
		[Token(Token = "0x1700157F")]
		public int specialLvlUpTime
		{
			[Token(Token = "0x600B2F2")]
			[Address(RVA = "0x32E0280", Offset = "0x32DEE80", VA = "0x1832E0280")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x0600B2F3 RID: 45811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001580")]
		public RequireViewModel[] requireSpecialItem
		{
			[Token(Token = "0x600B2F3")]
			[Address(RVA = "0x32E0220", Offset = "0x32DEE20", VA = "0x1832E0220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x0600B2F4 RID: 45812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001581")]
		public RequireViewModel[] requireItem
		{
			[Token(Token = "0x600B2F4")]
			[Address(RVA = "0x32E01C0", Offset = "0x32DEDC0", VA = "0x1832E01C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2F5")]
		[Address(RVA = "0x32DEB70", Offset = "0x32DD770", VA = "0x1832DEB70")]
		public string CheckAllSKillRequirements()
		{
			return null;
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2F6")]
		[Address(RVA = "0x32DECB0", Offset = "0x32DD8B0", VA = "0x1832DECB0")]
		public string CheckSpecializedSKillRequirements()
		{
			return null;
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2F7")]
		[Address(RVA = "0x32DED10", Offset = "0x32DD910", VA = "0x1832DED10")]
		public void RefreshAllData()
		{
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2F8")]
		[Address(RVA = "0x32DED70", Offset = "0x32DD970", VA = "0x1832DED70")]
		public void RefreshSpecialData()
		{
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x000441C0 File Offset: 0x000423C0
		[Token(Token = "0x600B2F9")]
		[Address(RVA = "0x32DEBD0", Offset = "0x32DD7D0", VA = "0x1832DEBD0")]
		public bool CheckIfTraineeValidAndIdle()
		{
			return default(bool);
		}

		// Token: 0x0600B2FA RID: 45818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2FA")]
		[Address(RVA = "0x32DEDD0", Offset = "0x32DD9D0", VA = "0x1832DEDD0")]
		private string _CheckRequireViewModels(IList<RequireViewModel> models)
		{
			return null;
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2FB")]
		[Address(RVA = "0x32DF130", Offset = "0x32DDD30", VA = "0x1832DF130")]
		private void _LoadAllLvlUpData()
		{
		}

		// Token: 0x0600B2FC RID: 45820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2FC")]
		[Address(RVA = "0x32DF460", Offset = "0x32DE060", VA = "0x1832DF460")]
		private void _LoadSpecialLvlUpData()
		{
		}

		// Token: 0x0600B2FD RID: 45821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2FD")]
		[Address(RVA = "0x32DF780", Offset = "0x32DE380", VA = "0x1832DF780")]
		private RequireViewModel[] _ParseSkillAllLvlUpRequirements(PlayerCharacter playerChar, CharacterData charData)
		{
			return null;
		}

		// Token: 0x0600B2FE RID: 45822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2FE")]
		[Address(RVA = "0x32DFC80", Offset = "0x32DE880", VA = "0x1832DFC80")]
		private RequireViewModel[] _ParseSkillSpecialLvlUpRequirements(PlayerCharacter playerChar, CharacterData charData, int skillIndex)
		{
			return null;
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2FF")]
		[Address(RVA = "0x32E0120", Offset = "0x32DED20", VA = "0x1832E0120")]
		public BuildingTrainingStateBean()
		{
		}

		// Token: 0x0400ADFC RID: 44540
		[Token(Token = "0x400ADFC")]
		[FieldOffset(Offset = "0x18")]
		public SkillGroupViewProperty skillProperty;

		// Token: 0x0400ADFD RID: 44541
		[Token(Token = "0x400ADFD")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int traineeInstId;

		// Token: 0x0400ADFE RID: 44542
		[Token(Token = "0x400ADFE")]
		[FieldOffset(Offset = "0x24")]
		[NonSerialized]
		public int selectSkillIndex;

		// Token: 0x0400ADFF RID: 44543
		[Token(Token = "0x400ADFF")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public int targetSkillLevel;

		// Token: 0x0400AE00 RID: 44544
		[Token(Token = "0x400AE00")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		public int targetSpecialLevel;

		// Token: 0x0400AE01 RID: 44545
		[Token(Token = "0x400AE01")]
		[FieldOffset(Offset = "0x30")]
		private RequireViewModel[] m_cacheViewModel;

		// Token: 0x0400AE02 RID: 44546
		[Token(Token = "0x400AE02")]
		[FieldOffset(Offset = "0x38")]
		private RequireViewModel[] m_cacheSpecialViewModel;

		// Token: 0x0400AE03 RID: 44547
		[Token(Token = "0x400AE03")]
		[FieldOffset(Offset = "0x40")]
		private int m_specialLvlUpTime;

		// Token: 0x0400AE04 RID: 44548
		[Token(Token = "0x400AE04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_specialLvlUpTime;

		// Token: 0x0400AE05 RID: 44549
		[Token(Token = "0x400AE05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_requireSpecialItem;

		// Token: 0x0400AE06 RID: 44550
		[Token(Token = "0x400AE06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_requireItem;

		// Token: 0x0400AE07 RID: 44551
		[Token(Token = "0x400AE07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckAllSKillRequirements;

		// Token: 0x0400AE08 RID: 44552
		[Token(Token = "0x400AE08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckSpecializedSKillRequirements;

		// Token: 0x0400AE09 RID: 44553
		[Token(Token = "0x400AE09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshAllData;

		// Token: 0x0400AE0A RID: 44554
		[Token(Token = "0x400AE0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshSpecialData;

		// Token: 0x0400AE0B RID: 44555
		[Token(Token = "0x400AE0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfTraineeValidAndIdle;

		// Token: 0x0400AE0C RID: 44556
		[Token(Token = "0x400AE0C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckRequireViewModels;

		// Token: 0x0400AE0D RID: 44557
		[Token(Token = "0x400AE0D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadAllLvlUpData;

		// Token: 0x0400AE0E RID: 44558
		[Token(Token = "0x400AE0E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadSpecialLvlUpData;

		// Token: 0x0400AE0F RID: 44559
		[Token(Token = "0x400AE0F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ParseSkillAllLvlUpRequirements;

		// Token: 0x0400AE10 RID: 44560
		[Token(Token = "0x400AE10")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ParseSkillSpecialLvlUpRequirements;

		// Token: 0x0400AE11 RID: 44561
		[Token(Token = "0x400AE11")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
