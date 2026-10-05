using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x02001880 RID: 6272
	[Token(Token = "0x2001880")]
	public class DIYRoomTemplateDatabase : IDIYRoomTemplateProvider
	{
		// Token: 0x06009EC0 RID: 40640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC0")]
		[Address(RVA = "0x31901E0", Offset = "0x318EDE0", VA = "0x1831901E0", Slot = "4")]
		public void QueryData(Predicate<IDIYRoomTemplate> filter, Action<IDIYRoomTemplate> action)
		{
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC1")]
		[Address(RVA = "0x3190360", Offset = "0x318EF60", VA = "0x183190360", Slot = "5")]
		public void QueryDatas(Predicate<IDIYRoomTemplate> filter, Action<IDIYRoomTemplate> action)
		{
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DIYRoomTemplateDatabase()
		{
		}

		// Token: 0x04009595 RID: 38293
		[Token(Token = "0x4009595")]
		private const string DEFAULT_ROOM_PATH = "default_room";

		// Token: 0x02001881 RID: 6273
		[Token(Token = "0x2001881")]
		private class Template : IDIYRoomTemplate
		{
			// Token: 0x170011CD RID: 4557
			// (get) Token: 0x06009EC3 RID: 40643 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011CD")]
			public string id
			{
				[Token(Token = "0x6009EC3")]
				[Address(RVA = "0x319F030", Offset = "0x319DC30", VA = "0x18319F030", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170011CE RID: 4558
			// (get) Token: 0x06009EC4 RID: 40644 RVA: 0x0003DF08 File Offset: 0x0003C108
			[Token(Token = "0x170011CE")]
			public int width
			{
				[Token(Token = "0x6009EC4")]
				[Address(RVA = "0x319F110", Offset = "0x319DD10", VA = "0x18319F110", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011CF RID: 4559
			// (get) Token: 0x06009EC5 RID: 40645 RVA: 0x0003DF20 File Offset: 0x0003C120
			[Token(Token = "0x170011CF")]
			public int height
			{
				[Token(Token = "0x6009EC5")]
				[Address(RVA = "0x319F000", Offset = "0x319DC00", VA = "0x18319F000", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011D0 RID: 4560
			// (get) Token: 0x06009EC6 RID: 40646 RVA: 0x0003DF38 File Offset: 0x0003C138
			[Token(Token = "0x170011D0")]
			public int depth
			{
				[Token(Token = "0x6009EC6")]
				[Address(RVA = "0x319EFD0", Offset = "0x319DBD0", VA = "0x18319EFD0", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170011D1 RID: 4561
			// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011D1")]
			public GameObject prefab
			{
				[Token(Token = "0x6009EC7")]
				[Address(RVA = "0x319F050", Offset = "0x319DC50", VA = "0x18319F050", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x06009EC8 RID: 40648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009EC8")]
			[Address(RVA = "0x319ED90", Offset = "0x319D990", VA = "0x18319ED90", Slot = "9")]
			public void ForEachObstacle(Action<Obstacle> action)
			{
			}

			// Token: 0x06009EC9 RID: 40649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009EC9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Template()
			{
			}

			// Token: 0x04009596 RID: 38294
			[Token(Token = "0x4009596")]
			[FieldOffset(Offset = "0x10")]
			public RoomSlotModel roomSlotModel;
		}
	}
}
