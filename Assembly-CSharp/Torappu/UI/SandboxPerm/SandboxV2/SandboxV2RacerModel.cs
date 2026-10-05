using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004367 RID: 17255
	[Token(Token = "0x2004367")]
	public abstract class SandboxV2RacerModel : IHotfixable, IComparable
	{
		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0601A7A0 RID: 108448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ED5")]
		public string racerTypeName
		{
			[Token(Token = "0x601A7A0")]
			[Address(RVA = "0x1397440", Offset = "0x1396040", VA = "0x181397440")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x0601A7A1 RID: 108449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ED6")]
		public string instId
		{
			[Token(Token = "0x601A7A1")]
			[Address(RVA = "0x13972C0", Offset = "0x1395EC0", VA = "0x1813972C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x0601A7A2 RID: 108450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ED7")]
		public string itemId
		{
			[Token(Token = "0x601A7A2")]
			[Address(RVA = "0x1397320", Offset = "0x1395F20", VA = "0x181397320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x0601A7A3 RID: 108451 RVA: 0x000A1EC8 File Offset: 0x000A00C8
		[Token(Token = "0x17003ED8")]
		public int racerLevel
		{
			[Token(Token = "0x601A7A3")]
			[Address(RVA = "0x13973E0", Offset = "0x1395FE0", VA = "0x1813973E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x0601A7A4 RID: 108452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ED9")]
		public List<SandboxV2RacerAttributeModel> attribute
		{
			[Token(Token = "0x601A7A4")]
			[Address(RVA = "0x1397200", Offset = "0x1395E00", VA = "0x181397200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x0601A7A5 RID: 108453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EDA")]
		public List<float> radarValue
		{
			[Token(Token = "0x601A7A5")]
			[Address(RVA = "0x13974A0", Offset = "0x13960A0", VA = "0x1813974A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x0601A7A6 RID: 108454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EDB")]
		public SandboxV2RacerBornTalentModel bornTalent
		{
			[Token(Token = "0x601A7A6")]
			[Address(RVA = "0x1397260", Offset = "0x1395E60", VA = "0x181397260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x0601A7A7 RID: 108455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EDC")]
		public SandboxV2RacerLearnedTalentModel learnedTalent
		{
			[Token(Token = "0x601A7A7")]
			[Address(RVA = "0x1397380", Offset = "0x1395F80", VA = "0x181397380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x0601A7A8 RID: 108456
		[Token(Token = "0x17003EDD")]
		public abstract bool isTemp { [Token(Token = "0x601A7A8")] get; }

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x0601A7A9 RID: 108457
		[Token(Token = "0x17003EDE")]
		public abstract string name { [Token(Token = "0x601A7A9")] get; }

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x0601A7AA RID: 108458
		// (set) Token: 0x0601A7AB RID: 108459
		[Token(Token = "0x17003EDF")]
		public abstract bool isMarked { [Token(Token = "0x601A7AA")] get; [Token(Token = "0x601A7AB")] set; }

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x0601A7AC RID: 108460
		[Token(Token = "0x17003EE0")]
		public abstract List<SandboxV2RacerMedalModel> medalList { [Token(Token = "0x601A7AC")] get; }

		// Token: 0x0601A7AD RID: 108461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7AD")]
		[Address(RVA = "0x1396A00", Offset = "0x1395600", VA = "0x181396A00")]
		protected void LoadData(string topicId, SandboxV2RacingData gameData, string instId, PlayerSandboxV2.Racing.RacerBaseInfo playerRacer)
		{
		}

		// Token: 0x0601A7AE RID: 108462 RVA: 0x000A1EE0 File Offset: 0x000A00E0
		[Token(Token = "0x601A7AE")]
		[Address(RVA = "0x1396800", Offset = "0x1395400", VA = "0x181396800", Slot = "10")]
		public virtual int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601A7AF RID: 108463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7AF")]
		[Address(RVA = "0x1396F80", Offset = "0x1395B80", VA = "0x181396F80")]
		protected SandboxV2RacerModel()
		{
		}

		// Token: 0x04021B13 RID: 138003
		[Token(Token = "0x4021B13")]
		[FieldOffset(Offset = "0x10")]
		private string m_racerTypeName;

		// Token: 0x04021B14 RID: 138004
		[Token(Token = "0x4021B14")]
		[FieldOffset(Offset = "0x18")]
		private string m_instId;

		// Token: 0x04021B15 RID: 138005
		[Token(Token = "0x4021B15")]
		[FieldOffset(Offset = "0x20")]
		private int m_racerLevel;

		// Token: 0x04021B16 RID: 138006
		[Token(Token = "0x4021B16")]
		[FieldOffset(Offset = "0x24")]
		private int m_sortId;

		// Token: 0x04021B17 RID: 138007
		[Token(Token = "0x4021B17")]
		[FieldOffset(Offset = "0x28")]
		private int m_inst;

		// Token: 0x04021B18 RID: 138008
		[Token(Token = "0x4021B18")]
		[FieldOffset(Offset = "0x30")]
		private string m_itemId;

		// Token: 0x04021B19 RID: 138009
		[Token(Token = "0x4021B19")]
		[FieldOffset(Offset = "0x38")]
		private List<SandboxV2RacerAttributeModel> m_attribute;

		// Token: 0x04021B1A RID: 138010
		[Token(Token = "0x4021B1A")]
		[FieldOffset(Offset = "0x40")]
		private List<float> m_radarValue;

		// Token: 0x04021B1B RID: 138011
		[Token(Token = "0x4021B1B")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2RacerBornTalentModel m_bornTalent;

		// Token: 0x04021B1C RID: 138012
		[Token(Token = "0x4021B1C")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2RacerLearnedTalentModel m_learnedTalent;

		// Token: 0x04021B1D RID: 138013
		[Token(Token = "0x4021B1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racerTypeName;

		// Token: 0x04021B1E RID: 138014
		[Token(Token = "0x4021B1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x04021B1F RID: 138015
		[Token(Token = "0x4021B1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04021B20 RID: 138016
		[Token(Token = "0x4021B20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_racerLevel;

		// Token: 0x04021B21 RID: 138017
		[Token(Token = "0x4021B21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_attribute;

		// Token: 0x04021B22 RID: 138018
		[Token(Token = "0x4021B22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_radarValue;

		// Token: 0x04021B23 RID: 138019
		[Token(Token = "0x4021B23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bornTalent;

		// Token: 0x04021B24 RID: 138020
		[Token(Token = "0x4021B24")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_learnedTalent;

		// Token: 0x04021B25 RID: 138021
		[Token(Token = "0x4021B25")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021B26 RID: 138022
		[Token(Token = "0x4021B26")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04021B27 RID: 138023
		[Token(Token = "0x4021B27")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
