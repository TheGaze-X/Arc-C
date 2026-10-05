using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public class AgreementTypeItemPanel : BasePanel
	{
		// Token: 0x06000937 RID: 2359 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x5C56060", Offset = "0x5C54C60", VA = "0x185C56060")]
		private new void Awake()
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public AgreementTypeItemPanel()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x50")]
		public Text typeText;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x58")]
		public Image bgImg;
	}
}
