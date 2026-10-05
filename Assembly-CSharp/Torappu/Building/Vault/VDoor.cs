using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A6A RID: 6762
	[Token(Token = "0x2001A6A")]
	public class VDoor : MonoBehaviour
	{
		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x0600AA58 RID: 43608 RVA: 0x00041F70 File Offset: 0x00040170
		// (set) Token: 0x0600AA59 RID: 43609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001409")]
		public SharedConsts.LeftOrRight side
		{
			[Token(Token = "0x600AA58")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			get
			{
				return SharedConsts.LeftOrRight.LEFT;
			}
			[Token(Token = "0x600AA59")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA5A")]
		[Address(RVA = "0x325E720", Offset = "0x325D320", VA = "0x18325E720")]
		public void Locate(Vector3 worldPos, SharedConsts.LeftOrRight side)
		{
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA5B")]
		[Address(RVA = "0x325E6A0", Offset = "0x325D2A0", VA = "0x18325E6A0")]
		public void EnableOutline(bool value)
		{
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA5C")]
		[Address(RVA = "0x325E630", Offset = "0x325D230", VA = "0x18325E630")]
		private void Awake()
		{
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA5D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public VDoor()
		{
		}

		// Token: 0x0400A299 RID: 41625
		[Token(Token = "0x400A299")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SharedConsts.LeftOrRight _defaultSide;

		// Token: 0x0400A29A RID: 41626
		[Token(Token = "0x400A29A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _outlineObj;
	}
}
