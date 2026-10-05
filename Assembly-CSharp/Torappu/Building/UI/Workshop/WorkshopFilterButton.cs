using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BF2 RID: 7154
	[Token(Token = "0x2001BF2")]
	public class WorkshopFilterButton : MonoBehaviour
	{
		// Token: 0x1400005A RID: 90
		// (add) Token: 0x0600B267 RID: 45671 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B268 RID: 45672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005A")]
		public event Action<WorkshopFilterButton> onButtonPressed
		{
			[Token(Token = "0x600B267")]
			[Address(RVA = "0x32EA8D0", Offset = "0x32E94D0", VA = "0x1832EA8D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B268")]
			[Address(RVA = "0x32EA980", Offset = "0x32E9580", VA = "0x1832EA980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x0600B269 RID: 45673 RVA: 0x00044070 File Offset: 0x00042270
		[Token(Token = "0x17001552")]
		public bool actived
		{
			[Token(Token = "0x600B269")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B26A")]
		[Address(RVA = "0x31BD200", Offset = "0x31BBE00", VA = "0x1831BD200")]
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B26B")]
		[Address(RVA = "0x31BD1E0", Offset = "0x31BBDE0", VA = "0x1831BD1E0")]
		public void OnButtonPressed()
		{
		}

		// Token: 0x0600B26C RID: 45676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B26C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public WorkshopFilterButton()
		{
		}

		// Token: 0x0400AD7A RID: 44410
		[Token(Token = "0x400AD7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _activeObjects;

		// Token: 0x0400AD7B RID: 44411
		[Token(Token = "0x400AD7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _inactiveObjects;

		// Token: 0x0400AD7D RID: 44413
		[Token(Token = "0x400AD7D")]
		[FieldOffset(Offset = "0x30")]
		private bool m_actived;
	}
}
