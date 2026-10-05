using System;
using CriWare.CriMana;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public class CriManaMoviePlayerHolder : CriMonoBehaviour
	{
		// Token: 0x17000097 RID: 151
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000097")]
		public Player player
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x3700DF0", Offset = "0x36FF9F0", VA = "0x183700DF0")]
		private void Awake()
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x36FB5A0", Offset = "0x36FA1A0", VA = "0x1836FB5A0")]
		public CriManaMoviePlayerHolder()
		{
		}

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x28")]
		private Player _player;
	}
}
