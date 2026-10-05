using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	internal abstract class DragAndDropData : IDragAndDropData
	{
		// Token: 0x06000A7C RID: 2684
		[Token(Token = "0x6000A7C")]
		public abstract object GetGenericData(string key);

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000243")]
		private object userData
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x5AD8AB0", Offset = "0x5AD76B0", VA = "0x185AD8AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A7E RID: 2686
		[Token(Token = "0x17000244")]
		public abstract object source { [Token(Token = "0x6000A7E")] get; }

		// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected DragAndDropData()
		{
		}
	}
}
