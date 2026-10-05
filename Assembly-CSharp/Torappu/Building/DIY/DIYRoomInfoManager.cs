using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001873 RID: 6259
	[Token(Token = "0x2001873")]
	public class DIYRoomInfoManager : IDIYRoomInfoProvider
	{
		// Token: 0x06009E76 RID: 40566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E76")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void Setup(IDIYRoomTemplateProvider db)
		{
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E77")]
		[Address(RVA = "0x318C500", Offset = "0x318B100", VA = "0x18318C500", Slot = "4")]
		public void QueryData(Predicate<DIYRoomInfo> filter, Action<DIYRoomInfo> action)
		{
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E78")]
		[Address(RVA = "0x318C7A0", Offset = "0x318B3A0", VA = "0x18318C7A0", Slot = "5")]
		public void QueryDatas(Predicate<DIYRoomInfo> filter, Action<DIYRoomInfo> action)
		{
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E79")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DIYRoomInfoManager()
		{
		}

		// Token: 0x04009541 RID: 38209
		[Token(Token = "0x4009541")]
		[FieldOffset(Offset = "0x10")]
		private IDIYRoomTemplateProvider m_templateProvider;
	}
}
