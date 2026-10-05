using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[Serializable]
	public class FileSelectionMessage
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x5BCBC60", Offset = "0x5BCA860", VA = "0x185BCBC60")]
		public static FileSelectionMessage FromJson(string json)
		{
			return null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FileSelectionMessage()
		{
		}

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x10")]
		public string[] AcceptFilters;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x18")]
		public bool MultipleAllowed;
	}
}
