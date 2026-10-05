using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BEB RID: 27627
	[Token(Token = "0x2006BEB")]
	public class ArchiveQuestCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027732 RID: 161586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027732")]
		[Address(RVA = "0x229C8D0", Offset = "0x229B4D0", VA = "0x18229C8D0")]
		public void Render(Sprite imgChar)
		{
		}

		// Token: 0x06027733 RID: 161587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027733")]
		[Address(RVA = "0x229C950", Offset = "0x229B550", VA = "0x18229C950")]
		public ArchiveQuestCharItemView()
		{
		}

		// Token: 0x04037E55 RID: 228949
		[Token(Token = "0x4037E55")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x04037E56 RID: 228950
		[Token(Token = "0x4037E56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037E57 RID: 228951
		[Token(Token = "0x4037E57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
