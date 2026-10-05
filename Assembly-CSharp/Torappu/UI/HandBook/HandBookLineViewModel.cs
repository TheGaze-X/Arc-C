using System;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066C0 RID: 26304
	[Token(Token = "0x20066C0")]
	[Serializable]
	public class HandBookLineViewModel
	{
		// Token: 0x06025C5E RID: 154718 RVA: 0x000C9030 File Offset: 0x000C7230
		[Token(Token = "0x6025C5E")]
		[Address(RVA = "0x20BDBC0", Offset = "0x20BC7C0", VA = "0x1820BDBC0")]
		public int GetNextID(string point)
		{
			return 0;
		}

		// Token: 0x06025C5F RID: 154719 RVA: 0x000C9048 File Offset: 0x000C7248
		[Token(Token = "0x6025C5F")]
		[Address(RVA = "0x20BDB40", Offset = "0x20BC740", VA = "0x1820BDB40")]
		public bool Contain(string point)
		{
			return default(bool);
		}

		// Token: 0x06025C60 RID: 154720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C60")]
		[Address(RVA = "0x20BDB90", Offset = "0x20BC790", VA = "0x1820BDB90")]
		public string GetAnotherPoint(string point)
		{
			return null;
		}

		// Token: 0x06025C61 RID: 154721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C61")]
		[Address(RVA = "0x20BDC00", Offset = "0x20BC800", VA = "0x1820BDC00")]
		public HandBookLineViewModel()
		{
		}

		// Token: 0x040351A2 RID: 217506
		[Token(Token = "0x40351A2")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040351A3 RID: 217507
		[Token(Token = "0x40351A3")]
		[FieldOffset(Offset = "0x18")]
		public string point1;

		// Token: 0x040351A4 RID: 217508
		[Token(Token = "0x40351A4")]
		[FieldOffset(Offset = "0x20")]
		public string point2;

		// Token: 0x040351A5 RID: 217509
		[Token(Token = "0x40351A5")]
		[FieldOffset(Offset = "0x28")]
		public int lineType;

		// Token: 0x040351A6 RID: 217510
		[Token(Token = "0x40351A6")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		public int point1NextID;

		// Token: 0x040351A7 RID: 217511
		[Token(Token = "0x40351A7")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public int point2NextID;
	}
}
