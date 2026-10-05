using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Resource.HGDownload
{
	// Token: 0x02001781 RID: 6017
	[Token(Token = "0x2001781")]
	public struct HGDownloadTaskInfo
	{
		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060097C8 RID: 38856 RVA: 0x0003AF50 File Offset: 0x00039150
		// (set) Token: 0x060097C9 RID: 38857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001049")]
		public bool isEmpty
		{
			[Token(Token = "0x60097C8")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60097C9")]
			[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x04008DE6 RID: 36326
		[Token(Token = "0x4008DE6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HGDownloadTaskInfo EMPTY;

		// Token: 0x04008DE8 RID: 36328
		[Token(Token = "0x4008DE8")]
		[FieldOffset(Offset = "0x4")]
		public int code;

		// Token: 0x04008DE9 RID: 36329
		[Token(Token = "0x4008DE9")]
		[FieldOffset(Offset = "0x8")]
		public int state;

		// Token: 0x04008DEA RID: 36330
		[Token(Token = "0x4008DEA")]
		[FieldOffset(Offset = "0xC")]
		public int fileId;
	}
}
