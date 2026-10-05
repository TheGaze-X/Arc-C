using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E03 RID: 15875
	[Token(Token = "0x2003E03")]
	public struct SquadItemStruct : IHotfixable
	{
		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x06018B30 RID: 101168 RVA: 0x0009B688 File Offset: 0x00099888
		[Token(Token = "0x17003AD7")]
		public int skillIndex
		{
			[Token(Token = "0x6018B30")]
			[Address(RVA = "0x1148C80", Offset = "0x1147880", VA = "0x181148C80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x06018B31 RID: 101169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AD8")]
		public string equipId
		{
			[Token(Token = "0x6018B31")]
			[Address(RVA = "0x1148B30", Offset = "0x1147730", VA = "0x181148B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018B32 RID: 101170 RVA: 0x0009B6A0 File Offset: 0x000998A0
		[Token(Token = "0x6018B32")]
		[Address(RVA = "0x1148860", Offset = "0x1147460", VA = "0x181148860")]
		public int GetSkillIndex(string tmplId)
		{
			return 0;
		}

		// Token: 0x06018B33 RID: 101171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B33")]
		[Address(RVA = "0x1148790", Offset = "0x1147390", VA = "0x181148790")]
		public string GetEquipId(string tmplId)
		{
			return null;
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x06018B34 RID: 101172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003AD9")]
		public CharacterCardViewModel cardModel
		{
			[Token(Token = "0x6018B34")]
			[Address(RVA = "0x11489A0", Offset = "0x11475A0", VA = "0x1811489A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x06018B35 RID: 101173 RVA: 0x0009B6B8 File Offset: 0x000998B8
		[Token(Token = "0x17003ADA")]
		public bool isPredefined
		{
			[Token(Token = "0x6018B35")]
			[Address(RVA = "0x1148BE0", Offset = "0x11477E0", VA = "0x181148BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x06018B36 RID: 101174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ADB")]
		public UISquadEditCharModel editModel
		{
			[Token(Token = "0x6018B36")]
			[Address(RVA = "0x1148AB0", Offset = "0x11476B0", VA = "0x181148AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x06018B37 RID: 101175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ADC")]
		public string currentTmpl
		{
			[Token(Token = "0x6018B37")]
			[Address(RVA = "0x1148A20", Offset = "0x1147620", VA = "0x181148A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018B38 RID: 101176 RVA: 0x0009B6D0 File Offset: 0x000998D0
		[Token(Token = "0x6018B38")]
		[Address(RVA = "0x1148910", Offset = "0x1147510", VA = "0x181148910")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06018B39 RID: 101177 RVA: 0x0009B6E8 File Offset: 0x000998E8
		[Token(Token = "0x6018B39")]
		[Address(RVA = "0x1148690", Offset = "0x1147290", VA = "0x181148690")]
		public static SquadItemStruct CreateFromCardModel(CharacterCardViewModel cardModel, string skillId, string equipId, [Optional] ISquadMemberCompInfo extraTmplInfo)
		{
			return default(SquadItemStruct);
		}

		// Token: 0x06018B3A RID: 101178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B3A")]
		[Address(RVA = "0x11482D0", Offset = "0x1146ED0", VA = "0x1811482D0")]
		public void ApplyFromCardModel(CharacterCardViewModel cardModel, string skillId, string equipId, [Optional] ISquadMemberCompInfo extraTmplInfo)
		{
		}

		// Token: 0x06018B3B RID: 101179 RVA: 0x0009B700 File Offset: 0x00099900
		[Token(Token = "0x6018B3B")]
		[Address(RVA = "0x1148480", Offset = "0x1147080", VA = "0x181148480")]
		public bool CheckIfMemberChanged(PlayerSquadMemberProto prevMember)
		{
			return default(bool);
		}

		// Token: 0x0401E49D RID: 124061
		[Token(Token = "0x401E49D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SquadItemStruct EMPTY;

		// Token: 0x0401E49E RID: 124062
		[Token(Token = "0x401E49E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CharacterCardViewModel m_cardModel;

		// Token: 0x0401E49F RID: 124063
		[Token(Token = "0x401E49F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private UISquadEditCharModel m_editModel;

		// Token: 0x0401E4A0 RID: 124064
		[Token(Token = "0x401E4A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skillIndex;

		// Token: 0x0401E4A1 RID: 124065
		[Token(Token = "0x401E4A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x0401E4A2 RID: 124066
		[Token(Token = "0x401E4A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSkillIndex;

		// Token: 0x0401E4A3 RID: 124067
		[Token(Token = "0x401E4A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEquipId;

		// Token: 0x0401E4A4 RID: 124068
		[Token(Token = "0x401E4A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cardModel;

		// Token: 0x0401E4A5 RID: 124069
		[Token(Token = "0x401E4A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isPredefined;

		// Token: 0x0401E4A6 RID: 124070
		[Token(Token = "0x401E4A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_editModel;

		// Token: 0x0401E4A7 RID: 124071
		[Token(Token = "0x401E4A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_currentTmpl;

		// Token: 0x0401E4A8 RID: 124072
		[Token(Token = "0x401E4A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0401E4A9 RID: 124073
		[Token(Token = "0x401E4A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateFromCardModel;

		// Token: 0x0401E4AA RID: 124074
		[Token(Token = "0x401E4AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ApplyFromCardModel;

		// Token: 0x0401E4AB RID: 124075
		[Token(Token = "0x401E4AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIfMemberChanged;
	}
}
