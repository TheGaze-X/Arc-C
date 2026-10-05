using System;
using Il2CppDummyDll;

namespace Torappu.UI.Notification
{
	// Token: 0x020047DF RID: 18399
	[Token(Token = "0x20047DF")]
	public class TextNotifyViewParam : NotifyViewParam
	{
		// Token: 0x0601BD6A RID: 114026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD6A")]
		[Address(RVA = "0x1535060", Offset = "0x1533C60", VA = "0x181535060", Slot = "4")]
		public override string GenerateSignature()
		{
			return null;
		}

		// Token: 0x0601BD6B RID: 114027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD6B")]
		[Address(RVA = "0x1535180", Offset = "0x1533D80", VA = "0x181535180")]
		public TextNotifyViewParam()
		{
		}

		// Token: 0x04024398 RID: 148376
		[Token(Token = "0x4024398")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04024399 RID: 148377
		[Token(Token = "0x4024399")]
		[FieldOffset(Offset = "0x18")]
		public bool useDeduplicate;
	}
}
