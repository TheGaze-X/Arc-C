using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B55 RID: 6997
	[Token(Token = "0x2001B55")]
	public class UIArchitectureRoomListLocator : MonoBehaviour
	{
		// Token: 0x0600AFC1 RID: 44993 RVA: 0x00043500 File Offset: 0x00041700
		[Token(Token = "0x600AFC1")]
		[Address(RVA = "0x32B8AD0", Offset = "0x32B76D0", VA = "0x1832B8AD0")]
		private float _EaseMoveConvert(float src)
		{
			return 0f;
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC2")]
		[Address(RVA = "0x32B88D0", Offset = "0x32B74D0", VA = "0x1832B88D0")]
		private void Update()
		{
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x00043518 File Offset: 0x00041718
		[Token(Token = "0x600AFC3")]
		[Address(RVA = "0x32B86C0", Offset = "0x32B72C0", VA = "0x1832B86C0")]
		public int SetFocusIndex(int index, bool easeMove = false)
		{
			return 0;
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC4")]
		[Address(RVA = "0x32B8B30", Offset = "0x32B7730", VA = "0x1832B8B30")]
		public UIArchitectureRoomListLocator()
		{
		}

		// Token: 0x0400A9CA RID: 43466
		[Token(Token = "0x400A9CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _easeMoveDuration;

		// Token: 0x0400A9CB RID: 43467
		[Token(Token = "0x400A9CB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _locationFactor;

		// Token: 0x0400A9CC RID: 43468
		[Token(Token = "0x400A9CC")]
		[FieldOffset(Offset = "0x20")]
		private float m_timer;

		// Token: 0x0400A9CD RID: 43469
		[Token(Token = "0x400A9CD")]
		[FieldOffset(Offset = "0x24")]
		private float m_basePosition;

		// Token: 0x0400A9CE RID: 43470
		[Token(Token = "0x400A9CE")]
		[FieldOffset(Offset = "0x28")]
		private float m_targetPosition;

		// Token: 0x0400A9CF RID: 43471
		[Token(Token = "0x400A9CF")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_easeMoving;
	}
}
