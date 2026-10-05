using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x0200187E RID: 6270
	[Token(Token = "0x200187E")]
	public class DIYRoomPrefabSettings : MonoBehaviour
	{
		// Token: 0x06009EBE RID: 40638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EBE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DIYRoomPrefabSettings()
		{
		}

		// Token: 0x04009580 RID: 38272
		[Token(Token = "0x4009580")]
		[FieldOffset(Offset = "0x18")]
		public Renderer wallRenderer;

		// Token: 0x04009581 RID: 38273
		[Token(Token = "0x4009581")]
		[FieldOffset(Offset = "0x20")]
		public MeshFilter wallMeshFilter;

		// Token: 0x04009582 RID: 38274
		[Token(Token = "0x4009582")]
		[FieldOffset(Offset = "0x28")]
		public Renderer floorRenderer;

		// Token: 0x04009583 RID: 38275
		[Token(Token = "0x4009583")]
		[FieldOffset(Offset = "0x30")]
		public MeshFilter floorMeshFilter;

		// Token: 0x04009584 RID: 38276
		[Token(Token = "0x4009584")]
		[FieldOffset(Offset = "0x38")]
		public MeshRenderer reflectCameraBound;

		// Token: 0x04009585 RID: 38277
		[Token(Token = "0x4009585")]
		[FieldOffset(Offset = "0x40")]
		public MeshFilter floorGridMeshFilter;

		// Token: 0x04009586 RID: 38278
		[Token(Token = "0x4009586")]
		[FieldOffset(Offset = "0x48")]
		public MeshFilter wallGridMeshFilter;

		// Token: 0x04009587 RID: 38279
		[Token(Token = "0x4009587")]
		[FieldOffset(Offset = "0x50")]
		public MeshFilter ceilingGridMeshFilter;

		// Token: 0x04009588 RID: 38280
		[Token(Token = "0x4009588")]
		[FieldOffset(Offset = "0x58")]
		public MeshFilter ceilingGridMaskMeshFilter;

		// Token: 0x04009589 RID: 38281
		[Token(Token = "0x4009589")]
		[FieldOffset(Offset = "0x60")]
		public Renderer leftDoorRenderer;

		// Token: 0x0400958A RID: 38282
		[Token(Token = "0x400958A")]
		[FieldOffset(Offset = "0x68")]
		public Renderer rightDoorRenderer;

		// Token: 0x0400958B RID: 38283
		[Token(Token = "0x400958B")]
		[FieldOffset(Offset = "0x70")]
		public DIYRoomPrefabSettings.ObstacleItem[] obstacles;

		// Token: 0x0400958C RID: 38284
		[Token(Token = "0x400958C")]
		[FieldOffset(Offset = "0x78")]
		public Transform overrideLeftDoorTransform;

		// Token: 0x0400958D RID: 38285
		[Token(Token = "0x400958D")]
		[FieldOffset(Offset = "0x80")]
		public Transform overrideRightDoorTransform;

		// Token: 0x0400958E RID: 38286
		[Token(Token = "0x400958E")]
		[FieldOffset(Offset = "0x88")]
		public GameObject frame;

		// Token: 0x0200187F RID: 6271
		[Token(Token = "0x200187F")]
		[Serializable]
		public class ObstacleItem
		{
			// Token: 0x06009EBF RID: 40639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009EBF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ObstacleItem()
			{
			}

			// Token: 0x0400958F RID: 38287
			[Token(Token = "0x400958F")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x04009590 RID: 38288
			[Token(Token = "0x4009590")]
			[FieldOffset(Offset = "0x14")]
			public int y;

			// Token: 0x04009591 RID: 38289
			[Token(Token = "0x4009591")]
			[FieldOffset(Offset = "0x18")]
			public int z;

			// Token: 0x04009592 RID: 38290
			[Token(Token = "0x4009592")]
			[FieldOffset(Offset = "0x1C")]
			public int w;

			// Token: 0x04009593 RID: 38291
			[Token(Token = "0x4009593")]
			[FieldOffset(Offset = "0x20")]
			public int h;

			// Token: 0x04009594 RID: 38292
			[Token(Token = "0x4009594")]
			[FieldOffset(Offset = "0x24")]
			public int d;
		}
	}
}
