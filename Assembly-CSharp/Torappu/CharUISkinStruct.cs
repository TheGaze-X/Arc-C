using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013F8 RID: 5112
	[Token(Token = "0x20013F8")]
	[Serializable]
	public struct CharUISkinStruct
	{
		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060074D5 RID: 29909 RVA: 0x00033FF0 File Offset: 0x000321F0
		[Token(Token = "0x17000E46")]
		[JsonIgnore]
		public bool isEmpty
		{
			[Token(Token = "0x60074D5")]
			[Address(RVA = "0x12E7370", Offset = "0x12E5F70", VA = "0x1812E7370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D6")]
		[Address(RVA = "0x2303D90", Offset = "0x2302990", VA = "0x182303D90")]
		public CharUISkinStruct(CharSkinData data, bool showSpDynIllust)
		{
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D7")]
		[Address(RVA = "0x2303AF0", Offset = "0x23026F0", VA = "0x182303AF0")]
		public CharUISkinStruct(string charId, string skinId, bool showSpDynIllust)
		{
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D8")]
		[Address(RVA = "0x2303D10", Offset = "0x2302910", VA = "0x182303D10")]
		public CharUISkinStruct(string charId, string skinId)
		{
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D9")]
		[Address(RVA = "0x2303A20", Offset = "0x2302620", VA = "0x182303A20")]
		public CharUISkinStruct(CharSkinData data)
		{
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DA")]
		[Address(RVA = "0x2303B90", Offset = "0x2302790", VA = "0x182303B90")]
		public CharUISkinStruct(string skinId, bool showSpDynIllust = false)
		{
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DB")]
		[Address(RVA = "0x23034D0", Offset = "0x23020D0", VA = "0x1823034D0")]
		public string GetIllustId()
		{
			return null;
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DC")]
		[Address(RVA = "0x23030D0", Offset = "0x2301CD0", VA = "0x1823030D0")]
		public string GetDynIllustId()
		{
			return null;
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00034008 File Offset: 0x00032208
		[Token(Token = "0x60074DD")]
		[Address(RVA = "0x23037A0", Offset = "0x23023A0", VA = "0x1823037A0")]
		public bool HasSpDynIllust()
		{
			return default(bool);
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DE")]
		[Address(RVA = "0x2303230", Offset = "0x2301E30", VA = "0x182303230")]
		public string GetDynPortraitId()
		{
			return null;
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DF")]
		[Address(RVA = "0x2302F90", Offset = "0x2301B90", VA = "0x182302F90")]
		public string GetDynEntranceId()
		{
			return null;
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E0")]
		[Address(RVA = "0x2303370", Offset = "0x2301F70", VA = "0x182303370")]
		public string GetIllustIdForBattle()
		{
			return null;
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E1")]
		[Address(RVA = "0x2302B30", Offset = "0x2301730", VA = "0x182302B30")]
		public string GetAvatarId()
		{
			return null;
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E2")]
		[Address(RVA = "0x2303630", Offset = "0x2302230", VA = "0x182303630")]
		public string GetPortraitId()
		{
			return null;
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E3")]
		[Address(RVA = "0x2302CA0", Offset = "0x23018A0", VA = "0x182302CA0")]
		public string GetBuildingId()
		{
			return null;
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00034020 File Offset: 0x00032220
		[Token(Token = "0x60074E4")]
		[Address(RVA = "0x23038E0", Offset = "0x23024E0", VA = "0x1823038E0")]
		public bool VerifyMe(PlayerCharacter playerChar)
		{
			return default(bool);
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x00034038 File Offset: 0x00032238
		[Token(Token = "0x60074E5")]
		[Address(RVA = "0x2302AB0", Offset = "0x23016B0", VA = "0x182302AB0")]
		public bool Equals(CharUISkinStruct other)
		{
			return default(bool);
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x00034050 File Offset: 0x00032250
		[Token(Token = "0x60074E6")]
		[Address(RVA = "0x2302DF0", Offset = "0x23019F0", VA = "0x182302DF0")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x00034068 File Offset: 0x00032268
		[Token(Token = "0x60074E7")]
		[Address(RVA = "0x2303970", Offset = "0x2302570", VA = "0x182303970")]
		private bool _TryGetAndCheckSkinData(out CharSkinData skinData)
		{
			return default(bool);
		}

		// Token: 0x04007207 RID: 29191
		[Token(Token = "0x4007207")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly CharUISkinStruct EMPTY;

		// Token: 0x04007208 RID: 29192
		[Token(Token = "0x4007208")]
		[FieldOffset(Offset = "0x0")]
		public string charId;

		// Token: 0x04007209 RID: 29193
		[Token(Token = "0x4007209")]
		[FieldOffset(Offset = "0x8")]
		public string skinId;

		// Token: 0x0400720A RID: 29194
		[Token(Token = "0x400720A")]
		[FieldOffset(Offset = "0x10")]
		public bool showSpDynIllust;
	}
}
