using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020023C4 RID: 9156
	[Token(Token = "0x20023C4")]
	public class MountPoint : ILocatable
	{
		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x0600E8D7 RID: 59607 RVA: 0x000551B8 File Offset: 0x000533B8
		[Token(Token = "0x17001D6C")]
		public bool isValid
		{
			[Token(Token = "0x600E8D7")]
			[Address(RVA = "0x5DB200", Offset = "0x5D9E00", VA = "0x1805DB200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D6D")]
		public Entity entity
		{
			[Token(Token = "0x600E8D8")]
			[Address(RVA = "0x5DAFA0", Offset = "0x5D9BA0", VA = "0x1805DAFA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x0600E8D9 RID: 59609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D6E")]
		public Transform transform
		{
			[Token(Token = "0x600E8D9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x0600E8DA RID: 59610 RVA: 0x000551D0 File Offset: 0x000533D0
		[Token(Token = "0x17001D6F")]
		public Vector2 mapPosition
		{
			[Token(Token = "0x600E8DA")]
			[Address(RVA = "0x5DB2F0", Offset = "0x5D9EF0", VA = "0x1805DB2F0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x0600E8DB RID: 59611 RVA: 0x000551E8 File Offset: 0x000533E8
		[Token(Token = "0x17001D70")]
		public Vector3 mapPositionV3
		{
			[Token(Token = "0x600E8DB")]
			[Address(RVA = "0x5DB240", Offset = "0x5D9E40", VA = "0x1805DB240", Slot = "5")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x00055200 File Offset: 0x00053400
		[Token(Token = "0x17001D71")]
		public Vector3 worldPosition
		{
			[Token(Token = "0x600E8DC")]
			[Address(RVA = "0x5DB380", Offset = "0x5D9F80", VA = "0x1805DB380", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x0600E8DD RID: 59613 RVA: 0x00055218 File Offset: 0x00053418
		[Token(Token = "0x17001D72")]
		public GridPosition gridPosition
		{
			[Token(Token = "0x600E8DD")]
			[Address(RVA = "0x5DB090", Offset = "0x5D9C90", VA = "0x1805DB090", Slot = "7")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x0600E8DE RID: 59614 RVA: 0x00055230 File Offset: 0x00053430
		[Token(Token = "0x17001D73")]
		public float height
		{
			[Token(Token = "0x600E8DE")]
			[Address(RVA = "0x5DB160", Offset = "0x5D9D60", VA = "0x1805DB160", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x0600E8DF RID: 59615 RVA: 0x00055248 File Offset: 0x00053448
		[Token(Token = "0x17001D74")]
		public Vector2 faceTo
		{
			[Token(Token = "0x600E8DF")]
			[Address(RVA = "0x5DAFE0", Offset = "0x5D9BE0", VA = "0x1805DAFE0", Slot = "8")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600E8E0 RID: 59616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8E0")]
		[Address(RVA = "0x5DAF10", Offset = "0x5D9B10", VA = "0x1805DAF10")]
		public MountPoint(Entity entity, Transform transform)
		{
		}

		// Token: 0x040100C3 RID: 65731
		[Token(Token = "0x40100C3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MountPoint INVALID;

		// Token: 0x040100C4 RID: 65732
		[Token(Token = "0x40100C4")]
		[FieldOffset(Offset = "0x10")]
		private Transform m_transform;

		// Token: 0x040100C5 RID: 65733
		[Token(Token = "0x40100C5")]
		[FieldOffset(Offset = "0x18")]
		private ObjectPtr<Entity> m_entity;
	}
}
