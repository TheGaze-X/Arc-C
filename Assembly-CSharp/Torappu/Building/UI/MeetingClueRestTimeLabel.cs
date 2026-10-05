using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B27 RID: 6951
	[Token(Token = "0x2001B27")]
	public class MeetingClueRestTimeLabel : MonoBehaviour
	{
		// Token: 0x14000057 RID: 87
		// (add) Token: 0x0600AF00 RID: 44800 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600AF01 RID: 44801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000057")]
		public event Action expiredUpdate
		{
			[Token(Token = "0x600AF00")]
			[Address(RVA = "0x329D440", Offset = "0x329C040", VA = "0x18329D440")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600AF01")]
			[Address(RVA = "0x329D4E0", Offset = "0x329C0E0", VA = "0x18329D4E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF02")]
		[Address(RVA = "0x329D0C0", Offset = "0x329BCC0", VA = "0x18329D0C0")]
		public void Setup(DateTime expireTime)
		{
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF03")]
		[Address(RVA = "0x329D0E0", Offset = "0x329BCE0", VA = "0x18329D0E0")]
		public void Unsetup()
		{
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF04")]
		[Address(RVA = "0x329D2C0", Offset = "0x329BEC0", VA = "0x18329D2C0")]
		private void _RefreshRestTime()
		{
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF05")]
		[Address(RVA = "0x329D260", Offset = "0x329BE60", VA = "0x18329D260")]
		private void Update()
		{
		}

		// Token: 0x0600AF06 RID: 44806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF06")]
		[Address(RVA = "0x156D000", Offset = "0x156BC00", VA = "0x18156D000")]
		public MeetingClueRestTimeLabel()
		{
		}

		// Token: 0x0400A853 RID: 43091
		[Token(Token = "0x400A853")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _label;

		// Token: 0x0400A854 RID: 43092
		[Token(Token = "0x400A854")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x0400A855 RID: 43093
		[Token(Token = "0x400A855")]
		[FieldOffset(Offset = "0x24")]
		private float m_timer;

		// Token: 0x0400A856 RID: 43094
		[Token(Token = "0x400A856")]
		[FieldOffset(Offset = "0x28")]
		private bool m_setup;

		// Token: 0x0400A857 RID: 43095
		[Token(Token = "0x400A857")]
		[FieldOffset(Offset = "0x30")]
		private DateTime m_expiredTime;
	}
}
