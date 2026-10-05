using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;

namespace Torappu.Scripts.UI.ConstructLand
{
	// Token: 0x020017AC RID: 6060
	[Token(Token = "0x20017AC")]
	public class ConstructLandFakeBlur : UIFakeBlur
	{
		// Token: 0x06009913 RID: 39187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009913")]
		[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
		public void Init(Canvas pageCanvas)
		{
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009914")]
		[Address(RVA = "0x313DCA0", Offset = "0x313C8A0", VA = "0x18313DCA0", Slot = "4")]
		protected override List<Camera> GetBlurCameras()
		{
			return null;
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009915")]
		[Address(RVA = "0x313DDC0", Offset = "0x313C9C0", VA = "0x18313DDC0")]
		public ConstructLandFakeBlur()
		{
		}

		// Token: 0x04008F37 RID: 36663
		[Token(Token = "0x4008F37")]
		[FieldOffset(Offset = "0x60")]
		private Canvas m_pageCanvas;
	}
}
