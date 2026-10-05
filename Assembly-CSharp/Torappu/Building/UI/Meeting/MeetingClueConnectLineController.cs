using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D65 RID: 7525
	[Token(Token = "0x2001D65")]
	public class MeetingClueConnectLineController : MonoBehaviour
	{
		// Token: 0x0600B9E1 RID: 47585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9E1")]
		[Address(RVA = "0x3378C90", Offset = "0x3377890", VA = "0x183378C90")]
		public void Setup(List<int> activePins)
		{
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9E2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MeetingClueConnectLineController()
		{
		}

		// Token: 0x0400B8A9 RID: 47273
		[Token(Token = "0x400B8A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _pins;

		// Token: 0x0400B8AA RID: 47274
		[Token(Token = "0x400B8AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MeetingClueConnectLineController.Line> _lines;

		// Token: 0x02001D66 RID: 7526
		[Token(Token = "0x2001D66")]
		[Serializable]
		public class Line
		{
			// Token: 0x0600B9E3 RID: 47587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9E3")]
			[Address(RVA = "0x3372BF0", Offset = "0x33717F0", VA = "0x183372BF0")]
			public void Setup(List<int> activeLines)
			{
			}

			// Token: 0x0600B9E4 RID: 47588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9E4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Line()
			{
			}

			// Token: 0x0400B8AB RID: 47275
			[Token(Token = "0x400B8AB")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _line;

			// Token: 0x0400B8AC RID: 47276
			[Token(Token = "0x400B8AC")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _pinIndex0;

			// Token: 0x0400B8AD RID: 47277
			[Token(Token = "0x400B8AD")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _pinIndex1;
		}
	}
}
