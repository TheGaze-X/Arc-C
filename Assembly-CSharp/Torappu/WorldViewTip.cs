using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013AD RID: 5037
	[Token(Token = "0x20013AD")]
	[Serializable]
	public class WorldViewTip : IItemWithWeight
	{
		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x00033678 File Offset: 0x00031878
		[Token(Token = "0x17000E24")]
		[JsonIgnore]
		public float weightValue
		{
			[Token(Token = "0x6007398")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007399")]
		[Address(RVA = "0x2218020", Offset = "0x2216C20", VA = "0x182218020")]
		public WorldViewTip()
		{
		}

		// Token: 0x04006FF7 RID: 28663
		[Token(Token = "0x4006FF7")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x04006FF8 RID: 28664
		[Token(Token = "0x4006FF8")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x04006FF9 RID: 28665
		[Token(Token = "0x4006FF9")]
		[FieldOffset(Offset = "0x20")]
		public string backgroundPicId;

		// Token: 0x04006FFA RID: 28666
		[Token(Token = "0x4006FFA")]
		[FieldOffset(Offset = "0x28")]
		public float weight;
	}
}
