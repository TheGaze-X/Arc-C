using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C07 RID: 3079
	[Token(Token = "0x2000C07")]
	public class PlayerCharRotationPreset
	{
		// Token: 0x0600689C RID: 26780 RVA: 0x00030978 File Offset: 0x0002EB78
		[Token(Token = "0x600689C")]
		[Address(RVA = "0x1EF2E60", Offset = "0x1EF1A60", VA = "0x181EF2E60")]
		public CharUISkinStruct GetProfileSkinStruct()
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCharRotationPreset()
		{
		}

		// Token: 0x04003ECD RID: 16077
		[Token(Token = "0x4003ECD")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003ECE RID: 16078
		[Token(Token = "0x4003ECE")]
		[FieldOffset(Offset = "0x18")]
		public string background;

		// Token: 0x04003ECF RID: 16079
		[Token(Token = "0x4003ECF")]
		[FieldOffset(Offset = "0x20")]
		public string homeTheme;

		// Token: 0x04003ED0 RID: 16080
		[Token(Token = "0x4003ED0")]
		[FieldOffset(Offset = "0x28")]
		public string profile;

		// Token: 0x04003ED1 RID: 16081
		[Token(Token = "0x4003ED1")]
		[FieldOffset(Offset = "0x30")]
		public bool profileSp;

		// Token: 0x04003ED2 RID: 16082
		[Token(Token = "0x4003ED2")]
		[FieldOffset(Offset = "0x38")]
		public List<PlayerCharRotationSlot> slots;
	}
}
