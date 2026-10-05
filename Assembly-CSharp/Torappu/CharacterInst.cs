using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000F69 RID: 3945
	[Token(Token = "0x2000F69")]
	[Serializable]
	public class CharacterInst
	{
		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06006C94 RID: 27796 RVA: 0x00031908 File Offset: 0x0002FB08
		[Token(Token = "0x17000D0B")]
		[JsonIgnore]
		public virtual bool isPredefined
		{
			[Token(Token = "0x6006C94")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06006C95 RID: 27797 RVA: 0x00031920 File Offset: 0x0002FB20
		[Token(Token = "0x17000D0C")]
		[JsonIgnore]
		public virtual bool isHidden
		{
			[Token(Token = "0x6006C95")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06006C96 RID: 27798 RVA: 0x00031938 File Offset: 0x0002FB38
		[Token(Token = "0x17000D0D")]
		[JsonIgnore]
		public bool isValid
		{
			[Token(Token = "0x6006C96")]
			[Address(RVA = "0xAC8CE0", Offset = "0xAC78E0", VA = "0x180AC8CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C97")]
		[Address(RVA = "0x20FFC50", Offset = "0x20FE850", VA = "0x1820FFC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C98")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
		public virtual string GetAliasId()
		{
			return null;
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x00031950 File Offset: 0x0002FB50
		[Token(Token = "0x6006C99")]
		[Address(RVA = "0x20FFC00", Offset = "0x20FE800", VA = "0x1820FFC00")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9A")]
		[Address(RVA = "0x20FE580", Offset = "0x20FD180", VA = "0x1820FE580")]
		public CharacterInst()
		{
		}

		// Token: 0x040053C3 RID: 21443
		[Token(Token = "0x40053C3")]
		[FieldOffset(Offset = "0x10")]
		public CharacterInst.Metadata inst;

		// Token: 0x040053C4 RID: 21444
		[Token(Token = "0x40053C4")]
		[FieldOffset(Offset = "0x30")]
		public int skillIndex;

		// Token: 0x040053C5 RID: 21445
		[Token(Token = "0x40053C5")]
		[FieldOffset(Offset = "0x34")]
		public int mainSkillLvl;

		// Token: 0x040053C6 RID: 21446
		[Token(Token = "0x40053C6")]
		[FieldOffset(Offset = "0x38")]
		public string skinId;

		// Token: 0x040053C7 RID: 21447
		[Token(Token = "0x40053C7")]
		[FieldOffset(Offset = "0x40")]
		public string tmplId;

		// Token: 0x040053C8 RID: 21448
		[Token(Token = "0x40053C8")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Blackboard overrideSkillBlackboard;

		// Token: 0x040053C9 RID: 21449
		[Token(Token = "0x40053C9")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public CharacterInst.TalentInst[] overrideTalents;

		// Token: 0x02000F6A RID: 3946
		[Token(Token = "0x2000F6A")]
		[Serializable]
		public struct Metadata
		{
			// Token: 0x040053CA RID: 21450
			[Token(Token = "0x40053CA")]
			[FieldOffset(Offset = "0x0")]
			public string characterKey;

			// Token: 0x040053CB RID: 21451
			[Token(Token = "0x40053CB")]
			[FieldOffset(Offset = "0x8")]
			public int level;

			// Token: 0x040053CC RID: 21452
			[Token(Token = "0x40053CC")]
			[FieldOffset(Offset = "0xC")]
			public EvolvePhase phase;

			// Token: 0x040053CD RID: 21453
			[Token(Token = "0x40053CD")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("favorPoint")]
			public int favorBattlePhase;

			// Token: 0x040053CE RID: 21454
			[Token(Token = "0x40053CE")]
			[FieldOffset(Offset = "0x14")]
			public int potentialRank;

			// Token: 0x040053CF RID: 21455
			[Token(Token = "0x40053CF")]
			[FieldOffset(Offset = "0x18")]
			[JsonIgnore]
			[NonSerialized]
			public int playerInstId;
		}

		// Token: 0x02000F6B RID: 3947
		[Token(Token = "0x2000F6B")]
		[Serializable]
		public struct TalentInst
		{
			// Token: 0x040053D0 RID: 21456
			[Token(Token = "0x40053D0")]
			[FieldOffset(Offset = "0x0")]
			public string prefabKey;

			// Token: 0x040053D1 RID: 21457
			[Token(Token = "0x40053D1")]
			[FieldOffset(Offset = "0x8")]
			public Blackboard blackboard;
		}
	}
}
