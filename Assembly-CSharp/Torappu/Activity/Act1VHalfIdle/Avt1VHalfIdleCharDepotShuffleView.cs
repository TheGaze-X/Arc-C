using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200774B RID: 30539
	[Token(Token = "0x200774B")]
	public class Avt1VHalfIdleCharDepotShuffleView : MonoBehaviour
	{
		// Token: 0x0602AE5E RID: 175710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE5E")]
		[Address(RVA = "0x26C2340", Offset = "0x26C0F40", VA = "0x1826C2340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AE5F RID: 175711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE5F")]
		[Address(RVA = "0x26C2200", Offset = "0x26C0E00", VA = "0x1826C2200")]
		public void OnRender(CharacterCardSortTypeViewModel sort, CharacterSortType sortType, bool forceResetTopShow, bool isTopShow, [Optional] UICharacterProfessionFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x0602AE60 RID: 175712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE60")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public Avt1VHalfIdleCharDepotShuffleView()
		{
		}

		// Token: 0x0403DDB1 RID: 253361
		[Token(Token = "0x403DDB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharacterSortTypeGroup _sortTypeGrp;

		// Token: 0x0403DDB2 RID: 253362
		[Token(Token = "0x403DDB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharacterSortFilterPanel _sortFilterPanel;

		// Token: 0x0403DDB3 RID: 253363
		[Token(Token = "0x403DDB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<CharacterSortType> onSetSortType;

		// Token: 0x0403DDB4 RID: 253364
		[Token(Token = "0x403DDB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<UICharacterProfessionFilterHolder.FilterParam> onSetFilter;

		// Token: 0x0403DDB5 RID: 253365
		[Token(Token = "0x403DDB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0403DDB6 RID: 253366
		[Token(Token = "0x403DDB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_isInited;
	}
}
