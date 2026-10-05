using System;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006465 RID: 25701
	[Token(Token = "0x2006465")]
	public struct STSceneInfo : IStreamDeserialize
	{
		// Token: 0x06024F2D RID: 151341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F2D")]
		[Address(RVA = "0x1FDC300", Offset = "0x1FDAF00", VA = "0x181FDC300", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04033B4A RID: 211786
		[Token(Token = "0x4033B4A")]
		[FieldOffset(Offset = "0x0")]
		public string sceneID;

		// Token: 0x04033B4B RID: 211787
		[Token(Token = "0x4033B4B")]
		[FieldOffset(Offset = "0x8")]
		public string address;

		// Token: 0x04033B4C RID: 211788
		[Token(Token = "0x4033B4C")]
		[FieldOffset(Offset = "0x10")]
		public string token;
	}
}
