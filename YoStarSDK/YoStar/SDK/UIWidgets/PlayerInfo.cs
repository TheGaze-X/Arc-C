using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public class PlayerInfo
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x5C2DC80", Offset = "0x5C2C880", VA = "0x185C2DC80")]
		public PlayerInfo(string tag)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public GameObject gameObject
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x5C2E170", Offset = "0x5C2CD70", VA = "0x185C2E170")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public Transform transform
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x5C2E230", Offset = "0x5C2CE30", VA = "0x185C2E230")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public Collider collider
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x5C2E090", Offset = "0x5C2CC90", VA = "0x185C2E090")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public Collider2D collider2D
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x5C2DFB0", Offset = "0x5C2CBB0", VA = "0x185C2DFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public Animator animator
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x5C2DD00", Offset = "0x5C2C900", VA = "0x185C2DD00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x1700005D")]
		public Bounds bounds
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x5C2DDE0", Offset = "0x5C2C9E0", VA = "0x185C2DDE0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x10")]
		private string m_Tag;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x18")]
		private GameObject m_GameObject;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Transform;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x30")]
		private Collider2D m_Collider2D;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x38")]
		private Animator m_Animator;
	}
}
