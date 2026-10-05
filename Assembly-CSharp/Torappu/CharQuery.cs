using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013F7 RID: 5111
	[Token(Token = "0x20013F7")]
	[Serializable]
	public struct CharQuery
	{
		// Token: 0x060074CC RID: 29900 RVA: 0x00033F48 File Offset: 0x00032148
		[Token(Token = "0x60074CC")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x00033F60 File Offset: 0x00032160
		[Token(Token = "0x60074CD")]
		[Address(RVA = "0x23029E0", Offset = "0x23015E0", VA = "0x1823029E0")]
		public static CharQuery SimpleChar(string charId)
		{
			return default(CharQuery);
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x00033F78 File Offset: 0x00032178
		[Token(Token = "0x60074CE")]
		[Address(RVA = "0x2302A10", Offset = "0x2301610", VA = "0x182302A10")]
		public static CharQuery TemplateChar(string charId, string tmplId)
		{
			return default(CharQuery);
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x00033F90 File Offset: 0x00032190
		[Token(Token = "0x60074CF")]
		[Address(RVA = "0x2302670", Offset = "0x2301270", VA = "0x182302670")]
		public static CharQuery FromPlayer(PlayerCharacter playerChar)
		{
			return default(CharQuery);
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x00033FA8 File Offset: 0x000321A8
		[Token(Token = "0x60074D0")]
		[Address(RVA = "0x2302730", Offset = "0x2301330", VA = "0x182302730")]
		public static CharQuery FromSharedChar(SharedCharData sharedData)
		{
			return default(CharQuery);
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x00033FC0 File Offset: 0x000321C0
		[Token(Token = "0x60074D1")]
		[Address(RVA = "0x2302920", Offset = "0x2301520", VA = "0x182302920")]
		public static CharQuery FromSkin(CharSkinData skinData)
		{
			return default(CharQuery);
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x00033FD8 File Offset: 0x000321D8
		[Token(Token = "0x60074D2")]
		[Address(RVA = "0x23027F0", Offset = "0x23013F0", VA = "0x1823027F0")]
		public static CharQuery FromSkinId(string skinId)
		{
			return default(CharQuery);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D3")]
		[Address(RVA = "0x2302A50", Offset = "0x2301650", VA = "0x182302A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04007203 RID: 29187
		[Token(Token = "0x4007203")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CharQuery EMPTY;

		// Token: 0x04007204 RID: 29188
		[Token(Token = "0x4007204")]
		[FieldOffset(Offset = "0x0")]
		public string charId;

		// Token: 0x04007205 RID: 29189
		[Token(Token = "0x4007205")]
		[FieldOffset(Offset = "0x8")]
		public bool isToken;

		// Token: 0x04007206 RID: 29190
		[Token(Token = "0x4007206")]
		[FieldOffset(Offset = "0x10")]
		public string tmplId;
	}
}
