using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200193B RID: 6459
	[Token(Token = "0x200193B")]
	public class DIYFilterButton : MonoBehaviour
	{
		// Token: 0x14000042 RID: 66
		// (add) Token: 0x0600A276 RID: 41590 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A277 RID: 41591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000042")]
		public event Action<DIYFilterButton> onButtonPressed
		{
			[Token(Token = "0x600A276")]
			[Address(RVA = "0x31BD2E0", Offset = "0x31BBEE0", VA = "0x1831BD2E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A277")]
			[Address(RVA = "0x31BD390", Offset = "0x31BBF90", VA = "0x1831BD390")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x0600A278 RID: 41592 RVA: 0x0003F450 File Offset: 0x0003D650
		[Token(Token = "0x170012DA")]
		public bool actived
		{
			[Token(Token = "0x600A278")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A279")]
		[Address(RVA = "0x31BD200", Offset = "0x31BBE00", VA = "0x1831BD200")]
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x0600A27A RID: 41594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A27A")]
		[Address(RVA = "0x31BD1E0", Offset = "0x31BBDE0", VA = "0x1831BD1E0")]
		public void OnButtonPressed()
		{
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A27B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DIYFilterButton()
		{
		}

		// Token: 0x040098C1 RID: 39105
		[Token(Token = "0x40098C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _activeObjects;

		// Token: 0x040098C2 RID: 39106
		[Token(Token = "0x40098C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _inactiveObjects;

		// Token: 0x040098C4 RID: 39108
		[Token(Token = "0x40098C4")]
		[FieldOffset(Offset = "0x30")]
		private bool m_actived;
	}
}
