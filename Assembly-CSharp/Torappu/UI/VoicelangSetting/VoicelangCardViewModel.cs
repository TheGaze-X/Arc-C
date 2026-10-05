using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.CharWord;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BA4 RID: 15268
	[Token(Token = "0x2003BA4")]
	public class VoicelangCardViewModel : IHotfixable
	{
		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x06017E9D RID: 97949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003914")]
		public string voicelangTypeName
		{
			[Token(Token = "0x6017E9D")]
			[Address(RVA = "0x106D1D0", Offset = "0x106BDD0", VA = "0x18106D1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x06017E9E RID: 97950 RVA: 0x00098928 File Offset: 0x00096B28
		// (set) Token: 0x06017E9F RID: 97951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003915")]
		public VoiceLangType voicelangType
		{
			[Token(Token = "0x6017E9E")]
			[Address(RVA = "0x106D230", Offset = "0x106BE30", VA = "0x18106D230")]
			get
			{
				return VoiceLangType.NONE;
			}
			[Token(Token = "0x6017E9F")]
			[Address(RVA = "0x106D5C0", Offset = "0x106C1C0", VA = "0x18106D5C0")]
			set
			{
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x06017EA0 RID: 97952 RVA: 0x00098940 File Offset: 0x00096B40
		[Token(Token = "0x17003916")]
		public VoiceLangGroupType voicelangGroupType
		{
			[Token(Token = "0x6017EA0")]
			[Address(RVA = "0x106D170", Offset = "0x106BD70", VA = "0x18106D170")]
			get
			{
				return VoiceLangGroupType.NONE;
			}
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x06017EA1 RID: 97953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003917")]
		public string wordKey
		{
			[Token(Token = "0x6017EA1")]
			[Address(RVA = "0x106D290", Offset = "0x106BE90", VA = "0x18106D290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x06017EA2 RID: 97954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003918")]
		public string charId
		{
			[Token(Token = "0x6017EA2")]
			[Address(RVA = "0x106CB00", Offset = "0x106B700", VA = "0x18106CB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x06017EA3 RID: 97955 RVA: 0x00098958 File Offset: 0x00096B58
		[Token(Token = "0x17003919")]
		public int instId
		{
			[Token(Token = "0x6017EA3")]
			[Address(RVA = "0x106CC80", Offset = "0x106B880", VA = "0x18106CC80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x06017EA4 RID: 97956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700391A")]
		public string skinId
		{
			[Token(Token = "0x6017EA4")]
			[Address(RVA = "0x106D030", Offset = "0x106BC30", VA = "0x18106D030")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x06017EA5 RID: 97957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700391B")]
		public string name
		{
			[Token(Token = "0x6017EA5")]
			[Address(RVA = "0x106CCE0", Offset = "0x106B8E0", VA = "0x18106CCE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x06017EA6 RID: 97958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700391C")]
		public string portraitId
		{
			[Token(Token = "0x6017EA6")]
			[Address(RVA = "0x106CE00", Offset = "0x106BA00", VA = "0x18106CE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x06017EA7 RID: 97959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700391D")]
		public string powerId
		{
			[Token(Token = "0x6017EA7")]
			[Address(RVA = "0x106CE60", Offset = "0x106BA60", VA = "0x18106CE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x06017EA8 RID: 97960 RVA: 0x00098970 File Offset: 0x00096B70
		// (set) Token: 0x06017EA9 RID: 97961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700391E")]
		public bool highLight
		{
			[Token(Token = "0x6017EA8")]
			[Address(RVA = "0x106CC20", Offset = "0x106B820", VA = "0x18106CC20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017EA9")]
			[Address(RVA = "0x106D3E0", Offset = "0x106BFE0", VA = "0x18106D3E0")]
			set
			{
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x06017EAA RID: 97962 RVA: 0x00098988 File Offset: 0x00096B88
		[Token(Token = "0x1700391F")]
		public bool newVoice
		{
			[Token(Token = "0x6017EAA")]
			[Address(RVA = "0x106CDA0", Offset = "0x106B9A0", VA = "0x18106CDA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x06017EAB RID: 97963 RVA: 0x000989A0 File Offset: 0x00096BA0
		[Token(Token = "0x17003920")]
		public bool newRole
		{
			[Token(Token = "0x6017EAB")]
			[Address(RVA = "0x106CD40", Offset = "0x106B940", VA = "0x18106CD40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x06017EAC RID: 97964 RVA: 0x000989B8 File Offset: 0x00096BB8
		// (set) Token: 0x06017EAD RID: 97965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003921")]
		public VoiceLangType targetVoiceTypeToSwitch
		{
			[Token(Token = "0x6017EAC")]
			[Address(RVA = "0x106D090", Offset = "0x106BC90", VA = "0x18106D090")]
			get
			{
				return VoiceLangType.NONE;
			}
			[Token(Token = "0x6017EAD")]
			[Address(RVA = "0x106D4C0", Offset = "0x106C0C0", VA = "0x18106D4C0")]
			set
			{
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x06017EAE RID: 97966 RVA: 0x000989D0 File Offset: 0x00096BD0
		// (set) Token: 0x06017EAF RID: 97967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003922")]
		public CardGroupFilterType filterType
		{
			[Token(Token = "0x6017EAE")]
			[Address(RVA = "0x106CBC0", Offset = "0x106B7C0", VA = "0x18106CBC0")]
			get
			{
				return default(CardGroupFilterType);
			}
			[Token(Token = "0x6017EAF")]
			[Address(RVA = "0x106D370", Offset = "0x106BF70", VA = "0x18106D370")]
			set
			{
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x06017EB0 RID: 97968 RVA: 0x000989E8 File Offset: 0x00096BE8
		[Token(Token = "0x17003923")]
		public bool showVoiceMark
		{
			[Token(Token = "0x6017EB0")]
			[Address(RVA = "0x106CF20", Offset = "0x106BB20", VA = "0x18106CF20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x06017EB1 RID: 97969 RVA: 0x00098A00 File Offset: 0x00096C00
		// (set) Token: 0x06017EB2 RID: 97970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003924")]
		public VoiceQuery voiceQuery
		{
			[Token(Token = "0x6017EB1")]
			[Address(RVA = "0x106D0F0", Offset = "0x106BCF0", VA = "0x18106D0F0")]
			get
			{
				return default(VoiceQuery);
			}
			[Token(Token = "0x6017EB2")]
			[Address(RVA = "0x106D530", Offset = "0x106C130", VA = "0x18106D530")]
			set
			{
			}
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x06017EB3 RID: 97971 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017EB4 RID: 97972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003925")]
		public List<VoiceLangType> displayTypeList
		{
			[Token(Token = "0x6017EB3")]
			[Address(RVA = "0x106CB60", Offset = "0x106B760", VA = "0x18106CB60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017EB4")]
			[Address(RVA = "0x106D2F0", Offset = "0x106BEF0", VA = "0x18106D2F0")]
			set
			{
			}
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x06017EB5 RID: 97973 RVA: 0x00098A18 File Offset: 0x00096C18
		// (set) Token: 0x06017EB6 RID: 97974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003926")]
		public bool redPoint
		{
			[Token(Token = "0x6017EB5")]
			[Address(RVA = "0x106CEC0", Offset = "0x106BAC0", VA = "0x18106CEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017EB6")]
			[Address(RVA = "0x106D450", Offset = "0x106C050", VA = "0x18106D450")]
			set
			{
			}
		}

		// Token: 0x06017EB7 RID: 97975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EB7")]
		[Address(RVA = "0x106C2B0", Offset = "0x106AEB0", VA = "0x18106C2B0")]
		public void FillViewModel(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06017EB8 RID: 97976 RVA: 0x00098A30 File Offset: 0x00096C30
		[Token(Token = "0x6017EB8")]
		[Address(RVA = "0x106C910", Offset = "0x106B510", VA = "0x18106C910")]
		public bool RefreshRedPoint()
		{
			return default(bool);
		}

		// Token: 0x06017EB9 RID: 97977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EB9")]
		[Address(RVA = "0x106CA40", Offset = "0x106B640", VA = "0x18106CA40")]
		public VoicelangCardViewModel()
		{
		}

		// Token: 0x0401CEC3 RID: 118467
		[Token(Token = "0x401CEC3")]
		[FieldOffset(Offset = "0x10")]
		private string m_voicelangTypeName;

		// Token: 0x0401CEC4 RID: 118468
		[Token(Token = "0x401CEC4")]
		[FieldOffset(Offset = "0x18")]
		private VoiceLangType m_voicelangType;

		// Token: 0x0401CEC5 RID: 118469
		[Token(Token = "0x401CEC5")]
		[FieldOffset(Offset = "0x1C")]
		private VoiceLangGroupType m_voicelangGroupType;

		// Token: 0x0401CEC6 RID: 118470
		[Token(Token = "0x401CEC6")]
		[FieldOffset(Offset = "0x20")]
		private string m_wordKey;

		// Token: 0x0401CEC7 RID: 118471
		[Token(Token = "0x401CEC7")]
		[FieldOffset(Offset = "0x28")]
		private string m_charId;

		// Token: 0x0401CEC8 RID: 118472
		[Token(Token = "0x401CEC8")]
		[FieldOffset(Offset = "0x30")]
		private int m_instId;

		// Token: 0x0401CEC9 RID: 118473
		[Token(Token = "0x401CEC9")]
		[FieldOffset(Offset = "0x38")]
		private string m_skinId;

		// Token: 0x0401CECA RID: 118474
		[Token(Token = "0x401CECA")]
		[FieldOffset(Offset = "0x40")]
		private string m_name;

		// Token: 0x0401CECB RID: 118475
		[Token(Token = "0x401CECB")]
		[FieldOffset(Offset = "0x48")]
		private string m_portraitId;

		// Token: 0x0401CECC RID: 118476
		[Token(Token = "0x401CECC")]
		[FieldOffset(Offset = "0x50")]
		private string m_powerId;

		// Token: 0x0401CECD RID: 118477
		[Token(Token = "0x401CECD")]
		[FieldOffset(Offset = "0x58")]
		private bool m_highLight;

		// Token: 0x0401CECE RID: 118478
		[Token(Token = "0x401CECE")]
		[FieldOffset(Offset = "0x59")]
		private bool m_newRole;

		// Token: 0x0401CECF RID: 118479
		[Token(Token = "0x401CECF")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_newVoice;

		// Token: 0x0401CED0 RID: 118480
		[Token(Token = "0x401CED0")]
		[FieldOffset(Offset = "0x5B")]
		private bool m_redPoint;

		// Token: 0x0401CED1 RID: 118481
		[Token(Token = "0x401CED1")]
		[FieldOffset(Offset = "0x5C")]
		private VoiceLangType m_targetVoiceTypeToSwitch;

		// Token: 0x0401CED2 RID: 118482
		[Token(Token = "0x401CED2")]
		[FieldOffset(Offset = "0x60")]
		private CardGroupFilterType m_filterType;

		// Token: 0x0401CED3 RID: 118483
		[Token(Token = "0x401CED3")]
		[FieldOffset(Offset = "0x68")]
		private VoiceQuery m_voiceQuery;

		// Token: 0x0401CED4 RID: 118484
		[Token(Token = "0x401CED4")]
		[FieldOffset(Offset = "0x88")]
		private List<VoiceLangType> m_displayTypeList;

		// Token: 0x0401CED5 RID: 118485
		[Token(Token = "0x401CED5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_voicelangTypeName;

		// Token: 0x0401CED6 RID: 118486
		[Token(Token = "0x401CED6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_voicelangType;

		// Token: 0x0401CED7 RID: 118487
		[Token(Token = "0x401CED7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_voicelangType;

		// Token: 0x0401CED8 RID: 118488
		[Token(Token = "0x401CED8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_voicelangGroupType;

		// Token: 0x0401CED9 RID: 118489
		[Token(Token = "0x401CED9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_wordKey;

		// Token: 0x0401CEDA RID: 118490
		[Token(Token = "0x401CEDA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0401CEDB RID: 118491
		[Token(Token = "0x401CEDB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0401CEDC RID: 118492
		[Token(Token = "0x401CEDC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x0401CEDD RID: 118493
		[Token(Token = "0x401CEDD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0401CEDE RID: 118494
		[Token(Token = "0x401CEDE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_portraitId;

		// Token: 0x0401CEDF RID: 118495
		[Token(Token = "0x401CEDF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_powerId;

		// Token: 0x0401CEE0 RID: 118496
		[Token(Token = "0x401CEE0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_highLight;

		// Token: 0x0401CEE1 RID: 118497
		[Token(Token = "0x401CEE1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_highLight;

		// Token: 0x0401CEE2 RID: 118498
		[Token(Token = "0x401CEE2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_newVoice;

		// Token: 0x0401CEE3 RID: 118499
		[Token(Token = "0x401CEE3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_newRole;

		// Token: 0x0401CEE4 RID: 118500
		[Token(Token = "0x401CEE4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_targetVoiceTypeToSwitch;

		// Token: 0x0401CEE5 RID: 118501
		[Token(Token = "0x401CEE5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_targetVoiceTypeToSwitch;

		// Token: 0x0401CEE6 RID: 118502
		[Token(Token = "0x401CEE6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_filterType;

		// Token: 0x0401CEE7 RID: 118503
		[Token(Token = "0x401CEE7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_filterType;

		// Token: 0x0401CEE8 RID: 118504
		[Token(Token = "0x401CEE8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_showVoiceMark;

		// Token: 0x0401CEE9 RID: 118505
		[Token(Token = "0x401CEE9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_voiceQuery;

		// Token: 0x0401CEEA RID: 118506
		[Token(Token = "0x401CEEA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_voiceQuery;

		// Token: 0x0401CEEB RID: 118507
		[Token(Token = "0x401CEEB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_displayTypeList;

		// Token: 0x0401CEEC RID: 118508
		[Token(Token = "0x401CEEC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_displayTypeList;

		// Token: 0x0401CEED RID: 118509
		[Token(Token = "0x401CEED")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_redPoint;

		// Token: 0x0401CEEE RID: 118510
		[Token(Token = "0x401CEEE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_redPoint;

		// Token: 0x0401CEEF RID: 118511
		[Token(Token = "0x401CEEF")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_FillViewModel;

		// Token: 0x0401CEF0 RID: 118512
		[Token(Token = "0x401CEF0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RefreshRedPoint;

		// Token: 0x0401CEF1 RID: 118513
		[Token(Token = "0x401CEF1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
