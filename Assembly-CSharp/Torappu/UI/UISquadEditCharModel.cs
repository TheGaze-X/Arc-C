using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200383B RID: 14395
	[Token(Token = "0x200383B")]
	public class UISquadEditCharModel : ISquadMemberCompInfo, IHotfixable
	{
		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x06016CF8 RID: 93432 RVA: 0x00093078 File Offset: 0x00091278
		// (set) Token: 0x06016CF9 RID: 93433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700368F")]
		public int charInstId
		{
			[Token(Token = "0x6016CF8")]
			[Address(RVA = "0xF52090", Offset = "0xF50C90", VA = "0x180F52090")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016CF9")]
			[Address(RVA = "0xF521D0", Offset = "0xF50DD0", VA = "0x180F521D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x06016CFA RID: 93434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016CFB RID: 93435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003690")]
		public string charId
		{
			[Token(Token = "0x6016CFA")]
			[Address(RVA = "0xF52030", Offset = "0xF50C30", VA = "0x180F52030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6016CFB")]
			[Address(RVA = "0xF52150", Offset = "0xF50D50", VA = "0x180F52150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06016CFC RID: 93436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CFC")]
		[Address(RVA = "0xF51F20", Offset = "0xF50B20", VA = "0x180F51F20")]
		private UISquadEditCharModel.Patch _SafeTmpl(string tmplId)
		{
			return null;
		}

		// Token: 0x06016CFD RID: 93437 RVA: 0x00093090 File Offset: 0x00091290
		[Token(Token = "0x6016CFD")]
		[Address(RVA = "0xF50D50", Offset = "0xF4F950", VA = "0x180F50D50")]
		public int GetSkillIndex(string tmplId)
		{
			return 0;
		}

		// Token: 0x06016CFE RID: 93438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CFE")]
		[Address(RVA = "0xF50B00", Offset = "0xF4F700", VA = "0x180F50B00", Slot = "6")]
		public string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x06016CFF RID: 93439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016CFF")]
		[Address(RVA = "0xF50C20", Offset = "0xF4F820", VA = "0x180F50C20")]
		public string GetEquipId(string tmplId)
		{
			return null;
		}

		// Token: 0x06016D00 RID: 93440 RVA: 0x000930A8 File Offset: 0x000912A8
		[Token(Token = "0x6016D00")]
		[Address(RVA = "0xF50A10", Offset = "0xF4F610", VA = "0x180F50A10")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x06016D01 RID: 93441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003691")]
		public string currentTmpl
		{
			[Token(Token = "0x6016D01")]
			[Address(RVA = "0xF520F0", Offset = "0xF50CF0", VA = "0x180F520F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016D02 RID: 93442 RVA: 0x000930C0 File Offset: 0x000912C0
		[Token(Token = "0x6016D02")]
		[Address(RVA = "0xF50CE0", Offset = "0xF4F8E0", VA = "0x180F50CE0")]
		public int GetSkillIndex()
		{
			return 0;
		}

		// Token: 0x06016D03 RID: 93443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D03")]
		[Address(RVA = "0xF51070", Offset = "0xF4FC70", VA = "0x180F51070")]
		public void SetSkillIndex(int index)
		{
		}

		// Token: 0x06016D04 RID: 93444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D04")]
		[Address(RVA = "0xF50BA0", Offset = "0xF4F7A0", VA = "0x180F50BA0")]
		public string GetEquipId()
		{
			return null;
		}

		// Token: 0x06016D05 RID: 93445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D05")]
		[Address(RVA = "0xF50F90", Offset = "0xF4FB90", VA = "0x180F50F90")]
		public void SetEquipId(string i_equipId, string defaultEquipId)
		{
		}

		// Token: 0x06016D06 RID: 93446 RVA: 0x000930D8 File Offset: 0x000912D8
		[Token(Token = "0x6016D06")]
		[Address(RVA = "0xF51100", Offset = "0xF4FD00", VA = "0x180F51100")]
		public bool SetTmpl(string tmplId)
		{
			return default(bool);
		}

		// Token: 0x06016D07 RID: 93447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D07")]
		[Address(RVA = "0xF50960", Offset = "0xF4F560", VA = "0x180F50960", Slot = "4")]
		public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x06016D08 RID: 93448 RVA: 0x000930F0 File Offset: 0x000912F0
		[Token(Token = "0x6016D08")]
		[Address(RVA = "0xF508F0", Offset = "0xF4F4F0", VA = "0x180F508F0", Slot = "5")]
		public int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x06016D09 RID: 93449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D09")]
		[Address(RVA = "0xF4FCC0", Offset = "0xF4E8C0", VA = "0x180F4FCC0")]
		public void ApplyFriendViewModelFromPlayerChar(int instId, string skillId, string equipId, [Optional] ISquadMemberCompInfo extraTmplInfo)
		{
		}

		// Token: 0x06016D0A RID: 93450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D0A")]
		[Address(RVA = "0xF4FF80", Offset = "0xF4EB80", VA = "0x180F4FF80")]
		public void ApplyFromCharCardModel(CharacterCardViewModel cardModel, string skillId, string equipId, [Optional] ISquadMemberCompInfo extraTmplInfo)
		{
		}

		// Token: 0x06016D0B RID: 93451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D0B")]
		[Address(RVA = "0xF50150", Offset = "0xF4ED50", VA = "0x180F50150")]
		public void ApplyFromCommonCharCardModel(ICharacterCardViewModel cardModel, string skillId, string equipId)
		{
		}

		// Token: 0x06016D0C RID: 93452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D0C")]
		[Address(RVA = "0xF51C60", Offset = "0xF50860", VA = "0x180F51C60")]
		private static UISquadEditCharModel _CreateFromSquadProto(PlayerSquadMemberProto proto)
		{
			return null;
		}

		// Token: 0x06016D0D RID: 93453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D0D")]
		[Address(RVA = "0xF515F0", Offset = "0xF501F0", VA = "0x180F515F0")]
		private void _ApplyImpl(int instId, CharQuery query, int skillIndex, string equipId, string defaultEquipId, IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> extraTmpls)
		{
		}

		// Token: 0x06016D0E RID: 93454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D0E")]
		[Address(RVA = "0xF50640", Offset = "0xF4F240", VA = "0x180F50640")]
		public RequestAssistChar CreateRequestAssistChar()
		{
			return null;
		}

		// Token: 0x06016D0F RID: 93455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D0F")]
		[Address(RVA = "0xF50420", Offset = "0xF4F020", VA = "0x180F50420")]
		public static UISquadEditCharModel[] CreateFromPlayerAssists(IList<PlayerFriendAssist> assists)
		{
			return null;
		}

		// Token: 0x06016D10 RID: 93456 RVA: 0x00093108 File Offset: 0x00091308
		[Token(Token = "0x6016D10")]
		[Address(RVA = "0xF511A0", Offset = "0xF4FDA0", VA = "0x180F511A0")]
		public static bool SyncFromPlayerData(IList<UISquadEditCharModel> squad, out bool tmplChange)
		{
			return default(bool);
		}

		// Token: 0x06016D11 RID: 93457 RVA: 0x00093120 File Offset: 0x00091320
		[Token(Token = "0x6016D11")]
		[Address(RVA = "0xF50ED0", Offset = "0xF4FAD0", VA = "0x180F50ED0")]
		public int InternalSkillIndex()
		{
			return 0;
		}

		// Token: 0x06016D12 RID: 93458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D12")]
		[Address(RVA = "0xF50E70", Offset = "0xF4FA70", VA = "0x180F50E70")]
		public string InternalEquipId()
		{
			return null;
		}

		// Token: 0x06016D13 RID: 93459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D13")]
		[Address(RVA = "0xF50E10", Offset = "0xF4FA10", VA = "0x180F50E10")]
		public string InternalDefaultEquipId()
		{
			return null;
		}

		// Token: 0x06016D14 RID: 93460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D14")]
		[Address(RVA = "0xF50F30", Offset = "0xF4FB30", VA = "0x180F50F30")]
		public IDictionary<string, UISquadEditCharModel.Patch> InternalTmpls()
		{
			return null;
		}

		// Token: 0x06016D15 RID: 93461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D15")]
		[Address(RVA = "0xF51FD0", Offset = "0xF50BD0", VA = "0x180F51FD0")]
		public UISquadEditCharModel()
		{
		}

		// Token: 0x0401B823 RID: 112675
		[Token(Token = "0x401B823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_skillIndex;

		// Token: 0x0401B824 RID: 112676
		[Token(Token = "0x401B824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_equipId;

		// Token: 0x0401B825 RID: 112677
		[Token(Token = "0x401B825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_defaultEquipId;

		// Token: 0x0401B826 RID: 112678
		[Token(Token = "0x401B826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_curTmpl;

		// Token: 0x0401B827 RID: 112679
		[Token(Token = "0x401B827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ListDict<string, UISquadEditCharModel.Patch> m_tmpls;

		// Token: 0x0401B828 RID: 112680
		[Token(Token = "0x401B828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charInstId;

		// Token: 0x0401B829 RID: 112681
		[Token(Token = "0x401B829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charInstId;

		// Token: 0x0401B82A RID: 112682
		[Token(Token = "0x401B82A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0401B82B RID: 112683
		[Token(Token = "0x401B82B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_charId;

		// Token: 0x0401B82C RID: 112684
		[Token(Token = "0x401B82C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SafeTmpl;

		// Token: 0x0401B82D RID: 112685
		[Token(Token = "0x401B82D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSkillIndex;

		// Token: 0x0401B82E RID: 112686
		[Token(Token = "0x401B82E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;

		// Token: 0x0401B82F RID: 112687
		[Token(Token = "0x401B82F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEquipId;

		// Token: 0x0401B830 RID: 112688
		[Token(Token = "0x401B830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCharQuery;

		// Token: 0x0401B831 RID: 112689
		[Token(Token = "0x401B831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_currentTmpl;

		// Token: 0x0401B832 RID: 112690
		[Token(Token = "0x401B832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix1_GetSkillIndex;

		// Token: 0x0401B833 RID: 112691
		[Token(Token = "0x401B833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetSkillIndex;

		// Token: 0x0401B834 RID: 112692
		[Token(Token = "0x401B834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_GetEquipId;

		// Token: 0x0401B835 RID: 112693
		[Token(Token = "0x401B835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetEquipId;

		// Token: 0x0401B836 RID: 112694
		[Token(Token = "0x401B836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetTmpl;

		// Token: 0x0401B837 RID: 112695
		[Token(Token = "0x401B837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x0401B838 RID: 112696
		[Token(Token = "0x401B838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x0401B839 RID: 112697
		[Token(Token = "0x401B839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ApplyFriendViewModelFromPlayerChar;

		// Token: 0x0401B83A RID: 112698
		[Token(Token = "0x401B83A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ApplyFromCharCardModel;

		// Token: 0x0401B83B RID: 112699
		[Token(Token = "0x401B83B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ApplyFromCommonCharCardModel;

		// Token: 0x0401B83C RID: 112700
		[Token(Token = "0x401B83C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CreateFromSquadProto;

		// Token: 0x0401B83D RID: 112701
		[Token(Token = "0x401B83D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ApplyImpl;

		// Token: 0x0401B83E RID: 112702
		[Token(Token = "0x401B83E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CreateRequestAssistChar;

		// Token: 0x0401B83F RID: 112703
		[Token(Token = "0x401B83F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CreateFromPlayerAssists;

		// Token: 0x0401B840 RID: 112704
		[Token(Token = "0x401B840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SyncFromPlayerData;

		// Token: 0x0401B841 RID: 112705
		[Token(Token = "0x401B841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_InternalSkillIndex;

		// Token: 0x0401B842 RID: 112706
		[Token(Token = "0x401B842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_InternalEquipId;

		// Token: 0x0401B843 RID: 112707
		[Token(Token = "0x401B843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_InternalDefaultEquipId;

		// Token: 0x0401B844 RID: 112708
		[Token(Token = "0x401B844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_InternalTmpls;

		// Token: 0x0401B845 RID: 112709
		[Token(Token = "0x401B845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200383C RID: 14396
		[Token(Token = "0x200383C")]
		public class Patch
		{
			// Token: 0x06016D16 RID: 93462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016D16")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Patch()
			{
			}

			// Token: 0x0401B846 RID: 112710
			[Token(Token = "0x401B846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int skillIndex;

			// Token: 0x0401B847 RID: 112711
			[Token(Token = "0x401B847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string equipId;

			// Token: 0x0401B848 RID: 112712
			[Token(Token = "0x401B848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string defaultEquipId;
		}
	}
}
