using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Medal.Test
{
	// Token: 0x020049B2 RID: 18866
	[Token(Token = "0x20049B2")]
	[ExecuteInEditMode]
	public class MedalGroupEditorView : MonoBehaviour
	{
		// Token: 0x0601C6D3 RID: 116435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MedalGroupEditorView()
		{
		}

		// Token: 0x040253D3 RID: 152531
		[Token(Token = "0x40253D3")]
		private const string BASIC_MEDAL_FRAME = "medalGroupActivityRune01";

		// Token: 0x040253D4 RID: 152532
		[Token(Token = "0x40253D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _medalContainer;

		// Token: 0x040253D5 RID: 152533
		[Token(Token = "0x40253D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _medalGroupId;
	}
}
