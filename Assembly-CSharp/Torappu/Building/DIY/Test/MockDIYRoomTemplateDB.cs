using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001912 RID: 6418
	[Token(Token = "0x2001912")]
	public class MockDIYRoomTemplateDB : MonoBehaviour, IDIYRoomTemplateProvider
	{
		// Token: 0x0600A1A0 RID: 41376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A0")]
		[Address(RVA = "0x31CD810", Offset = "0x31CC410", VA = "0x1831CD810", Slot = "4")]
		public void QueryData(Predicate<IDIYRoomTemplate> filter, Action<IDIYRoomTemplate> action)
		{
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A1")]
		[Address(RVA = "0x31CD8D0", Offset = "0x31CC4D0", VA = "0x1831CD8D0", Slot = "5")]
		public void QueryDatas(Predicate<IDIYRoomTemplate> filter, Action<IDIYRoomTemplate> action)
		{
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MockDIYRoomTemplateDB()
		{
		}

		// Token: 0x040097EC RID: 38892
		[Token(Token = "0x40097EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockDIYRoomTemplateDB.DIYRoomTemplate[] _templates;

		// Token: 0x02001913 RID: 6419
		[Token(Token = "0x2001913")]
		[Serializable]
		public class DIYRoomTemplate : IDIYRoomTemplate
		{
			// Token: 0x1700129D RID: 4765
			// (get) Token: 0x0600A1A3 RID: 41379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700129D")]
			public string id
			{
				[Token(Token = "0x600A1A3")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700129E RID: 4766
			// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x0003EF10 File Offset: 0x0003D110
			[Token(Token = "0x1700129E")]
			public int width
			{
				[Token(Token = "0x600A1A4")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700129F RID: 4767
			// (get) Token: 0x0600A1A5 RID: 41381 RVA: 0x0003EF28 File Offset: 0x0003D128
			[Token(Token = "0x1700129F")]
			public int height
			{
				[Token(Token = "0x600A1A5")]
				[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012A0 RID: 4768
			// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x0003EF40 File Offset: 0x0003D140
			[Token(Token = "0x170012A0")]
			public int depth
			{
				[Token(Token = "0x600A1A6")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012A1 RID: 4769
			// (get) Token: 0x0600A1A7 RID: 41383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012A1")]
			public GameObject prefab
			{
				[Token(Token = "0x600A1A7")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600A1A8 RID: 41384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1A8")]
			[Address(RVA = "0x31BF890", Offset = "0x31BE490", VA = "0x1831BF890", Slot = "9")]
			public void ForEachObstacle(Action<Obstacle> action)
			{
			}

			// Token: 0x0600A1A9 RID: 41385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1A9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DIYRoomTemplate()
			{
			}

			// Token: 0x040097ED RID: 38893
			[Token(Token = "0x40097ED")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _id;

			// Token: 0x040097EE RID: 38894
			[Token(Token = "0x40097EE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _width;

			// Token: 0x040097EF RID: 38895
			[Token(Token = "0x40097EF")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _height;

			// Token: 0x040097F0 RID: 38896
			[Token(Token = "0x40097F0")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private int _depth;

			// Token: 0x040097F1 RID: 38897
			[Token(Token = "0x40097F1")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _prefab;

			// Token: 0x040097F2 RID: 38898
			[Token(Token = "0x40097F2")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private MockDIYRoomTemplateDB.DIYRoomTemplate.RectConfig[] _obtacles;

			// Token: 0x02001914 RID: 6420
			[Token(Token = "0x2001914")]
			[Serializable]
			public class RectConfig
			{
				// Token: 0x0600A1AA RID: 41386 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A1AA")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RectConfig()
				{
				}

				// Token: 0x040097F3 RID: 38899
				[Token(Token = "0x40097F3")]
				[FieldOffset(Offset = "0x10")]
				public int x;

				// Token: 0x040097F4 RID: 38900
				[Token(Token = "0x40097F4")]
				[FieldOffset(Offset = "0x14")]
				public int y;

				// Token: 0x040097F5 RID: 38901
				[Token(Token = "0x40097F5")]
				[FieldOffset(Offset = "0x18")]
				public int z;

				// Token: 0x040097F6 RID: 38902
				[Token(Token = "0x40097F6")]
				[FieldOffset(Offset = "0x1C")]
				public int w;

				// Token: 0x040097F7 RID: 38903
				[Token(Token = "0x40097F7")]
				[FieldOffset(Offset = "0x20")]
				public int h;

				// Token: 0x040097F8 RID: 38904
				[Token(Token = "0x40097F8")]
				[FieldOffset(Offset = "0x24")]
				public int d;
			}
		}
	}
}
