using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x020008EA RID: 2282
	[Token(Token = "0x20008EA")]
	public abstract class PlayerSquadMemberProto : ISquadMemberCompInfo, IHotfixable
	{
		// Token: 0x060065A5 RID: 26021 RVA: 0x00030780 File Offset: 0x0002E980
		[Token(Token = "0x60065A5")]
		[Address(RVA = "0x1EFEF60", Offset = "0x1EFDB60", VA = "0x181EFEF60")]
		public int GetSkillIndex()
		{
			return 0;
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A6")]
		[Address(RVA = "0x1EFEDF0", Offset = "0x1EFD9F0", VA = "0x181EFEDF0", Slot = "6")]
		public string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A7")]
		[Address(RVA = "0x1EFEEC0", Offset = "0x1EFDAC0", VA = "0x181EFEEC0")]
		public string GetEquipId()
		{
			return null;
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x00030798 File Offset: 0x0002E998
		[Token(Token = "0x60065A8")]
		[Address(RVA = "0x1EFF000", Offset = "0x1EFDC00", VA = "0x181EFF000")]
		public int InternalSkillIndex()
		{
			return 0;
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A9")]
		[Address(RVA = "0x1EFED40", Offset = "0x1EFD940", VA = "0x181EFED40", Slot = "4")]
		public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x000307B0 File Offset: 0x0002E9B0
		[Token(Token = "0x60065AA")]
		[Address(RVA = "0x1EFECD0", Offset = "0x1EFD8D0", VA = "0x181EFECD0", Slot = "5")]
		public int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AB")]
		[Address(RVA = "0x1EFF060", Offset = "0x1EFDC60", VA = "0x181EFF060")]
		protected PlayerSquadMemberProto()
		{
		}

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("skillIndex")]
		private int m_skillIndex;

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("currentEquip")]
		private string m_currentEquip;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[FieldOffset(Offset = "0x20")]
		public string currentTmpl;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, PlayerSquadTmpl> tmpl;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSkillIndex;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEquipId;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InternalSkillIndex;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
