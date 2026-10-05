using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020008A7 RID: 2215
	[Token(Token = "0x20008A7")]
	public class RequestSquadSlot
	{
		// Token: 0x06006548 RID: 25928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006548")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RequestSquadSlot()
		{
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00030660 File Offset: 0x0002E860
		[Token(Token = "0x6006549")]
		[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
		public bool ShouldSerializeS_currentTmpl()
		{
			return default(bool);
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x00030678 File Offset: 0x0002E878
		[Token(Token = "0x600654A")]
		[Address(RVA = "0x1F00EC0", Offset = "0x1EFFAC0", VA = "0x181F00EC0")]
		public bool ShouldSerializeS_skillIndex()
		{
			return default(bool);
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x00030690 File Offset: 0x0002E890
		[Token(Token = "0x600654B")]
		[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
		public bool ShouldSerializeS_tmpl()
		{
			return default(bool);
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x000306A8 File Offset: 0x0002E8A8
		[Token(Token = "0x600654C")]
		[Address(RVA = "0x1F00EC0", Offset = "0x1EFFAC0", VA = "0x181F00EC0")]
		public bool ShouldSerializeS_currentEquip()
		{
			return default(bool);
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x000306C0 File Offset: 0x0002E8C0
		[Token(Token = "0x600654D")]
		[Address(RVA = "0x1F00E50", Offset = "0x1EFFA50", VA = "0x181F00E50")]
		public int GetSkillIndex()
		{
			return 0;
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654E")]
		[Address(RVA = "0x1F00DE0", Offset = "0x1EFF9E0", VA = "0x181F00DE0")]
		public string GetEquipId()
		{
			return null;
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654F")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public string GetCurTmpl()
		{
			return null;
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006550")]
		[Address(RVA = "0x1F00ED0", Offset = "0x1EFFAD0", VA = "0x181F00ED0")]
		private RequestSquadSlot.Patch _SafeTmpl(string tmplId)
		{
			return null;
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006551")]
		[Address(RVA = "0x1F00830", Offset = "0x1EFF430", VA = "0x181F00830")]
		public static RequestSquadSlot Create(int instId, CharQuery query, int skillIndex, string equipId, ISquadMemberCompInfo extraInfo)
		{
			return null;
		}

		// Token: 0x04003272 RID: 12914
		[Token(Token = "0x4003272")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04003273 RID: 12915
		[Token(Token = "0x4003273")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("skillIndex")]
		public int S_skillIndex;

		// Token: 0x04003274 RID: 12916
		[Token(Token = "0x4003274")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("currentTmpl")]
		public string S_currentTmpl;

		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("tmpl")]
		public ListDict<string, RequestSquadSlot.Patch> S_tmpl;

		// Token: 0x04003276 RID: 12918
		[Token(Token = "0x4003276")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("currentEquip")]
		public string S_currentEquip;

		// Token: 0x020008A8 RID: 2216
		[Token(Token = "0x20008A8")]
		public class Patch
		{
			// Token: 0x06006552 RID: 25938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006552")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Patch()
			{
			}

			// Token: 0x04003277 RID: 12919
			[Token(Token = "0x4003277")]
			[FieldOffset(Offset = "0x10")]
			public int skillIndex;

			// Token: 0x04003278 RID: 12920
			[Token(Token = "0x4003278")]
			[FieldOffset(Offset = "0x18")]
			public string currentEquip;
		}
	}
}
