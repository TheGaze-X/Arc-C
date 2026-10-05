using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x0200333C RID: 13116
	[Token(Token = "0x200333C")]
	public class UILifePointRL3 : MonoBehaviour
	{
		// Token: 0x06014EC4 RID: 85700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EC4")]
		[Address(RVA = "0xD5F900", Offset = "0xD5E500", VA = "0x180D5F900")]
		public void SetData(int lifePoint)
		{
		}

		// Token: 0x06014EC5 RID: 85701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EC5")]
		[Address(RVA = "0xD5FA40", Offset = "0xD5E640", VA = "0x180D5FA40")]
		public void UpdateData(int lifePoint)
		{
		}

		// Token: 0x06014EC6 RID: 85702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EC6")]
		[Address(RVA = "0xD5F800", Offset = "0xD5E400", VA = "0x180D5F800")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014EC7 RID: 85703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EC7")]
		[Address(RVA = "0xD5FD10", Offset = "0xD5E910", VA = "0x180D5FD10")]
		public UILifePointRL3()
		{
		}

		// Token: 0x04018E26 RID: 101926
		[Token(Token = "0x4018E26")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _tweenTime;

		// Token: 0x04018E27 RID: 101927
		[Token(Token = "0x4018E27")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _images;

		// Token: 0x04018E28 RID: 101928
		[Token(Token = "0x4018E28")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected UIAtlasImage _lifePointMask;

		// Token: 0x04018E29 RID: 101929
		[Token(Token = "0x4018E29")]
		[FieldOffset(Offset = "0x30")]
		private int m_lifePoint;
	}
}
