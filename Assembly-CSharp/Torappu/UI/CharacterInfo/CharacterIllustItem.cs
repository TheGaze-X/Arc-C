using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F51 RID: 24401
	[Token(Token = "0x2005F51")]
	public class CharacterIllustItem : MonoBehaviour
	{
		// Token: 0x0602354B RID: 144715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602354B")]
		[Address(RVA = "0x1DD6310", Offset = "0x1DD4F10", VA = "0x181DD6310")]
		public void OnClick()
		{
		}

		// Token: 0x0602354C RID: 144716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602354C")]
		[Address(RVA = "0x1DD62B0", Offset = "0x1DD4EB0", VA = "0x181DD62B0")]
		public void ApplyState(int index)
		{
		}

		// Token: 0x0602354D RID: 144717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602354D")]
		[Address(RVA = "0x1DD6200", Offset = "0x1DD4E00", VA = "0x181DD6200")]
		public void ApplyData(bool state, [Optional] Sprite illust, bool selected = false, int indexState = 0)
		{
		}

		// Token: 0x0602354E RID: 144718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602354E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterIllustItem()
		{
		}

		// Token: 0x04030C04 RID: 199684
		[Token(Token = "0x4030C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _unSelectedState;

		// Token: 0x04030C05 RID: 199685
		[Token(Token = "0x4030C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _SelectedState;

		// Token: 0x04030C06 RID: 199686
		[Token(Token = "0x4030C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unActive;

		// Token: 0x04030C07 RID: 199687
		[Token(Token = "0x4030C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _Active;

		// Token: 0x04030C08 RID: 199688
		[Token(Token = "0x4030C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _illust;

		// Token: 0x04030C09 RID: 199689
		[Token(Token = "0x4030C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<int> OnSelect;

		// Token: 0x04030C0A RID: 199690
		[Token(Token = "0x4030C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_cacheState;

		// Token: 0x04030C0B RID: 199691
		[Token(Token = "0x4030C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_state;
	}
}
