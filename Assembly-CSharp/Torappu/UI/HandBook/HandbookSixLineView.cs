using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066A3 RID: 26275
	[Token(Token = "0x20066A3")]
	public class HandbookSixLineView : MonoBehaviour
	{
		// Token: 0x06025BE5 RID: 154597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BE5")]
		[Address(RVA = "0x20B4A70", Offset = "0x20B3670", VA = "0x1820B4A70")]
		public void Init(string powerId)
		{
		}

		// Token: 0x06025BE6 RID: 154598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BE6")]
		[Address(RVA = "0x20B4BC0", Offset = "0x20B37C0", VA = "0x1820B4BC0")]
		public void OnValueChanged(HandBookScrollViewProperty property)
		{
		}

		// Token: 0x06025BE7 RID: 154599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BE7")]
		[Address(RVA = "0x20B4DF0", Offset = "0x20B39F0", VA = "0x1820B4DF0")]
		public void SetLineState(int id, int state)
		{
		}

		// Token: 0x06025BE8 RID: 154600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BE8")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandbookSixLineView()
		{
		}

		// Token: 0x040350CE RID: 217294
		[Token(Token = "0x40350CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _sixLine;

		// Token: 0x040350CF RID: 217295
		[Token(Token = "0x40350CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite[] _sixLineSprite;

		// Token: 0x040350D0 RID: 217296
		[Token(Token = "0x40350D0")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Vector3 _initPos;
	}
}
