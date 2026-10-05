using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[Serializable]
	public class UnicodeLineBreakingRules
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000048")]
		internal HashSet<uint> leadingCharactersLookup
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x5A02B10", Offset = "0x5A01710", VA = "0x185A02B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000049")]
		internal HashSet<uint> followingCharactersLookup
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x5A02A70", Offset = "0x5A01670", VA = "0x185A02A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x5A025F0", Offset = "0x5A011F0", VA = "0x185A025F0")]
		internal static void LoadLineBreakingRules()
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x5A02520", Offset = "0x5A01120", VA = "0x185A02520")]
		private static HashSet<uint> GetCharacters(TextAsset file)
		{
			return null;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnicodeLineBreakingRules()
		{
		}

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x0")]
		private static UnicodeLineBreakingRules s_Instance;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextAsset m_UnicodeLineBreakingRules;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextAsset m_LeadingCharacters;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextAsset m_FollowingCharacters;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x8")]
		private static HashSet<uint> s_LeadingCharactersLookup;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x10")]
		private static HashSet<uint> s_FollowingCharactersLookup;
	}
}
