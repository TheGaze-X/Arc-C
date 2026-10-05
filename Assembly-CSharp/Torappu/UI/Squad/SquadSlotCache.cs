using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E01 RID: 15873
	[Token(Token = "0x2003E01")]
	public struct SquadSlotCache : ISquadMemberCompInfo, IHotfixable
	{
		// Token: 0x06018B23 RID: 101155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B23")]
		[Address(RVA = "0x1149D40", Offset = "0x1148940", VA = "0x181149D40")]
		public string GetSkillId(string tmplId)
		{
			return null;
		}

		// Token: 0x06018B24 RID: 101156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B24")]
		[Address(RVA = "0x1149C10", Offset = "0x1148810", VA = "0x181149C10")]
		public string GetEquipId(string tmplId)
		{
			return null;
		}

		// Token: 0x06018B25 RID: 101157 RVA: 0x0009B610 File Offset: 0x00099810
		[Token(Token = "0x6018B25")]
		[Address(RVA = "0x1149840", Offset = "0x1148440", VA = "0x181149840")]
		public static SquadSlotCache Create(SquadItemStruct member)
		{
			return default(SquadSlotCache);
		}

		// Token: 0x06018B26 RID: 101158 RVA: 0x0009B628 File Offset: 0x00099828
		[Token(Token = "0x6018B26")]
		[Address(RVA = "0x11491A0", Offset = "0x1147DA0", VA = "0x1811491A0")]
		public static SquadSlotCache CreateByEditMode(UISquadEditCharModel editModel)
		{
			return default(SquadSlotCache);
		}

		// Token: 0x06018B27 RID: 101159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B27")]
		[Address(RVA = "0x1149A10", Offset = "0x1148610", VA = "0x181149A10", Slot = "4")]
		public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x06018B28 RID: 101160 RVA: 0x0009B640 File Offset: 0x00099840
		[Token(Token = "0x6018B28")]
		[Address(RVA = "0x1149970", Offset = "0x1148570", VA = "0x181149970", Slot = "5")]
		public int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x06018B29 RID: 101161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B29")]
		[Address(RVA = "0x1149B00", Offset = "0x1148700", VA = "0x181149B00", Slot = "6")]
		public string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x0401E48B RID: 124043
		[Token(Token = "0x401E48B")]
		[FieldOffset(Offset = "0x0")]
		public int chrInstId;

		// Token: 0x0401E48C RID: 124044
		[Token(Token = "0x401E48C")]
		[FieldOffset(Offset = "0x8")]
		public string charId;

		// Token: 0x0401E48D RID: 124045
		[Token(Token = "0x401E48D")]
		[FieldOffset(Offset = "0x10")]
		public string tmplId;

		// Token: 0x0401E48E RID: 124046
		[Token(Token = "0x401E48E")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty]
		private string m_skillId;

		// Token: 0x0401E48F RID: 124047
		[Token(Token = "0x401E48F")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty]
		private string m_equipId;

		// Token: 0x0401E490 RID: 124048
		[Token(Token = "0x401E490")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty]
		private string m_defaultEquipId;

		// Token: 0x0401E491 RID: 124049
		[Token(Token = "0x401E491")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, SquadSlotTmplPatch> tmpl;

		// Token: 0x0401E492 RID: 124050
		[Token(Token = "0x401E492")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSkillId;

		// Token: 0x0401E493 RID: 124051
		[Token(Token = "0x401E493")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEquipId;

		// Token: 0x0401E494 RID: 124052
		[Token(Token = "0x401E494")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0401E495 RID: 124053
		[Token(Token = "0x401E495")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateByEditMode;

		// Token: 0x0401E496 RID: 124054
		[Token(Token = "0x401E496")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x0401E497 RID: 124055
		[Token(Token = "0x401E497")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x0401E498 RID: 124056
		[Token(Token = "0x401E498")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;
	}
}
