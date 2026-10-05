using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002220 RID: 8736
	[Token(Token = "0x2002220")]
	public interface IDrawableRange
	{
		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x000505F8 File Offset: 0x0004E7F8
		[Token(Token = "0x17001BBE")]
		bool isExtendable
		{
			[Token(Token = "0x600DBFC")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x0600DBFD RID: 56317
		[Token(Token = "0x17001BBF")]
		Ability ability { [Token(Token = "0x600DBFD")] get; }

		// Token: 0x0600DBFE RID: 56318
		[Token(Token = "0x600DBFE")]
		bool CheckTargetIn(ILocatable target);

		// Token: 0x0600DBFF RID: 56319 RVA: 0x00050610 File Offset: 0x0004E810
		[Token(Token = "0x600DBFF")]
		[Address(RVA = "0x3620180", Offset = "0x361ED80", VA = "0x183620180", Slot = "3")]
		bool CheckTargetInOriginRange(ILocatable target)
		{
			return default(bool);
		}
	}
}
