using System;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public struct RaycastResult
	{
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000212")]
		public GameObject gameObject
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x17000213")]
		public bool isValid
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x5B924F0", Offset = "0x5B910F0", VA = "0x185B924F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x5B919C0", Offset = "0x5B905C0", VA = "0x185B919C0")]
		public void Clear()
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x5B91AB0", Offset = "0x5B906B0", VA = "0x185B91AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x0")]
		private GameObject m_GameObject;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x8")]
		public BaseRaycaster module;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x10")]
		public float distance;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x14")]
		public float index;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x18")]
		public int depth;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x1C")]
		public int sortingGroupID;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x20")]
		public int sortingGroupOrder;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x24")]
		public int sortingLayer;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x28")]
		public int sortingOrder;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 worldPosition;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 worldNormal;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 screenPosition;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x4C")]
		public int displayIndex;
	}
}
