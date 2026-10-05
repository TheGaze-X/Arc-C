using System;
using Il2CppDummyDll;

namespace YoStar.SDK.UI
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	public class SDKViewStateManager
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public static SDKViewStateManager Instance
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x5C4D860", Offset = "0x5C4C460", VA = "0x185C4D860")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x5C4D820", Offset = "0x5C4C420", VA = "0x185C4D820")]
		public void NotifyPanelOpen()
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x5C4D7E0", Offset = "0x5C4C3E0", VA = "0x185C4D7E0")]
		public void NotifyPanelClose()
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SDKViewStateManager()
		{
		}

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x0")]
		private static SDKViewStateManager _instance;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x10")]
		private int _activeCount;
	}
}
