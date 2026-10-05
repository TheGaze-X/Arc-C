using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006201 RID: 25089
	[Token(Token = "0x2006201")]
	public class BattleFinishDropItemView : MonoBehaviour
	{
		// Token: 0x0602433E RID: 148286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602433E")]
		[Address(RVA = "0x1F13480", Offset = "0x1F12080", VA = "0x181F13480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602433F RID: 148287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602433F")]
		[Address(RVA = "0x1F13690", Offset = "0x1F12290", VA = "0x181F13690")]
		private IEnumerator _RenderAfterTime(float passTime)
		{
			return null;
		}

		// Token: 0x06024340 RID: 148288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024340")]
		[Address(RVA = "0x1F132C0", Offset = "0x1F11EC0", VA = "0x181F132C0")]
		public void Render(int index, bool isFirstDrop, UIItemViewModel itemModel, float passTime)
		{
		}

		// Token: 0x06024341 RID: 148289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024341")]
		[Address(RVA = "0x1F13630", Offset = "0x1F12230", VA = "0x181F13630")]
		private void _PlayItemDropSE()
		{
		}

		// Token: 0x06024342 RID: 148290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024342")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BattleFinishDropItemView()
		{
		}

		// Token: 0x0403255C RID: 206172
		[Token(Token = "0x403255C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _firstDropTag;

		// Token: 0x0403255D RID: 206173
		[Token(Token = "0x403255D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _cardScaleFactor;

		// Token: 0x0403255E RID: 206174
		[Token(Token = "0x403255E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403255F RID: 206175
		[Token(Token = "0x403255F")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_itemCard;

		// Token: 0x04032560 RID: 206176
		[Token(Token = "0x4032560")]
		[FieldOffset(Offset = "0x38")]
		private Animator m_animator;

		// Token: 0x04032561 RID: 206177
		[Token(Token = "0x4032561")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;
	}
}
