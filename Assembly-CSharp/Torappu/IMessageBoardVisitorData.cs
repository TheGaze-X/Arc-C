using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu
{
	// Token: 0x0200068D RID: 1677
	[Token(Token = "0x200068D")]
	public interface IMessageBoardVisitorData : IPlayerStatus, IHotfixable
	{
		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060062BE RID: 25278
		[Token(Token = "0x17000CD2")]
		AvatarInfo avatarInfo { [Token(Token = "0x60062BE")] get; }

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060062BF RID: 25279
		[Token(Token = "0x17000CD3")]
		string skinId { [Token(Token = "0x60062BF")] get; }

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060062C0 RID: 25280
		[Token(Token = "0x17000CD4")]
		bool isSkinSp { [Token(Token = "0x60062C0")] get; }

		// Token: 0x060062C1 RID: 25281 RVA: 0x000302A0 File Offset: 0x0002E4A0
		[Token(Token = "0x60062C1")]
		[Address(RVA = "0x1DEE290", Offset = "0x1DECE90", VA = "0x181DEE290", Slot = "3")]
		bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C2")]
		[Address(RVA = "0x1DEE250", Offset = "0x1DECE50", VA = "0x181DEE250", Slot = "4")]
		string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062C3")]
		[Address(RVA = "0x1DEE190", Offset = "0x1DECD90", VA = "0x181DEE190", Slot = "5")]
		AvatarInfo GetAvatarInfo()
		{
			return null;
		}
	}
}
