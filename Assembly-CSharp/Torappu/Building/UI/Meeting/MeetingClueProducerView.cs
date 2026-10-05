using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D68 RID: 7528
	[Token(Token = "0x2001D68")]
	public class MeetingClueProducerView : MonoBehaviour
	{
		// Token: 0x0600B9F2 RID: 47602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F2")]
		[Address(RVA = "0x3379880", Offset = "0x3378480", VA = "0x183379880")]
		public void Setup(ClueProducerInfo info)
		{
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MeetingClueProducerView()
		{
		}

		// Token: 0x0400B8BC RID: 47292
		[Token(Token = "0x400B8BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400B8BD RID: 47293
		[Token(Token = "0x400B8BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _level;

		// Token: 0x0400B8BE RID: 47294
		[Token(Token = "0x400B8BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _evolveIcon;
	}
}
