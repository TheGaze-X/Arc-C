using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200375E RID: 14174
	[Token(Token = "0x200375E")]
	public class SkillItemViewModel
	{
		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x06016818 RID: 92184 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016819 RID: 92185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035ED")]
		public Sprite skillIcon
		{
			[Token(Token = "0x6016818")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6016819")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0601681A RID: 92186 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601681B RID: 92187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035EE")]
		public SkillData skillData
		{
			[Token(Token = "0x601681A")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601681B")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601681C RID: 92188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601681C")]
		[Address(RVA = "0xEDED30", Offset = "0xEDD930", VA = "0x180EDED30")]
		public void FillGameData(SkillData skillData, bool skipIconLoad = false)
		{
		}

		// Token: 0x0601681D RID: 92189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601681D")]
		[Address(RVA = "0xEDF0D0", Offset = "0xEDDCD0", VA = "0x180EDF0D0")]
		public SkillItemViewModel UplevelGameData(bool isSpOp = false)
		{
			return null;
		}

		// Token: 0x0601681E RID: 92190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601681E")]
		[Address(RVA = "0xEDEF00", Offset = "0xEDDB00", VA = "0x180EDEF00")]
		public string GetCantSpecializeReason()
		{
			return null;
		}

		// Token: 0x0601681F RID: 92191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601681F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SkillItemViewModel()
		{
		}

		// Token: 0x0401B1D4 RID: 111060
		[Token(Token = "0x401B1D4")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0401B1D5 RID: 111061
		[Token(Token = "0x401B1D5")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0401B1D6 RID: 111062
		[Token(Token = "0x401B1D6")]
		[FieldOffset(Offset = "0x20")]
		public int spCost;

		// Token: 0x0401B1D7 RID: 111063
		[Token(Token = "0x401B1D7")]
		[FieldOffset(Offset = "0x24")]
		public int initCost;

		// Token: 0x0401B1D8 RID: 111064
		[Token(Token = "0x401B1D8")]
		[FieldOffset(Offset = "0x28")]
		public int specLevel;

		// Token: 0x0401B1D9 RID: 111065
		[Token(Token = "0x401B1D9")]
		[FieldOffset(Offset = "0x2C")]
		public bool isUnlocked;

		// Token: 0x0401B1DA RID: 111066
		[Token(Token = "0x401B1DA")]
		[FieldOffset(Offset = "0x30")]
		public List<SkillTagViewModel> tags;

		// Token: 0x0401B1DB RID: 111067
		[Token(Token = "0x401B1DB")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x0401B1DC RID: 111068
		[Token(Token = "0x401B1DC")]
		[FieldOffset(Offset = "0x40")]
		public string rawDesc;

		// Token: 0x0401B1DD RID: 111069
		[Token(Token = "0x401B1DD")]
		[FieldOffset(Offset = "0x48")]
		public string initialUnlockCond;

		// Token: 0x0401B1DE RID: 111070
		[Token(Token = "0x401B1DE")]
		[FieldOffset(Offset = "0x50")]
		public EvolvePhase initialUnlockPhase;

		// Token: 0x0401B1DF RID: 111071
		[Token(Token = "0x401B1DF")]
		[FieldOffset(Offset = "0x54")]
		public int skillAllLevel;

		// Token: 0x0401B1E0 RID: 111072
		[Token(Token = "0x401B1E0")]
		[FieldOffset(Offset = "0x58")]
		public int specializedState;

		// Token: 0x0401B1E1 RID: 111073
		[Token(Token = "0x401B1E1")]
		[FieldOffset(Offset = "0x5C")]
		public bool ableToSpec;

		// Token: 0x0401B1E2 RID: 111074
		[Token(Token = "0x401B1E2")]
		[FieldOffset(Offset = "0x60")]
		public int trainingSlotLevel;

		// Token: 0x0401B1E3 RID: 111075
		[Token(Token = "0x401B1E3")]
		[FieldOffset(Offset = "0x68")]
		public string tokenKey;

		// Token: 0x0401B1E4 RID: 111076
		[Token(Token = "0x401B1E4")]
		[FieldOffset(Offset = "0x70")]
		public bool isSkillHideOnUI;
	}
}
