using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FD2 RID: 28626
	[Token(Token = "0x2006FD2")]
	public class ActMultiV3SquadModel : IHotfixable
	{
		// Token: 0x17005FF7 RID: 24567
		// (get) Token: 0x06028A72 RID: 166514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028A73 RID: 166515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FF7")]
		public string squadId
		{
			[Token(Token = "0x6028A72")]
			[Address(RVA = "0x23FC1D0", Offset = "0x23FADD0", VA = "0x1823FC1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028A73")]
			[Address(RVA = "0x23FC410", Offset = "0x23FB010", VA = "0x1823FC410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FF8 RID: 24568
		// (get) Token: 0x06028A74 RID: 166516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028A75 RID: 166517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FF8")]
		public string name
		{
			[Token(Token = "0x6028A74")]
			[Address(RVA = "0x23FC110", Offset = "0x23FAD10", VA = "0x1823FC110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028A75")]
			[Address(RVA = "0x23FC320", Offset = "0x23FAF20", VA = "0x1823FC320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FF9 RID: 24569
		// (get) Token: 0x06028A76 RID: 166518 RVA: 0x000D2828 File Offset: 0x000D0A28
		// (set) Token: 0x06028A77 RID: 166519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FF9")]
		public int sortId
		{
			[Token(Token = "0x6028A76")]
			[Address(RVA = "0x23FC170", Offset = "0x23FAD70", VA = "0x1823FC170")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028A77")]
			[Address(RVA = "0x23FC3A0", Offset = "0x23FAFA0", VA = "0x1823FC3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FFA RID: 24570
		// (get) Token: 0x06028A78 RID: 166520 RVA: 0x000D2840 File Offset: 0x000D0A40
		// (set) Token: 0x06028A79 RID: 166521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FFA")]
		public ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028A78")]
			[Address(RVA = "0x23FC0B0", Offset = "0x23FACB0", VA = "0x1823FC0B0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
			[Token(Token = "0x6028A79")]
			[Address(RVA = "0x23FC2B0", Offset = "0x23FAEB0", VA = "0x1823FC2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FFB RID: 24571
		// (get) Token: 0x06028A7A RID: 166522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028A7B RID: 166523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FFB")]
		public string effectIconId
		{
			[Token(Token = "0x6028A7A")]
			[Address(RVA = "0x23FBF90", Offset = "0x23FAB90", VA = "0x1823FBF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028A7B")]
			[Address(RVA = "0x23FC230", Offset = "0x23FAE30", VA = "0x1823FC230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FFC RID: 24572
		// (get) Token: 0x06028A7C RID: 166524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FFC")]
		public ActMultiV3PriClassModel highPriModel
		{
			[Token(Token = "0x6028A7C")]
			[Address(RVA = "0x23FBFF0", Offset = "0x23FABF0", VA = "0x1823FBFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FFD RID: 24573
		// (get) Token: 0x06028A7D RID: 166525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FFD")]
		public ActMultiV3PriClassModel lowPriModel
		{
			[Token(Token = "0x6028A7D")]
			[Address(RVA = "0x23FC050", Offset = "0x23FAC50", VA = "0x1823FC050")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028A7E RID: 166526 RVA: 0x000D2858 File Offset: 0x000D0A58
		[Token(Token = "0x6028A7E")]
		[Address(RVA = "0x23FB320", Offset = "0x23F9F20", VA = "0x1823FB320")]
		public int GetPriClassMaxCnt(ActMultiV3IdentityType idType)
		{
			return 0;
		}

		// Token: 0x06028A7F RID: 166527 RVA: 0x000D2870 File Offset: 0x000D0A70
		[Token(Token = "0x6028A7F")]
		[Address(RVA = "0x23FB420", Offset = "0x23FA020", VA = "0x1823FB420")]
		public int GetTargetInstId(ActMultiV3IdentityType idType, string charId)
		{
			return 0;
		}

		// Token: 0x06028A80 RID: 166528 RVA: 0x000D2888 File Offset: 0x000D0A88
		[Token(Token = "0x6028A80")]
		[Address(RVA = "0x23FAD50", Offset = "0x23F9950", VA = "0x1823FAD50")]
		public bool CheckIfNewOpen()
		{
			return default(bool);
		}

		// Token: 0x06028A81 RID: 166529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A81")]
		[Address(RVA = "0x23FAF40", Offset = "0x23F9B40", VA = "0x1823FAF40")]
		public void ConsumeNewOpenTrack()
		{
		}

		// Token: 0x06028A82 RID: 166530 RVA: 0x000D28A0 File Offset: 0x000D0AA0
		[Token(Token = "0x6028A82")]
		[Address(RVA = "0x23FB5D0", Offset = "0x23FA1D0", VA = "0x1823FB5D0")]
		public bool IsCharNumAdequate()
		{
			return default(bool);
		}

		// Token: 0x06028A83 RID: 166531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A83")]
		[Address(RVA = "0x23FB790", Offset = "0x23FA390", VA = "0x1823FB790")]
		public void LoadData(string actId, ActMultiV3Data actData, ActMultiV3SquadInfoData squadInfo)
		{
		}

		// Token: 0x06028A84 RID: 166532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A84")]
		[Address(RVA = "0x23FBAD0", Offset = "0x23FA6D0", VA = "0x1823FBAD0")]
		public void UpdateEffectData()
		{
		}

		// Token: 0x06028A85 RID: 166533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A85")]
		[Address(RVA = "0x23FBC50", Offset = "0x23FA850", VA = "0x1823FBC50")]
		private void _UpdateEffectData()
		{
		}

		// Token: 0x06028A86 RID: 166534 RVA: 0x000D28B8 File Offset: 0x000D0AB8
		[Token(Token = "0x6028A86")]
		[Address(RVA = "0x23FB700", Offset = "0x23FA300", VA = "0x1823FB700")]
		public bool IsSquadUnlock()
		{
			return default(bool);
		}

		// Token: 0x06028A87 RID: 166535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028A87")]
		[Address(RVA = "0x23FBBB0", Offset = "0x23FA7B0", VA = "0x1823FBBB0")]
		private ActMultiV3PriClassModel _GetPriModel(ActMultiV3IdentityType idType)
		{
			return null;
		}

		// Token: 0x06028A88 RID: 166536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A88")]
		[Address(RVA = "0x23FAFF0", Offset = "0x23F9BF0", VA = "0x1823FAFF0")]
		public void GenCharIdTypeDict(Dictionary<int, string> outputDict)
		{
		}

		// Token: 0x06028A89 RID: 166537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A89")]
		[Address(RVA = "0x23FB0B0", Offset = "0x23F9CB0", VA = "0x1823FB0B0")]
		public void GenSelectCharList(ActMultiV3IdentityType idType, List<TemplateCharSelectCharInputData> outputList)
		{
		}

		// Token: 0x06028A8A RID: 166538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A8A")]
		[Address(RVA = "0x23FA770", Offset = "0x23F9370", VA = "0x1823FA770")]
		public void ApplySelectCharList(ActMultiV3IdentityType idType, List<TemplateCharSelectCardViewModel> selectedList)
		{
		}

		// Token: 0x06028A8B RID: 166539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A8B")]
		[Address(RVA = "0x23FBB30", Offset = "0x23FA730", VA = "0x1823FBB30")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x06028A8C RID: 166540 RVA: 0x000D28D0 File Offset: 0x000D0AD0
		[Token(Token = "0x6028A8C")]
		[Address(RVA = "0x23FAE10", Offset = "0x23F9A10", VA = "0x1823FAE10")]
		public bool CheckIfSquadChanged()
		{
			return default(bool);
		}

		// Token: 0x06028A8D RID: 166541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A8D")]
		[Address(RVA = "0x23FBDF0", Offset = "0x23FA9F0", VA = "0x1823FBDF0")]
		public ActMultiV3SquadModel()
		{
		}

		// Token: 0x04039EB7 RID: 237239
		[Token(Token = "0x4039EB7")]
		[FieldOffset(Offset = "0x10")]
		private long m_unlockTs;

		// Token: 0x04039EB8 RID: 237240
		[Token(Token = "0x4039EB8")]
		[FieldOffset(Offset = "0x18")]
		private int m_leastNeedCharCnt;

		// Token: 0x04039EB9 RID: 237241
		[Token(Token = "0x4039EB9")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x04039EBA RID: 237242
		[Token(Token = "0x4039EBA")]
		[FieldOffset(Offset = "0x28")]
		private ActMultiV3PriClassModel m_highPriModel;

		// Token: 0x04039EBB RID: 237243
		[Token(Token = "0x4039EBB")]
		[FieldOffset(Offset = "0x30")]
		private ActMultiV3PriClassModel m_lowPriModel;

		// Token: 0x04039EBC RID: 237244
		[Token(Token = "0x4039EBC")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<int> m_tempCharInstSet;

		// Token: 0x04039EC2 RID: 237250
		[Token(Token = "0x4039EC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadId;

		// Token: 0x04039EC3 RID: 237251
		[Token(Token = "0x4039EC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_squadId;

		// Token: 0x04039EC4 RID: 237252
		[Token(Token = "0x4039EC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04039EC5 RID: 237253
		[Token(Token = "0x4039EC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x04039EC6 RID: 237254
		[Token(Token = "0x4039EC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04039EC7 RID: 237255
		[Token(Token = "0x4039EC7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04039EC8 RID: 237256
		[Token(Token = "0x4039EC8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x04039EC9 RID: 237257
		[Token(Token = "0x4039EC9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x04039ECA RID: 237258
		[Token(Token = "0x4039ECA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_effectIconId;

		// Token: 0x04039ECB RID: 237259
		[Token(Token = "0x4039ECB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_effectIconId;

		// Token: 0x04039ECC RID: 237260
		[Token(Token = "0x4039ECC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_highPriModel;

		// Token: 0x04039ECD RID: 237261
		[Token(Token = "0x4039ECD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_lowPriModel;

		// Token: 0x04039ECE RID: 237262
		[Token(Token = "0x4039ECE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetPriClassMaxCnt;

		// Token: 0x04039ECF RID: 237263
		[Token(Token = "0x4039ECF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTargetInstId;

		// Token: 0x04039ED0 RID: 237264
		[Token(Token = "0x4039ED0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckIfNewOpen;

		// Token: 0x04039ED1 RID: 237265
		[Token(Token = "0x4039ED1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ConsumeNewOpenTrack;

		// Token: 0x04039ED2 RID: 237266
		[Token(Token = "0x4039ED2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsCharNumAdequate;

		// Token: 0x04039ED3 RID: 237267
		[Token(Token = "0x4039ED3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039ED4 RID: 237268
		[Token(Token = "0x4039ED4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdateEffectData;

		// Token: 0x04039ED5 RID: 237269
		[Token(Token = "0x4039ED5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateEffectData;

		// Token: 0x04039ED6 RID: 237270
		[Token(Token = "0x4039ED6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsSquadUnlock;

		// Token: 0x04039ED7 RID: 237271
		[Token(Token = "0x4039ED7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetPriModel;

		// Token: 0x04039ED8 RID: 237272
		[Token(Token = "0x4039ED8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GenCharIdTypeDict;

		// Token: 0x04039ED9 RID: 237273
		[Token(Token = "0x4039ED9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GenSelectCharList;

		// Token: 0x04039EDA RID: 237274
		[Token(Token = "0x4039EDA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ApplySelectCharList;

		// Token: 0x04039EDB RID: 237275
		[Token(Token = "0x4039EDB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04039EDC RID: 237276
		[Token(Token = "0x4039EDC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CheckIfSquadChanged;

		// Token: 0x04039EDD RID: 237277
		[Token(Token = "0x4039EDD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
