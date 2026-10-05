using System;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005089 RID: 20617
	[Token(Token = "0x2005089")]
	public struct STDuelSceneInfo : IStreamDeserialize
	{
		// Token: 0x0601E88D RID: 125069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E88D")]
		[Address(RVA = "0x184D540", Offset = "0x184C140", VA = "0x18184D540", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04028E7A RID: 167546
		[Token(Token = "0x4028E7A")]
		[FieldOffset(Offset = "0x0")]
		public string sceneID;

		// Token: 0x04028E7B RID: 167547
		[Token(Token = "0x4028E7B")]
		[FieldOffset(Offset = "0x8")]
		public string address;

		// Token: 0x04028E7C RID: 167548
		[Token(Token = "0x4028E7C")]
		[FieldOffset(Offset = "0x10")]
		public string token;
	}
}
