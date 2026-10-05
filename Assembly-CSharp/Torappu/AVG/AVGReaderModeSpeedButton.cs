using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F64 RID: 8036
	[Token(Token = "0x2001F64")]
	public class AVGReaderModeSpeedButton : MonoBehaviour
	{
		// Token: 0x0600C7B6 RID: 51126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7B6")]
		[Address(RVA = "0x348D0B0", Offset = "0x348BCB0", VA = "0x18348D0B0")]
		public void SetSpeedImage(Sprite sprite)
		{
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x0600C7B7 RID: 51127 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600C7B8 RID: 51128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000069")]
		public event Action OnSpeedClicked
		{
			[Token(Token = "0x600C7B7")]
			[Address(RVA = "0x348D160", Offset = "0x348BD60", VA = "0x18348D160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600C7B8")]
			[Address(RVA = "0x348D200", Offset = "0x348BE00", VA = "0x18348D200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600C7B9 RID: 51129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7B9")]
		[Address(RVA = "0x5134F0", Offset = "0x5120F0", VA = "0x1805134F0")]
		public void OnButtonClicked()
		{
		}

		// Token: 0x0600C7BA RID: 51130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7BA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AVGReaderModeSpeedButton()
		{
		}

		// Token: 0x0400CDD0 RID: 52688
		[Token(Token = "0x400CDD0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _speedImage;
	}
}
