using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C06 RID: 3078
	[Token(Token = "0x2000C06")]
	public class PlayerCharRotationSlot
	{
		// Token: 0x0600689A RID: 26778 RVA: 0x00030960 File Offset: 0x0002EB60
		[Token(Token = "0x600689A")]
		[Address(RVA = "0x1DF73C0", Offset = "0x1DF5FC0", VA = "0x181DF73C0")]
		public CharUISkinStruct GetSkinStruct()
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCharRotationSlot()
		{
		}

		// Token: 0x04003ECA RID: 16074
		[Token(Token = "0x4003ECA")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04003ECB RID: 16075
		[Token(Token = "0x4003ECB")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;

		// Token: 0x04003ECC RID: 16076
		[Token(Token = "0x4003ECC")]
		[FieldOffset(Offset = "0x20")]
		public bool skinSp;
	}
}
