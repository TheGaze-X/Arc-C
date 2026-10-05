using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047D8 RID: 18392
	[Token(Token = "0x20047D8")]
	public class PlayerAvatarItemViewModel : IHotfixable
	{
		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x0601BD4D RID: 113997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700422D")]
		public string avatarId
		{
			[Token(Token = "0x601BD4D")]
			[Address(RVA = "0x1528F40", Offset = "0x1527B40", VA = "0x181528F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x0601BD4E RID: 113998 RVA: 0x000A6680 File Offset: 0x000A4880
		[Token(Token = "0x1700422E")]
		public bool isAssistant
		{
			[Token(Token = "0x601BD4E")]
			[Address(RVA = "0x1528FA0", Offset = "0x1527BA0", VA = "0x181528FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601BD4F RID: 113999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD4F")]
		[Address(RVA = "0x1528E90", Offset = "0x1527A90", VA = "0x181528E90")]
		public PlayerAvatarItemViewModel()
		{
		}

		// Token: 0x04024379 RID: 148345
		[Token(Token = "0x4024379")]
		[FieldOffset(Offset = "0x10")]
		public int sortId;

		// Token: 0x0402437A RID: 148346
		[Token(Token = "0x402437A")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x0402437B RID: 148347
		[Token(Token = "0x402437B")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarQuery query;

		// Token: 0x0402437C RID: 148348
		[Token(Token = "0x402437C")]
		[FieldOffset(Offset = "0x38")]
		public bool isSelect;

		// Token: 0x0402437D RID: 148349
		[Token(Token = "0x402437D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avatarId;

		// Token: 0x0402437E RID: 148350
		[Token(Token = "0x402437E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAssistant;

		// Token: 0x0402437F RID: 148351
		[Token(Token = "0x402437F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
