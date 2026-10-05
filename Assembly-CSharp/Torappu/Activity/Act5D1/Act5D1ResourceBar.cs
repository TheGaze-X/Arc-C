using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200720D RID: 29197
	[Token(Token = "0x200720D")]
	public class Act5D1ResourceBar : MonoBehaviour
	{
		// Token: 0x06029649 RID: 169545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029649")]
		[Address(RVA = "0x24C7B70", Offset = "0x24C6770", VA = "0x1824C7B70")]
		public void SetCoinPart(bool point = true, bool coin = true)
		{
		}

		// Token: 0x0602964A RID: 169546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602964A")]
		[Address(RVA = "0x24C7A70", Offset = "0x24C6670", VA = "0x1824C7A70")]
		public void RefreshCount()
		{
		}

		// Token: 0x0602964B RID: 169547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602964B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public Act5D1ResourceBar()
		{
		}

		// Token: 0x0403B201 RID: 242177
		[Token(Token = "0x403B201")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pointPart;

		// Token: 0x0403B202 RID: 242178
		[Token(Token = "0x403B202")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _coinPart;

		// Token: 0x0403B203 RID: 242179
		[Token(Token = "0x403B203")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _pointText;

		// Token: 0x0403B204 RID: 242180
		[Token(Token = "0x403B204")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _coinText;
	}
}
