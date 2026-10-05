using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006668 RID: 26216
	[Token(Token = "0x2006668")]
	public class HandBookJumpParam : ICharInfoHomeInitParam
	{
		// Token: 0x17005937 RID: 22839
		// (get) Token: 0x06025A50 RID: 154192 RVA: 0x000C8A18 File Offset: 0x000C6C18
		// (set) Token: 0x06025A51 RID: 154193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005937")]
		public bool isBattle
		{
			[Token(Token = "0x6025A50")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025A51")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005938 RID: 22840
		// (get) Token: 0x06025A52 RID: 154194 RVA: 0x000C8A30 File Offset: 0x000C6C30
		// (set) Token: 0x06025A53 RID: 154195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005938")]
		public bool isAVG
		{
			[Token(Token = "0x6025A52")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025A53")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06025A54 RID: 154196 RVA: 0x000C8A48 File Offset: 0x000C6C48
		[Token(Token = "0x6025A54")]
		[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "6")]
		public bool IsFromHandbook()
		{
			return default(bool);
		}

		// Token: 0x06025A55 RID: 154197 RVA: 0x000C8A60 File Offset: 0x000C6C60
		[Token(Token = "0x6025A55")]
		[Address(RVA = "0x2098C00", Offset = "0x2097800", VA = "0x182098C00", Slot = "7")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06025A56 RID: 154198 RVA: 0x000C8A78 File Offset: 0x000C6C78
		[Token(Token = "0x6025A56")]
		[Address(RVA = "0x2098B90", Offset = "0x2097790", VA = "0x182098B90", Slot = "4")]
		public int GetCharInstId()
		{
			return 0;
		}

		// Token: 0x06025A57 RID: 154199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A57")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
		public List<int> GetCharList()
		{
			return null;
		}

		// Token: 0x06025A58 RID: 154200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A58")]
		[Address(RVA = "0x2098C70", Offset = "0x2097870", VA = "0x182098C70")]
		public void SetParamBundle(DataBundle bundle)
		{
		}

		// Token: 0x06025A59 RID: 154201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A59")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookJumpParam()
		{
		}

		// Token: 0x04034E0E RID: 216590
		[Token(Token = "0x4034E0E")]
		[FieldOffset(Offset = "0x10")]
		public bool isHandBookPage;

		// Token: 0x04034E0F RID: 216591
		[Token(Token = "0x4034E0F")]
		[FieldOffset(Offset = "0x11")]
		public bool isJump;

		// Token: 0x04034E10 RID: 216592
		[Token(Token = "0x4034E10")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x04034E11 RID: 216593
		[Token(Token = "0x4034E11")]
		[FieldOffset(Offset = "0x20")]
		public List<int> charList;
	}
}
