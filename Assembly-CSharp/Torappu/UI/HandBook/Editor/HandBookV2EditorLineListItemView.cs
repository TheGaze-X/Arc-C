using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x0200673C RID: 26428
	[Token(Token = "0x200673C")]
	public class HandBookV2EditorLineListItemView : MonoBehaviour
	{
		// Token: 0x170059CA RID: 22986
		// (get) Token: 0x06025E82 RID: 155266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025E83 RID: 155267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059CA")]
		public Action<int> onClick
		{
			[Token(Token = "0x6025E82")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025E83")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025E84 RID: 155268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E84")]
		[Address(RVA = "0x20D1BF0", Offset = "0x20D07F0", VA = "0x1820D1BF0")]
		public void ApplyData(int index, string displayStr)
		{
		}

		// Token: 0x06025E85 RID: 155269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E85")]
		[Address(RVA = "0x20D1C50", Offset = "0x20D0850", VA = "0x1820D1C50")]
		public void OnItemClick()
		{
		}

		// Token: 0x06025E86 RID: 155270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E86")]
		[Address(RVA = "0x20D1C70", Offset = "0x20D0870", VA = "0x1820D1C70")]
		public void SetSelect(bool isSelect)
		{
		}

		// Token: 0x06025E87 RID: 155271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E87")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookV2EditorLineListItemView()
		{
		}

		// Token: 0x040354DB RID: 218331
		[Token(Token = "0x40354DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgSelected;

		// Token: 0x040354DC RID: 218332
		[Token(Token = "0x40354DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLine;

		// Token: 0x040354DE RID: 218334
		[Token(Token = "0x40354DE")]
		[FieldOffset(Offset = "0x30")]
		private int m_index;
	}
}
